// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class ListPolicySetAttachedGatewaysResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of attached gateways.</para>
        /// </summary>
        [NameInMap("AttachedGateways")]
        [Validation(Required=false)]
        public List<ListPolicySetAttachedGatewaysResponseBodyAttachedGateways> AttachedGateways { get; set; }
        public class ListPolicySetAttachedGatewaysResponseBodyAttachedGateways : TeaModel {
            /// <summary>
            /// <para>The name of the policy set that is currently in effect on the gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default-policy-set</para>
            /// </summary>
            [NameInMap("AttachedPolicySetName")]
            [Validation(Required=false)]
            public string AttachedPolicySetName { get; set; }

            /// <summary>
            /// <para>The time when the policy set was attached to the gateway, in UTC and ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-05-08T06:19:17Z</para>
            /// </summary>
            [NameInMap("AttachedTime")]
            [Validation(Required=false)]
            public string AttachedTime { get; set; }

            /// <summary>
            /// <para>The policy enforcement mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ENFORCE: Blocks non-compliant requests and allows compliant requests.</description></item>
            /// <item><description>LOG_ONLY: Only logs non-compliant requests without blocking them.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ENFORCE</para>
            /// </summary>
            [NameInMap("EnforcementMode")]
            [Validation(Required=false)]
            public string EnforcementMode { get; set; }

            /// <summary>
            /// <para>The ARN of the target gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:agentidentity:cn-beijing:123456:gateway/my-gateway</para>
            /// </summary>
            [NameInMap("GatewayArn")]
            [Validation(Required=false)]
            public string GatewayArn { get; set; }

            /// <summary>
            /// <para>The gateway type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>AIGateway: Alibaba Cloud AI Gateway</description></item>
            /// <item><description>AgentRunMCP: AgentRun MCP tool</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AIGateway</para>
            /// </summary>
            [NameInMap("GatewayType")]
            [Validation(Required=false)]
            public string GatewayType { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of results to return per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token used for pagination. You do not need to specify this parameter for the first call. For subsequent calls, pass the NextToken value returned from the previous call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2A48EB1D-D645-5758-91AF-EDF8E36E257B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries that match the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
