using Newtonsoft.Json;

namespace ManagerConsoleApp.Models;

public class Manager<T> where T:BaseEntity
{
     List<T> list = [];
     string _path = "";

    public Manager(string filename)
    {
        string currentDirectory = Directory.GetCurrentDirectory();
        _path = Path.Combine(currentDirectory, "..", "..", "..", "Jsons", filename);

        if (!File.Exists(_path)) 
        {
            File.Create(_path);
        }
    }
    public  void Add(T entity)
    {
        item = ReadFromJson();
        item.Add(entity);
        Console.WriteLine("Object successfully added!");
    }

    public List<T> Remove(int id)
    {
        
        foreach (var item in list)
        {
            if (item.ID == id)
            {
                list.Remove(item);
                return list;
            }
        }
        throw new ObjectNotFoundException();
    }

    public  void Update(T entity)
    {
        T? existEntity =  list.Find(x => x.ID == entity.ID);

        if (existEntity is null)
         throw new ObjectNotFoundException();

            existEntity = entity;
    }
    
    public  void GetByID(int id)
    {
        foreach(var item in list)
        {
            bool productFound = true;
            if (item.ID == id)
                Console.WriteLine(item.ToString());

            if (!productFound)
                throw new ObjectNotFoundException();
        }
    }

    public  void GetAll()
    {
        Items = ReadFromJson();
        foreach (var item in Items)
        {
            Console.WriteLine(item.ToString());
        }
            
    }

    private void WriteToJson(List<T> items)
    {
        var json = JsonConvert.SerializeObject(items);
        using StreamWriter sw = new(_path);
        sw.Write(json);
    }

    private List<T> ReadFromJson()
    {
        using StreamReader sr = new(_path);
        var json = sr.ReadToEnd();
        var data = JsonConvert.DeserializeObject<List<T>> (json) ?? new();
        return data;
    }
    
}
