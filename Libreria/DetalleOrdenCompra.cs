using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;

namespace Libreria
{
    public class DetalleOrdenCompra
    {
        public BsonInt32 CodPedido { get; set; }
        public String Articulo { get; set; }
        public BsonInt32 CodProducto { get; set; }
        public BsonInt32 Compra { get; set; }
        public BsonInt32 Cantidad { get; set; }
        public BsonInt32 Precio { get; set; } 
    }
}
