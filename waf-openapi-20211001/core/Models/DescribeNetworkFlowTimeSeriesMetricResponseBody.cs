// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeNetworkFlowTimeSeriesMetricResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned time series data. Time series data of multiple values can be returned.</para>
        /// </summary>
        [NameInMap("NetworkFlowTimeSeries")]
        [Validation(Required=false)]
        public List<DescribeNetworkFlowTimeSeriesMetricResponseBodyNetworkFlowTimeSeries> NetworkFlowTimeSeries { get; set; }
        public class DescribeNetworkFlowTimeSeriesMetricResponseBodyNetworkFlowTimeSeries : TeaModel {
            /// <summary>
            /// <para>The returned data content. The meaning is consistent with the Metric parameter in the request parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>total_requests</para>
            /// </summary>
            [NameInMap("Metric")]
            [Validation(Required=false)]
            public string Metric { get; set; }

            /// <summary>
            /// <para>The time series. Each point represents the start time of a time range.</para>
            /// </summary>
            [NameInMap("Timestamps")]
            [Validation(Required=false)]
            public List<string> Timestamps { get; set; }

            /// <summary>
            /// <para>The data series. Each point represents the statistical count within a specific time range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[]</para>
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
            /// <para>The statistical time granularity of each data point in the returned time series data. For example, &quot;15m&quot; indicates that each returned data point is the statistical data for every 15 minutes. For more information about the time granularity of the returned data, see <b>Description of the time granularity of time series data points</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1m</para>
            /// </summary>
            [NameInMap("AggregateInterval")]
            [Validation(Required=false)]
            public string AggregateInterval { get; set; }

            /// <summary>
            /// <para>The time range used for the query.</para>
            /// </summary>
            [NameInMap("DateRange")]
            [Validation(Required=false)]
            public DescribeNetworkFlowTimeSeriesMetricResponseBodyTimeSeriesMetaDataDateRange DateRange { get; set; }
            public class DescribeNetworkFlowTimeSeriesMetricResponseBodyTimeSeriesMetaDataDateRange : TeaModel {
                /// <summary>
                /// <para>The end time used for querying data. The value is a UNIX timestamp in seconds. This value is the same as the EndDate parameter in the request parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1713888600</para>
                /// </summary>
                [NameInMap("EndDate")]
                [Validation(Required=false)]
                public long? EndDate { get; set; }

                /// <summary>
                /// <para>The start time used for querying data. The value is a UNIX timestamp in seconds. This value is the same as the StartDate parameter in the request parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1713888000</para>
                /// </summary>
                [NameInMap("StartDate")]
                [Validation(Required=false)]
                public long? StartDate { get; set; }

            }

            /// <summary>
            /// <para>The unit of the returned statistical data. Default value: requests.</para>
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
