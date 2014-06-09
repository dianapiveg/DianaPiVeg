using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using avanced.Models;

namespace avanced.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public String Index()
        {

            return "Navegar a una url para mostrar un ejemplo";
        }

        public ViewResult AutoProperty()
        {
            //crear un nuevo objeto
            // De la clase producto

            Product myproduct = new Product();

            //Establece el valor de la propiedad
            myproduct.productoID = 12;
            myproduct.Name = "Kayak";
            myproduct.Description = "kiosteca Blue";
            myproduct.Category = "SPORTS";
            myproduct.Price = 12.5f;

            String salida =
                String.Format("{0}-{2}-{3}-{4:c0}", myproduct.productoID, myproduct.Name, myproduct.Description, myproduct.Category,
          // Genera la vista
            return View("results", (object)salida);
            
   
        }
    }

}

                                
        
