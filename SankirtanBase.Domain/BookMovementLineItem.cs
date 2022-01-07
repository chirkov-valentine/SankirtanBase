using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SankirtanBase.Domain
{
    public class BookMovementLineItem : XPObject
    {
        public BookMovementLineItem(Session session) : base(session) { }
        private int _quantity;
        public int Quantity
        {
            get { return _quantity; }
            set { SetPropertyValue(nameof(Quantity), ref _quantity, value); }
        }

        private Book _book;

        [Association("Book-BookMovementLineItems")]
        public Book Book
        {
            get { return _book; }
            set { SetPropertyValue(nameof(Book), ref _book, value); }
        }

        private BookMovementTransaction _bookMovementTransaction;

        [Association("BookMovementTransaction-BookMovementLineItems")]
        public BookMovementTransaction BookMovementTransaction
        {
            get { return _bookMovementTransaction; }
            set { SetPropertyValue(nameof(BookMovementTransaction), ref _bookMovementTransaction, value); }
        }
    }
}
