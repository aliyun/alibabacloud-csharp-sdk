// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeAllDataSourcesResponseBody : TeaModel {
        [NameInMap("Columns")]
        [Validation(Required=false)]
        public DescribeAllDataSourcesResponseBodyColumns Columns { get; set; }
        public class DescribeAllDataSourcesResponseBodyColumns : TeaModel {
            [NameInMap("Column")]
            [Validation(Required=false)]
            public List<DescribeAllDataSourcesResponseBodyColumnsColumn> Column { get; set; }
            public class DescribeAllDataSourcesResponseBodyColumnsColumn : TeaModel {
                [NameInMap("AutoIncrementColumn")]
                [Validation(Required=false)]
                public bool? AutoIncrementColumn { get; set; }

                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                [NameInMap("DBClusterId")]
                [Validation(Required=false)]
                public string DBClusterId { get; set; }

                [NameInMap("PrimaryKey")]
                [Validation(Required=false)]
                public bool? PrimaryKey { get; set; }

                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Schemas")]
        [Validation(Required=false)]
        public DescribeAllDataSourcesResponseBodySchemas Schemas { get; set; }
        public class DescribeAllDataSourcesResponseBodySchemas : TeaModel {
            [NameInMap("Schema")]
            [Validation(Required=false)]
            public List<DescribeAllDataSourcesResponseBodySchemasSchema> Schema { get; set; }
            public class DescribeAllDataSourcesResponseBodySchemasSchema : TeaModel {
                [NameInMap("DBClusterId")]
                [Validation(Required=false)]
                public string DBClusterId { get; set; }

                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

            }

        }

        [NameInMap("Tables")]
        [Validation(Required=false)]
        public DescribeAllDataSourcesResponseBodyTables Tables { get; set; }
        public class DescribeAllDataSourcesResponseBodyTables : TeaModel {
            [NameInMap("Table")]
            [Validation(Required=false)]
            public List<DescribeAllDataSourcesResponseBodyTablesTable> Table { get; set; }
            public class DescribeAllDataSourcesResponseBodyTablesTable : TeaModel {
                [NameInMap("DBClusterId")]
                [Validation(Required=false)]
                public string DBClusterId { get; set; }

                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

        }

    }

}
