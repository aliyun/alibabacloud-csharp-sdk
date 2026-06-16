// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeTagsBarChartResponseBody : TeaModel {
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
        /// <para>The error message.</para>
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
        public DescribeTagsBarChartResponseBodyResultObject ResultObject { get; set; }
        public class DescribeTagsBarChartResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>The data list.</para>
            /// </summary>
            [NameInMap("series")]
            [Validation(Required=false)]
            public List<DescribeTagsBarChartResponseBodyResultObjectSeries> Series { get; set; }
            public class DescribeTagsBarChartResponseBodyResultObjectSeries : TeaModel {
                /// <summary>
                /// <para>The chart data list.</para>
                /// </summary>
                [NameInMap("data")]
                [Validation(Required=false)]
                public List<DescribeTagsBarChartResponseBodyResultObjectSeriesData> Data { get; set; }
                public class DescribeTagsBarChartResponseBodyResultObjectSeriesData : TeaModel {
                    /// <summary>
                    /// <para>The quantity.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("num")]
                    [Validation(Required=false)]
                    public long? Num { get; set; }

                    /// <summary>
                    /// <para>The ratio.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10%</para>
                    /// </summary>
                    [NameInMap("scale")]
                    [Validation(Required=false)]
                    public string Scale { get; set; }

                }

                /// <summary>
                /// <para>The series name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tag</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The chart field, which is the same as the name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tag</para>
                /// </summary>
                [NameInMap("stack")]
                [Validation(Required=false)]
                public string Stack { get; set; }

            }

            /// <summary>
            /// <para>The x-axis configuration.</para>
            /// </summary>
            [NameInMap("xaxis")]
            [Validation(Required=false)]
            public DescribeTagsBarChartResponseBodyResultObjectXaxis Xaxis { get; set; }
            public class DescribeTagsBarChartResponseBodyResultObjectXaxis : TeaModel {
                /// <summary>
                /// <para>The x-axis data items.</para>
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
