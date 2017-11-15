using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WeDoCurrency.Dal
{
    public static class LogWriter
    {
        public static void Write(string logString)
        {

            using (StreamWriter writer = new StreamWriter("Test.txt", true))
            writer.WriteLine(logString);
        }
    }
}
