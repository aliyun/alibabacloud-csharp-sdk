// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeSiteWafTimeSeriesDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeSiteWafTimeSeriesDataResponseBodyData> Data { get; set; }
        public class DescribeSiteWafTimeSeriesDataResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The returned data.</para>
            /// </summary>
            [NameInMap("DetailData")]
            [Validation(Required=false)]
            public List<DescribeSiteWafTimeSeriesDataResponseBodyDataDetailData> DetailData { get; set; }
            public class DescribeSiteWafTimeSeriesDataResponseBodyDataDetailData : TeaModel {
                /// <summary>
                /// <para>The start time of the time slice.</para>
                /// <para>The time is in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is in UTC+0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-04-08T16:00:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// <para>The value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public object Value { get; set; }

            }

            /// <summary>
            /// <para>The query dimension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALL</para>
            /// </summary>
            [NameInMap("DimensionName")]
            [Validation(Required=false)]
            public string DimensionName { get; set; }

            /// <summary>
            /// <para>The dimension value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALL</para>
            /// </summary>
            [NameInMap("DimensionValue")]
            [Validation(Required=false)]
            public string DimensionValue { get; set; }

            /// <summary>
            /// <para>The metric name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Traffic</para>
            /// </summary>
            [NameInMap("FieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

        }

        /// <summary>
        /// <para>The end time of the returned data.</para>
        /// <para>The time is in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is in UTC+0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-04-09T16:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The data granularity. Unit: seconds.</para>
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
        /// <para>93652946-2687-5428-8254-533B1E6A***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The sampling rate. Unit: %.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("SamplingRate")]
        [Validation(Required=false)]
        public float? SamplingRate { get; set; }

        /// <summary>
        /// <para>The start time for the data query.</para>
        /// <para>Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC+0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-04-08T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The summarized query data.</para>
        /// </summary>
        [NameInMap("SummarizedData")]
        [Validation(Required=false)]
        public List<DescribeSiteWafTimeSeriesDataResponseBodySummarizedData> SummarizedData { get; set; }
        public class DescribeSiteWafTimeSeriesDataResponseBodySummarizedData : TeaModel {
            /// <summary>
            /// <para>The aggregation method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sum</para>
            /// </summary>
            [NameInMap("AggMethod")]
            [Validation(Required=false)]
            public string AggMethod { get; set; }

            /// <summary>
            /// <para>The summarized dimension name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALL</para>
            /// </summary>
            [NameInMap("DimensionName")]
            [Validation(Required=false)]
            public string DimensionName { get; set; }

            /// <summary>
            /// <para>The summarized dimension value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALL</para>
            /// </summary>
            [NameInMap("DimensionValue")]
            [Validation(Required=false)]
            public string DimensionValue { get; set; }

            /// <summary>
            /// <para>The summarized metric name.</para>
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
            /// <para>123456</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public object Value { get; set; }

        }

    }

}
