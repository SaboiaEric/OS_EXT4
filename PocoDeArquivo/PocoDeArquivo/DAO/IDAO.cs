using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections.ObjectModel;


namespace PocoDeArquivo.DAO
{
    public interface IDAO<T> 
        where T : class
        {
            T Insert(T model);
            T Update(T model);
            bool Delete(T model);
            T Select(object param);
            List<T> Search(params object[] key);
            List<T> ListAll();
        }
}
