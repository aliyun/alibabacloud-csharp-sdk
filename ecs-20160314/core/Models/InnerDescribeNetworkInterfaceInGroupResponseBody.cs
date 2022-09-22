// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class InnerDescribeNetworkInterfaceInGroupResponseBody : TeaModel {
        [NameInMap("NetworkInterfaceSets")]
        [Validation(Required=false)]
        public InnerDescribeNetworkInterfaceInGroupResponseBodyNetworkInterfaceSets NetworkInterfaceSets { get; set; }
        public class InnerDescribeNetworkInterfaceInGroupResponseBodyNetworkInterfaceSets : TeaModel {
            [NameInMap("NetworkInterfaceSet")]
            [Validation(Required=false)]
            public List<InnerDescribeNetworkInterfaceInGroupResponseBodyNetworkInterfaceSetsNetworkInterfaceSet> NetworkInterfaceSet { get; set; }
            public class InnerDescribeNetworkInterfaceInGroupResponseBodyNetworkInterfaceSetsNetworkInterfaceSet : TeaModel {
                [NameInMap("AssociatedPublicIp")]
                [Validation(Required=false)]
                public InnerDescribeNetworkInterfaceInGroupResponseBodyNetworkInterfaceSetsNetworkInterfaceSetAssociatedPublicIp AssociatedPublicIp { get; set; }
                public class InnerDescribeNetworkInterfaceInGroupResponseBodyNetworkInterfaceSetsNetworkInterfaceSetAssociatedPublicIp : TeaModel {
                    [NameInMap("AllocationId")]
                    [Validation(Required=false)]
                    public string AllocationId { get; set; }

                    [NameInMap("PublicIpAddress")]
                    [Validation(Required=false)]
                    public string PublicIpAddress { get; set; }

                }

                [NameInMap("Attachment")]
                [Validation(Required=false)]
                public InnerDescribeNetworkInterfaceInGroupResponseBodyNetworkInterfaceSetsNetworkInterfaceSetAttachment Attachment { get; set; }
                public class InnerDescribeNetworkInterfaceInGroupResponseBodyNetworkInterfaceSetsNetworkInterfaceSetAttachment : TeaModel {
                    [NameInMap("DeviceIndex")]
                    [Validation(Required=false)]
                    public int? DeviceIndex { get; set; }

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("TrunkNetworkInterfaceId")]
                    [Validation(Required=false)]
                    public string TrunkNetworkInterfaceId { get; set; }

                }

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
                public InnerDescribeNetworkInterfaceInGroupResponseBodyNetworkInterfaceSetsNetworkInterfaceSetIpv6Sets Ipv6Sets { get; set; }
                public class InnerDescribeNetworkInterfaceInGroupResponseBodyNetworkInterfaceSetsNetworkInterfaceSetIpv6Sets : TeaModel {
                    [NameInMap("Ipv6Set")]
                    [Validation(Required=false)]
                    public List<InnerDescribeNetworkInterfaceInGroupResponseBodyNetworkInterfaceSetsNetworkInterfaceSetIpv6SetsIpv6Set> Ipv6Set { get; set; }
                    public class InnerDescribeNetworkInterfaceInGroupResponseBodyNetworkInterfaceSetsNetworkInterfaceSetIpv6SetsIpv6Set : TeaModel {
                        [NameInMap("Ipv6Address")]
                        [Validation(Required=false)]
                        public string Ipv6Address { get; set; }

                    }

                }

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
                public InnerDescribeNetworkInterfaceInGroupResponseBodyNetworkInterfaceSetsNetworkInterfaceSetPrivateIpSets PrivateIpSets { get; set; }
                public class InnerDescribeNetworkInterfaceInGroupResponseBodyNetworkInterfaceSetsNetworkInterfaceSetPrivateIpSets : TeaModel {
                    [NameInMap("PrivateIpSet")]
                    [Validation(Required=false)]
                    public List<InnerDescribeNetworkInterfaceInGroupResponseBodyNetworkInterfaceSetsNetworkInterfaceSetPrivateIpSetsPrivateIpSet> PrivateIpSet { get; set; }
                    public class InnerDescribeNetworkInterfaceInGroupResponseBodyNetworkInterfaceSetsNetworkInterfaceSetPrivateIpSetsPrivateIpSet : TeaModel {
                        [NameInMap("AssociatedPublicIp")]
                        [Validation(Required=false)]
                        public InnerDescribeNetworkInterfaceInGroupResponseBodyNetworkInterfaceSetsNetworkInterfaceSetPrivateIpSetsPrivateIpSetAssociatedPublicIp AssociatedPublicIp { get; set; }
                        public class InnerDescribeNetworkInterfaceInGroupResponseBodyNetworkInterfaceSetsNetworkInterfaceSetPrivateIpSetsPrivateIpSetAssociatedPublicIp : TeaModel {
                            [NameInMap("AllocationId")]
                            [Validation(Required=false)]
                            public string AllocationId { get; set; }

                            [NameInMap("PublicIpAddress")]
                            [Validation(Required=false)]
                            public string PublicIpAddress { get; set; }

                        }

                        [NameInMap("Primary")]
                        [Validation(Required=false)]
                        public bool? Primary { get; set; }

                        [NameInMap("PrivateIpAddress")]
                        [Validation(Required=false)]
                        public string PrivateIpAddress { get; set; }

                    }

                }

                [NameInMap("QueueNumber")]
                [Validation(Required=false)]
                public int? QueueNumber { get; set; }

                [NameInMap("QueuePairNumber")]
                [Validation(Required=false)]
                public int? QueuePairNumber { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("SecurityGroupIds")]
                [Validation(Required=false)]
                public InnerDescribeNetworkInterfaceInGroupResponseBodyNetworkInterfaceSetsNetworkInterfaceSetSecurityGroupIds SecurityGroupIds { get; set; }
                public class InnerDescribeNetworkInterfaceInGroupResponseBodyNetworkInterfaceSetsNetworkInterfaceSetSecurityGroupIds : TeaModel {
                    [NameInMap("SecurityGroupId")]
                    [Validation(Required=false)]
                    public List<string> SecurityGroupId { get; set; }

                }

                [NameInMap("ServiceID")]
                [Validation(Required=false)]
                public long? ServiceID { get; set; }

                [NameInMap("ServiceManaged")]
                [Validation(Required=false)]
                public bool? ServiceManaged { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public InnerDescribeNetworkInterfaceInGroupResponseBodyNetworkInterfaceSetsNetworkInterfaceSetTags Tags { get; set; }
                public class InnerDescribeNetworkInterfaceInGroupResponseBodyNetworkInterfaceSetsNetworkInterfaceSetTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<InnerDescribeNetworkInterfaceInGroupResponseBodyNetworkInterfaceSetsNetworkInterfaceSetTagsTag> Tag { get; set; }
                    public class InnerDescribeNetworkInterfaceInGroupResponseBodyNetworkInterfaceSetsNetworkInterfaceSetTagsTag : TeaModel {
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

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

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
