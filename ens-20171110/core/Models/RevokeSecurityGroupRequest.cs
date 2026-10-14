// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class RevokeSecurityGroupRequest : TeaModel {
        /// <summary>
        /// <para>The transport layer protocol. The value is case-sensitive. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>tcp: TCP.</description></item>
        /// <item><description>udp: UDP.</description></item>
        /// <item><description>icmp: ICMP.</description></item>
        /// <item><description>gre: GRE.</description></item>
        /// <item><description>all: All protocols are supported.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("IpProtocol")]
        [Validation(Required=false)]
        public string IpProtocol { get; set; }

        /// <summary>
        /// <para>Settings for access permissions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>accept (default): Accepts access.</description></item>
        /// <item><description>drop: Deny access without returning a deny message.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>accept</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// <para>The range of destination port numbers relevant to the transport layer protocol for the security group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>TCP/UDP: Valid values are <b>1</b> to <b>65535</b>. Separate the start port and end port with a forward slash (/). Correct example: <b>1/200</b>. Incorrect example: <b>200/1</b>.</description></item>
        /// <item><description>ICMP: <b>-1/-1</b>.</description></item>
        /// <item><description>GRE: <b>-1/-1</b>.</description></item>
        /// <item><description>If IpProtocol is set to all: <b>-1/-1</b>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22/22</para>
        /// </summary>
        [NameInMap("PortRange")]
        [Validation(Required=false)]
        public string PortRange { get; set; }

        /// <summary>
        /// <para>The priority of the security group rule. Valid values: <b>1</b> to <b>100</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

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
        /// <para>The source IP address range. CIDR format and IPv4 format are supported. Default value: 0.0.XX.XX/0.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.XX.XX/8</para>
        /// </summary>
        [NameInMap("SourceCidrIp")]
        [Validation(Required=false)]
        public string SourceCidrIp { get; set; }

        /// <summary>
        /// <para>The range of source port numbers relevant to the transport layer protocol for the security group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>TCP/UDP: Valid values are <b>1</b> to <b>65535</b>. Separate the start port and end port with a forward slash (/). Correct example: <b>1/200</b>. Incorrect example: <b>200/1</b>.</description></item>
        /// <item><description>ICMP: <b>-1/-1</b>.</description></item>
        /// <item><description>GRE: <b>-1/-1</b>.</description></item>
        /// <item><description>If IpProtocol is set to all: <b>-1/-1</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>22/22</para>
        /// </summary>
        [NameInMap("SourcePortRange")]
        [Validation(Required=false)]
        public string SourcePortRange { get; set; }

    }

}
