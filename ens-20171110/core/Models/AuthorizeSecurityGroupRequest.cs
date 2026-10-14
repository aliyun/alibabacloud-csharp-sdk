// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class AuthorizeSecurityGroupRequest : TeaModel {
        /// <summary>
        /// <para>The transport-layer protocol. The value is case-sensitive. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>tcp</description></item>
        /// <item><description>udp</description></item>
        /// <item><description>icmp</description></item>
        /// <item><description>gre</description></item>
        /// <item><description>all: all protocols are supported</description></item>
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
        /// <item><description>accept: accepts access.</description></item>
        /// <item><description>drop: deny access without returning a rejection message.</description></item>
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
        /// <para>The range of port numbers for the transport-layer protocol of the security group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>TCP/UDP protocol: valid values are <b>1</b> to <b>65535</b>. Separate the start port and the end port with a forward slash (/). Correct example: <b>1/200</b>. Incorrect example: <b>200/1</b>.</description></item>
        /// <item><description>ICMP protocol: <b>-1/-1</b>.</description></item>
        /// <item><description>GRE protocol: <b>-1/-1</b>.</description></item>
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
        /// <para>The priority of the security group rule. Valid values: <b>1</b> to <b>100</b>.</para>
        /// <para>Default value: <b>1</b>.</para>
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
        /// <para>sg-bp67acfmxazb4ph***</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The source IP address range. CIDR blocks and IPv4 addresses are supported.</para>
        /// <para>Default value: none.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.XX.XX/8</para>
        /// </summary>
        [NameInMap("SourceCidrIp")]
        [Validation(Required=false)]
        public string SourceCidrIp { get; set; }

        /// <summary>
        /// <para>The range of port numbers for the transport-layer protocol of the source security group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>TCP/UDP protocol: valid values are <b>1</b> to <b>65535</b>. Separate the start port and the end port with a forward slash (/). Correct example: <b>1/200</b>. Incorrect example: <b>200/1</b>.</description></item>
        /// <item><description>ICMP protocol: <b>-1/-1</b>.</description></item>
        /// <item><description>GRE protocol: <b>-1/-1</b>.</description></item>
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
