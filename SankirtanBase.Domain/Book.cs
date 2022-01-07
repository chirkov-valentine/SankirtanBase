using DevExpress.Xpo;

namespace SankirtanBase.Domain
{
    public class Book : XPObject
    {
        public Book(Session session) : base(session) { }
        
        private string _name;

        public string Name
        {
            get { return _name; }
            set { SetPropertyValue(nameof(Name), ref _name, value); }
        }

        private string _shortName;

        public string ShortName
        {
            get { return _shortName; }
            set { SetPropertyValue(nameof(ShortName), ref _shortName, value); }
        }

        private string _description;

        public string Descrition
        {
            get { return _description; }
            set { SetPropertyValue(nameof(Descrition), ref _description, value); }
        }

        private BookType _bookType;

        [Association("BookType-Books")]
        public BookType BookType
        {
            get { return _bookType; }
            set { SetPropertyValue(nameof(BookType), ref _bookType, value); }
        }

        [Association("Book-Prices")]
        public XPCollection<Price> Prices
        {
            get { return GetCollection<Price>(); }
        }

        [Association("Book-BookBalances")]
        public XPCollection<BookBalance> BookBalances
        {
            get { return GetCollection<BookBalance>(); }
        }

        [Association("Book-BookCreditOperations")]
        public XPCollection<BookCreditOperation> BookCreditOperations
        {
            get { return GetCollection<BookCreditOperation>(); }
        }

        [Association("Book-BookDebetOperations")]
        public XPCollection<BookDebetOperation> BookDebetOperations
        {
            get { return GetCollection<BookDebetOperation>(); }
        }

    }
}