using Microsoft.Data.SqlClient;
using Models;
using System.Collections.Generic;

namespace Dal
{
   public class DalPeople : IDalPeople
   {
      private readonly SqlConnection _connection;

      public DalPeople(SqlConnection connection)
      {
         _connection = connection;
      }

      public bool Delete(params object[] values)
      {
         throw new System.NotImplementedException();
      }

      public People Find(params object[] values)
      {
         throw new System.NotImplementedException();
      }

      public IEnumerable<People> FindAll()
      {
         throw new System.NotImplementedException();
      }

      public People Insert(People model)
      {
         throw new System.NotImplementedException();
      }

      public bool Update(People model)
      {
         throw new System.NotImplementedException();
      }
   }
}
