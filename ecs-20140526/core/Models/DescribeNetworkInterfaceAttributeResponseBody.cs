// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeNetworkInterfaceAttributeResponseBody : TeaModel {
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        [NameInMap("ServiceManaged")]
        [Validation(Required=false)]
        public bool? ServiceManaged { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        [NameInMap("NetworkInterfaceName")]
        [Validation(Required=false)]
        public string NetworkInterfaceName { get; set; }

        [NameInMap("Attachment")]
        [Validation(Required=false)]
        public DescribeNetworkInterfaceAttributeResponseBodyAttachment Attachment { get; set; }
        public class DescribeNetworkInterfaceAttributeResponseBodyAttachment : TeaModel {
            [NameInMap("DeviceIndex")]
            [Validation(Required=false)]
            public int? DeviceIndex { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("MemberNetworkInterfaceIds")]
            [Validation(Required=false)]
            public List<string> MemberNetworkInterfaceIds { get; set; }
            [NameInMap("TrunkNetworkInterfaceId")]
            [Validation(Required=false)]
            public string TrunkNetworkInterfaceId { get; set; }
        };

        [NameInMap("MacAddress")]
        [Validation(Required=false)]
        public string MacAddress { get; set; }

        [NameInMap("NetworkInterfaceId")]
        [Validation(Required=false)]
        public string NetworkInterfaceId { get; set; }

        [NameInMap("SecurityGroupIds")]
        [Validation(Required=false)]
        public List<string> SecurityGroupIds { get; set; }

        [NameInMap("ServiceID")]
        [Validation(Required=false)]
        public long? ServiceID { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("QueueNumber")]
        [Validation(Required=false)]
        public int? QueueNumber { get; set; }

        [NameInMap("Ipv6Sets")]
        [Validation(Required=false)]
        public List<DescribeNetworkInterfaceAttributeResponseBodyIpv6Sets> Ipv6Sets { get; set; }
        public class DescribeNetworkInterfaceAttributeResponseBodyIpv6Sets : TeaModel {
            [NameInMap("Ipv6Address")]
            [Validation(Required=false)]
            public string Ipv6Address { get; set; }

        }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("AssociatedPublicIp")]
        [Validation(Required=false)]
        public DescribeNetworkInterfaceAttributeResponseBodyAssociatedPublicIp AssociatedPublicIp { get; set; }
        public class DescribeNetworkInterfaceAttributeResponseBodyAssociatedPublicIp : TeaModel {
            [NameInMap("AllocationId")]
            [Validation(Required=false)]
            public string AllocationId { get; set; }
            [NameInMap("PublicIpAddress")]
            [Validation(Required=false)]
            public string PublicIpAddress { get; set; }
        };

        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<DescribeNetworkInterfaceAttributeResponseBodyTags> Tags { get; set; }
        public class DescribeNetworkInterfaceAttributeResponseBodyTags : TeaModel {
            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

        }

        [NameInMap("PrivateIpSets")]
        [Validation(Required=false)]
        public List<DescribeNetworkInterfaceAttributeResponseBodyPrivateIpSets> PrivateIpSets { get; set; }
        public class DescribeNetworkInterfaceAttributeResponseBodyPrivateIpSets : TeaModel {
            [NameInMap("AssociatedPublicIp")]
            [Validation(Required=false)]
            public DescribeNetworkInterfaceAttributeResponseBodyPrivateIpSetsAssociatedPublicIp AssociatedPublicIp { get; set; }
            public class DescribeNetworkInterfaceAttributeResponseBodyPrivateIpSetsAssociatedPublicIp : TeaModel {
                [NameInMap("AllocationId")]
                [Validation(Required=false)]
                public string AllocationId { get; set; }
                [NameInMap("PublicIpAddress")]
                [Validation(Required=false)]
                public string PublicIpAddress { get; set; }
            };

            [NameInMap("Primary")]
            [Validation(Required=false)]
            public bool? Primary { get; set; }

            [NameInMap("PrivateIpAddress")]
            [Validation(Required=false)]
            public string PrivateIpAddress { get; set; }

        }

    }

}
