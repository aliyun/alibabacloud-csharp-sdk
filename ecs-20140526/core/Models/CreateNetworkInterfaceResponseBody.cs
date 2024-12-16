// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateNetworkInterfaceResponseBody : TeaModel {
        /// <summary>
        /// <para>The description of the ENI.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The IPv4 prefixes assigned to the ENI.</para>
        /// </summary>
        [NameInMap("Ipv4PrefixSets")]
        [Validation(Required=false)]
        public CreateNetworkInterfaceResponseBodyIpv4PrefixSets Ipv4PrefixSets { get; set; }
        public class CreateNetworkInterfaceResponseBodyIpv4PrefixSets : TeaModel {
            [NameInMap("Ipv4PrefixSet")]
            [Validation(Required=false)]
            public List<CreateNetworkInterfaceResponseBodyIpv4PrefixSetsIpv4PrefixSet> Ipv4PrefixSet { get; set; }
            public class CreateNetworkInterfaceResponseBodyIpv4PrefixSetsIpv4PrefixSet : TeaModel {
                /// <summary>
                /// <para>The IPv4 prefix assigned to the ENI.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hide</para>
                /// </summary>
                [NameInMap("Ipv4Prefix")]
                [Validation(Required=false)]
                public string Ipv4Prefix { get; set; }

            }

        }

        /// <summary>
        /// <para>The IPv6 prefixes assigned to the ENI.</para>
        /// </summary>
        [NameInMap("Ipv6PrefixSets")]
        [Validation(Required=false)]
        public CreateNetworkInterfaceResponseBodyIpv6PrefixSets Ipv6PrefixSets { get; set; }
        public class CreateNetworkInterfaceResponseBodyIpv6PrefixSets : TeaModel {
            [NameInMap("Ipv6PrefixSet")]
            [Validation(Required=false)]
            public List<CreateNetworkInterfaceResponseBodyIpv6PrefixSetsIpv6PrefixSet> Ipv6PrefixSet { get; set; }
            public class CreateNetworkInterfaceResponseBodyIpv6PrefixSetsIpv6PrefixSet : TeaModel {
                /// <summary>
                /// <para>The IPv6 prefix assigned to the ENI.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hide</para>
                /// </summary>
                [NameInMap("Ipv6Prefix")]
                [Validation(Required=false)]
                public string Ipv6Prefix { get; set; }

            }

        }

        /// <summary>
        /// <para>The IPv6 addresses assigned to the ENI.</para>
        /// </summary>
        [NameInMap("Ipv6Sets")]
        [Validation(Required=false)]
        public CreateNetworkInterfaceResponseBodyIpv6Sets Ipv6Sets { get; set; }
        public class CreateNetworkInterfaceResponseBodyIpv6Sets : TeaModel {
            [NameInMap("Ipv6Set")]
            [Validation(Required=false)]
            public List<CreateNetworkInterfaceResponseBodyIpv6SetsIpv6Set> Ipv6Set { get; set; }
            public class CreateNetworkInterfaceResponseBodyIpv6SetsIpv6Set : TeaModel {
                /// <summary>
                /// <para>The IPv6 address assigned to the ENI.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2001:db8:1234:1a00::****</para>
                /// </summary>
                [NameInMap("Ipv6Address")]
                [Validation(Required=false)]
                public string Ipv6Address { get; set; }

            }

        }

        /// <summary>
        /// <para>The media access control (MAC) address of the ENI.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00:16:3e:12:<b>:</b></para>
        /// </summary>
        [NameInMap("MacAddress")]
        [Validation(Required=false)]
        public string MacAddress { get; set; }

        /// <summary>
        /// <para>The ID of the ENI.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eni-bp14v2sdd3v8htln****</para>
        /// </summary>
        [NameInMap("NetworkInterfaceId")]
        [Validation(Required=false)]
        public string NetworkInterfaceId { get; set; }

        /// <summary>
        /// <para>The name of the ENI.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-eni-name</para>
        /// </summary>
        [NameInMap("NetworkInterfaceName")]
        [Validation(Required=false)]
        public string NetworkInterfaceName { get; set; }

        /// <summary>
        /// <para>The ID of the account to which the ENI belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The private IP address of the ENI.</para>
        /// 
        /// <b>Example:</b>
        /// <para><c>172.17.**.**</c></para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The private IP addresses.</para>
        /// </summary>
        [NameInMap("PrivateIpSets")]
        [Validation(Required=false)]
        public CreateNetworkInterfaceResponseBodyPrivateIpSets PrivateIpSets { get; set; }
        public class CreateNetworkInterfaceResponseBodyPrivateIpSets : TeaModel {
            [NameInMap("PrivateIpSet")]
            [Validation(Required=false)]
            public List<CreateNetworkInterfaceResponseBodyPrivateIpSetsPrivateIpSet> PrivateIpSet { get; set; }
            public class CreateNetworkInterfaceResponseBodyPrivateIpSetsPrivateIpSet : TeaModel {
                /// <summary>
                /// <para>Indicates whether the private IP address is the primary private IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Primary")]
                [Validation(Required=false)]
                public bool? Primary { get; set; }

                /// <summary>
                /// <para>The private IP address of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para><c>172.17.**.**</c></para>
                /// </summary>
                [NameInMap("PrivateIpAddress")]
                [Validation(Required=false)]
                public string PrivateIpAddress { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the ENI belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-2ze88m67qx5z****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The IDs of the security groups to which the ENI belongs.</para>
        /// </summary>
        [NameInMap("SecurityGroupIds")]
        [Validation(Required=false)]
        public CreateNetworkInterfaceResponseBodySecurityGroupIds SecurityGroupIds { get; set; }
        public class CreateNetworkInterfaceResponseBodySecurityGroupIds : TeaModel {
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public List<string> SecurityGroupId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the distributor to which the ENI belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678910</para>
        /// </summary>
        [NameInMap("ServiceID")]
        [Validation(Required=false)]
        public long? ServiceID { get; set; }

        /// <summary>
        /// <para>Indicates whether the user of the ENI is an Alibaba Cloud service or a distributor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ServiceManaged")]
        [Validation(Required=false)]
        public bool? ServiceManaged { get; set; }

        /// <summary>
        /// <remarks>
        /// <para> This parameter is in invitational preview and is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SourceDestCheck")]
        [Validation(Required=false)]
        public bool? SourceDestCheck { get; set; }

        /// <summary>
        /// <para>The state of the ENI.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tags of the ENI.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public CreateNetworkInterfaceResponseBodyTags Tags { get; set; }
        public class CreateNetworkInterfaceResponseBodyTags : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<CreateNetworkInterfaceResponseBodyTagsTag> Tag { get; set; }
            public class CreateNetworkInterfaceResponseBodyTagsTag : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestKey</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestValue</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

        /// <summary>
        /// <para>The type of the ENI.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Secondary</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch to which the ENI is connected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp16usj2p27htro3****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC to which the ENI belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1j7w3gc1cexjqd****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The zone ID of the ENI.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-e</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
