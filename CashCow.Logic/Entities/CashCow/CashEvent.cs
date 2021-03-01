using CashCow.Contracts.Persistence.CashCow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCow.Logic.Entities.CashCow
{
    class CashEvent : VersionEntity, Contracts.Persistence.CashCow.ICashEvent
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Currency { get; set; }
        public string ExtraInfo { get; set; }
        public string Category { get; set; }
        public string Participants { get; set; }

        public void CopyProperties(ICashEvent other)
        {
            Id = other.Id;
            RowVersion = other.RowVersion;
            Title = other.Title;
            Description = other.Description;
            Currency = other.Currency;
            ExtraInfo = other.ExtraInfo;
            Category = other.Category;
            Participants = other.Participants;






        }
}
