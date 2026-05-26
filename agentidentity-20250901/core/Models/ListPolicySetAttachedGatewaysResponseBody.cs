// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class ListPolicySetAttachedGatewaysResponseBody : TeaModel {
        [NameInMap("AttachedGateways")]
        [Validation(Required=false)]
        public List<ListPolicySetAttachedGatewaysResponseBodyAttachedGateways> AttachedGateways { get; set; }
        public class ListPolicySetAttachedGatewaysResponseBodyAttachedGateways : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>default-policy-set</para>
            /// </summary>
            [NameInMap("AttachedPolicySetName")]
            [Validation(Required=false)]
            public string AttachedPolicySetName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-05-08T06:19:17Z</para>
            /// </summary>
            [NameInMap("AttachedTime")]
            [Validation(Required=false)]
            public string AttachedTime { get; set; }

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

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2A48EB1D-D645-5758-91AF-EDF8E36E257B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
