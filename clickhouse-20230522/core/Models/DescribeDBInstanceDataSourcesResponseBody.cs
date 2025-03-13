// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class DescribeDBInstanceDataSourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDBInstanceDataSourcesResponseBodyData Data { get; set; }
        public class DescribeDBInstanceDataSourcesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The columns.</para>
            /// </summary>
            [NameInMap("Columns")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceDataSourcesResponseBodyDataColumns> Columns { get; set; }
            public class DescribeDBInstanceDataSourcesResponseBodyDataColumns : TeaModel {
                /// <summary>
                /// <para>The column name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c31</para>
                /// </summary>
                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                /// <summary>
                /// <para>The description of the database account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Used for test</para>
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <para>The database name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dbtest</para>
                /// </summary>
                [NameInMap("DBName")]
                [Validation(Required=false)]
                public string DBName { get; set; }

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
                public string PrimaryKey { get; set; }

                /// <summary>
                /// <para>The table name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tableTest</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// <para>The type of the stored data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>UInt64</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cc-bp100p4q1g9z3****</para>
            /// </summary>
            [NameInMap("DBInstanceId")]
            [Validation(Required=false)]
            public string DBInstanceId { get; set; }

            /// <summary>
            /// <para>The account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("Schemas")]
            [Validation(Required=false)]
            public string Schemas { get; set; }

            /// <summary>
            /// <para>The tables.</para>
            /// </summary>
            [NameInMap("Tables")]
            [Validation(Required=false)]
            public List<string> Tables { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F543E6CC-6868-523D-8D28-0E92CF977ED2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
