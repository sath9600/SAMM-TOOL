//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OwaspSAMM.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class AssessmentTemplate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AssessmentTemplate()
        {
            this.TemplateCategories = new HashSet<TemplateCategory>();
        }
    
        public int TemplateID { get; set; }
        public int TemplateVersion { get; set; }
        public Nullable<System.DateTime> TemplateDate { get; set; }
        public Nullable<bool> DefaultTemplate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TemplateCategory> TemplateCategories { get; set; }
    }
}
