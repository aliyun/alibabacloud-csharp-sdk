// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateServiceRequest : TeaModel {
        /// <summary>
        /// <para>The gateway instance ID.</para>
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
        /// <para>The list of service configurations.</para>
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

            [NameInMap("agentServiceConfig")]
            [Validation(Required=false)]
            public AgentServiceConfig AgentServiceConfig { get; set; }

            /// <summary>
            /// <para>The AI service configurations.</para>
            /// </summary>
            [NameInMap("aiServiceConfig")]
            [Validation(Required=false)]
            public AiServiceConfig AiServiceConfig { get; set; }

            /// <summary>
            /// <para>The list of DNS service addresses.</para>
            /// </summary>
            [NameInMap("dnsServers")]
            [Validation(Required=false)]
            public List<string> DnsServers { get; set; }

            /// <summary>
            /// <para>The service group name. This parameter is required if sourceType is set to MSE_NACOS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEFAULT_GROUP</para>
            /// </summary>
            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

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
            /// <para>The service namespace. This parameter is required when sourceType is set to K8S or MSE_NACOS.</para>
            /// <list type="bullet">
            /// <item><description>If sourceType is set to K8S, this parameter specifies the namespace where the K8s service resides.</description></item>
            /// <item><description>If sourceType is set to MSE_NACOS, this parameter specifies a namespace in Nacos.</description></item>
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

        }

        /// <summary>
        /// <para>The service source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MSE_NACOS: a service in an MSE Nacos instance</description></item>
        /// <item><description>K8S: a service in a Kubernetes (K8s) cluster in Container Service for Kubernetes (ACK)</description></item>
        /// <item><description>VIP: a fixed IP address</description></item>
        /// <item><description>DNS: a Domain Name System (DNS) domain name</description></item>
        /// <item><description>FC3: a service in Function Compute</description></item>
        /// <item><description>SAE_K8S_SERVICE: a service in a K8s cluster in Serverless App Engine (SAE)</description></item>
        /// </list>
        /// <para>Enumerated values:</para>
        /// <list type="bullet">
        /// <item><description>SAE_K8S_SERVICE</description></item>
        /// <item><description>K8S</description></item>
        /// <item><description>FC3</description></item>
        /// <item><description>DNS</description></item>
        /// <item><description>VIP</description></item>
        /// <item><description>MSE_NACOS</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MSE_NACOS</para>
        /// </summary>
        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
