using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SVC
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ISVCFactura
    {
        [OperationContract]
        Factura ObtenerFactura(string IdFactura);

        // TODO: agregue aquí sus operaciones de servicio
    }

    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    // Puede agregar archivos XSD al proyecto. Después de compilar el proyecto, puede usar directamente los tipos de datos definidos aquí, con el espacio de nombres "SVC.ContractType".
    [DataContract]
    public class Factura : BaseRespuesta
    {
        [DataMember]
        public string IdFactura { get; set; }
        [DataMember]
        public int Monto { get; set; }
        [DataMember]
        public string Articulo { get; set; }
    }

    [DataContract]
    public class BaseRespuesta
    {
        public string MensajeRespuesta { get; set; }
        public string Error { get; set; }
    }

   
}
