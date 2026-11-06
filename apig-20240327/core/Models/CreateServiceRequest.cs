// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateServiceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-cq7l5s5lhtg***</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-xxx</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The list of service configurations. At least one service configuration must be included.</para>
        /// </summary>
        [NameInMap("serviceConfigs")]
        [Validation(Required=false)]
        public List<CreateServiceRequestServiceConfigs> ServiceConfigs { get; set; }
        public class CreateServiceRequestServiceConfigs : TeaModel {
            /// <summary>
            /// <para>The list of domain names or fixed addresses.</para>
            /// </summary>
            [NameInMap("addresses")]
            [Validation(Required=false)]
            public List<string> Addresses { get; set; }

            /// <summary>
            /// <para>The agent service configuration. This parameter is required when the sourceType is AGENT.</para>
            /// </summary>
            [NameInMap("agentServiceConfig")]
            [Validation(Required=false)]
            public AgentServiceConfig AgentServiceConfig { get; set; }

            /// <summary>
            /// <para>The AI service configuration. This parameter is required when the sourceType is AI.</para>
            /// </summary>
            [NameInMap("aiServiceConfig")]
            [Validation(Required=false)]
            public AiServiceConfig AiServiceConfig { get; set; }

            /// <summary>
            /// <para>The list of DNS server addresses.</para>
            /// </summary>
            [NameInMap("dnsServers")]
            [Validation(Required=false)]
            public List<string> DnsServers { get; set; }

            /// <summary>
            /// <para>The service expression type, which identifies the special type or mode of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Standard</para>
            /// </summary>
            [NameInMap("expressType")]
            [Validation(Required=false)]
            public string ExpressType { get; set; }

            /// <summary>
            /// <para>The name of the service group. This parameter is required when the sourceType is MSE_NACOS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEFAULT_GROUP</para>
            /// </summary>
            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The ID of the model provider. This parameter is applicable only to AI services.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mp-xxx****</para>
            /// </summary>
            [NameInMap("modelProviderId")]
            [Validation(Required=false)]
            public string ModelProviderId { get; set; }

            /// <summary>
            /// <para>The name of the service. This parameter is required when the sourceType is FC3.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user-service</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The namespace of the service:</para>
            /// <list type="bullet">
            /// <item><description>When the sourceType is K8S, this parameter specifies the namespace where the Kubernetes service resides.</description></item>
            /// <item><description>When the sourceType is MSE_NACOS, this parameter specifies the namespace in Nacos.
            /// This parameter is required when the sourceType is K8S or MSE_NACOS.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PUBLIC</para>
            /// </summary>
            [NameInMap("namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The function version or alias.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LATEST</para>
            /// </summary>
            [NameInMap("qualifier")]
            [Validation(Required=false)]
            public string Qualifier { get; set; }

            /// <summary>
            /// <para>The ID of the service source. This parameter is required in scenarios with multiple Nacos instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nacos-instance-001</para>
            /// </summary>
            [NameInMap("sourceId")]
            [Validation(Required=false)]
            public string SourceId { get; set; }

            /// <summary>
            /// <para>The validation options, which are configuration options related to service validation.</para>
            /// </summary>
            [NameInMap("validationOptions")]
            [Validation(Required=false)]
            public CreateServiceRequestServiceConfigsValidationOptions ValidationOptions { get; set; }
            public class CreateServiceRequestServiceConfigsValidationOptions : TeaModel {
                /// <summary>
                /// <para>Specifies whether to skip the AI chat completion validation.</para>
                /// </summary>
                [NameInMap("skipVerifyAIChatCompletion")]
                [Validation(Required=false)]
                public bool? SkipVerifyAIChatCompletion { get; set; }

            }

        }

        /// <summary>
        /// <para>The source of the service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MSE_NACOS: services in MSE Nacos.</description></item>
        /// <item><description>K8S: services in Container Service for Kubernetes clusters.</description></item>
        /// <item><description>VIP: fixed address services.</description></item>
        /// <item><description>DNS: DNS domain name services.</description></item>
        /// <item><description>FC3: services in Function Compute.</description></item>
        /// <item><description>SAE_K8S_SERVICE: SAE Kubernetes services.</description></item>
        /// <item><description>AI: AI services.</description></item>
        /// <item><description>AGENT: agent services.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MSE_NACOS</para>
        /// </summary>
        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The client token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
