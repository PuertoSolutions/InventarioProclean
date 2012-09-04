using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;

namespace Libreria
{
    public class Egresos
    {
        public ObjectId Id { get; set; }
        public BsonDateTime Fecha { get; set; }
        public ObjectId Producto { get; set; }
        public ObjectId CentroCosto { get; set; }
        public BsonInt32 Cantidad { get; set; }
    }
}
