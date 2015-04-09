using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQLScriptGenerator
{
    class Database
    {
        public Database(string name)
        {
            table = new List<Table>();
            this.name = name;
        }
        public string name;
        public List<Table> table;
    }
}
