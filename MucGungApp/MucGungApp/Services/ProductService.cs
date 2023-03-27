using MucGungApp.Models;

namespace MucGungApp.Services
{
    public class ProductService
    {
        static ProductService _instance;

        public static ProductService Instance
        {
            get { return _instance ?? (_instance = new ProductService()); }
        }

        public List<Product> GetProducts()
        {
            return new List<Product> {
              new Product { 
                  Name = "Trà Gừng",
                  Image = "tra.jpg",
                  Description = "Thành phần: trà, gừng, dạng bột.",
                  Price = 1.49,
              },
              new Product {
                  Name = "Bột Gừng",
                  Image = "botgung.ipg",
                  Description = "Thành phần: gừng xay bột mịn, uống với nước ấm.",
                  Price = 1.66,
              },
              new Product {
                  Name = "Chuối Sấy Kim Long",
                  Image = "chuoisay.jpg",
                  Description = "Thành phần: chuối chín, đường.",
                  Price = 2.08,
              },
              new Product {
                  Name = "Tré Kim Long",
                  Image = "tre1.jpg",
                  Description = "Thành phần: tai heo, mũi heo, thịt ba rọi, riềng, mè.",
                  Price = 2.34,
              },
              new Product {
                  Name = "Tôm Chua Kim Long",
                  Image = "tomchua.jpg",
                  Description = "Thành phần: tôm, riềng, ớt, tỏi.",
                  Price = 4.04,
              },
              new Product {
                  Name = "Mức Gừng Dẻo Mật Ong",
                  Image = "gung_ong_deo.jpg",
                  Description = "Thành phần: gừng non, mật ong, đường.",
                  Price = 4.08,
              },
              new Product {
                  Name = "Mức Gừng Dẻo Mật Ong",
                  Image = "deo_tui.jpg",
                  Description = "Thành phần: gừng non, đường.",
                  Price = 3.74,
              },
           };
        }
    }
}