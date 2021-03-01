﻿using CommonBase.Attributes;
using SmartNQuick.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCow.Contracts.Persistence.CashCow
{
    public interface IPayment : IVersionable, ICopyable<IPayment>
    {
        [ContractPropertyInfo(Required = true, MaxLength = 256, IsUnique = true)]
        string Title { get; set; }

        [ContractPropertyInfo(Required = true)]
        string Zahlung { get; set; }

        [ContractPropertyInfo(Required = true)]
        int Amount { get; set; }

        [ContractPropertyInfo(Required = true)]
        DateTime Date { get; set; }

        [ContractPropertyInfo(Required = true, MaxLength = 64)]
        string Payer { get; set; }
    }
}
