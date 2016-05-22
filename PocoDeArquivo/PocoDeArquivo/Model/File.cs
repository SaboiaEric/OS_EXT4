using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocoDeArquivo.Model
{
    public class File
    {
        private string name;
        private DateTime built;
        private List<DateTime> modifications;
        private List<DateTime> access;
        private object selfFile;
        private string path;
        private User author;
        private byte lenght;
        private TypeOfFile type;
        private string extention;

        #region Constructors
        public File(string name, TypeOfFile type, string extention)
        {
            this.name = name;
            this.type = type;
            this.extention = extention;
            this.built = DateTime.Now;
        }
        #endregion

        #region Gets/Sets

        public string Name { get; set; }
        public DateTime Built { get; set; }
        public List<DateTime> Modifications{ get; set; }
        public List<DateTime> Access { get; set; }
        public object SelfFile{ get; set; }
        public User Author{ get; set; }
        public Byte Lenght{ get; set; }

        public TypeOfFile Type{ get; set; }
        public string Extenttion{ get; set; }
        #endregion

        #region Public Methods

        public byte generateLenght()
        {
            throw new NotImplementedException();
        }

        public string getExtention()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
