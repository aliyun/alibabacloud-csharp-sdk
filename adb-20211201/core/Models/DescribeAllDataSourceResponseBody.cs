// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeAllDataSourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried columns.</para>
        /// </summary>
        [NameInMap("Columns")]
        [Validation(Required=false)]
        public DescribeAllDataSourceResponseBodyColumns Columns { get; set; }
        public class DescribeAllDataSourceResponseBodyColumns : TeaModel {
            [NameInMap("Column")]
            [Validation(Required=false)]
            public List<DescribeAllDataSourceResponseBodyColumnsColumn> Column { get; set; }
            public class DescribeAllDataSourceResponseBodyColumnsColumn : TeaModel {
                /// <summary>
                /// <para>Indicates whether the column is an auto-increment column. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AutoIncrementColumn")]
                [Validation(Required=false)]
                public bool? AutoIncrementColumn { get; set; }

                /// <summary>
                /// <para>The name of the column.</para>
                /// 
                /// <b>Example:</b>
                /// <para>id</para>
                /// </summary>
                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                /// <summary>
                /// <para>The ID of the AnalyticDB for MySQL Data Lakehouse Edition cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>amv-bp1pke2pcfavw****</para>
                /// </summary>
                [NameInMap("DBClusterId")]
                [Validation(Required=false)]
                public string DBClusterId { get; set; }

                /// <summary>
                /// <para>Indicates whether the column is the primary key of the table. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("PrimaryKey")]
                [Validation(Required=false)]
                public bool? PrimaryKey { get; set; }

                /// <summary>
                /// <para>The logical name of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>adb_demo</para>
                /// </summary>
                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                /// <summary>
                /// <para>The logical name of the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// <para>The data type of the column.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bigint</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C7EDB8E4-9769-4233-88C7-DCA4C9******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The queried databases.</para>
        /// </summary>
        [NameInMap("Schemas")]
        [Validation(Required=false)]
        public DescribeAllDataSourceResponseBodySchemas Schemas { get; set; }
        public class DescribeAllDataSourceResponseBodySchemas : TeaModel {
            [NameInMap("Schema")]
            [Validation(Required=false)]
            public List<DescribeAllDataSourceResponseBodySchemasSchema> Schema { get; set; }
            public class DescribeAllDataSourceResponseBodySchemasSchema : TeaModel {
                /// <summary>
                /// <para>The ID of the AnalyticDB for MySQL Data Lakehouse Edition cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>amv-bp1pke2pcfavw****</para>
                /// </summary>
                [NameInMap("DBClusterId")]
                [Validation(Required=false)]
                public string DBClusterId { get; set; }

                /// <summary>
                /// <para>The logical name of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>adb_demo</para>
                /// </summary>
                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

            }

        }

        /// <summary>
        /// <para>The queried tables.</para>
        /// </summary>
        [NameInMap("Tables")]
        [Validation(Required=false)]
        public DescribeAllDataSourceResponseBodyTables Tables { get; set; }
        public class DescribeAllDataSourceResponseBodyTables : TeaModel {
            [NameInMap("Table")]
            [Validation(Required=false)]
            public List<DescribeAllDataSourceResponseBodyTablesTable> Table { get; set; }
            public class DescribeAllDataSourceResponseBodyTablesTable : TeaModel {
                /// <summary>
                /// <para>The ID of the AnalyticDB for MySQL Data Lakehouse Edition cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>amv-bp1pke2pcfavw****</para>
                /// </summary>
                [NameInMap("DBClusterId")]
                [Validation(Required=false)]
                public string DBClusterId { get; set; }

                /// <summary>
                /// <para>The name of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>adb_demo</para>
                /// </summary>
                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                /// <summary>
                /// <para>The logical name of the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

        }

    }

}
