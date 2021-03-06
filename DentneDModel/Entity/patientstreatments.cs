//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DG.DentneD.Model.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class patientstreatments
    {
        public patientstreatments()
        {
            this.estimateslines = new HashSet<estimateslines>();
            this.invoiceslines = new HashSet<invoiceslines>();
        }
    
        public int patientstreatments_id { get; set; }
        public int doctors_id { get; set; }
        public int patients_id { get; set; }
        public int treatments_id { get; set; }
        public System.DateTime patientstreatments_creationdate { get; set; }
        public Nullable<System.DateTime> patientstreatments_fulfilldate { get; set; }
        public bool patientstreatments_ispaid { get; set; }
        public decimal patientstreatments_price { get; set; }
        public bool patientstreatments_isunitprice { get; set; }
        public decimal patientstreatments_taxrate { get; set; }
        public string patientstreatments_description { get; set; }
        public string patientstreatments_notes { get; set; }
        public Nullable<System.DateTime> patientstreatments_expirationdate { get; set; }
        public bool patientstreatments_t11 { get; set; }
        public bool patientstreatments_t12 { get; set; }
        public bool patientstreatments_t13 { get; set; }
        public bool patientstreatments_t14 { get; set; }
        public bool patientstreatments_t15 { get; set; }
        public bool patientstreatments_t16 { get; set; }
        public bool patientstreatments_t17 { get; set; }
        public bool patientstreatments_t18 { get; set; }
        public bool patientstreatments_t21 { get; set; }
        public bool patientstreatments_t22 { get; set; }
        public bool patientstreatments_t23 { get; set; }
        public bool patientstreatments_t24 { get; set; }
        public bool patientstreatments_t25 { get; set; }
        public bool patientstreatments_t26 { get; set; }
        public bool patientstreatments_t27 { get; set; }
        public bool patientstreatments_t28 { get; set; }
        public bool patientstreatments_t31 { get; set; }
        public bool patientstreatments_t32 { get; set; }
        public bool patientstreatments_t33 { get; set; }
        public bool patientstreatments_t34 { get; set; }
        public bool patientstreatments_t35 { get; set; }
        public bool patientstreatments_t36 { get; set; }
        public bool patientstreatments_t37 { get; set; }
        public bool patientstreatments_t38 { get; set; }
        public bool patientstreatments_t41 { get; set; }
        public bool patientstreatments_t42 { get; set; }
        public bool patientstreatments_t43 { get; set; }
        public bool patientstreatments_t44 { get; set; }
        public bool patientstreatments_t45 { get; set; }
        public bool patientstreatments_t46 { get; set; }
        public bool patientstreatments_t47 { get; set; }
        public bool patientstreatments_t48 { get; set; }
    
        public virtual doctors doctors { get; set; }
        public virtual ICollection<estimateslines> estimateslines { get; set; }
        public virtual ICollection<invoiceslines> invoiceslines { get; set; }
        public virtual patients patients { get; set; }
        public virtual treatments treatments { get; set; }
    }
}
