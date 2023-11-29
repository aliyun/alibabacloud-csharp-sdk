// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DataExtraInfoSubDbsValue : TeaModel {
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        [NameInMap("TenantName")]
        [Validation(Required=false)]
        public string TenantName { get; set; }

        [NameInMap("DatabaseId")]
        [Validation(Required=false)]
        public string DatabaseId { get; set; }

        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        [NameInMap("MappingDatabaseName")]
        [Validation(Required=false)]
        public string MappingDatabaseName { get; set; }

        [NameInMap("SourceClientId")]
        [Validation(Required=false)]
        public string SourceClientId { get; set; }

        [NameInMap("Tables")]
        [Validation(Required=false)]
        public List<DataExtraInfoSubDbsValueTables> Tables { get; set; }
        public class DataExtraInfoSubDbsValueTables : TeaModel {
            [NameInMap("TableId")]
            [Validation(Required=false)]
            public string TableId { get; set; }

            [NameInMap("Database")]
            [Validation(Required=false)]
            public string Database { get; set; }

            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            [NameInMap("MappingTableName")]
            [Validation(Required=false)]
            public string MappingTableName { get; set; }

            [NameInMap("Instance")]
            [Validation(Required=false)]
            public string Instance { get; set; }

            [NameInMap("Columns")]
            [Validation(Required=false)]
            public List<DataExtraInfoSubDbsValueTablesColumns> Columns { get; set; }
            public class DataExtraInfoSubDbsValueTablesColumns : TeaModel {
                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                [NameInMap("Position")]
                [Validation(Required=false)]
                public int? Position { get; set; }

                [NameInMap("ColumnType")]
                [Validation(Required=false)]
                public string ColumnType { get; set; }

                [NameInMap("RecordFieldType")]
                [Validation(Required=false)]
                public string RecordFieldType { get; set; }

                [NameInMap("RawColumnType")]
                [Validation(Required=false)]
                public string RawColumnType { get; set; }

                [NameInMap("ColumnKey")]
                [Validation(Required=false)]
                public string ColumnKey { get; set; }

                [NameInMap("Nullable")]
                [Validation(Required=false)]
                public bool? Nullable { get; set; }

                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                [NameInMap("DataLength")]
                [Validation(Required=false)]
                public long? DataLength { get; set; }

                [NameInMap("DataPrecision")]
                [Validation(Required=false)]
                public int? DataPrecision { get; set; }

                [NameInMap("DataScale")]
                [Validation(Required=false)]
                public int? DataScale { get; set; }

                [NameInMap("Encoding")]
                [Validation(Required=false)]
                public string Encoding { get; set; }

                [NameInMap("ColumnComment")]
                [Validation(Required=false)]
                public string ColumnComment { get; set; }

                [NameInMap("IsGenerateField")]
                [Validation(Required=false)]
                public bool? IsGenerateField { get; set; }

            }

        }

    }

}
