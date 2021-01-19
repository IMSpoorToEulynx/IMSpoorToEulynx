 
using System; 
using System.Collections.Generic; 
using System.Text; using System.IO; 
using System.Xml.Serialization; 
using System.Linq;
     
using Models.TopoModels.EULYNX.rtmCommon;
     
using Models.TopoModels.EULYNX.dp;
     
using Models.TopoModels.EULYNX.sig;
     
using trv = Models.TopoModels.EULYNX.trv;

namespace Models.TopoModels.EULYNX.trv {
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/TRV")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/TRV",IsNullable=false)] 
             
        public  partial class MovableElement: sig.MovableElement
        {
            [XmlElementAttribute("canReportDegradedStatus", Order=1)]
            public Boolean canReportDegradedStatus {get; set;} = new Boolean();
                
             
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
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/TRV")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/TRV",IsNullable=false)] 
             
        public  partial class SignallingEntities: dp.SignallingEntities
        {
             
        }  
    
        /** 
        EBICAB balise. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/TRV")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/TRV",IsNullable=false)] 
             
        public  partial class AtcBalise: sig.Balise
        {
             
        }  
    
} 
            