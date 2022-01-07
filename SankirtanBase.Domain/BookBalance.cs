using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SankirtanBase.Domain
{
    public class BookBalance : XPObject
    {
        public BookBalance(Session session) : base(session) { }
        private int _value;

        public int Value
        {
            get { return _value; }
            set { SetPropertyValue(nameof(Value), ref _value, value); }
        }

        private Book _book;

        [Association("Book-BookBalances")]
        public Book Book
        {
            get { return _book; }
            set { SetPropertyValue(nameof(Book), ref _book, value); }
        }

        private Contractor _contractor;

        [Association("Contractor-BookBalances")]
        public Contractor Contractor
        {
            get { return _contractor; }
            set { SetPropertyValue(nameof(Contractor), ref _contractor, value); }
        }
    }
}
