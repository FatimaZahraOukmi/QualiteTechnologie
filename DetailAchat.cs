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
    
    public partial class DetailAchat
    {
        public int ID_DetailAchat { get; set; }
        public Nullable<int> AchatId { get; set; }
        public int ArticleId { get; set; }
        public string Reference { get; set; }
        public string Designation { get; set; }
        public Nullable<decimal> PrixUnitaire { get; set; }
        public Nullable<int> Quantite { get; set; }
        public decimal Montant_Produit { get; set; }
        public Nullable<int> TypeArticleId { get; set; }
    
        public virtual Achat Achat { get; set; }
        public virtual Articles Articles { get; set; }
        public virtual TypeArticle TypeArticle { get; set; }
    }
}
