// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class RevokeSecurityGroupEgressRequest : TeaModel {
        /// <summary>
        /// <para>The destination IP addresses. CIDR blocks and IPv4 addresses are supported.</para>
        /// <para>By default, this parameter is empty.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.0/8</para>
        /// </summary>
        [NameInMap("DestCidrIp")]
        [Validation(Required=false)]
        public string DestCidrIp { get; set; }

        /// <summary>
        /// <para>The transport layer protocol. The value of this parameter is case-sensitive. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>tcp</description></item>
        /// <item><description>udp</description></item>
        /// <item><description>icmp</description></item>
        /// <item><description>gre</description></item>
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
        /// <para>The action of the security group rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>accept</b>: allows access.</description></item>
        /// <item><description><b>drop</b>: denies access and returns no responses.</description></item>
        /// </list>
        /// <para>Default value: <b>accept</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>accept</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// <para>The range of destination ports that correspond to the transport layer protocol for the security group rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If you set the IpProtocol parameter to tcp or udp, the port number ranges from <b>1</b> to <b>65535</b>. The start port number and the end port number are separated by a forward slash (/). Correct example: <b>1/200</b>. Incorrect example: <b>200/1</b>.</description></item>
        /// <item><description>When the IpProtocol parameter is set to icmp, the port number range is <b>-1/-1</b>, which indicates all ports.</description></item>
        /// <item><description>When the IpProtocol parameter is set to gre, the port number range is <b>-1/-1</b>, which indicates all ports.</description></item>
        /// <item><description>When the IpProtocol parameter is set to all, the port number range is <b>-1/-1</b>, which indicates all ports.</description></item>
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
        /// <para>The priority of the security group rule. Valid values: <b>1</b> to <b>100</b>. A smaller value indicates a higher priority.</para>
        /// <para>Default value: <b>1</b>.</para>
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
        /// <para>sg-bp67acfmxazb4ph***</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The range of port numbers that correspond to the transport layer protocol for the source security group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If you set the IpProtocol parameter to tcp or udp, the port number ranges from <b>1</b> to <b>65535</b>. The start port number and the end port number are separated by a forward slash (/). Correct example: <b>1/200</b>. Incorrect example: <b>200/1</b>.</description></item>
        /// <item><description>When the IpProtocol parameter is set to icmp, the port number range is <b>-1/-1</b>, which indicates all ports.</description></item>
        /// <item><description>When the IpProtocol parameter is set to gre, the port number range is <b>-1/-1</b>, which indicates all ports.</description></item>
        /// <item><description>When the IpProtocol parameter is set to all, the port number range is <b>-1/-1</b>, which indicates all ports.</description></item>
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
