//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public int Id { get; set; }
        public int User_Id { get; set; }
        public System.DateTime HireDate { get; set; }
        public double Salary { get; set; }

        public List<Links> links = new List<Links>();

        public virtual User User { get; set; }
    }
}
