using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace Libreria
{
    public class MongoHandler
    {
        private MongoServer server;
        private MongoDatabase bd;
        private MongoCollection coleccion;
        public StringBuilder mensaje = new StringBuilder();

        public MongoHandler(String strConn, String based)
        {
            try
            {
                this.server = MongoServer.Create(strConn + "/?safe=true");
                this.bd = this.server.GetDatabase(based);
            }
            catch (MongoConnectionException MCE)
            {
                this.mensaje.Append("MongoInserts.Constructor" + Environment.NewLine).
                    Append("MongoConnectionException: " + MCE.Message + Environment.NewLine);
            }
            catch (Exception E)
            {
                this.mensaje.Append("MongoInserts.Constructor" + Environment.NewLine).
                    Append("Exception: " + E.Message + Environment.NewLine);
            }
        }

        public Boolean GuardarProveedor(Proveedor P)
        {
            try
            {
                coleccion = bd.GetCollection<Proveedor>("Proveedor");
                coleccion.EnsureIndex(new IndexKeysBuilder().
                    Ascending("Rut"), IndexOptions.SetUnique(true));
                this.mensaje.Append(coleccion.Insert(P).Response.ToString());
                return true;
            }
            catch (MongoSafeModeException MSME)
            {
                this.mensaje.Append("Rut Duplicado: " + P.Rut);
            }
            catch (Exception E)
            {
                this.mensaje.Append(E.Message);
            }
            return false;
        }

        public List<Proveedor> getProveedores()
        {
            try
            {
                coleccion = bd.GetCollection<Proveedor>("Proveedor");
                MongoCursor<Proveedor> cursor = coleccion.FindAllAs<Proveedor>();
                return cursor.ToList<Proveedor>();
            }
            catch (Exception E)
            {
                this.mensaje.Append(E.Message);
            }
            return null;
        }
    }
}
