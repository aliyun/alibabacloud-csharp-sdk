// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeSQLPatternsResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the access denial. This parameter is returned only if RAM authentication fails.</para>
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
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>A list of SQL patterns.</para>
        /// </summary>
        [NameInMap("PatternDetails")]
        [Validation(Required=false)]
        public List<DescribeSQLPatternsResponseBodyPatternDetails> PatternDetails { get; set; }
        public class DescribeSQLPatternsResponseBodyPatternDetails : TeaModel {
            /// <summary>
            /// <para>The client IP address used to submit the queries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.xx.xx</para>
            /// </summary>
            [NameInMap("AccessIp")]
            [Validation(Required=false)]
            public string AccessIp { get; set; }

            /// <summary>
            /// <para>The average execution time of queries matching this pattern. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>234.78</para>
            /// </summary>
            [NameInMap("AverageExecutionTime")]
            [Validation(Required=false)]
            public double? AverageExecutionTime { get; set; }

            /// <summary>
            /// <para>The average CPU cost for queries that match this pattern. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("AverageOperatorCost")]
            [Validation(Required=false)]
            public double? AverageOperatorCost { get; set; }

            /// <summary>
            /// <para>The average peak memory usage of queries matching this pattern. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>234.22</para>
            /// </summary>
            [NameInMap("AveragePeakMemory")]
            [Validation(Required=false)]
            public double? AveragePeakMemory { get; set; }

            /// <summary>
            /// <para>The average duration of queries matching this pattern. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("AverageQueryTime")]
            [Validation(Required=false)]
            public double? AverageQueryTime { get; set; }

            /// <summary>
            /// <para>The average scan time for queries that match this pattern. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("AverageScanCost")]
            [Validation(Required=false)]
            public double? AverageScanCost { get; set; }

            /// <summary>
            /// <para>The average amount of data scanned by queries matching this pattern. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>234149.23</para>
            /// </summary>
            [NameInMap("AverageScanSize")]
            [Validation(Required=false)]
            public double? AverageScanSize { get; set; }

            /// <summary>
            /// <para>Indicates whether queries that match this pattern can be blocked. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The queries can be blocked.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The queries cannot be blocked.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>Currently, AnalyticDB for MySQL allows you to block only SELECT and INSERT statements.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Blockable")]
            [Validation(Required=false)]
            public bool? Blockable { get; set; }

            /// <summary>
            /// <para>The number of failed queries that match this pattern.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18</para>
            /// </summary>
            [NameInMap("FailedCount")]
            [Validation(Required=false)]
            public long? FailedCount { get; set; }

            /// <summary>
            /// <para>The maximum execution time of a query matching this pattern. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2142</para>
            /// </summary>
            [NameInMap("MaxExecutionTime")]
            [Validation(Required=false)]
            public long? MaxExecutionTime { get; set; }

            /// <summary>
            /// <para>The maximum CPU cost for a query that matches this pattern. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("MaxOperatorCost")]
            [Validation(Required=false)]
            public double? MaxOperatorCost { get; set; }

            /// <summary>
            /// <para>The maximum peak memory usage of a query matching this pattern. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>234149</para>
            /// </summary>
            [NameInMap("MaxPeakMemory")]
            [Validation(Required=false)]
            public long? MaxPeakMemory { get; set; }

            /// <summary>
            /// <para>The maximum duration of a query matching this pattern. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2341</para>
            /// </summary>
            [NameInMap("MaxQueryTime")]
            [Validation(Required=false)]
            public long? MaxQueryTime { get; set; }

            /// <summary>
            /// <para>The maximum scan time for a query that matches this pattern. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("MaxScanCost")]
            [Validation(Required=false)]
            public double? MaxScanCost { get; set; }

            /// <summary>
            /// <para>The maximum amount of data scanned by a query matching this pattern. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32212254</para>
            /// </summary>
            [NameInMap("MaxScanSize")]
            [Validation(Required=false)]
            public long? MaxScanSize { get; set; }

            /// <summary>
            /// <para>The total CPU cost of queries matching this pattern as a percentage of the total CPU cost for all queries. Unit: %.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("OperatorCostPercentage")]
            [Validation(Required=false)]
            public double? OperatorCostPercentage { get; set; }

            /// <summary>
            /// <para>The total CPU cost for all queries that match this pattern. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("OperatorCostSum")]
            [Validation(Required=false)]
            public double? OperatorCostSum { get; set; }

            /// <summary>
            /// <para>The submission time of the first query that matches this pattern within the specified time range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-09-06 05:06:00</para>
            /// </summary>
            [NameInMap("PatternCreationTime")]
            [Validation(Required=false)]
            public string PatternCreationTime { get; set; }

            /// <summary>
            /// <para>The ID of the SQL pattern.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5575924945138******</para>
            /// </summary>
            [NameInMap("PatternId")]
            [Validation(Required=false)]
            public string PatternId { get; set; }

            /// <summary>
            /// <para>The total peak memory usage of queries matching this pattern as a percentage of the total peak memory usage for all queries. Unit: %.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PeakMemoryPercentage")]
            [Validation(Required=false)]
            public double? PeakMemoryPercentage { get; set; }

            /// <summary>
            /// <para>The sum of the peak memory usage for all queries that match this pattern. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("PeakMemorySum")]
            [Validation(Required=false)]
            public double? PeakMemorySum { get; set; }

            /// <summary>
            /// <para>The number of executed queries that match this pattern.</para>
            /// 
            /// <b>Example:</b>
            /// <para>345</para>
            /// </summary>
            [NameInMap("QueryCount")]
            [Validation(Required=false)]
            public long? QueryCount { get; set; }

            /// <summary>
            /// <para>The total query time of queries matching this pattern as a percentage of the total query time for all queries. Unit: %.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("QueryTimePercentage")]
            [Validation(Required=false)]
            public double? QueryTimePercentage { get; set; }

            /// <summary>
            /// <para>The total query duration for all queries that match this pattern. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("QueryTimeSum")]
            [Validation(Required=false)]
            public double? QueryTimeSum { get; set; }

            /// <summary>
            /// <para>The SQL pattern.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SELECT * FROM KEPLER_META_NODE_STATIC_INFO WHERE elastic_node = ? OR (elastic_node = ? AND enable = ?)</para>
            /// </summary>
            [NameInMap("SQLPattern")]
            [Validation(Required=false)]
            public string SQLPattern { get; set; }

            /// <summary>
            /// <para>The total scan cost of queries matching this pattern as a percentage of the total scan cost for all queries. Unit: %.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ScanCostPercentage")]
            [Validation(Required=false)]
            public double? ScanCostPercentage { get; set; }

            /// <summary>
            /// <para>The total scan cost for all queries that match this pattern. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ScanCostSum")]
            [Validation(Required=false)]
            public double? ScanCostSum { get; set; }

            /// <summary>
            /// <para>The total amount of data scanned by queries matching this pattern as a percentage of the total data scanned by all queries. Unit: %.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("ScanSizePercentage")]
            [Validation(Required=false)]
            public double? ScanSizePercentage { get; set; }

            /// <summary>
            /// <para>The total amount of data scanned by all queries that match this pattern. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ScanSizeSum")]
            [Validation(Required=false)]
            public double? ScanSizeSum { get; set; }

            /// <summary>
            /// <para>The tables scanned by the SQL pattern.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tpch.orders</para>
            /// </summary>
            [NameInMap("Tables")]
            [Validation(Required=false)]
            public string Tables { get; set; }

            /// <summary>
            /// <para>The name of the database user who submitted the matching SQL statements.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F3174013-5B7A-5A47-9FE0-6B5D397BD86A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
