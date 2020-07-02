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
    class Enseignant
    {
        [Key]
        public int num_Ens { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string email { get; set; }
        public string speciality { get; set; }
        public string adresse { get; set; }
        public string telephone { get; set; }
        public string CIN { get; set; }
        public string login { get; set; }
        public bool sex { get; set; }
        [ForeignKey("Dep")]
        public String numDepartment { get; set; }
        [ForeignKey("Login")]
        public int loginId { get; set; }


        public virtual Department Department { get; set; }
        public virtual ICollection<Groupe> Groupe { get; set; }
        public virtual ICollection<Matiere> Matieres { get; set; }
        public virtual Login Login { get; set; }


        public Enseignant(int num_Ens, string nom, string prenom, string email, string speciality, string adresse, string telephone, string cIN, string login, bool sex)
        {
            this.num_Ens = num_Ens;
            this.nom = nom;
            this.prenom = prenom;
            this.email = email;
            this.speciality = speciality;
            this.adresse = adresse;
            this.telephone = telephone;
            this.CIN = cIN;
            this.login = login;
            this.sex = sex;
        }

        public Enseignant()
        {
        }

        public string toString()
        {
            string s = "Num: " + num_Ens + ", Nom: " + nom + " prenom: " + prenom + " email: " + email + " tele: " + telephone + " sex: " + sex;
            return s;
        }
    }
}
