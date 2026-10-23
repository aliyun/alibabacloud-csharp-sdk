// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifySecurityGroupRuleRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
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
        /// <para>The destination IPv4 CIDR block. CIDR format and IPv4 format IP address ranges are supported.</para>
        /// <para>Default value: none.</para>
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
        /// <item><description>Protocol numbers that comply with the IANA standard, which are integers from 0 to 255. Supported regions:</description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description>Philippines</description></item>
        /// <item><description>UK</description></item>
        /// <item><description>Malaysia</description></item>
        /// <item><description>Hohhot</description></item>
        /// <item><description>Qingdao</description></item>
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
        /// <para>The destination IPv6 CIDR block. CIDR format and IPv6 format IP address ranges are supported.</para>
        /// <remarks>
        /// <para>Only VPC-type IP addresses are supported. This parameter and the DestCidrIp parameter cannot be specified at the same time.</para>
        /// </remarks>
        /// <para>Default value: none.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2001:db8:1234:1a00::***</para>
        /// </summary>
        [NameInMap("Ipv6DestCidrIp")]
        [Validation(Required=false)]
        public string Ipv6DestCidrIp { get; set; }

        /// <summary>
        /// <para>The source IPv6 CIDR block. CIDR format and IPv6 format IP address ranges are supported.</para>
        /// <remarks>
        /// <para>Only VPC-type IP addresses are supported. This parameter and the SourceCidrIp parameter cannot be specified at the same time.</para>
        /// </remarks>
        /// <para>Default value: none.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2001:db8:1233:1a00::***</para>
        /// </summary>
        [NameInMap("Ipv6SourceCidrIp")]
        [Validation(Required=false)]
        public string Ipv6SourceCidrIp { get; set; }

        /// <summary>
        /// <para>The NIC type.</para>
        /// <remarks>
        /// <para>You cannot modify this parameter when you modify a rule by specifying the security group rule ID. To modify this parameter, add a new rule and then delete the current rule.</para>
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
        /// <para>The access permission. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>accept: allows access.</description></item>
        /// <item><description>drop: denies access and does not return a rejection message.</description></item>
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
        /// <para>The range of destination ports that are open for the transport layer protocol in the destination security group. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>For TCP and UDP: 1 to 65535. Use a forward slash (/) to separate the start port and the end port. Example: 1/200.</description></item>
        /// <item><description>For ICMP: -1/-1.</description></item>
        /// <item><description>For GRE: -1/-1.</description></item>
        /// <item><description>For ALL: -1/-1.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>80/80</para>
        /// </summary>
        [NameInMap("PortRange")]
        [Validation(Required=false)]
        public string PortRange { get; set; }

        /// <summary>
        /// <para>The ID of the port list.</para>
        /// <para>You can call the DescribePortRangeLists operation to query the IDs of available port lists.</para>
        /// <para>If you specify the PortRange parameter, this parameter is ignored.</para>
        /// <para>For more information, see <a href="~~25412#SecurityGroupQuota1~~">Security group limits</a>.</para>
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
        /// <para>The region ID of the target security group. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
        /// <para>The ID of the security group rule. You can call the <a href="https://help.aliyun.com/document_detail/2679845.html">DescribeSecurityGroupAttribute</a> operation to query the security group rule ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sgr-bp67acfmxa123b***</para>
        /// </summary>
        [NameInMap("SecurityGroupRuleId")]
        [Validation(Required=false)]
        public string SecurityGroupRuleId { get; set; }

        /// <summary>
        /// <para>The source IPv4 CIDR block. CIDR format and IPv4 format IP address ranges are supported.</para>
        /// <para>Default value: none.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.0/8</para>
        /// </summary>
        [NameInMap("SourceCidrIp")]
        [Validation(Required=false)]
        public string SourceCidrIp { get; set; }

        /// <summary>
        /// <para>The ID of the source security group. You must specify at least one of the SourceGroupId and SourceCidrIp parameters.</para>
        /// <list type="bullet">
        /// <item><description>If you specify SourceGroupId but do not specify SourceCidrIp, the NicType parameter can only be set to intranet.</description></item>
        /// <item><description>If you specify both SourceGroupId and SourceCidrIp, SourceCidrIp takes precedence by default.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp67acfmxa123b****</para>
        /// </summary>
        [NameInMap("SourceGroupId")]
        [Validation(Required=false)]
        public string SourceGroupId { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account to which the source security group belongs when you configure a security group rule across accounts. </para>
        /// <list type="bullet">
        /// <item><description>If neither SourceGroupOwnerAccount nor SourceGroupOwnerId is specified, the rule is considered to configure the access permissions for another security group of your own.</description></item>
        /// <item><description>If the SourceCidrIp parameter is specified, the SourceGroupOwnerAccount parameter is invalid.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:EcsforCloud@Alibaba.com">EcsforCloud@Alibaba.com</a></para>
        /// </summary>
        [NameInMap("SourceGroupOwnerAccount")]
        [Validation(Required=false)]
        public string SourceGroupOwnerAccount { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account to which the source security group belongs when you configure a security group rule across accounts. </para>
        /// <list type="bullet">
        /// <item><description>If neither SourceGroupOwnerId nor SourceGroupOwnerAccount is specified, the rule is considered to configure the access permissions for another security group of your own.</description></item>
        /// <item><description>If the SourceCidrIp parameter is specified, the SourceGroupOwnerId parameter is invalid.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>12345678910</para>
        /// </summary>
        [NameInMap("SourceGroupOwnerId")]
        [Validation(Required=false)]
        public long? SourceGroupOwnerId { get; set; }

        /// <summary>
        /// <para>The range of source ports that are open for the transport layer protocol in the source security group. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>For TCP and UDP: 1 to 65535. Use a forward slash (/) to separate the start port and the end port. Example: 1/200.</description></item>
        /// <item><description>For ICMP: -1/-1.</description></item>
        /// <item><description>For GRE: -1/-1.</description></item>
        /// <item><description>For ALL: -1/-1.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>80/80</para>
        /// </summary>
        [NameInMap("SourcePortRange")]
        [Validation(Required=false)]
        public string SourcePortRange { get; set; }

        /// <summary>
        /// <para>The ID of the source prefix list. You can call the <a href="https://help.aliyun.com/document_detail/205046.html">DescribePrefixLists</a> operation to query the IDs of available prefix lists.</para>
        /// <para>If you specify one of the SourceCidrIp, Ipv6SourceCidrIp, or SourceGroupId parameters, this parameter is ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pl-x1j1k5ykzqlixdcy****</para>
        /// </summary>
        [NameInMap("SourcePrefixListId")]
        [Validation(Required=false)]
        public string SourcePrefixListId { get; set; }

    }

}
