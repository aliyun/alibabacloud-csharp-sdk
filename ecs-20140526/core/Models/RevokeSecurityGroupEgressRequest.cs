// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class RevokeSecurityGroupEgressRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among multiple requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use Permissions.N.Description to specify the rule description.</para>
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
        /// <para><b>[Deprecated]</b> Use Permissions.N.DestCidrIp to specify the destination IPv4 Classless Inter-Domain Routing.</para>
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
        /// <para>sg-bp67acfmxa123b****</para>
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
        /// <para>TCP</para>
        /// </summary>
        [NameInMap("IpProtocol")]
        [Validation(Required=false)]
        [Obsolete]
        public string IpProtocol { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use Permissions.N.Ipv6DestCidrIp to specify the destination IPv6 Classless Inter-Domain Routing.</para>
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
        /// <para>The array of security group rules. Array length: 0 to 100.</para>
        /// </summary>
        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public List<RevokeSecurityGroupEgressRequestPermissions> Permissions { get; set; }
        public class RevokeSecurityGroupEgressRequestPermissions : TeaModel {
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
            /// <para>The destination IPv4 Classless Inter-Domain Routing for which you want to revoke access permissions. Supports Classless Inter-Domain Routing format and IPv4 format IP address ranges.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.0/8</para>
            /// </summary>
            [NameInMap("DestCidrIp")]
            [Validation(Required=false)]
            public string DestCidrIp { get; set; }

            /// <summary>
            /// <para>The ID of the destination security group for which you want to revoke access permissions.</para>
            /// <list type="bullet">
            /// <item><description>You must configure the Settings for at least one of the following parameters: DestGroupId, DestCidrIp, Ipv6DestCidrIp, and DestPrefixListId.</description></item>
            /// <item><description>If you specify DestGroupId but do not specify DestCidrIp, you must set NicType to intranet.</description></item>
            /// <item><description>If you specify both DestGroupId and DestCidrIp, DestCidrIp takes precedence by default.</description></item>
            /// </list>
            /// <para>Take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description>Advanced security groups do not support authorization between security groups.</description></item>
            /// <item><description>A basic security group can be authorized to access up to 20 other security groups.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>sg-bp67acfmxa123b****</para>
            /// </summary>
            [NameInMap("DestGroupId")]
            [Validation(Required=false)]
            public string DestGroupId { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account to which the destination security group belongs when you revoke a cross-account authorization security group rule.</para>
            /// <list type="bullet">
            /// <item><description>If the Settings for neither DestGroupOwnerAccount nor DestGroupOwnerId are configured, it is considered as revoking the access permissions of your other security groups. </description></item>
            /// <item><description>If the Settings for the DestCidrIp parameter are configured, the DestGroupOwnerAccount parameter is invalid.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:Test@aliyun.com">Test@aliyun.com</a></para>
            /// </summary>
            [NameInMap("DestGroupOwnerAccount")]
            [Validation(Required=false)]
            public string DestGroupOwnerAccount { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the destination security group belongs when you revoke a cross-account authorization security group rule.</para>
            /// <list type="bullet">
            /// <item><description>If the Settings for neither DestGroupOwnerId nor DestGroupOwnerAccount are configured, it is considered as revoking the access permissions of your other security groups.  </description></item>
            /// <item><description>If you have configured the Settings for the DestCidrIp parameter, the DestGroupOwnerId parameter is invalid.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>12345678910</para>
            /// </summary>
            [NameInMap("DestGroupOwnerId")]
            [Validation(Required=false)]
            public string DestGroupOwnerId { get; set; }

            /// <summary>
            /// <para>The destination prefix list for which you want to revoke access permissions. You can invoke the <a href="https://help.aliyun.com/document_detail/205046.html">DescribePrefixLists</a> operation to query the IDs of available prefix lists.</para>
            /// <para>Precautions:</para>
            /// <para>If you specify one of the DestCidrIp, Ipv6DestCidrIp, and DestGroupId parameters, this parameter is ignored.</para>
            /// <para>For more information, see <a href="~~25412#SecurityGroupQuota1~~">Security group limits</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pl-x1j1k5ykzqlixdcy****</para>
            /// </summary>
            [NameInMap("DestPrefixListId")]
            [Validation(Required=false)]
            public string DestPrefixListId { get; set; }

            /// <summary>
            /// <para>The protocol type. The value is not case-sensitive. Valid values: </para>
            /// <list type="bullet">
            /// <item><description>TCP</description></item>
            /// <item><description>UDP</description></item>
            /// <item><description>ICMP</description></item>
            /// <item><description>ICMPv6</description></item>
            /// <item><description>GRE</description></item>
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
            /// <para>The destination IPv6 Classless Inter-Domain Routing for which you want to revoke access permissions. Supports Classless Inter-Domain Routing format and IPv6 format IP address ranges.</para>
            /// <remarks>
            /// <para>This parameter is valid only for VPC-type ECS instances that support IPv6. You cannot configure the Settings for both this parameter and the DestCidrIp parameter at the same time.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2001:db8:1233:1a00::***</para>
            /// </summary>
            [NameInMap("Ipv6DestCidrIp")]
            [Validation(Required=false)]
            public string Ipv6DestCidrIp { get; set; }

            /// <summary>
            /// <para>The source IPv6 CIDR block. CIDR blocks and IPv6 address ranges are supported.</para>
            /// <para>This parameter is used to support quintuple rules. For more information, see <a href="https://help.aliyun.com/document_detail/97439.html">Quintuple rules for security groups</a>. </para>
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
            /// <para>The network interface controller (NIC) type of the security group rule. You do not need to configure the Settings for the NIC type for security group rules in a VPC. The default value is intranet, and only intranet is supported.</para>
            /// <remarks>
            /// <para>The classic network feature is offline. For details, see <a href="https://help.aliyun.com/document_detail/2833134.html">Offline announcement</a>. The NIC type for classic network type security group rules. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>internet: public NIC.</description></item>
            /// <item><description>intranet: internal network NIC.</description></item>
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
            /// <item><description>drop: deny access without returning a rejection message. This manifests as a request timeout or connection failure on the initiator side.</description></item>
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
            /// <para>The destination port range for the protocols opened in the security group. Valid values: </para>
            /// <list type="bullet">
            /// <item><description>TCP or UDP: 1 to 65535. Use a forward slash (/) to separate the start port and the end port. Example: 1/200.</description></item>
            /// <item><description>ICMP: -1/-1.</description></item>
            /// <item><description>GRE: -1/-1.</description></item>
            /// <item><description>ALL: -1/-1.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>22/22</para>
            /// </summary>
            [NameInMap("PortRange")]
            [Validation(Required=false)]
            public string PortRange { get; set; }

            /// <summary>
            /// <para>The ID of the port list.
            /// You can call the DescribePortRangeLists operation to query the IDs of available port lists.</para>
            /// <para>If you specify the Permissions.N.PortRange parameter, this parameter is ignored.</para>
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
            /// <para>The source port range for the protocols opened in the security group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>TCP or UDP: 1 to 65535. Use a forward slash (/) to separate the start port and the end port. Example: 1/200.</description></item>
            /// <item><description>ICMP: -1/-1.</description></item>
            /// <item><description>GRE: -1/-1.</description></item>
            /// <item><description>ALL: -1/-1.</description></item>
            /// </list>
            /// <para>This parameter is used to support quintuple rules. For more information, see <a href="https://help.aliyun.com/document_detail/97439.html">Quintuple rules for security groups</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22/22</para>
            /// </summary>
            [NameInMap("SourcePortRange")]
            [Validation(Required=false)]
            public string SourcePortRange { get; set; }

        }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use Permissions.N.Policy to configure the Settings for access permissions.</para>
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

        /// <summary>
        /// <para>The array of security group rule IDs. Array length: 0 to 100.</para>
        /// </summary>
        [NameInMap("SecurityGroupRuleId")]
        [Validation(Required=false)]
        public List<string> SecurityGroupRuleId { get; set; }

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
        /// <para>22/22</para>
        /// </summary>
        [NameInMap("SourcePortRange")]
        [Validation(Required=false)]
        [Obsolete]
        public string SourcePortRange { get; set; }

    }

}
