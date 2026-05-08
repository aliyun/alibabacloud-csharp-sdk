// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
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

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
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
        public DescribeAllDataSourceResponseBodyTables Tables { get; set; }
        public class DescribeAllDataSourceResponseBodyTables : TeaModel {
            [NameInMap("Table")]
            [Validation(Required=false)]
            public List<DescribeAllDataSourceResponseBodyTablesTable> Table { get; set; }
            public class DescribeAllDataSourceResponseBodyTablesTable : TeaModel {
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
