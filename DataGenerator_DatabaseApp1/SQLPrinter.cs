using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataGenerator_DatabaseApp1
{
    class SQLPrinter
    {
        private string output;
        private StreamWriter sw;

        public SQLPrinter(string output)
        {
            this.output = output;
            sw = new StreamWriter(output);
        }

        public void printInsert(string tableName, string[] values)
        {
            StringBuilder line = new StringBuilder("INSERT INTO " + tableName + " VALUES (");
            foreach (string v in values)
            {
                line.Append('\'');
                line.Append(v);
                line.Append('\'');
                line.Append(", ");
            }
            line[line.Length - 2] = ')';
            line.Remove(line.Length-1, 1);
            sw.WriteLine(line.ToString());
        }

        public void Close()
        {
            sw.Close();
        }
    }
}
