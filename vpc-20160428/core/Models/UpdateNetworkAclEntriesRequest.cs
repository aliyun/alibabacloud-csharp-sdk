// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class UpdateNetworkAclEntriesRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request is unique.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The information about the outbound rules.</para>
        /// </summary>
        [NameInMap("EgressAclEntries")]
        [Validation(Required=false)]
        public List<UpdateNetworkAclEntriesRequestEgressAclEntries> EgressAclEntries { get; set; }
        public class UpdateNetworkAclEntriesRequestEgressAclEntries : TeaModel {
            /// <summary>
            /// <para>The description of the outbound rule.</para>
            /// <para>The description must be 1 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is EgressAclEntries.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The destination CIDR block. You can also specify a prefix list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.0/24
            /// pl-xxxxxx</para>
            /// </summary>
            [NameInMap("DestinationCidrIp")]
            [Validation(Required=false)]
            public string DestinationCidrIp { get; set; }

            /// <summary>
            /// <para>The rule type. Set the value to <b>custom</b>, which indicates a custom rule.</para>
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
            /// <para>The ID of the outbound rule entries.</para>
            /// <para>Valid values of <b>N</b>: <b>0</b> to <b>99</b>. You can update up to 100 outbound rules at a time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nae-2zecs97e0brcge46****</para>
            /// </summary>
            [NameInMap("NetworkAclEntryId")]
            [Validation(Required=false)]
            public string NetworkAclEntryId { get; set; }

            /// <summary>
            /// <para>The name of the outbound rule entries.</para>
            /// <para>The name must be 1 to 128 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acl-2</para>
            /// </summary>
            [NameInMap("NetworkAclEntryName")]
            [Validation(Required=false)]
            public string NetworkAclEntryName { get; set; }

            /// <summary>
            /// <para>The authorization policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>accept</b>: allows the traffic.</para>
            /// </description></item>
            /// <item><description><para><b>drop</b>: denies the traffic.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>accept</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <para>The destination port range of the outbound rule.</para>
            /// <list type="bullet">
            /// <item><description>If the <b>Protocol</b> (Protocol Type) of the outbound rule is set to <b>all</b>, <b>icmp</b>, or <b>gre</b>, the port range is -1/-1, which indicates that all ports are available.</description></item>
            /// <item><description>If the <b>Protocol</b> (Protocol Type) of the outbound rule is set to <b>tcp</b> or <b>udp</b>, the port range is <b>1</b> to <b>65535</b>. The format is <b>1/200</b> or <b>80/80</b>, which indicates Port 1 to Port 200 or Port 80.</description></item>
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
            /// <item><description><para><b>icmp</b>: Internet Control Message Protocol (ICMP).</para>
            /// </description></item>
            /// <item><description><para><b>gre</b>: Generic Routing Encapsulation (GRE).</para>
            /// </description></item>
            /// <item><description><para><b>tcp</b>: Transmission Control Protocol (TCP).</para>
            /// </description></item>
            /// <item><description><para><b>udp</b>: User Datagram Protocol (UDP).</para>
            /// </description></item>
            /// <item><description><para><b>all</b>: all protocols.</para>
            /// </description></item>
            /// <item><description><para><b>icmpv6</b>: Internet Control Message Protocol version 6 (ICMPv6).</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>all</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

        }

        /// <summary>
        /// <para>The information about the inbound rules.</para>
        /// </summary>
        [NameInMap("IngressAclEntries")]
        [Validation(Required=false)]
        public List<UpdateNetworkAclEntriesRequestIngressAclEntries> IngressAclEntries { get; set; }
        public class UpdateNetworkAclEntriesRequestIngressAclEntries : TeaModel {
            /// <summary>
            /// <para>The description of the inbound rule.</para>
            /// <para>The description must be 1 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is IngressAclEntries.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The rule type. Set the value to <b>custom</b>, which indicates a custom rule.</para>
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
            /// <para>The ID of the inbound rule entries.</para>
            /// <para>Valid values of <b>N</b>: <b>0</b> to <b>99</b>. You can update up to 100 inbound rules at a time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nae-2zepn32de59j8m4****</para>
            /// </summary>
            [NameInMap("NetworkAclEntryId")]
            [Validation(Required=false)]
            public string NetworkAclEntryId { get; set; }

            /// <summary>
            /// <para>The name of the inbound rule entries.</para>
            /// <para>The name must be 1 to 128 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acl-3</para>
            /// </summary>
            [NameInMap("NetworkAclEntryName")]
            [Validation(Required=false)]
            public string NetworkAclEntryName { get; set; }

            /// <summary>
            /// <para>The authorization policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>accept</b>: allows the traffic.</para>
            /// </description></item>
            /// <item><description><para><b>drop</b>: denies the traffic.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>accept</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <para>The source port range of the inbound rule.</para>
            /// <list type="bullet">
            /// <item><description>If the <b>Protocol</b> (Protocol Type) of the inbound rule is set to <b>all</b>, <b>icmp</b>, or <b>gre</b>, the port range is -1/-1, which indicates that all ports are available.</description></item>
            /// <item><description>If the <b>Protocol</b> (Protocol Type) of the inbound rule is set to <b>tcp</b> or <b>udp</b>, the port range is <b>1</b> to <b>65535</b>. The format is <b>1/200</b> or <b>80/80</b>, which indicates Port 1 to Port 200 or Port 80.</description></item>
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
            /// <item><description><para><b>icmp</b>: Internet Control Message Protocol (ICMP).</para>
            /// </description></item>
            /// <item><description><para><b>gre</b>: Generic Routing Encapsulation (GRE).</para>
            /// </description></item>
            /// <item><description><para><b>tcp</b>: Transmission Control Protocol (TCP).</para>
            /// </description></item>
            /// <item><description><para><b>udp</b>: User Datagram Protocol (UDP).</para>
            /// </description></item>
            /// <item><description><para><b>all</b>: all protocols.</para>
            /// </description></item>
            /// <item><description><para><b>icmpv6</b>: Internet Control Message Protocol version 6 (ICMPv6).</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>all</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The source CIDR block. You can also specify a prefix list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.0/24
            /// pl-xxxxxx</para>
            /// </summary>
            [NameInMap("SourceCidrIp")]
            [Validation(Required=false)]
            public string SourceCidrIp { get; set; }

        }

        /// <summary>
        /// <para>The ID of the network ACL.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nacl-bp1lhl0taikrzxsc****</para>
        /// </summary>
        [NameInMap("NetworkAclId")]
        [Validation(Required=false)]
        public string NetworkAclId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the network ACL.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>Specifies whether to update the outbound rules. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: yes.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): no.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter does not support incremental updates. If the network ACL already has an outbound rule and you want to add another outbound rule, you must pass both rules when you call this operation. If you pass only the new outbound rule, the existing outbound rule is deleted.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UpdateEgressAclEntries")]
        [Validation(Required=false)]
        public bool? UpdateEgressAclEntries { get; set; }

        /// <summary>
        /// <para>Specifies whether to update the inbound rules. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: yes.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): no.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter does not support incremental updates. If the network ACL already has an inbound rule and you want to add another inbound rule, you must pass both rules when you call this operation. If you pass only the new inbound rule, the existing inbound rule is deleted.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UpdateIngressAclEntries")]
        [Validation(Required=false)]
        public bool? UpdateIngressAclEntries { get; set; }

    }

}
