using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;

namespace Libreria
{
    public class Proveedor
    {
        public ObjectId Id { get; set; }
        public String Rut { get; set; }
        public String Nombre { get; set; }
        public String NombreFantasia { get; set; }
        public String Direccion { get; set; }
        public String Mail { get; set; }
        public List<String> Telefonos { get; set; }

    }
}
