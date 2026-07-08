// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AnyTrans20250707.Models
{
    public class SubmitHtmlTranslateTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public SubmitHtmlTranslateTaskResponseBodyData Data { get; set; }
        public class SubmitHtmlTranslateTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The translation task status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>in_process</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The HTML translation task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2746f4be-cff2-465e-a2c6-12bff30ce0f9</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>User-defined tracking data that the service returns as-is. Use this parameter for data tracking.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;traceId&quot;:&quot;trace_123456&quot;}</para>
            /// </summary>
            [NameInMap("trackingData")]
            [Validation(Required=false)]
            public string TrackingData { get; set; }

        }

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
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID. Use it to trace the API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>72E4FDA1-5474-5DC1-8DFF-968BEEA65C49</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
