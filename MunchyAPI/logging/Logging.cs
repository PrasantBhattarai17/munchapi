namespace MunchyAPI.logging
{
    public class Logging:ILogging
        //similary to use another implemenation class for the service we can use by creating new  implementation class using the same interface
        //and by using the dependency injection the new implementation is configured in the program.cs file and it can be easily used!!
    {
        public void Log( string message, string type)
        {
            if(type == "error")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR - "+message);
                Console.BackgroundColor = ConsoleColor.Black;//this is used to return the bg color of the console back to  black as if not used then it remains same for all logs!
            }
            else
            {
                Console.WriteLine(message);
            }
        }
    }
}
