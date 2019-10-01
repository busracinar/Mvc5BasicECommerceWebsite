using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Abc.MvcWebUI.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {

            var kategoriler = new List<Category>()
            {
                new Category() { Name = "Kamera", Description = "Kamera ürünleri"},
                new Category() { Name = "Bilgisayar", Description = "Bilgisayar ürünleri"},
                new Category() { Name = "Elektronik", Description = "Elektronik ürünleri"},
                new Category() { Name = "Telefon", Description = "Telefon ürünleri"},
                new Category() { Name = "Beyaz Eşya", Description = "Beyaz Eşya ürünleri"},
                new Category() { Name = "Televizyon", Description = "Televizyon ürünleri"}

            };

            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

            var urunler = new List<Product>()
            {
                new Product() {Name = "Sony FDR-AX53 4K Ultra HD Video Kamera", Description = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price =6.329, Stock =1200, Image="1.jpg", IsApproved =true, CategoryId =1,IsHome=true},
                new Product() {Name = "Evervox EVR-S1 1.3MP Wi-Fi Akıllı Kamera", Description = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price = 229, Stock =600, Image="2.jpg", IsApproved =false, CategoryId =1,IsHome=true},
                new Product() {Name = "Sony HXR-MC2500 Profesyonel Video Kamera", Description = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price = 8.083, Stock =0, Image="3.jpg", IsApproved = true, CategoryId =1},
                new Product() {Name = "Sony FDR-AX100 4K Ultra HD Video Kamera", Description = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price = 8.028, Stock =300, Image="4.jpg", IsApproved = false, CategoryId =1},
                new Product() {Name = "Sony HXR-NX100 Full HD Profesyonel NXCAM Video Kamera", Description = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price = 11.493,  Stock =300, Image="5.jpg", IsApproved = true, CategoryId =1,IsHome=true},

                new Product() {Name = "Lenovo V330 81AX00DQTX Dizüstü Bilgisayar", Description = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price = 3.499,  Stock =2000, Image="6.jpg", IsApproved =true, CategoryId =2,IsHome=true},
                new Product() {Name = "Lenovo IdeaPad 330 81D200PBTX AMD Ryzen 5 2500U 8GB 256GBSSD 2GB Radeon540 15.6 FHD Freedos Notebook", Description = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price = 3.149,  Stock =200, Image="7.jpg", IsApproved = false, CategoryId =2},
                new Product() {Name = "HP 7AM62EA Dizüstü Bilgisayar", Description = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price = 5.569,  Stock =5, Image="8.jpg", IsApproved = true, CategoryId =2,IsHome=true},
                new Product() {Name = "Acer AN515-52-54ZN NH.Q3LEY.012 Dizüstü Bilgisayar", Description = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price = 5.079, Stock =50, Image="9.jpg", IsApproved = false, CategoryId =2,IsHome=true},
                new Product() {Name = "Casper Excalibur G900.9750-BE60X Dizüstü Bilgisayar", Description = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price = 8.499,  Stock =380, Image="10.jpg", IsApproved = true, CategoryId =2},
                
                new Product() {Name = "Singer Brilliance 6180 Elektronik Dikiş Makinesi", Description = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price =759, Stock =400, Image="11.jpg", IsApproved =true, CategoryId =3},
                new Product() {Name = "Fakir Ranger Elektronik Elektrikli Süpürge", Description = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price = 569,  Stock =30, Image="12.jpg", IsApproved = false, CategoryId =3,IsHome=true},
                new Product() {Name = "Tabanca Havya 40 Watt Havya Lehim Makinesi", Description = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price = 24, Stock =700, Image="13.jpg", IsApproved = true, CategoryId =3,IsHome=true},
                new Product() {Name = "Sewing FH201 Elektronik Pedallı Mini Dikiş Makinesi", Description = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price = 119,  Stock = 1200, Image="14.jpg", IsApproved = false, CategoryId =3},
                new Product() {Name = "Ultrasonik Riddex Plus Elektronik Fare Ve Haşere Kovucu", Description = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price = 16, Stock =90, Image="15.jpg", IsApproved = true, CategoryId =3},

                new Product() {Name = "HUAWEI P Smart 2019 Akıllı Telefon Mavi", Description = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price = 1.688,  Stock =1000, Image="16.jpg", IsApproved =true, CategoryId =4},
                new Product() {Name = "SAMSUNG Galaxy A70 Akıllı Telefon Beyaz", Description = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price = 2.783,  Stock =6000, Image="17.jpg", IsApproved = false, CategoryId =4,IsHome=true},
                new Product() {Name = "K6 Note 3/32GB Akıllı Telefon Gri Lenovo Türkiye Garantili", Description = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price = 911, Stock =500, Image="18.jpg", IsApproved = true, CategoryId =4},
                new Product() {Name = "HUAWEI Y5 2019 Akıllı Telefon Modern Siyah ", Description = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price = 1.200,  Stock =750, Image="19.jpg", IsApproved = false, CategoryId =4,IsHome=true},
                new Product() {Name = "Apple iPhone 6S 32 GB Rose Gold Akıllı Telefon", Description = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price = 2.999, Stock =10, Image="20.jpg", IsApproved = true, CategoryId =4},

                new Product() {Name = "Nexon BM 501 Bulaşık Makinesi", Description = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price = 1.099,  Stock =900, Image="21.jpg", IsApproved =true, CategoryId =5},
                new Product() {Name = "Vestel BM-500 Retro Bulaşık Makinesi", Description = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price = 2.399, Stock =1500, Image="22.jpg", IsApproved = false, CategoryId =5,IsHome=true},
                new Product() {Name = "Altus AL 403 M Bulaşık Makinesi", Description = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price = 1.187,  Stock =450, Image="23.jpg", IsApproved = true, CategoryId =5,IsHome=true},
                new Product() {Name = "Electrolux ESF5533LOW Bulaşık Makinesi", Description = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price = 2.398,  Stock =0, Image="24.jpg", IsApproved = false, CategoryId =5},
                new Product() {Name = "Altus AL 435 XI Bulaşık Makinesi", Description = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price = 1.819,  Stock =2500, Image="25.jpg", IsApproved = true, CategoryId =5}
            };

            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();


            base.Seed(context);
        }
    }
}