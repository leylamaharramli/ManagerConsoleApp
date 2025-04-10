namespace ManagerConsoleApp.Models;

public class Manager<T> where T:BaseEntity
{
     T[] array = new T[0];
    public  void Add(T entity)
    {
        foreach(var item in array)
        {
      
            {
                Array.Resize(ref array, array.Length + 1);
                array[^1] = entity;
            }
    
           
        }
        Console.WriteLine("Object successfully added!");
    }

    public  T[] Remove(int id)
    {
        T[] arr = new T[array.Length - 1];
        int index = 0;
        foreach (var item in array)
        {
            if (item.ID == id)
            {
                continue;
            }
            if (index < arr.Length)
            {
                arr[index++] = item;
            }
        }
        Console.WriteLine("Object removed from list!");
        array = arr;
        return arr;
        throw new ObjectNotFoundException();
    }

    public  void Update(T entity)
    {
        T? existEntity = null;

        foreach(var item in array)
        {
            if (item.ID == entity.ID)
            {
                existEntity = item;
                break;
            }
        }

        if (existEntity is null)
         throw new ObjectNotFoundException();

            existEntity = entity;
    }
    
    public  void GetByID(int id)
    {
        foreach(var item in array)
        {
            if (item.ID == id)
                Console.WriteLine(item.ToString());
           
        }
    }

    public  void GetAll()
    {
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
            
    }
}
