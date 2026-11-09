// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class DeleteAgentVersionRequest : TeaModel {
        /// <summary>
        /// <para>The client-generated idempotency token. This is a reserved parameter, and the backend does not currently provide persistent idempotency guarantees.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c2d8a6f0-3b1e-4a7d-9f25-6e4b0c1a8d37</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
