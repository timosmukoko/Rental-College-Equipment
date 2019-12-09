using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

// Shane Nolan - K00205031.
namespace LIT
{
    public static class Storage
    {
        const string USER_FILENAME = "UsersDB.bin";
        const string EQUIPMENT_FILENAME = "EquipDB.bin";

        //ID, Person Object.
        public static SortedDictionary<string, Person> UsersDB = new SortedDictionary<string, Person>();

        /*Hashsets were going to be used originally but since you cant access Hashsets with [], it was decided
         *it would be better to use a list.*/

        //Equipment List.
        public static List<Equipment> EquipmentDB = new List<Equipment>();

        public static void ImportUsers()
        {
            try
            {
                ftImport();
                BinaryFormatter bf = new BinaryFormatter();
                if (File.Exists(USER_FILENAME))
                {
                    FileStream fsUsers = new FileStream(USER_FILENAME, FileMode.Open);
                    UsersDB = bf.Deserialize(fsUsers) as SortedDictionary<string, Person>;
                    fsUsers.Close();
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong when trying to Import Users :(\nPlease restart the program and try again.",
                    "LIT Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ExportUsers()
        {
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                if (File.Exists(USER_FILENAME))
                    File.Delete(USER_FILENAME);
                FileStream fsUsers = new FileStream(USER_FILENAME, FileMode.OpenOrCreate);
                bf.Serialize(fsUsers, UsersDB);
                fsUsers.Close();
            }
            catch
            {
                MessageBox.Show("Something went wrong when trying to Export Users :(\nPlease restart the program and try again.",
                    "LIT Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ImportEquipment()
        {
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                if (File.Exists(EQUIPMENT_FILENAME))
                {
                    FileStream fsEqu = new FileStream(EQUIPMENT_FILENAME, FileMode.Open);
                    EquipmentDB = bf.Deserialize(fsEqu) as List<Equipment>;
                    fsEqu.Close();
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong when trying to Import Equipment :(\nPlease restart the program and try again.",
                    "LIT Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ExportEquipment()
        {
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                if (File.Exists(EQUIPMENT_FILENAME))
                    File.Delete(EQUIPMENT_FILENAME);
                FileStream fsEqu = new FileStream(EQUIPMENT_FILENAME, FileMode.OpenOrCreate);
                bf.Serialize(fsEqu, EquipmentDB);
                fsEqu.Close();
            }
            catch
            {
                MessageBox.Show("Something went wrong when trying to Export Equipment :(\nPlease restart the program and try again.",
                    "LIT Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*First Time Import for when the program is ran for the first time and 
         * imports the default student database. */
        private static void ftImport()
        {
            try
            {
                const string OLD_FILE = "studentData.txt";
                if (File.Exists(OLD_FILE))
                {
                    DialogResult dr = MessageBox.Show("Hello there!\nIt appears its your first time " +
                        "running LIT Rental Scheme, would you like to import the previous student database file into our improved data structure?",
                        "LIT Rental - Welcome", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        StreamReader sr = new StreamReader(OLD_FILE);
                        string data;
                        while ((data = sr.ReadLine()) != null)
                        {
                            string[] content = data.Split(' ');
                            Student ns = new Student(content[0], content[1] + " " + content[2], content[3]);
                            UsersDB.Add(ns.ID, ns);
                        }
                        sr.Close();
                    }
                    //Default Staff.
                    Staff defaultStaff = new Staff("00", "Admin", "admin");
                    UsersDB.Add(defaultStaff.ID, defaultStaff);
                    File.Move(OLD_FILE, OLD_FILE + ".bak");
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong when trying to import the previous data :(\nPlease restart the program and try again.",
                    "LIT Rental - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
