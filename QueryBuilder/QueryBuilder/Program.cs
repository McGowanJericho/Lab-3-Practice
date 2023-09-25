

using Microsoft.Data.Sqlite;
using System.Reflection;
using System.Text;
using QueryBuilder.Models;


namespace QueryBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dbPath = "../../../Data/data.db";
           QueryBuilder query = new QueryBuilder(dbPath);
            int i = 0;
            Pokemon p = query.Read<Pokemon>(i);
            Console.WriteLine(p.ToString);
        }

    }
}