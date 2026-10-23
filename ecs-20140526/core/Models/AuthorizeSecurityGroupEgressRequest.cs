// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class AuthorizeSecurityGroupEgressRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use Permissions.N.Description to specify the description of the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is description.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        [Obsolete]
        public string Description { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use Permissions.N.DestCidrIp to specify the destination IPv4 Classless Inter-Domain Routing (CIDR) block.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.0/8</para>
        /// </summary>
        [NameInMap("DestCidrIp")]
        [Validation(Required=false)]
        [Obsolete]
        public string DestCidrIp { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use Permissions.N.DestGroupId to specify the destination security group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("DestGroupId")]
        [Validation(Required=false)]
        [Obsolete]
        public string DestGroupId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use Permissions.N.DestGroupOwnerAccount to specify the Alibaba Cloud account to which the destination security group belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:Test@aliyun.com">Test@aliyun.com</a></para>
        /// </summary>
        [NameInMap("DestGroupOwnerAccount")]
        [Validation(Required=false)]
        [Obsolete]
        public string DestGroupOwnerAccount { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use Permissions.N.DestGroupOwnerId to specify the ID of the Alibaba Cloud account to which the destination security group belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678910</para>
        /// </summary>
        [NameInMap("DestGroupOwnerId")]
        [Validation(Required=false)]
        [Obsolete]
        public long? DestGroupOwnerId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use Permissions.N.DestPrefixListId to specify the destination prefix list ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pl-x1j1k5ykzqlixdcy****</para>
        /// </summary>
        [NameInMap("DestPrefixListId")]
        [Validation(Required=false)]
        [Obsolete]
        public string DestPrefixListId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use Permissions.N.IpProtocol to specify the protocol type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("IpProtocol")]
        [Validation(Required=false)]
        [Obsolete]
        public string IpProtocol { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use Permissions.N.Ipv6DestCidrIp to specify the destination IPv6 Classless Inter-Domain Routing (CIDR) block.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2001:db8:1233:1a00::***</para>
        /// </summary>
        [NameInMap("Ipv6DestCidrIp")]
        [Validation(Required=false)]
        [Obsolete]
        public string Ipv6DestCidrIp { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use Permissions.N.Ipv6SourceCidrIp to specify the source IPv6 CIDR block.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2001:db8:1234:1a00::***</para>
        /// </summary>
        [NameInMap("Ipv6SourceCidrIp")]
        [Validation(Required=false)]
        [Obsolete]
        public string Ipv6SourceCidrIp { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use Permissions.N.NicType to specify the NIC type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>intranet</para>
        /// </summary>
        [NameInMap("NicType")]
        [Validation(Required=false)]
        [Obsolete]
        public string NicType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The array of security group rules. Length: 1 to 100.</para>
        /// </summary>
        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public List<AuthorizeSecurityGroupEgressRequestPermissions> Permissions { get; set; }
        public class AuthorizeSecurityGroupEgressRequestPermissions : TeaModel {
            /// <summary>
            /// <para>The description of the security group rule. The description must be 1 to 512 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is description.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The destination IPv4 Classless Inter-Domain Routing (CIDR) block settings for access permissions. Supports Classless Inter-Domain Routing (CIDR) format and IPv4 format IP address ranges.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.0/8</para>
            /// </summary>
            [NameInMap("DestCidrIp")]
            [Validation(Required=false)]
            public string DestCidrIp { get; set; }

            /// <summary>
            /// <para>The ID of the destination security group for which you want to configure access permissions.</para>
            /// <list type="bullet">
            /// <item><description><para>You must specify at least one of the following parameters: DestGroupId, DestCidrIp, Ipv6DestCidrIp, and DestPrefixListId.</para>
            /// </description></item>
            /// <item><description><para>If you specify DestGroupId but do not specify DestCidrIp, the NicType parameter can only be set to intranet.</para>
            /// </description></item>
            /// <item><description><para>If you specify both DestGroupId and DestCidrIp, the DestCidrIp parameter takes precedence.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>sg-bp67acfmxazb4p****</para>
            /// </summary>
            [NameInMap("DestGroupId")]
            [Validation(Required=false)]
            public string DestGroupId { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account to which the destination security group belongs when you configure security group rules across accounts. </para>
            /// <list type="bullet">
            /// <item><description>If neither DestGroupOwnerAccount nor DestGroupOwnerId is specified, the rule is considered to configure access permissions for your other security groups.</description></item>
            /// <item><description>If the DestCidrIp parameter is specified, the DestGroupOwnerAccount parameter is invalid.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:Test@aliyun.com">Test@aliyun.com</a></para>
            /// </summary>
            [NameInMap("DestGroupOwnerAccount")]
            [Validation(Required=false)]
            public string DestGroupOwnerAccount { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the destination security group belongs when you configure security group rules across accounts. </para>
            /// <list type="bullet">
            /// <item><description>If neither DestGroupOwnerId nor DestGroupOwnerAccount is specified, the rule is considered to configure access permissions for your other security groups.</description></item>
            /// <item><description>If the DestCidrIp parameter is specified, the DestGroupOwnerId parameter is invalid.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>12345678910</para>
            /// </summary>
            [NameInMap("DestGroupOwnerId")]
            [Validation(Required=false)]
            public long? DestGroupOwnerId { get; set; }

            /// <summary>
            /// <para>The ID of the destination prefix list for which you want to configure access permissions. You can call the <a href="https://help.aliyun.com/document_detail/205046.html">DescribePrefixLists</a> operation to query the IDs of available prefix lists.</para>
            /// <para>Precautions:</para>
            /// <para>If you specify the DestCidrIp, Ipv6DestCidrIp, or DestGroupId parameter, this parameter is ignored.</para>
            /// <para>For more information, see <a href="~~25412#SecurityGroupQuota1~~">Security group limits</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pl-x1j1k5ykzqlixdcy****</para>
            /// </summary>
            [NameInMap("DestPrefixListId")]
            [Validation(Required=false)]
            public string DestPrefixListId { get; set; }

            /// <summary>
            /// <para>The network layer or transport layer protocol. Two types of values are supported:</para>
            /// <ol>
            /// <item><description>Case-insensitive protocol names. Valid values:</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description>ICMP</description></item>
            /// <item><description>GRE</description></item>
            /// <item><description>TCP</description></item>
            /// <item><description>UDP</description></item>
            /// <item><description>ALL: all protocols.</description></item>
            /// </list>
            /// <ol start="2">
            /// <item><description>IANA-standard protocol numbers, which are integers from 0 to 255. This is supported in the following regions:</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description>Philippines</description></item>
            /// <item><description>UK</description></item>
            /// <item><description>Malaysia</description></item>
            /// <item><description>China (Hohhot)</description></item>
            /// <item><description>China (Qingdao)</description></item>
            /// <item><description>US West</description></item>
            /// <item><description>Singapore</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ALL</para>
            /// </summary>
            [NameInMap("IpProtocol")]
            [Validation(Required=false)]
            public string IpProtocol { get; set; }

            /// <summary>
            /// <para>The destination IPv6 Classless Inter-Domain Routing (CIDR) block settings for access permissions. Supports Classless Inter-Domain Routing (CIDR) format and IPv6 format IP address ranges.</para>
            /// <remarks>
            /// <para>This parameter is valid only for VPC-type ECS instances that support IPv6. You cannot specify both this parameter and the DestCidrIp parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2001:db8:1233:1a00::***</para>
            /// </summary>
            [NameInMap("Ipv6DestCidrIp")]
            [Validation(Required=false)]
            public string Ipv6DestCidrIp { get; set; }

            /// <summary>
            /// <para>The source IPv6 CIDR block. CIDR blocks and IPv6 address ranges are supported. </para>
            /// <para>This parameter is used to support quintuple rules. For more information, see <a href="https://help.aliyun.com/document_detail/97439.html">Quintuple rules for security groups</a>.</para>
            /// <remarks>
            /// <para>This parameter is valid only for VPC-type ECS instances that support IPv6. You cannot specify both this parameter and the DestCidrIp parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2001:db8:1234:1a00::***</para>
            /// </summary>
            [NameInMap("Ipv6SourceCidrIp")]
            [Validation(Required=false)]
            public string Ipv6SourceCidrIp { get; set; }

            /// <summary>
            /// <para>The network interface controller (NIC) type for security group rules in the classic network type. Valid values: </para>
            /// <list type="bullet">
            /// <item><description>internet: public NIC.</description></item>
            /// <item><description>intranet: internal network NIC.<list type="bullet">
            /// <item><description>For security group rules in a VPC, you do not need to set the NIC type settings. The default value is intranet.</description></item>
            /// <item><description>When you configure mutual access between security groups by specifying only the DestGroupId parameter, the default value is intranet.</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// <para>Default value: internet.</para>
            /// 
            /// <b>Example:</b>
            /// <para>intranet</para>
            /// </summary>
            [NameInMap("NicType")]
            [Validation(Required=false)]
            public string NicType { get; set; }

            /// <summary>
            /// <para>The access permission settings. Valid values: </para>
            /// <list type="bullet">
            /// <item><description>accept: allows access.</description></item>
            /// <item><description>drop: denies access and does not return a rejection message. The request from the source experiences a timeout or fails to establish a connection.</description></item>
            /// </list>
            /// <para>Default value: accept.</para>
            /// 
            /// <b>Example:</b>
            /// <para>accept</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <para>The destination port range for the protocols enabled in the security group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>TCP or UDP: 1 to 65535. Separate the start port and the end port with a forward slash (/). Example: 1/200.</description></item>
            /// <item><description>ICMP: -1/-1.</description></item>
            /// <item><description>GRE: -1/-1.</description></item>
            /// <item><description>ALL: -1/-1.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>80/80</para>
            /// </summary>
            [NameInMap("PortRange")]
            [Validation(Required=false)]
            public string PortRange { get; set; }

            /// <summary>
            /// <para>The ID of the port range list.
            /// You can invoke the DescribePortRangeLists operation to query the IDs of available port range lists.</para>
            /// <list type="bullet">
            /// <item><description>If you specify the Permissions.N.PortRange parameter, this parameter is ignored.</description></item>
            /// <item><description>Port range list settings are not supported when the network type of the security group is classic network. For more information about the limits on security groups and port range lists, see <a href="~~25412#SecurityGroupQuota1~~">Security group limits</a>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>prl-2ze9743****</para>
            /// </summary>
            [NameInMap("PortRangeListId")]
            [Validation(Required=false)]
            public string PortRangeListId { get; set; }

            /// <summary>
            /// <para>The priority of the security group rule. A smaller value indicates a higher priority. Valid values: 1 to 100.</para>
            /// <para>Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// <para>The source IPv4 CIDR block. CIDR blocks and IPv4 address ranges are supported.</para>
            /// <para>This parameter is used to support quintuple rules. For more information, see <a href="https://help.aliyun.com/document_detail/97439.html">Quintuple rules for security groups</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.0/8</para>
            /// </summary>
            [NameInMap("SourceCidrIp")]
            [Validation(Required=false)]
            public string SourceCidrIp { get; set; }

            /// <summary>
            /// <para>The source port range for the protocols enabled in the security group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>TCP or UDP: 1 to 65535. Separate the start port and the end port with a forward slash (/). Example: 1/200.</description></item>
            /// <item><description>ICMP: -1/-1.</description></item>
            /// <item><description>GRE: -1/-1.</description></item>
            /// <item><description>ALL: -1/-1.</description></item>
            /// </list>
            /// <para>This parameter is used to support quintuple rules. For more information, see <a href="https://help.aliyun.com/document_detail/97439.html">Quintuple rules for security groups</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80/80</para>
            /// </summary>
            [NameInMap("SourcePortRange")]
            [Validation(Required=false)]
            public string SourcePortRange { get; set; }

        }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use Permissions.N.Policy for the access permission settings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>accept</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        [Obsolete]
        public string Policy { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use Permissions.N.PortRange to specify the port range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80/80</para>
        /// </summary>
        [NameInMap("PortRange")]
        [Validation(Required=false)]
        [Obsolete]
        public string PortRange { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use Permissions.N.Priority to specify the rule priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        [Obsolete]
        public string Priority { get; set; }

        /// <summary>
        /// <para>The region ID of the source security group. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
        /// <para>The security group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use Permissions.N.SourceCidrIp to specify the source IPv4 CIDR block.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.0/8</para>
        /// </summary>
        [NameInMap("SourceCidrIp")]
        [Validation(Required=false)]
        [Obsolete]
        public string SourceCidrIp { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use Permissions.N.SourcePortRange to specify the source port range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80/80</para>
        /// </summary>
        [NameInMap("SourcePortRange")]
        [Validation(Required=false)]
        [Obsolete]
        public string SourcePortRange { get; set; }

    }

}
