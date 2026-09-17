// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeSqlPatternCompareReportResponseBody : TeaModel {
        /// <summary>
        /// <para>The Pattern details on the current page. An empty array is returned if no results match the conditions.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeSqlPatternCompareReportResponseBodyItems> Items { get; set; }
        public class DescribeSqlPatternCompareReportResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The display string of the average execution duration for Time 2, in seconds. This field is returned only for the CPU_COST dimension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.4s</para>
            /// </summary>
            [NameInMap("AvgExecutionTime")]
            [Validation(Required=false)]
            public string AvgExecutionTime { get; set; }

            /// <summary>
            /// <para>The display string of the average planning duration for Time 2, in seconds. This field is returned only for the CPU_COST dimension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.1s</para>
            /// </summary>
            [NameInMap("AvgPlanningTime")]
            [Validation(Required=false)]
            public string AvgPlanningTime { get; set; }

            /// <summary>
            /// <para>The display string of the average query response time for Time 2, in seconds. This field is returned for all analysis dimensions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.5s</para>
            /// </summary>
            [NameInMap("AvgRt")]
            [Validation(Required=false)]
            public string AvgRt { get; set; }

            /// <summary>
            /// <para>The display string of the maximum execution duration for Time 2, in seconds. This field is returned only for the CPU_COST dimension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.8s</para>
            /// </summary>
            [NameInMap("MaxExecutionTime")]
            [Validation(Required=false)]
            public string MaxExecutionTime { get; set; }

            /// <summary>
            /// <para>The display string of the maximum planning duration for Time 2, in seconds. This field is returned only for the CPU_COST dimension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.2s</para>
            /// </summary>
            [NameInMap("MaxPlanningTime")]
            [Validation(Required=false)]
            public string MaxPlanningTime { get; set; }

            /// <summary>
            /// <para>The display string of the maximum query response time for Time 2, in seconds. This field is returned for all analysis dimensions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2s</para>
            /// </summary>
            [NameInMap("MaxRt")]
            [Validation(Required=false)]
            public string MaxRt { get; set; }

            /// <summary>
            /// <para>The primary metric mapping for the current analysis dimension. Valid keys:</para>
            /// <list type="bullet">
            /// <item><description><c>QUERY_COUNT</c>: the number of query executions.</description></item>
            /// <item><description><c>CPU_COST</c>: the CPU consumption.</description></item>
            /// <item><description><c>SHUFFLE_SIZE</c>: the shuffle data volume.</description></item>
            /// <item><description><c>PEAK_MEMORY</c>: the peak memory consumption.</description></item>
            /// <item><description><c>SCAN_SIZE</c>: the scan data volume.</description></item>
            /// </list>
            /// <remarks>
            /// <para>Each result contains only one key that matches the <c>MetricType</c> request parameter.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("MetricValues")]
            [Validation(Required=false)]
            public Dictionary<string, ItemsMetricValuesValue> MetricValues { get; set; }

            /// <summary>
            /// <para>The parameterized SQL Pattern text. This field is empty or not returned when IncludePattern is set to false. When the text is unavailable, a prompt containing a hash identifier may be returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SELECT * FROM orders WHERE order_id = ?</para>
            /// </summary>
            [NameInMap("Pattern")]
            [Validation(Required=false)]
            public string Pattern { get; set; }

            /// <summary>
            /// <para>The number of query executions for Time 2, in count. This field is returned for the CPU_COST, SHUFFLE_SIZE, PEAK_MEMORY, and SCAN_SIZE dimensions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("QueryCount")]
            [Validation(Required=false)]
            public long? QueryCount { get; set; }

            /// <summary>
            /// <para>The display string of the number of query executions for Time 2. The applicable scope is the same as QueryCount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120 times</para>
            /// </summary>
            [NameInMap("QueryCountDisplayValue")]
            [Validation(Required=false)]
            public string QueryCountDisplayValue { get; set; }

            /// <summary>
            /// <para>The global sequence number in the current filtered and sorted results, starting from 1 and numbered continuously across pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Rank")]
            [Validation(Required=false)]
            public long? Rank { get; set; }

            /// <summary>
            /// <para>The change level for the current analysis dimension. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>NEW</c>: A new Pattern. Returned only for NEW reports.</description></item>
            /// <item><description><c>SLIGHT</c>: A slight change. The average change rate is in the range of (0%, 20%].</description></item>
            /// <item><description><c>MODERATE</c>: A moderate change. The average change rate is in the range of (20%, 50%].</description></item>
            /// <item><description><c>HIGH</c>: A high change. The average change rate is in the range of (50%, 100%].</description></item>
            /// <item><description><c>SEVERE</c>: A severe change. The average change rate is greater than 100%, or the change represents zero-baseline growth.</description></item>
            /// </list>
            /// <remarks>
            /// <para>The change level only indicates the magnitude of metric growth and cannot be used alone to determine the cause of a fault.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>SEVERE</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <para>The hash identifier of the SQL Pattern, returned as a string. Store and pass this value as a string to avoid precision loss caused by numeric conversion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567890123456789</para>
            /// </summary>
            [NameInMap("SqlPatternHash")]
            [Validation(Required=false)]
            public string SqlPatternHash { get; set; }

            /// <summary>
            /// <para>The display string of the total query duration for Time 2, in seconds. This field is returned only for the QUERY_COUNT dimension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60s</para>
            /// </summary>
            [NameInMap("TotalQueryTime")]
            [Validation(Required=false)]
            public string TotalQueryTime { get; set; }

            /// <summary>
            /// <para>The display string of the total scan duration for Time 2, in seconds. This field is returned only for the SCAN_SIZE dimension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12s</para>
            /// </summary>
            [NameInMap("TotalScanCost")]
            [Validation(Required=false)]
            public string TotalScanCost { get; set; }

        }

        /// <summary>
        /// <para>The analysis metric. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>QUERY_COUNT</c>: the number of query executions.</description></item>
        /// <item><description><c>CPU_COST</c>: the CPU consumption.</description></item>
        /// <item><description><c>SHUFFLE_SIZE</c>: the amount of shuffle data.</description></item>
        /// <item><description><c>PEAK_MEMORY</c>: the peak memory consumption.</description></item>
        /// <item><description><c>SCAN_SIZE</c>: the amount of scanned data.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CPU_COST</para>
        /// </summary>
        [NameInMap("MetricType")]
        [Validation(Required=false)]
        public string MetricType { get; set; }

        /// <summary>
        /// <para>The page number of the returned page, starting from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The maximum number of entries returned per page for this query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the SQL Pattern comparison report.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1001</para>
        /// </summary>
        [NameInMap("ReportId")]
        [Validation(Required=false)]
        public long? ReportId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9A1B2C3D-4E5F-6789-ABCD-0123456789AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of Patterns that match the current report, analysis dimension, and change rate filter conditions. This is not the number of entries on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
