using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salem_Jamel_Note_Management.Entities
{
    class Groupe
    {
        [Key]

        public String codeGroupe { get; set; }
        public String nomGroupe { get; set; }
       
        [ForeignKey("Filier")]
         public String codeFiliere { get; set; }

        public virtual ICollection<Matiere> Matieres { get; set; }
        public virtual ICollection<Enseignant> Enseignants { get; set; }
        public virtual ICollection<Etudient> Etudients { get; set; }
        public virtual Filiere Filiere { get; set; }
    }
}
