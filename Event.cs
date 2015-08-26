using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventDatabase.Models
{
    public class Event
    {    
        public int EventId { get; set; }
        public string Name { get; set; }
        public string EventType { get; set; }
        public DateTime EventDate { get; set; }
        public decimal TotalBuget { get; set; }
        public string Location { get; set; }
        public Address LocatonAddress { get; set; }
        public decimal PriceOfLocation { get; set; }
        public string Food { get; set; }
        public decimal PriceOfFood { get; set; }
        public string Entertainment { get; set; }
        public string TypeOfEntertainment { get; set; }
        public decimal PriceOfEntertainment { get; set; }
        public string ColorOrThem { get; set; }
        public decimal PriceOfDecortion { get; set; }
        public string Outfits { get; set; }
        public decimal PriceOfOutfits { get; set; }
        public decimal MissAlse { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal AmountMoneyLeft { get; set; }
        public int NumberOfInviteScent { get; set; }
        public int NumberOfConfirmed { get; set; }
        public int NumberOfDeclained { get; set; }
        public int NumberOfUnConfirmed { get; set; }
        public IList<Organizer> Organizer { get; set;}
    }
}