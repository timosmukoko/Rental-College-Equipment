using System;
using System.Collections.Generic;

namespace LIT
{
    [Serializable]
    public abstract class Person
    {
        public string ID { get; set; }
        public string Name { get; set; }

        public Person(string id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        public virtual string Details(string ui)
        {
            return ui + "ID: " + ID + " Name: " + Name;
        }
    }

    [Serializable]
    public class Staff : Person
    {
        public string Password { get; set; }

        public Staff(string id, string name, string password) : base(id, name)
        {
            this.Password = password;
        }

        public override string Details(string ui)
        {
            return base.Details(ui) + " Password: ******";
        }

        public string[] getDetails()
        {
            string[] details = { ID, Name, Name + "@lit.ie" };
            return details;
        }
    }

    [Serializable]
    public class Student : Person
    {
        public string Course { get; set; }
        public List<Transaction> Transactions { get; set; }

        public Student(string id, string name, string course) : base(id, name)
        {
            this.Course = course;
            Transactions = new List<Transaction>();
        }

        public List<Transaction> getTransaction()
        {
            return Transactions;
        }

        public void addTransaction(Transaction nTransaction)
        {
            Transactions.Add(nTransaction);
        }

        public void removeTransaction(Transaction nTransaction)
        {
            Transactions.Remove(nTransaction);
        }

        public override string Details(string ui)
        {
            string details = base.Details(ui) + " Course: " + Course + "\n";
            if (Transactions.Count != 0)
                details += "\t\t~~Transactions~~\n" + getTransDetails();
            return details;
        }

        public string getTransDetails()
        {
            string details = "";
            foreach (Transaction x in Transactions)
            {
                details += x.Details();
            }

            return details;
        }

        public string[] getDetails()
        {
            string[] details = { ID, Name, Course };
            return details;
        }
    }
}
