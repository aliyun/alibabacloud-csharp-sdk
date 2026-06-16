// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeDecisionResultTrendResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The input parameter data is not valid. order_storage_company_num component not found</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AE7E6105-7DEB-5125-9B24-DCBC139F6CD2</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned object.</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeDecisionResultTrendResponseBodyResultObject ResultObject { get; set; }
        public class DescribeDecisionResultTrendResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>The chart data.</para>
            /// </summary>
            [NameInMap("series")]
            [Validation(Required=false)]
            public List<DescribeDecisionResultTrendResponseBodyResultObjectSeries> Series { get; set; }
            public class DescribeDecisionResultTrendResponseBodyResultObjectSeries : TeaModel {
                /// <summary>
                /// <para>The returned data object.</para>
                /// </summary>
                [NameInMap("data")]
                [Validation(Required=false)]
                public List<DescribeDecisionResultTrendResponseBodyResultObjectSeriesData> Data { get; set; }
                public class DescribeDecisionResultTrendResponseBodyResultObjectSeriesData : TeaModel {
                    /// <summary>
                    /// <para>The quantity.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("num")]
                    [Validation(Required=false)]
                    public long? Num { get; set; }

                    /// <summary>
                    /// <para>The ratio.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5.56%</para>
                    /// </summary>
                    [NameInMap("scale")]
                    [Validation(Required=false)]
                    public string Scale { get; set; }

                }

                /// <summary>
                /// <para>The name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IpTag_FFF</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The x-axis data.</para>
            /// </summary>
            [NameInMap("xaxis")]
            [Validation(Required=false)]
            public DescribeDecisionResultTrendResponseBodyResultObjectXaxis Xaxis { get; set; }
            public class DescribeDecisionResultTrendResponseBodyResultObjectXaxis : TeaModel {
                /// <summary>
                /// <para>The xaxis data structure.</para>
                /// </summary>
                [NameInMap("data")]
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
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
