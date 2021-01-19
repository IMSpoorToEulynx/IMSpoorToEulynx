 
using System; 
using System.Collections.Generic; 
using System.Text; using System.IO; 
using System.Xml.Serialization; 
using System.Linq;
     
using Models.TopoModels.EULYNX.rtmCommon;
     
using Models.TopoModels.EULYNX.dp;
     
using Models.TopoModels.EULYNX.sig;
     
using rfi = Models.TopoModels.EULYNX.rfi;

namespace Models.TopoModels.EULYNX.rfi {
    
        /** 
        RFI lens diffuser type.
it-IT: diffusore a lente RFI
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/RFI")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/RFI",IsNullable=false)] 
             
        public  partial class LensDiffuser: sig.LensDiffuser
        {
            [XmlElementAttribute("isOfLensDiffuserType", Order=1)]
            public LensDiffuserTypes isOfLensDiffuserType {get; set;} = new LensDiffuserTypes();
                
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/RFI")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/RFI",IsNullable=false)] 
             
        public  partial class SignalAlignment: sig.SignalAlignmentPointOnTrack
        {
            [XmlElementAttribute("alpha", Order=1)]
            public Double alpha {get; set;} = new Double();
                
             
        }  
    
        /** 
        Italian track assets are labeled with a series
of strings: prefix + number + fullname 

it-IT: I track asset italiani sono etichettati con una serie di stringhe: 
prefisso + numero + nome completo 

E.g.  prefix="Savv",  number="03",  fullname="Savv03"
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/RFI")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/RFI",IsNullable=false)] 
             
        public  partial class Designation: sig.Designation
        {
            [XmlElementAttribute("fullName", Order=1)]
            public String fullName= "";
                
            [XmlElementAttribute("number", Order=2)]
            public Int32 number {get; set;} = new Int32();
                
            [XmlElementAttribute("prefix", Order=3)]
            public String prefix= "";
                
             
        }  
    
        public partial class SignallingEntities
        {
            internal string AddObject(Object myObject, string id = null)
            {
                switch (myObject)
                {
                
                }
                return id;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/RFI")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/RFI",IsNullable=false)] 
             
        public  partial class SignallingEntities: dp.SignallingEntities
        {
             
        }  
    
    public enum LensDiffuserTypes : int {
        /* O  */line,/* A
raggio di curvatura &lt; 7500 m */highRadius,/* Bd
raggio di curvatura &lt; 1500 m */lineCurveToRight,/* Bs
raggio di curvatura &lt; 1500 m */lineCurveToLeft
    }
    
} 
            