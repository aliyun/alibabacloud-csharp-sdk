// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeSparkSQLDiagnosisListResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A91C9D07-7462-5F35-BB47-83629CE6CCAC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The SQL diagnostics information collection.</para>
        /// </summary>
        [NameInMap("SQLDiagnosisList")]
        [Validation(Required=false)]
        public List<DescribeSparkSQLDiagnosisListResponseBodySQLDiagnosisList> SQLDiagnosisList { get; set; }
        public class DescribeSparkSQLDiagnosisListResponseBodySQLDiagnosisList : TeaModel {
            /// <summary>
            /// <para>The application ID.</para>
            /// <remarks>
            /// <para>You can call the <a href="https://help.aliyun.com/document_detail/612475.html">ListSparkApps</a> operation to query the ID of the Spark application.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>s202404291020bjd448ad40002122</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The actual running time. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ElapsedTime")]
            [Validation(Required=false)]
            public long? ElapsedTime { get; set; }

            /// <summary>
            /// <para>The internal query execution ID within the Spark application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InnerQueryId")]
            [Validation(Required=false)]
            public long? InnerQueryId { get; set; }

            /// <summary>
            /// <para>The maximum operator execution time. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("MaxExclusiveTime")]
            [Validation(Required=false)]
            public long? MaxExclusiveTime { get; set; }

            /// <summary>
            /// <para>The maximum operator memory consumption. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("PeakMemory")]
            [Validation(Required=false)]
            public long? PeakMemory { get; set; }

            /// <summary>
            /// <para>The SQL statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>select * from device where name = \&quot;105506012112790031\&quot;</para>
            /// </summary>
            [NameInMap("SQL")]
            [Validation(Required=false)]
            public string SQL { get; set; }

            /// <summary>
            /// <para>The number of scanned rows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ScanRowCount")]
            [Validation(Required=false)]
            public long? ScanRowCount { get; set; }

            /// <summary>
            /// <para>The start time of the query. Format: <i>yyyy-MM-ddTHH:mmZ</i> (UTC time).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-11-20 09:09:00</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The final execution state of the query. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>COMPLETED: The query is completed.</description></item>
            /// <item><description>CANCELED: The query is canceled.</description></item>
            /// <item><description>ABORTED: The query is aborted.</description></item>
            /// <item><description>FAILED: The query failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETED</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The unique ID of the code block in the Spark job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("StatementId")]
            [Validation(Required=false)]
            public long? StatementId { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1343</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
