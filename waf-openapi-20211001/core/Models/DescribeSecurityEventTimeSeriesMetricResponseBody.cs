// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeSecurityEventTimeSeriesMetricResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D827FCFE-90A7-4330-9326-*****4C7726</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned time series data. The operation can return time series data for multiple values.</para>
        /// </summary>
        [NameInMap("SecurityEventTimeSeries")]
        [Validation(Required=false)]
        public List<DescribeSecurityEventTimeSeriesMetricResponseBodySecurityEventTimeSeries> SecurityEventTimeSeries { get; set; }
        public class DescribeSecurityEventTimeSeriesMetricResponseBodySecurityEventTimeSeries : TeaModel {
            /// <summary>
            /// <para>The content of the returned data. This is consistent with the \<c>Metric\\</c> request parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>monitored_requests</para>
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
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<long?> Values { get; set; }

        }

        /// <summary>
        /// <para>The metadata of the returned data.</para>
        /// </summary>
        [NameInMap("TimeSeriesMetaData")]
        [Validation(Required=false)]
        public DescribeSecurityEventTimeSeriesMetricResponseBodyTimeSeriesMetaData TimeSeriesMetaData { get; set; }
        public class DescribeSecurityEventTimeSeriesMetricResponseBodyTimeSeriesMetaData : TeaModel {
            /// <summary>
            /// <para>The time granularity of each data point in the returned time series data. For example, &quot;15m&quot; indicates that each returned data point represents statistics for a 15-minute interval. For more information about the time granularity of the returned data, see the Time granularity of time series data points section.</para>
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
            public DescribeSecurityEventTimeSeriesMetricResponseBodyTimeSeriesMetaDataDateRange DateRange { get; set; }
            public class DescribeSecurityEventTimeSeriesMetricResponseBodyTimeSeriesMetaDataDateRange : TeaModel {
                /// <summary>
                /// <para>The end time of the query. This is a UNIX timestamp. Unit: seconds. This value is the same as the \<c>EndDate\\</c> request parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1713888600</para>
                /// </summary>
                [NameInMap("EndDate")]
                [Validation(Required=false)]
                public long? EndDate { get; set; }

                /// <summary>
                /// <para>The start time of the query. This is a UNIX timestamp. Unit: seconds. This value is the same as the \<c>StartDate\\</c> request parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1713888000</para>
                /// </summary>
                [NameInMap("StartDate")]
                [Validation(Required=false)]
                public long? StartDate { get; set; }

            }

            /// <summary>
            /// <para>The unit of the returned statistical data.</para>
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
