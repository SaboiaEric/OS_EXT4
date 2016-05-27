using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using PocoDeArquivo.Model;
using PocoDeArquivo.Factory;
using PocoDeArquivo.DAO;
using System.Data;
using System.Data.SqlClient;

namespace PocoDeArquivo.DAO
{
    public class FileDAO : IDAO<File>
    {
        public bool Delete(File model)
        {
            return true;
        }

        public File Insert(File model)
        {
            throw new NotImplementedException();
        }

        public List<File> ListAll()
        {
            throw new NotImplementedException();
        }

        public List<File> Search(params object[] key)
        {
            throw new NotImplementedException();
        }

        public File Select(object param)
        {
            throw new NotImplementedException();
        }

        public File Update(File model)
        {
            throw new NotImplementedException();
        }
    }
}
