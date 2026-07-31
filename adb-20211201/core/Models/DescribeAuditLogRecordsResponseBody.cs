// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeAuditLogRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;The ID of the Enterprise Edition, Basic Edition, or Data Lakehouse Edition cluster.
        /// &lt;props=&quot;intl&quot;&gt;The ID of the Data Lakehouse Edition cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-t4nj8619bz2w3****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>A list of audit log records.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeAuditLogRecordsResponseBodyItems> Items { get; set; }
        public class DescribeAuditLogRecordsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The connection ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>14356****</para>
            /// </summary>
            [NameInMap("ConnId")]
            [Validation(Required=false)]
            public string ConnId { get; set; }

            /// <summary>
            /// <para>The name of the database on which the SQL statement ran.</para>
            /// 
            /// <b>Example:</b>
            /// <para>adb_demo</para>
            /// </summary>
            [NameInMap("DBName")]
            [Validation(Required=false)]
            public string DBName { get; set; }

            /// <summary>
            /// <para>The execution start time of the SQL statement. The time is in the <c>yyyy-MM-dd HH:mm:ss</c> format and in the local time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-12 10:10:00</para>
            /// </summary>
            [NameInMap("ExecuteTime")]
            [Validation(Required=false)]
            public string ExecuteTime { get; set; }

            /// <summary>
            /// <para>The execution start time of the SQL statement, as a millisecond timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1774600396584</para>
            /// </summary>
            [NameInMap("ExecuteTimestamp")]
            [Validation(Required=false)]
            public long? ExecuteTimestamp { get; set; }

            /// <summary>
            /// <para>Specifies whether the response contains diagnostic information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("HasDiagnosticInfo")]
            [Validation(Required=false)]
            public bool? HasDiagnosticInfo { get; set; }

            /// <summary>
            /// <para>The IP address and port of the client that ran the SQL statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100.104.XX.XX:43908</para>
            /// </summary>
            [NameInMap("HostAddress")]
            [Validation(Required=false)]
            public string HostAddress { get; set; }

            /// <summary>
            /// <para>The process ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>202106081752021720161662490345362390</para>
            /// </summary>
            [NameInMap("ProcessID")]
            [Validation(Required=false)]
            public string ProcessID { get; set; }

            /// <summary>
            /// <para>The SQL statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SELECT * FROM adb_hdfs_import_source</para>
            /// </summary>
            [NameInMap("SQLText")]
            [Validation(Required=false)]
            public string SQLText { get; set; }

            /// <summary>
            /// <para>The SQL type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SELECT</para>
            /// </summary>
            [NameInMap("SQLType")]
            [Validation(Required=false)]
            public string SQLType { get; set; }

            /// <summary>
            /// <para>Indicates whether the SQL statement succeeded. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The SQL statement succeeded.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The SQL statement failed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Succeed")]
            [Validation(Required=false)]
            public string Succeed { get; set; }

            /// <summary>
            /// <para>The execution duration of the SQL statement in milliseconds (ms).</para>
            /// 
            /// <b>Example:</b>
            /// <para>216</para>
            /// </summary>
            [NameInMap("TotalTime")]
            [Validation(Required=false)]
            public string TotalTime { get; set; }

            /// <summary>
            /// <para>The username of the account that ran the SQL statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8A564B7F-8C00-43C0-8EC5-919FBB70573</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6974</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
