 
using System; 
using System.Collections.Generic; 
using System.Text; using System.IO; 
using System.Xml.Serialization; 
using System.Linq;
     
using rtmCommon = Models.TopoModels.EULYNX.rtmCommon;

namespace Models.TopoModels.EULYNX.rtmCommon {
    
        public partial class tElementWithIDref { }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(rtmCommon.NamedResource))]
        [XmlIncludeAttribute(typeof(rtmCommon.NetworkLevel))]
        [XmlIncludeAttribute(typeof(rtmCommon.AssociatedPositioningSystem))]
        [XmlIncludeAttribute(typeof(rtmCommon.IntrinsicCoordinate))]
        [XmlIncludeAttribute(typeof(rtmCommon.LinearAnchorPoint))]
        [XmlIncludeAttribute(typeof(rtmCommon.ElementPartCollection))]
        [XmlIncludeAttribute(typeof(rtmCommon.AlignmentCurve))]
        [XmlIncludeAttribute(typeof(rtmCommon.HorizontalAlignmentSegment))]
        [XmlIncludeAttribute(typeof(rtmCommon.VerticalAlignmentSegment))]
        [XmlIncludeAttribute(typeof(rtmCommon.AlignmentCantSegment))]
        [XmlIncludeAttribute(typeof(rtmCommon.DiscretisedPointSet))]
        [XmlIncludeAttribute(typeof(rtmCommon.ThreeDAlignmentCurve))]
        [XmlIncludeAttribute(typeof(rtmCommon.BaseLocation))]
        [XmlIncludeAttribute(typeof(sig.BaseObject))]     
        public abstract partial class BaseObject
        {
            [XmlElementAttribute("id", Order=1)]
            public String id= "";
                
             
        }  
    
        /** 
        Abstract property class, needed to put the composite pattern at work. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(rtmCommon.ObservableProperty))]
        [XmlIncludeAttribute(typeof(rtmCommon.PropertySet))]     
        public abstract partial class BaseProperty: rtmCommon.NamedResource
        {
            [XmlElementAttribute("appliesTo", Order=1)]
            public List<tElementWithIDref> appliesTo { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        Quantity of kind duration, delay, timer, etc. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class Duration: rtmCommon.Quantity
        {
             
        }  
    
        /** 
        Quantity of kind gradient, slope, ramp, etc. 
Uphill is positive, downhill is negative. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class Gradient: rtmCommon.Quantity
        {
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class Inertia: rtmCommon.Quantity
        {
             
        }  
    
        /** 
        Quantity of kind length, distance, height, width, etc.
The quantity kind must be a Length. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class Length: rtmCommon.Quantity
        {
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class Mass: rtmCommon.Quantity
        {
             
        }  
    
        /** 
        A resource that has a name. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(rtmCommon.BaseProperty))]
        [XmlIncludeAttribute(typeof(rtmCommon.QuantityKind))]
        [XmlIncludeAttribute(typeof(rtmCommon.Unit))]
        [XmlIncludeAttribute(typeof(rtmCommon.Network))]
        [XmlIncludeAttribute(typeof(rtmCommon.NetworkResource))]
        [XmlIncludeAttribute(typeof(rtmCommon.PositioningSystem))]
        [XmlIncludeAttribute(typeof(rtmCommon.Circumstance))]
        [XmlIncludeAttribute(typeof(rtmCommon.InformationSource))]
        [XmlIncludeAttribute(typeof(rtmCommon.Sensor))]
        [XmlIncludeAttribute(typeof(rtmCommon.TimeReferenceSystem))]     
        public abstract partial class NamedResource: rtmCommon.BaseObject
        {
            [XmlElementAttribute("longname", Order=1)]
            public String longname= "";
                
            [XmlElementAttribute("name", Order=2)]
            public String name= "";
                
             
        }  
    
        /** 
        Definition: see <a href="https://www.w3.org/TR/vocab-ssn/#SOSAObservableProperty"><font color="#0000ff"><u>https://www.w3.org/TR/vocab-ssn/#SOSAObservableProperty</u></font></a> .
This class embodies all properties that need to be referenced by another class in this model (or a model using the present model). While platform-specific code may reference any public attribute or property, UML2.5 (used here to build a platform-independent model) does not allow a class to reference directly an attribute of another class, even if it is public. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(rtmCommon.PositioningSystemCoordinate))]     
        public  partial class ObservableProperty: rtmCommon.BaseProperty
        {
            [XmlElementAttribute("quantity", Order=1)]
            public List<Quantity> quantity { get; set; } = new List<Quantity>(); 
                
             
        }  
    
        /** 
        Group of properties. Intended grouping is "mechanical properties", "actual state", or the like, rather than sampled values of the same properties (observations and value sampling are the concerns of another package). 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class PropertySet: rtmCommon.BaseProperty
        {
            [XmlElementAttribute("contains", Order=1)]
            public List<tElementWithIDref> contains { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        Allows quantification of Properties, as well as for other purposes (e.g. observation and samples). 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(rtmCommon.Duration))]
        [XmlIncludeAttribute(typeof(rtmCommon.Gradient))]
        [XmlIncludeAttribute(typeof(rtmCommon.Inertia))]
        [XmlIncludeAttribute(typeof(rtmCommon.Length))]
        [XmlIncludeAttribute(typeof(rtmCommon.Mass))]
        [XmlIncludeAttribute(typeof(rtmCommon.Speed))]
        [XmlIncludeAttribute(typeof(rtmCommon.Result))]
        [XmlIncludeAttribute(typeof(rtmCommon.TimeValue))]     
        public abstract partial class Quantity
        {
            [XmlElementAttribute("quantityKind", Order=1)]
            public tElementWithIDref quantityKind {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("unit", Order=2)]
            public tElementWithIDref unit {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("value", Order=3)]
            public Double value {get; set;} = new Double();
                
             
        }  
    
        /** 
        A Quantity of a given QuantityKind contains a numerical value expressed in a particular measurement unit. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class QuantityKind: rtmCommon.NamedResource
        {
            [XmlElementAttribute("definitionURI", Order=1)]
            public String definitionURI= "";
                
            [XmlElementAttribute("scale", Order=2)]
            public Scale scale {get; set;} = new Scale();
                
            [XmlElementAttribute("symbol", Order=3)]
            public String symbol= "";
                
             
        }  
    
        /** 
        For measuring a quantity on a scale such as Celsius, Kelvin, Beaufort, Richter.
A measurement scale is an ordered set of quantity values of quantities of a given kind of quantity used in ranking, according to magnitude, quantities of that kind.
A scale may need a unit such as "degree". 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class Scale
        {
            [XmlElementAttribute("unit", Order=1)]
            public tElementWithIDref unit {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("valueDefinition", Order=2)]
            public List<ScaleValueDefinition> valueDefinition { get; set; } = new List<ScaleValueDefinition>(); 
                
             
        }  
    
        /** 
        Derived from OMG SysML 1.2 : see <a href="http://www.omgwiki.org/OMGSysML/lib/exe/fetch.php?media=sysml-qudv:annex_c.5_2009-08-26.pdf"><font color="#0000ff"><u>http://www.omgwiki.org/OMGSysML/lib/exe/fetch.php?media=sysml-qudv:annex_c.5_2009-08-26.pdf</u></font></a> , figure C8.
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class ScaleValueDefinition
        {
            [XmlElementAttribute("description", Order=1)]
            public String description= "";
                
            [XmlElementAttribute("value", Order=2)]
            public Double value {get; set;} = new Double();
                
             
        }  
    
        /** 
        Quantity of kind speed. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class Speed: rtmCommon.Quantity
        {
             
        }  
    
        /** 
        It is strongly recommended for implementations of new systems to use the UUID type definition. If this is not possible a parallel ID of type UUID should be implemented to allow for global compatibility. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public abstract partial class tID
        {
             
        }  
    
        /** 
        Derived from OMG SysML 1.2 : see <a href="http://www.omgwiki.org/OMGSysML/lib/exe/fetch.php?media=sysml-qudv:annex_c.5_2009-08-26.pdf"><font color="#0000ff"><u>http://www.omgwiki.org/OMGSysML/lib/exe/fetch.php?media=sysml-qudv:annex_c.5_2009-08-26.pdf</u></font></a> , figure C8.
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class Unit: rtmCommon.NamedResource
        {
            [XmlElementAttribute("definitionURI", Order=1)]
            public String definitionURI= "";
                
            [XmlElementAttribute("symbol", Order=2)]
            public String symbol= "";
                
             
        }  
    
        /** 
        An instance of “Network” can be considered as a set of description levels (“LevelNetwork”) and a set of “NetworkResource” instances.

A "Network" is described in at least one "LevelNetwork". A "Network" may be described in more than one "LevelNetwork", typically for different levels of detail. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class Network: rtmCommon.NamedResource
        {
            [XmlElementAttribute("levels", Order=1)]
            public List<tElementWithIDref> levels { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("networkResources", Order=2)]
            public List<tElementWithIDref> networkResources { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        LevelNetwork depicts a specific description level and defines a consistent "view" of a Network at a certain level of granularity. An instance of this class therefore includes all resources that are required to define the corresponding level (e.g. micro/track, or macro/line).
The concept of description level is central to the goal of computational efficiency. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class NetworkLevel: rtmCommon.BaseObject
        {
            [XmlElementAttribute("hasDescriptionLevel", Order=1)]
            public DescriptionLevel hasDescriptionLevel {get; set;} = new DescriptionLevel();
                
            [XmlElementAttribute("networkResources", Order=2)]
            public List<tElementWithIDref> networkResources { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        Every object of the network is qualified as a resource. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(rtmNE.NetEntity))]
        [XmlIncludeAttribute(typeof(rtmNE.NetProperty))]
        [XmlIncludeAttribute(typeof(rtmCommon.NetElement))]
        [XmlIncludeAttribute(typeof(rtmCommon.Relation))]     
        public abstract partial class NetworkResource: rtmCommon.NamedResource
        {
             
        }  
    
        /** 
        Describes the relation between a PositioningNetElement and a PositioningSystem 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class AssociatedPositioningSystem: rtmCommon.BaseObject
        {
            [XmlElementAttribute("intrinsicCoordinates", Order=1)]
            public List<IntrinsicCoordinate> intrinsicCoordinates { get; set; } = new List<IntrinsicCoordinate>(); 
                
            [XmlElementAttribute("positioningSystem", Order=2)]
            public tElementWithIDref positioningSystem {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Cartesian coordinates. The x,y, z units are defined by the associated positioning system.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class CartesianCoordinate: rtmCommon.GeometricCoordinate
        {
            [XmlElementAttribute("x", Order=1)]
            public Double x {get; set;} = new Double();
                
            [XmlElementAttribute("y", Order=2)]
            public Double y {get; set;} = new Double();
                
            [XmlElementAttribute("z", Order=3)]
            public Double z {get; set;} = new Double();
                
             
        }  
    
        /** 
        Lattitude, longitude and height. the datum and units are defined by the assocatied positioning system. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class GeographicCoordinate: rtmCommon.GeometricCoordinate
        {
            [XmlElementAttribute("height", Order=1)]
            public Double height {get; set;} = new Double();
                
            [XmlElementAttribute("latitude", Order=2)]
            public Double latitude {get; set;} = new Double();
                
            [XmlElementAttribute("longitude", Order=3)]
            public Double longitude {get; set;} = new Double();
                
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(rtmCommon.CartesianCoordinate))]
        [XmlIncludeAttribute(typeof(rtmCommon.GeographicCoordinate))]     
        public abstract partial class GeometricCoordinate: rtmCommon.PositioningSystemCoordinate
        {
             
        }  
    
        /** 
        Defines schematic, geographic or geodetic coordinate reference systems (CRS) used to position instances of NetElement or NetEntity. GeometricPositioningSystem instances support the transformation between intrinsic locations and geometric coordinates. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class GeometricPositioningSystem: rtmCommon.PositioningSystem
        {
            [XmlElementAttribute("crsDefinition", Order=1)]
            public String crsDefinition= "";
                
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class IntrinsicCoordinate: rtmCommon.BaseObject
        {
            [XmlElementAttribute("coordinates", Order=1)]
            public List<tElementWithIDref> coordinates { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("value", Order=2)]
            public Double value {get; set;} = new Double();
                
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class LinearAnchorPoint: rtmCommon.BaseObject
        {
            [XmlElementAttribute("anchorName", Order=1)]
            public String anchorName= "";
                
            [XmlElementAttribute("measure", Order=2)]
            public Double measure {get; set;} = new Double();
                
            [XmlElementAttribute("measureToNext", Order=3)]
            public Double measureToNext {get; set;} = new Double();
                
             
        }  
    
        /** 
        A curvilinear abscissa, optional vertical and lateral offset.
The units are defined by the associated positioning system. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class LinearCoordinate: rtmCommon.PositioningSystemCoordinate
        {
            [XmlElementAttribute("lateralOffset", Order=1)]
            public Length lateralOffset {get; set;} = new Length();
                
            [XmlElementAttribute("measure", Order=2)]
            public Double measure {get; set;} = new Double();
                
            [XmlElementAttribute("verticalOffset", Order=3)]
            public Length verticalOffset {get; set;} = new Length();
                
             
        }  
    
        /** 
        Defines a Positioning System where a line of reference, in combination with a single number allows locating within a railway network.
The start- and end-measure represent the length of this line of reference and use the same units, e.g. 0.0 m to 422.8 m or 3.3 furlong to 34.2 furlong.
The units of linear abscissa use the same unit as the start and end-measure.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class LinearPositioningSystem: rtmCommon.PositioningSystem
        {
            [XmlElementAttribute("anchors", Order=1)]
            public List<LinearAnchorPoint> anchors { get; set; } = new List<LinearAnchorPoint>(); 
                
            [XmlElementAttribute("endMeasure", Order=2)]
            public Length endMeasure {get; set;} = new Length();
                
            [XmlElementAttribute("hasLinearReferencingMethod", Order=3)]
            public LrsMethod hasLinearReferencingMethod {get; set;} = new LrsMethod();
                
            [XmlElementAttribute("startMeasure", Order=4)]
            public Length startMeasure {get; set;} = new Length();
                
             
        }  
    
        /** 
        A spatial reference system in which a position can be expressed in terms of coordinates. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(rtmCommon.GeometricPositioningSystem))]
        [XmlIncludeAttribute(typeof(rtmCommon.LinearPositioningSystem))]     
        public  partial class PositioningSystem: rtmCommon.NamedResource
        {
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(rtmCommon.GeometricCoordinate))]
        [XmlIncludeAttribute(typeof(rtmCommon.LinearCoordinate))]     
        public  partial class PositioningSystemCoordinate: rtmCommon.ObservableProperty
        {
            [XmlElementAttribute("positioningSystem", Order=1)]
            public tElementWithIDref positioningSystem {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Allows the nodes to aggregate into bigger nodes. This allows zooming in and out, showing or hiding levels of detail.
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(rtmCommon.PositioningNetElement))]     
        public abstract partial class CompositionNetElement: rtmCommon.NetElement
        {
            [XmlElementAttribute("elementCollections", Order=1)]
            public List<ElementPartCollection> elementCollections { get; set; } = new List<ElementPartCollection>(); 
                
             
        }  
    
        /** 
        Defines a collection of NetElements that can aggregate into a higher level NetElement class.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(rtmCommon.OrderedCollection))]
        [XmlIncludeAttribute(typeof(rtmCommon.UnorderedCollection))]     
        public  partial class ElementPartCollection: rtmCommon.BaseObject
        {
             
        }  
    
        /** 
        A one-dimensional topological (curvi-)linear element. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class LinearElement: rtmCommon.PositioningNetElement
        {
             
        }  
    
        /** 
        The base member of topology in a connectivity graph representing the network (at any level).
An NetElement has relations with one or more other NetElements. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(rtmCommon.CompositionNetElement))]     
        public  partial class NetElement: rtmCommon.NetworkResource
        {
            [XmlElementAttribute("relation", Order=1)]
            public List<tElementWithIDref> relation { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        A topological element that isn't (curvi-)linear, i.e. area or point. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class NonLinearElement: rtmCommon.PositioningNetElement
        {
             
        }  
    
        /** 
        Ordered collection of NetElements. 
Elements are ordered inside the collection via the role elementParts.
Moreover, the user may define several ordered collections and decide to order the ordered collections themselves, using the "sequence" attribute.

<i>Suggested use case: starting from a micro-level description of a dense area, create CompositionNetElements representing all possible paths (disjoint or overlapping). Each path is an OrderedCollection and points to an ordered list of NetElements. NetElements can be shared by several paths. Paths can be ordered (using the sequence attribute), where the meaning of the order is left to the user. The order may be absolute (all 'sequence' values are distinct) or relative (two OrderedCollections may bear the same 'sequence' attribute).</i> 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class OrderedCollection: rtmCommon.ElementPartCollection
        {
            [XmlElementAttribute("elementParts", Order=1)]
            public List<tElementWithIDref> elementParts { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("sequence", Order=2)]
            public Int32 sequence {get; set;} = new Int32();
                
             
        }  
    
        /** 
        The positioned relation defines an oriented relation between exactly two PositioningNetElements.
An instance of this class is equivalent to an edge in a connectivity graph 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class PositionedRelation: rtmCommon.Relation
        {
            [XmlElementAttribute("elementA", Order=1)]
            public tElementWithIDref elementA {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("elementB", Order=2)]
            public tElementWithIDref elementB {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("navigability", Order=3)]
            public Navigability navigability {get; set;} = new Navigability();
                
            [XmlElementAttribute("positionOnA", Order=4)]
            public Usage positionOnA {get; set;} = new Usage();
                
            [XmlElementAttribute("positionOnB", Order=5)]
            public Usage positionOnB {get; set;} = new Usage();
                
             
        }  
    
        /** 
        Topological element in the network that requires at least one positioning system and an orientation, carried by the intrinsic coordinate.
A concrete class, reflecting the fact that the "linear" or "non-linear" character of a given part of the network may depend on the context: at micro level, there is no ambiguity, but ambiguities may well arise at macro level for instance. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(rtmCommon.LinearElement))]
        [XmlIncludeAttribute(typeof(rtmCommon.NonLinearElement))]     
        public  partial class PositioningNetElement: rtmCommon.CompositionNetElement
        {
            [XmlElementAttribute("associatedPositioningSystems", Order=1)]
            public List<AssociatedPositioningSystem> associatedPositioningSystems { get; set; } = new List<AssociatedPositioningSystem>(); 
                
            [XmlElementAttribute("intrinsicCoordinate", Order=2)]
            public List<IntrinsicCoordinate> intrinsicCoordinate { get; set; } = new List<IntrinsicCoordinate>(); 
                
             
        }  
    
        /** 
        Base class for defining edges in the sense of graph theory. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(rtmCommon.PositionedRelation))]     
        public  partial class Relation: rtmCommon.NetworkResource
        {
             
        }  
    
        /** 
        An unordered collection has no specific begin and end. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class UnorderedCollection: rtmCommon.ElementPartCollection
        {
            [XmlElementAttribute("elementParts", Order=1)]
            public List<tElementWithIDref> elementParts { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        Class "AlignmentCurve" provides the most used description of railway alignment curves in space, which is by projections. The horizontal projection "HorizontalAlignment" is broken down into a set of segments, each segment having definite geometric characteristics.

The same applies to "VerticalAlignment", that may however be missing (hence the 0..1 multiplicity) at early project stages..

Segment boundaries, for vertical and horizontal alignment, do not necessarily coincide.

Finally, lateral inclination provides a way to describe the twist or cant applied to a track (specialized class "RailwayAlignmentCant") or, more generally, to the trackbed, bridge deck, or similar. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class AlignmentCurve: rtmCommon.BaseObject
        {
            [XmlElementAttribute("hasHorizontalAlignment", Order=1)]
            public HorizontalAlignment hasHorizontalAlignment {get; set;} = new HorizontalAlignment();
                
            [XmlElementAttribute("hasLateralInclination", Order=2)]
            public LateralInclination hasLateralInclination {get; set;} = new LateralInclination();
                
            [XmlElementAttribute("hasVerticalAlignment", Order=3)]
            public VerticalAlignment hasVerticalAlignment {get; set;} = new VerticalAlignment();
                
             
        }  
    
        /** 
        The horizontal alignment is composed of a set of ordered horizontal alignment segments. Each  segment can be of one of the following three geometry types:
<ul>
 <li>straight line</li>
 <li>arc of a circle</li>
 <li>transition curve</li>
</ul>

The horizontal alignment delivers the metric for the linear reference system used to position the vertical alignment segments and the cant segments. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class HorizontalAlignment
        {
            [XmlElementAttribute("isStructuredIn", Order=1)]
            public List<tElementWithIDref> isStructuredIn { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        Abstract class representing any kind of horizontal alignment segment.
Geometric segments are used to define the horizontal alignment. The segments are ordered. Each horizontal segment is defined with:
<ul>
 <li>a starting point known by its cartesian coordinates</li>
 <li>the starting direction in form of an azimuth [gon] or alternatively [rad](radiant).</li>
 <li>the segment length in [m]</li>
 <li>the information on how the segment is connected to the following segment. This information is used to describe possible discontinuities (e.g. if there is a horizontal bend).</li>
</ul>

Additionally:
<ul>
 <li>a radius, for arc segments</li>
 <li>an initial and final radius for transition segments as well as the type of transition curve. Some transition curves require additional parameters.</li>
</ul> 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(rtmCommon.HorizontalSegmentLine))]
        [XmlIncludeAttribute(typeof(rtmCommon.HorizontalSegmentArc))]
        [XmlIncludeAttribute(typeof(rtmCommon.HorizontalSegmentTransition))]     
        public abstract partial class HorizontalAlignmentSegment: rtmCommon.BaseObject
        {
            [XmlElementAttribute("HasLinearLocation", Order=1)]
            public LinearLocation HasLinearLocation {get; set;} = new LinearLocation();
                
             
        }  
    
        /** 
        Geometric primitive. All required attributes are defined in the class "HorizontalAlignmentSegment".
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class HorizontalSegmentLine: rtmCommon.HorizontalAlignmentSegment
        {
             
        }  
    
        /** 
        Geometric primitive for Arc of circle.
All Attributes except the radius are defined in the class "HorizontalAlignmentSegment".

 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class HorizontalSegmentArc: rtmCommon.HorizontalAlignmentSegment
        {
             
        }  
    
        /** 
        Geometric primitive for transition curves.
All the attributes except the type of transition curve and initial and final radius are defined in the class "HorizontalAlignmentSegment".

 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class HorizontalSegmentTransition: rtmCommon.HorizontalAlignmentSegment
        {
             
        }  
    
        /** 
        The vertical alignment is composed of a set of ordered vertical alignment segments. Each  segment can be of one of the following three geometry types:
<ul>
 <li>straight line</li>
 <li>arc of a circle</li>
 <li>transition curve</li>
</ul> 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class VerticalAlignment
        {
            [XmlElementAttribute("isStructuredIn", Order=1)]
            public List<tElementWithIDref> isStructuredIn { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        Abstract class representing any kind of vertical alignment segment.
Geometric segments are used to define the vertical alignment. The segments are ordered. Each vertical segment is defined with:
<ul>
 <li>a starting point known by its distance along the horizontal alignment [m]</li>
 <li>the starting point elevation in [m]</li>
 <li>the starting direction as a gradient [‰]</li>
 <li>the segment length in [m]</li>
 <li>the information on how the segment is connected to the following segment. This information is used to describe possible discontinuities (e.g. if there is a vertical bend).</li>
</ul>

Additionally:
<ul>
 <li>a radius, for arc segments [m]</li>
 <li>the initial and final radius for transition segments as well as the type of transition curve. Some transition curves require additional parameters.</li>
</ul>

The elevation (= Cartesian Z-coordinate) of the starting point, the segment length and the starting gradient are defined for each geometric element. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(rtmCommon.VerticalSegmentLine))]
        [XmlIncludeAttribute(typeof(rtmCommon.VerticalSegmentArc))]
        [XmlIncludeAttribute(typeof(rtmCommon.VerticalSegmentTransition))]     
        public abstract partial class VerticalAlignmentSegment: rtmCommon.BaseObject
        {
            [XmlElementAttribute("HasLinearLocation", Order=1)]
            public LinearLocation HasLinearLocation {get; set;} = new LinearLocation();
                
             
        }  
    
        /** 
        Geometric primitive. All required attributes are defined in the class "Vertical AlignmentSegment".

 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class VerticalSegmentLine: rtmCommon.VerticalAlignmentSegment
        {
             
        }  
    
        /** 
        Geometric primitive for Arc of circle.
All Attributes except the radius are defined in the class "VerticalAlignmentSegment".

 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class VerticalSegmentArc: rtmCommon.VerticalAlignmentSegment
        {
             
        }  
    
        /** 
        Geometric primitive for transition curves.
All the attributes except the type of transition curve and initial and final radius are defined in the class "VerticalAlignmentSegment".
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class VerticalSegmentTransition: rtmCommon.VerticalAlignmentSegment
        {
             
        }  
    
        /** 
        The lateral inclination is a generic class serving as a reference for the description of any kind of inclination related to an alignment curve i.e.  for describing cross sections for road or cant for railways. So lateral inclination is independent from the usage i.e. road or rail. 
For the purpose of railway the spezialized class RailwayAlignmentCant will be used. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(rtmCommon.RailwayAlignmentCant))]     
        public  partial class LateralInclination
        {
             
        }  
    
        /** 
        The railway cant alignment is composed of geometric segments with the two following geometry types
<ul>
 <li>Straight line for constant cant or constant change of cant </li>
 <li>Transition curve for curved cant</li>
</ul> 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class RailwayAlignmentCant: rtmCommon.LateralInclination
        {
            [XmlElementAttribute("isStructuredIn", Order=1)]
            public List<tElementWithIDref> isStructuredIn { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        Geometric segments are used to define the railway cant. The segments are ordered. Each cant segment is defined with:
<ul>
 <li>a starting point known by its distance along the horizontal alignment [m] </li>
 <li>the segment length in [m] </li>
 <li>the start cant value in [mm] </li>
 <li>the end cant value in [mm] </li>
 <li>the information on how the segment is connected to the following segment. This information is used to describe possible discontinuities (e.g. invalid sudden change of cant or missing cant information if end point and starting point differ over a threshold).</li>
</ul>

Additionally:<ul>
 <li>an information which describes if a smoothing was applied between two cant segments</li>
</ul> 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(rtmCommon.SegmentCantLine))]
        [XmlIncludeAttribute(typeof(rtmCommon.SegmentCantTransition))]     
        public abstract partial class AlignmentCantSegment: rtmCommon.BaseObject
        {
            [XmlElementAttribute("hasLinearLocation", Order=1)]
            public LinearLocation hasLinearLocation {get; set;} = new LinearLocation();
                
             
        }  
    
        /** 
        Geometric primitive. All needed attributes are defined in the class "AlignmentCantSegment".
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class SegmentCantLine: rtmCommon.AlignmentCantSegment
        {
             
        }  
    
        /** 
        Geometric primitive for transition curves.
All the attributes except the type of transition curve and initial and final radius are defined in the class "AlignmentCantSegment". 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class SegmentCantTransition: rtmCommon.AlignmentCantSegment
        {
             
        }  
    
        /** 
        A set of points that can be spot-located. Typically the product of a position sampling process such as a land survey, photogrammetry, a measurement campaign with satellite receivers or a mix of these. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class DiscretisedPointSet: rtmCommon.BaseObject
        {
            [XmlElementAttribute("isDescribedWithPoints", Order=1)]
            public List<DiscretisedPoint> isDescribedWithPoints { get; set; } = new List<DiscretisedPoint>(); 
                
            [XmlElementAttribute("isSubsetOf", Order=2)]
            public List<tElementWithIDref> isSubsetOf { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        A geometric point that is a sample of a discretized point set. The class can inform about the sampling process that produced this point. Role "location" points to a SpotLocation, which is the abstraction for "point in space". This allows to document the location in one or more reference system(s). 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(rtmCommon.RailwayDiscretisedPoint))]     
        public  partial class DiscretisedPoint
        {
            [XmlElementAttribute("hasSpotLocation", Order=1)]
            public SpotLocation hasSpotLocation {get; set;} = new SpotLocation();
                
             
        }  
    
        /** 
        A geometric point that is a sample of a railway alignment. 
Can bear geometric attributes such as locally measured cant values, etc.
More generally, geometric properties that cannot be represented by SpotLocation (which is the abstraction of a "point in space"), such as twist or the rotation of some local coordinate system, shall be described here.
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class RailwayDiscretisedPoint: rtmCommon.DiscretisedPoint
        {
             
        }  
    
        /** 
        Class holding the definition of a geometrical element in 3-D space, as a set of equations, possibly involving up to six coordinates (e.g. x, y, z, rho, theta, phi).

The class holds a reference to the coordinate reference system in which the equations are expressed.

The class also holds a reference to a linear location on the network. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class ThreeDAlignmentCurve: rtmCommon.BaseObject
        {
            [XmlElementAttribute("hasCoordinateReferenceSystem", Order=1)]
            public tElementWithIDref hasCoordinateReferenceSystem {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("hasLinearLocation", Order=2)]
            public LinearLocation hasLinearLocation {get; set;} = new LinearLocation();
                
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class TimedLocation: rtmCommon.BaseLocation
        {
             
        }  
    
        /** 
        Defines point location information for a LocatedNetentity instance. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class SpotLocation: rtmCommon.BaseLocation
        {
            [XmlElementAttribute("associatedNetElements", Order=1)]
            public List<AssociatedNetElement> associatedNetElements { get; set; } = new List<AssociatedNetElement>(); 
                
            [XmlElementAttribute("coordinates", Order=2)]
            public List<tElementWithIDref> coordinates { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class LinearLocationCoordinate: rtmCommon.LinearLocation
        {
            [XmlElementAttribute("coordinates", Order=1)]
            public List<tElementWithIDref> coordinates { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        Defines location information with a startpoint and an endpoint. Refers to an ordered set of one or more PositioningNetElement instances. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(rtmCommon.LinearLocationCoordinate))]     
        public  partial class LinearLocation: rtmCommon.BaseLocation
        {
            [XmlElementAttribute("associatedElements", Order=1)]
            public List<AssociatedNetElement> associatedElements { get; set; } = new List<AssociatedNetElement>(); 
                
            [XmlElementAttribute("associatedNetElements", Order=2)]
            public List<AssociatedNetElement> associatedNetElements { get; set; } = new List<AssociatedNetElement>(); 
                
             
        }  
    
        /** 
        Provides topological and position information "Location" is an abstraction for "some place in space that is <b>used </b>by some NetEntity". We can relate the location to network topology elements, and associate it with positions in some reference system.
BaseLocation, as an abstract class, is the ancestor of actually usable locations (spot, linear, or area). 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(rtmCommon.TimedLocation))]
        [XmlIncludeAttribute(typeof(rtmCommon.SpotLocation))]
        [XmlIncludeAttribute(typeof(rtmCommon.LinearLocation))]
        [XmlIncludeAttribute(typeof(rtmCommon.AreaLocation))]     
        public abstract partial class BaseLocation: rtmCommon.BaseObject
        {
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class AssociatedNetElementIntrinsic: rtmCommon.AssociatedNetElement
        {
            [XmlElementAttribute("intrinsicCoordValues", Order=1)]
            public List<Double> intrinsicCoordValues { get; set; } = new List<Double>(); 
                
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class AssociatedNetElementCoordinate: rtmCommon.AssociatedNetElement
        {
            [XmlElementAttribute("extremities", Order=1)]
            public List<tElementWithIDref> extremities { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(rtmCommon.AssociatedNetElementIntrinsic))]
        [XmlIncludeAttribute(typeof(rtmCommon.AssociatedNetElementCoordinate))]     
        public  partial class AssociatedNetElement
        {
            [XmlElementAttribute("appliesInDirection", Order=1)]
            public ApplicationDirection appliesInDirection {get; set;} = new ApplicationDirection();
                
            [XmlElementAttribute("bounds", Order=2)]
            public List<IntrinsicCoordinate> bounds { get; set; } = new List<IntrinsicCoordinate>(); 
                
            [XmlElementAttribute("isLocatedToSide", Order=3)]
            public LateralSide isLocatedToSide {get; set;} = new LateralSide();
                
            [XmlElementAttribute("netElement", Order=4)]
            public tElementWithIDref netElement {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        a "topological box" 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class AreaLocation: rtmCommon.BaseLocation
        {
            [XmlElementAttribute("associatedNetElements", Order=1)]
            public List<AssociatedNetElement> associatedNetElements { get; set; } = new List<AssociatedNetElement>(); 
                
             
        }  
    
        /** 
        Abstract class for a number of w3c sosa or ssn concepts in relation with observations. See examples. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(rtmCommon.Context))]
        [XmlIncludeAttribute(typeof(rtmCommon.MeasurementAuthor))]
        [XmlIncludeAttribute(typeof(rtmCommon.MeasurementEquipment))]
        [XmlIncludeAttribute(typeof(rtmCommon.MeasurementMethod))]
        [XmlIncludeAttribute(typeof(rtmCommon.PhenomenonTime))]     
        public abstract partial class Circumstance: rtmCommon.NamedResource
        {
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public abstract partial class Context: rtmCommon.Circumstance
        {
             
        }  
    
        /** 
        Abstraction of w3c sosa:observation. Needed for the purpose of dealing with specified values (de:Sollwert) and observed values (de:Istwert) on symmetric terms. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(rtmCommon.Observation))]
        [XmlIncludeAttribute(typeof(rtmCommon.Specification))]     
        public abstract partial class InformationSource: rtmCommon.NamedResource
        {
            [XmlElementAttribute("featureOfInterest", Order=1)]
            public List<tElementWithIDref> featureOfInterest { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("observedProperty", Order=2)]
            public tElementWithIDref observedProperty {get; set;} = new tElementWithIDref();
                
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public abstract partial class MeasurementAuthor: rtmCommon.Circumstance
        {
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public abstract partial class MeasurementEquipment: rtmCommon.Circumstance
        {
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public abstract partial class MeasurementMethod: rtmCommon.Circumstance
        {
             
        }  
    
        /** 
        As per ISO 19156(2011) :
<b>observation </b>= act of measuring or otherwise determining the value of a property
<b>property </b>= facet or attribute of an object referenced by a name

Here, "Observation" implements the w3c sosa:Observation class.
The latter inherits directly from Class ; in the context of RTM, we let it inherit from NamedResource. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class Observation: rtmCommon.InformationSource
        {
            [XmlElementAttribute("circumstance", Order=1)]
            public List<tElementWithIDref> circumstance { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("hasResult", Order=2)]
            public List<Result> hasResult { get; set; } = new List<Result>(); 
                
            [XmlElementAttribute("madeBySensor", Order=3)]
            public tElementWithIDref madeBySensor {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("resultTime", Order=4)]
            public TimeValue resultTime {get; set;} = new TimeValue();
                
            [XmlElementAttribute("simpleResult", Order=5)]
            public String simpleResult= "";
                
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public abstract partial class PhenomenonTime: rtmCommon.Circumstance
        {
             
        }  
    
        /** 
        "Result" as per w3c sosa ontology:
<a href="https://www.w3.org/TR/vocab-ssn/#SOSAResult"><font color="#0000ff"><u>https://www.w3.org/TR/vocab-ssn/#SOSAResult</u></font></a> 
There is no apparent need for an ancestor class, as the result is "borne" by the observation that produces it. W3C does <b>not </b>indicate any ancestor (other than "Class") or properties, such as units, confidence ranges, etc. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class Result: rtmCommon.Quantity
        {
             
        }  
    
        /** 
        A device that measures a physical feature of an object resulting in one or more observations. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class Sensor: rtmCommon.NamedResource
        {
            [XmlElementAttribute("isLocatedAt", Order=1)]
            public List<BaseLocation> isLocatedAt { get; set; } = new List<BaseLocation>(); 
                
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public abstract partial class Specification: rtmCommon.InformationSource
        {
             
        }  
    
        /** 
        Composite intervals contain at least one interval, to which further intervals can be added or subtracted (in a set-theoretical sense).
(informative)
The combination of additions and subtractions will result in a sequence of disjoint, simple intervals; the resulting sequence may be a derived, persisted property, in practical applications. It is not materialized here.
In any operation (e.g. to check if an instant is in a composite interval), all additions shall be done first before subtractions take place.
Generating periodic intervals (such as "all weekdays between Jan 1, 2018 and Dec 31, 2019") is best done using a factory pattern, not included here. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class CompositeTimeInterval: rtmCommon.TimeInterval
        {
            [XmlElementAttribute("added", Order=1)]
            public List<TimeInterval> added { get; set; } = new List<TimeInterval>(); 
                
            [XmlElementAttribute("subtracted", Order=2)]
            public List<TimeInterval> subtracted { get; set; } = new List<TimeInterval>(); 
                
             
        }  
    
        /** 
        A (physical) instant that can be associated with different time values from different time reference systems.
(informative)
An example (instance) is "instant of tripping of circuit breaker X of locomotive Y". the instant is an instance of (Physical) Instant. The circuit breaker tripping provides the context, hence the physical meaning.
The time equivalent of "SpotLocation", except that a PhysicalInstant must have an owner (here, the locomotive or the circuit breaker). 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class Instant
        {
            [XmlElementAttribute("atTime", Order=1)]
            public List<TimeValue> atTime { get; set; } = new List<TimeValue>(); 
                
             
        }  
    
        /** 
        Simple, i.e. continuous time interval between start and end.
Start and end instants can be included or excluded.
(informative)
Start excluded is useful for computing statements such as "takes place after", etc. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(rtmCommon.ValidityPeriod))]     
        public  partial class SimpleTimeInterval: rtmCommon.TimeInterval
        {
            [XmlElementAttribute("end", Order=1)]
            public List<TimeValue> end { get; set; } = new List<TimeValue>(); 
                
            [XmlElementAttribute("endIncluded", Order=2)]
            public Boolean endIncluded {get; set;} = new Boolean();
                
            [XmlElementAttribute("start", Order=3)]
            public List<TimeValue> start { get; set; } = new List<TimeValue>(); 
                
            [XmlElementAttribute("startIncluded", Order=4)]
            public Boolean startIncluded {get; set;} = new Boolean();
                
             
        }  
    
        /** 
        Abstract class for time intervals.
(informative)
Time intervals bear no IDs, as they are expected to be managed by other objects, such as "TimeTable" or "NetElement" (describing the interval of validity: former validFrom... validTo)
May include basic methods such as:
isIncluded(instant:DateTime): boolean ;
intersection(interval:TimeInterval): TimeInterval, etc. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(rtmCommon.CompositeTimeInterval))]
        [XmlIncludeAttribute(typeof(rtmCommon.SimpleTimeInterval))]     
        public abstract partial class TimeInterval
        {
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class TimeReferenceSystem: rtmCommon.NamedResource
        {
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class TimeValue: rtmCommon.Quantity
        {
            [XmlElementAttribute("timeReferenceSystem", Order=1)]
            public List<tElementWithIDref> timeReferenceSystem { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        Simple time interval, used for defining the time frame in which a functional object is available in the field (from placing into service to de-commissioning). By extension, also used for setting the time frame in which e.g. a regulation or reference system is in force. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schema/Common")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schema/Common",IsNullable=false)] 
             
        public  partial class ValidityPeriod: rtmCommon.SimpleTimeInterval
        {
             
        }  
    
    public enum DescriptionLevel : int {
        /* The Macro level aims to describe the network at regional or national level, with the nonlinear elements being the boundaries and the major OP’s, while the linear elements are the sections of lines connecting those points. */Macro,/* The Meso level brings the description of the tracks between the operational points of the network into focus.
The non-linear elements are the Operating Points (OP = stations, yards, junctions, boundaries), and linear elements are the tracks connecting Ops. */Meso,/* At micro level, the smallest details aggregate into a single item. E.g. individual point components and point blades and tips coalesce into a single turnout.  */Micro,/* The nano level could be described as a properly attributed surveyor’s map, including topological properties of the rail network in the finest possible granularity. 
Use cases for the Nano level would include interlocking and asset management. */Nano
    }
    
    public enum LrsMethod : int {
        /* distance along, measured from the intersections (junctions) where linear elements meet. */relative,/* curvilinear abscissa ("distance along" linear element); values do not necessarily start with zero */absolute,/* Fraction (percentage) of distance along linear element. */interpolation
    }
    
    public enum Navigability : int {
        /* Navigation is possible only from NetElement A to NetElement B. */AB,/* Navigation is possible only from NetElement B to NetElement A. */BA,/* Navigation between element A and B is possible in both directions. */Both,/* None is an extraneous value - a graph would have no edge at all in such case. It conveys the meaning that NetElements are "adjacent", which makes no sense in graph theory but would have a meaning in mathematical topology (you cannot insert any NetElement between). This is a slight but practical concession to conceptual purity.

To keep the real connectivity we need all the edges and the "none" value, else the connectivity graph (same for the line graph) is not properly formed with regard to the original graph. */None
    }
    
    public enum Orientation : int {
        /* Orientation is normal */normal,/* Orientation is reverse */reverse
    }
    
    public enum Usage : int {
        /* the relation uses the start of the net element */start,/* the relation uses the end of the net element */end
    }
    
    public enum LateralSide : int {
        /* The lateral side is not yet defined/known although the spot located object is or will be placed to the left or right of the track. Can be used at early planning stages. The actual lateral side can then be given at a later stage, e.g. as-built. */undefined,/*  */left,/*  */right,/* Centred on the linear element. */centre
    }
    
    public enum ApplicationDirection : int {
        /* The application direction is irrelevant or (yet) unknown.  */undefined,/* the located object is valid in the direction of the LinearElement */normal,/* the located object is valid in the reverse direction of the LinearElement. */reverse,/* The located object is valid in both directions. */both
    }
    
} 
            