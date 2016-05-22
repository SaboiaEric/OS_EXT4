using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocoDeArquivo.Model
{
    public class User
    {
        public string name;
        public string login;
        public string password;
        public TypeOfUser type;
        public Dictionary<string, int> permissions;
        public List<Group> groups;

        #region Constructors

        public User(string name, string login, string password, TypeOfFile type, Group group)
        {
            this.name = name;
            this.login = login;
            this.password = password;
            this.type = type;
            groups = new List<Group>();
            groups.Add(group);
        }

        #endregion
    }
}
