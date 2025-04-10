namespace ManagerConsoleApp.Models;

public class EntityIsAlreadyExistException : Exception
{
    public EntityIsAlreadyExistException() : base("Entity is already include!")
    {

    }
}

public class ObjectNotFoundException : Exception
{
    public ObjectNotFoundException() : base("Object not found!")
    {

    }
}
