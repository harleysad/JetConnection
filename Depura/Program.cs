using System;

namespace Depura
{
    class Program
    {
        static void Main(string[] args)
        {

            JetConnection.Helpers.Helpers.CreateDatabase(@"d:\src\jet.mdb",
                JetConnection.Constants.DatabaseVersion.Newest,
                JetConnection.Constants.CollatingOrder.General);
            Console.WriteLine("Acabei");
        }
    }
}
