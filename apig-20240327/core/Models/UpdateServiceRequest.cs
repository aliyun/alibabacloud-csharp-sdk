// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateServiceRequest : TeaModel {
        [NameInMap("addresses")]
        [Validation(Required=false)]
        public List<string> Addresses { get; set; }

        [NameInMap("agentServiceConfig")]
        [Validation(Required=false)]
        public AgentServiceConfig AgentServiceConfig { get; set; }

        [NameInMap("aiServiceConfig")]
        [Validation(Required=false)]
        public AiServiceConfig AiServiceConfig { get; set; }

        [NameInMap("dnsServers")]
        [Validation(Required=false)]
        public List<string> DnsServers { get; set; }

        [NameInMap("healthCheckConfig")]
        [Validation(Required=false)]
        public UpdateServiceRequestHealthCheckConfig HealthCheckConfig { get; set; }
        public class UpdateServiceRequestHealthCheckConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            [NameInMap("expectedStatuses")]
            [Validation(Required=false)]
            public List<string> ExpectedStatuses { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("healthyThreshold")]
            [Validation(Required=false)]
            public int? HealthyThreshold { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dev.itemcener.com</para>
            /// </summary>
            [NameInMap("httpHost")]
            [Validation(Required=false)]
            public string HttpHost { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>/healthz</para>
            /// </summary>
            [NameInMap("httpPath")]
            [Validation(Required=false)]
            public string HttpPath { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("timeout")]
            [Validation(Required=false)]
            public int? Timeout { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("unhealthyThreshold")]
            [Validation(Required=false)]
            public int? UnhealthyThreshold { get; set; }

        }

        [NameInMap("healthyPanicThreshold")]
        [Validation(Required=false)]
        public float? HealthyPanicThreshold { get; set; }

        [NameInMap("outlierDetectionConfig")]
        [Validation(Required=false)]
        public UpdateServiceRequestOutlierDetectionConfig OutlierDetectionConfig { get; set; }
        public class UpdateServiceRequestOutlierDetectionConfig : TeaModel {
            [NameInMap("baseEjectionTime")]
            [Validation(Required=false)]
            public int? BaseEjectionTime { get; set; }

            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            [NameInMap("failurePercentageMinimumHosts")]
            [Validation(Required=false)]
            public int? FailurePercentageMinimumHosts { get; set; }

            [NameInMap("failurePercentageThreshold")]
            [Validation(Required=false)]
            public int? FailurePercentageThreshold { get; set; }

            [NameInMap("interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

        }

        [NameInMap("ports")]
        [Validation(Required=false)]
        public List<UpdateServiceRequestPorts> Ports { get; set; }
        public class UpdateServiceRequestPorts : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

    }

}
