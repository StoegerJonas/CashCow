//@BaseCode
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCow.Logic.Entities
{
    partial class VersionEntity : IdentityEntity, Contracts.IVersionable
    {
        public byte[] RowVersion { get; set; }
    }
}
