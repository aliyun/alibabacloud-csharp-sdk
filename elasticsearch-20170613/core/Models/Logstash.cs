// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class Logstash : TeaModel {
        [NameInMap("config")]
        [Validation(Required=false)]
        public Dictionary<string, string> Config { get; set; }

        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("dataNode")]
        [Validation(Required=false)]
        public bool? DataNode { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("endpointList")]
        [Validation(Required=false)]
        public List<LogstashEndpointList> EndpointList { get; set; }
        public class LogstashEndpointList : TeaModel {
            [NameInMap("host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            [NameInMap("port")]
            [Validation(Required=false)]
            public long? Port { get; set; }

            [NameInMap("zoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

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

        }

        [NameInMap("nodeAmount")]
        [Validation(Required=false)]
        public long? NodeAmount { get; set; }

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

        }

        [NameInMap("paymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        [NameInMap("protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<LogstashTags> Tags { get; set; }
        public class LogstashTags : TeaModel {
            [NameInMap("tagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            [NameInMap("tagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        [NameInMap("zoneCount")]
        [Validation(Required=false)]
        public long? ZoneCount { get; set; }

        [NameInMap("zoneInfos")]
        [Validation(Required=false)]
        public List<LogstashZoneInfos> ZoneInfos { get; set; }
        public class LogstashZoneInfos : TeaModel {
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("zoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
