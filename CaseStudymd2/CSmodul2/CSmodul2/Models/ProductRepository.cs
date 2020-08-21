using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSmodul2.Models
{
    public class ProductRepository : IProductRepository
    {
        private List<Products> listProducts;
        public ProductRepository()
        {
            this.listProducts = new List<Products>()
            {
                new Products()
                {
                    ProductId = "c397a3c0-4e88-44a6-8770-9ca035c374ea",
                    NameProduct = "Vui vẻ không quạo",
                    ProType = Types.TruyenCuoi,
                    ShortDescription = "#Chuyên nghiệp",
                    Author = "#Tín",
                    Content = "Người quản lý báo cáo với ông chủ: “Anh chàng Gines hết thuốc chữa rồi thưa ngài, ngày nào đi làm anh ta cũng gà gật, tôi cũng đã đổi bộ phận làm việc cho anh ta ba lần rồi, nhưng lần nào anh ta cũng thế, không bỏ được thói quen ngủ gật của mình." +
                   "Vậy cho anh ta ra cửa hàng bán Pyjama đi, treo trên người anh ta một bảng quảng cáo: Pyjama chất lượng, thực nghiệm tại chỗ” " + 
                   "Ông chủ nói."
                },
                new Products()
                {
                    ProductId = "5c00ee32-ba41-402d-99ca-d47aa65a3b6d",
                    NameProduct = "Ngày ấy đâu rồi",
                    ProType = Types.TruyenNgonTinh,
                    ShortDescription = "#Người lúc xưa tỏ tình với bạn sao rồi!!!",
                    Author = "#Quang",
                    Content = "16 tuổi, cô tỏ tình với anh, anh từ chối, sau khi tốt nghiệp, ai nấy đều bận rộn với công việc của chính mình. Họ đã trải qua những mối tình khác nhau. Năm 26 tuổi, giữa biển người, anh cầu hôn cô. Cô hỏi anh, khi ấy sao anh lại công đồng ý. Anh nói, anh muốn là mái ấm của em, chứ không phải là mối tình đầu. Bây giờ chúng ta mới hiểu thế nào là tình yêu. "
                },
                new Products()
                {
                    ProductId = "ce7f466c-a8b1-4949-bcc4-a66f5737e401",
                    NameProduct = "Từ trên cao nhìn xuống",
                    ProType = Types.TruyenMa,
                    ShortDescription = "Đọc xong đừng nhìn lên trên nha các bạn",
                    Author = "#Trung",
                    Content = "Bạn sợ ma ư??? Đừng sợ mà hãy tự đi tìm họ! Bạn có thể nhìn sang phải, nhìn sang trái, dưới gầm giường, sau tủ đồ hay sau lưng bạn. Nhưng đừng nhìn lên trần nhà, họ không thích bị nhìn thấy đâu."
                }
            };
        }
        public Products Create(Products products)
        {
            products.ProductId = $"{Guid.NewGuid()}";
            listProducts.Add(products);
            return products;
        }

        public bool Delete(string id)
        {
            var delProduct = Get(id);
            if(delProduct != null)
            {
                listProducts.Remove(delProduct);
                return true;
            }
            return false;
        }

        public Products Edit(Products products)
        {
            var editProduct = Get(products.ProductId);
            editProduct.NameProduct = products.NameProduct;
            editProduct.ShortDescription = products.ShortDescription;
            editProduct.Content = products.Content;
            editProduct.Author = products.Author;
            return editProduct;
        }

        public Products Get(string id)
        {
            return listProducts.FirstOrDefault(e => e.ProductId == id);
        }

        public IEnumerable<Products> Gets()
        {
            return listProducts;
        }
    }
}
