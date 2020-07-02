using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salem_Jamel_Note_Management.Entities
{
    class Matiere
    {
        [Key]

        public String codeMatiere { get; set; }
        public String nomMatiere { get; set; }
        [ForeignKey("Enseignant")]
        public String numDepartment { get; set; }


        public virtual Enseignant Enseignant { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
        public virtual ICollection<Enseignant> Enseignants { get; set; }
    }
}

