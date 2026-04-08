// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appflow20230904.Models
{
    public class InvokeActionResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>346E5EE9-D5FE-56A0-B3E2-A43E0F67302A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public InvokeActionResponseBodyResult Result { get; set; }
        public class InvokeActionResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>The provided parameter xxx is invalid.</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;output&quot;: {
            ///     &quot;finishReason&quot;: &quot;stop&quot;,
            ///     &quot;text&quot;: &quot;hello&quot;
            ///   },
            ///   &quot;requestId&quot;: &quot;433944e3-2163-9c7a-9664-2a27c0dda0ec&quot;,
            ///   &quot;usage&quot;: {
            ///     &quot;inputTokens&quot;: 13,
            ///     &quot;outputTokens&quot;: 16,
            ///     &quot;totalTokens&quot;: 29
            ///   }
            /// }</para>
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public object Output { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RUNNING、COMPLETED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
