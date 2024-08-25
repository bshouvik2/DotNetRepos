using Bloggie.Data;
using Bloggie.Models.Domain;
using Bloggie.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Bloggie.Controllers
{
    public class AdminController : Controller
    {
        private myDbContext myDbContext1;
        public AdminController(myDbContext myDbContext)
        {
            myDbContext1 = myDbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Add")] 
        public IActionResult Add( AddTagRequest addTagRequest) {
            // mapping addtag request to tag domain model
         var tag = new Tag { name = addTagRequest.Name, displayname=addTagRequest.Displayname };
            myDbContext1.tags.Add(tag);
            myDbContext1.SaveChanges();
     //  var names = addTagRequest.Name;
     //  var Dnames = addTagRequest.Displayname;
            return View("Add"); 
        }
    }
}
