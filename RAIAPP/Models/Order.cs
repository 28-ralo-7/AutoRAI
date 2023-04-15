//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RAIAPP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.OrderServices = new HashSet<OrderService>();
        }
    
        public int Id { get; set; }
        public Nullable<int> OrderPersonal { get; set; }
        public Nullable<int> OrderAuto { get; set; }
        public System.DateTime OrderDate { get; set; }
        public Nullable<int> OrderStatus { get; set; }
    
        public virtual Auto Auto { get; set; }
        public virtual Personal Personal { get; set; }
        public virtual Status Status { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderService> OrderServices { get; set; }
    }
}
