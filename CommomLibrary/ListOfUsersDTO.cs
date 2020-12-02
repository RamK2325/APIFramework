using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommomLibrary
{
    public partial class ListOfUsersDTO
    {
        public List<Data> Data { get; set; }

    }

    public partial class Data
    {
        public int id { get; set; }
        public string email { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string avatar { get; set; }
    }


}

