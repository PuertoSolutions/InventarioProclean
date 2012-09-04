using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;

namespace Libreria
{
    public class Categoria
    {
        public ObjectId Id { get; set; }
        public BsonInt32 Codigo { get; set; }
        public String Nombre { get; set; }
    }
}
