// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class MetricData : TeaModel {
        /// <summary>
        /// <para>The end time of the time series query, exclusive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-11-05T00:02:00Z</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The grouping keys used for this query. An empty array is returned if no grouping is applied.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;teamID&quot;]</para>
        /// </summary>
        [NameInMap("groupBy")]
        [Validation(Required=false)]
        public List<string> GroupBy { get; set; }

        /// <summary>
        /// <para>The data point interval used for this query, in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The result for each requested metric.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;metricName&quot;:&quot;cpuUsedCores&quot;,&quot;unit&quot;:&quot;Core&quot;,&quot;series&quot;:[{&quot;dimensions&quot;:{&quot;teamID&quot;:&quot;70d1c834-0333-58d8-97ac-5336eb9179eb&quot;},&quot;points&quot;:[{&quot;timestamp&quot;:&quot;2026-11-05T00:00:00Z&quot;,&quot;value&quot;:0.25},{&quot;timestamp&quot;:&quot;2026-11-05T00:01:00Z&quot;,&quot;value&quot;:0.5}]}]}]</para>
        /// </summary>
        [NameInMap("results")]
        [Validation(Required=false)]
        public List<MetricDataResults> Results { get; set; }
        public class MetricDataResults : TeaModel {
            /// <summary>
            /// <para>The name of the metric in the request.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cpuUsedCores</para>
            /// </summary>
            [NameInMap("metricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// <para>The time series for the metric. An empty array is returned if no data points exist.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;dimensions&quot;:{&quot;teamID&quot;:&quot;70d1c834-0333-58d8-97ac-5336eb9179eb&quot;},&quot;points&quot;:[{&quot;timestamp&quot;:&quot;2026-11-05T00:00:00Z&quot;,&quot;value&quot;:0.25},{&quot;timestamp&quot;:&quot;2026-11-05T00:01:00Z&quot;,&quot;value&quot;:0.5}]}]</para>
            /// </summary>
            [NameInMap("series")]
            [Validation(Required=false)]
            public List<MetricDataResultsSeries> Series { get; set; }
            public class MetricDataResultsSeries : TeaModel {
                /// <summary>
                /// <para>The team, template, or other grouping values for this series.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;teamID&quot;:&quot;70d1c834-0333-58d8-97ac-5336eb9179eb&quot;}</para>
                /// </summary>
                [NameInMap("dimensions")]
                [Validation(Required=false)]
                public Dictionary<string, string> Dimensions { get; set; }

                /// <summary>
                /// <para>The data points in chronological order. Only times with metric values are listed.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;timestamp&quot;:&quot;2026-11-05T00:00:00Z&quot;,&quot;value&quot;:0.25},{&quot;timestamp&quot;:&quot;2026-11-05T00:01:00Z&quot;,&quot;value&quot;:0.5}]</para>
                /// </summary>
                [NameInMap("points")]
                [Validation(Required=false)]
                public List<MetricDataResultsSeriesPoints> Points { get; set; }
                public class MetricDataResultsSeriesPoints : TeaModel {
                    /// <summary>
                    /// <para>The time corresponding to the metric value, in UTC seconds.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-11-05T00:00:00Z</para>
                    /// </summary>
                    [NameInMap("timestamp")]
                    [Validation(Required=false)]
                    public string Timestamp { get; set; }

                    /// <summary>
                    /// <para>The metric value at this time. The unit is specified in unit.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.25</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public double? Value { get; set; }

                }

            }

            /// <summary>
            /// <para>The unit of the metric value, such as Core for CPU cores.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Core</para>
            /// </summary>
            [NameInMap("unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

        /// <summary>
        /// <para>The start time of the time series query, inclusive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-11-05T00:00:00Z</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The time of the query. Returned only for single-point queries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-11-05T00:01:00Z</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}
