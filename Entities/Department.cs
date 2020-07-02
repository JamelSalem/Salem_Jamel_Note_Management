using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salem_Jamel_Note_Management.Entities
{
    class Department
    {
        [Key]

        public String numDepartment { get; set; }
        public String nomDepartment { get; set; }

        public virtual ICollection<Filiere> Filieres { get; set; }
        public virtual ICollection<Enseignant> Enseignants { get; set; }
    }
}
