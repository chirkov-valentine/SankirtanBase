using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SankirtanBase.Domain
{
    public class BookType : XPObject
    {
        public BookType(Session session) : base(session) 
        {
        }
        private string _name;

        public string Name
        {
            get { return _name; }
            set { SetPropertyValue(nameof(Name), ref _name, value); }
        }

        private float _points;

        public float Points
        {
            get { return _points; }
            set { SetPropertyValue(nameof(Points), ref _points, value); }
        }

        private string _description;

        public string Descrition
        {
            get { return _description; }
            set { SetPropertyValue(nameof(Descrition), ref _description, value); }
        }
        
        [Association("BookType-Books")]
        public XPCollection<Book> Books
        {
            get { return GetCollection<Book>(); }
        }
    }
}
