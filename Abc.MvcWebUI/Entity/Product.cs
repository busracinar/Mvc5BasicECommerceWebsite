using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Entity
{
    public class Product
    {
        public int ID { get; set; }
        [DisplayName("Ürün Adı")]
        public string Name { get; set; }
        [DisplayName("Açıklama")]
        public string Description { get; set; }
        [DisplayName("Fiyat")]
        public double Price { get; set; }
        [DisplayName("Stokta Var Mı?")]
        public int Stock { get; set; }
        [DisplayName("Ürün Resmi")]
        public string Image { get; set; }
        [DisplayName("Onaylı mı?")]
        public bool IsApproved { get; set; }
        [DisplayName("Anasayfada Var Mı?")]
        public bool IsHome { get; set; }
        [DisplayName("Kategori")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}