//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace praktos1_EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orders
    {
        public int OrderID { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
    
        public virtual Users Users { private get; set; }
    }
}
