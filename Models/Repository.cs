using System.Security.Cryptography;

namespace FormsApp.Models
{
    public class Repository{
        private static readonly List<Product> _product=new();
        private static readonly List<Category> _categories=new();
        static Repository(){
            _categories.Add(new Category{CategoryId=1,Name="Telefon"});
            _categories.Add(new Category{CategoryId=2,Name="Bilgisayar"});

            _product.Add(new Product{ProductId=1,Name="Iphone 14",Price=40000,IsActive=false,Image="1.jpg",CategoryId=1});
            _product.Add(new Product{ProductId=2,Name="Iphone 15",Price=45000,IsActive=true,Image="2.jpg",CategoryId=1});
            _product.Add(new Product{ProductId=3,Name="Iphone 16",Price=60000,IsActive=true,Image="3.jpg",CategoryId=1});
            _product.Add(new Product{ProductId=4,Name="Iphone 17",Price=70000,IsActive=false,Image="4.jpg",CategoryId=1});
            
            _product.Add(new Product{ProductId=5,Name="Macbook Air",Price=80000,IsActive=true,Image="5.jpg",CategoryId=2});
            _product.Add(new Product{ProductId=6,Name="Macbook Pro",Price=90000,IsActive=false,Image="6.jpg",CategoryId=2});
        }
        public static List<Product> Products{
            get{
                return _product;
            }
        }
        public static void CreateProduct(Product entity){
            _product.Add(entity);
        }
        public static List<Category> Categories{
            get{
                return _categories;
            }
        }
        public static void EditProduct(Product updatedProduct){
            var entity = _product.FirstOrDefault(p=> p.ProductId== updatedProduct.ProductId);
            if(entity != null){
                entity.Name= updatedProduct.Name;
                entity.Price= updatedProduct.Price;
                entity.Image= updatedProduct.Image;
                entity.CategoryId= updatedProduct.CategoryId;
                entity.IsActive= updatedProduct.IsActive;
            }
        }
        public static void EditIsActive(Product updatedProduct){
            var entity = _product.FirstOrDefault(p=> p.ProductId== updatedProduct.ProductId);
            if(entity != null){
                entity.IsActive= updatedProduct.IsActive;
            }
        }
        public static void DeleteProduct(Product entity){
            var deletedProduct = _product.FirstOrDefault(p=> p.ProductId== entity.ProductId);
            if(deletedProduct != null)
            {
                _product.Remove(deletedProduct);
            }
        }
        
    }
}