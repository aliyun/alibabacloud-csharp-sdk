// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeColumnsResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried columns.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeColumnsResponseBodyItems Items { get; set; }
        public class DescribeColumnsResponseBodyItems : TeaModel {
            [NameInMap("Column")]
            [Validation(Required=false)]
            public List<DescribeColumnsResponseBodyItemsColumn> Column { get; set; }
            public class DescribeColumnsResponseBodyItemsColumn : TeaModel {
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
                /// <para>amv-bp111m2cfrdl1****</para>
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
                /// <para>The name of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>adb_demo</para>
                /// </summary>
                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                /// <summary>
                /// <para>The name of the table.</para>
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
        /// <para>1AD222E9-E606-4A42-BF6D-XXX442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
