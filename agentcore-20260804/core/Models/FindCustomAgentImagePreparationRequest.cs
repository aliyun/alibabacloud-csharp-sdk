// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class FindCustomAgentImagePreparationRequest : TeaModel {
        /// <summary>
        /// <para>The idempotency token passed as a query parameter. This parameter is required when you explicitly submit customImage or container.type=custom, and optional for ACR image and code package submissions. The value must be 1 to 128 characters in length and can contain letters, digits, periods, underscores, colons, and hyphens. Reuse the same token for retries of the same submission. If the same token is used for different parameters, the request will be rejected.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image-update-20261022-001</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
