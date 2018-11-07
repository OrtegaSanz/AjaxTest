using AjaxTest.Models; 
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxTest.Controllers
{
    public class AjaxTestController : Controller
    {
        
        // GET: AjaxTest
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult buscarProveedor(int a)
        {
            CARWASHEntities db = new CARWASHEntities();
            PROVEEDOR pROVEEDOR= db.PROVEEDOR.Find(a);
            return Json(pROVEEDOR, JsonRequestBehavior.AllowGet);
        }

        public JsonResult buscarMaterial(string b)
        {
            CARWASHEntities db = new CARWASHEntities();
            MATERIALES mATERIALES = db.MATERIALES.Find(b);
            string[] codigoMaterial = new string[4];
            codigoMaterial[0] = mATERIALES.DESCRIPCION;
            codigoMaterial[1] = mATERIALES.PRECI_UNI.ToString();
            codigoMaterial[2] = mATERIALES.COD_MATE;
            return Json(codigoMaterial, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Registrar(string row, string ruc)
        {
            CARWASHEntities db = new CARWASHEntities();
            Random r = new Random();
            var stringifiedTable = row.Split('-');
            List<string> codigo = new List<string>();
            List<string> cantidad = new List<string>();
            List<string> subtotal = new List<string>();
            for (int i = 0; i < stringifiedTable.Count(); i += 5)
            {
                codigo.Add(stringifiedTable[i]);
            }
            for(int i = 2; i < stringifiedTable.Count(); i+=5)
            {
                cantidad.Add(stringifiedTable[i]);
            }
            for (int i = 4; i < stringifiedTable.Count(); i+=5)
            {
                subtotal.Add(stringifiedTable[i]);
            }
            List<ORDEN_COMPRA> oRDEN_COMPRAs = new List<ORDEN_COMPRA>();
            for(int i = 0; i < codigo.Count() - 1; i++)
            {
                ORDEN_COMPRA orden_compra = new ORDEN_COMPRA();
                orden_compra.COD_OC = r.Next(1000000, 9999999);
                orden_compra.COD_MATE = codigo[i];
                orden_compra.RUC = int.Parse(ruc);
                orden_compra.CANTIDAD = int.Parse(cantidad[i]);
                orden_compra.SUBTOTAL = double.Parse(subtotal[i]);
                oRDEN_COMPRAs.Add(orden_compra);
            }
            db.ORDEN_COMPRA.AddRange(oRDEN_COMPRAs);
            db.SaveChanges();
            return Json(codigo.Count() + "," + cantidad.Count() + "," + subtotal.Count() + "," + codigo.Last(), JsonRequestBehavior.AllowGet);
        }
    }
}