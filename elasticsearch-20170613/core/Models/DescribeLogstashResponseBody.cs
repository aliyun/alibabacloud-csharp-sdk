// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DescribeLogstashResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeLogstashResponseBodyResult Result { get; set; }
        public class DescribeLogstashResponseBodyResult : TeaModel {
            [NameInMap("ExtendConfigs")]
            [Validation(Required=false)]
            public List<string> ExtendConfigs { get; set; }
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeLogstashResponseBodyResultTags> Tags { get; set; }
            public class DescribeLogstashResponseBodyResultTags : TeaModel {
                public string TagKey { get; set; }
                public string TagValue { get; set; }
            }
            [NameInMap("ZoneInfos")]
            [Validation(Required=false)]
            public List<DescribeLogstashResponseBodyResultZoneInfos> ZoneInfos { get; set; }
            public class DescribeLogstashResponseBodyResultZoneInfos : TeaModel {
                public string Status { get; set; }
                public string ZoneId { get; set; }
            }
            [NameInMap("config")]
            [Validation(Required=false)]
            public Dictionary<string, string> Config { get; set; }
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("endpointList")]
            [Validation(Required=false)]
            public List<DescribeLogstashResponseBodyResultEndpointList> EndpointList { get; set; }
            public class DescribeLogstashResponseBodyResultEndpointList : TeaModel {
                public string ZoneId { get; set; }
                public string Port { get; set; }
                public string Host { get; set; }
            }
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("networkConfig")]
            [Validation(Required=false)]
            public DescribeLogstashResponseBodyResultNetworkConfig NetworkConfig { get; set; }
            public class DescribeLogstashResponseBodyResultNetworkConfig : TeaModel {
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
            public int? NodeAmount { get; set; }
            [NameInMap("nodeSpec")]
            [Validation(Required=false)]
            public DescribeLogstashResponseBodyResultNodeSpec NodeSpec { get; set; }
            public class DescribeLogstashResponseBodyResultNodeSpec : TeaModel {
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                [NameInMap("diskEncryption")]
                [Validation(Required=false)]
                public bool? DiskEncryption { get; set; }

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
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }
            [NameInMap("vpcInstanceId")]
            [Validation(Required=false)]
            public string VpcInstanceId { get; set; }
        };

    }

}
