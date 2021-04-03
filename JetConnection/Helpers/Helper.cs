using System;
using JetConnection.Constants;

namespace JetConnection.Helpers
{
    public class JetHelper
    {
        public static void CreateDatabase(
           string storeName,
           DatabaseVersion version = DatabaseVersion.NewestSupported,
           CollatingOrder collatingOrder = CollatingOrder.General,
           string databasePassword = null)
        {
            DeleteDatabase(storeName);
            JetConnection.CreateDatabase(storeName, version, collatingOrder, databasePassword);
        }

        public static void DeleteDatabase(string storeName)
        {
            JetConnection.ClearAllPools();
            JetConnection.DropDatabase(storeName);
        }
    }
}
