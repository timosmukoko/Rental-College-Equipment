using System;

namespace LIT
{
    public enum Status
    {
        Available, Issued, Reserved, Returned, Overdue
    }

    [Serializable]
    public class Equipment
    {
        public string id { get; set; }
        public string name { get; set; }
        public Status stat { get; set; }
        public int maxbooking { get; set; }
        //Linked Transaction.
        public Student linkedStudent { get; set; }
        public string ImageLocation { get; set; }

        public Equipment() { }

        public Equipment(string id, string name, Status stat, int maxbooking)
        {
            this.id = id;
            this.name = name;
            this.stat = stat;
            this.maxbooking = maxbooking;
            linkedStudent = null;
            ImageLocation = null;
        }

        public string[] Details()
        {
            string[] details = { id, name, stat.ToString(), maxbooking.ToString()};
            return details;
            //return "\t\tID: " + id + " Name: " + name + " Status: " + stat.ToString() + " Max Booking:" + maxbooking + "\n";
        }

        public string[] ViewsDetails()
        {
            string[] d_views = { id, name, maxbooking.ToString() };
            return d_views;
        }
    }
}
