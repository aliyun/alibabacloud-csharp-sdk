// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class CapacityPlanRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether complex aggregate query is required. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Required.</description></item>
        /// <item><description>false (default): Not required.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("complexQueryAvailable")]
        [Validation(Required=false)]
        public bool? ComplexQueryAvailable { get; set; }

        /// <summary>
        /// <para>The disk usage information.</para>
        /// </summary>
        [NameInMap("dataInfo")]
        [Validation(Required=false)]
        public List<CapacityPlanRequestDataInfo> DataInfo { get; set; }
        public class CapacityPlanRequestDataInfo : TeaModel {
            /// <summary>
            /// <para>The disk data metric code. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>totalRawData: source data information</description></item>
            /// <item><description>document: data document information, estimated number of documents</description></item>
            /// <item><description>dailyIncrement: daily data growth</description></item>
            /// <item><description>dailyIncrement: daily incremental documents</description></item>
            /// <item><description>retentionTime: data retention period</description></item>
            /// <item><description>replica: replica settings.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>totalRawData</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The metric value of disk usage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The total number of data entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// <para>The disk data type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>hot: hot data</description></item>
            /// <item><description>warm: warm data.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>hot</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The data unit or time unit. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Data units: MiB, GiB, TB, PB</description></item>
            /// <item><description>Time units: DAYS, WEEKS, MONTHS, YEARS.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MiB</para>
            /// </summary>
            [NameInMap("unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

        /// <summary>
        /// <para>The metric information, including disk usage, search and write operations, and aggregation requests.</para>
        /// </summary>
        [NameInMap("metric")]
        [Validation(Required=false)]
        public List<CapacityPlanRequestMetric> Metric { get; set; }
        public class CapacityPlanRequestMetric : TeaModel {
            /// <summary>
            /// <para>The average QPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("averageQps")]
            [Validation(Required=false)]
            public int? AverageQps { get; set; }

            /// <summary>
            /// <para>The search or write metric code. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>write: write</description></item>
            /// <item><description>search: search.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>write</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The number of concurrent connections.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("concurrent")]
            [Validation(Required=false)]
            public long? Concurrent { get; set; }

            /// <summary>
            /// <para>The peak QPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("peakQps")]
            [Validation(Required=false)]
            public int? PeakQps { get; set; }

            /// <summary>
            /// <para>The expected average response time, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("responseTime")]
            [Validation(Required=false)]
            public int? ResponseTime { get; set; }

            /// <summary>
            /// <para>The throughput, in MB/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("throughput")]
            [Validation(Required=false)]
            public long? Throughput { get; set; }

            /// <summary>
            /// <para>The search or write peak type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>common: normal</description></item>
            /// <item><description>peak: peak.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>common</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Scenarios. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>general: general-purpose scenario</description></item>
        /// <item><description>analysisVisualization: data analytics scenario</description></item>
        /// <item><description>dbAcceleration: database acceleration scenario</description></item>
        /// <item><description>search: search scenario</description></item>
        /// <item><description>log: log scenario.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>general</para>
        /// </summary>
        [NameInMap("usageScenario")]
        [Validation(Required=false)]
        public string UsageScenario { get; set; }

    }

}
