//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LTQL11.Models
{
    using System;
    using System.Collections.Generic;
    using System.Web.Mvc;

    public partial class Person
    {
        public string PersonID { get; set; }
        [AllowHtml]
        public string PersonName { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public string Discriminator { get; set; }
    }
}
