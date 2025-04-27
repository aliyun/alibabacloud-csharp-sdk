// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class CapacityPlanRequest : TeaModel {
        /// <summary>
        /// <para>Indicates whether there is a need for complex aggregation queries. Options:</para>
        /// <list type="bullet">
        /// <item><description>true: Yes</description></item>
        /// <item><description>false (default): No</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("complexQueryAvailable")]
        [Validation(Required=false)]
        public bool? ComplexQueryAvailable { get; set; }

        /// <summary>
        /// <para>Disk usage status.</para>
        /// </summary>
        [NameInMap("dataInfo")]
        [Validation(Required=false)]
        public List<CapacityPlanRequestDataInfo> DataInfo { get; set; }
        public class CapacityPlanRequestDataInfo : TeaModel {
            /// <summary>
            /// <para>Disk data metric code. Options:</para>
            /// <list type="bullet">
            /// <item><description>totalRawData: Raw data information</description></item>
            /// <item><description>document: Data document information, estimated document count</description></item>
            /// <item><description>dailyIncrement: Daily data growth</description></item>
            /// <item><description>dailyIncrementDoc: Daily incremental document count</description></item>
            /// <item><description>retentionTime: Data retention period</description></item>
            /// <item><description>replica: Replica settings</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>totalRawData</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>Disk usage metric value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>Total number of data entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// <para>Disk data type. Options:</para>
            /// <list type="bullet">
            /// <item><description>hot: Hot data</description></item>
            /// <item><description>warm: Cold data</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>hot</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>Data or time unit. Options:</para>
            /// <list type="bullet">
            /// <item><description>Data units: MiB, GiB, TB, PB</description></item>
            /// <item><description>Time units: DAYS, WEEKS, MONTHS, YEARS</description></item>
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
        /// <para>Metrics information including disk usage, search and write operations, aggregation requests, etc.</para>
        /// </summary>
        [NameInMap("metric")]
        [Validation(Required=false)]
        public List<CapacityPlanRequestMetric> Metric { get; set; }
        public class CapacityPlanRequestMetric : TeaModel {
            /// <summary>
            /// <para>Average QPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("averageQps")]
            [Validation(Required=false)]
            public int? AverageQps { get; set; }

            /// <summary>
            /// <para>Search or write metric code. Options:</para>
            /// <list type="bullet">
            /// <item><description>write: Write</description></item>
            /// <item><description>search: Search</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>write</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>Concurrent number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("concurrent")]
            [Validation(Required=false)]
            public long? Concurrent { get; set; }

            /// <summary>
            /// <para>Peak QPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("peakQps")]
            [Validation(Required=false)]
            public int? PeakQps { get; set; }

            /// <summary>
            /// <para>Expected average response time, unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("responseTime")]
            [Validation(Required=false)]
            public int? ResponseTime { get; set; }

            /// <summary>
            /// <para>Throughput, unit: MB/S.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("throughput")]
            [Validation(Required=false)]
            public long? Throughput { get; set; }

            /// <summary>
            /// <para>Search/write peak type. Options:</para>
            /// <list type="bullet">
            /// <item><description>common: Regular</description></item>
            /// <item><description>peak: Peak</description></item>
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
        /// <para>Usage scenarios, options:</para>
        /// <list type="bullet">
        /// <item><description>general: General scenario</description></item>
        /// <item><description>analysisVisualization: Data analysis scenario</description></item>
        /// <item><description>dbAcceleration: Database acceleration scenario</description></item>
        /// <item><description>search: Search scenario</description></item>
        /// <item><description>log: Log scenario</description></item>
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
