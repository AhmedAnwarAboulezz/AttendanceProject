//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AttendanceProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AttendanceLog
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string TimeIN { get; set; }
        public string TimeOut { get; set; }
        public string TimeFunction { get; set; }
        public string FunctionID { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public Nullable<int> MachineTableID { get; set; }
        public string Comment { get; set; }
    
        public virtual AttMachineTableRefrence AttMachineTableRefrence { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
