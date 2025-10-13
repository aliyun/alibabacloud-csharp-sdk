// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class Service : TeaModel {
        [NameInMap("addresses")]
        [Validation(Required=false)]
        public List<string> Addresses { get; set; }

        [NameInMap("agentServiceConfig")]
        [Validation(Required=false)]
        public AgentServiceConfig AgentServiceConfig { get; set; }

        [NameInMap("aiServiceConfig")]
        [Validation(Required=false)]
        public AiServiceConfig AiServiceConfig { get; set; }

        [NameInMap("createTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>StartExecution</para>
        /// </summary>
        [NameInMap("expressType")]
        [Validation(Required=false)]
        public string ExpressType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>gw-xxxx</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>publich</para>
        /// </summary>
        [NameInMap("groupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("healthCheck")]
        [Validation(Required=false)]
        public ServiceHealthCheck HealthCheck { get; set; }

        [NameInMap("healthStatus")]
        [Validation(Required=false)]
        public string HealthStatus { get; set; }

        [NameInMap("labelDetails")]
        [Validation(Required=false)]
        public List<LabelDetail> LabelDetails { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("outlierEndpoints")]
        [Validation(Required=false)]
        public List<string> OutlierEndpoints { get; set; }

        [NameInMap("ports")]
        [Validation(Required=false)]
        public List<ServicePorts> Ports { get; set; }
        public class ServicePorts : TeaModel {
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>LATEST</para>
        /// </summary>
        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg-xxx</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("serviceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        [NameInMap("unhealthyEndpoints")]
        [Validation(Required=false)]
        public List<string> UnhealthyEndpoints { get; set; }

        [NameInMap("updateTimestamp")]
        [Validation(Required=false)]
        public long? UpdateTimestamp { get; set; }

    }

}
