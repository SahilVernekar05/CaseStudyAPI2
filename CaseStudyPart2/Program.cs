using CaseStudyPart2;
using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string connectionString = @"Server = 192.168.0.13\\sqlexpress,49753; Database = IVP_O_S_CS; User Id = sa;Password = sa@12345678; TrustServerCertificate = True"; // Update with your actual connection string
        string PricesFilePath = @"C:\\Users\\snvernekar\\Downloads\\Prices.csv"; // Update with the actual file path

        string holidaysFilePath = @"C:\\Users\\snvernekar\\Downloads\\Holidays2021.txt";
        string ConstituentsFilePath = @"C:\Users\snvernekar\Downloads\S_P500constituents.csv";

        var adapter = new FileAdapter(connectionString);
        //adapter.InsertPrices(PricesFilePath);
        //adapter.InsertHoliday(holidaysFilePath);
        adapter.LoadHolidaysToDatabase(connectionString, holidaysFilePath);
        //adapter.InsertConstituencies(ConstituentsFilePath);
    }
}
