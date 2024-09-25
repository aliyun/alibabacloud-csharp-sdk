// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeNetworkAclAttributesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the network ACLs.</para>
        /// </summary>
        [NameInMap("NetworkAclAttribute")]
        [Validation(Required=false)]
        public DescribeNetworkAclAttributesResponseBodyNetworkAclAttribute NetworkAclAttribute { get; set; }
        public class DescribeNetworkAclAttributesResponseBodyNetworkAclAttribute : TeaModel {
            /// <summary>
            /// <para>The time when the network ACL was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-25 11:33:27</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The description of the network ACL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is my NetworkAcl.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The information about the outbound rules of the network ACL.</para>
            /// </summary>
            [NameInMap("EgressAclEntries")]
            [Validation(Required=false)]
            public DescribeNetworkAclAttributesResponseBodyNetworkAclAttributeEgressAclEntries EgressAclEntries { get; set; }
            public class DescribeNetworkAclAttributesResponseBodyNetworkAclAttributeEgressAclEntries : TeaModel {
                [NameInMap("EgressAclEntry")]
                [Validation(Required=false)]
                public List<DescribeNetworkAclAttributesResponseBodyNetworkAclAttributeEgressAclEntriesEgressAclEntry> EgressAclEntry { get; set; }
                public class DescribeNetworkAclAttributesResponseBodyNetworkAclAttributeEgressAclEntriesEgressAclEntry : TeaModel {
                    /// <summary>
                    /// <para>The description of the outbound rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>This is EgressAclEntries.</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The destination CIDR block.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10.0.0.0/24</para>
                    /// </summary>
                    [NameInMap("DestinationCidrIp")]
                    [Validation(Required=false)]
                    public string DestinationCidrIp { get; set; }

                    /// <summary>
                    /// <para>The type of the inbound rule.</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>custom</b></para>
                    /// </description></item>
                    /// <item><description><para><b>system</b></para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>custom</para>
                    /// </summary>
                    [NameInMap("EntryType")]
                    [Validation(Required=false)]
                    public string EntryType { get; set; }

                    /// <summary>
                    /// <para>The IP version. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>IPv4</b></description></item>
                    /// <item><description><b>IPv6</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>IPv4</para>
                    /// </summary>
                    [NameInMap("IpVersion")]
                    [Validation(Required=false)]
                    public string IpVersion { get; set; }

                    /// <summary>
                    /// <para>The ID of the outbound rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>nae-a2d447uw4tillxdcv****</para>
                    /// </summary>
                    [NameInMap("NetworkAclEntryId")]
                    [Validation(Required=false)]
                    public string NetworkAclEntryId { get; set; }

                    /// <summary>
                    /// <para>The name of the outbound rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>acl-2</para>
                    /// </summary>
                    [NameInMap("NetworkAclEntryName")]
                    [Validation(Required=false)]
                    public string NetworkAclEntryName { get; set; }

                    /// <summary>
                    /// <para>The action to be performed on network traffic that matches the rule. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>accept</b></description></item>
                    /// <item><description><b>drop</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>accept</para>
                    /// </summary>
                    [NameInMap("Policy")]
                    [Validation(Required=false)]
                    public string Policy { get; set; }

                    /// <summary>
                    /// <para>The destination port range of the outbound traffic.</para>
                    /// <list type="bullet">
                    /// <item><description>If the <b>protocol</b> of the outbound rule is set to <b>all</b>, <b>icmp</b>, or <b>gre</b>, the port range is -1/-1, which specified all ports.</description></item>
                    /// <item><description>If the <b>protocol</b> of the outbound rule is set to <b>tcp</b> or <b>udp</b>, set the port range in the following format: <b>1/200</b> or <b>80/80</b>, which specifies port 1 to port 200 or port 80. Valid values for a port: <b>1</b> to <b>65535</b>.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>-1/-1</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public string Port { get; set; }

                    /// <summary>
                    /// <para>The protocol type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>icmp</b></description></item>
                    /// <item><description><b>gre</b></description></item>
                    /// <item><description><b>tcp</b></description></item>
                    /// <item><description><b>udp</b></description></item>
                    /// <item><description><b>all</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>all</para>
                    /// </summary>
                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                }

            }

            /// <summary>
            /// <para>The information about the inbound rules of the network ACL.</para>
            /// </summary>
            [NameInMap("IngressAclEntries")]
            [Validation(Required=false)]
            public DescribeNetworkAclAttributesResponseBodyNetworkAclAttributeIngressAclEntries IngressAclEntries { get; set; }
            public class DescribeNetworkAclAttributesResponseBodyNetworkAclAttributeIngressAclEntries : TeaModel {
                [NameInMap("IngressAclEntry")]
                [Validation(Required=false)]
                public List<DescribeNetworkAclAttributesResponseBodyNetworkAclAttributeIngressAclEntriesIngressAclEntry> IngressAclEntry { get; set; }
                public class DescribeNetworkAclAttributesResponseBodyNetworkAclAttributeIngressAclEntriesIngressAclEntry : TeaModel {
                    /// <summary>
                    /// <para>The description of the inbound rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>This is IngressAclEntries.</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The type of the inbound rule.</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>custom</b></para>
                    /// </description></item>
                    /// <item><description><para><b>system</b></para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>custom</para>
                    /// </summary>
                    [NameInMap("EntryType")]
                    [Validation(Required=false)]
                    public string EntryType { get; set; }

                    /// <summary>
                    /// <para>The IP version. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>IPv4</b></description></item>
                    /// <item><description><b>IPv6</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>IPv4</para>
                    /// </summary>
                    [NameInMap("IpVersion")]
                    [Validation(Required=false)]
                    public string IpVersion { get; set; }

                    /// <summary>
                    /// <para>The ID of the inbound rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>nae-a2dk86arlydmevfbg****</para>
                    /// </summary>
                    [NameInMap("NetworkAclEntryId")]
                    [Validation(Required=false)]
                    public string NetworkAclEntryId { get; set; }

                    /// <summary>
                    /// <para>The name of the inbound rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>acl-3</para>
                    /// </summary>
                    [NameInMap("NetworkAclEntryName")]
                    [Validation(Required=false)]
                    public string NetworkAclEntryName { get; set; }

                    /// <summary>
                    /// <para>The action to be performed on network traffic that matches the rule. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>accept</b></description></item>
                    /// <item><description><b>drop</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>accept</para>
                    /// </summary>
                    [NameInMap("Policy")]
                    [Validation(Required=false)]
                    public string Policy { get; set; }

                    /// <summary>
                    /// <para>The destination port range of the inbound traffic.</para>
                    /// <list type="bullet">
                    /// <item><description>If the <b>protocol</b> of the inbound rule is set to <b>all</b>, <b>icmp</b>, or <b>gre</b>, the port range is -1/-1, which specifies all ports.</description></item>
                    /// <item><description>If the <b>protocol</b> of the inbound rule is set to <b>tcp</b> or <b>udp</b>, set the port range in the following format: <b>1/200</b> or <b>80/80</b>, which specifies port 1 to port 200 or port 80. Valid ports: <b>1</b> to <b>65535</b>.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>-1/-1</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public string Port { get; set; }

                    /// <summary>
                    /// <para>The protocol type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>icmp</b></description></item>
                    /// <item><description><b>gre</b></description></item>
                    /// <item><description><b>tcp</b></description></item>
                    /// <item><description><b>udp</b></description></item>
                    /// <item><description><b>all</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>all</para>
                    /// </summary>
                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                    /// <summary>
                    /// <para>The source CIDR block.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10.0.0.0/24</para>
                    /// </summary>
                    [NameInMap("SourceCidrIp")]
                    [Validation(Required=false)]
                    public string SourceCidrIp { get; set; }

                }

            }

            /// <summary>
            /// <para>The ID of the network ACL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nacl-a2do9e413e0spnhmj****</para>
            /// </summary>
            [NameInMap("NetworkAclId")]
            [Validation(Required=false)]
            public string NetworkAclId { get; set; }

            /// <summary>
            /// <para>The name of the network ACL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acl-1</para>
            /// </summary>
            [NameInMap("NetworkAclName")]
            [Validation(Required=false)]
            public string NetworkAclName { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the network ACL belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>253460731706911258</para>
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public long? OwnerId { get; set; }

            /// <summary>
            /// <para>The region ID of the network ACL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The resources that are associated with the network ACL.</para>
            /// </summary>
            [NameInMap("Resources")]
            [Validation(Required=false)]
            public DescribeNetworkAclAttributesResponseBodyNetworkAclAttributeResources Resources { get; set; }
            public class DescribeNetworkAclAttributesResponseBodyNetworkAclAttributeResources : TeaModel {
                [NameInMap("Resource")]
                [Validation(Required=false)]
                public List<DescribeNetworkAclAttributesResponseBodyNetworkAclAttributeResourcesResource> Resource { get; set; }
                public class DescribeNetworkAclAttributesResponseBodyNetworkAclAttributeResourcesResource : TeaModel {
                    /// <summary>
                    /// <para>The ID of the associated resource.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vsw-bp1de348lntdwxscd****</para>
                    /// </summary>
                    [NameInMap("ResourceId")]
                    [Validation(Required=false)]
                    public string ResourceId { get; set; }

                    /// <summary>
                    /// <para>The type of resource with which you want to associate the network ACL. The value is set to <b>VSwitch</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>VSwitch</para>
                    /// </summary>
                    [NameInMap("ResourceType")]
                    [Validation(Required=false)]
                    public string ResourceType { get; set; }

                    /// <summary>
                    /// <para>The association status of the resource. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>BINDED</b></description></item>
                    /// <item><description><b>BINDING</b></description></item>
                    /// <item><description><b>UNBINDING</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>BINDED</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

            }

            /// <summary>
            /// <para>The association status of the resource. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Available</b></description></item>
            /// <item><description><b>Modifying</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The information about the tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public DescribeNetworkAclAttributesResponseBodyNetworkAclAttributeTags Tags { get; set; }
            public class DescribeNetworkAclAttributesResponseBodyNetworkAclAttributeTags : TeaModel {
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public List<DescribeNetworkAclAttributesResponseBodyNetworkAclAttributeTagsTag> Tag { get; set; }
                public class DescribeNetworkAclAttributesResponseBodyNetworkAclAttributeTagsTag : TeaModel {
                    /// <summary>
                    /// <para>The key of tag N added to the resource.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>FinanceDept</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The value of tag N added to the resource.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>FinanceJoshua</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// <para>The ID of the VPC to which the network ACL belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-a2d33rfpl72k5defr****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F5905F9C-0161-4E72-9CB1-1F3F3CF6268A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
