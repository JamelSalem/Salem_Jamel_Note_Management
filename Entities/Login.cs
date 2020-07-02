using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salem_Jamel_Note_Management.Entities
{
    class Login
    {
        public int loginId { get; set; }
        public string password { get; set; }
        public virtual ICollection<AdminScol> AdminScols { get; set; }
        public virtual ICollection<Enseignant> Enseignants { get; set; }
        public virtual ICollection<Etudient> Etudients { get; set; }


    }
}
