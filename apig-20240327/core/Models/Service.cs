// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class Service : TeaModel {
        /// <summary>
        /// <para>The address details, which can be IP addresses or domain names.</para>
        /// </summary>
        [NameInMap("addresses")]
        [Validation(Required=false)]
        public List<string> Addresses { get; set; }

        /// <summary>
        /// <para>The agent service configuration</para>
        /// </summary>
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
        /// <para>The creation time (unix timestamp).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1725617840096</para>
        /// </summary>
        [NameInMap("createTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// <para>The express type</para>
        /// 
        /// <b>Example:</b>
        /// <para>StartExecution</para>
        /// </summary>
        [NameInMap("expressType")]
        [Validation(Required=false)]
        public string ExpressType { get; set; }

        /// <summary>
        /// <para>The gateway instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-xxxx</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The service group name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>publich</para>
        /// </summary>
        [NameInMap("groupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The health check configurations.</para>
        /// </summary>
        [NameInMap("healthCheck")]
        [Validation(Required=false)]
        public ServiceHealthCheck HealthCheck { get; set; }

        /// <summary>
        /// <para>The health check status.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Unhealthy</description></item>
        /// <item><description>Healthy</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Healthy</para>
        /// </summary>
        [NameInMap("healthStatus")]
        [Validation(Required=false)]
        public string HealthStatus { get; set; }

        /// <summary>
        /// <para>The label details for service version configuration</para>
        /// </summary>
        [NameInMap("labelDetails")]
        [Validation(Required=false)]
        public List<LabelDetail> LabelDetails { get; set; }

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
        /// 
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The outlier endpoints list</para>
        /// </summary>
        [NameInMap("outlierEndpoints")]
        [Validation(Required=false)]
        public List<string> OutlierEndpoints { get; set; }

        /// <summary>
        /// <para>The list of objects containing port details.</para>
        /// </summary>
        [NameInMap("ports")]
        [Validation(Required=false)]
        public List<ServicePorts> Ports { get; set; }
        public class ServicePorts : TeaModel {
            /// <summary>
            /// <para>The port name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user-service</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The port number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8080</para>
            /// </summary>
            [NameInMap("port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The protocol. Valid values: TCP and UDP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

        }

        /// <summary>
        /// <para>The service protocol type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The function qualifier name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LATEST</para>
        /// </summary>
        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

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
        /// <para>The service unique ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>svc-cr6pk4tlhtgm***</para>
        /// </summary>
        [NameInMap("serviceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>The source type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MSE_NACOS</para>
        /// </summary>
        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The list of unhealthy endpoints.</para>
        /// </summary>
        [NameInMap("unhealthyEndpoints")]
        [Validation(Required=false)]
        public List<string> UnhealthyEndpoints { get; set; }

        /// <summary>
        /// <para>The last modified time (unix timestamp).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1725868548440</para>
        /// </summary>
        [NameInMap("updateTimestamp")]
        [Validation(Required=false)]
        public long? UpdateTimestamp { get; set; }

    }

}
