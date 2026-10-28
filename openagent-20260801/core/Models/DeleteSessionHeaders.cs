// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenAgent20260801.Models
{
    public class DeleteSessionHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// <para>The idempotency key of the request. Subsequent calls after deletion, including those using the same key, return 404 Session.NotFound.</para>
        /// 
        /// <b>Example:</b>
        /// <para>delete-session-example-001</para>
        /// </summary>
        [NameInMap("X-OpenAgent-Idempotency-Key")]
        [Validation(Required=false)]
        public string XOpenAgentIdempotencyKey { get; set; }

    }

}
