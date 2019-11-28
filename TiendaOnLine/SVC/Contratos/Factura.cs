using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SVC
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class SVCFactura : ISVCFactura
    {
        public Factura ObtenerFactura(string IdFactura)
        {
            if (IdFactura == "0")
            {
                return new Factura() { IdFactura = "1001", Monto = 12700 };
            }
            else 
            {
                return new Factura() { Error = "Factura no ecnontrada" };
            }
        }
    }
}
