 
using System; 
using System.Collections.Generic; 
using System.Text; using System.IO; 
using System.Xml.Serialization; 
using System.Linq;
     
using Models.TopoModels.EULYNX.rtmNE;
     
using Models.TopoModels.EULYNX.rtmCommon;
     
using Models.TopoModels.EULYNX.rtmSig;
     
using Models.TopoModels.EULYNX.sig;
     
using dp = Models.TopoModels.EULYNX.dp;

namespace Models.TopoModels.EULYNX.dp {
    
        /** 
        The xml instance is based on an XSD that matches the given UML baseline.  
The baseline uses a numbering schema like so:
major=1
minor=2 
editorial=1
applicability=A 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DataPrep")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DataPrep",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(dp.PackageBaseline))]     
        public  partial class Baseline
        {
            [XmlElementAttribute("applicability", Order=1)]
            public String applicability= "";
                
            [XmlElementAttribute("editorial", Order=2)]
            public Int32 editorial {get; set;} = new Int32();
                
            [XmlElementAttribute("major", Order=3)]
            public Int32 major {get; set;} = new Int32();
                
            [XmlElementAttribute("minor", Order=4)]
            public Int32 minor {get; set;} = new Int32();
                
             
        }  
    
        /** 
        root element of an EULYNX XML. This is an instance of the XSD produced by EULYNX DP. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DataPrep")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DataPrep",IsNullable=false)] 
             
        public  partial class EulynxDataPrep
        {
            [XmlElementAttribute("isReleaseVersion", Order=1)]
            public Version isReleaseVersion {get; set;} = new Version();
                
            [XmlElementAttribute("ownsRtmEntities", Order=2)]
            public RtmEntities ownsRtmEntities {get; set;} = new RtmEntities();
                
            [XmlElementAttribute("ownsSignallingEntities", Order=3)]
            public SignallingEntities ownsSignallingEntities {get; set;} = new SignallingEntities();
                
             
        }  
    
        /** 
        A baseline applying to a package in the given national domain. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DataPrep")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DataPrep",IsNullable=false)] 
             
        public  partial class PackageBaseline: dp.Baseline
        {
            [XmlElementAttribute("appliesToNationalDomain", Order=1)]
            public NationalDomains appliesToNationalDomain {get; set;} = new NationalDomains();
                
             
        }  
    
        /** 
        Container for entities defined in the RSM namespace. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DataPrep")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DataPrep",IsNullable=false)] 
             
        public  partial class RtmEntities: sig.BaseObject
        {
            [XmlElementAttribute("ownsBufferstop", Order=1)]
            public List<rtmSig.VehicleStop> ownsBufferstop { get; set; } = new List<rtmSig.VehicleStop>(); 
                
            [XmlElementAttribute("ownsPoint", Order=2)]
            public List<rtmSig.Turnout> ownsPoint { get; set; } = new List<rtmSig.Turnout>(); 
                
            [XmlElementAttribute("ownsRouteBody", Order=3)]
            public List<rtmSig.RouteBody> ownsRouteBody { get; set; } = new List<rtmSig.RouteBody>(); 
                
            [XmlElementAttribute("ownsSignal", Order=4)]
            public List<rtmSig.Signal> ownsSignal { get; set; } = new List<rtmSig.Signal>(); 
                
            [XmlElementAttribute("usesAlignmentCurve", Order=5)]
            public List<rtmCommon.AlignmentCurve> usesAlignmentCurve { get; set; } = new List<rtmCommon.AlignmentCurve>(); 
                
            [XmlElementAttribute("usesCablingTopology", Order=6)]
            public Topology usesCablingTopology {get; set;} = new Topology();
                
            [XmlElementAttribute("usesEtcsTopology", Order=7)]
            public Topology usesEtcsTopology {get; set;} = new Topology();
                
            [XmlElementAttribute("usesHorizontalAlignmentSegment", Order=8)]
            public List<rtmCommon.HorizontalAlignmentSegment> usesHorizontalAlignmentSegment { get; set; } = new List<rtmCommon.HorizontalAlignmentSegment>(); 
                
            [XmlElementAttribute("usesLinearLocation", Order=9)]
            public List<rtmCommon.LinearLocation> usesLinearLocation { get; set; } = new List<rtmCommon.LinearLocation>(); 
                
            [XmlElementAttribute("usesPositioningSystem", Order=10)]
            public List<rtmCommon.PositioningSystem> usesPositioningSystem { get; set; } = new List<rtmCommon.PositioningSystem>(); 
                
            [XmlElementAttribute("usesPositioningSystemCoordinate", Order=11)]
            public List<rtmCommon.PositioningSystemCoordinate> usesPositioningSystemCoordinate { get; set; } = new List<rtmCommon.PositioningSystemCoordinate>(); 
                
            [XmlElementAttribute("usesQuantityKind", Order=12)]
            public List<rtmCommon.QuantityKind> usesQuantityKind { get; set; } = new List<rtmCommon.QuantityKind>(); 
                
            [XmlElementAttribute("usesSpotLocation", Order=13)]
            public List<rtmCommon.SpotLocation> usesSpotLocation { get; set; } = new List<rtmCommon.SpotLocation>(); 
                
            [XmlElementAttribute("usesTrackTopology", Order=14)]
            public Topology usesTrackTopology {get; set;} = new Topology();
                
            [XmlElementAttribute("usesUnit", Order=15)]
            public List<rtmCommon.Unit> usesUnit { get; set; } = new List<rtmCommon.Unit>(); 
                
            [XmlElementAttribute("usesVerticalAlignmentSegment", Order=16)]
            public List<rtmCommon.VerticalAlignmentSegment> usesVerticalAlignmentSegment { get; set; } = new List<rtmCommon.VerticalAlignmentSegment>(); 
                
             
        }  
    
        public partial class SignallingEntities
        {
            internal string AddObject(Object myObject, string id = null)
            {
                switch (myObject)
                {
                
                    case sig.AssetAndState myAssetAndState:
                        if (!knowsAssetAndState.Contains(myAssetAndState)) knowsAssetAndState.Append(myObject);
                        break;
                
                    case sig.Annotation myAnnotation:
                        if (!ownsAnnotation.Contains(myAnnotation)) ownsAnnotation.Append(myObject);
                        break;
                
                    case sig.Aspect myAspect:
                        if (!ownsAspect.Contains(myAspect)) ownsAspect.Append(myObject);
                        break;
                
                    case sig.AspectProving myAspectProving:
                        if (!ownsAspectProving.Contains(myAspectProving)) ownsAspectProving.Append(myObject);
                        break;
                
                    case sig.AssetUser myAssetUser:
                        if (!ownsAssetUser.Contains(myAssetUser)) ownsAssetUser.Append(myObject);
                        break;
                
                    case sig.TpsProtectionDistance myTpsProtectionDistance:
                        if (!ownsAtpProtectiveDistance.Contains(myTpsProtectionDistance)) ownsAtpProtectiveDistance.Append(myObject);
                        break;
                
                    case sig.Attachment myAttachment:
                        if (!ownsAttachmentDocument.Contains(myAttachment)) ownsAttachmentDocument.Append(myObject);
                        break;
                
                    case sig.Automatic myAutomatic:
                        if (!ownsAutomatic.Contains(myAutomatic)) ownsAutomatic.Append(myObject);
                        break;
                
                    case sig.BackToBackLocking myBackToBackLocking:
                        if (!ownsBackToBackLocking.Contains(myBackToBackLocking)) ownsBackToBackLocking.Append(myObject);
                        break;
                
                    case sig.BaselineOfRuleSet myBaselineOfRuleSet:
                        if (!ownsBaselineOfRuleSet.Contains(myBaselineOfRuleSet)) ownsBaselineOfRuleSet.Append(myObject);
                        break;
                
                    case sig.BlockSystem myBlockSystem:
                        if (!ownsBlockSystem.Contains(myBlockSystem)) ownsBlockSystem.Append(myObject);
                        break;
                
                    case sig.Cable myCable:
                        if (!ownsCable.Contains(myCable)) ownsCable.Append(myObject);
                        break;
                
                    case sig.CableRoute myCableRoute:
                        if (!ownsCableDuct.Contains(myCableRoute)) ownsCableDuct.Append(myObject);
                        break;
                
                    case sig.CableJoint myCableJoint:
                        if (!ownsCableJoint.Contains(myCableJoint)) ownsCableJoint.Append(myObject);
                        break;
                
                    case sig.CableJointInstallation myCableJointInstallation:
                        if (!ownsCableJointInstallation.Contains(myCableJointInstallation)) ownsCableJointInstallation.Append(myObject);
                        break;
                
                    case sig.CableProperties myCableProperties:
                        if (!ownsCableProperties.Contains(myCableProperties)) ownsCableProperties.Append(myObject);
                        break;
                
                    case sig.CableRouteJunction myCableRouteJunction:
                        if (!ownsCableRouteJunction.Contains(myCableRouteJunction)) ownsCableRouteJunction.Append(myObject);
                        break;
                
                    case sig.ChangeMarker myChangeMarker:
                        if (!ownsChangeMarker.Contains(myChangeMarker)) ownsChangeMarker.Append(myObject);
                        break;
                
                    case sig.CivilStructure myCivilStructure:
                        if (!ownsCivilStructure.Contains(myCivilStructure)) ownsCivilStructure.Append(myObject);
                        break;
                
                    case sig.CompositeRoute myCompositeRoute:
                        if (!ownsCompositeRoute.Contains(myCompositeRoute)) ownsCompositeRoute.Append(myObject);
                        break;
                
                    case sig.ConditionSectionsClear myConditionSectionsClear:
                        if (!ownsConditionSectionsClear.Contains(myConditionSectionsClear)) ownsConditionSectionsClear.Append(myObject);
                        break;
                
                    case sig.ConflictingRoute myConflictingRoute:
                        if (!ownsConflictingRoute.Contains(myConflictingRoute)) ownsConflictingRoute.Append(myObject);
                        break;
                
                    case sig.ControlArea myControlArea:
                        if (!ownsControlArea.Contains(myControlArea)) ownsControlArea.Append(myObject);
                        break;
                
                    case sig.ControlRelation myControlRelation:
                        if (!ownsControlRelation.Contains(myControlRelation)) ownsControlRelation.Append(myObject);
                        break;
                
                    case sig.ControlledTrackAsset myControlledTrackAsset:
                        if (!ownsControlledTrackAsset.Contains(myControlledTrackAsset)) ownsControlledTrackAsset.Append(myObject);
                        break;
                
                    case sig.DirectionAuthorityDependentOverlap myDirectionAuthorityDependentOverlap:
                        if (!ownsDADoverlap.Contains(myDirectionAuthorityDependentOverlap)) ownsDADoverlap.Append(myObject);
                        break;
                
                    case sig.DangerAreaTrack myDangerAreaTrack:
                        if (!ownsDangerAreaTrack.Contains(myDangerAreaTrack)) ownsDangerAreaTrack.Append(myObject);
                        break;
                
                    case sig.Description myDescription:
                        if (!ownsDescription.Contains(myDescription)) ownsDescription.Append(myObject);
                        break;
                
                    case sig.DispatchAnnouncerAssignment myDispatchAnnouncerAssignment:
                        if (!ownsDispatchAnnouncerAssignment.Contains(myDispatchAnnouncerAssignment)) ownsDispatchAnnouncerAssignment.Append(myObject);
                        break;
                
                    case sig.EquipmentSupport myEquipmentSupport:
                        if (!ownsEquipmentSupport.Contains(myEquipmentSupport)) ownsEquipmentSupport.Append(myObject);
                        break;
                
                    case sig.FlankProtection myFlankProtection:
                        if (!ownsFlankProtection.Contains(myFlankProtection)) ownsFlankProtection.Append(myObject);
                        break;
                
                    case sig.FoulTrackControl myFoulTrackControl:
                        if (!ownsFoulTrackControl.Contains(myFoulTrackControl)) ownsFoulTrackControl.Append(myObject);
                        break;
                
                    case sig.Illumination myIllumination:
                        if (!ownsIllumination.Contains(myIllumination)) ownsIllumination.Append(myObject);
                        break;
                
                    case sig.InfrastructureBorder myInfrastructureBorder:
                        if (!ownsInfrastructureBorder.Contains(myInfrastructureBorder)) ownsInfrastructureBorder.Append(myObject);
                        break;
                
                    case sig.IntentionallyDarkAllowed myIntentionallyDarkAllowed:
                        if (!ownsIntentionallyDarkAllowed.Contains(myIntentionallyDarkAllowed)) ownsIntentionallyDarkAllowed.Append(myObject);
                        break;
                
                    case sig.Key myKey:
                        if (!ownsKey.Contains(myKey)) ownsKey.Append(myObject);
                        break;
                
                    case sig.LensDiffuser myLensDiffuser:
                        if (!ownsLensDiffuser.Contains(myLensDiffuser)) ownsLensDiffuser.Append(myObject);
                        break;
                
                    case sig.LevelCrossingActivation myLevelCrossingActivation:
                        if (!ownsLevelCrossingActivation.Contains(myLevelCrossingActivation)) ownsLevelCrossingActivation.Append(myObject);
                        break;
                
                    case sig.LevelCrossingDeactivation myLevelCrossingDeactivation:
                        if (!ownsLevelCrossingDeactivation.Contains(myLevelCrossingDeactivation)) ownsLevelCrossingDeactivation.Append(myObject);
                        break;
                
                    case sig.LevelCrossingLocalOperationUiElement myLevelCrossingLocalOperationUiElement:
                        if (!ownsLevelCrossingLocalOperationUiElement.Contains(myLevelCrossingLocalOperationUiElement)) ownsLevelCrossingLocalOperationUiElement.Append(myObject);
                        break;
                
                    case sig.LevelCrossingRouteRelation myLevelCrossingRouteRelation:
                        if (!ownsLevelCrossingRouteRelation.Contains(myLevelCrossingRouteRelation)) ownsLevelCrossingRouteRelation.Append(myObject);
                        break;
                
                    case sig.LevelCrossingSignalRelation myLevelCrossingSignalRelation:
                        if (!ownsLevelCrossingSignalRelation.Contains(myLevelCrossingSignalRelation)) ownsLevelCrossingSignalRelation.Append(myObject);
                        break;
                
                    case sig.LevelCrossingTimerSet myLevelCrossingTimerSet:
                        if (!ownsLevelCrossingTimerSet.Contains(myLevelCrossingTimerSet)) ownsLevelCrossingTimerSet.Append(myObject);
                        break;
                
                    case sig.LineBlockInformation myLineBlockInformation:
                        if (!ownsLineBlockInformation.Contains(myLineBlockInformation)) ownsLineBlockInformation.Append(myObject);
                        break;
                
                    case sig.LineSideInstallation myLineSideInstallation:
                        if (!ownsLineSideInstallation.Contains(myLineSideInstallation)) ownsLineSideInstallation.Append(myObject);
                        break;
                
                    case sig.LocalOperatingArea myLocalOperatingArea:
                        if (!ownsLocalOperatingArea.Contains(myLocalOperatingArea)) ownsLocalOperatingArea.Append(myObject);
                        break;
                
                    case sig.LocalOperatingAreaUiElement myLocalOperatingAreaUiElement:
                        if (!ownsLocalOperatingAreaUiElement.Contains(myLocalOperatingAreaUiElement)) ownsLocalOperatingAreaUiElement.Append(myObject);
                        break;
                
                    case sig.LocalOperatingZone myLocalOperatingZone:
                        if (!ownsLocalOperatingZone.Contains(myLocalOperatingZone)) ownsLocalOperatingZone.Append(myObject);
                        break;
                
                    case sig.LocalOperatingZoneLimit myLocalOperatingZoneLimit:
                        if (!ownsLocalOperatingZoneLimit.Contains(myLocalOperatingZoneLimit)) ownsLocalOperatingZoneLimit.Append(myObject);
                        break;
                
                    case sig.LocalOperatingZoneRelation myLocalOperatingZoneRelation:
                        if (!ownsLocalOperatingZoneRelation.Contains(myLocalOperatingZoneRelation)) ownsLocalOperatingZoneRelation.Append(myObject);
                        break;
                
                    case sig.LocalOperationDevice myLocalOperationDevice:
                        if (!ownsLocalOperationDevice.Contains(myLocalOperationDevice)) ownsLocalOperationDevice.Append(myObject);
                        break;
                
                    case sig.LocationProxy myLocationProxy:
                        if (!ownsLocationProxy.Contains(myLocationProxy)) ownsLocationProxy.Append(myObject);
                        break;
                
                    case sig.Lock myLock:
                        if (!ownsLock.Contains(myLock)) ownsLock.Append(myObject);
                        break;
                
                    case sig.LockCombination myLockCombination:
                        if (!ownsLockCombination.Contains(myLockCombination)) ownsLockCombination.Append(myObject);
                        break;
                
                    case sig.LozAssetRelation myLozAssetRelation:
                        if (!ownsLozAssetRelation.Contains(myLozAssetRelation)) ownsLozAssetRelation.Append(myObject);
                        break;
                
                    case sig.ManualOverlapRelease myManualOverlapRelease:
                        if (!ownsManualOverlapRelease.Contains(myManualOverlapRelease)) ownsManualOverlapRelease.Append(myObject);
                        break;
                
                    case sig.ModificationInformation myModificationInformation:
                        if (!ownsModificationInformation.Contains(myModificationInformation)) ownsModificationInformation.Append(myObject);
                        break;
                
                    case sig.NotUpgradeableSpeedRestriction myNotUpgradeableSpeedRestriction:
                        if (!ownsNUSR.Contains(myNotUpgradeableSpeedRestriction)) ownsNUSR.Append(myObject);
                        break;
                
                    case sig.NearestAccessPoint myNearestAccessPoint:
                        if (!ownsNearestAccessPoint.Contains(myNearestAccessPoint)) ownsNearestAccessPoint.Append(myObject);
                        break;
                
                    case sig.NonReplacement myNonReplacement:
                        if (!ownsNonReplacement.Contains(myNonReplacement)) ownsNonReplacement.Append(myObject);
                        break;
                
                    case sig.NonStopMovement myNonStopMovement:
                        if (!ownsNonStopMovement.Contains(myNonStopMovement)) ownsNonStopMovement.Append(myObject);
                        break;
                
                    case sig.Normalisation myNormalisation:
                        if (!ownsNormalisation.Contains(myNormalisation)) ownsNormalisation.Append(myObject);
                        break;
                
                    case sig.OperationalLocality myOperationalLocality:
                        if (!ownsOperationalLocality.Contains(myOperationalLocality)) ownsOperationalLocality.Append(myObject);
                        break;
                
                    case sig.OppositeTrackSignal myOppositeTrackSignal:
                        if (!ownsOppositeTrackSignal.Contains(myOppositeTrackSignal)) ownsOppositeTrackSignal.Append(myObject);
                        break;
                
                    case sig.PowerOutputChannelProperties myPowerOutputChannelProperties:
                        if (!ownsPowerOutputChannelProperties.Contains(myPowerOutputChannelProperties)) ownsPowerOutputChannelProperties.Append(myObject);
                        break;
                
                    case sig.PowerSourceRelation myPowerSourceRelation:
                        if (!ownsPowerSourceRelation.Contains(myPowerSourceRelation)) ownsPowerSourceRelation.Append(myObject);
                        break;
                
                    case sig.PowerSupplyModule myPowerSupplyModule:
                        if (!ownsPowerSupplyModule.Contains(myPowerSupplyModule)) ownsPowerSupplyModule.Append(myObject);
                        break;
                
                    case sig.ReferenceDrawing myReferenceDrawing:
                        if (!ownsReferenceDrawing.Contains(myReferenceDrawing)) ownsReferenceDrawing.Append(myObject);
                        break;
                
                    case sig.Route myRoute:
                        if (!ownsRoute.Contains(myRoute)) ownsRoute.Append(myObject);
                        break;
                
                    case sig.RouteApproachLocking myRouteApproachLocking:
                        if (!ownsRouteApproacLocking.Contains(myRouteApproachLocking)) ownsRouteApproacLocking.Append(myObject);
                        break;
                
                    case sig.RouteBody myRouteBody:
                        if (!ownsRouteBody.Contains(myRouteBody)) ownsRouteBody.Append(myObject);
                        break;
                
                    case sig.RouteBodyProperty myRouteBodyProperty:
                        if (!ownsRouteBodyProperty.Contains(myRouteBodyProperty)) ownsRouteBodyProperty.Append(myObject);
                        break;
                
                    case sig.RouteCondition myRouteCondition:
                        if (!ownsRouteCondition.Contains(myRouteCondition)) ownsRouteCondition.Append(myObject);
                        break;
                
                    case sig.RouteProperty myRouteProperty:
                        if (!ownsRouteProperty.Contains(myRouteProperty)) ownsRouteProperty.Append(myObject);
                        break;
                
                    case sig.SafetyDistance mySafetyDistance:
                        if (!ownsSafetyDistance.Contains(mySafetyDistance)) ownsSafetyDistance.Append(myObject);
                        break;
                
                    case sig.SectionsForFlankProtection mySectionsForFlankProtection:
                        if (!ownsSectionsForFlankProtection.Contains(mySectionsForFlankProtection)) ownsSectionsForFlankProtection.Append(myObject);
                        break;
                
                    case sig.Segment mySegment:
                        if (!ownsSegment.Contains(mySegment)) ownsSegment.Append(myObject);
                        break;
                
                    case sig.ShuntingRouteSectionProving myShuntingRouteSectionProving:
                        if (!ownsShuntingRouteSectionProving.Contains(myShuntingRouteSectionProving)) ownsShuntingRouteSectionProving.Append(myObject);
                        break;
                
                    case sig.SignalAlignment mySignalAlignment:
                        if (!ownsSignalAlignment.Contains(mySignalAlignment)) ownsSignalAlignment.Append(myObject);
                        break;
                
                    case sig.SignalAspectDegradation mySignalAspectDegradation:
                        if (!ownsSignalAspectDegradation.Contains(mySignalAspectDegradation)) ownsSignalAspectDegradation.Append(myObject);
                        break;
                
                    case sig.SignalFrame mySignalFrame:
                        if (!ownsSignalFrame.Contains(mySignalFrame)) ownsSignalFrame.Append(myObject);
                        break;
                
                    case sig.SignalFrameComponent mySignalFrameComponent:
                        if (!ownsSignalFrameComponent.Contains(mySignalFrameComponent)) ownsSignalFrameComponent.Append(myObject);
                        break;
                
                    case sig.SignalFunction mySignalFunction:
                        if (!ownsSignalFunction.Contains(mySignalFunction)) ownsSignalFunction.Append(myObject);
                        break;
                
                    case sig.SignalLocation mySignalLocation:
                        if (!ownsSignalLocation.Contains(mySignalLocation)) ownsSignalLocation.Append(myObject);
                        break;
                
                    case sig.SignalMessage mySignalMessage:
                        if (!ownsSignalMessage.Contains(mySignalMessage)) ownsSignalMessage.Append(myObject);
                        break;
                
                    case sig.SignalSightingDistance mySignalSightingDistance:
                        if (!ownsSignalSightingDistance.Contains(mySignalSightingDistance)) ownsSignalSightingDistance.Append(myObject);
                        break;
                
                    case sig.SignalType mySignalType:
                        if (!ownsSignalType.Contains(mySignalType)) ownsSignalType.Append(myObject);
                        break;
                
                    case sig.SignalVector mySignalVector:
                        if (!ownsSignalVector.Contains(mySignalVector)) ownsSignalVector.Append(myObject);
                        break;
                
                    case sig.Signalplan mySignalplan:
                        if (!ownsSignalplan.Contains(mySignalplan)) ownsSignalplan.Append(myObject);
                        break;
                
                    case sig.SpecialPositionArrangement mySpecialPositionArrangement:
                        if (!ownsSpecialPositionArrangement.Contains(mySpecialPositionArrangement)) ownsSpecialPositionArrangement.Append(myObject);
                        break;
                
                    case sig.SpeedProfile mySpeedProfile:
                        if (!ownsSpeedProfile.Contains(mySpeedProfile)) ownsSpeedProfile.Append(myObject);
                        break;
                
                    case sig.StandOutControl myStandOutControl:
                        if (!ownsStandOutControl.Contains(myStandOutControl)) ownsStandOutControl.Append(myObject);
                        break;
                
                    case sig.SwingingOverlap mySwingingOverlap:
                        if (!ownsSwingingOverlap.Contains(mySwingingOverlap)) ownsSwingingOverlap.Append(myObject);
                        break;
                
                    case sig.SynchedFlashing mySynchedFlashing:
                        if (!ownsSynchedFlashing.Contains(mySynchedFlashing)) ownsSynchedFlashing.Append(myObject);
                        break;
                
                    case sig.SystemState mySystemState:
                        if (!ownsSystemState.Contains(mySystemState)) ownsSystemState.Append(myObject);
                        break;
                
                    case sig.TdsOccupancyOverrideGroup myTdsOccupancyOverrideGroup:
                        if (!ownsTdsOccupanyOverrideGroup.Contains(myTdsOccupancyOverrideGroup)) ownsTdsOccupanyOverrideGroup.Append(myObject);
                        break;
                
                    case sig.TimeFrame myTimeFrame:
                        if (!ownsTimeFrame.Contains(myTimeFrame)) ownsTimeFrame.Append(myObject);
                        break;
                
                    case sig.TpArea myTpArea:
                        if (!ownsTpArea.Contains(myTpArea)) ownsTpArea.Append(myObject);
                        break;
                
                    case sig.TpsDataTransmissionSystemProperties myTpsDataTransmissionSystemProperties:
                        if (!ownsTpsDataTransmissionSystemProperties.Contains(myTpsDataTransmissionSystemProperties)) ownsTpsDataTransmissionSystemProperties.Append(myObject);
                        break;
                
                    case sig.TpsDeviceProperties myTpsDeviceProperties:
                        if (!ownsTpsDeviceProperties.Contains(myTpsDeviceProperties)) ownsTpsDeviceProperties.Append(myObject);
                        break;
                
                    case sig.TpsRelation myTpsRelation:
                        if (!ownsTpsRelation.Contains(myTpsRelation)) ownsTpsRelation.Append(myObject);
                        break;
                
                    case sig.TrackAsset myTrackAsset:
                        if (!ownsTrackAsset.Contains(myTrackAsset)) ownsTrackAsset.Append(myObject);
                        break;
                
                    case sig.TrackAssetConfiguration myTrackAssetConfiguration:
                        if (!ownsTrackAssetConfiguration.Contains(myTrackAssetConfiguration)) ownsTrackAssetConfiguration.Append(myObject);
                        break;
                
                    case sig.TrackConditionArea myTrackConditionArea:
                        if (!ownsTrackConditionArea.Contains(myTrackConditionArea)) ownsTrackConditionArea.Append(myObject);
                        break;
                
                    case sig.TrackProperty myTrackProperty:
                        if (!ownsTrackProperty.Contains(myTrackProperty)) ownsTrackProperty.Append(myObject);
                        break;
                
                    case sig.TrainCategory myTrainCategory:
                        if (!ownsTrainCategory.Contains(myTrainCategory)) ownsTrainCategory.Append(myObject);
                        break;
                
                    case sig.TrainSelectionProperties myTrainSelectionProperties:
                        if (!ownsTrainSelectionProperties.Contains(myTrainSelectionProperties)) ownsTrainSelectionProperties.Append(myObject);
                        break;
                
                    case sig.TriggerAssignment myTriggerAssignment:
                        if (!ownsTriggerAssignment.Contains(myTriggerAssignment)) ownsTriggerAssignment.Append(myObject);
                        break;
                
                    case sig.TunnelSignal myTunnelSignal:
                        if (!ownsTunnelSignal.Contains(myTunnelSignal)) ownsTunnelSignal.Append(myObject);
                        break;
                
                }
                return id;
            }
        }
        
        /** 
        Container for classes needed for signalling engineering and the Data Preparation. This translates into the XSD as an XML-element that contains EULYNX signalling entities.
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DataPrep")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DataPrep",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(db.SignallingEntities))]
        [XmlIncludeAttribute(typeof(nr.SignallingEntities))]
        [XmlIncludeAttribute(typeof(prorail.SignallingEntities))]
        [XmlIncludeAttribute(typeof(rfi.SignallingEntities))]
        [XmlIncludeAttribute(typeof(sncf.SignallingEntities))]
        [XmlIncludeAttribute(typeof(trv.SignallingEntities))]     
        public  partial class SignallingEntities: sig.BaseObject
        {
            [XmlElementAttribute("knowsAssetAndState", Order=1)]
            public List<sig.AssetAndState> knowsAssetAndState { get; set; } = new List<sig.AssetAndState>(); 
                
            [XmlElementAttribute("ownsAnnotation", Order=2)]
            public List<sig.Annotation> ownsAnnotation { get; set; } = new List<sig.Annotation>(); 
                
            [XmlElementAttribute("ownsAspect", Order=3)]
            public List<sig.Aspect> ownsAspect { get; set; } = new List<sig.Aspect>(); 
                
            [XmlElementAttribute("ownsAspectProving", Order=4)]
            public List<sig.AspectProving> ownsAspectProving { get; set; } = new List<sig.AspectProving>(); 
                
            [XmlElementAttribute("ownsAssetUser", Order=5)]
            public List<sig.AssetUser> ownsAssetUser { get; set; } = new List<sig.AssetUser>(); 
                
            [XmlElementAttribute("ownsAtpProtectiveDistance", Order=6)]
            public List<sig.TpsProtectionDistance> ownsAtpProtectiveDistance { get; set; } = new List<sig.TpsProtectionDistance>(); 
                
            [XmlElementAttribute("ownsAttachmentDocument", Order=7)]
            public List<sig.Attachment> ownsAttachmentDocument { get; set; } = new List<sig.Attachment>(); 
                
            [XmlElementAttribute("ownsAutomatic", Order=8)]
            public List<sig.Automatic> ownsAutomatic { get; set; } = new List<sig.Automatic>(); 
                
            [XmlElementAttribute("ownsBackToBackLocking", Order=9)]
            public List<sig.BackToBackLocking> ownsBackToBackLocking { get; set; } = new List<sig.BackToBackLocking>(); 
                
            [XmlElementAttribute("ownsBaselineOfRuleSet", Order=10)]
            public List<sig.BaselineOfRuleSet> ownsBaselineOfRuleSet { get; set; } = new List<sig.BaselineOfRuleSet>(); 
                
            [XmlElementAttribute("ownsBlockSystem", Order=11)]
            public List<sig.BlockSystem> ownsBlockSystem { get; set; } = new List<sig.BlockSystem>(); 
                
            [XmlElementAttribute("ownsCable", Order=12)]
            public List<sig.Cable> ownsCable { get; set; } = new List<sig.Cable>(); 
                
            [XmlElementAttribute("ownsCableDuct", Order=13)]
            public List<sig.CableRoute> ownsCableDuct { get; set; } = new List<sig.CableRoute>(); 
                
            [XmlElementAttribute("ownsCableJoint", Order=14)]
            public List<sig.CableJoint> ownsCableJoint { get; set; } = new List<sig.CableJoint>(); 
                
            [XmlElementAttribute("ownsCableJointInstallation", Order=15)]
            public List<sig.CableJointInstallation> ownsCableJointInstallation { get; set; } = new List<sig.CableJointInstallation>(); 
                
            [XmlElementAttribute("ownsCableProperties", Order=16)]
            public List<sig.CableProperties> ownsCableProperties { get; set; } = new List<sig.CableProperties>(); 
                
            [XmlElementAttribute("ownsCableRouteJunction", Order=17)]
            public List<sig.CableRouteJunction> ownsCableRouteJunction { get; set; } = new List<sig.CableRouteJunction>(); 
                
            [XmlElementAttribute("ownsChangeMarker", Order=18)]
            public List<sig.ChangeMarker> ownsChangeMarker { get; set; } = new List<sig.ChangeMarker>(); 
                
            [XmlElementAttribute("ownsCivilStructure", Order=19)]
            public List<sig.CivilStructure> ownsCivilStructure { get; set; } = new List<sig.CivilStructure>(); 
                
            [XmlElementAttribute("ownsCompositeRoute", Order=20)]
            public List<sig.CompositeRoute> ownsCompositeRoute { get; set; } = new List<sig.CompositeRoute>(); 
                
            [XmlElementAttribute("ownsConditionSectionsClear", Order=21)]
            public List<sig.ConditionSectionsClear> ownsConditionSectionsClear { get; set; } = new List<sig.ConditionSectionsClear>(); 
                
            [XmlElementAttribute("ownsConflictingRoute", Order=22)]
            public List<sig.ConflictingRoute> ownsConflictingRoute { get; set; } = new List<sig.ConflictingRoute>(); 
                
            [XmlElementAttribute("ownsControlArea", Order=23)]
            public List<sig.ControlArea> ownsControlArea { get; set; } = new List<sig.ControlArea>(); 
                
            [XmlElementAttribute("ownsControlRelation", Order=24)]
            public List<sig.ControlRelation> ownsControlRelation { get; set; } = new List<sig.ControlRelation>(); 
                
            [XmlElementAttribute("ownsControlledTrackAsset", Order=25)]
            public List<sig.ControlledTrackAsset> ownsControlledTrackAsset { get; set; } = new List<sig.ControlledTrackAsset>(); 
                
            [XmlElementAttribute("ownsDADoverlap", Order=26)]
            public List<sig.DirectionAuthorityDependentOverlap> ownsDADoverlap { get; set; } = new List<sig.DirectionAuthorityDependentOverlap>(); 
                
            [XmlElementAttribute("ownsDangerAreaTrack", Order=27)]
            public List<sig.DangerAreaTrack> ownsDangerAreaTrack { get; set; } = new List<sig.DangerAreaTrack>(); 
                
            [XmlElementAttribute("ownsDescription", Order=28)]
            public List<sig.Description> ownsDescription { get; set; } = new List<sig.Description>(); 
                
            [XmlElementAttribute("ownsDispatchAnnouncerAssignment", Order=29)]
            public List<sig.DispatchAnnouncerAssignment> ownsDispatchAnnouncerAssignment { get; set; } = new List<sig.DispatchAnnouncerAssignment>(); 
                
            [XmlElementAttribute("ownsEquipmentSupport", Order=30)]
            public List<sig.EquipmentSupport> ownsEquipmentSupport { get; set; } = new List<sig.EquipmentSupport>(); 
                
            [XmlElementAttribute("ownsFlankProtection", Order=31)]
            public List<sig.FlankProtection> ownsFlankProtection { get; set; } = new List<sig.FlankProtection>(); 
                
            [XmlElementAttribute("ownsFoulTrackControl", Order=32)]
            public List<sig.FoulTrackControl> ownsFoulTrackControl { get; set; } = new List<sig.FoulTrackControl>(); 
                
            [XmlElementAttribute("ownsIllumination", Order=33)]
            public List<sig.Illumination> ownsIllumination { get; set; } = new List<sig.Illumination>(); 
                
            [XmlElementAttribute("ownsInfrastructureBorder", Order=34)]
            public List<sig.InfrastructureBorder> ownsInfrastructureBorder { get; set; } = new List<sig.InfrastructureBorder>(); 
                
            [XmlElementAttribute("ownsIntentionallyDarkAllowed", Order=35)]
            public List<sig.IntentionallyDarkAllowed> ownsIntentionallyDarkAllowed { get; set; } = new List<sig.IntentionallyDarkAllowed>(); 
                
            [XmlElementAttribute("ownsKey", Order=36)]
            public List<sig.Key> ownsKey { get; set; } = new List<sig.Key>(); 
                
            [XmlElementAttribute("ownsLensDiffuser", Order=37)]
            public List<sig.LensDiffuser> ownsLensDiffuser { get; set; } = new List<sig.LensDiffuser>(); 
                
            [XmlElementAttribute("ownsLevelCrossingActivation", Order=38)]
            public List<sig.LevelCrossingActivation> ownsLevelCrossingActivation { get; set; } = new List<sig.LevelCrossingActivation>(); 
                
            [XmlElementAttribute("ownsLevelCrossingDeactivation", Order=39)]
            public List<sig.LevelCrossingDeactivation> ownsLevelCrossingDeactivation { get; set; } = new List<sig.LevelCrossingDeactivation>(); 
                
            [XmlElementAttribute("ownsLevelCrossingLocalOperationUiElement", Order=40)]
            public List<sig.LevelCrossingLocalOperationUiElement> ownsLevelCrossingLocalOperationUiElement { get; set; } = new List<sig.LevelCrossingLocalOperationUiElement>(); 
                
            [XmlElementAttribute("ownsLevelCrossingRouteRelation", Order=41)]
            public List<sig.LevelCrossingRouteRelation> ownsLevelCrossingRouteRelation { get; set; } = new List<sig.LevelCrossingRouteRelation>(); 
                
            [XmlElementAttribute("ownsLevelCrossingSignalRelation", Order=42)]
            public List<sig.LevelCrossingSignalRelation> ownsLevelCrossingSignalRelation { get; set; } = new List<sig.LevelCrossingSignalRelation>(); 
                
            [XmlElementAttribute("ownsLevelCrossingTimerSet", Order=43)]
            public List<sig.LevelCrossingTimerSet> ownsLevelCrossingTimerSet { get; set; } = new List<sig.LevelCrossingTimerSet>(); 
                
            [XmlElementAttribute("ownsLineBlockInformation", Order=44)]
            public List<sig.LineBlockInformation> ownsLineBlockInformation { get; set; } = new List<sig.LineBlockInformation>(); 
                
            [XmlElementAttribute("ownsLineSideInstallation", Order=45)]
            public List<sig.LineSideInstallation> ownsLineSideInstallation { get; set; } = new List<sig.LineSideInstallation>(); 
                
            [XmlElementAttribute("ownsLocalOperatingArea", Order=46)]
            public List<sig.LocalOperatingArea> ownsLocalOperatingArea { get; set; } = new List<sig.LocalOperatingArea>(); 
                
            [XmlElementAttribute("ownsLocalOperatingAreaUiElement", Order=47)]
            public List<sig.LocalOperatingAreaUiElement> ownsLocalOperatingAreaUiElement { get; set; } = new List<sig.LocalOperatingAreaUiElement>(); 
                
            [XmlElementAttribute("ownsLocalOperatingZone", Order=48)]
            public List<sig.LocalOperatingZone> ownsLocalOperatingZone { get; set; } = new List<sig.LocalOperatingZone>(); 
                
            [XmlElementAttribute("ownsLocalOperatingZoneLimit", Order=49)]
            public List<sig.LocalOperatingZoneLimit> ownsLocalOperatingZoneLimit { get; set; } = new List<sig.LocalOperatingZoneLimit>(); 
                
            [XmlElementAttribute("ownsLocalOperatingZoneRelation", Order=50)]
            public List<sig.LocalOperatingZoneRelation> ownsLocalOperatingZoneRelation { get; set; } = new List<sig.LocalOperatingZoneRelation>(); 
                
            [XmlElementAttribute("ownsLocalOperationDevice", Order=51)]
            public List<sig.LocalOperationDevice> ownsLocalOperationDevice { get; set; } = new List<sig.LocalOperationDevice>(); 
                
            [XmlElementAttribute("ownsLocationProxy", Order=52)]
            public List<sig.LocationProxy> ownsLocationProxy { get; set; } = new List<sig.LocationProxy>(); 
                
            [XmlElementAttribute("ownsLock", Order=53)]
            public List<sig.Lock> ownsLock { get; set; } = new List<sig.Lock>(); 
                
            [XmlElementAttribute("ownsLockCombination", Order=54)]
            public List<sig.LockCombination> ownsLockCombination { get; set; } = new List<sig.LockCombination>(); 
                
            [XmlElementAttribute("ownsLozAssetRelation", Order=55)]
            public List<sig.LozAssetRelation> ownsLozAssetRelation { get; set; } = new List<sig.LozAssetRelation>(); 
                
            [XmlElementAttribute("ownsManualOverlapRelease", Order=56)]
            public List<sig.ManualOverlapRelease> ownsManualOverlapRelease { get; set; } = new List<sig.ManualOverlapRelease>(); 
                
            [XmlElementAttribute("ownsModificationInformation", Order=57)]
            public List<sig.ModificationInformation> ownsModificationInformation { get; set; } = new List<sig.ModificationInformation>(); 
                
            [XmlElementAttribute("ownsNUSR", Order=58)]
            public List<sig.NotUpgradeableSpeedRestriction> ownsNUSR { get; set; } = new List<sig.NotUpgradeableSpeedRestriction>(); 
                
            [XmlElementAttribute("ownsNearestAccessPoint", Order=59)]
            public List<sig.NearestAccessPoint> ownsNearestAccessPoint { get; set; } = new List<sig.NearestAccessPoint>(); 
                
            [XmlElementAttribute("ownsNonReplacement", Order=60)]
            public List<sig.NonReplacement> ownsNonReplacement { get; set; } = new List<sig.NonReplacement>(); 
                
            [XmlElementAttribute("ownsNonStopMovement", Order=61)]
            public List<sig.NonStopMovement> ownsNonStopMovement { get; set; } = new List<sig.NonStopMovement>(); 
                
            [XmlElementAttribute("ownsNormalisation", Order=62)]
            public List<sig.Normalisation> ownsNormalisation { get; set; } = new List<sig.Normalisation>(); 
                
            [XmlElementAttribute("ownsOperationalLocality", Order=63)]
            public List<sig.OperationalLocality> ownsOperationalLocality { get; set; } = new List<sig.OperationalLocality>(); 
                
            [XmlElementAttribute("ownsOppositeTrackSignal", Order=64)]
            public List<sig.OppositeTrackSignal> ownsOppositeTrackSignal { get; set; } = new List<sig.OppositeTrackSignal>(); 
                
            [XmlElementAttribute("ownsPowerOutputChannelProperties", Order=65)]
            public List<sig.PowerOutputChannelProperties> ownsPowerOutputChannelProperties { get; set; } = new List<sig.PowerOutputChannelProperties>(); 
                
            [XmlElementAttribute("ownsPowerSourceRelation", Order=66)]
            public List<sig.PowerSourceRelation> ownsPowerSourceRelation { get; set; } = new List<sig.PowerSourceRelation>(); 
                
            [XmlElementAttribute("ownsPowerSupplyModule", Order=67)]
            public List<sig.PowerSupplyModule> ownsPowerSupplyModule { get; set; } = new List<sig.PowerSupplyModule>(); 
                
            [XmlElementAttribute("ownsReferenceDrawing", Order=68)]
            public List<sig.ReferenceDrawing> ownsReferenceDrawing { get; set; } = new List<sig.ReferenceDrawing>(); 
                
            [XmlElementAttribute("ownsRoute", Order=69)]
            public List<sig.Route> ownsRoute { get; set; } = new List<sig.Route>(); 
                
            [XmlElementAttribute("ownsRouteApproacLocking", Order=70)]
            public List<sig.RouteApproachLocking> ownsRouteApproacLocking { get; set; } = new List<sig.RouteApproachLocking>(); 
                
            [XmlElementAttribute("ownsRouteBody", Order=71)]
            public List<sig.RouteBody> ownsRouteBody { get; set; } = new List<sig.RouteBody>(); 
                
            [XmlElementAttribute("ownsRouteBodyProperty", Order=72)]
            public List<sig.RouteBodyProperty> ownsRouteBodyProperty { get; set; } = new List<sig.RouteBodyProperty>(); 
                
            [XmlElementAttribute("ownsRouteCondition", Order=73)]
            public List<sig.RouteCondition> ownsRouteCondition { get; set; } = new List<sig.RouteCondition>(); 
                
            [XmlElementAttribute("ownsRouteProperty", Order=74)]
            public List<sig.RouteProperty> ownsRouteProperty { get; set; } = new List<sig.RouteProperty>(); 
                
            [XmlElementAttribute("ownsSafetyDistance", Order=75)]
            public List<sig.SafetyDistance> ownsSafetyDistance { get; set; } = new List<sig.SafetyDistance>(); 
                
            [XmlElementAttribute("ownsSectionsForFlankProtection", Order=76)]
            public List<sig.SectionsForFlankProtection> ownsSectionsForFlankProtection { get; set; } = new List<sig.SectionsForFlankProtection>(); 
                
            [XmlElementAttribute("ownsSegment", Order=77)]
            public List<sig.Segment> ownsSegment { get; set; } = new List<sig.Segment>(); 
                
            [XmlElementAttribute("ownsShuntingRouteSectionProving", Order=78)]
            public List<sig.ShuntingRouteSectionProving> ownsShuntingRouteSectionProving { get; set; } = new List<sig.ShuntingRouteSectionProving>(); 
                
            [XmlElementAttribute("ownsSignalAlignment", Order=79)]
            public List<sig.SignalAlignment> ownsSignalAlignment { get; set; } = new List<sig.SignalAlignment>(); 
                
            [XmlElementAttribute("ownsSignalAspectDegradation", Order=80)]
            public List<sig.SignalAspectDegradation> ownsSignalAspectDegradation { get; set; } = new List<sig.SignalAspectDegradation>(); 
                
            [XmlElementAttribute("ownsSignalFrame", Order=81)]
            public List<sig.SignalFrame> ownsSignalFrame { get; set; } = new List<sig.SignalFrame>(); 
                
            [XmlElementAttribute("ownsSignalFrameComponent", Order=82)]
            public List<sig.SignalFrameComponent> ownsSignalFrameComponent { get; set; } = new List<sig.SignalFrameComponent>(); 
                
            [XmlElementAttribute("ownsSignalFunction", Order=83)]
            public List<sig.SignalFunction> ownsSignalFunction { get; set; } = new List<sig.SignalFunction>(); 
                
            [XmlElementAttribute("ownsSignalLocation", Order=84)]
            public List<sig.SignalLocation> ownsSignalLocation { get; set; } = new List<sig.SignalLocation>(); 
                
            [XmlElementAttribute("ownsSignalMessage", Order=85)]
            public List<sig.SignalMessage> ownsSignalMessage { get; set; } = new List<sig.SignalMessage>(); 
                
            [XmlElementAttribute("ownsSignalSightingDistance", Order=86)]
            public List<sig.SignalSightingDistance> ownsSignalSightingDistance { get; set; } = new List<sig.SignalSightingDistance>(); 
                
            [XmlElementAttribute("ownsSignalType", Order=87)]
            public List<sig.SignalType> ownsSignalType { get; set; } = new List<sig.SignalType>(); 
                
            [XmlElementAttribute("ownsSignalVector", Order=88)]
            public List<sig.SignalVector> ownsSignalVector { get; set; } = new List<sig.SignalVector>(); 
                
            [XmlElementAttribute("ownsSignalplan", Order=89)]
            public List<sig.Signalplan> ownsSignalplan { get; set; } = new List<sig.Signalplan>(); 
                
            [XmlElementAttribute("ownsSpecialPositionArrangement", Order=90)]
            public List<sig.SpecialPositionArrangement> ownsSpecialPositionArrangement { get; set; } = new List<sig.SpecialPositionArrangement>(); 
                
            [XmlElementAttribute("ownsSpeedProfile", Order=91)]
            public List<sig.SpeedProfile> ownsSpeedProfile { get; set; } = new List<sig.SpeedProfile>(); 
                
            [XmlElementAttribute("ownsStandOutControl", Order=92)]
            public List<sig.StandOutControl> ownsStandOutControl { get; set; } = new List<sig.StandOutControl>(); 
                
            [XmlElementAttribute("ownsSwingingOverlap", Order=93)]
            public List<sig.SwingingOverlap> ownsSwingingOverlap { get; set; } = new List<sig.SwingingOverlap>(); 
                
            [XmlElementAttribute("ownsSynchedFlashing", Order=94)]
            public List<sig.SynchedFlashing> ownsSynchedFlashing { get; set; } = new List<sig.SynchedFlashing>(); 
                
            [XmlElementAttribute("ownsSystemState", Order=95)]
            public List<sig.SystemState> ownsSystemState { get; set; } = new List<sig.SystemState>(); 
                
            [XmlElementAttribute("ownsTdsOccupanyOverrideGroup", Order=96)]
            public List<sig.TdsOccupancyOverrideGroup> ownsTdsOccupanyOverrideGroup { get; set; } = new List<sig.TdsOccupancyOverrideGroup>(); 
                
            [XmlElementAttribute("ownsTimeFrame", Order=97)]
            public List<sig.TimeFrame> ownsTimeFrame { get; set; } = new List<sig.TimeFrame>(); 
                
            [XmlElementAttribute("ownsTpArea", Order=98)]
            public List<sig.TpArea> ownsTpArea { get; set; } = new List<sig.TpArea>(); 
                
            [XmlElementAttribute("ownsTpsDataTransmissionSystemProperties", Order=99)]
            public List<sig.TpsDataTransmissionSystemProperties> ownsTpsDataTransmissionSystemProperties { get; set; } = new List<sig.TpsDataTransmissionSystemProperties>(); 
                
            [XmlElementAttribute("ownsTpsDeviceProperties", Order=100)]
            public List<sig.TpsDeviceProperties> ownsTpsDeviceProperties { get; set; } = new List<sig.TpsDeviceProperties>(); 
                
            [XmlElementAttribute("ownsTpsRelation", Order=101)]
            public List<sig.TpsRelation> ownsTpsRelation { get; set; } = new List<sig.TpsRelation>(); 
                
            [XmlElementAttribute("ownsTrackAsset", Order=102)]
            public List<sig.TrackAsset> ownsTrackAsset { get; set; } = new List<sig.TrackAsset>(); 
                
            [XmlElementAttribute("ownsTrackAssetConfiguration", Order=103)]
            public List<sig.TrackAssetConfiguration> ownsTrackAssetConfiguration { get; set; } = new List<sig.TrackAssetConfiguration>(); 
                
            [XmlElementAttribute("ownsTrackConditionArea", Order=104)]
            public List<sig.TrackConditionArea> ownsTrackConditionArea { get; set; } = new List<sig.TrackConditionArea>(); 
                
            [XmlElementAttribute("ownsTrackProperty", Order=105)]
            public List<sig.TrackProperty> ownsTrackProperty { get; set; } = new List<sig.TrackProperty>(); 
                
            [XmlElementAttribute("ownsTrainCategory", Order=106)]
            public List<sig.TrainCategory> ownsTrainCategory { get; set; } = new List<sig.TrainCategory>(); 
                
            [XmlElementAttribute("ownsTrainSelectionProperties", Order=107)]
            public List<sig.TrainSelectionProperties> ownsTrainSelectionProperties { get; set; } = new List<sig.TrainSelectionProperties>(); 
                
            [XmlElementAttribute("ownsTriggerAssignment", Order=108)]
            public List<sig.TriggerAssignment> ownsTriggerAssignment { get; set; } = new List<sig.TriggerAssignment>(); 
                
            [XmlElementAttribute("ownsTunnelSignal", Order=109)]
            public List<sig.TunnelSignal> ownsTunnelSignal { get; set; } = new List<sig.TunnelSignal>(); 
                
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DataPrep")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DataPrep",IsNullable=false)] 
             
        public  partial class Topology
        {
            [XmlElementAttribute("usesPositionedRelation", Order=1)]
            public List<rtmCommon.PositionedRelation> usesPositionedRelation { get; set; } = new List<rtmCommon.PositionedRelation>(); 
                
            [XmlElementAttribute("usesPositioningNetElement", Order=2)]
            public List<rtmCommon.PositioningNetElement> usesPositioningNetElement { get; set; } = new List<rtmCommon.PositioningNetElement>(); 
                
             
        }  
    
        /** 
        The version element of the EULYNX DP XML. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DataPrep")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DataPrep",IsNullable=false)] 
             
        public  partial class Version
        {
            [XmlElementAttribute("generatedByTool", Order=1)]
            public List<XsdGeneratorVersion> generatedByTool { get; set; } = new List<XsdGeneratorVersion>(); 
                
            [XmlElementAttribute("hasBaseline", Order=2)]
            public List<Baseline> hasBaseline { get; set; } = new List<Baseline>(); 
                
             
        }  
    
        /** 
        Captures the tooling used to transform the UML classes into XSD. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DataPrep")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DataPrep",IsNullable=false)] 
             
        public  partial class XsdGeneratorVersion
        {
            [XmlElementAttribute("generatedByTool", Order=1)]
            public String generatedByTool= "";
                
            [XmlElementAttribute("generatedByToolVersion", Order=2)]
            public String generatedByToolVersion= "";
                
            [XmlElementAttribute("toolUri", Order=3)]
            public String toolUri= "";
                
             
        }  
    
    public enum NationalDomains : int {
        /* Soci&#233;t&#233; National des Chemins de fer Fran&#231;ais */sncf,/* Deutsche Bahn Netze */db,/* Network Rail */nr,/*  */prorail,/* Rete Ferroviaria Italiana */rfi,/* Chemins de fer f&#233;d&#233;raux suisses (CFF), Schweizerische Bundesbahnen (SBB), Ferrovie federali svizzere (FFS) */sbb,/* Trafikverket */trafikverket,/* Chemins de fer Luxembourgeois */banenor,/*  */cfl,/*  */infrabel,/* &#214;sterreichische Bundesbahnen */oebb,/* Slovenske zeleznice */sz,/* V&#228;yl&#228;virasto */vayla,/*  */other
    }
    
} 
            