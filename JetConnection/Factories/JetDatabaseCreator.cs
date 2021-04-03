using JetConnection.Constants;
using JetConnection.Interfaces;
using JetConnection.Schemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace JetConnection.Factories
{
    public abstract class JetDatabaseCreator : IJetDatabaseCreator
    {
        public static JetDatabaseCreator CreateInstance(SchemaProviderType schemaProviderType)
            => schemaProviderType switch
            {
                SchemaProviderType.Precise => new PreciseDatabaseCreator(),
                SchemaProviderType.Dao => new DaoDatabaseCreator(),
                SchemaProviderType.Adox => new AdoxDatabaseCreator(),
                _ => throw new ArgumentOutOfRangeException(nameof(schemaProviderType))
            };

        public abstract void CreateDatabase(string fileNameOrConnectionString, DatabaseVersion version = DatabaseVersion.NewestSupported, CollatingOrder collatingOrder = CollatingOrder.General, string databasePassword = null);
    }
}