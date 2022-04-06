using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mod03.Services
{
    public class DataSource : IDataSource
    {
        public List<String> getRecords()
        {
            var myList = new List<String>();
            myList.Add("Karan");
            myList.Add("Koenig");
            myList.Add("Kv");
            return myList;
        }
    }
}
