// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeSQLPatternsResponseBody : TeaModel {
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
        /// <para>The queried SQL patterns.</para>
        /// </summary>
        [NameInMap("PatternDetails")]
        [Validation(Required=false)]
        public List<DescribeSQLPatternsResponseBodyPatternDetails> PatternDetails { get; set; }
        public class DescribeSQLPatternsResponseBodyPatternDetails : TeaModel {
            /// <summary>
            /// <para>The IP address of the SQL client that commits the SQL pattern.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.xx.xx</para>
            /// </summary>
            [NameInMap("AccessIp")]
            [Validation(Required=false)]
            public string AccessIp { get; set; }

            /// <summary>
            /// <para>The average execution duration of the SQL pattern within the query time range. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>234.78</para>
            /// </summary>
            [NameInMap("AverageExecutionTime")]
            [Validation(Required=false)]
            public double? AverageExecutionTime { get; set; }

            [NameInMap("AverageOperatorCost")]
            [Validation(Required=false)]
            public double? AverageOperatorCost { get; set; }

            /// <summary>
            /// <para>The average peak memory usage of the SQL pattern within the query time range. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>234.22</para>
            /// </summary>
            [NameInMap("AveragePeakMemory")]
            [Validation(Required=false)]
            public double? AveragePeakMemory { get; set; }

            /// <summary>
            /// <para>The average total amount of time consumed by the SQL pattern within the query time range. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("AverageQueryTime")]
            [Validation(Required=false)]
            public double? AverageQueryTime { get; set; }

            [NameInMap("AverageScanCost")]
            [Validation(Required=false)]
            public double? AverageScanCost { get; set; }

            /// <summary>
            /// <para>The average amount of data scanned based on the SQL pattern within the query time range. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>234149.23</para>
            /// </summary>
            [NameInMap("AverageScanSize")]
            [Validation(Required=false)]
            public double? AverageScanSize { get; set; }

            /// <summary>
            /// <para>Indicates whether the execution of the SQL pattern can be intercepted. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// <remarks>
            /// <para> Only SELECT and INSERT statements can be intercepted.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Blockable")]
            [Validation(Required=false)]
            public bool? Blockable { get; set; }

            /// <summary>
            /// <para>The number of failed queries executed in association with the SQL pattern within the query time range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18</para>
            /// </summary>
            [NameInMap("FailedCount")]
            [Validation(Required=false)]
            public long? FailedCount { get; set; }

            /// <summary>
            /// <para>The maximum execution duration of the SQL pattern within the query time range. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2142</para>
            /// </summary>
            [NameInMap("MaxExecutionTime")]
            [Validation(Required=false)]
            public long? MaxExecutionTime { get; set; }

            [NameInMap("MaxOperatorCost")]
            [Validation(Required=false)]
            public double? MaxOperatorCost { get; set; }

            /// <summary>
            /// <para>The maximum peak memory usage of the SQL pattern within the query time range. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>234149</para>
            /// </summary>
            [NameInMap("MaxPeakMemory")]
            [Validation(Required=false)]
            public long? MaxPeakMemory { get; set; }

            /// <summary>
            /// <para>The maximum total amount of time consumed by the SQL pattern within the query time range. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2341</para>
            /// </summary>
            [NameInMap("MaxQueryTime")]
            [Validation(Required=false)]
            public long? MaxQueryTime { get; set; }

            [NameInMap("MaxScanCost")]
            [Validation(Required=false)]
            public double? MaxScanCost { get; set; }

            /// <summary>
            /// <para>The maximum amount of data scanned based on the SQL pattern within the query time range. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32212254</para>
            /// </summary>
            [NameInMap("MaxScanSize")]
            [Validation(Required=false)]
            public long? MaxScanSize { get; set; }

            [NameInMap("OperatorCostPercentage")]
            [Validation(Required=false)]
            public double? OperatorCostPercentage { get; set; }

            [NameInMap("OperatorCostSum")]
            [Validation(Required=false)]
            public double? OperatorCostSum { get; set; }

            /// <summary>
            /// <para>The earliest commit time of the SQL pattern within the query time range.</para>
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

            [NameInMap("PeakMemoryPercentage")]
            [Validation(Required=false)]
            public double? PeakMemoryPercentage { get; set; }

            [NameInMap("PeakMemorySum")]
            [Validation(Required=false)]
            public double? PeakMemorySum { get; set; }

            /// <summary>
            /// <para>The number of queries executed in association with the SQL pattern within the query time range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>345</para>
            /// </summary>
            [NameInMap("QueryCount")]
            [Validation(Required=false)]
            public long? QueryCount { get; set; }

            [NameInMap("QueryTimePercentage")]
            [Validation(Required=false)]
            public double? QueryTimePercentage { get; set; }

            [NameInMap("QueryTimeSum")]
            [Validation(Required=false)]
            public double? QueryTimeSum { get; set; }

            /// <summary>
            /// <para>The statement of the SQL pattern.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SELECT * FROM KEPLER_META_NODE_STATIC_INFO WHERE elastic_node = ? OR (elastic_node = ? AND enable = ?)</para>
            /// </summary>
            [NameInMap("SQLPattern")]
            [Validation(Required=false)]
            public string SQLPattern { get; set; }

            [NameInMap("ScanCostPercentage")]
            [Validation(Required=false)]
            public double? ScanCostPercentage { get; set; }

            [NameInMap("ScanCostSum")]
            [Validation(Required=false)]
            public double? ScanCostSum { get; set; }

            [NameInMap("ScanSizePercentage")]
            [Validation(Required=false)]
            public double? ScanSizePercentage { get; set; }

            [NameInMap("ScanSizeSum")]
            [Validation(Required=false)]
            public double? ScanSizeSum { get; set; }

            /// <summary>
            /// <para>The tables scanned based on the SQL pattern.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tpch.orders</para>
            /// </summary>
            [NameInMap("Tables")]
            [Validation(Required=false)]
            public string Tables { get; set; }

            /// <summary>
            /// <para>The name of the database account that is used to commit the SQL pattern.</para>
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
        /// <para>F3174013-5B7A-5A47-9FE0-6B5D397BD86B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
