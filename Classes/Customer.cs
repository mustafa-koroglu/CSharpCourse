using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Customer
    {
        //property
        public int Id { get; set; }
        // field
        //private string _firstName;
        // bu eski kullanım
        // public string FirstName 
        // {
        //     get
        //     {
        //         return "Mrs."+ _firstName;
        //     }
        //     set 
        //     {
        //         _firstName= value;
        //     }

        // }
        // yeni kullanım
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string City { get; set; }

    }
}
