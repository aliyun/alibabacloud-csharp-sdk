// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AnyTrans20250707.Models
{
    public class SubmitDocTranslateTaskResponseBody : TeaModel {
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
        public SubmitDocTranslateTaskResponseBodyData Data { get; set; }
        public class SubmitDocTranslateTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The task status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ready</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The document translation task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d3a2397bc2c14ab4a2e40a4f5b46241b</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>User-defined passthrough data. The translation service returns this data without processing it. This is useful for analytics tracking.</para>
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
        /// <para>The request ID, used to trace the API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>377A48D7-7CFA-53F9-8CA2-14FE3F2774B6</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
