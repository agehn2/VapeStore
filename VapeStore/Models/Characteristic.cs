//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VapeStore.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Characteristic
    {
        public string FlavorID { get; set; }
        public string NicLevel { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string BottleSize { get; set; }
        public string CharacteristicID { get; set; }
    
        public virtual Flavor Flavor { get; set; }
    }
}
