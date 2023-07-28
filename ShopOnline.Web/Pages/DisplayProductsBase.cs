using Microsoft.AspNetCore.Components;
using ShopOnline.Models.Dtos;

namespace ShopOnline.Web.Pages
{
    public class DisplayProductsBase : ProductsBase
    {
        [Parameter]
        public IEnumerable<ProductDto> Products { get; set; }

    }
}
