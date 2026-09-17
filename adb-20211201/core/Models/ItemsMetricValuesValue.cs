// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ItemsMetricValuesValue : TeaModel {
        /// <summary>
        /// <para>The primary metric code, which matches the key in <c>MetricValues</c> and the <c>MetricType</c> request parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>QUERY_COUNT</c>: the number of query executions.</description></item>
        /// <item><description><c>CPU_COST</c>: the CPU consumption.</description></item>
        /// <item><description><c>SHUFFLE_SIZE</c>: the shuffle data volume.</description></item>
        /// <item><description><c>PEAK_MEMORY</c>: the peak memory consumption.</description></item>
        /// <item><description><c>SCAN_SIZE</c>: the scan data volume.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CPU_COST</para>
        /// </summary>
        [NameInMap("MetricCode")]
        [Validation(Required=false)]
        public string MetricCode { get; set; }

        /// <summary>
        /// <para>The primary metric name. The mapping is as follows:</para>
        /// <list type="bullet">
        /// <item><description><c>QUERY_COUNT</c>: <c>QueryCount</c>.</description></item>
        /// <item><description><c>CPU_COST</c>: <c>OperatorCost</c>.</description></item>
        /// <item><description><c>SHUFFLE_SIZE</c>: <c>ShuffleSize</c>.</description></item>
        /// <item><description><c>PEAK_MEMORY</c>: <c>PeakMemory</c>.</description></item>
        /// <item><description><c>SCAN_SIZE</c>: <c>ScanSize</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OperatorCost</para>
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>Indicates whether this is the primary metric for the current analysis dimension. The current value is true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Primary")]
        [Validation(Required=false)]
        public bool? Primary { get; set; }

        /// <summary>
        /// <para>The aggregated result for Time 2 in the NEW report. This field is returned only for NEW reports.</para>
        /// </summary>
        [NameInMap("Time2")]
        [Validation(Required=false)]
        public ItemsMetricValuesValueTime2 Time2 { get; set; }
        public class ItemsMetricValuesValueTime2 : TeaModel {
            /// <summary>
            /// <para>The sum of metric values across active query minute buckets for Time 2. The unit depends on MetricCode: count for QUERY_COUNT, seconds for CPU_COST, and GB (1 GB = 1024³ bytes) for SHUFFLE_SIZE, PEAK_MEMORY, and SCAN_SIZE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>180</para>
            /// </summary>
            [NameInMap("SumValue")]
            [Validation(Required=false)]
            public double? SumValue { get; set; }

            /// <summary>
            /// <para>The display string of the total sum for Time 2, with the unit included.</para>
            /// 
            /// <b>Example:</b>
            /// <para>180s</para>
            /// </summary>
            [NameInMap("SumDisplayValue")]
            [Validation(Required=false)]
            public string SumDisplayValue { get; set; }

            /// <summary>
            /// <para>The average value across active query minute buckets for Time 2, calculated as the total sum divided by the number of minute buckets that contain queries for this Pattern. The unit depends on MetricCode: count for QUERY_COUNT, seconds for CPU_COST, and GB (1 GB = 1024³ bytes) for SHUFFLE_SIZE, PEAK_MEMORY, and SCAN_SIZE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("AvgValue")]
            [Validation(Required=false)]
            public double? AvgValue { get; set; }

            /// <summary>
            /// <para>The display string of the average value across active query minute buckets for Time 2, with the unit included.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3s</para>
            /// </summary>
            [NameInMap("AvgDisplayValue")]
            [Validation(Required=false)]
            public string AvgDisplayValue { get; set; }

            /// <summary>
            /// <para>The maximum metric value in a single minute bucket for Time 2. The unit depends on MetricCode: count for QUERY_COUNT, seconds for CPU_COST, and GB (1 GB = 1024³ bytes) for SHUFFLE_SIZE, PEAK_MEMORY, and SCAN_SIZE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("MaxValue")]
            [Validation(Required=false)]
            public double? MaxValue { get; set; }

            /// <summary>
            /// <para>The display string of the peak value in a single minute bucket for Time 2, with the unit included.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9s</para>
            /// </summary>
            [NameInMap("MaxDisplayValue")]
            [Validation(Required=false)]
            public string MaxDisplayValue { get; set; }

            /// <summary>
            /// <para>The percentage of this Pattern\&quot;s Time 2 total sum relative to the total sum of all results before dimension filtering in the current report. A value of 10 indicates 10%.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("SumRatioPercent")]
            [Validation(Required=false)]
            public double? SumRatioPercent { get; set; }

            /// <summary>
            /// <para>The percentage of this Pattern\&quot;s Time 2 average value relative to the sum of average values across all Patterns before dimension filtering in the current report. A value of 10 indicates 10%.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("AvgRatioPercent")]
            [Validation(Required=false)]
            public double? AvgRatioPercent { get; set; }

        }

        /// <summary>
        /// <para>The dual-window comparison of the average value across active query minute buckets for the CHANGED report. This field is returned only for CHANGED reports.</para>
        /// </summary>
        [NameInMap("Avg")]
        [Validation(Required=false)]
        public ItemsMetricValuesValueAvg Avg { get; set; }
        public class ItemsMetricValuesValueAvg : TeaModel {
            /// <summary>
            /// <para>The change rate of the average value across active query minute buckets, calculated as (Time 2 value − Time 1 value) / Time 1 value × 100. A value of 200 indicates a 200% increase. When the Time 1 value is 0, a finite change rate cannot be calculated. This field may not be returned and must not be treated as 0%.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("ChangeRatePercent")]
            [Validation(Required=false)]
            public double? ChangeRatePercent { get; set; }

            /// <summary>
            /// <para>The average value across active query minute buckets for Time 1. The unit depends on MetricCode: count for QUERY_COUNT, seconds for CPU_COST, and GB (1 GB = 1024³ bytes) for SHUFFLE_SIZE, PEAK_MEMORY, and SCAN_SIZE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Time1Value")]
            [Validation(Required=false)]
            public double? Time1Value { get; set; }

            /// <summary>
            /// <para>The display string of the average value across active query minute buckets for Time 1, with the unit included.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1s</para>
            /// </summary>
            [NameInMap("Time1DisplayValue")]
            [Validation(Required=false)]
            public string Time1DisplayValue { get; set; }

            /// <summary>
            /// <para>The percentage of this Pattern\&quot;s Time 1 average value across active query minute buckets relative to the sum of the corresponding statistics for all results before dimension filtering in the current report. A value of 10 indicates 10%.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Time1RatioPercent")]
            [Validation(Required=false)]
            public double? Time1RatioPercent { get; set; }

            /// <summary>
            /// <para>The average value across active query minute buckets for Time 2. The unit depends on MetricCode: count for QUERY_COUNT, seconds for CPU_COST, and GB (1 GB = 1024³ bytes) for SHUFFLE_SIZE, PEAK_MEMORY, and SCAN_SIZE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Time2Value")]
            [Validation(Required=false)]
            public double? Time2Value { get; set; }

            /// <summary>
            /// <para>The display string of the average value across active query minute buckets for Time 2, with the unit included.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3s</para>
            /// </summary>
            [NameInMap("Time2DisplayValue")]
            [Validation(Required=false)]
            public string Time2DisplayValue { get; set; }

            /// <summary>
            /// <para>The percentage of this Pattern\&quot;s Time 2 average value across active query minute buckets relative to the sum of the corresponding statistics for all results before dimension filtering in the current report. A value of 10 indicates 10%.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Time2RatioPercent")]
            [Validation(Required=false)]
            public double? Time2RatioPercent { get; set; }

        }

        /// <summary>
        /// <para>The dual-window comparison of the sum of metric values across active query minute buckets for the CHANGED report. This field is returned only for CHANGED reports.</para>
        /// </summary>
        [NameInMap("Sum")]
        [Validation(Required=false)]
        public ItemsMetricValuesValueSum Sum { get; set; }
        public class ItemsMetricValuesValueSum : TeaModel {
            /// <summary>
            /// <para>The change rate of the sum of metric values across active query minute buckets, calculated as (Time 2 value − Time 1 value) / Time 1 value × 100. A value of 200 indicates a 200% increase. When the Time 1 value is 0, a finite change rate cannot be calculated. This field may not be returned and must not be treated as 0%.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("ChangeRatePercent")]
            [Validation(Required=false)]
            public double? ChangeRatePercent { get; set; }

            /// <summary>
            /// <para>The sum of metric values across active query minute buckets for Time 1. The unit depends on MetricCode: count for QUERY_COUNT, seconds for CPU_COST, and GB (1 GB = 1024³ bytes) for SHUFFLE_SIZE, PEAK_MEMORY, and SCAN_SIZE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("Time1Value")]
            [Validation(Required=false)]
            public double? Time1Value { get; set; }

            /// <summary>
            /// <para>The display string of the sum of metric values across active query minute buckets for Time 1, with the unit included.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60s</para>
            /// </summary>
            [NameInMap("Time1DisplayValue")]
            [Validation(Required=false)]
            public string Time1DisplayValue { get; set; }

            /// <summary>
            /// <para>The percentage of this Pattern\&quot;s Time 1 sum of metric values across active query minute buckets relative to the sum of the corresponding statistics for all results before dimension filtering in the current report. A value of 10 indicates 10%.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Time1RatioPercent")]
            [Validation(Required=false)]
            public double? Time1RatioPercent { get; set; }

            /// <summary>
            /// <para>The sum of metric values across active query minute buckets for Time 2. The unit depends on MetricCode: count for QUERY_COUNT, seconds for CPU_COST, and GB (1 GB = 1024³ bytes) for SHUFFLE_SIZE, PEAK_MEMORY, and SCAN_SIZE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>180</para>
            /// </summary>
            [NameInMap("Time2Value")]
            [Validation(Required=false)]
            public double? Time2Value { get; set; }

            /// <summary>
            /// <para>The display string of the sum of metric values across active query minute buckets for Time 2, with the unit included.</para>
            /// 
            /// <b>Example:</b>
            /// <para>180s</para>
            /// </summary>
            [NameInMap("Time2DisplayValue")]
            [Validation(Required=false)]
            public string Time2DisplayValue { get; set; }

            /// <summary>
            /// <para>The percentage of this Pattern\&quot;s Time 2 sum of metric values across active query minute buckets relative to the sum of the corresponding statistics for all results before dimension filtering in the current report. A value of 10 indicates 10%.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Time2RatioPercent")]
            [Validation(Required=false)]
            public double? Time2RatioPercent { get; set; }

        }

        /// <summary>
        /// <para>The dual-window comparison of the peak value in a single minute bucket for the CHANGED report. This field is returned only for CHANGED reports.</para>
        /// </summary>
        [NameInMap("Max")]
        [Validation(Required=false)]
        public ItemsMetricValuesValueMax Max { get; set; }
        public class ItemsMetricValuesValueMax : TeaModel {
            /// <summary>
            /// <para>The change rate of the peak value in a single minute bucket, calculated as (Time 2 value − Time 1 value) / Time 1 value × 100. A value of 200 indicates a 200% increase. When the Time 1 value is 0, a finite change rate cannot be calculated. This field may not be returned and must not be treated as 0%.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("ChangeRatePercent")]
            [Validation(Required=false)]
            public double? ChangeRatePercent { get; set; }

            /// <summary>
            /// <para>The peak value in a single minute bucket for Time 1. The unit depends on MetricCode: count for QUERY_COUNT, seconds for CPU_COST, and GB (1 GB = 1024³ bytes) for SHUFFLE_SIZE, PEAK_MEMORY, and SCAN_SIZE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Time1Value")]
            [Validation(Required=false)]
            public double? Time1Value { get; set; }

            /// <summary>
            /// <para>The display string of the peak value in a single minute bucket for Time 1, with the unit included.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3s</para>
            /// </summary>
            [NameInMap("Time1DisplayValue")]
            [Validation(Required=false)]
            public string Time1DisplayValue { get; set; }

            /// <summary>
            /// <para>The peak value in a single minute bucket for Time 2. The unit depends on MetricCode: count for QUERY_COUNT, seconds for CPU_COST, and GB (1 GB = 1024³ bytes) for SHUFFLE_SIZE, PEAK_MEMORY, and SCAN_SIZE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("Time2Value")]
            [Validation(Required=false)]
            public double? Time2Value { get; set; }

            /// <summary>
            /// <para>The display string of the peak value in a single minute bucket for Time 2, with the unit included.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9s</para>
            /// </summary>
            [NameInMap("Time2DisplayValue")]
            [Validation(Required=false)]
            public string Time2DisplayValue { get; set; }

        }

    }

}
