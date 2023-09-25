

using Microsoft.Data.Sqlite;
using System.Reflection;
using System.Text;
using QueryBuilder.Models;





/*Questions:
 * Exception being thrown fix?
 * how to create new objects of Pokemon and BannedGame without constructor? 
 * Do I have to have no constructor due to the special properties of Read and ReadAll?
 */
namespace QueryBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dbPath = "../../../Data/data.db";
           QueryBuilder query = new QueryBuilder(dbPath);
            int num = 0;
            Pokemon p = query.Read<Pokemon>(num);
            Console.WriteLine(p.ToString);


            #region B.
            

            List<Pokemon> listP = query.ReadAll<Pokemon>();
            for(int i = 0; i <  listP.Count; i++)
            {

                query.Create(listP[i]);

            }
            List<BannedGame> listB = query.ReadAll<BannedGame>();
            for (int i = 0; i < listB.Count; i++)
            {

                query.Create(listB[i]);

            }


            #endregion

            #region C. 

            query.Create(listB[2]);
            query.Create(listP[1]);

            #endregion

        }

    }
}