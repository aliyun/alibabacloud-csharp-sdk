// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateServiceRequest : TeaModel {
        /// <summary>
        /// <para>The list of domain names or fixed addresses.</para>
        /// </summary>
        [NameInMap("addresses")]
        [Validation(Required=false)]
        public List<string> Addresses { get; set; }

        /// <summary>
        /// <para>The agent service configurations.</para>
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
        /// <para>A DNS service address.</para>
        /// </summary>
        [NameInMap("dnsServers")]
        [Validation(Required=false)]
        public List<string> DnsServers { get; set; }

        /// <summary>
        /// <para>The health check configurations.</para>
        /// </summary>
        [NameInMap("healthCheckConfig")]
        [Validation(Required=false)]
        public UpdateServiceRequestHealthCheckConfig HealthCheckConfig { get; set; }
        public class UpdateServiceRequestHealthCheckConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable health checks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>The normal status codes to be returned. This parameter is required if the health check protocol is HTTP.</para>
            /// </summary>
            [NameInMap("expectedStatuses")]
            [Validation(Required=false)]
            public List<string> ExpectedStatuses { get; set; }

            /// <summary>
            /// <para>The healthy threshold.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("healthyThreshold")]
            [Validation(Required=false)]
            public int? HealthyThreshold { get; set; }

            /// <summary>
            /// <para>The domain name that you want to use for health checks. Optional. This parameter is available if the health check protocol is HTTP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dev.itemcener.com</para>
            /// </summary>
            [NameInMap("httpHost")]
            [Validation(Required=false)]
            public string HttpHost { get; set; }

            /// <summary>
            /// <para>The request path of health checks. This parameter is required if the health check protocol is HTTP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/healthz</para>
            /// </summary>
            [NameInMap("httpPath")]
            [Validation(Required=false)]
            public string HttpPath { get; set; }

            /// <summary>
            /// <para>The health check interval. Unit: seconds</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

            /// <summary>
            /// <para>The protocol over which the system performs health checks.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>TCP</description></item>
            /// <item><description>HTTP</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The timeout period for a health check response. Unit: seconds</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("timeout")]
            [Validation(Required=false)]
            public int? Timeout { get; set; }

            /// <summary>
            /// <para>The unhealthy threshold.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("unhealthyThreshold")]
            [Validation(Required=false)]
            public int? UnhealthyThreshold { get; set; }

        }

        /// <summary>
        /// <para>The health check threshold.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("healthyPanicThreshold")]
        [Validation(Required=false)]
        public float? HealthyPanicThreshold { get; set; }

        /// <summary>
        /// <para>The passive health check configurations.</para>
        /// </summary>
        [NameInMap("outlierDetectionConfig")]
        [Validation(Required=false)]
        public UpdateServiceRequestOutlierDetectionConfig OutlierDetectionConfig { get; set; }
        public class UpdateServiceRequestOutlierDetectionConfig : TeaModel {
            /// <summary>
            /// <para>The initial isolation duration after a node is isolated (e.g., 30 seconds). The isolation time is calculated as: k \* base_ejection_time (with k initially set to 1). Each subsequent isolation increases the isolation time (k is incremented by 1), while consecutive healthy checks gradually decrease the isolation time (k is decremented by 1).</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("baseEjectionTime")]
            [Validation(Required=false)]
            public int? BaseEjectionTime { get; set; }

            /// <summary>
            /// <para>enable</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>The panic threshold.</para>
            /// <para>When the proportion of healthy nodes in the service is greater than the panic threshold, health checks take effect normally, and requests are only sent to healthy nodes, not to ejected nodes. When the proportion of healthy nodes in the service is less than or equal to the panic threshold, health checks are effectively disabled, and requests are sent to all nodes, including those that have been ejected nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("failurePercentageMinimumHosts")]
            [Validation(Required=false)]
            public int? FailurePercentageMinimumHosts { get; set; }

            /// <summary>
            /// <para>When the request failure rate of a node reaches this threshold, the system triggers the isolation mechanism of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("failurePercentageThreshold")]
            [Validation(Required=false)]
            public int? FailurePercentageThreshold { get; set; }

            /// <summary>
            /// <para>The detection interval.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

        }

        /// <summary>
        /// <para>The port information.</para>
        /// </summary>
        [NameInMap("ports")]
        [Validation(Required=false)]
        public List<UpdateServiceRequestPorts> Ports { get; set; }
        public class UpdateServiceRequestPorts : TeaModel {
            /// <summary>
            /// <para>The port name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>catalog</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The protocol.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TCP|UDP</para>
            /// </summary>
            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

        }

        /// <summary>
        /// <para>The service protocol.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

    }

}
