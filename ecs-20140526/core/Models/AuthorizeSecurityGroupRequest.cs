// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class AuthorizeSecurityGroupRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests. The ClientToken value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
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
        /// <para><b>[Deprecated]</b> Use Permissions.N.Description to specify the description of the security group rule.</para>
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
        /// <para><b>[Deprecated]</b> Use Permissions.N.DestCidrIp to specify the destination IPv4 CIDR block.</para>
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
        /// <para><b>[Deprecated]</b> Use Permissions.N.Ipv6DestCidrIp to specify the destination IPv6 CIDR block.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
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
        /// <para>2001:250:6000::***</para>
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
        /// <para>The array of security group rules. Valid values for the array length: 1 to 100.</para>
        /// </summary>
        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public List<AuthorizeSecurityGroupRequestPermissions> Permissions { get; set; }
        public class AuthorizeSecurityGroupRequestPermissions : TeaModel {
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
            /// <para>The destination IPv4 CIDR block. Both CIDR format and IPv4 format address ranges are supported.</para>
            /// <para>This parameter is used to support quintuple rules. For more information, see <a href="https://help.aliyun.com/document_detail/97439.html">Quintuple rules for security groups</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.0/8</para>
            /// </summary>
            [NameInMap("DestCidrIp")]
            [Validation(Required=false)]
            public string DestCidrIp { get; set; }

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
            /// <item><description>IANA-standard protocol numbers, which are integers from 0 to 255. This is available in the following regions:</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description>Philippines</description></item>
            /// <item><description>UK</description></item>
            /// <item><description>Malaysia</description></item>
            /// <item><description>China (Hohhot)</description></item>
            /// <item><description>China (Qingdao)</description></item>
            /// <item><description>US (Silicon Valley)</description></item>
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
            /// <para>The destination IPv6 CIDR block. Both CIDR format and IPv6 format address ranges are supported.</para>
            /// <para>This parameter is used to support quintuple rules. For more information, see <a href="https://help.aliyun.com/document_detail/97439.html">Quintuple rules for security groups</a>.</para>
            /// <remarks>
            /// <para>This parameter is valid only for VPC-type ECS instances that support IPv6. You cannot specify both this parameter and the DestCidrIp parameter in the same settings.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2001:250:6000::***</para>
            /// </summary>
            [NameInMap("Ipv6DestCidrIp")]
            [Validation(Required=false)]
            public string Ipv6DestCidrIp { get; set; }

            /// <summary>
            /// <para>The source IPv6 CIDR block for access permission settings. Both CIDR format and IPv6 format address ranges are supported.</para>
            /// <remarks>
            /// <para>This parameter is valid only for VPC-type ECS instances that support IPv6. You cannot specify both this parameter and the SourceCidrIp parameter in the same settings.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2001:250:6000::***</para>
            /// </summary>
            [NameInMap("Ipv6SourceCidrIp")]
            [Validation(Required=false)]
            public string Ipv6SourceCidrIp { get; set; }

            /// <summary>
            /// <para>The NIC type for security group rules in the classic network. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>internet: public NIC.</para>
            /// </description></item>
            /// <item><description><para>intranet: internal NIC.</para>
            /// </description></item>
            /// </list>
            /// <para>No NIC type settings are required for security group rules in a VPC. The default value is intranet, and it can only be set to intranet.</para>
            /// <para>When you configure mutual access between security groups, which means only the DestGroupId parameter is specified, this parameter can only be set to intranet.</para>
            /// <para>Default value: internet.</para>
            /// 
            /// <b>Example:</b>
            /// <para>intranet</para>
            /// </summary>
            [NameInMap("NicType")]
            [Validation(Required=false)]
            public string NicType { get; set; }

            /// <summary>
            /// <para>The access permission settings. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>accept: allows access.</para>
            /// </description></item>
            /// <item><description><para>drop: denies access without returning a rejection message. The initiator experiences a request timeout or a connection failure.</para>
            /// </description></item>
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
            /// <para>The destination port range for the specified protocol opened in the security group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>TCP or UDP: 1 to 65535. Use a forward slash (/) to separate the start port and the stop port. Example: 1/200.</description></item>
            /// <item><description>ICMP: -1/-1.</description></item>
            /// <item><description>GRE: -1/-1.</description></item>
            /// <item><description>ALL: -1/-1.</description></item>
            /// </list>
            /// <para>For more information about common scenarios, see <a href="https://help.aliyun.com/document_detail/40724.html">Common ports used by typical applications</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80/80</para>
            /// </summary>
            [NameInMap("PortRange")]
            [Validation(Required=false)]
            public string PortRange { get; set; }

            /// <summary>
            /// <para>The ID of the port list.
            /// You can call the DescribePortRangeLists operation to query available port list IDs.</para>
            /// <list type="bullet">
            /// <item><description>If you specify the Permissions.N.PortRange parameter, this parameter is ignored.</description></item>
            /// <item><description>Port lists are not supported when the network type of the security group is classic network. For more information about the limits on security groups and port lists, see <a href="~~25412#SecurityGroupQuota1~~">Security group limits</a>.</description></item>
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
            /// <para>The source IPv4 CIDR block for access permission settings. Both CIDR format and IPv4 format address ranges are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.0/8</para>
            /// </summary>
            [NameInMap("SourceCidrIp")]
            [Validation(Required=false)]
            public string SourceCidrIp { get; set; }

            /// <summary>
            /// <para>The ID of the source security group for access permission settings.</para>
            /// <list type="bullet">
            /// <item><description><para>You must specify at least one of the following parameters: SourceGroupId, SourceCidrIp, Ipv6SourceCidrIp, and SourcePrefixListId.</para>
            /// </description></item>
            /// <item><description><para>If you specify SourceGroupId but do not specify SourceCidrIp or Ipv6SourceCidrIp, you must set NicType to intranet.</para>
            /// </description></item>
            /// <item><description><para>If you specify both SourceGroupId and SourceCidrIp, SourceCidrIp takes precedence by default.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>sg-bp67acfmxazb4p****</para>
            /// </summary>
            [NameInMap("SourceGroupId")]
            [Validation(Required=false)]
            public string SourceGroupId { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account that owns the source security group for cross-account security group rule settings.</para>
            /// <list type="bullet">
            /// <item><description><para>If neither SourceGroupOwnerAccount nor SourceGroupOwnerId is specified, the rule applies to the access permission settings for your other security groups.</para>
            /// </description></item>
            /// <item><description><para>If SourceCidrIp is specified, the SourceGroupOwnerAccount parameter is invalid.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:test@aliyun.com">test@aliyun.com</a></para>
            /// </summary>
            [NameInMap("SourceGroupOwnerAccount")]
            [Validation(Required=false)]
            public string SourceGroupOwnerAccount { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account that owns the source security group for cross-account security group rule settings.</para>
            /// <list type="bullet">
            /// <item><description><para>If neither SourceGroupOwnerAccount nor SourceGroupOwnerId is specified, the rule applies to the access permission settings for your other security groups.</para>
            /// </description></item>
            /// <item><description><para>If SourceCidrIp is specified, the SourceGroupOwnerAccount parameter is invalid.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1234567890</para>
            /// </summary>
            [NameInMap("SourceGroupOwnerId")]
            [Validation(Required=false)]
            public long? SourceGroupOwnerId { get; set; }

            /// <summary>
            /// <para>The source port range for the specified protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>TCP or UDP: 1 to 65535. Use a forward slash (/) to separate the start port and the end port. Example: 1/200.</description></item>
            /// <item><description>ICMP: -1/-1.</description></item>
            /// <item><description>GRE: -1/-1.</description></item>
            /// <item><description>ALL: -1/-1.</description></item>
            /// </list>
            /// <para>This parameter is used to support quintuple rules. For more information, see <a href="https://help.aliyun.com/document_detail/97439.html">Quintuple rules for security groups</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7000/8000</para>
            /// </summary>
            [NameInMap("SourcePortRange")]
            [Validation(Required=false)]
            public string SourcePortRange { get; set; }

            /// <summary>
            /// <para>The ID of the source prefix list for access permission settings. You can call the <a href="https://help.aliyun.com/document_detail/205046.html">DescribePrefixLists</a> operation to query available prefix list IDs.</para>
            /// <para>Precautions:</para>
            /// <para>If you specify SourceCidrIp, Ipv6SourceCidrIp, or SourceGroupId, this parameter is ignored.</para>
            /// <para>For more information, see <a href="~~25412#SecurityGroupQuota1~~">Security group limits</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pl-x1j1k5ykzqlixdcy****</para>
            /// </summary>
            [NameInMap("SourcePrefixListId")]
            [Validation(Required=false)]
            public string SourcePrefixListId { get; set; }

        }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use Permissions.N.Policy for access permission settings.</para>
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
        /// <para>22/22</para>
        /// </summary>
        [NameInMap("PortRange")]
        [Validation(Required=false)]
        [Obsolete]
        public string PortRange { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use Permissions.N.Priority to specify the priority of the security group rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        [Obsolete]
        public string Priority { get; set; }

        /// <summary>
        /// <para>The region ID of the security group. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
        /// <para>The ID of the security group.</para>
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
        /// <para><b>[Deprecated]</b> Use Permissions.N.SourceGroupId to specify the source security group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("SourceGroupId")]
        [Validation(Required=false)]
        [Obsolete]
        public string SourceGroupId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use Permissions.N.SourceGroupOwnerAccount to specify the Alibaba Cloud account that owns the source security group.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:test@aliyun.com">test@aliyun.com</a></para>
        /// </summary>
        [NameInMap("SourceGroupOwnerAccount")]
        [Validation(Required=false)]
        [Obsolete]
        public string SourceGroupOwnerAccount { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use Permissions.N.SourceGroupOwnerId to specify the ID of the Alibaba Cloud account that owns the source security group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890</para>
        /// </summary>
        [NameInMap("SourceGroupOwnerId")]
        [Validation(Required=false)]
        [Obsolete]
        public long? SourceGroupOwnerId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use Permissions.N.SourcePortRange to specify the source port range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22/22</para>
        /// </summary>
        [NameInMap("SourcePortRange")]
        [Validation(Required=false)]
        [Obsolete]
        public string SourcePortRange { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use Permissions.N.SourcePrefixListId to specify the source prefix list ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pl-x1j1k5ykzqlixdcy****</para>
        /// </summary>
        [NameInMap("SourcePrefixListId")]
        [Validation(Required=false)]
        [Obsolete]
        public string SourcePrefixListId { get; set; }

    }

}
