﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QualiTech
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GStockQualiTechEntities : DbContext
    {
        public GStockQualiTechEntities()
            : base("name=GStockQualiTechEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Achat> Achat { get; set; }
        public virtual DbSet<Articles> Articles { get; set; }
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<DetailAchat> DetailAchat { get; set; }
        public virtual DbSet<DetailVente> DetailVente { get; set; }
        public virtual DbSet<Fournisseurs> Fournisseurs { get; set; }
        public virtual DbSet<TypeArticle> TypeArticle { get; set; }
        public virtual DbSet<Utilisateurs> Utilisateurs { get; set; }
        public virtual DbSet<Vente> Vente { get; set; }
    }
}
