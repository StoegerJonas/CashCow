//@BaseCode
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCow.Logic.Entities
{
    partial class IdentityEntity : Contracts.IIdentifiable
    {
        public int Id { get; set; }
    }
}
