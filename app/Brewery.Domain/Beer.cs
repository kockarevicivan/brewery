//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Brewery.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class Beer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal AlcoholPercentage { get; set; }
        public decimal IBU { get; set; }
        public Nullable<int> Quantity { get; set; }
        public int BeerTypeId { get; set; }
        public Nullable<int> BreweryId { get; set; }
    
        public virtual BeerType BeerType { get; set; }
        public virtual Brewery Brewery { get; set; }
    }
}
