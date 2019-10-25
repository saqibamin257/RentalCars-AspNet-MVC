﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarRentalSystem
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class CarRentalEntities : DbContext
    {
        public CarRentalEntities()
            : base("name=CarRentalEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Car> Cars { get; set; }
        public DbSet<BookingDetail> BookingDetails { get; set; }
    
        public virtual ObjectResult<string> AddCarBooking(string carName, string pickupLocation, string pickupTime, string dropLocation, string dropTime, string name, string email, string phone)
        {
            var carNameParameter = carName != null ?
                new ObjectParameter("carName", carName) :
                new ObjectParameter("carName", typeof(string));
    
            var pickupLocationParameter = pickupLocation != null ?
                new ObjectParameter("pickupLocation", pickupLocation) :
                new ObjectParameter("pickupLocation", typeof(string));
    
            var pickupTimeParameter = pickupTime != null ?
                new ObjectParameter("pickupTime", pickupTime) :
                new ObjectParameter("pickupTime", typeof(string));
    
            var dropLocationParameter = dropLocation != null ?
                new ObjectParameter("dropLocation", dropLocation) :
                new ObjectParameter("dropLocation", typeof(string));
    
            var dropTimeParameter = dropTime != null ?
                new ObjectParameter("dropTime", dropTime) :
                new ObjectParameter("dropTime", typeof(string));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("phone", phone) :
                new ObjectParameter("phone", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("AddCarBooking", carNameParameter, pickupLocationParameter, pickupTimeParameter, dropLocationParameter, dropTimeParameter, nameParameter, emailParameter, phoneParameter);
        }
    
        public virtual ObjectResult<GetCars_Result1> GetCars()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetCars_Result1>("GetCars");
        }
    
        public virtual ObjectResult<string> fn_AddBookingDetail(string carName, string pickupLocation, string pickupTime, string dropLocation, string dropTime, string name, string email, string phone)
        {
            var carNameParameter = carName != null ?
                new ObjectParameter("carName", carName) :
                new ObjectParameter("carName", typeof(string));
    
            var pickupLocationParameter = pickupLocation != null ?
                new ObjectParameter("pickupLocation", pickupLocation) :
                new ObjectParameter("pickupLocation", typeof(string));
    
            var pickupTimeParameter = pickupTime != null ?
                new ObjectParameter("pickupTime", pickupTime) :
                new ObjectParameter("pickupTime", typeof(string));
    
            var dropLocationParameter = dropLocation != null ?
                new ObjectParameter("dropLocation", dropLocation) :
                new ObjectParameter("dropLocation", typeof(string));
    
            var dropTimeParameter = dropTime != null ?
                new ObjectParameter("dropTime", dropTime) :
                new ObjectParameter("dropTime", typeof(string));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("phone", phone) :
                new ObjectParameter("phone", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("fn_AddBookingDetail", carNameParameter, pickupLocationParameter, pickupTimeParameter, dropLocationParameter, dropTimeParameter, nameParameter, emailParameter, phoneParameter);
        }
    }
}