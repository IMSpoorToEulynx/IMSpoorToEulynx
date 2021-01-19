 
using System; 
using System.Collections.Generic; 
using System.Text; using System.IO; 
using System.Xml.Serialization; 
using System.Linq;
     
using Models.TopoModels.EULYNX.rtmNE;
     
using Models.TopoModels.EULYNX.rtmCommon;
     
using rtmSig = Models.TopoModels.EULYNX.rtmSig;

namespace Models.TopoModels.EULYNX.rtmSig {
    
        /** 
        Superclass for all on-track signalling devices. Encompasses balises, axle counting heads, LZB cables, etc.
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schemas/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schemas/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(rtmSig.TpsDevice))]
        [XmlIncludeAttribute(typeof(rtmSig.VehiclePassageDetector))]     
        public abstract partial class OnTrackSignallingDevice: rtmNE.LocatedNetEntity
        {
             
        }  
    
        /** 
        A route body is a linear location, i.e. a closed topological subset of the network, without any branches.

EULYNX DP defines:
<ul>
 <li>A route <i>body </i>has an entry- and exit.</li>
 <li>The positions of points that the train encounters in the route body, either facing or trailing, <i>can</i> be given.</li>
</ul> 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schemas/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schemas/Signalling",IsNullable=false)] 
             
        public  partial class RouteBody: rtmNE.LocatedNetEntity
        {
             
        }  
    
        /** 
        Apparatus by means of which a conventional visual or acoustic indication is given, generally concerning the movements of railway vehicles. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schemas/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schemas/Signalling",IsNullable=false)] 
             
        public  partial class Signal: rtmNE.LocatedNetEntity
        {
             
        }  
    
        /** 
        Device that transmits train protection information to a passing train.
E.g. crocodile, (Euro-)balise, magnet, loop. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schemas/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schemas/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(rtmSig.TpsSpotDevice))]     
        public  partial class TpsDevice: rtmSig.OnTrackSignallingDevice
        {
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schemas/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schemas/Signalling",IsNullable=false)] 
             
        public  partial class TpsSpotDevice: rtmSig.TpsDevice
        {
             
        }  
    
        /** 
        A system where tracks divert, cross or that derails railway traffic. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schemas/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schemas/Signalling",IsNullable=false)] 
             
        public  partial class Turnout: rtmNE.LocatedNetEntity
        {
             
        }  
    
        /** 
        Line-side device for detecting passage of a rail vehicle. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schemas/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schemas/Signalling",IsNullable=false)] 
             
        public  partial class VehiclePassageDetector: rtmSig.OnTrackSignallingDevice
        {
             
        }  
    
        /** 
        Installation for physically stopping trains. The track may continue beyond the device.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schemas/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://www.railtopomodel.org/schemas/Signalling",IsNullable=false)] 
             
        public  partial class VehicleStop: rtmNE.LocatedNetEntity
        {
             
        }  
    
} 
            