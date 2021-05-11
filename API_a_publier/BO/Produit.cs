using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.BO
{
    public class Produit
    {
        public int Id { get; set; }

        public Facture Facture { get; set; }

        public String Nom { get; set; }

        public int Stock { get; set; }

        public String Photo { get; set; }

    }
}
