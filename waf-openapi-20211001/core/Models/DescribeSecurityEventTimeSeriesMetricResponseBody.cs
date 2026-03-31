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
        /// <para>The time series data returned. This operation can return time series for multiple metrics.</para>
        /// </summary>
        [NameInMap("SecurityEventTimeSeries")]
        [Validation(Required=false)]
        public List<DescribeSecurityEventTimeSeriesMetricResponseBodySecurityEventTimeSeries> SecurityEventTimeSeries { get; set; }
        public class DescribeSecurityEventTimeSeriesMetricResponseBodySecurityEventTimeSeries : TeaModel {
            /// <summary>
            /// <para>The metric. This value is the same as the value of Metric in the request parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>monitored_requests</para>
            /// </summary>
            [NameInMap("Metric")]
            [Validation(Required=false)]
            public string Metric { get; set; }

            /// <summary>
            /// <para>The time points. Each point represents a time range.</para>
            /// </summary>
            [NameInMap("Timestamps")]
            [Validation(Required=false)]
            public List<string> Timestamps { get; set; }

            /// <summary>
            /// <para>The data points. Each point represents a count for a time range.</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<long?> Values { get; set; }

        }

        /// <summary>
        /// <para>The metadata of the time series data returned.</para>
        /// </summary>
        [NameInMap("TimeSeriesMetaData")]
        [Validation(Required=false)]
        public DescribeSecurityEventTimeSeriesMetricResponseBodyTimeSeriesMetaData TimeSeriesMetaData { get; set; }
        public class DescribeSecurityEventTimeSeriesMetricResponseBodyTimeSeriesMetaData : TeaModel {
            /// <summary>
            /// <para>The time granularity of data points in the time series data returned. For example, a value of 15m indicates that data points are collected at 15-minute intervals. For more information about time granularities, see the <b>Time granularities of data points in time series</b> section below.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1m</para>
            /// </summary>
            [NameInMap("AggregateInterval")]
            [Validation(Required=false)]
            public string AggregateInterval { get; set; }

            /// <summary>
            /// <para>The time range that is used for the query.</para>
            /// </summary>
            [NameInMap("DateRange")]
            [Validation(Required=false)]
            public DescribeSecurityEventTimeSeriesMetricResponseBodyTimeSeriesMetaDataDateRange DateRange { get; set; }
            public class DescribeSecurityEventTimeSeriesMetricResponseBodyTimeSeriesMetaDataDateRange : TeaModel {
                /// <summary>
                /// <para>The end of the time range to query. The value is a Unix timestamp. Unit: seconds. This value is the same as the value of EndDate in the request parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1713888600</para>
                /// </summary>
                [NameInMap("EndDate")]
                [Validation(Required=false)]
                public long? EndDate { get; set; }

                /// <summary>
                /// <para>The beginning of the time range to query. The value is a Unix timestamp. Unit: seconds. This value is the same as the value of StartDate in the request parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1713888000</para>
                /// </summary>
                [NameInMap("StartDate")]
                [Validation(Required=false)]
                public long? StartDate { get; set; }

            }

            /// <summary>
            /// <para>The unit of the statistics returned. It is fixed as requests.</para>
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
