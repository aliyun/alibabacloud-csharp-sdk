// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenAgent20260801.Models
{
    public class SendMessageHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// <para>The idempotency key for the request. Use the same key and the same business parameters when retrying the same request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>send-message-example-001</para>
        /// </summary>
        [NameInMap("X-OpenAgent-Idempotency-Key")]
        [Validation(Required=false)]
        public string XOpenAgentIdempotencyKey { get; set; }

    }

}
