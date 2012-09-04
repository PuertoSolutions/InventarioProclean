using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;

namespace Libreria
{
    public class Factura
    {
        public ObjectId Id { get; set; }
        public ObjectId Proveedor { get; set; }
        public BsonInt32 IDFactura { get; set; }
        public BsonInt32 OrdenCompra { get; set; }
        public BsonDateTime Fecha { get; set; }
        public DetalleFactura Detalle { get; set; }
    }
}
