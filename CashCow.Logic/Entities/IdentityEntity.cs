﻿//@BaseCode
using CashCow.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCow.Logic.Entities
{
    internal abstract partial class IdentityEntity : IIdentifiable
    {
        public int Id { get; set; }
    }
}
