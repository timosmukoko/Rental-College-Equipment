using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIT
{
    [Serializable]
    public class Transaction
    {
        public string id { get; set; }
        public DateTime issuedDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public List<Equipment> Items { get; set; }
        public bool closed { get; set; }
        public Transaction() { }

        public Transaction(string id, DateTime issuedDate, DateTime ReturnDate)
        {
            this.id = id;
            this.issuedDate = issuedDate;
            this.ReturnDate = ReturnDate;
            Items = new List<Equipment>();
            closed = false;
        }

        public void addItem(Equipment x)
        {
            Items.Add(x);
        }

        public void removeItem(Equipment x)
        {
            Items.Remove(x);
        }

        public string[] Details()
        {
            string[] details = { id, issuedDate.ToString(), ReturnDate.ToString(), getItemDetails() };
            return details;
        }

        public string getItemDetails()
        {
            string details = "";
            foreach (Equipment x in Items)
                details += " " + x.id + " " + x.name;

            return details;
        }
    }
}
