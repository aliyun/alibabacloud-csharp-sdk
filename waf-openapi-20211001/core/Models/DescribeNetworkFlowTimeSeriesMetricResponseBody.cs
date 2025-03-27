// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeNetworkFlowTimeSeriesMetricResponseBody : TeaModel {
        /// <summary>
        /// <para>The array of time-series data. Supports returning data with multiple values.</para>
        /// </summary>
        [NameInMap("NetworkFlowTimeSeries")]
        [Validation(Required=false)]
        public List<DescribeNetworkFlowTimeSeriesMetricResponseBodyNetworkFlowTimeSeries> NetworkFlowTimeSeries { get; set; }
        public class DescribeNetworkFlowTimeSeriesMetricResponseBodyNetworkFlowTimeSeries : TeaModel {
            /// <summary>
            /// <para>The metric name, consistent with the Metric request parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>total_requests</para>
            /// </summary>
            [NameInMap("Metric")]
            [Validation(Required=false)]
            public string Metric { get; set; }

            /// <summary>
            /// <para>The array of timestamps (seconds) marking the start of each time interval.</para>
            /// </summary>
            [NameInMap("Timestamps")]
            [Validation(Required=false)]
            public List<string> Timestamps { get; set; }

            /// <summary>
            /// <para>The array of counts, each representing the count for the corresponding time interval.</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<long?> Values { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D827FCFE-90A7-4330-9326-D33C8B4C7726</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The time series metadata.</para>
        /// </summary>
        [NameInMap("TimeSeriesMetaData")]
        [Validation(Required=false)]
        public DescribeNetworkFlowTimeSeriesMetricResponseBodyTimeSeriesMetaData TimeSeriesMetaData { get; set; }
        public class DescribeNetworkFlowTimeSeriesMetricResponseBodyTimeSeriesMetaData : TeaModel {
            /// <summary>
            /// <para>The time granularity. For example, &quot;15m&quot; indicates that each data point is counted every 15 minutes. For details, see <b>Time granularity of time series data points</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;1m&quot;</para>
            /// </summary>
            [NameInMap("AggregateInterval")]
            [Validation(Required=false)]
            public string AggregateInterval { get; set; }

            /// <summary>
            /// <para>The query time range.</para>
            /// </summary>
            [NameInMap("DateRange")]
            [Validation(Required=false)]
            public DescribeNetworkFlowTimeSeriesMetricResponseBodyTimeSeriesMetaDataDateRange DateRange { get; set; }
            public class DescribeNetworkFlowTimeSeriesMetricResponseBodyTimeSeriesMetaDataDateRange : TeaModel {
                /// <summary>
                /// <para>The end time of the query range (in UNIX timestamp, seconds). Same as the EndDate request parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1713888600</para>
                /// </summary>
                [NameInMap("EndDate")]
                [Validation(Required=false)]
                public long? EndDate { get; set; }

                /// <summary>
                /// <para>The start time of the query range (in UNIX timestamp, seconds). It is the same as the StartDate request parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1713888000</para>
                /// </summary>
                [NameInMap("StartDate")]
                [Validation(Required=false)]
                public long? StartDate { get; set; }

            }

            /// <summary>
            /// <para>The unit of the returned data. Defaults to the value: request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>request</para>
            /// </summary>
            [NameInMap("Units")]
            [Validation(Required=false)]
            public string Units { get; set; }

        }

    }

}
