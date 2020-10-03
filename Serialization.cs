using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;
using SampleConApp;

namespace NewConApp
    {
        [Serializable]
        public class Student
        {
            public string Name { get; set; }
            public string Address { get; set; }
            public long Phone { get; set; }

            public override string ToString()
            {
                return string.Format($"The name: {Name} from {Address} is available at {Phone}");
            }
        }
        class Serialization
        {
            static void Main(string[] args)
            {
                binaryFile();
                 Console.ReadKey();
            }

            private static void binaryFile()
            {
                Console.WriteLine("Do you want to read or write:");
                string choice = Console.ReadLine();
                if (choice.ToLower() == "read")
                    deserializing();
                else
                    serializing();
            }

            private static void deserializing()
            {
                FileStream fs = new FileStream("Binary.bin", FileMode.Open, FileAccess.Read);
                BinaryFormatter fm = new BinaryFormatter();
                Student stud = fm.Deserialize(fs) as Student;
                Console.WriteLine($"Student name is {stud.Name} from {stud.Address} contact details {stud.Phone}");
                fs.Close();
            }

        private static void serializing()
        {

            Student stud = new Student();
            stud.Name = MyConsole.getString("Enter the name");
            stud.Address = MyConsole.getString("Enter the address");
            stud.Phone = MyConsole.getNumber("Enter the  Phone no");
            BinaryFormatter fm = new BinaryFormatter();
            FileStream fs = new FileStream("Binary.bin", FileMode.OpenOrCreate, FileAccess.Write);
            fm.Serialize(fs, stud);
            fs.Close();
        }       

            
        }
    }



