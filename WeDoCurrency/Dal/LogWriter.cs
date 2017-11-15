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
			//This writes to a file called Test.Txt, and creates a new file if it doesnt exist
			using (StreamWriter writer = new StreamWriter("Test.txt", true))
			{
				writer.WriteLine(logString);
			}
        }
    }
}
