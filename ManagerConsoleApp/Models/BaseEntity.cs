namespace ManagerConsoleApp.Models;

public abstract class BaseEntity
{
   public int ID { get; private set; }

   private static int _count = 1;

        public BaseEntity()
        {
        ID = _count++;
         
        }
    
}

