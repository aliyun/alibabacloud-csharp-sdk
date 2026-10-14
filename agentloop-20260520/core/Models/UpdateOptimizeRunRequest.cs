// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class UpdateOptimizeRunRequest : TeaModel {
        /// <summary>
        /// <para>The extra parameters. To retry a failed artifact application, set application.action to retry and do not specify status. Do not specify this field when canceling a run.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;application&quot;:{&quot;action&quot;:&quot;retry&quot;}}</para>
        /// </summary>
        [NameInMap("extra")]
        [Validation(Required=false)]
        public Dictionary<string, object> Extra { get; set; }

        /// <summary>
        /// <para>The status. Only Cancelled is supported when canceling a run. The execution status is maintained by the server. Do not specify this field when retrying an artifact application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Succeeded</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The idempotency token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a1b2c3d4-1234-5678-90ab-cdef12345678</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
