// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class AttachPolicySetToGatewayRequest : TeaModel {
        /// <summary>
        /// <para>The policy enforcement mode. Valid values: ENFORCE (blocks non-compliant requests and allows compliant requests) and LOG_ONLY (records non-compliant requests but does not block them).</para>
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
        /// <item><description>AIGateway: Alibaba Cloud AI gateway.</description></item>
        /// <item><description>AgentRunMCP: AgentRun MCP tool.</description></item>
        /// </list>
        /// <para>Default value: AIGateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AIGateway</para>
        /// </summary>
        [NameInMap("GatewayType")]
        [Validation(Required=false)]
        public string GatewayType { get; set; }

        /// <summary>
        /// <para>The name of the policy set. The name must be unique within the current Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default-policy-set</para>
        /// </summary>
        [NameInMap("PolicySetName")]
        [Validation(Required=false)]
        public string PolicySetName { get; set; }

    }

}
