// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class InvokeAIAgentResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public InvokeAIAgentResponseBodyData Data { get; set; }
        public class InvokeAIAgentResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;choices&quot;:[{&quot;delta&quot;:{&quot;content&quot;:&quot;分析结果...&quot;}}]}</para>
            /// </summary>
            [NameInMap("body")]
            [Validation(Required=false)]
            public string Body { get; set; }

            [NameInMap("headers")]
            [Validation(Required=false)]
            public Dictionary<string, string> Headers { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("httpCode")]
            [Validation(Required=false)]
            public int? HttpCode { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>A60EE5CA-1294-532A-9775-8D2FD1C6EFBF</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
