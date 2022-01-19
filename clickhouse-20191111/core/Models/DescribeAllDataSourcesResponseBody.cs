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
                public bool? AutoIncrementColumn { get; set; }
                public string ColumnName { get; set; }
                public string DBClusterId { get; set; }
                public bool? PrimaryKey { get; set; }
                public string SchemaName { get; set; }
                public string TableName { get; set; }
                public string Type { get; set; }
            }
        };

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
                public string DBClusterId { get; set; }
                public string SchemaName { get; set; }
            }
        };

        [NameInMap("Tables")]
        [Validation(Required=false)]
        public DescribeAllDataSourcesResponseBodyTables Tables { get; set; }
        public class DescribeAllDataSourcesResponseBodyTables : TeaModel {
            [NameInMap("Table")]
            [Validation(Required=false)]
            public List<DescribeAllDataSourcesResponseBodyTablesTable> Table { get; set; }
            public class DescribeAllDataSourcesResponseBodyTablesTable : TeaModel {
                public string DBClusterId { get; set; }
                public string SchemaName { get; set; }
                public string TableName { get; set; }
            }
        };

    }

}
