using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using System.Net.Http;

namespace WebAppBar.Controllers
{
    public class ProductoController : ApiController
    {

        [System.Web.Http.HttpPost]
        // GET: Producto
        public IHttpActionResult Add()
        {
            using (Models.BarDbEntities db = new Models.BarDbEntities())

            {
                var oProducto = new Models.Producto();
                oProducto.nomProd = "Chaparro";
                oProducto.descripcion = "Botella";
                oProducto.precio = 1;
                oProducto.estado = 3;
                oProducto.cantidad = 4;
                db.Productoes.Add(oProducto);
                db.SaveChanges();
            } 
            return Ok("Hecho");
            
        }
    }
}