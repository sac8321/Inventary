using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class ProductEntity
    {
        [Key]
        [StringLength(10)]
        public string ProductId { get; set; }

        [Required]
        [StringLength(100)]
        public string ProductName { get; set; }
        [StringLength(600)]
        public string ProductDescription { get; set; }

        public int TotalQunatity { get; set; }

        //Relacion con categorias
        public string CategoryId { get; set; }
        public CategoryEntity Category { get; set; }
        //relacion con almacenamiento
        public ICollection<StorageEntity> Storages {get;set;}


    }
}
