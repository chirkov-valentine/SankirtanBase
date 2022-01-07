using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SankirtanBase.Domain
{
    public class MoneyBalance : XPObject
    {
        public MoneyBalance(Session session) : base(session) { }

        private decimal _value;

        public decimal Value
        {
            get { return _value; }
            set { SetPropertyValue(nameof(Value), ref _value, value); }
        }

        private Contractor _contractor;

        [Association("Contractor-MoneyBalances")]
        public Contractor Contractor
        {
            get { return _contractor; }
            set { SetPropertyValue(nameof(Contractor), ref _contractor, value); }
        }
    }
}
