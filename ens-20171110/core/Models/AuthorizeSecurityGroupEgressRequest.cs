// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class AuthorizeSecurityGroupEgressRequest : TeaModel {
        /// <summary>
        /// <para>The destination IP addresses. CIDR blocks and IPv4 addresses are supported.</para>
        /// <para>This parameter is empty by default.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.XX.XX/8</para>
        /// </summary>
        [NameInMap("DestCidrIp")]
        [Validation(Required=false)]
        public string DestCidrIp { get; set; }

        /// <summary>
        /// <para>The transport layer protocol. The value of this parameter is case-sensitive. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>tcp</para>
        /// </description></item>
        /// <item><description><para>udp</para>
        /// </description></item>
        /// <item><description><para>icmp</para>
        /// </description></item>
        /// <item><description><para>gre</para>
        /// </description></item>
        /// <item><description><para>all: All protocols are supported.</para>
        /// </description></item>
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
        /// <para>The action of the security group rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>accept: allows access. This is the default value.</para>
        /// </description></item>
        /// <item><description><para>drop: denies access and does not return responses.</para>
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
        /// <para>The range of destination ports that correspond to the transport layer protocol for security group rule N. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>When the IpProtocol parameter is set to tcp or udp, the port number range is <b>1</b> to <b>65535</b>. The start port number and the end port number are separated by a forward slash (/). Correct example: <b>1/200</b>. Incorrect example: <b>200/1</b>.</para>
        /// </description></item>
        /// <item><description><para>When the IpProtocol parameter is set to icmp, the port number range is <b>-1/-1</b>, which indicates all ports.</para>
        /// </description></item>
        /// <item><description><para>When the IpProtocol parameter is set to gre, the port number range is <b>-1/-1</b>, which indicates all ports.</para>
        /// </description></item>
        /// <item><description><para>When the IpProtocol parameter is set to all, the port number range is <b>-1/-1</b>, which indicates all ports.</para>
        /// </description></item>
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
        /// <para>The priority of security group rule N. Valid values: <b>1 to 100</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

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
        /// <para>The range of port numbers that correspond to the transport layer protocol for the source security group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>When the IpProtocol parameter is set to tcp or udp, the port number range is <b>1</b> to <b>65535</b>. The start port number and the end port number are separated by a forward slash (/). Correct example: <b>1/200</b>. Incorrect example: <b>200/1</b>.</para>
        /// </description></item>
        /// <item><description><para>When the IpProtocol parameter is set to icmp, the port number range is <b>-1/-1</b>, which indicates all ports.</para>
        /// </description></item>
        /// <item><description><para>When the IpProtocol parameter is set to gre, the port number range is <b>-1/-1</b>, which indicates all ports.</para>
        /// </description></item>
        /// <item><description><para>When the IpProtocol parameter is set to all, the port number range is <b>-1/-1</b>, which indicates all ports.</para>
        /// </description></item>
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
