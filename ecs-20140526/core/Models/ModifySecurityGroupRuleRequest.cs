// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifySecurityGroupRuleRequest : TeaModel {
        /// <summary>
        /// <para>A client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but make sure that the token is unique among different requests. The <b>ClientToken</b> value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the security group rule. The description must be 1 to 512 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a new security group rule.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The destination IPv4 Classless Inter-Domain Routing (CIDR) block. CIDR format and IPv4 format IP address range are supported.</para>
        /// <para>Default value: null.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.0/8</para>
        /// </summary>
        [NameInMap("DestCidrIp")]
        [Validation(Required=false)]
        public string DestCidrIp { get; set; }

        /// <summary>
        /// <para>The network-layer or transport-layer protocol. Two types of values are supported:</para>
        /// <ol>
        /// <item><description>Case-insensitive protocol names. Valid values:</description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description>ICMP</description></item>
        /// <item><description>GRE</description></item>
        /// <item><description>TCP</description></item>
        /// <item><description>UDP</description></item>
        /// <item><description>ALL: all protocols are supported.</description></item>
        /// </list>
        /// <ol start="2">
        /// <item><description>Protocol numbers that comply with IANA specifications, which are integers from 0 to 255. The following regions currently support this feature:</description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description>Philippines</description></item>
        /// <item><description>UK (London)</description></item>
        /// <item><description>Malaysia</description></item>
        /// <item><description>China (Hohhot)</description></item>
        /// <item><description>China (Qingdao)</description></item>
        /// <item><description>US (Virginia)</description></item>
        /// <item><description>Singapore.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("IpProtocol")]
        [Validation(Required=false)]
        public string IpProtocol { get; set; }

        /// <summary>
        /// <para>Settings for the destination IPv6 CIDR block. CIDR format and IPv6 format IP address range are supported.</para>
        /// <remarks>
        /// <para>Only VPC-type IP addresses are supported. This parameter and <c>DestCidrIp</c> cannot be specified at the same time.</para>
        /// </remarks>
        /// <para>Default value: null.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2001:db8:1234:1a00::***</para>
        /// </summary>
        [NameInMap("Ipv6DestCidrIp")]
        [Validation(Required=false)]
        public string Ipv6DestCidrIp { get; set; }

        /// <summary>
        /// <para>Settings for the source IPv6 CIDR block for the access permissions. Classless Inter-Domain Routing (CIDR) format and IPv6 format IP address range are supported.</para>
        /// <remarks>
        /// <para>Only VPC-type IP addresses are supported. This parameter and <c>SourceCidrIp</c> cannot be specified at the same time.</para>
        /// </remarks>
        /// <para>Default value: null.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2001:db8:1233:1a00::***</para>
        /// </summary>
        [NameInMap("Ipv6SourceCidrIp")]
        [Validation(Required=false)]
        public string Ipv6SourceCidrIp { get; set; }

        /// <summary>
        /// <para>The network interface controller (NIC) type.</para>
        /// <remarks>
        /// <para>When you modify a rule by specifying the security group rule ID, this parameter cannot be modified. To change this value, add a new rule and then delete the current rule.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>intranet</para>
        /// </summary>
        [NameInMap("NicType")]
        [Validation(Required=false)]
        public string NicType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The access permissions. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>accept: accepts access.</description></item>
        /// <item><description>drop: deny access and does not return a rejection response.</description></item>
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
        /// <para>The range of destination ports that correspond to the transport-layer protocol. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>TCP/UDP: valid values are 1 to 65535. Separate the start port and the end port with a forward slash (/). Example: 1/200.</description></item>
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
        /// <para>Settings for the port address book ID.
        /// You can invoke <c>DescribePortRangeLists</c> to query available port address book IDs.</para>
        /// <list type="bullet">
        /// <item><description>This parameter is ignored if you specify the PortRange parameter.</description></item>
        /// <item><description>Port address books are not supported for security groups with the classic network type. For more information about the limits of security groups and port address books, see <a href="~~25412#SecurityGroupQuota1~~">Security group limits</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>prl-2ze9743****</para>
        /// </summary>
        [NameInMap("PortRangeListId")]
        [Validation(Required=false)]
        public string PortRangeListId { get; set; }

        /// <summary>
        /// <para>The priority of the security group rule. Valid values: 1 to 100.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public string Priority { get; set; }

        /// <summary>
        /// <para>The region ID of the target security group. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
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
        /// <para>The security group rule ID. You can call <a href="https://help.aliyun.com/document_detail/2679845.html">DescribeSecurityGroupAttribute</a> to query security group rule IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sgr-bp67acfmxa123b***</para>
        /// </summary>
        [NameInMap("SecurityGroupRuleId")]
        [Validation(Required=false)]
        public string SecurityGroupRuleId { get; set; }

        /// <summary>
        /// <para>Settings for the source IPv4 CIDR block for the access permissions. Classless Inter-Domain Routing (CIDR) format and IPv4 format IP address range are supported.</para>
        /// <para>Default value: null.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.0/8</para>
        /// </summary>
        [NameInMap("SourceCidrIp")]
        [Validation(Required=false)]
        public string SourceCidrIp { get; set; }

        /// <summary>
        /// <para>Settings for the ID of the source security group for the access permissions. Specify at least one of <c>SourceGroupId</c> and <c>SourceCidrIp</c>.</para>
        /// <list type="bullet">
        /// <item><description>If <c>SourceGroupId</c> is specified but <c>SourceCidrIp</c> is not, the <c>NicType</c> parameter can only be set to intranet.</description></item>
        /// <item><description>If both <c>SourceGroupId</c> and <c>SourceCidrIp</c> are specified, <c>SourceCidrIp</c> takes precedence by default.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp67acfmxa123b****</para>
        /// </summary>
        [NameInMap("SourceGroupId")]
        [Validation(Required=false)]
        public string SourceGroupId { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account that owns the source security group when you configure a cross-account security group rule. </para>
        /// <list type="bullet">
        /// <item><description>If neither <c>SourceGroupOwnerAccount</c> nor <c>SourceGroupOwnerID</c> is set, the rule is configured for access permissions of another security group within your account.</description></item>
        /// <item><description>If the parameter <c>SourceCidrIp</c> is specified, the parameter <c>SourceGroupOwnerAccount</c> is ignored.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:EcsforCloud@Alibaba.com">EcsforCloud@Alibaba.com</a></para>
        /// </summary>
        [NameInMap("SourceGroupOwnerAccount")]
        [Validation(Required=false)]
        public string SourceGroupOwnerAccount { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account that owns the source security group when you configure a cross-account security group rule. </para>
        /// <list type="bullet">
        /// <item><description>If neither <c>SourceGroupOwnerId</c> nor <c>SourceGroupOwnerAccount</c> is set, the rule is configured for access permissions of another security group within your account.</description></item>
        /// <item><description>If the parameter <c>SourceCidrIp</c> is specified, the parameter <c>SourceGroupOwnerId</c> is ignored.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>12345678910</para>
        /// </summary>
        [NameInMap("SourceGroupOwnerId")]
        [Validation(Required=false)]
        public long? SourceGroupOwnerId { get; set; }

        /// <summary>
        /// <para>The range of source ports that correspond to the transport-layer protocol. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>TCP/UDP: valid values are 1 to 65535. Separate the start port and the end port with a forward slash (/). Example: 1/200.</description></item>
        /// <item><description>ICMP: -1/-1.</description></item>
        /// <item><description>GRE: -1/-1.</description></item>
        /// <item><description>ALL: -1/-1.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>80/80</para>
        /// </summary>
        [NameInMap("SourcePortRange")]
        [Validation(Required=false)]
        public string SourcePortRange { get; set; }

        /// <summary>
        /// <para>Settings for the ID of the source prefix list for the access permissions. You can invoke <a href="https://help.aliyun.com/document_detail/205046.html">DescribePrefixLists</a> to query available prefix list IDs.</para>
        /// <para>This parameter is ignored if you specify one of the <c>SourceCidrIp</c>, <c>Ipv6SourceCidrIp</c>, or <c>SourceGroupId</c> parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pl-x1j1k5ykzqlixdcy****</para>
        /// </summary>
        [NameInMap("SourcePrefixListId")]
        [Validation(Required=false)]
        public string SourcePrefixListId { get; set; }

    }

}
