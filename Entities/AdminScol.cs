using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salem_Jamel_Note_Management.Entities
{
    class AdminScol
    {
        public string codeAdmin { get; set; }
        public string Nom { get; set; }
        public string Prénom { get; set; }
        public string Fonction { get; set; }
        public string tel { get; set; }
        public string age { get; set; }
        public string sex { get; set; }
        public virtual Login Login { get; set; }
    }
}
