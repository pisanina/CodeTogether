using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using CodeTogether.Models;

namespace CodeTogether.Controllers
{
    public class tblUserDatasController : ApiController
    {
        private UserDataContext db = new UserDataContext();

        // GET: api/tblUserDatas
        public IQueryable<tblUserData> GettblUserData()
        {
            return db.tblUserData;
        }

        // GET: api/tblUserDatas/5
        [ResponseType(typeof(tblUserData))]
        public IHttpActionResult GettblUserData(int id)
        {
            tblUserData tblUserData = db.tblUserData.Find(id);
            if (tblUserData == null)
            {
                return NotFound();
            }

            return Ok(tblUserData);
        }

        // PUT: api/tblUserDatas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PuttblUserData(int id, tblUserData tblUserData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblUserData.ID)
            {
                return BadRequest();
            }

            db.Entry(tblUserData).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblUserDataExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/tblUserDatas
        [ResponseType(typeof(tblUserData))]
        public IHttpActionResult PosttblUserData(tblUserData tblUserData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tblUserData.Add(tblUserData);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tblUserData.ID }, tblUserData);
        }

        // DELETE: api/tblUserDatas/5
        [ResponseType(typeof(tblUserData))]
        public IHttpActionResult DeletetblUserData(int id)
        {
            tblUserData tblUserData = db.tblUserData.Find(id);
            if (tblUserData == null)
            {
                return NotFound();
            }

            db.tblUserData.Remove(tblUserData);
            db.SaveChanges();

            return Ok(tblUserData);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblUserDataExists(int id)
        {
            return db.tblUserData.Count(e => e.ID == id) > 0;
        }
    }
}