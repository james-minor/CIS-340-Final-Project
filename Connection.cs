using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public static class Connection
    {
        public static string ConnectionString =>
            @"Data Source=(LocalDB)\MSSQLLocalDB;
             AttachDbFilename='|DataDirectory|\ShopEasyDatabase.mdf';Integrated Security=True";
    }
}
