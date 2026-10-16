// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class GetGatewayPolicyConfigRequest : TeaModel {
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
        /// <para>If this parameter is not specified, the default value is AIGateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AIGateway</para>
        /// </summary>
        [NameInMap("GatewayType")]
        [Validation(Required=false)]
        public string GatewayType { get; set; }

    }

}
