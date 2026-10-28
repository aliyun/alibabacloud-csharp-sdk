// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenAgent20260801.Models
{
    public class CancelRunHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// <para>The idempotency key of the request. Use the same value and the same business parameters when retrying the same cancellation request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cancel-example-001</para>
        /// </summary>
        [NameInMap("X-OpenAgent-Idempotency-Key")]
        [Validation(Required=false)]
        public string XOpenAgentIdempotencyKey { get; set; }

    }

}
