namespace Models.Base
{
   public abstract class KeyBase<T> : IKeyBase<T>
   {
      public virtual T Id { get; set; }
   }
}
