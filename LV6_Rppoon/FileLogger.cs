using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV6_Rppoon
{
    class FileLogger : AbstractLogger
    {
        private string filePath;
        public FileLogger(MessageType messageType, string filePath) : base(messageType)
        {
            this.filePath = filePath;
        }
        protected override void WriteMessage(string message, MessageType type)
        {

            //StreamWriter writer = new StreamWriter(filePath);
            //writer.WriteLine(type + ": " + DateTime.Now);
            //writer.WriteLine(new string('=', message.Length));
            //writer.WriteLine(message);
            //writer.WriteLine(new string('=', message.Length) + "\n");
            //writer.Close();

            System.IO.File.WriteAllText(filePath, type + ": " + DateTime.Now + "\n" + new string('=', message.Length) + "\n" + message + "\n" + new string('=', message.Length) + "\n");

        }
    }
}
