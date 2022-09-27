// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeNetworkInterfacesResponseBody : TeaModel {
        [NameInMap("NetworkInterfaceSets")]
        [Validation(Required=false)]
        public DescribeNetworkInterfacesResponseBodyNetworkInterfaceSets NetworkInterfaceSets { get; set; }
        public class DescribeNetworkInterfacesResponseBodyNetworkInterfaceSets : TeaModel {
            [NameInMap("NetworkInterfaceSet")]
            [Validation(Required=false)]
            public List<DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSet> NetworkInterfaceSet { get; set; }
            public class DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSet : TeaModel {
                [NameInMap("AssociatedPublicIp")]
                [Validation(Required=false)]
                public DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetAssociatedPublicIp AssociatedPublicIp { get; set; }
                public class DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetAssociatedPublicIp : TeaModel {
                    [NameInMap("AllocationId")]
                    [Validation(Required=false)]
                    public string AllocationId { get; set; }

                    [NameInMap("PublicIpAddress")]
                    [Validation(Required=false)]
                    public string PublicIpAddress { get; set; }

                }

                [NameInMap("Attachment")]
                [Validation(Required=false)]
                public DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetAttachment Attachment { get; set; }
                public class DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetAttachment : TeaModel {
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
                public DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetIpv6Sets Ipv6Sets { get; set; }
                public class DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetIpv6Sets : TeaModel {
                    [NameInMap("Ipv6Set")]
                    [Validation(Required=false)]
                    public List<DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetIpv6SetsIpv6Set> Ipv6Set { get; set; }
                    public class DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetIpv6SetsIpv6Set : TeaModel {
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
                public DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetPrivateIpSets PrivateIpSets { get; set; }
                public class DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetPrivateIpSets : TeaModel {
                    [NameInMap("PrivateIpSet")]
                    [Validation(Required=false)]
                    public List<DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetPrivateIpSetsPrivateIpSet> PrivateIpSet { get; set; }
                    public class DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetPrivateIpSetsPrivateIpSet : TeaModel {
                        [NameInMap("AssociatedPublicIp")]
                        [Validation(Required=false)]
                        public DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetPrivateIpSetsPrivateIpSetAssociatedPublicIp AssociatedPublicIp { get; set; }
                        public class DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetPrivateIpSetsPrivateIpSetAssociatedPublicIp : TeaModel {
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
                public DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetSecurityGroupIds SecurityGroupIds { get; set; }
                public class DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetSecurityGroupIds : TeaModel {
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
                public DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetTags Tags { get; set; }
                public class DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetTagsTag> Tag { get; set; }
                    public class DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetTagsTag : TeaModel {
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

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
