//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Service
{
    using System;
    using System.Collections.Generic;
    
    public partial class machine
    {
        public machine()
        {
            this.oil_usage = new HashSet<oil_usage>();
            this.productions = new HashSet<production>();
            this.products_active = new HashSet<products_active>();
        }
    
        public int m_id { get; set; }
        public Nullable<System.DateTime> installation { get; set; }
        public string description { get; set; }
    
        public virtual ICollection<oil_usage> oil_usage { get; set; }
        public virtual ICollection<production> productions { get; set; }
        public virtual ICollection<products_active> products_active { get; set; }
    }
}
