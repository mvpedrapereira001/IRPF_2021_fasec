using IRPF_2021_fasec.DAL;
using IRPF_2021_fasec.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace IRPF_2021_fasec.Controllers
{
    public class TitularController : Controller
    {
        private EFContext db = new EFContext();

        // GET: Titulars
        public ActionResult Index()
        {




            return View();
        }

        // GET: Titulars/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Titular titular = db.Titular.Find(id);
            if (titular == null)
            {
                return HttpNotFound();
            }
            return View(titular);
        }

        // GET: Titulars/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Titulars/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Cpf_Titular,Nome_titular,DataNascimento,ID_USUARIO")] Titular titular)
        {
            if (ModelState.IsValid)
            {
                db.Titular.Add(titular);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(titular);
        }

        // GET: Titulars/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Titular titular = db.Titular.Find(id);
            if (titular == null)
            {
                return HttpNotFound();
            }
            return View(titular);
        }

        // POST: Titulars/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Cpf_Titular,Nome_titular,DataNascimento,ID_USUARIO")] Titular titular)
        {
            if (ModelState.IsValid)
            {
                db.Entry(titular).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(titular);
        }

        // GET: Titulars/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Titular titular = db.Titular.Find(id);
            if (titular == null)
            {
                return HttpNotFound();
            }
            return View(titular);
        }

        // POST: Titulars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Titular titular = db.Titular.Find(id);
            db.Titular.Remove(titular);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
