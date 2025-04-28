// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeBadSqlDetectionResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the request denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;PolicyType&quot;: &quot;AccountLevelIdentityBasedPolicy&quot;,
        ///     &quot;AuthPrincipalOwnerId&quot;: &quot;1**<em><b><b><b><b><b><b><b>7&quot;,
        ///     &quot;EncodedDiagnosticMessage&quot;: &quot;AQIBIAAAAOPdwKY2QLOvgMEc7SkkoJfj1kvZwsaRqNYMh10Tv0wTe0fCzaCdrvgazfNb0EnJKETgXyhR+3BIQjx9WAqZryejBsp1Bl4qI5En/D9dEhcXAtKCxCmE2kZCiEzpy8BoEUt+bs0DmlaGWO5xkEpttypLIB4rUhDvZd+zwPg4EXk4KSSWSWsurxtqDkKEMshKlQFBTKvJcKwyhk62IeYly4hQ+5IpXjkh1GQXuDRCQ==&quot;,
        ///     &quot;AuthPrincipalType&quot;: &quot;SubUser&quot;,
        ///     &quot;AuthPrincipalDisplayName&quot;: &quot;2</b></b></b></b></b></b></b></em>9&quot;,
        ///     &quot;NoPermissionType&quot;: &quot;ImplicitDeny&quot;,
        ///     &quot;AuthAction&quot;: &quot;adb:DescribeExcessivePrimaryKeys&quot;
        /// }</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-xxx</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The queried detection items and detection results.</para>
        /// </summary>
        [NameInMap("DetectionItems")]
        [Validation(Required=false)]
        public List<DescribeBadSqlDetectionResponseBodyDetectionItems> DetectionItems { get; set; }
        public class DescribeBadSqlDetectionResponseBodyDetectionItems : TeaModel {
            /// <summary>
            /// <para>The information about the diagnostic result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Multiple bad SQL statements are detected. Perform optimization on the statements.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The name of the detection item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PeakMemory
            /// OperatorCost
            /// ScanSize</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The detection result items.</para>
            /// </summary>
            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<DescribeBadSqlDetectionResponseBodyDetectionItemsResults> Results { get; set; }
            public class DescribeBadSqlDetectionResponseBodyDetectionItemsResults : TeaModel {
                /// <summary>
                /// <para>The total execution duration. Unit: milliseconds.</para>
                /// <remarks>
                /// <para> This value is the cumulative value of the <c>QueuedTime</c>, <c>TotalPlanningTime</c>, and <c>ExecutionTime</c> parameters.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>37</para>
                /// </summary>
                [NameInMap("Cost")]
                [Validation(Required=false)]
                public long? Cost { get; set; }

                /// <summary>
                /// <para>The diagnostic result items.</para>
                /// </summary>
                [NameInMap("DiagnosisResults")]
                [Validation(Required=false)]
                public List<DescribeBadSqlDetectionResponseBodyDetectionItemsResultsDiagnosisResults> DiagnosisResults { get; set; }
                public class DescribeBadSqlDetectionResponseBodyDetectionItemsResultsDiagnosisResults : TeaModel {
                    /// <summary>
                    /// <para>The diagnostic code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>FILTER_NOT_PUSHDOWN</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <para>The information about the diagnostic result.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The query consumes a large amount of memory resources. Perform memory optimization on the query.</para>
                    /// </summary>
                    [NameInMap("Detail")]
                    [Validation(Required=false)]
                    public string Detail { get; set; }

                    /// <summary>
                    /// <para>The operator ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Join[234]</para>
                    /// </summary>
                    [NameInMap("OperatorId")]
                    [Validation(Required=false)]
                    public string OperatorId { get; set; }

                    /// <summary>
                    /// <para>The stage ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Stage[1]</para>
                    /// </summary>
                    [NameInMap("StageId")]
                    [Validation(Required=false)]
                    public string StageId { get; set; }

                }

                /// <summary>
                /// <para>The total CPU time consumed by all operators in the stage, which is equivalent to the total CPU time of the stage. You can use this parameter to determine which parts of the stage consume a large amount of computing resources. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("OperatorCost")]
                [Validation(Required=false)]
                public long? OperatorCost { get; set; }

                /// <summary>
                /// <para>The amount of returned data. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("OutputDataSize")]
                [Validation(Required=false)]
                public long? OutputDataSize { get; set; }

                /// <summary>
                /// <para>The SQL pattern ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>-5978869478527645300</para>
                /// </summary>
                [NameInMap("PatternId")]
                [Validation(Required=false)]
                public string PatternId { get; set; }

                /// <summary>
                /// <para>The peak memory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("PeakMemory")]
                [Validation(Required=false)]
                public long? PeakMemory { get; set; }

                /// <summary>
                /// <para>The query ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023120808405202104101604703151654257</para>
                /// </summary>
                [NameInMap("ProcessId")]
                [Validation(Required=false)]
                public string ProcessId { get; set; }

                /// <summary>
                /// <para>The SQL statement.</para>
                /// <remarks>
                /// <para> For performance considerations, an SQL statement cannot exceed 5,120 characters in length. Otherwise, the SQL statement is truncated. You can call the <a href="https://help.aliyun.com/document_detail/308212.html">DownloadDiagnosisRecords</a> operation to download the information about SQL statements that meet a query condition for an AnalyticDB for MySQL cluster, including the complete SQL statements.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>select * from user</para>
                /// </summary>
                [NameInMap("SQL")]
                [Validation(Required=false)]
                public string SQL { get; set; }

                /// <summary>
                /// <para>The amount of scanned data. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("ScanSize")]
                [Validation(Required=false)]
                public long? ScanSize { get; set; }

                /// <summary>
                /// <para>The start time of the query. The time follows the ISO 8601 standard in the <em>yyyy-MM-ddTHH:mmZ</em> format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-05-05T02:13Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The total number of stages generated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("TotalStages")]
                [Validation(Required=false)]
                public int? TotalStages { get; set; }

            }

            /// <summary>
            /// <para>The severity level of the detection result. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL
            /// WARNNING
            /// CRITICAL</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32C6E870-81E5-5E2A-BE7D-F9623F090DAB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
