// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateServiceRequest : TeaModel {
        /// <summary>
        /// <para>The gateway ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-cq7l5s5lhtg***</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-xxx</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The list of service configurations. At least one service configuration is required.</para>
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
            /// <para>The Agent service configuration. This parameter is required when sourceType is set to AGENT.</para>
            /// </summary>
            [NameInMap("agentServiceConfig")]
            [Validation(Required=false)]
            public AgentServiceConfig AgentServiceConfig { get; set; }

            /// <summary>
            /// <para>The AI service configuration.</para>
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
            /// <para>The service expression type. Identifies the special type or mode of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Standard</para>
            /// </summary>
            [NameInMap("expressType")]
            [Validation(Required=false)]
            public string ExpressType { get; set; }

            /// <summary>
            /// <para>The service group name. This parameter is required when sourceType is set to MSE_NACOS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEFAULT_GROUP</para>
            /// </summary>
            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The model provider ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mp-xxx****</para>
            /// </summary>
            [NameInMap("modelProviderId")]
            [Validation(Required=false)]
            public string ModelProviderId { get; set; }

            /// <summary>
            /// <para>The service name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user-service</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The namespace of the service.</para>
            /// <list type="bullet">
            /// <item><description>If sourceType is set to K8S, this parameter specifies the namespace of the Kubernetes service.</description></item>
            /// <item><description>If sourceType is set to MSE_NACOS, this parameter specifies the namespace in Nacos.</description></item>
            /// </list>
            /// <para>This parameter is required when sourceType is set to K8S or MSE_NACOS.</para>
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
            /// <para>The service source ID. This parameter is required in multi-Nacos instance scenarios.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nacos-instance-001</para>
            /// </summary>
            [NameInMap("sourceId")]
            [Validation(Required=false)]
            public string SourceId { get; set; }

            /// <summary>
            /// <para>The validation options. Configuration options related to service validation.</para>
            /// </summary>
            [NameInMap("validationOptions")]
            [Validation(Required=false)]
            public CreateServiceRequestServiceConfigsValidationOptions ValidationOptions { get; set; }
            public class CreateServiceRequestServiceConfigsValidationOptions : TeaModel {
                /// <summary>
                /// <para>Specifies whether to skip AI chat completion verification.</para>
                /// </summary>
                [NameInMap("skipVerifyAIChatCompletion")]
                [Validation(Required=false)]
                public bool? SkipVerifyAIChatCompletion { get; set; }

            }

        }

        /// <summary>
        /// <para>The service source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MSE_NACOS: a service in MSE Nacos.</description></item>
        /// <item><description>K8S: a service in a Kubernetes cluster of Container Service.</description></item>
        /// <item><description>VIP: a fixed address service.</description></item>
        /// <item><description>DNS: a DNS domain name service.</description></item>
        /// <item><description>FC3: a service in Function Compute.</description></item>
        /// <item><description>SAE_K8S_SERVICE: an SAE Kubernetes service.</description></item>
        /// <item><description>AI: an AI service.</description></item>
        /// <item><description>AGENT: an Agent service.</description></item>
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
