// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenAgent20260801.Models
{
    public class UpdateSessionHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// <para>The idempotency key for the request. Use the same value when you retry the same update request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>update-session-example-001</para>
        /// </summary>
        [NameInMap("X-OpenAgent-Idempotency-Key")]
        [Validation(Required=false)]
        public string XOpenAgentIdempotencyKey { get; set; }

    }

}
