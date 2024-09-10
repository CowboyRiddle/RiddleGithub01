using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace CB_Basic_App_AzDev.Pages
{
    public class BasicPageModel : PageModel
    {
        public string Name { get; private set; }
        public void OnGet()
        {
            Class1 tp = new Class1();
            Name = tp.Name;
        }
    }
}
