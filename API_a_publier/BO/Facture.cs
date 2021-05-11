using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.BO
{
    public class Facture
    {
        public int Id { get; set; }

        public Client Client { get; set; }

        public DateTime Date_émission { get; set; }

        public bool Payé { get; set; }

        public DateTime Date_Paiment { get; set; }

        public int Prix { get; set; }
    }
}
