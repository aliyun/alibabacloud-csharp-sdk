// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class AuthorizeSecurityGroupEgressRequest : TeaModel {
        /// <summary>
        /// <para>The destination IP address range. CIDR blocks and IPv4 address ranges are supported.</para>
        /// <para>Default value: none.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.XX.XX/8</para>
        /// </summary>
        [NameInMap("DestCidrIp")]
        [Validation(Required=false)]
        public string DestCidrIp { get; set; }

        /// <summary>
        /// <para>The transport layer protocol. The value is case-sensitive. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>tcp: TCP.</description></item>
        /// <item><description>udp: UDP.</description></item>
        /// <item><description>icmp: ICMP.</description></item>
        /// <item><description>gre: GRE.</description></item>
        /// <item><description>all: All protocols.</description></item>
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
        /// <item><description>accept (default): accept access.</description></item>
        /// <item><description>drop: deny access without returning a deny message.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>accept</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// <para>The range of ports enabled for the transport layer protocol in the security group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>For TCP or UDP: <b>1</b> to <b>65535</b>. Use a forward slash (/) to separate the start port and the end port. Correct example: <b>1/200</b>. Incorrect example: <b>200/1</b>.</description></item>
        /// <item><description>For ICMP: <b>-1/-1</b>.</description></item>
        /// <item><description>For GRE: <b>-1/-1</b>.</description></item>
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
        /// <para>The range of ports enabled for the transport layer protocol in the source security group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>For TCP or UDP: <b>1</b> to <b>65535</b>. Use a forward slash (/) to separate the start port and the end port. Correct example: <b>1/200</b>. Incorrect example: <b>200/1</b>.</description></item>
        /// <item><description>For ICMP: <b>-1/-1</b>.</description></item>
        /// <item><description>For GRE: <b>-1/-1</b>.</description></item>
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
