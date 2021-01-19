 
using System; 
using System.Collections.Generic; 
using System.Text; using System.IO; 
using System.Xml.Serialization; 
using System.Linq;
     
using Models.TopoModels.EULYNX.rtmCommon;
     
using rtmNE = Models.TopoModels.EULYNX.rtmNE;

namespace Models.TopoModels.EULYNX.rtmNE {
    
        /** 
        Parent class for information that can definitely be localised, which is the case of most infrastructure-related objects. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schemas/NetEntity")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schemas/NetEntity",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(rtmSig.OnTrackSignallingDevice))]
        [XmlIncludeAttribute(typeof(rtmSig.RouteBody))]
        [XmlIncludeAttribute(typeof(rtmSig.Signal))]
        [XmlIncludeAttribute(typeof(rtmSig.Turnout))]
        [XmlIncludeAttribute(typeof(rtmSig.VehicleStop))]     
        public  partial class LocatedNetEntity: rtmNE.NetEntity
        {
            [XmlElementAttribute("locations", Order=1)]
            public List<tElementWithIDref> locations { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        Anchor point for any infrastructure element that has a topological position 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schemas/NetEntity")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schemas/NetEntity",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(rtmNE.LocatedNetEntity))]     
        public  partial class NetEntity: rtmCommon.NetworkResource
        {
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schemas/NetEntity")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schemas/NetEntity",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(rtmNE.Slope))]
        [XmlIncludeAttribute(typeof(rtmNE.SpeedLimit))]     
        public  partial class NetProperty: rtmCommon.NetworkResource
        {
            [XmlElementAttribute("location", Order=1)]
            public List<rtmCommon.BaseLocation> location { get; set; } = new List<rtmCommon.BaseLocation>(); 
                
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schemas/NetEntity")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schemas/NetEntity",IsNullable=false)] 
             
        public  partial class Slope: rtmNE.NetProperty
        {
            [XmlElementAttribute("slope", Order=1)]
            public Double slope {get; set;} = new Double();
                
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schemas/NetEntity")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schemas/NetEntity",IsNullable=false)] 
             
        public  partial class SpeedLimit: rtmNE.NetProperty
        {
            [XmlElementAttribute("speed", Order=1)]
            public Double speed {get; set;} = new Double();
                
             
        }  
    
} 
            