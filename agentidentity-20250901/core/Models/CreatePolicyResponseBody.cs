// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class CreatePolicyResponseBody : TeaModel {
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public CreatePolicyResponseBodyPolicy Policy { get; set; }
        public class CreatePolicyResponseBodyPolicy : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-05-08T06:19:17Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Definition")]
            [Validation(Required=false)]
            public Definition Definition { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>example description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>acs:agentidentity:cn-beijing:123456:policyset/default-policy-set/policy/rate-limit-policy</para>
            /// </summary>
            [NameInMap("PolicyArn")]
            [Validation(Required=false)]
            public string PolicyArn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rate-limit-policy</para>
            /// </summary>
            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>default-policy-set</para>
            /// </summary>
            [NameInMap("PolicySetName")]
            [Validation(Required=false)]
            public string PolicySetName { get; set; }

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
