//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ToyShop1.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public int IdEmployee { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public System.DateTime Birthday { get; set; }
        public string IdGender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int IdUser { get; set; }
    
        public virtual Gender Gender { get; set; }
        public virtual User User { get; set; }
    }
}
