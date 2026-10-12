// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AgentInfo : TeaModel {
        /// <summary>
        /// <para>The associated resource information for the agent access capability. If the agent access capability is not configured, null is always returned.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("agentAccess")]
        [Validation(Required=false)]
        public AgentInfoAgentAccess AgentAccess { get; set; }
        public class AgentInfoAgentAccess : TeaModel {
            /// <summary>
            /// <para>The ID of the HTTP API associated with the agent access capability. The frontend uses this ID to call existing HTTP API, route, consumer authorization, policy, and plugin query operations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{ &quot;httpApiId&quot;: &quot;api-abc123&quot; }</para>
            /// </summary>
            [NameInMap("httpApiId")]
            [Validation(Required=false)]
            public string HttpApiId { get; set; }

        }

        /// <summary>
        /// <para>The agent ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent-1</para>
        /// </summary>
        [NameInMap("agentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>The type of the agent. DashScope allows only agent access. Dify allows agent access and model access. ClaudeCode allows only model access. Custom allows agent access and model access.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Custom</para>
        /// </summary>
        [NameInMap("agentType")]
        [Validation(Required=false)]
        public string AgentType { get; set; }

        /// <summary>
        /// <para>The list of capabilities that the current agent type is allowed to configure. This field does not indicate that the capabilities are already configured. To check whether a capability is configured, determine whether agentAccess or modelAccess is null.</para>
        /// </summary>
        [NameInMap("allowedCapabilities")]
        [Validation(Required=false)]
        public List<string> AllowedCapabilities { get; set; }

        /// <summary>
        /// <para>The time when the agent was created. The value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1755129600000</para>
        /// </summary>
        [NameInMap("createTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// <para>The description of the agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom agent</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the gateway to which the agent belongs. When reading the associated API deployment configuration, select the configuration whose gatewayId matches this value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gateway-1</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The associated resource information for the model access capability. If the model access capability is not configured, null is always returned.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("modelAccess")]
        [Validation(Required=false)]
        public AgentInfoModelAccess ModelAccess { get; set; }
        public class AgentInfoModelAccess : TeaModel {
            /// <summary>
            /// <para>The list of consumer identity bindings maintained by the agent domain. The Model API ID and the consumer IDs in the list jointly identify the agent and take effect for all routes of the Model API. You can obtain consumer details and their Model API authorization details by calling existing Consumer API and consumer authorization query operations.</para>
            /// </summary>
            [NameInMap("consumerIds")]
            [Validation(Required=false)]
            public List<string> ConsumerIds { get; set; }

            /// <summary>
            /// <para>The ID of the Model API associated with the model access capability. Model access does not distinguish between routes. The frontend uses this ID to query the basic information and all routes of the Model API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{ &quot;modelApiId&quot;: &quot;model-api-1&quot; }</para>
            /// </summary>
            [NameInMap("modelApiId")]
            [Validation(Required=false)]
            public string ModelApiId { get; set; }

        }

        /// <summary>
        /// <para>The name of the agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-agent</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the resource group where the agent is saved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-1</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The status of the agent. In the current phase, agents that are successfully created and can be queried always return Ready. Internal creation or compensation statuses are not returned externally.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ready</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The time when the agent was last updated. The value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1755129600000</para>
        /// </summary>
        [NameInMap("updateTimestamp")]
        [Validation(Required=false)]
        public long? UpdateTimestamp { get; set; }

    }

}
