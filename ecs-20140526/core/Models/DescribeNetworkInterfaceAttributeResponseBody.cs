// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeNetworkInterfaceAttributeResponseBody : TeaModel {
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
            public DescribeNetworkInterfaceAttributeResponseBodyAttachmentMemberNetworkInterfaceIds MemberNetworkInterfaceIds { get; set; }
            public class DescribeNetworkInterfaceAttributeResponseBodyAttachmentMemberNetworkInterfaceIds : TeaModel {
                [NameInMap("MemberNetworkInterfaceId")]
                [Validation(Required=false)]
                public List<string> MemberNetworkInterfaceId { get; set; }

            }
            [NameInMap("TrunkNetworkInterfaceId")]
            [Validation(Required=false)]
            public string TrunkNetworkInterfaceId { get; set; }
        };

        [NameInMap("BondInterfaceSpecification")]
        [Validation(Required=false)]
        public DescribeNetworkInterfaceAttributeResponseBodyBondInterfaceSpecification BondInterfaceSpecification { get; set; }
        public class DescribeNetworkInterfaceAttributeResponseBodyBondInterfaceSpecification : TeaModel {
            [NameInMap("BondMode")]
            [Validation(Required=false)]
            public string BondMode { get; set; }
            [NameInMap("SlaveInterfaceSpecification")]
            [Validation(Required=false)]
            public DescribeNetworkInterfaceAttributeResponseBodyBondInterfaceSpecificationSlaveInterfaceSpecification SlaveInterfaceSpecification { get; set; }
            public class DescribeNetworkInterfaceAttributeResponseBodyBondInterfaceSpecificationSlaveInterfaceSpecification : TeaModel {
                [NameInMap("SlaveInterfaceSpecificationSet")]
                [Validation(Required=false)]
                public List<DescribeNetworkInterfaceAttributeResponseBodyBondInterfaceSpecificationSlaveInterfaceSpecificationSlaveInterfaceSpecificationSet> SlaveInterfaceSpecificationSet { get; set; }
                public class DescribeNetworkInterfaceAttributeResponseBodyBondInterfaceSpecificationSlaveInterfaceSpecificationSlaveInterfaceSpecificationSet : TeaModel {
                    [NameInMap("BondNetworkInterfaceId")]
                    [Validation(Required=false)]
                    public string BondNetworkInterfaceId { get; set; }

                    [NameInMap("SlaveNetworkInterfaceId")]
                    [Validation(Required=false)]
                    public string SlaveNetworkInterfaceId { get; set; }

                    [NameInMap("WorkState")]
                    [Validation(Required=false)]
                    public string WorkState { get; set; }

                }

            }
        };

        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Ipv6Sets")]
        [Validation(Required=false)]
        public DescribeNetworkInterfaceAttributeResponseBodyIpv6Sets Ipv6Sets { get; set; }
        public class DescribeNetworkInterfaceAttributeResponseBodyIpv6Sets : TeaModel {
            [NameInMap("Ipv6Set")]
            [Validation(Required=false)]
            public List<DescribeNetworkInterfaceAttributeResponseBodyIpv6SetsIpv6Set> Ipv6Set { get; set; }
            public class DescribeNetworkInterfaceAttributeResponseBodyIpv6SetsIpv6Set : TeaModel {
                public string Ipv6Address { get; set; }
            }
        };

        [NameInMap("MacAddress")]
        [Validation(Required=false)]
        public string MacAddress { get; set; }

        [NameInMap("NetworkInterfaceId")]
        [Validation(Required=false)]
        public string NetworkInterfaceId { get; set; }

        [NameInMap("NetworkInterfaceName")]
        [Validation(Required=false)]
        public string NetworkInterfaceName { get; set; }

        [NameInMap("NetworkInterfaceTrafficMode")]
        [Validation(Required=false)]
        public string NetworkInterfaceTrafficMode { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        [NameInMap("PrivateIpSets")]
        [Validation(Required=false)]
        public DescribeNetworkInterfaceAttributeResponseBodyPrivateIpSets PrivateIpSets { get; set; }
        public class DescribeNetworkInterfaceAttributeResponseBodyPrivateIpSets : TeaModel {
            [NameInMap("PrivateIpSet")]
            [Validation(Required=false)]
            public List<DescribeNetworkInterfaceAttributeResponseBodyPrivateIpSetsPrivateIpSet> PrivateIpSet { get; set; }
            public class DescribeNetworkInterfaceAttributeResponseBodyPrivateIpSetsPrivateIpSet : TeaModel {
                public DescribeNetworkInterfaceAttributeResponseBodyPrivateIpSetsPrivateIpSetAssociatedPublicIp AssociatedPublicIp { get; set; }
                public class DescribeNetworkInterfaceAttributeResponseBodyPrivateIpSetsPrivateIpSetAssociatedPublicIp : TeaModel {
                    [NameInMap("AllocationId")]
                    [Validation(Required=false)]
                    public string AllocationId { get; set; }

                    [NameInMap("PublicIpAddress")]
                    [Validation(Required=false)]
                    public string PublicIpAddress { get; set; }

                }
                public bool? Primary { get; set; }
                public string PrivateIpAddress { get; set; }
            }
        };

        [NameInMap("QueueNumber")]
        [Validation(Required=false)]
        public int? QueueNumber { get; set; }

        [NameInMap("QueuePairNumber")]
        [Validation(Required=false)]
        public int? QueuePairNumber { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("SecurityGroupIds")]
        [Validation(Required=false)]
        public DescribeNetworkInterfaceAttributeResponseBodySecurityGroupIds SecurityGroupIds { get; set; }
        public class DescribeNetworkInterfaceAttributeResponseBodySecurityGroupIds : TeaModel {
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public List<string> SecurityGroupId { get; set; }
        };

        [NameInMap("ServiceID")]
        [Validation(Required=false)]
        public long? ServiceID { get; set; }

        [NameInMap("ServiceManaged")]
        [Validation(Required=false)]
        public bool? ServiceManaged { get; set; }

        [NameInMap("SlaveInterfaceSpecification")]
        [Validation(Required=false)]
        public DescribeNetworkInterfaceAttributeResponseBodySlaveInterfaceSpecification SlaveInterfaceSpecification { get; set; }
        public class DescribeNetworkInterfaceAttributeResponseBodySlaveInterfaceSpecification : TeaModel {
            [NameInMap("BondNetworkInterfaceId")]
            [Validation(Required=false)]
            public string BondNetworkInterfaceId { get; set; }
            [NameInMap("SlaveNetworkInterfaceId")]
            [Validation(Required=false)]
            public string SlaveNetworkInterfaceId { get; set; }
            [NameInMap("WorkState")]
            [Validation(Required=false)]
            public string WorkState { get; set; }
        };

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public DescribeNetworkInterfaceAttributeResponseBodyTags Tags { get; set; }
        public class DescribeNetworkInterfaceAttributeResponseBodyTags : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<DescribeNetworkInterfaceAttributeResponseBodyTagsTag> Tag { get; set; }
            public class DescribeNetworkInterfaceAttributeResponseBodyTagsTag : TeaModel {
                public string TagKey { get; set; }
                public string TagValue { get; set; }
            }
        };

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
