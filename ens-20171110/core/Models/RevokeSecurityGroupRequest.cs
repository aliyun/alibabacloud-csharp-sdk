// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class RevokeSecurityGroupRequest : TeaModel {
        /// <summary>
        /// <para>The transport layer protocol. The value of this parameter is case-sensitive. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>tcp</description></item>
        /// <item><description>udp</description></item>
        /// <item><description>icmp</description></item>
        /// <item><description>gre</description></item>
        /// <item><description>all: all protocols.</description></item>
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
        /// <para>The authorization policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>accept: allows access. This is the default value.</description></item>
        /// <item><description>drop: denies access and does not return responses.</description></item>
        /// </list>
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
        /// <item><description>When the IpProtocol parameter is set to tcp or udp, the port number range is <b>1</b> to <b>65535</b>. The start port number and the end port number are separated by a forward slash (/). Correct example: <b>1/200</b>. Incorrect example: <b>200/1</b>.</description></item>
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
        /// <para>The priority of the security group rule. Valid values: <b>1</b> to <b>100</b>. Default value: <b>1</b>.</para>
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
        /// <para>The source CIDR block. CIDR blocks and IPv4 addresses are supported. Default value: 0.0.XX.XX/0.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.XX.XX/8</para>
        /// </summary>
        [NameInMap("SourceCidrIp")]
        [Validation(Required=false)]
        public string SourceCidrIp { get; set; }

        /// <summary>
        /// <para>The range of source ports that correspond to the transport layer protocol for the security group rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>When the IpProtocol parameter is set to tcp or udp, the port number range is <b>1</b> to <b>65535</b>. The start port number and the end port number are separated by a forward slash (/). Correct example: <b>1/200</b>. Incorrect example: <b>200/1</b>.</description></item>
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
