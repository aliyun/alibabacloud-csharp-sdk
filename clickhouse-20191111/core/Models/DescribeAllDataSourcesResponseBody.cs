// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeAllDataSourcesResponseBody : TeaModel {
        /// <summary>
        /// Details of the columns.
        /// </summary>
        [NameInMap("Columns")]
        [Validation(Required=false)]
        public DescribeAllDataSourcesResponseBodyColumns Columns { get; set; }
        public class DescribeAllDataSourcesResponseBodyColumns : TeaModel {
            [NameInMap("Column")]
            [Validation(Required=false)]
            public List<DescribeAllDataSourcesResponseBodyColumnsColumn> Column { get; set; }
            public class DescribeAllDataSourcesResponseBodyColumnsColumn : TeaModel {
                /// <summary>
                /// Indicates whether the column is an auto-increment column. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("AutoIncrementColumn")]
                [Validation(Required=false)]
                public bool? AutoIncrementColumn { get; set; }

                /// <summary>
                /// The column name.
                /// </summary>
                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                /// <summary>
                /// The cluster ID.
                /// </summary>
                [NameInMap("DBClusterId")]
                [Validation(Required=false)]
                public string DBClusterId { get; set; }

                /// <summary>
                /// Indicates whether the column is the primary key of the table. Valid values:
                /// 
                /// *   **true**: The column is the primary key of the table.
                /// *   **false**: The column is not the primary key of the table.
                /// </summary>
                [NameInMap("PrimaryKey")]
                [Validation(Required=false)]
                public bool? PrimaryKey { get; set; }

                /// <summary>
                /// The database name.
                /// </summary>
                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                /// <summary>
                /// The table name.
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// The column type.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the databases.
        /// </summary>
        [NameInMap("Schemas")]
        [Validation(Required=false)]
        public DescribeAllDataSourcesResponseBodySchemas Schemas { get; set; }
        public class DescribeAllDataSourcesResponseBodySchemas : TeaModel {
            [NameInMap("Schema")]
            [Validation(Required=false)]
            public List<DescribeAllDataSourcesResponseBodySchemasSchema> Schema { get; set; }
            public class DescribeAllDataSourcesResponseBodySchemasSchema : TeaModel {
                /// <summary>
                /// The cluster ID.
                /// </summary>
                [NameInMap("DBClusterId")]
                [Validation(Required=false)]
                public string DBClusterId { get; set; }

                /// <summary>
                /// The database name.
                /// </summary>
                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

            }

        }

        /// <summary>
        /// The information about the tables.
        /// </summary>
        [NameInMap("Tables")]
        [Validation(Required=false)]
        public DescribeAllDataSourcesResponseBodyTables Tables { get; set; }
        public class DescribeAllDataSourcesResponseBodyTables : TeaModel {
            [NameInMap("Table")]
            [Validation(Required=false)]
            public List<DescribeAllDataSourcesResponseBodyTablesTable> Table { get; set; }
            public class DescribeAllDataSourcesResponseBodyTablesTable : TeaModel {
                /// <summary>
                /// The cluster ID.
                /// </summary>
                [NameInMap("DBClusterId")]
                [Validation(Required=false)]
                public string DBClusterId { get; set; }

                /// <summary>
                /// The database name.
                /// </summary>
                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                /// <summary>
                /// The table name.
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

        }

    }

}
