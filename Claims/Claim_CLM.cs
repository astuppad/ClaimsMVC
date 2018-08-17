//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Claims
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Claim_CLM
    {
        [Display(Name = "ID")]
        public int ID { get; set; }
        [Display(Name = "Insurer")]
        public string Insurer { get; set; }
        [Display(Name = "Policy Type")]
        public string PolicyType { get; set; }
        [Display(Name = "Policy Number")]
        public int PolicyNumber { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Business Name")]
        public string BusinessName { get; set; }
        [Display(Name = "Business Contact Name")]
        public string BusinessContactName { get; set; }
        [Display(Name = "Address Search")]
        public string AddressSearch { get; set; }
        [Display(Name = "Address 1")]
        public string Address1 { get; set; }
        [Display(Name = "Address 2")]
        public string Address2 { get; set; }
        [Display(Name = "City/Suburb")]
        public string City { get; set; }
        [Display(Name = "Post Code")]
        public string PostCode { get; set; }
        [Display(Name = "State")]
        public string State { get; set; }
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Mobile Number")]
        public string MobileNumber { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Policy Start Date")]
        public Nullable<System.DateTime> PolicyStartDate { get; set; }
        [Display(Name = "Policy End Date")]
        public Nullable<System.DateTime> PolicyEndDate { get; set; }
        [Display(Name = "Policy Status")]
        public string PolicyStatus { get; set; }
        [Display(Name = "Outstanding Premium")]
        public Nullable<decimal> OutstandingPremium { get; set; }
        [Display(Name = "Outstanding Amount")]
        public Nullable<decimal> OutstandingAmount { get; set; }
        [Display(Name = "Policy Excess")]
        public Nullable<decimal> PolicyExcess { get; set; }
        [Display(Name = "Broker Name")]
        public string BrokerName { get; set; }
        [Display(Name = "Broker Contact ")]
        public string BrokerContact { get; set; }
        [Display(Name = "Was the loss reported to the police?")]
        public string Was_the_loss_reported_to_the_police_ { get; set; }
        [Display(Name = "Police Reference Number")]
        public Nullable<int> Police_Reference_Number { get; set; }
        [Display(Name = "Details")]
        public string Details { get; set; }
        [Display(Name = "Same as Risk Address")]
        public bool Same_as_Risk_Address { get; set; }
        [Display(Name = "Enter Address")]
        public string Address { get; set; }
        [Display(Name = "Address 1")]
        public string Address_1 { get; set; }
        [Display(Name = "Address 2")]
        public string Address_2 { get; set; }
        [Display(Name = "Suburb")]
        public string Suburb { get; set; }
        [Display(Name = "Postcode")]
        public string INFPostcode { get; set; }
        [Display(Name = "State")]
        public string INFState { get; set; }
        [Display(Name = "Reported by")]
        public string Reported_by { get; set; }
        [Display(Name = "First Name")]
        public string First_Name { get; set; }
        [Display(Name = "Last Name")]
        public string Last_Name { get; set; }
        [Display(Name = "Contact Number")]
        public string Contact_Number { get; set; }
        [Display(Name = "Email")]
        public string INFEmail { get; set; }
        [Display(Name = "Date of Loss")]
        public System.DateTime Date_of_Loss { get; set; }
        [Display(Name = "Time of Loss")]
        public Nullable<System.TimeSpan> Time_of_Loss { get; set; }
        [Display(Name = "Loss Cause")]
        public string Loss_Cause { get; set; }
        [Display(Name = "Secondary Loss Casue")]
        public string Secondary_Loss_Casue { get; set; }
        [Display(Name = "Claim No.")]
        public Nullable<int> Claim_No_ { get; set; }
        [Display(Name = "External Reference Number")]
        public string External_Reference_Number { get; set; }
        [Display(Name = "Reported Date")]
        public Nullable<System.DateTime> Reported_Date { get; set; }
        [Display(Name = "Loss Description")]
        public string Loss_Description { get; set; }
        [Display(Name = "Severity")]
        public string Severity { get; set; }
        [Display(Name = "Claim Decision")]
        public string Claim_Decision { get; set; }
        [Display(Name = "Contact Type")]
        public string Contact_Type { get; set; }
        [Display(Name = "First Name")]
        public string CCFirst_Name { get; set; }
        [Display(Name = "Last Name")]
        public string CCLast_Name { get; set; }
        [Display(Name = "Phone Number")]
        public string CCPhone_Number { get; set; }
        [Display(Name = "Mobile Phone")]
        public string CCMobile_Phone { get; set; }
        [Display(Name = "Email")]
        public string CCEmail { get; set; }
        [Display(Name = "Preferred Contact")]
        public string Preferred_Contact { get; set; }
        [Display(Name = "Catastrophe Event")]
        public string Catastrophe_Event { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Display(Name = "Start Date")]
        public Nullable<System.DateTime> Start_Date { get; set; }
        [Display(Name = "End Date")]
        public Nullable<System.DateTime> End_Date { get; set; }
        [Display(Name = "Claim Owner")]
        public string Claim_Owner { get; set; }
        [Display(Name = "Assessment")]
        public string Assessment { get; set; }
        [Display(Name = "Assessor")]
        public string Assessor { get; set; }
    }
}
