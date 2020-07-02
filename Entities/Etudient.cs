using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Salem_Jamel_Note_Management.Entities
{
    class Etudient
    {
        [Key]
            public int num_Etud { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string adresse { get; set; }
        public string telephone { get; set; }
        public string date_naissance { get; set; }
        public string CIN { get; set; }
        public bool sex { get; set; }
        [ForeignKey("Group")]
        public String codeGroupe { get; set; }
        [ForeignKey("Login")]
        public int loginId { get; set; }


        public virtual ICollection<Note> note { get; set; }
        public virtual Groupe Groupe { get; set; }
        public virtual Login Login { get; set; }




        public Etudient(int num_Etud, string nom, string prenom,  string adresse, string telephone, string date_naissance, string cIN,  bool sex)
        {
            this.num_Etud = num_Etud;
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.telephone = telephone;
            this.date_naissance = date_naissance;
            CIN = cIN;
            this.sex = sex;
        }

        public Etudient()
        {
        }

    }
}
