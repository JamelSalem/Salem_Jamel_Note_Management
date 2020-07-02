using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salem_Jamel_Note_Management.Entities
{
    class Note
    {
        [Key]
        public String idNote { get; set; }
        public float noteTP { get; set; }
        public float noteCours { get; set; }
        public float noteModule { get; set; }
        [ForeignKey("Etudient")]
        public int num_Etud { get; set; }
        [ForeignKey("Matier")]
        public String codeMatiere { get; set; }

        public virtual Etudient Etudient { get; set; }
        public virtual Matiere Matiere { get; set; }

        public Note(string idNote, float noteTP, float noteCours, float noteModule)
        {
            this.idNote = idNote;
            this.noteTP = noteTP;
            this.noteCours = noteCours;
            this.noteModule = noteModule;
        }

        public Note()
        {
        }

        public string toString()
        {
            string s = "Votre note TP est  : " + noteTP + ", Votre note Cours est: " + noteCours + " Le moyen de module est : " + noteModule;
            return s;
        }
    }
}

