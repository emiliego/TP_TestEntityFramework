﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestEntityFrameworkBDD.BDD
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ExerciceCSharp_BDDEntities : DbContext
    {
        public ExerciceCSharp_BDDEntities()
            : base("name=ExerciceCSharp_BDDEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Civilite> Civilite { get; set; }
        public virtual DbSet<Personne> Personne { get; set; }
        public virtual DbSet<Ville> Ville { get; set; }
    }
}