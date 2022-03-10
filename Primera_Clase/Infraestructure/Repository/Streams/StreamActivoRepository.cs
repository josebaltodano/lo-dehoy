using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository.Streams
{
    public class StreamActivoRepository : IActivoModel
    {

      
        private BinaryReader binaryReader;
        private BinaryWriter binaryWriter;
        private string fileName="Activo.dat";
        public StreamActivoRepository()
        {

        }
        public void Add(Activo t)
        {
            try
            {
                using (FileStream fileStream = new FileStream(fileName, FileMode.Append, FileAccess.Write)) //El using sirve para que se ejecute y cuando termina se cierra.
                {
                    binaryWriter = new BinaryWriter(fileStream);
                    binaryWriter.Write(t.id);
                    binaryWriter.Write(t.nombre);
                    binaryWriter.Write(t.valor);
                    binaryWriter.Write(t.vidaUtil);
                    binaryWriter.Write(t.valorResidual);
                    binaryWriter.Close();
                } // Aqui se va a cerrar tanto la conexion como la instancia.
            }
            catch (IOException)
            {
                throw;
            }
        }

        public void Delete(Activo t)
        {
            throw new NotImplementedException();
        }

        public Activo GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Activo> Read()
        {
            List<Activo> activos = new List<Activo>();
            try
            {
                using (FileStream fileStream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read)) //El using sirve para que se ejecute y cuando termina se cierra.
                {
                    binaryReader = new BinaryReader(fileStream);
                    binaryWriter.Write(t.id);
                    binaryWriter.Write(t.nombre);
                    binaryWriter.Write(t.valor);
                    binaryWriter.Write(t.vidaUtil);
                    binaryWriter.Write(t.valorResidual);
                    binaryWriter.Close();
                } // Aqui se va a cerrar tanto la conexion como la instancia.
            }
            catch (IOException)
            {
                throw;
            }
        }
    }
}
