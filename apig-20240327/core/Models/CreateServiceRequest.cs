// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateServiceRequest : TeaModel {
        /// <summary>
        /// <para>Gateway ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-cq7l5s5lhtg***</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>Resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-xxx</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>List of service configuration information.</para>
        /// </summary>
        [NameInMap("serviceConfigs")]
        [Validation(Required=false)]
        public List<CreateServiceRequestServiceConfigs> ServiceConfigs { get; set; }
        public class CreateServiceRequestServiceConfigs : TeaModel {
            /// <summary>
            /// <para>List of domain names or fixed addresses.</para>
            /// </summary>
            [NameInMap("addresses")]
            [Validation(Required=false)]
            public List<string> Addresses { get; set; }

            /// <summary>
            /// <para>AI service configuration.</para>
            /// </summary>
            [NameInMap("aiServiceConfig")]
            [Validation(Required=false)]
            public AiServiceConfig AiServiceConfig { get; set; }

            /// <summary>
            /// <para>List of DNS server addresses.</para>
            /// </summary>
            [NameInMap("dnsServers")]
            [Validation(Required=false)]
            public List<string> DnsServers { get; set; }

            /// <summary>
            /// <para>Service group name.
            /// Needs to be specified when <c>sourceType</c> is MSE_NACOS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEFAULT_GROUP</para>
            /// </summary>
            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>Service name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user-service</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Namespace of the service:</para>
            /// <list type="bullet">
            /// <item><description>When <c>sourceType</c> is K8S, it represents the namespace where the K8S service is located.</description></item>
            /// <item><description>When <c>sourceType</c> is MSE_NACOS, it represents the namespace in Nacos.</description></item>
            /// </list>
            /// <para>It needs to be specified when <c>sourceType</c> is K8S or MSE_NACOS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PUBLIC</para>
            /// </summary>
            [NameInMap("namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>Function version or alias.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LATEST</para>
            /// </summary>
            [NameInMap("qualifier")]
            [Validation(Required=false)]
            public string Qualifier { get; set; }

        }

        /// <summary>
        /// <para>Service source:</para>
        /// <list type="bullet">
        /// <item><description>MSE_NACOS: Services in MSE Nacos.</description></item>
        /// <item><description>K8S: Services in the K8S cluster of container service.</description></item>
        /// <item><description>VIP: Fixed address service.</description></item>
        /// <item><description>DNS: DNS domain name service.</description></item>
        /// <item><description>FC3: Function Compute service.</description></item>
        /// <item><description>SAE_K8S_SERVICE: SAE K8S service.</description></item>
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
