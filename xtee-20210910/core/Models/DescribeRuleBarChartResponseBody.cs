// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeRuleBarChartResponseBody : TeaModel {
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
        /// <para>The response object.</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeRuleBarChartResponseBodyResultObject ResultObject { get; set; }
        public class DescribeRuleBarChartResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>The data list.</para>
            /// </summary>
            [NameInMap("series")]
            [Validation(Required=false)]
            public List<DescribeRuleBarChartResponseBodyResultObjectSeries> Series { get; set; }
            public class DescribeRuleBarChartResponseBodyResultObjectSeries : TeaModel {
                /// <summary>
                /// <para>The response data.</para>
                /// </summary>
                [NameInMap("data")]
                [Validation(Required=false)]
                public List<DescribeRuleBarChartResponseBodyResultObjectSeriesData> Data { get; set; }
                public class DescribeRuleBarChartResponseBodyResultObjectSeriesData : TeaModel {
                    /// <summary>
                    /// <para>The event name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>营销事件</para>
                    /// </summary>
                    [NameInMap("eventName")]
                    [Validation(Required=false)]
                    public string EventName { get; set; }

                    /// <summary>
                    /// <para>The quantity.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("num")]
                    [Validation(Required=false)]
                    public long? Num { get; set; }

                    /// <summary>
                    /// <para>The policy name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>营销风险识别评分_高风险_拒绝</para>
                    /// </summary>
                    [NameInMap("ruleName")]
                    [Validation(Required=false)]
                    public string RuleName { get; set; }

                    /// <summary>
                    /// <para>The status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>RUNNING</para>
                    /// </summary>
                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// <para>The bar chart type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bar</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The y-axis results.</para>
            /// </summary>
            [NameInMap("yaxis")]
            [Validation(Required=false)]
            public DescribeRuleBarChartResponseBodyResultObjectYaxis Yaxis { get; set; }
            public class DescribeRuleBarChartResponseBodyResultObjectYaxis : TeaModel {
                /// <summary>
                /// <para>The y-axis data items.</para>
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
