//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Laba5._2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Authorizations
    {
        public int Account_ID { get; set; }
        public Nullable<int> Employee_ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Role_ID { get; set; }
    
        public virtual Employees Employees { get; set; }
        public virtual Roles Roles { get; set; }
    }
}
