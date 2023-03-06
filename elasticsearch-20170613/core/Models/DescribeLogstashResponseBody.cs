// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DescribeLogstashResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Detailed information about the instance.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeLogstashResponseBodyResult Result { get; set; }
        public class DescribeLogstashResponseBodyResult : TeaModel {
            /// <summary>
            /// The configuration of cluster extension parameters.
            /// </summary>
            [NameInMap("ExtendConfigs")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> ExtendConfigs { get; set; }

            /// <summary>
            /// The ID of the resource group to which the instance belongs.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The tags added to the ALB instance.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeLogstashResponseBodyResultTags> Tags { get; set; }
            public class DescribeLogstashResponseBodyResultTags : TeaModel {
                /// <summary>
                /// The key of the tag.
                /// </summary>
                [NameInMap("tagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// The value of the tag.
                /// </summary>
                [NameInMap("tagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// The information about the zones.
            /// </summary>
            [NameInMap("ZoneInfos")]
            [Validation(Required=false)]
            public List<DescribeLogstashResponseBodyResultZoneInfos> ZoneInfos { get; set; }
            public class DescribeLogstashResponseBodyResultZoneInfos : TeaModel {
                /// <summary>
                /// The status of the zone. Valid values:
                /// 
                /// *   ISOLATION: offline
                /// *   NORMAL
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The zone ID of the new instance.
                /// </summary>
                [NameInMap("zoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

            /// <summary>
            /// The configurations of the instance.
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public Dictionary<string, object> Config { get; set; }

            /// <summary>
            /// The time when the instance was created.
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// The name of the instance.
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The access information of the node.
            /// </summary>
            [NameInMap("endpointList")]
            [Validation(Required=false)]
            public List<DescribeLogstashResponseBodyResultEndpointList> EndpointList { get; set; }
            public class DescribeLogstashResponseBodyResultEndpointList : TeaModel {
                /// <summary>
                /// The IP address of the node.
                /// </summary>
                [NameInMap("host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// The port number.
                /// </summary>
                [NameInMap("port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// The ID of the zone where the node resides.
                /// </summary>
                [NameInMap("zoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The network configurations.
            /// </summary>
            [NameInMap("networkConfig")]
            [Validation(Required=false)]
            public DescribeLogstashResponseBodyResultNetworkConfig NetworkConfig { get; set; }
            public class DescribeLogstashResponseBodyResultNetworkConfig : TeaModel {
                /// <summary>
                /// The network type of the instance. Valid values: Currently, only Virtual Private Cloud (VPC) are supported.
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The ID of the virtual private cloud (VPC).
                /// </summary>
                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// The zone where the cluster resides.
                /// </summary>
                [NameInMap("vsArea")]
                [Validation(Required=false)]
                public string VsArea { get; set; }

                /// <summary>
                /// The ID of the vSwitch to which the instance is connected.
                /// </summary>
                [NameInMap("vswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

            }

            /// <summary>
            /// The number of data nodes.
            /// </summary>
            [NameInMap("nodeAmount")]
            [Validation(Required=false)]
            public int? NodeAmount { get; set; }

            /// <summary>
            /// The configuration information of the node.
            /// </summary>
            [NameInMap("nodeSpec")]
            [Validation(Required=false)]
            public DescribeLogstashResponseBodyResultNodeSpec NodeSpec { get; set; }
            public class DescribeLogstashResponseBodyResultNodeSpec : TeaModel {
                /// <summary>
                /// The disk size of the node.
                /// </summary>
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                /// <summary>
                /// Whether to use disk encryption:
                /// 
                /// *   true
                /// *   false
                /// </summary>
                [NameInMap("diskEncryption")]
                [Validation(Required=false)]
                public bool? DiskEncryption { get; set; }

                /// <summary>
                /// The disk type of the node.
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// The specifications of the node.
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

            }

            /// <summary>
            /// The billing method of the instance. Valid values:
            /// 
            /// *   prepaid: subscription
            /// *   postpaid: pay-as-you-go
            /// </summary>
            [NameInMap("paymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }

            /// <summary>
            /// The state of the instance. Four states are supported:
            /// 
            /// *   Normal: active
            /// *   Active: activating
            /// *   Freeze: inactive
            /// *   Invalid: invalid
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The time when the instance was last updated.
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// The edition of the dedicated KMS instance.
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// The ID of the virtual private cloud (VPC) to which the elastic container instances belong.
            /// </summary>
            [NameInMap("vpcInstanceId")]
            [Validation(Required=false)]
            public string VpcInstanceId { get; set; }

        }

    }

}
