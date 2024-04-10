using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitBody.Models
{
    public static class Constants
    {
        

        public const string DatabaseFile = "Database\\FitBodyDB.db";

        public static string DbPath =>
         Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
         @"..\..\..\..\..\", DatabaseFile);

    }
}
