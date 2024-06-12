using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NvdBKGK_lession07.Models;

namespace NvdBKGK_lession07.Controllers
{
    public class nvdSinhViensController : Controller
    {
        private NVDK22CNT3_Lession07DbEntities5 db = new NVDK22CNT3_Lession07DbEntities5();

        // GET: nvdSinhViens
        public ActionResult NvdIndex()
        {
            var nvdSinhViens = db.nvdSinhViens.Include(n => n.nvdKhoa);
            return View(nvdSinhViens.ToList());
        }

        // GET: nvdSinhViens/Details/5
        public ActionResult NvdDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nvdSinhVien nvdSinhVien = db.nvdSinhViens.Find(id);
            if (nvdSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(nvdSinhVien);
        }

        // GET: nvdSinhViens/Create
        public ActionResult NvdCreate()
        {
            ViewBag.NvdMaKH = new SelectList(db.nvdKhoas, "NvdMaKH", "NvdTenKH");
            return View();
        }

        // POST: nvdSinhViens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NvdCreate([Bind(Include = "NvdMaSV,NvdHoSV,NvdTenSV,NvdNgaySinh,NvdPhai,NvdPhone,NvdEmail,NvdMaKH")] nvdSinhVien nvdSinhVien)
        {
            if (ModelState.IsValid)
            {
                db.nvdSinhViens.Add(nvdSinhVien);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.NvdMaKH = new SelectList(db.nvdKhoas, "NvdMaKH", "NvdTenKH", nvdSinhVien.NvdMaKH);
            return View(nvdSinhVien);
        }

        // GET: nvdSinhViens/Edit/5
        public ActionResult NvdEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nvdSinhVien nvdSinhVien = db.nvdSinhViens.Find(id);
            if (nvdSinhVien == null)
            {
                return HttpNotFound();
            }
            ViewBag.NvdMaKH = new SelectList(db.nvdKhoas, "NvdMaKH", "NvdTenKH", nvdSinhVien.NvdMaKH);
            return View(nvdSinhVien);
        }

        // POST: nvdSinhViens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NvdEdit([Bind(Include = "NvdMaSV,NvdHoSV,NvdTenSV,NvdNgaySinh,NvdPhai,NvdPhone,NvdEmail,NvdMaKH")] nvdSinhVien nvdSinhVien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nvdSinhVien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.NvdMaKH = new SelectList(db.nvdKhoas, "NvdMaKH", "NvdTenKH", nvdSinhVien.NvdMaKH);
            return View(nvdSinhVien);
        }

        // GET: nvdSinhViens/Delete/5
        public ActionResult NvdDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nvdSinhVien nvdSinhVien = db.nvdSinhViens.Find(id);
            if (nvdSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(nvdSinhVien);
        }

        // POST: nvdSinhViens/Delete/5
        [HttpPost, ActionName("NvdDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            nvdSinhVien nvdSinhVien = db.nvdSinhViens.Find(id);
            db.nvdSinhViens.Remove(nvdSinhVien);
            db.SaveChanges();
            return RedirectToAction("NvdIndex");
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
