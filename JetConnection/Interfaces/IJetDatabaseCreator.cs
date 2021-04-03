using JetConnection.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace JetConnection.Interfaces
{

    public interface IJetDatabaseCreator
    {
        void CreateDatabase(
            string fileNameOrConnectionString,
            DatabaseVersion version = DatabaseVersion.NewestSupported,
            CollatingOrder collatingOrder = CollatingOrder.General,
            string databasePassword = null);
    }
}