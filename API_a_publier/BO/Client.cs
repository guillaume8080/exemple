using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.BO
{
    public class Client
    {
        public int Id { get; set; }

        public String Nom { get; set; }

        public String Prénom { get; set; }

        public DateTime Date_Creation { get; set; }

    }
}
