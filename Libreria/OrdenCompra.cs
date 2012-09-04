using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;

namespace Libreria
{
    public class OrdenCompra
    {
        public ObjectId Id { get; set; }
        public ObjectId Proveedor { get; set; }
        public String Emitida { get; set; }
        public String TipoPago { get; set; }
        public BsonInt32 Descuento { get; set; }
        public BsonInt32 Recargo { get; set; }
        public String Observacion { get; set; }
        public BsonDateTime Fecha { get; set; }
    }
}
