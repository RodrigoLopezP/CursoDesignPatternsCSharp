using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.SingletonPattern
{
    public class Log
    {
        //Questo è l'unico Oggetto che verrà creato in tutto il programma
        //E' privato, quindi potrà essere richiamato solo qua dentro
        //Ad esempio facendo così
        /*
         */
        private readonly static Log _instance = new Log(); 
        private string _path = "log.txt";
        public static Log Instance
        {
            get
            {
                return _instance; 
            }
        }
        private Log()
        {
        }

        public void Save(string message)
        {
            File.AppendAllText(_path, message + Environment.NewLine);

        }
    }
}
