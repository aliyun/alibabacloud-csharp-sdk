// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateSecurityGroupPermissionsRequest : TeaModel {
        /// <summary>
        /// <para>The security group rules.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public List<CreateSecurityGroupPermissionsRequestPermissions> Permissions { get; set; }
        public class CreateSecurityGroupPermissionsRequestPermissions : TeaModel {
            /// <summary>
            /// <para>The description. The description must be 2 to 256 characters in length and cannot start with http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testDescription</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The destination IPv4 CIDR block. Both CIDR format and IPv4 format IP address range are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.XX.XX.14/32</para>
            /// </summary>
            [NameInMap("DestCidrIp")]
            [Validation(Required=false)]
            public string DestCidrIp { get; set; }

            /// <summary>
            /// <para>The authorization direction. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>egress: outbound.</description></item>
            /// <item><description>ingress: inbound.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ingress</para>
            /// </summary>
            [NameInMap("Direction")]
            [Validation(Required=false)]
            public string Direction { get; set; }

            /// <summary>
            /// <para>The protocol type. Valid values: </para>
            /// <list type="bullet">
            /// <item><description>TCP: TCP protocol.</description></item>
            /// <item><description>UDP: UDP protocol.</description></item>
            /// <item><description>ICMP: ICMP protocol.</description></item>
            /// <item><description>ICMPv6: ICMPv6 protocol.</description></item>
            /// <item><description>ALL: All protocols are supported.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("IpProtocol")]
            [Validation(Required=false)]
            public string IpProtocol { get; set; }

            /// <summary>
            /// <para>The destination IPv6 CIDR block. Both CIDR format and IPv6 format IP address range are supported. </para>
            /// <remarks>
            /// <para>This parameter and the <c>DestCidrIp</c> parameter cannot be set at the same time. Settings for these two parameters are mutually exclusive.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>::/0</para>
            /// </summary>
            [NameInMap("Ipv6DestCidrIp")]
            [Validation(Required=false)]
            public string Ipv6DestCidrIp { get; set; }

            /// <summary>
            /// <para>The source IPv6 CIDR block. Both CIDR format and IPv6 format IP address range are supported.</para>
            /// <remarks>
            /// <para>This parameter and the <c>DestCidrIp</c> parameter cannot be set at the same time. Settings for these two parameters are mutually exclusive.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>::/0</para>
            /// </summary>
            [NameInMap("Ipv6SourceCidrIp")]
            [Validation(Required=false)]
            public string Ipv6SourceCidrIp { get; set; }

            /// <summary>
            /// <para>The access permissions. Valid values: </para>
            /// <list type="bullet">
            /// <item><description>Accept: Allows access.</description></item>
            /// <item><description>Drop: Deny access.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Accept</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <para>The range of destination ports that correspond to the protocols for the security group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>TCP/UDP protocol: Valid values are 1 to 65535. Separate the start port and end port with a forward slash (/). Example: 1/200.</description></item>
            /// <item><description>ICMP protocol: -1/-1.</description></item>
            /// <item><description>ICMPv6: -1/-1.</description></item>
            /// <item><description>ALL: -1/-1.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80/80</para>
            /// </summary>
            [NameInMap("PortRange")]
            [Validation(Required=false)]
            public string PortRange { get; set; }

            /// <summary>
            /// <para>The priority of the security group rule. A smaller value indicates a higher priority. Valid values: 1 to 100.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The source IPv4 CIDR block. Both CIDR format and IPv4 format IP address range are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0.0.0/0</para>
            /// </summary>
            [NameInMap("SourceCidrIp")]
            [Validation(Required=false)]
            public string SourceCidrIp { get; set; }

            /// <summary>
            /// <para>The range of source ports that correspond to the protocols for the security group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>TCP/UDP protocol: Valid values are 1 to 65535. Separate the start port and end port with a forward slash (/). Example: 1/200.</description></item>
            /// <item><description>ICMP protocol: -1/-1.</description></item>
            /// <item><description>ICMPv6: -1/-1.</description></item>
            /// <item><description>ALL: -1/-1.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>22/22</para>
            /// </summary>
            [NameInMap("SourcePortRange")]
            [Validation(Required=false)]
            public string SourcePortRange { get; set; }

        }

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

    }

}
