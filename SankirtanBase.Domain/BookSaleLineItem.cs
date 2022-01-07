using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SankirtanBase.Domain
{
    public class BookSaleLineItem : XPObject
    {
        public BookSaleLineItem(Session session) : base(session) { }
        private int _quantity;
        public int Quantity
        {
            get { return _quantity; }
            set { SetPropertyValue(nameof(Quantity), ref _quantity, value); }
        }

        private Price _price;

        [Association("Price-BookSaleLineItems")]
        public Price Price
        {
            get { return _price; }
            set { SetPropertyValue(nameof(Price), ref _price, value); }
        }

        private Book _book;

        [Association("Book-BookSaleLineItems")]
        public Book Book
        {
            get { return _book; }
            set { SetPropertyValue(nameof(Book), ref _book, value); }
        }

        private BookSaleTransaction _bookSaleTransaction;

        [Association("BookSaleTransaction-BookSaleLineItems")]
        public BookSaleTransaction BookSaleTransaction
        {
            get { return _bookSaleTransaction; }
            set { SetPropertyValue(nameof(BookSaleTransaction), ref _bookSaleTransaction, value); }
        }
    }
}
