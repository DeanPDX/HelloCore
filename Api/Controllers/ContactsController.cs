using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace HelloCore.Api.Controllers
{
    [Route("api/[controller]")]
    public class ContactsController : Controller 
    {
        // Note: for the sake of demo brevity we are just creating an
        // inner class but don't do this in the real world.
        public class ContactModel 
        {
            // Nobody gets middle names around these parts...
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        // GET api/contacts
        [HttpGet]
        public List<ContactModel> Get()
        {
            // Our data access layer, seen here, is the height of elegance.
            return new List<ContactModel>() {
                new ContactModel() { FirstName = "Dean", LastName = "Davidson" },
                new ContactModel() { FirstName = "Scott", LastName = "Gu" },
                new ContactModel() { FirstName = "Other", LastName = "Scott" },
                new ContactModel() { FirstName = "John", LastName = "Doe" }
            };
        }
    }
}