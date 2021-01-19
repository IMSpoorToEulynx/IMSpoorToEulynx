 
using System; 
using System.Collections.Generic; 
using System.Text; using System.IO; 
using System.Xml.Serialization; 
using System.Linq;
     
using Models.TopoModels.EULYNX.rtmCommon;
     
using Models.TopoModels.EULYNX.dp;
     
using Models.TopoModels.EULYNX.sig;
     
using nr = Models.TopoModels.EULYNX.nr;

namespace Models.TopoModels.EULYNX.nr {
    
        /** 
        NR level crossing system.
Note that it is not necessary to define the type or streetname of the protected track crossing, its spot location suffices.
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/NR")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/NR",IsNullable=false)] 
             
        public  partial class LevelCrossingSystem: sig.LevelCrossingSystem
        {
            [XmlElementAttribute("isOfLevelCrossingControlType", Order=1)]
            public List<LevelCrossingControlTypes> isOfLevelCrossingControlType { get; set; } = new List<LevelCrossingControlTypes>(); 
                
             
        }  
    
        /** 
        Timer that applies to NR level crossing.
Mrot: minimum road open time. Time during which a level crossing is guaranteed to be available to road traffic. 

 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/NR")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/NR",IsNullable=false)] 
             
        public  partial class LevelCrossingTimerSet: sig.LevelCrossingTimerSet
        {
            [XmlElementAttribute("isOfMrotType", Order=1)]
            public MrotTypes isOfMrotType {get; set;} = new MrotTypes();
                
             
        }  
    
        /** 
        A trackside frame for locally controlling movable elements. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/NR")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/NR",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(nr.GroundFrame))]     
        public  partial class ControlFrame: sig.LocalOperationDevice
        {
            [XmlElementAttribute("covered", Order=1)]
            public Boolean covered {get; set;} = new Boolean();
                
            [XmlElementAttribute("releaseNumber", Order=2)]
            public String releaseNumber= "";
                
             
        }  
    
        /** 
        Mechanical lever frame for manually throwing movable elements like points.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/NR")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/NR",IsNullable=false)] 
             
        public  partial class GroundFrame: nr.ControlFrame
        {
            [XmlElementAttribute("numberOfLevers", Order=1)]
            public Int32 numberOfLevers {get; set;} = new Int32();
                
             
        }  
    
        /** 
        Features that may present confusion risk such as station lights or road lights. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/NR")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/NR",IsNullable=false)] 
             
        public  partial class ConfusionRisk
        {
            [XmlElementAttribute("backgroundFeatures", Order=1)]
            public String backgroundFeatures= "";
                
            [XmlElementAttribute("isReadingThrough", Order=2)]
            public ReadThroughRiskTypes isReadingThrough {get; set;} = new ReadThroughRiskTypes();
                
            [XmlElementAttribute("isSignalAheadVisible", Order=3)]
            public SignalBeyondVisibleTypes isSignalAheadVisible {get; set;} = new SignalBeyondVisibleTypes();
                
            [XmlElementAttribute("isWithOtherSignals", Order=4)]
            public ConfusionRiskWithOtherSignalsTypes isWithOtherSignals {get; set;} = new ConfusionRiskWithOtherSignalsTypes();
                
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/NR")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/NR",IsNullable=false)] 
             
        public  partial class FrameDimension
        {
            [XmlElementAttribute("isMiniature", Order=1)]
            public Boolean isMiniature {get; set;} = new Boolean();
                
            [XmlElementAttribute("width", Order=2)]
            public Int32 width {get; set;} = new Int32();
                
             
        }  
    
        /** 
        (X,Y) coordinates of the signal frame components as assigned in the Signal Head Editor tool. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/NR")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/NR",IsNullable=false)] 
             
        public  partial class GridLocation
        {
            [XmlElementAttribute("X", Order=1)]
            public Int32 X {get; set;} = new Int32();
                
            [XmlElementAttribute("Y", Order=2)]
            public Int32 Y {get; set;} = new Int32();
                
             
        }  
    
        /** 
        Supporting images, photos and diagrams for signal sighting. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/NR")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/NR",IsNullable=false)] 
             
        public  partial class ImageAttachment: sig.Attachment
        {
            [XmlElementAttribute("isOfImageType", Order=1)]
            public ImageTypes isOfImageType {get; set;} = new ImageTypes();
                
             
        }  
    
        /** 
        NR Lens diffuser 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/NR")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/NR",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(nr.LensDiffuserWithHotStrip))]     
        public  partial class LensDiffuser: sig.LensDiffuser
        {
            [XmlElementAttribute("isOfLensDiffuserType", Order=1)]
            public LensDiffuserTypes isOfLensDiffuserType {get; set;} = new LensDiffuserTypes();
                
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/NR")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/NR",IsNullable=false)] 
             
        public  partial class LensDiffuserWithHotStrip: nr.LensDiffuser
        {
            [XmlElementAttribute("value", Order=1)]
            public String value= "";
                
             
        }  
    
        /** 
        NR Light signal 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/NR")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/NR",IsNullable=false)] 
             
        public  partial class LightSignal: sig.LightSignal
        {
            [XmlElementAttribute("hasBackBoard", Order=1)]
            public BackBoardTypes hasBackBoard {get; set;} = new BackBoardTypes();
                
            [XmlElementAttribute("hasHoodLength", Order=2)]
            public HoodsLengthTypes hasHoodLength {get; set;} = new HoodsLengthTypes();
                
             
        }  
    
        /** 
        A trackside object that obscures the view.
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/NR")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/NR",IsNullable=false)] 
             
        public  partial class Obscuration: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("description", Order=1)]
            public String description= "";
                
             
        }  
    
        /** 
        NR Physical signal 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/NR")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/NR",IsNullable=false)] 
             
        public  partial class PhysicalSignal: sig.PhysicalSignal
        {
            [XmlElementAttribute("GsmRadioCoverage", Order=1)]
            public Boolean GsmRadioCoverage {get; set;} = new Boolean();
                
            [XmlElementAttribute("hasConfusionRisk", Order=2)]
            public ConfusionRisk hasConfusionRisk {get; set;} = new ConfusionRisk();
                
            [XmlElementAttribute("hasImageAttachment", Order=3)]
            public List<tElementWithIDref> hasImageAttachment { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("isObscuredBy", Order=4)]
            public List<tElementWithIDref> isObscuredBy { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        Predicted Overrun Protection (POP) group of signals.
Overrun of any of the signals in the POP group triggers a closing of all signals. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/NR")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/NR",IsNullable=false)] 
             
        public  partial class PopGroup: sig.ConfiguredBaseObject
        {
             
        }  
    
        /** 
        Association class describing the conditions applying to individual signals in the POP group. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/NR")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/NR",IsNullable=false)] 
             
        public  partial class PopGroupAssociation: sig.BaseObject
        {
            [XmlElementAttribute("appliesToPopGroup", Order=1)]
            public tElementWithIDref appliesToPopGroup {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("appliesToSignal", Order=2)]
            public tElementWithIDref appliesToSignal {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("condition", Order=3)]
            public String condition= "";
                
            [XmlElementAttribute("hasDerailerElementCondition", Order=4)]
            public List<tElementWithIDref> hasDerailerElementCondition { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("hasPointElementCondition", Order=5)]
            public List<tElementWithIDref> hasPointElementCondition { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        NR signal frame.
The type of frame is inherent to the aspect, i.e. speed warning, termination, repeater, spate, enhanced permissible speed. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/NR")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/NR",IsNullable=false)] 
             
        public  partial class SignalFrame: sig.SignalFrame
        {
            [XmlElementAttribute("hasComponent", Order=1)]
            public List<SignalFrameComponent> hasComponent { get; set; } = new List<SignalFrameComponent>(); 
                
            [XmlElementAttribute("hasFrameDimension", Order=2)]
            public FrameDimension hasFrameDimension {get; set;} = new FrameDimension();
                
            [XmlElementAttribute("hasMountingPoint", Order=3)]
            public GridLocation hasMountingPoint {get; set;} = new GridLocation();
                
             
        }  
    
        /** 
        Lamps or indicators that are part of a signal housing. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/NR")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/NR",IsNullable=false)] 
             
        public  partial class SignalFrameComponent: sig.SignalFrameComponent
        {
            [XmlElementAttribute("hasGridLocation", Order=1)]
            public GridLocation hasGridLocation {get; set;} = new GridLocation();
                
            [XmlElementAttribute("pitchAngle", Order=2)]
            public Double pitchAngle {get; set;} = new Double();
                
            [XmlElementAttribute("yawAngle", Order=3)]
            public Double yawAngle {get; set;} = new Double();
                
             
        }  
    
        /** 
        Special information for SignalPostTelephone required by NR. 
Driver safety must be assessed and extra measures may be needed so that the driver can safely access the telephone.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/NR")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/NR",IsNullable=false)] 
             
        public  partial class SignalPostTelephone: sig.SignalPostTelephone
        {
            [XmlElementAttribute("conductorRailGuardBoardRequired", Order=1)]
            public String conductorRailGuardBoardRequired= "";
                
            [XmlElementAttribute("handSignalProhibited", Order=2)]
            public String handSignalProhibited= "";
                
            [XmlElementAttribute("limitedClearance", Order=3)]
            public String limitedClearance= "";
                
            [XmlElementAttribute("safeHandRailRequired", Order=4)]
            public String safeHandRailRequired= "";
                
            [XmlElementAttribute("walkway", Order=5)]
            public String walkway= "";
                
             
        }  
    
        /** 
        NR Signal sighting distance 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/NR")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/NR",IsNullable=false)] 
             
        public  partial class SignalSightingDistance: sig.SignalSightingDistance
        {
            [XmlElementAttribute("appliesToSignalFrame", Order=1)]
            public tElementWithIDref appliesToSignalFrame {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("bannerSignalRequired", Order=2)]
            public String bannerSignalRequired= "";
                
            [XmlElementAttribute("hasAchievableDistance", Order=3)]
            public rtmCommon.Length hasAchievableDistance {get; set;} = new rtmCommon.Length();
                
            [XmlElementAttribute("hasApproachSpeed", Order=4)]
            public rtmCommon.Speed hasApproachSpeed {get; set;} = new rtmCommon.Speed();
                
            [XmlElementAttribute("hasCombinedReadableDistance", Order=5)]
            public rtmCommon.Length hasCombinedReadableDistance {get; set;} = new rtmCommon.Length();
                
            [XmlElementAttribute("hasMinimumViewingDistance", Order=6)]
            public rtmCommon.Length hasMinimumViewingDistance {get; set;} = new rtmCommon.Length();
                
            [XmlElementAttribute("hasSupplementaryResponseTime", Order=7)]
            public rtmCommon.Duration hasSupplementaryResponseTime {get; set;} = new rtmCommon.Duration();
                
             
        }  
    
        /** 
        A set of properties that applies to a movable component with Network Rail.
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/NR")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/NR",IsNullable=false)] 
             
        public  partial class TurnoutComponentConfiguration: sig.TurnoutComponentConfiguration
        {
            [XmlElementAttribute("isOfPointControlType", Order=1)]
            public PointControlTypes isOfPointControlType {get; set;} = new PointControlTypes();
                
             
        }  
    
        /** 
        The associated track section is occupied when interrupter is activated/broken (only placed in derailer section; detects a train even if it is not on the rails anymore)
Can be associated with a buffer stop that constrains the position of the derailment detector.
Also known as track circuit interruptor. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/NR")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/NR",IsNullable=false)] 
             
        public  partial class DerailmentDetector: sig.VehicleSensor
        {
            [XmlElementAttribute("repeated", Order=1)]
            public Boolean repeated {get; set;} = new Boolean();
                
             
        }  
    
        /** 
        A raised construction for guiding cables across an obstacle. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/NR")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/NR",IsNullable=false)] 
             
        public  partial class CableBridge: sig.CableBridge
        {
            [XmlElementAttribute("bridgeNumber", Order=1)]
            public String bridgeNumber= "";
                
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/NR")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/NR",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(nr.FullDesignation))]     
        public  partial class Designation: sig.Designation
        {
            [XmlElementAttribute("longName", Order=1)]
            public String longName= "";
                
             
        }  
    
        /** 
        The construct for defining the types of equipment location references able to be located on the infrastructure. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/NR")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/NR",IsNullable=false)] 
             
        public  partial class EquipmentLocation: sig.ConfigurationProperty
        {
            [XmlElementAttribute("isOfEquipmentLocationType", Order=1)]
            public EquipmentLocationTypes isOfEquipmentLocationType {get; set;} = new EquipmentLocationTypes();
                
             
        }  
    
        /** 
        Used to be the signal box short code. Today, the line code is used. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/NR")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/NR",IsNullable=false)] 
             
        public  partial class FullDesignation: nr.Designation
        {
            [XmlElementAttribute("name", Order=1)]
            public String name= "";
                
            [XmlElementAttribute("prefix", Order=2)]
            public String prefix= "";
                
            [XmlElementAttribute("suffix", Order=3)]
            public String suffix= "";
                
             
        }  
    
        /** 
        Signalling Equivalent Unit (SEU) is used as a way of estimating the size of a signalling project , so this determines if a piece of equipment is counted as an SEU or part of one.
E.g. a signal &amp; a point are 1 SEU each regardless complexity and components. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/NR")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/NR",IsNullable=false)] 
             
        public  partial class SignallingEquivalentUnit: sig.ConfigurationProperty
        {
            [XmlElementAttribute("rate", Order=1)]
            public Double rate {get; set;} = new Double();
                
             
        }  
    
        public partial class SignallingEntities
        {
            internal string AddObject(Object myObject, string id = null)
            {
                switch (myObject)
                {
                
                    case nr.Obscuration myObscuration:
                        if (!ownsObscuration.Contains(myObscuration)) ownsObscuration.Append(myObject);
                        break;
                
                    case nr.PopGroup myPopGroup:
                        if (!ownsPopGroup.Contains(myPopGroup)) ownsPopGroup.Append(myObject);
                        break;
                
                    case nr.PopGroupAssociation myPopGroupAssociation:
                        if (!ownsPopGroupAssociation.Contains(myPopGroupAssociation)) ownsPopGroupAssociation.Append(myObject);
                        break;
                
                }
                return id;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/NR")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/NR",IsNullable=false)] 
             
        public  partial class SignallingEntities: dp.SignallingEntities
        {
            [XmlElementAttribute("ownsObscuration", Order=1)]
            public List<Obscuration> ownsObscuration { get; set; } = new List<Obscuration>(); 
                
            [XmlElementAttribute("ownsPopGroup", Order=2)]
            public List<PopGroup> ownsPopGroup { get; set; } = new List<PopGroup>(); 
                
            [XmlElementAttribute("ownsPopGroupAssociation", Order=3)]
            public List<PopGroupAssociation> ownsPopGroupAssociation { get; set; } = new List<PopGroupAssociation>(); 
                
             
        }  
    
        /** 
        Automatic Power Control Magnet.
Strictly speaking, this is not a train protection device but it uses the same technology to transmit information about the neutral section.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/NR")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/NR",IsNullable=false)] 
             
        public  partial class ApcMagnet: sig.TpsSpotDevice
        {
            [XmlElementAttribute("appliesToNeutralSection", Order=1)]
            public tElementWithIDref appliesToNeutralSection {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        A beacon in the ATP system.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/NR")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/NR",IsNullable=false)] 
             
        public  partial class AtpBeacon: sig.TpsSpotDevice
        {
             
        }  
    
        /** 
        Class for storing information about an AWS magnet. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/NR")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/NR",IsNullable=false)] 
             
        public  partial class AwsMagnet: sig.TpsSpotDevice
        {
            [XmlElementAttribute("positionInGroup", Order=1)]
            public Int32 positionInGroup {get; set;} = new Int32();
                
            [XmlElementAttribute("type", Order=2)]
            public String type= "";
                
             
        }  
    
        /** 
        Class for storing information about the properties of the AWS system. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/NR")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/NR",IsNullable=false)] 
             
        public  partial class AwsSystemProperties: sig.TpsDataTransmissionSystemProperties
        {
            [XmlElementAttribute("type", Order=1)]
            public String type= "";
                
             
        }  
    
        /** 
        TPWS loop.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/NR")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/NR",IsNullable=false)] 
             
        public  partial class TpwsDevice: sig.TpsSpotDevice
        {
            [XmlElementAttribute("hasFrequency", Order=1)]
            public List<TpwsFrequencyTypes> hasFrequency { get; set; } = new List<TpwsFrequencyTypes>(); 
                
            [XmlElementAttribute("positionInGroup", Order=2)]
            public Int32 positionInGroup {get; set;} = new Int32();
                
             
        }  
    
        /** 
        TPWS system property set. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/NR")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/NR",IsNullable=false)] 
             
        public  partial class TpwsSystemProperties: sig.TpsDataTransmissionSystemProperties
        {
            [XmlElementAttribute("hasTpwsFunction", Order=1)]
            public TpwsFunctionTypes hasTpwsFunction {get; set;} = new TpwsFunctionTypes();
                
            [XmlElementAttribute("hasTpwsTrainCategorySpecificProperties", Order=2)]
            public List<TpwsTrainCategorySpecificProperties> hasTpwsTrainCategorySpecificProperties { get; set; } = new List<TpwsTrainCategorySpecificProperties>(); 
                
            [XmlElementAttribute("isOfTpwsSystemType", Order=3)]
            public TpwsSystemTypes isOfTpwsSystemType {get; set;} = new TpwsSystemTypes();
                
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/NR")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/NR",IsNullable=false)] 
             
        public  partial class TpwsTrainCategorySpecificProperties
        {
            [XmlElementAttribute("appliesToTrainCategoryForMaximumOverrunDistance", Order=1)]
            public tElementWithIDref appliesToTrainCategoryForMaximumOverrunDistance;
                
            [XmlElementAttribute("hasMaximumOverrunDistance", Order=2)]
            public rtmCommon.Length hasMaximumOverrunDistance {get; set;} = new rtmCommon.Length();
                
             
        }  
    
        /** 
        Line-side mechanical device that activates the train's trip cock. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/NR")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/NR",IsNullable=false)] 
             
        public  partial class TrainStop: sig.TpsSpotDevice
        {
            [XmlElementAttribute("type", Order=1)]
            public String type= "";
                
             
        }  
    
        /** 
        Line-side device for testing the trainborne trip cock. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/NR")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/NR",IsNullable=false)] 
             
        public  partial class TripcockTester: sig.TpsSpotDevice
        {
            [XmlElementAttribute("type", Order=1)]
            public String type= "";
                
             
        }  
    
    public enum LevelCrossingControlTypes : int {
        /*  */AHB,/*  */ABCL,/*  */MCB,/* MCB-OD */MCB_OD,/* MCB(RBC) */MCB_RBC,/*  */CCTV,/*  */AOCL,/*  */barrow,/*  */footpath,/*  */bridleway,/*  */authorisedStaffCrossing,/*  */userWorkedTelephone,/*  */userWorkedMiniatureWarningLights,/*  */userWorkedBarrierMiniatureWarningLights,/*  */trainCrewOperatedBarriers,/*  */trainCrewOperatedGates,/*  */openCrossing,/*  */pedestrianMiniatureStopLights,/*  */vehicularMiniatureStopLights,/*  */mannedGates,/*  */AFBC
    }
    
    public enum MrotTypes : int {
        /* Minimum road opening time of 10 seconds. */Mrot10,/* Minimum road opening time of 20 seconds. */Mrot20
    }
    
    public enum BackBoardTypes : int {
        /*  */yes,/*  */no,/*  */notApplicable
    }
    
    public enum ConfusionRiskWithOtherSignalsTypes : int {
        /*  */yes,/*  */no,/*  */notApplicable
    }
    
    public enum HoodsLengthTypes : int {
        /*  */standard,/*  */longHood,/*  */none
    }
    
    public enum ImageTypes : int {
        /*  */CloseImage,/*  */RearImage,/*  */MinimumReadingDistanceImage,/*  */VegetationImage,/*  */VisionPlot,/*  */PlatformStartingSignal,/*  */PhotoTrainDispatch
    }
    
    public enum LensDiffuserTypes : int {
        /*  */longRangeWideBeam,/*  */longRangeNarrowBeam,/*  */mediumRangeWideBeam,/*  */mediumRangeNarrowBeam,/*  */shortRange
    }
    
    public enum ReadThroughRiskTypes : int {
        /*  */nil,/*  */slight,/*  */significant
    }
    
    public enum SignalBeyondVisibleTypes : int {
        /*  */yes,/*  */no,/*  */notApplicable
    }
    
    public enum PointControlTypes : int {
        /* Point Operating Mechanism in the 6-foot. */sixFootPointMachine,/* Point Operating Mechanism in the 4-foot. */fourFootPointMachine,/* Trailable Power Operated Point Mechanism. */yardPointMachine
    }
    
    public enum EquipmentLocationTypes : int {
        /* Equipment mounted at junctions (Junction Equipment). */junction,/* Equipment mounted between the rails (Sleeper Equipment). */sleeper,/* Equipment mounted on the rail (Rail Equipment). */rail,/* Equipment mounted at a point related to the track (Track Equipment). */track,/* Equipment covering a section or sections of track (Section Equipment). */section,/* Equipment covering an area related to the track. */area,/*  */other
    }
    
    public enum TpwsFrequencyTypes : int {
        /*  */f1,/*  */f2,/*  */f3,/*  */f4,/*  */f5,/*  */f6,/*  */f5_f6
    }
    
    public enum TpwsFunctionTypes : int {
        /* OverSpeed Sensor (OSS - speed check). */uniDirectionalOverSpeed,/* Trains Stop (TSS). */uniDirectionalTrainStop
    }
    
    public enum TpwsSystemTypes : int {
        /*  */normal,/*  */opposite
    }
    
} 
            