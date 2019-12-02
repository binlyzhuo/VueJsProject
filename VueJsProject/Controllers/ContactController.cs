using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VueJsProject.Models;
using VueJsProject.Repository;

namespace VueJsProject.Controllers
{
    public class ContactController : Controller
    {
        private static ContactRepository contactRepository = new ContactRepository();

        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult Get()
        {
            return Json(contactRepository.Get(), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Add(Contact contact)
        {
            contactRepository.Put(contact);
            return Json(contactRepository.Get());
        }

        [HttpPost]
        public JsonResult Update(Contact contact)
        {
            contactRepository.Post(contact);
            return Json(contactRepository.Get());
        }

        [HttpPost]
        public JsonResult Delete(string id)
        {
            var contact = contactRepository.Get(id);
            contactRepository.Delete(id);
            return Json(contactRepository.Get());
        }
    }
}