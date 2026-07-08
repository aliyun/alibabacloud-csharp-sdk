// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeNetworkFlowTimeSeriesMetricResponseBody : TeaModel {
        /// <summary>
        /// <para>The time series data. Multiple data series can be returned.</para>
        /// </summary>
        [NameInMap("NetworkFlowTimeSeries")]
        [Validation(Required=false)]
        public List<DescribeNetworkFlowTimeSeriesMetricResponseBodyNetworkFlowTimeSeries> NetworkFlowTimeSeries { get; set; }
        public class DescribeNetworkFlowTimeSeriesMetricResponseBodyNetworkFlowTimeSeries : TeaModel {
            /// <summary>
            /// <para>The metric name. This value is the same as the Metric request parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>total_requests</para>
            /// </summary>
            [NameInMap("Metric")]
            [Validation(Required=false)]
            public string Metric { get; set; }

            /// <summary>
            /// <para>The timestamps. Each value represents the start of a time interval.</para>
            /// </summary>
            [NameInMap("Timestamps")]
            [Validation(Required=false)]
            public List<string> Timestamps { get; set; }

            /// <summary>
            /// <para>The metric values. Each value represents the count within the corresponding time interval.</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<long?> Values { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D827FCFE-90A7-4330-9326-D33C8B4*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The metadata of the returned data.</para>
        /// </summary>
        [NameInMap("TimeSeriesMetaData")]
        [Validation(Required=false)]
        public DescribeNetworkFlowTimeSeriesMetricResponseBodyTimeSeriesMetaData TimeSeriesMetaData { get; set; }
        public class DescribeNetworkFlowTimeSeriesMetricResponseBodyTimeSeriesMetaData : TeaModel {
            /// <summary>
            /// <para>The time granularity of each data point in the returned time series. For example, &quot;15m&quot; indicates that each data point represents statistics for a 15-minute interval. For more information about the time granularity, see the <b>Time granularity of data points</b> section.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1m</para>
            /// </summary>
            [NameInMap("AggregateInterval")]
            [Validation(Required=false)]
            public string AggregateInterval { get; set; }

            /// <summary>
            /// <para>The time range that was queried.</para>
            /// </summary>
            [NameInMap("DateRange")]
            [Validation(Required=false)]
            public DescribeNetworkFlowTimeSeriesMetricResponseBodyTimeSeriesMetaDataDateRange DateRange { get; set; }
            public class DescribeNetworkFlowTimeSeriesMetricResponseBodyTimeSeriesMetaDataDateRange : TeaModel {
                /// <summary>
                /// <para>The end of the time range that was queried. This value is a UNIX timestamp. Unit: seconds. This value is the same as the EndDate request parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1713888600</para>
                /// </summary>
                [NameInMap("EndDate")]
                [Validation(Required=false)]
                public long? EndDate { get; set; }

                /// <summary>
                /// <para>The start of the time range that was queried. This value is a UNIX timestamp. Unit: seconds. This value is the same as the StartDate request parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1713888000</para>
                /// </summary>
                [NameInMap("StartDate")]
                [Validation(Required=false)]
                public long? StartDate { get; set; }

            }

            /// <summary>
            /// <para>The unit of the returned data. Default value: requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>requests</para>
            /// </summary>
            [NameInMap("Units")]
            [Validation(Required=false)]
            public string Units { get; set; }

        }

    }

}
