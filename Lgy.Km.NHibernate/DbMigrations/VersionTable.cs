using FluentMigrator.VersionTableInfo;

namespace Lgy.Km.DbMigrations
{
    [VersionTableMetaData]
    public class VersionTable : DefaultVersionTableMetaData
    {
        public override string TableName
        {
            get
            {
                return "AppVersionInfo";
            }
        }
    }
}
