//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class category
    {
        public category()
        {
            this.sub_category = new HashSet<sub_category>();
        }
    
        public int id { get; set; }
        public string category_name { get; set; }
    
        public virtual ICollection<sub_category> sub_category { get; set; }
    }
}