// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeSQLPatternsResponseBody : TeaModel {
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
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The details of the SQL patterns.</para>
        /// </summary>
        [NameInMap("PatternDetails")]
        [Validation(Required=false)]
        public List<DescribeSQLPatternsResponseBodyPatternDetails> PatternDetails { get; set; }
        public class DescribeSQLPatternsResponseBodyPatternDetails : TeaModel {
            /// <summary>
            /// <para>The client IP address from which the SQL statements matching this pattern were submitted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.xx.xx</para>
            /// </summary>
            [NameInMap("AccessIp")]
            [Validation(Required=false)]
            public string AccessIp { get; set; }

            /// <summary>
            /// <para>The average execution time for statements matching this SQL pattern within the specified time range, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>234.78</para>
            /// </summary>
            [NameInMap("AverageExecutionTime")]
            [Validation(Required=false)]
            public double? AverageExecutionTime { get; set; }

            /// <summary>
            /// <para>The average CPU cost for statements matching this pattern, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("AverageOperatorCost")]
            [Validation(Required=false)]
            public double? AverageOperatorCost { get; set; }

            /// <summary>
            /// <para>The average peak memory usage for statements matching this SQL pattern within the specified time range, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>234.22</para>
            /// </summary>
            [NameInMap("AveragePeakMemory")]
            [Validation(Required=false)]
            public double? AveragePeakMemory { get; set; }

            /// <summary>
            /// <para>The average query time for statements matching this SQL pattern within the specified time range, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("AverageQueryTime")]
            [Validation(Required=false)]
            public double? AverageQueryTime { get; set; }

            /// <summary>
            /// <para>The average CPU cost of table scans for statements matching this pattern, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("AverageScanCost")]
            [Validation(Required=false)]
            public double? AverageScanCost { get; set; }

            /// <summary>
            /// <para>The average data scan size for statements matching this SQL pattern within the specified time range, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>234149.23</para>
            /// </summary>
            [NameInMap("AverageScanSize")]
            [Validation(Required=false)]
            public double? AverageScanSize { get; set; }

            /// <summary>
            /// <para>Specifies whether queries matching this pattern can be blocked. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The SQL pattern can be blocked.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The SQL pattern cannot be blocked.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>AnalyticDB for MySQL supports blocking for only <c>SELECT</c> and <c>INSERT</c> statements.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Blockable")]
            [Validation(Required=false)]
            public bool? Blockable { get; set; }

            /// <summary>
            /// <para>The number of failed executions for statements matching this pattern within the specified time range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>234</para>
            /// </summary>
            [NameInMap("FailedCount")]
            [Validation(Required=false)]
            public long? FailedCount { get; set; }

            /// <summary>
            /// <para>The maximum execution time for statements matching this SQL pattern within the specified time range, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2142</para>
            /// </summary>
            [NameInMap("MaxExecutionTime")]
            [Validation(Required=false)]
            public long? MaxExecutionTime { get; set; }

            /// <summary>
            /// <para>The maximum CPU cost for statements matching this pattern, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("MaxOperatorCost")]
            [Validation(Required=false)]
            public double? MaxOperatorCost { get; set; }

            /// <summary>
            /// <para>The maximum peak memory usage for statements matching this SQL pattern within the specified time range, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>234149</para>
            /// </summary>
            [NameInMap("MaxPeakMemory")]
            [Validation(Required=false)]
            public long? MaxPeakMemory { get; set; }

            /// <summary>
            /// <para>The maximum query time for statements matching this SQL pattern within the specified time range, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2341</para>
            /// </summary>
            [NameInMap("MaxQueryTime")]
            [Validation(Required=false)]
            public long? MaxQueryTime { get; set; }

            /// <summary>
            /// <para>The maximum CPU cost of table scans for statements matching this pattern, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("MaxScanCost")]
            [Validation(Required=false)]
            public double? MaxScanCost { get; set; }

            /// <summary>
            /// <para>The maximum data scan size for statements matching this SQL pattern within the specified time range, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>234149</para>
            /// </summary>
            [NameInMap("MaxScanSize")]
            [Validation(Required=false)]
            public long? MaxScanSize { get; set; }

            /// <summary>
            /// <para>The percentage of the total CPU cost from all patterns that the queries for this pattern consume.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("OperatorCostPercentage")]
            [Validation(Required=false)]
            public double? OperatorCostPercentage { get; set; }

            /// <summary>
            /// <para>The total CPU cost for statements matching this pattern, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("OperatorCostSum")]
            [Validation(Required=false)]
            public double? OperatorCostSum { get; set; }

            /// <summary>
            /// <para>The earliest time a query matching this pattern was submitted within the specified time range. The time is in the <c>YYYY-MM-DD HH:MM:SS</c> format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-12 03:06:00</para>
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
            /// <para>The percentage of total peak memory usage from all patterns that the queries for this pattern consume.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PeakMemoryPercentage")]
            [Validation(Required=false)]
            public double? PeakMemoryPercentage { get; set; }

            /// <summary>
            /// <para>The total peak memory used by statements matching this pattern, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("PeakMemorySum")]
            [Validation(Required=false)]
            public double? PeakMemorySum { get; set; }

            /// <summary>
            /// <para>The number of executions for statements matching this pattern within the specified time range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>345</para>
            /// </summary>
            [NameInMap("QueryCount")]
            [Validation(Required=false)]
            public long? QueryCount { get; set; }

            /// <summary>
            /// <para>The percentage of total query time from all patterns that the queries for this pattern consume.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("QueryTimePercentage")]
            [Validation(Required=false)]
            public double? QueryTimePercentage { get; set; }

            /// <summary>
            /// <para>The total query time for statements matching this pattern, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("QueryTimeSum")]
            [Validation(Required=false)]
            public double? QueryTimeSum { get; set; }

            /// <summary>
            /// <para>The SQL pattern statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SELECT * FROM KEPLER_META_NODE_STATIC_INFO WHERE elastic_node = ? OR (elastic_node = ? AND enable = ?)</para>
            /// </summary>
            [NameInMap("SQLPattern")]
            [Validation(Required=false)]
            public string SQLPattern { get; set; }

            /// <summary>
            /// <para>The percentage of the total CPU cost from all table scans that the queries for this pattern consume.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ScanCostPercentage")]
            [Validation(Required=false)]
            public double? ScanCostPercentage { get; set; }

            /// <summary>
            /// <para>The total CPU cost of table scans for statements matching this pattern, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ScanCostSum")]
            [Validation(Required=false)]
            public double? ScanCostSum { get; set; }

            /// <summary>
            /// <para>The percentage of the total data scan size from all patterns that the queries for this pattern consume.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("ScanSizePercentage")]
            [Validation(Required=false)]
            public double? ScanSizePercentage { get; set; }

            /// <summary>
            /// <para>The total data scan size for statements matching this pattern, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ScanSizeSum")]
            [Validation(Required=false)]
            public double? ScanSizeSum { get; set; }

            /// <summary>
            /// <para>The database table scanned by the queries in this pattern.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tpch.orders</para>
            /// </summary>
            [NameInMap("Tables")]
            [Validation(Required=false)]
            public string Tables { get; set; }

            /// <summary>
            /// <para>The database username that submitted the SQL statements matching this pattern.</para>
            /// 
            /// <b>Example:</b>
            /// <para>reporter</para>
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6BE0EDD1-0DE6-3EB6-81BF-BFE4F2******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
