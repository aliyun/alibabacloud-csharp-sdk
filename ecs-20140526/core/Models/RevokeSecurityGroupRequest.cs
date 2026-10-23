// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class RevokeSecurityGroupRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests. The <b>ClientToken</b> value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
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
        /// <para><b>[Deprecated]</b> Use <c>Permissions.N.Description</c> to specify the description of the rule.</para>
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
        /// <para><b>[Deprecated]</b> Use <c>Permissions.N.DestCidrIp</c> to specify the destination IPv4 CIDR block.</para>
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
        /// <para><b>[Deprecated]</b> Use <c>Permissions.N.IpProtocol</c> to specify the protocol type.</para>
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
        /// <para><b>[Deprecated]</b> Use <c>Permissions.N.Ipv6DestCidrIp</c> to specify the destination IPv6 CIDR block.</para>
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
        /// <para><b>[Deprecated]</b> Use <c>Permissions.N.Ipv6SourceCidrIp</c> to specify the source IPv6 Classless Inter-Domain Routing.</para>
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
        /// <para><b>[Deprecated]</b> Use <c>Permissions.N.NicType</c> to specify the NIC type.</para>
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
        /// <para>The array of security group rules. Array length: 0 to 100.</para>
        /// </summary>
        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public List<RevokeSecurityGroupRequestPermissions> Permissions { get; set; }
        public class RevokeSecurityGroupRequestPermissions : TeaModel {
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
            /// <para>The destination IPv4 CIDR block. CIDR blocks and IPv4 address ranges are supported.</para>
            /// <para>This parameter is used to support quintuple rules. For more information, see <a href="https://help.aliyun.com/document_detail/97439.html">Quintuple rules for security groups</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.0/8</para>
            /// </summary>
            [NameInMap("DestCidrIp")]
            [Validation(Required=false)]
            public string DestCidrIp { get; set; }

            /// <summary>
            /// <para>The protocol type. The value is not case-sensitive. Valid values: </para>
            /// <list type="bullet">
            /// <item><description>TCP.</description></item>
            /// <item><description>UDP.</description></item>
            /// <item><description>ICMP.</description></item>
            /// <item><description>ICMPv6.</description></item>
            /// <item><description>GRE.</description></item>
            /// <item><description>ALL: all protocols.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("IpProtocol")]
            [Validation(Required=false)]
            public string IpProtocol { get; set; }

            /// <summary>
            /// <para>The destination IPv6 CIDR block. CIDR blocks and IPv6 address ranges are supported. </para>
            /// <para>This parameter is used to support quintuple rules. For more information, see <a href="https://help.aliyun.com/document_detail/97439.html">Quintuple rules for security groups</a>.</para>
            /// <remarks>
            /// <para>This parameter is valid only for VPC-type ECS instances that support IPv6. You cannot specify both this parameter and the <c>DestCidrIp</c> parameter at the same time.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2001:db8:1233:1a00::***</para>
            /// </summary>
            [NameInMap("Ipv6DestCidrIp")]
            [Validation(Required=false)]
            public string Ipv6DestCidrIp { get; set; }

            /// <summary>
            /// <para>The source IPv6 Classless Inter-Domain Routing from which you want to revoke access permissions. CIDR format and IPv6 format IP address ranges are supported.</para>
            /// <remarks>
            /// <para>This parameter is valid only for VPC-type ECS instances that support IPv6. Settings for this parameter and the <c>SourceCidrIp</c> parameter cannot be applied at the same time.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2001:db8:1234:1a00::***</para>
            /// </summary>
            [NameInMap("Ipv6SourceCidrIp")]
            [Validation(Required=false)]
            public string Ipv6SourceCidrIp { get; set; }

            /// <summary>
            /// <para>The network interface controller (NIC) type of the security group rule. You do not need to specify the network interface controller (NIC) type for security group rules in a VPC. The default value is intranet, and only intranet is supported.</para>
            /// <remarks>
            /// <para>The classic network feature has been taken offline. For details, see <a href="https://help.aliyun.com/document_detail/2833134.html">Offline notice</a>. The network interface controller (NIC) type for classic network security group rules. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>internet: public network interface controller (NIC).</description></item>
            /// <item><description>intranet: internal network interface controller (NIC).</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>intranet</para>
            /// </summary>
            [NameInMap("NicType")]
            [Validation(Required=false)]
            public string NicType { get; set; }

            /// <summary>
            /// <para>The access permissions. Valid values: </para>
            /// <list type="bullet">
            /// <item><description>accept: allows access.</description></item>
            /// <item><description>drop: deny access without returning a rejection message. The initiator receives a message indicating that the request timeout or the connection failed.</description></item>
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
            /// <para>The destination port range for the protocol specified in the security group rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>For TCP or UDP: 1 to 65535. Use a forward slash (/) to separate the start port and the end port. Example: 1/200.</description></item>
            /// <item><description>For ICMP: -1/-1.</description></item>
            /// <item><description>For GRE: -1/-1.</description></item>
            /// <item><description>For ALL: -1/-1.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1/200</para>
            /// </summary>
            [NameInMap("PortRange")]
            [Validation(Required=false)]
            public string PortRange { get; set; }

            /// <summary>
            /// <para>The ID of the port list.</para>
            /// <para>You can call the <c>DescribePortRangeLists</c> operation to query the IDs of available port lists.</para>
            /// <para>If you specify the <c>Permissions.N.PortRange</c> parameter, this parameter is ignored.</para>
            /// <para>For more information, see <a href="~~25412#SecurityGroupQuota1~~">Security group limits</a>.</para>
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
            /// <para>The source IPv4 Classless Inter-Domain Routing from which you want to revoke access permissions. CIDR format and IPv4 format IP address ranges are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.0/8</para>
            /// </summary>
            [NameInMap("SourceCidrIp")]
            [Validation(Required=false)]
            public string SourceCidrIp { get; set; }

            /// <summary>
            /// <para>The ID of the source security group from which you want to revoke access permissions.</para>
            /// <list type="bullet">
            /// <item><description><para>You must specify at least one of the following parameters: <c>SourceGroupId</c>, <c>SourceCidrIp</c>, <c>Ipv6SourceCidrIp</c>, and <c>SourcePrefixListId</c>.</para>
            /// </description></item>
            /// <item><description><para>If you specify <c>SourceGroupId</c> but do not specify <c>SourceCidrIp</c> or <c>Ipv6SourceCidrIp</c>, you must set the NicType parameter to intranet.</para>
            /// </description></item>
            /// <item><description><para>If you specify both <c>SourceGroupId</c> and <c>SourceCidrIp</c>, <c>SourceCidrIp</c> takes precedence by default.</para>
            /// </description></item>
            /// </list>
            /// <para>Take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description><para>Advanced security groups do not support authorization between security groups.</para>
            /// </description></item>
            /// <item><description><para>A basic security group can be authorized to access a maximum of 20 other security groups.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>sg-bp67acfmxa123b****</para>
            /// </summary>
            [NameInMap("SourceGroupId")]
            [Validation(Required=false)]
            public string SourceGroupId { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account to which the source security group belongs when you revoke a cross-account authorization security group rule.</para>
            /// <list type="bullet">
            /// <item><description>If Settings for neither <c>SourceGroupOwnerAccount</c> nor <c>SourceGroupOwnerId</c> are applied, it is considered that you are revoking the access permissions from your other security groups.</description></item>
            /// <item><description>If <c>SourceCidrIp</c> is specified, the <c>SourceGroupOwnerAccount</c> parameter is invalid.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:Test@aliyun.com">Test@aliyun.com</a></para>
            /// </summary>
            [NameInMap("SourceGroupOwnerAccount")]
            [Validation(Required=false)]
            public string SourceGroupOwnerAccount { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the source security group belongs when you revoke a cross-account authorization security group rule.</para>
            /// <list type="bullet">
            /// <item><description>If Settings for neither <c>SourceGroupOwnerId</c> nor <c>SourceGroupOwnerAccount</c> are applied, it is considered that you are revoking the access permissions from your other security groups.</description></item>
            /// <item><description>If <c>SourceCidrIp</c> is specified, the <c>SourceGroupOwnerId</c> parameter is invalid.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>12345678910</para>
            /// </summary>
            [NameInMap("SourceGroupOwnerId")]
            [Validation(Required=false)]
            public long? SourceGroupOwnerId { get; set; }

            /// <summary>
            /// <para>The source port range for the protocol specified in the security group rule. Valid values: </para>
            /// <list type="bullet">
            /// <item><description>For TCP or UDP: 1 to 65535. Use a forward slash (/) to separate the start port and the end port. Example: 1/200.</description></item>
            /// <item><description>For ICMP: -1/-1.</description></item>
            /// <item><description>For GRE: -1/-1.</description></item>
            /// <item><description>For ALL: -1/-1.</description></item>
            /// </list>
            /// <para>This parameter is used to support quintuple rules. For more information, see <a href="https://help.aliyun.com/document_detail/97439.html">Quintuple rules for security groups</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80/80</para>
            /// </summary>
            [NameInMap("SourcePortRange")]
            [Validation(Required=false)]
            public string SourcePortRange { get; set; }

            /// <summary>
            /// <para>The ID of the source prefix list from which you want to revoke access permissions. You can call the <a href="https://help.aliyun.com/document_detail/205046.html">DescribePrefixLists</a> operation to query the IDs of available prefix lists.</para>
            /// <para>Precautions:</para>
            /// <para>If you specify one of the <c>SourceCidrIp</c>, <c>Ipv6SourceCidrIp</c>, and <c>SourceGroupId</c> parameters, this parameter is ignored.</para>
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
        /// <para><b>[Deprecated]</b> Use <c>Permissions.N.Policy</c> for the Settings of access permissions.</para>
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
        /// <para><b>[Deprecated]</b> Use <c>Permissions.N.PortRange</c> to specify the port range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1/200</para>
        /// </summary>
        [NameInMap("PortRange")]
        [Validation(Required=false)]
        [Obsolete]
        public string PortRange { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use <c>Permissions.N.Priority</c> to specify the rule priority.</para>
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
        /// <para>The security group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The array of security group rule IDs. Array length: 0 to 100.</para>
        /// </summary>
        [NameInMap("SecurityGroupRuleId")]
        [Validation(Required=false)]
        public List<string> SecurityGroupRuleId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use <c>Permissions.N.SourceCidrIp</c> to specify the source IPv4 Classless Inter-Domain Routing.</para>
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
        /// <para><b>[Deprecated]</b> Use <c>Permissions.N.SourceGroupId</c> to specify the source security group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp67acfmxa123b****</para>
        /// </summary>
        [NameInMap("SourceGroupId")]
        [Validation(Required=false)]
        [Obsolete]
        public string SourceGroupId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use <c>Permissions.N.SourceGroupOwnerAccount</c> to specify the Alibaba Cloud account to which the source security group belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:Test@aliyun.com">Test@aliyun.com</a></para>
        /// </summary>
        [NameInMap("SourceGroupOwnerAccount")]
        [Validation(Required=false)]
        [Obsolete]
        public string SourceGroupOwnerAccount { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use <c>Permissions.N.SourceGroupOwnerId</c> to specify the ID of the Alibaba Cloud account to which the source security group belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678910</para>
        /// </summary>
        [NameInMap("SourceGroupOwnerId")]
        [Validation(Required=false)]
        [Obsolete]
        public long? SourceGroupOwnerId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use <c>Permissions.N.SourcePortRange</c> to specify the source port range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80/80</para>
        /// </summary>
        [NameInMap("SourcePortRange")]
        [Validation(Required=false)]
        [Obsolete]
        public string SourcePortRange { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use <c>Permissions.N.SourcePrefixListId</c> to specify the source prefix list ID.</para>
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
