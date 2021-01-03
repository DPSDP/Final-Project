using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_II
{
    public class Dataframe
    {
        private List<string> _columnsTypes = new List<string>() ;
        public List<string> ColumnsTypes { get { return _columnsTypes; } }
        private List<Row> _rows = new List<Row>();
        public Dataframe(ArrayList row1)
        {
            for(int i=0;i< row1.Count; i++)
            {
                string type = row1[i].GetType().Name;
                _columnsTypes.Add(type);
            }
            Row rowA = new Row(row1);

            _rows.Add(rowA);
        }
        public ArrayList getIndex(int i)
        {
            return _rows[i].elements;
        }

        public void Add(ArrayList individu)
        {
            Row row = new Row(individu);
            _rows.Add(row);
        }
    }
}
