namespace BookingSystem.Infra.Persistence.Exceptions;

public class NoConnectionStringException : Exception
{
    public NoConnectionStringException() : base("No connection was provided")
    {
        
    }
}