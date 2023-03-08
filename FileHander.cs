using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ContactBook_WPF
{
    internal class FileHander
    {
        public Dictionary<string, Contact> readFile(string filePatch)
        {

            Dictionary<string, Contact> phoneBook = new Dictionary<string, Contact>();

            if (!File.Exists(filePatch))
            {
                return phoneBook;
            }
            var fileReader = new StreamReader(filePatch);

            while (!fileReader.EndOfStream)
            {
                Contact newPerson = new Contact(String.Empty, String.Empty, String.Empty,String.Empty,String.Empty);
                var header = fileReader.ReadLine();
                var lines = header.Split(",");
                newPerson.contactNumber = lines[0];
                newPerson.firstName = lines[1];
                newPerson.lastName = lines[2];
                newPerson.emailAddress = lines[3];
                newPerson.homeAddress= lines[4];
                phoneBook.Add(newPerson.contactNumber, newPerson);

            }
            fileReader.Close();
            return phoneBook;
        }

        public void saveToFile(string filePatch, Dictionary<string, Contact> phoneBook)
        {
            StreamWriter saveDictionaryToFile = new StreamWriter(filePatch, false);
            foreach (KeyValuePair<string, Contact> entry in phoneBook)
            {
                string lineToSave = ($"{ entry.Key},{entry.Value.firstName},{entry.Value.lastName}");
                {
                    saveDictionaryToFile.WriteLine(lineToSave);
                }
            }
            saveDictionaryToFile.Close();
        }
    }
}
