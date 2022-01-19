// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeAllDataSourceResponseBody : TeaModel {
        [NameInMap("Columns")]
        [Validation(Required=false)]
        public DescribeAllDataSourceResponseBodyColumns Columns { get; set; }
        public class DescribeAllDataSourceResponseBodyColumns : TeaModel {
            [NameInMap("Column")]
            [Validation(Required=false)]
            public List<DescribeAllDataSourceResponseBodyColumnsColumn> Column { get; set; }
            public class DescribeAllDataSourceResponseBodyColumnsColumn : TeaModel {
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
        public DescribeAllDataSourceResponseBodySchemas Schemas { get; set; }
        public class DescribeAllDataSourceResponseBodySchemas : TeaModel {
            [NameInMap("Schema")]
            [Validation(Required=false)]
            public List<DescribeAllDataSourceResponseBodySchemasSchema> Schema { get; set; }
            public class DescribeAllDataSourceResponseBodySchemasSchema : TeaModel {
                public string DBClusterId { get; set; }
                public string SchemaName { get; set; }
            }
        };

        [NameInMap("Tables")]
        [Validation(Required=false)]
        public DescribeAllDataSourceResponseBodyTables Tables { get; set; }
        public class DescribeAllDataSourceResponseBodyTables : TeaModel {
            [NameInMap("Table")]
            [Validation(Required=false)]
            public List<DescribeAllDataSourceResponseBodyTablesTable> Table { get; set; }
            public class DescribeAllDataSourceResponseBodyTablesTable : TeaModel {
                public string DBClusterId { get; set; }
                public string SchemaName { get; set; }
                public string TableName { get; set; }
            }
        };

    }

}
