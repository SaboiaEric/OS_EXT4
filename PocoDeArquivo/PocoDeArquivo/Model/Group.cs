using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocoDeArquivo.Model
{
    public class Group
    {
        private string name;
        private int permissions;
        private string admin;
        private List<User> users;

        #region Construct
        /*Creating group without users*/
        public Group(string name)
        {
            this.name = name;
        }
        /*Creating group with users*/
        public Group(string name, List<User>lista)
        {
            this.name = name;
            this.users = lista;

        }
        #endregion

        #region Get/Set
        public string Name { get; set; }
        public int Permissions { get; set; }
        public string Admin { get; set; }
        public List<User> Users { get; set; }
        #endregion

        #region Public Methods
            
        #endregion
    }

}
