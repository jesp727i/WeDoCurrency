using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using WeDoCurrency.Dal;

namespace WeDoCurrency.Model
{
    public static class logger
    {
        public static void generateEventLog(Currency currency)
        {
            string logString = "";
            DateTime logDate = DateTime.Now;
            logString = "Update Date: " + logDate.ToString("dd-MM-yyyy hh:mm");

            PropertyInfo[] properties = typeof(Rates).GetProperties();
            foreach (PropertyInfo property in properties)
            {
                logString += " (" + property.Name;
                logString += ": " +property.GetValue(currency.rates).ToString() +")";
                
            }
            LogWriter.Write(logString);
            
        }

    }
}
