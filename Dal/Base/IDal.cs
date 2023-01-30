using System.Collections.Generic;
namespace Dal.Base
{
   public interface IDal<T>
   {
      T Insert(T model);
      bool Update(T model);
      T Find(params object[] values);
      IEnumerable<T> FindAll();
      bool Delete(params object[] values);
   }
}
