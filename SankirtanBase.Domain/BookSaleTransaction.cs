using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SankirtanBase.Domain
{
    public class BookSaleTransaction : XPObject
    {
        public BookSaleTransaction(Session session) : base(session) { }

        private DateTime _date;
        public DateTime Date
        {
            get { return _date; }
            set { SetPropertyValue(nameof(Date), ref _date, value); }
        }

        private bool _isArchive;
        public bool IsArchive
        {
            get { return _isArchive; }
            set { SetPropertyValue(nameof(IsArchive), ref _isArchive, value); }
        }

        [Association("BookSaleTransaction-BookSaleLineItems")]
        public XPCollection<BookSaleLineItem> BookSaleLineItems
        {
            get { return GetCollection<BookSaleLineItem>(); }
        }

        private MoneyDebetOperation _moneyDebetOperation;

        [Association("MoneyDebetOperation-BookSaleTransactions")]
        public MoneyDebetOperation MoneyDebetOperation
        {
            get { return _moneyDebetOperation; }
            set { SetPropertyValue(nameof(MoneyDebetOperation), ref _moneyDebetOperation, value); }
        }

        private Contractor _contractor;

        [Association("Contractor-BookSaleTransactions")]
        public Contractor Contractor
        {
            get { return _contractor; }
            set { SetPropertyValue(nameof(Contractor), ref _contractor, value); }
        }
    }
}
