using Microsoft.AspNetCore.Mvc;
using TestWeek7.Models;
namespace TestWeek7.Controllers
{

    public class ToDosController : Controller
    {
        private static List<ToDos> _todos = new List<ToDos>();
        public async Task<string> GetUsers()
        {
            //Define your baseUrl
            string baseUrl = "https://dummyjson.com/docs/todos";
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync(baseUrl))
                    {
                        using (HttpContent content = res.Content)
                        {
                            var data = await content.ReadAsStringAsync();
                            return data;
                        }
                    }
                }
            }
            catch (Exception exception)
            {
               return exception.Message;
            }
        }

        public async Task<IActionResult> Index()
        {
            TempData["Data"] = await GetUsers();
            return View();
        }
        //public IActionResult Index()
        //{
        //    return View(GetToDos());
        //}
    }
}
