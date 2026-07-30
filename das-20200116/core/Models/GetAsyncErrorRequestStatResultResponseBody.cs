// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetAsyncErrorRequestStatResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{         &quot;fail&quot;: false,         &quot;data&quot;: {             &quot;ad78a4e7d3ce81590c9dc2d5f4bc****&quot;: {                 &quot;sqlId&quot;: &quot;ad78a4e7d3ce81590c9dc2d5f4bc****&quot;,                 &quot;instanceId&quot;: &quot;rm-2ze8g2am97624****&quot;,                 &quot;count&quot;: 1             },             &quot;0f92feacd92c048b06a16617a633****&quot;: {                 &quot;sqlId&quot;: &quot;0f92feacd92c048b06a16617a633****&quot;,                 &quot;instanceId&quot;: &quot;rm-2ze8g2am97624****&quot;,                 &quot;count&quot;: 2             }         },         &quot;resultId&quot;: &quot;async__61f45ee381b2fa4e8a6545e3bee9****&quot;,         &quot;isFinish&quot;: true,         &quot;state&quot;: &quot;SUCCESS&quot;,         &quot;complete&quot;: true,         &quot;timestamp&quot;: 1644558576717     }</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAsyncErrorRequestStatResultResponseBodyData Data { get; set; }
        public class GetAsyncErrorRequestStatResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the asynchronous request is complete.</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The request is complete.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The request is in progress.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("complete")]
            [Validation(Required=false)]
            public bool? Complete { get; set; }

            /// <summary>
            /// <para>Indicates whether the request failed.</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The request failed.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The request succeeded.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("fail")]
            [Validation(Required=false)]
            public bool? Fail { get; set; }

            /// <summary>
            /// <para>Indicates whether the asynchronous request is complete.</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The request is complete.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The request is in progress.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isFinish")]
            [Validation(Required=false)]
            public bool? IsFinish { get; set; }

            /// <summary>
            /// <para>The data returned by the asynchronous request.</para>
            /// </summary>
            [NameInMap("result")]
            [Validation(Required=false)]
            public Dictionary<string, DataResultValue> Result { get; set; }

            /// <summary>
            /// <para>The asynchronous request ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>async__61f45ee381b2fa4e8a6545e3bee9****</para>
            /// </summary>
            [NameInMap("resultId")]
            [Validation(Required=false)]
            public string ResultId { get; set; }

            /// <summary>
            /// <para>The state of the asynchronous request. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>RUNNING</b>: The request is running.</para>
            /// </description></item>
            /// <item><description><para><b>SUCCESS</b>: The request succeeded.</para>
            /// </description></item>
            /// <item><description><para><b>FAIL</b>: The request failed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The time when the asynchronous request was complete. The time is a Unix timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1644558576717</para>
            /// </summary>
            [NameInMap("timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// <remarks>
        /// <para>If the request succeeds, this parameter returns <b>Successful</b>. If the request fails, this parameter returns an error message.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3FC3F8EB-3564-5D1A-B187-3B03E5B0****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request failed.</para>
        /// </description></item>
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
