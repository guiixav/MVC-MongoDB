using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MongoDB.Bson;
using MongoDB.Driver.Core;
using System.Configuration;
using RoxierMongoDB.App_Start;
using MongoDB.Driver;
using RoxierMongoDB.Models;     

namespace RoxierMongoDB.Controllers
{
    public class MaquinaController : Controller
    {

        private MongoDBContext dbcontext;
        private IMongoCollection<Maquina> tempCollection;
        private IMongoCollection<Maquina> vibrCollection;


        public MaquinaController()
        {
            dbcontext = new MongoDBContext();
            tempCollection = dbcontext.database.GetCollection<Maquina>("sth_/_urn:ngsi-ld:MaquinaTemp:001_Maquina");
            vibrCollection = dbcontext.database.GetCollection<Maquina>("sth_/_urn:ngsi-ld:MaquinaVibr:001_Maquina");

        }


        public ActionResult Temperatura()
        {

            
            List<Maquina> Temperatura = tempCollection.AsQueryable<Maquina>().ToList();



            return PartialView(Temperatura);


        }

        public ActionResult Vibracao()
        {
            List<Maquina> Vibracao = vibrCollection.AsQueryable<Maquina>().ToList();
            return PartialView(Vibracao);

        }


        // GET: Maquina
        public ActionResult Index()
        {
            /*List<Maquina> maquina = maquinaCollection.AsQueryable<Maquina>().ToList();*/
            return View();
        }

        // GET: Maquina/Details/5
        public ActionResult Details(string id)
        {
            /*var maquinaID = new ObjectId(id);
            var maquina = maquinaCollection.AsQueryable<Maquina>().SingleOrDefault(x => x.Id == maquinaID*/
            return View();
        }

        // GET: Maquina/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Maquina/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Maquina/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Maquina/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Maquina/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Maquina/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
