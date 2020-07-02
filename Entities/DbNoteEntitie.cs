using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salem_Jamel_Note_Management.Entities
{
    class DbNoteEntitie : System.Data.Entity.DbContext
    {
        public DbNoteEntitie() : base("name=DbNoteEntities") { }
        public virtual DbSet<Login> login { get; set; }
        public virtual DbSet<Note> Notes  { get; set; }
        public virtual DbSet<Enseignant> Enseignants  { get; set; }
        public virtual DbSet<Etudient> Etudients  { get; set; }
        public virtual DbSet<AdminScol> AdminScols  { get; set; }
        public virtual DbSet<Filiere> Filieres  { get; set; }
        public virtual DbSet<Groupe> Groupes  { get; set; }
        public virtual DbSet<Matiere> Matieres { get; set; }
        public virtual DbSet<Department> Departments  { get; set; }
    }
}
