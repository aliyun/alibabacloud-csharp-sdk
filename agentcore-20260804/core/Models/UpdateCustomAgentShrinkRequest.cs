// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateCustomAgentShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The update configuration of the custom code or image agent. You must provide at least one top-level field. Omitted top-level fields retain their original values. When submitting <c>artifact</c>, specify <c>port</c> and the required fields for the corresponding artifact source. When submitting <c>runtime</c>, specify <c>compute</c> and <c>sessionPolicy</c>, and include the complete <c>hpa</c> that needs to be retained. <c>environment.variables</c> and other arrays are replaced as complete lists.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string BodyShrink { get; set; }

        /// <summary>
        /// <para>The idempotency token passed through query parameters. Required when explicitly submitting customImage or container.type=custom. Optional for ACR image and code package submissions. The length is 1 to 128 characters. Letters, digits, periods, underscores, colons, and hyphens are allowed. Reuse the same token for retries of the same submission. Using the same token for different parameters is rejected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom-agent-request-20261010-001</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
