using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError =  "Bu kategoriye daha fazla ürün eklenemez";
        public static string ProductNameAlreadyExists = "Bu isimde zaten bir ürün var";
        internal static string CategoryLimitExceded = "kategori limiti aşıldı";
    }
}
