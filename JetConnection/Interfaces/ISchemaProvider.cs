using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace JetConnection.Interfaces
{
    public interface ISchemaProvider1
    {
        DataTable GetCheckConstraints();
        DataTable GetColumns();
        DataTable GetIndexColumns();
        DataTable GetIndexes();
        DataTable GetRelationColumns();
        DataTable GetRelations();
        DataTable GetTables();
    }

    public interface ISchemaProvider
        : IDisposable
    {
        DataTable GetTables();
        DataTable GetColumns();
        DataTable GetIndexes();
        DataTable GetIndexColumns();
        DataTable GetRelations();
        DataTable GetRelationColumns();
        DataTable GetCheckConstraints();
    }

}
