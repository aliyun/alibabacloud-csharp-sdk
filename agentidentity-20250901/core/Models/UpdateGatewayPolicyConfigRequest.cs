// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class UpdateGatewayPolicyConfigRequest : TeaModel {
        /// <summary>
        /// <para>The policy enforcement mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ENFORCE: Intercepts non-compliant requests and allows compliant requests.</description></item>
        /// <item><description>LOG_ONLY: Only logs non-compliant requests without intercepting them.</description></item>
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
        /// <item><description>AIGateway: Alibaba Cloud AI gateway.</description></item>
        /// <item><description>AgentRunMCP: AgentRun MCP tool.
        /// If you do not specify this parameter, the default value is AIGateway.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AIGateway</para>
        /// </summary>
        [NameInMap("GatewayType")]
        [Validation(Required=false)]
        public string GatewayType { get; set; }

    }

}
