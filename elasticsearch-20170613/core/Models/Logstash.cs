/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class Logstash : TeaModel {
        /// <summary>
        /// Config
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public Dictionary<string, string> Config { get; set; }

        /// <summary>
        /// CreatedAt
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// DataNode
        /// </summary>
        [NameInMap("dataNode")]
        [Validation(Required=false)]
        public bool? DataNode { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// EndTime
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// EndpointList
        /// </summary>
        [NameInMap("endpointList")]
        [Validation(Required=false)]
        public List<LogstashEndpointList> EndpointList { get; set; }
        public class LogstashEndpointList : TeaModel {
            /// <summary>
            /// Host
            /// </summary>
            [NameInMap("host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            /// <summary>
            /// Port
            /// </summary>
            [NameInMap("port")]
            [Validation(Required=false)]
            public long? Port { get; set; }

            /// <summary>
            /// ZoneId
            /// </summary>
            [NameInMap("zoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// InstanceId
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// NetworkConfig
        /// </summary>
        [NameInMap("networkConfig")]
        [Validation(Required=false)]
        public LogstashNetworkConfig NetworkConfig { get; set; }
        public class LogstashNetworkConfig : TeaModel {
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("vpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }
            [NameInMap("vsArea")]
            [Validation(Required=false)]
            public string VsArea { get; set; }
            [NameInMap("vswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }
        };

        /// <summary>
        /// NodeAmount
        /// </summary>
        [NameInMap("nodeAmount")]
        [Validation(Required=false)]
        public long? NodeAmount { get; set; }

        /// <summary>
        /// NodeSpec
        /// </summary>
        [NameInMap("nodeSpec")]
        [Validation(Required=false)]
        public LogstashNodeSpec NodeSpec { get; set; }
        public class LogstashNodeSpec : TeaModel {
            [NameInMap("disk")]
            [Validation(Required=false)]
            public long? Disk { get; set; }
            [NameInMap("diskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }
            [NameInMap("spec")]
            [Validation(Required=false)]
            public string Spec { get; set; }
        };

        /// <summary>
        /// PaymentType
        /// </summary>
        [NameInMap("paymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// Protocol
        /// </summary>
        [NameInMap("protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// ResourceGroupId
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// Tags
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<LogstashTags> Tags { get; set; }
        public class LogstashTags : TeaModel {
            /// <summary>
            /// TagKey
            /// </summary>
            [NameInMap("tagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// TagValue
            /// </summary>
            [NameInMap("tagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

        /// <summary>
        /// UpdatedAt
        /// </summary>
        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Version
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        /// <summary>
        /// ZoneCount
        /// </summary>
        [NameInMap("zoneCount")]
        [Validation(Required=false)]
        public long? ZoneCount { get; set; }

        /// <summary>
        /// ZoneInfos
        /// </summary>
        [NameInMap("zoneInfos")]
        [Validation(Required=false)]
        public List<LogstashZoneInfos> ZoneInfos { get; set; }
        public class LogstashZoneInfos : TeaModel {
            /// <summary>
            /// Status
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// ZoneId
            /// </summary>
            [NameInMap("zoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
