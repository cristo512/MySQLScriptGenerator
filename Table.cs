using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MySQLScriptGenerator
{
    class Table
    {
        public Table(string name, int valuesAmount)
        {
            this.name = name;
            this.valuesAmount = valuesAmount;
        }
	    public string name;
	    public int valuesAmount;
    }
}
