﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class VapeStoreDBEntities : DbContext
    {
        public VapeStoreDBEntities()
            : base("name=VapeStoreDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Characteristic> Characteristics { get; set; }
        public virtual DbSet<Flavor> Flavors { get; set; }
        public virtual DbSet<Juice> Juices { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
    }
}