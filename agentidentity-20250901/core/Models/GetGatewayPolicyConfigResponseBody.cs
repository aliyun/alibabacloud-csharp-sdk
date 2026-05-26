// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class GetGatewayPolicyConfigResponseBody : TeaModel {
        [NameInMap("GatewayPolicyConfig")]
        [Validation(Required=false)]
        public GetGatewayPolicyConfigResponseBodyGatewayPolicyConfig GatewayPolicyConfig { get; set; }
        public class GetGatewayPolicyConfigResponseBodyGatewayPolicyConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ENFORCE</para>
            /// </summary>
            [NameInMap("EnforcementMode")]
            [Validation(Required=false)]
            public string EnforcementMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>acs:agentidentity:cn-beijing:123456:policyset/default-policy-set</para>
            /// </summary>
            [NameInMap("PolicySetArn")]
            [Validation(Required=false)]
            public string PolicySetArn { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2A48EB1D-D645-5758-91AF-EDF8E36E257B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
