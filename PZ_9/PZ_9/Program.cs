namespace PZ_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dva origin = new Dva();

            origin.OdinDouble(2.75);
            origin.OdinInt(350);
            origin.OdinChar('G');

            Console.WriteLine("******");

            Odin client = new Odin();
            client.ClientDb(2.75);
            client.ClientInt(350);
            client.ClientChr('G');
        }
    }
}