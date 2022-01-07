using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SankirtanBase.Domain
{
    public class Price : XPObject
    {
        public Price(Session session) : base(session) { }
        private decimal _value;

        public decimal Value
        {
            get { return _value; }
            set { SetPropertyValue(nameof(Value), ref _value, value); }
        }

        private DateTime _date;

        public DateTime Date
        {
            get { return _date; }
            set { SetPropertyValue(nameof(Date), ref _date, value); }
        }

        private Book _book;

        [Association("Book-Prices")]
        public Book Book
        {
            get { return _book; }
            set { SetPropertyValue(nameof(Book), ref _book, value); }
        }

        [Association("Price-BookSaleLineItems")]
        public XPCollection<BookSaleLineItem> BookSaleLineItems
        {
            get { return GetCollection<BookSaleLineItem>(); }
        }
    }
}
