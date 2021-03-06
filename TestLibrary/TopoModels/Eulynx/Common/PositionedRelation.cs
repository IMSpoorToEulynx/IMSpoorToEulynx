﻿using Models.TopoModels.Eulynx;
using Models.TopoModels.IMSpoor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.TopoModels.Eulynx
{
    internal enum RelationDirection{
        ONWARDS, BACKWARDS
    }

    internal class MicroLinkRelation
    {
        public MicroLink MicroLink { get; set; }

        public Navigability Navigability { get; set; }
        public RelationDirection RelationDirection { get; set; }
    }

    public partial class PositionedRelation
    {
        private MicroLinkRelation yoWhichTrackDoesThisPortHave(RailTopology railTopology, String junction, int port)
        {
            MicroLink yoIFoundThisOne = null;
            RelationDirection relationDirection = RelationDirection.ONWARDS;
            
            MicroLink[] allTracks = railTopology.MicroLinks;

            foreach(MicroLink track in allTracks)
            {
                if(track.FromMicroNode.nodeRef == junction && track.FromMicroNode.portIndex == port)
                {
                    yoIFoundThisOne = track;
                    relationDirection = RelationDirection.ONWARDS;
                    break;
                }else if(track.ToMicroNode.nodeRef == junction && track.ToMicroNode.portIndex == port)
                {
                    yoIFoundThisOne = track;
                    relationDirection = RelationDirection.BACKWARDS;
                    break;
                }
            }

            return new MicroLinkRelation()
            {
                MicroLink = yoIFoundThisOne,
                RelationDirection = relationDirection
            };
        }

        private IList<MicroLinkRelation> whereCanIGoThroughThisPort(RailTopology railTopology, String junction, int port)
        {
            IList<MicroLinkRelation> tracksToGoTo = new List<MicroLinkRelation>();

            MicroNode[] allNodes = railTopology.MicroNodes;

            foreach(MicroNode node in allNodes)
            {
                if (node.Jumpers == null) continue;
                if (node.junctionRef != junction) continue;

                foreach(Jumper jumper in node.Jumpers)
                {
                    int otherPort;
                    if (port == jumper.fromIndex)
                    {
                        otherPort = jumper.toIndex;
                    }
                    else if(port == jumper.toIndex)
                    {
                        otherPort = jumper.fromIndex;
                    }
                    else
                    {
                        continue;
                    }

                    MicroLinkRelation trackOnOtherSideOfPort = yoWhichTrackDoesThisPortHave(railTopology, junction, otherPort);

                    if(trackOnOtherSideOfPort.MicroLink == null) // There is no track on other side of this junction port.. huh?
                    {
                        continue;
                    }

                    MicroLinkRelation trackRelation = new MicroLinkRelation() {
                        MicroLink = trackOnOtherSideOfPort.MicroLink,
                        Navigability = Navigability.Both,
                        RelationDirection = trackOnOtherSideOfPort.RelationDirection
                    };

                    tracksToGoTo.Add(trackRelation);
                }
            }

            return tracksToGoTo;
        }

        private IList<PositionedRelation> getPositionedRelationsForThisPort(RailTopology railTopology, tNodePort nodePort, MicroLink currentTrack, RelationDirection relationDirection)
        {
            IList<PositionedRelation> positionedRelations = new List<PositionedRelation>();

            IList<MicroLinkRelation> tracksToGoTo = whereCanIGoThroughThisPort(railTopology, nodePort.nodeRef, nodePort.portIndex);

            foreach (MicroLinkRelation tToGoToRelation in tracksToGoTo)
            {
                MicroLink tToGoTo = tToGoToRelation.MicroLink;

                if (tToGoTo == currentTrack) continue; // u cant go towards yourself weirdo that'd be very weird

                PositionedRelation trackRelation = new PositionedRelation();
                trackRelation.elementA = new tElementWithIDref() { @ref = currentTrack.trackFunctionalViewRef };
                trackRelation.elementB = new tElementWithIDref() { @ref = tToGoTo.trackFunctionalViewRef };
                trackRelation.name = "-";
                trackRelation.navigability = tToGoToRelation.Navigability;
                trackRelation.positionOnA = relationDirection == RelationDirection.ONWARDS ? Usage.start : Usage.end; // Current track
                trackRelation.positionOnB = tToGoToRelation.RelationDirection == RelationDirection.ONWARDS ? Usage.start : Usage.end;

                positionedRelations.Add(trackRelation);
            }

            return positionedRelations;
        }

        private IList<PositionedRelation> AddRangeDistinct(IList<PositionedRelation> sourceList, IList<PositionedRelation> addingList)
        {
            foreach(PositionedRelation addition in addingList)
            {
                bool duplicate = false;
                foreach(PositionedRelation checking in sourceList)
                {
                    if (addition.IsDuplicate(checking))
                    {
                        duplicate = true;
                        break;
                    }
                }

                if (!duplicate)
                {
                    sourceList.Add(addition);
                }
            }
            return sourceList;
        }

        private bool IsDuplicate(PositionedRelation other)
        {
            if((this.elementA.@ref == other.elementA.@ref
                        && this.elementB.@ref == other.elementB.@ref)
                    || (this.elementA.@ref == other.elementB.@ref
                        && this.elementB.@ref == other.elementA.@ref)
                    || (this.elementA.@ref == other.elementA.@ref
                        && this.elementB.@ref == other.elementA.@ref)
                    || (this.elementA.@ref == other.elementB.@ref
                        && this.elementB.@ref == other.elementB.@ref))
            {
                return true;
            }
            return false;
        }

        public PositionedRelation[] TranslateMultiple(RailTopology railTopology)
        {
            IList<PositionedRelation> positionedRelations = new List<PositionedRelation>();

            foreach(MicroLink currentTrack in railTopology.MicroLinks)
            {
                IList<PositionedRelation> relationsAtFromPort = getPositionedRelationsForThisPort(railTopology, currentTrack.FromMicroNode, currentTrack, RelationDirection.ONWARDS);
                IList<PositionedRelation> relationsAtToPort = getPositionedRelationsForThisPort(railTopology, currentTrack.ToMicroNode, currentTrack, RelationDirection.BACKWARDS);

                positionedRelations = AddRangeDistinct(positionedRelations, relationsAtFromPort);
                positionedRelations = AddRangeDistinct(positionedRelations, relationsAtToPort);
            }

            return positionedRelations.ToArray();
        }
    }
}
