using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Claims;

namespace Claims.Controllers
{
    public class Claim_CLMController : Controller
    {
        private ClaimsEntities db = new ClaimsEntities();

        // GET: Claim_CLM
        public ActionResult Index()
        {
            return View(db.Claim_CLM.ToList());
        }

        // GET: Claim_CLM/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Claim_CLM claim_CLM = db.Claim_CLM.Find(id);
            if (claim_CLM == null)
            {
                return HttpNotFound();
            }
            return View(claim_CLM);
        }

        // GET: Claim_CLM/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Claim_CLM/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Insurer,PolicyType,PolicyNumber,FirstName,LastName,BusinessName,BusinessContactName,AddressSearch,Address1,Address2,City,PostCode,State,PhoneNumber,MobileNumber,Email,PolicyStartDate,PolicyEndDate,PolicyStatus,OutstandingPremium,OutstandingAmount,PolicyExcess,BrokerName,BrokerContact,Was_the_loss_reported_to_the_police_,Police_Reference_Number,Details,Same_as_Risk_Address,Address,Address_1,Address_2,Suburb,INFPostcode,INFState,Reported_by,First_Name,Last_Name,Contact_Number,INFEmail,Date_of_Loss,Time_of_Loss,Loss_Cause,Secondary_Loss_Casue,Claim_No_,External_Reference_Number,Reported_Date,Loss_Description,Severity,Claim_Decision,Contact_Type,CCFirst_Name,CCLast_Name,CCPhone_Number,CCMobile_Phone,CCEmail,Preferred_Contact,Catastrophe_Event,Description,Start_Date,End_Date,Claim_Owner,Assessment,Assessor")] Claim_CLM claim_CLM)
        {
            if (ModelState.IsValid)
            {
                db.Claim_CLM.Add(claim_CLM);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(claim_CLM);
        }

        // GET: Claim_CLM/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Claim_CLM claim_CLM = db.Claim_CLM.Find(id);
            if (claim_CLM == null)
            {
                return HttpNotFound();
            }
            return View("Create",claim_CLM);
        }

        // POST: Claim_CLM/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Insurer,PolicyType,PolicyNumber,FirstName,LastName,BusinessName,BusinessContactName,AddressSearch,Address1,Address2,City,PostCode,State,PhoneNumber,MobileNumber,Email,PolicyStartDate,PolicyEndDate,PolicyStatus,OutstandingPremium,OutstandingAmount,PolicyExcess,BrokerName,BrokerContact,Was_the_loss_reported_to_the_police_,Police_Reference_Number,Details,Same_as_Risk_Address,Address,Address_1,Address_2,Suburb,INFPostcode,INFState,Reported_by,First_Name,Last_Name,Contact_Number,INFEmail,Date_of_Loss,Time_of_Loss,Loss_Cause,Secondary_Loss_Casue,Claim_No_,External_Reference_Number,Reported_Date,Loss_Description,Severity,Claim_Decision,Contact_Type,CCFirst_Name,CCLast_Name,CCPhone_Number,CCMobile_Phone,CCEmail,Preferred_Contact,Catastrophe_Event,Description,Start_Date,End_Date,Claim_Owner,Assessment,Assessor")] Claim_CLM claim_CLM)
        {
            if (ModelState.IsValid)
            {
                db.Entry(claim_CLM).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Create", claim_CLM);
        }

        // GET: Claim_CLM/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Claim_CLM claim_CLM = db.Claim_CLM.Find(id);
            if (claim_CLM == null)
            {
                return HttpNotFound();
            }
            return View(claim_CLM);
        }

        // POST: Claim_CLM/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Claim_CLM claim_CLM = db.Claim_CLM.Find(id);
            db.Claim_CLM.Remove(claim_CLM);
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
