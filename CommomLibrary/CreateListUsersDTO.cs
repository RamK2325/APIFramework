using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommomLibrary
{
  public  class CreateListUsersDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Age { get; set; }
        public string Job { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    }
}
