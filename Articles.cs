//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Articles
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Articles()
        {
            this.DetailAchat = new HashSet<DetailAchat>();
            this.DetailVente = new HashSet<DetailVente>();
        }
    
        public int ArticleId { get; set; }
        public string Designation { get; set; }
        public Nullable<int> TypeArticleId { get; set; }
        public Nullable<decimal> PrixUnitaire { get; set; }
        public Nullable<int> QuantiteStock { get; set; }
        public Nullable<int> FournisseurId { get; set; }
        public string Reference { get; set; }
        public Nullable<System.DateTime> DateReception { get; set; }
    
        public virtual Fournisseurs Fournisseurs { get; set; }
        public virtual TypeArticle TypeArticle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailAchat> DetailAchat { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailVente> DetailVente { get; set; }
    }
}
