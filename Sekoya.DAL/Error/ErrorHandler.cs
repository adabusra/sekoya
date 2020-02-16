using Sekoya.DAL.RepositoryLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Sekoya.DAL.Constants
{
    public class ErrorHandler:ILogger
    {
        static private ErrorHandler _instance = null;
        static public ErrorHandler Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ErrorHandler();
                }
                return _instance;
            }
        }

        public void Add(string message, object obj)
        {
            string GuidKey = Guid.NewGuid().ToString();
            string fileName = @"C:\\Documents\\" + GuidKey;

            try
            {   
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }     
                using (FileStream fs = File.Create(fileName))
                {
                    Byte[] title = new UTF8Encoding(true).GetBytes(message);
                    fs.Write(title, 0, title.Length);
                }
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }
    }
}
