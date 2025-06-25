// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeAdbMySqlTableMetaResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned message. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the request was successful, a success message is returned.****</description></item>
        /// <item><description>If the request failed, an error message is returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2FED790E-FB61-4721-8C1C-07C627FA5A19</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The queried table metadata.</para>
        /// </summary>
        [NameInMap("TableMeta")]
        [Validation(Required=false)]
        public DescribeAdbMySqlTableMetaResponseBodyTableMeta TableMeta { get; set; }
        public class DescribeAdbMySqlTableMetaResponseBodyTableMeta : TeaModel {
            /// <summary>
            /// <para>The time when the table was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-03-14 02:18:08.0</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The distribution key column.</para>
            /// 
            /// <b>Example:</b>
            /// <para>customer_id</para>
            /// </summary>
            [NameInMap("DistributeColumn")]
            [Validation(Required=false)]
            public string DistributeColumn { get; set; }

            /// <summary>
            /// <para>The distribution type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hash</para>
            /// </summary>
            [NameInMap("DistributeType")]
            [Validation(Required=false)]
            public string DistributeType { get; set; }

            /// <summary>
            /// <para>Indicates whether full-column indexes are used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsAllIndex")]
            [Validation(Required=false)]
            public bool? IsAllIndex { get; set; }

            /// <summary>
            /// <para>Indicates whether dictionary encoding is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDictEncode")]
            [Validation(Required=false)]
            public bool? IsDictEncode { get; set; }

            /// <summary>
            /// <para>Indicates whether full-text indexes are used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsFullTextDict")]
            [Validation(Required=false)]
            public bool? IsFullTextDict { get; set; }

            /// <summary>
            /// <para>Indicates whether pages are hidden.</para>
            /// <list type="bullet">
            /// <item><description><b>false</b></description></item>
            /// <item><description><b>true</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsHidden")]
            [Validation(Required=false)]
            public bool? IsHidden { get; set; }

            /// <summary>
            /// <para>The partition key column.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DATE_FORMAT(login_time, \&quot;%Y%m%d\&quot;)</para>
            /// </summary>
            [NameInMap("PartitionColumn")]
            [Validation(Required=false)]
            public string PartitionColumn { get; set; }

            /// <summary>
            /// <para>The type of the partition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value</para>
            /// </summary>
            [NameInMap("PartitionType")]
            [Validation(Required=false)]
            public string PartitionType { get; set; }

            /// <summary>
            /// <para>The primary key column.</para>
            /// 
            /// <b>Example:</b>
            /// <para>login_time,customer_id,phone_num</para>
            /// </summary>
            [NameInMap("PrimaryKeyColumn")]
            [Validation(Required=false)]
            public string PrimaryKeyColumn { get; set; }

            /// <summary>
            /// <para>The table engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>XUANWU</para>
            /// </summary>
            [NameInMap("TableEngine")]
            [Validation(Required=false)]
            public string TableEngine { get; set; }

            /// <summary>
            /// <para>The name of the table.</para>
            /// <para>**</para>
            /// <hr>
            /// 
            /// <b>Example:</b>
            /// <para>external_supplier</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            /// <summary>
            /// <para>The database to which the table belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tpch</para>
            /// </summary>
            [NameInMap("TableSchema")]
            [Validation(Required=false)]
            public string TableSchema { get; set; }

            /// <summary>
            /// <para>The type of the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fact_table</para>
            /// </summary>
            [NameInMap("TableType")]
            [Validation(Required=false)]
            public string TableType { get; set; }

            /// <summary>
            /// <para>The time when the table was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-25 02:07:23.0</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

    }

}
