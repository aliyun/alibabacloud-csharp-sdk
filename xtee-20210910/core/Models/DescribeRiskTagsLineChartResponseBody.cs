// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeRiskTagsLineChartResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code. Note: 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>A32FE941-35F2-5378-B37C-4B8FDB16F094</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returned result information</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public DescribeRiskTagsLineChartResponseBodyResultObject ResultObject { get; set; }
        public class DescribeRiskTagsLineChartResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Call percentage, represented as a decimal</para>
            /// </summary>
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public List<float?> Percent { get; set; }

            /// <summary>
            /// <para>Chart data</para>
            /// </summary>
            [NameInMap("Series")]
            [Validation(Required=false)]
            public List<DescribeRiskTagsLineChartResponseBodyResultObjectSeries> Series { get; set; }
            public class DescribeRiskTagsLineChartResponseBodyResultObjectSeries : TeaModel {
                /// <summary>
                /// <para>Data</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public float? Data { get; set; }

                /// <summary>
                /// <para>Name</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm0102</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>Total number of records.</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public List<long?> Total { get; set; }

            /// <summary>
            /// <para>X-axis data of the chart</para>
            /// </summary>
            [NameInMap("Xaxis")]
            [Validation(Required=false)]
            public DescribeRiskTagsLineChartResponseBodyResultObjectXaxis Xaxis { get; set; }
            public class DescribeRiskTagsLineChartResponseBodyResultObjectXaxis : TeaModel {
                /// <summary>
                /// <para>Data returned by the chart</para>
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public List<string> Data { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
