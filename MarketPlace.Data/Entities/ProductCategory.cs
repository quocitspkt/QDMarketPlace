using MarketPlace.Data.Enums;
using MarketPlace.Data.Interfaces;
using MarketPlace.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MarketPlace.Data.Entities
{
    [Table("ProductCategories")]
    public class ProductCategory : DomainEntity<int>, IHasSeoMetaData, ISwitchable, IDateTracking,ISortable
    {
        
        [Required] 
        [Column(TypeName="nvarchar")]
        [StringLength(128)]
        public string Name { get; set; }

        public int? ParentId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(128)]
        public string SeoPageTitle { set; get; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(128)]
        public string SeoAlias { set; get; }
        
        [Column(TypeName = "nvarchar")]
        [StringLength(158)]
        public string SeoKeyWord { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(158)]
        public string SeoDescription { set; get; }

        public Status Status { set; get; }

        public DateTime DateCreated { set; get; }

        public DateTime DateModified { set; get; }

        public int SortOrder { set; get; }
    }
}
