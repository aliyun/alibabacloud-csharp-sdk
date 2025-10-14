// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeSiteTimeSeriesDataResponseBody : TeaModel {
        /// <summary>
        /// <para>Returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeSiteTimeSeriesDataResponseBodyData> Data { get; set; }
        public class DescribeSiteTimeSeriesDataResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Returned data.</para>
            /// </summary>
            [NameInMap("DetailData")]
            [Validation(Required=false)]
            public List<DescribeSiteTimeSeriesDataResponseBodyDataDetailData> DetailData { get; set; }
            public class DescribeSiteTimeSeriesDataResponseBodyDataDetailData : TeaModel {
                /// <summary>
                /// <para>Start timestamp of the time slice.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-04-08T16:00:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// <para>Value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public object Value { get; set; }

            }

            /// <summary>
            /// <para>Query dimension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALL</para>
            /// </summary>
            [NameInMap("DimensionName")]
            [Validation(Required=false)]
            public string DimensionName { get; set; }

            /// <summary>
            /// <para>Query dimension value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALL</para>
            /// </summary>
            [NameInMap("DimensionValue")]
            [Validation(Required=false)]
            public string DimensionValue { get; set; }

            /// <summary>
            /// <para>Query metric value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Traffic</para>
            /// </summary>
            [NameInMap("FieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

        }

        /// <summary>
        /// <para>The end time for fetching the data.</para>
        /// <para>The date format follows ISO8601 notation and uses UTC+0, formatted as yyyy-MM-ddTHH:mm:ssZ.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-04-09T16:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The granularity of the data, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public long? Interval { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The sampling rate, in %.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("SamplingRate")]
        [Validation(Required=false)]
        public float? SamplingRate { get; set; }

        /// <summary>
        /// <para>The start time for fetching the data.</para>
        /// <para>The date format follows ISO8601 notation and uses UTC+0, formatted as yyyy-MM-ddTHH:mm:ssZ.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-04-08T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>Aggregated query data.</para>
        /// </summary>
        [NameInMap("SummarizedData")]
        [Validation(Required=false)]
        public List<DescribeSiteTimeSeriesDataResponseBodySummarizedData> SummarizedData { get; set; }
        public class DescribeSiteTimeSeriesDataResponseBodySummarizedData : TeaModel {
            /// <summary>
            /// <para>The aggregation method used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sum</para>
            /// </summary>
            [NameInMap("AggMethod")]
            [Validation(Required=false)]
            public string AggMethod { get; set; }

            /// <summary>
            /// <para>The dimension of the aggregated data being queried.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALL</para>
            /// </summary>
            [NameInMap("DimensionName")]
            [Validation(Required=false)]
            public string DimensionName { get; set; }

            /// <summary>
            /// <para>The value of the aggregated dimension being queried.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALL</para>
            /// </summary>
            [NameInMap("DimensionValue")]
            [Validation(Required=false)]
            public string DimensionValue { get; set; }

            /// <summary>
            /// <para>The value of the aggregated metric being queried.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Traffic</para>
            /// </summary>
            [NameInMap("FieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            /// <summary>
            /// <para>The aggregated value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public object Value { get; set; }

        }

    }

}
