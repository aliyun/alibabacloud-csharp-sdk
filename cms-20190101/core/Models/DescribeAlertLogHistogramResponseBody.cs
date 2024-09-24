// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeAlertLogHistogramResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of alert logs that were generated during each interval of a time period.</para>
        /// </summary>
        [NameInMap("AlertLogHistogramList")]
        [Validation(Required=false)]
        public List<DescribeAlertLogHistogramResponseBodyAlertLogHistogramList> AlertLogHistogramList { get; set; }
        public class DescribeAlertLogHistogramResponseBodyAlertLogHistogramList : TeaModel {
            /// <summary>
            /// <para>The number of alert logs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The start timestamp of the queried alert logs.</para>
            /// <para>Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1610074791</para>
            /// </summary>
            [NameInMap("From")]
            [Validation(Required=false)]
            public long? From { get; set; }

            /// <summary>
            /// <para>The end timestamp of the queried alert logs.</para>
            /// <para>Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1610074800</para>
            /// </summary>
            [NameInMap("To")]
            [Validation(Required=false)]
            public long? To { get; set; }

        }

        /// <summary>
        /// <para>The response code.</para>
        /// <remarks>
        /// <para> The status code 200 indicates that the request was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified resource is not found.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1C4A3709-BF52-42EE-87B5-7435F0929585</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
