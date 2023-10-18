using Microsoft.AspNetCore.Mvc;
using ViewComponentCoreMvc.Models;

namespace ViewComponentCoreMvc.ViewComponents
{
    //Create a Class, and it should inherit from ViewComponent class
    public class TopProductsViewComponent : ViewComponent
    {
        //The Invoke method for the View component
        public async Task<IViewComponentResult> InvokeAsync(int count)
        {
            // Your logic for preparing data
            ProductRepository productRepository = new ProductRepository();
            var books=await productRepository.GetTopProductAsync(count);
            return View(books);
        }

        //public IViewComponentResult Invoke(int count)
        //{
        // // Your logic for preparing data
        // ProductRepository productRepository = new ProductRepository();
        // var books = productRepository.GetTopProductsAsync(count).Result;
        // return View(books);
        //}

    }
}
