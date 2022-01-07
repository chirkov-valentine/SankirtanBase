﻿using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SankirtanBase.Domain
{
    public class BookCreditOperation : XPObject
    {
        public BookCreditOperation(Session session) : base(session) { }
        private int _value;

        public int Value
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

        private Contractor _contractor;

        [Association("Contractor-BookCreditOperations")]
        public Contractor Contractor
        {
            get { return _contractor; }
            set { SetPropertyValue(nameof(Contractor), ref _contractor, value); }
        }

        private Book _book;

        [Association("Book-BookCreditOperations")]
        public Book Book
        {
            get { return _book; }
            set { SetPropertyValue(nameof(Book), ref _book, value); }
        }

        [Association("BookCreditOperation-BookMovementTransactions")]
        public XPCollection<BookMovementTransaction> BookMovementTransactions
        {
            get { return GetCollection<BookMovementTransaction>(); }
        }
    }
}