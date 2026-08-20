// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AgentInfo : TeaModel {
        /// <summary>
        /// <para>The associated resource information for the Agent access capability. Returns null if the Agent access capability is not configured.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("agentAccess")]
        [Validation(Required=false)]
        public AgentInfoAgentAccess AgentAccess { get; set; }
        public class AgentInfoAgentAccess : TeaModel {
            /// <summary>
            /// <para>The HTTP API ID associated with the Agent access capability. The frontend uses this ID to call existing HTTP API, route, consumer authorization, policy, and plugin query interfaces.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{ &quot;httpApiId&quot;: &quot;api-abc123&quot; }</para>
            /// </summary>
            [NameInMap("httpApiId")]
            [Validation(Required=false)]
            public string HttpApiId { get; set; }

        }

        /// <summary>
        /// <para>Agent ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent-1</para>
        /// </summary>
        [NameInMap("agentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>The Agent type. DashScope (Bailian) allows only Agent access. Dify allows both Agent access and model access. ClaudeCode allows only model access. Custom allows both Agent access and model access.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Custom</para>
        /// </summary>
        [NameInMap("agentType")]
        [Validation(Required=false)]
        public string AgentType { get; set; }

        /// <summary>
        /// <para>The list of capabilities that the current Agent type allows to be configured. This field does not indicate that the capabilities are already configured. To determine whether a capability is configured, check whether agentAccess or modelAccess is null.</para>
        /// </summary>
        [NameInMap("allowedCapabilities")]
        [Validation(Required=false)]
        public List<string> AllowedCapabilities { get; set; }

        /// <summary>
        /// <para>The Agent creation time, in Unix millisecond timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1755129600000</para>
        /// </summary>
        [NameInMap("createTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// <para>The Agent description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom agent</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The gateway ID to which the Agent belongs. When reading the associated API deployment configuration, select the configuration whose gatewayId matches this value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gateway-1</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The associated resource information for the model access capability. Returns null if the model access capability is not configured.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("modelAccess")]
        [Validation(Required=false)]
        public AgentInfoModelAccess ModelAccess { get; set; }
        public class AgentInfoModelAccess : TeaModel {
            /// <summary>
            /// <para>The list of consumer identity bindings maintained by the Agent domain. The Model API ID and the consumer IDs in this list together identify the Agent identity and take effect on all routes of the Model API. Consumer details and their Model API authorization details can be obtained through existing Consumer API and consumer authorization query interfaces.</para>
            /// </summary>
            [NameInMap("consumerIds")]
            [Validation(Required=false)]
            public List<string> ConsumerIds { get; set; }

            /// <summary>
            /// <para>The Model API ID associated with the model access capability. Model Access does not distinguish routes. The frontend uses this ID to query the Model API basic information and all routes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{ &quot;modelApiId&quot;: &quot;model-api-1&quot; }</para>
            /// </summary>
            [NameInMap("modelApiId")]
            [Validation(Required=false)]
            public string ModelApiId { get; set; }

        }

        /// <summary>
        /// <para>The Agent name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-agent</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The resource group ID in which the Agent is saved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-1</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The Agent status. An Agent that is successfully created and queryable always returns Ready. Internal creation or compensation states are not returned externally.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ready</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The Agent last update time, in Unix millisecond timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1755129600000</para>
        /// </summary>
        [NameInMap("updateTimestamp")]
        [Validation(Required=false)]
        public long? UpdateTimestamp { get; set; }

    }

}
