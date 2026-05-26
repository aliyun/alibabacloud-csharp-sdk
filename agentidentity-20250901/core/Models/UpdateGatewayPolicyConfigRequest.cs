// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class UpdateGatewayPolicyConfigRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ENFORCE</para>
        /// </summary>
        [NameInMap("EnforcementMode")]
        [Validation(Required=false)]
        public string EnforcementMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>acs:agentidentity:cn-beijing:123456:gateway/my-gateway</para>
        /// </summary>
        [NameInMap("GatewayArn")]
        [Validation(Required=false)]
        public string GatewayArn { get; set; }

        [NameInMap("GatewayType")]
        [Validation(Required=false)]
        public string GatewayType { get; set; }

    }

}
