using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;

namespace Libreria
{
    public class DetalleFactura
    {
        public String Producto { get; set; }
        public BsonInt32 Unidades { get; set; }
        public BsonInt32 PrecioUnidad { get; set; }
    }
}
