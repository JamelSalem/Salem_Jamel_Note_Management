using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salem_Jamel_Note_Management.Entities
{
    class Filiere
    {
        [Key]

        public String codeFiliere { get; set; }
        public String nomFiliere { get; set; }
        [ForeignKey("Dep")]
        public String numDepartment { get; set; }

        public virtual Department Department { get; set; }
        public virtual ICollection<Groupe> Groupe { get; set; }
    }
}
