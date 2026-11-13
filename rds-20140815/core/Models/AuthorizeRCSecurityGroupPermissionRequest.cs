// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class AuthorizeRCSecurityGroupPermissionRequest : TeaModel {
        /// <summary>
        /// <para>The direction of the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ingress</b>: inbound</description></item>
        /// <item><description><b>egress</b>: outbound</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ingress</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The security group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-2ze27hs990o2hn9****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The security group rules.</para>
        /// </summary>
        [NameInMap("SecurityGroupPermissions")]
        [Validation(Required=false)]
        public List<AuthorizeRCSecurityGroupPermissionRequestSecurityGroupPermissions> SecurityGroupPermissions { get; set; }
        public class AuthorizeRCSecurityGroupPermissionRequestSecurityGroupPermissions : TeaModel {
            /// <summary>
            /// <para>The destination IP address range for outbound authorization. CIDR format and IPv4 format IP addresses are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.0.1/12</para>
            /// </summary>
            [NameInMap("DestCidrIp")]
            [Validation(Required=false)]
            public string DestCidrIp { get; set; }

            /// <summary>
            /// <para>The protocol type. The value is not case-sensitive. Valid values: </para>
            /// <list type="bullet">
            /// <item><description><b>ICMP</b></description></item>
            /// <item><description><b>GRE</b></description></item>
            /// <item><description><b>TCP</b></description></item>
            /// <item><description><b>UDP</b></description></item>
            /// <item><description><b>ALL</b>: All protocols are supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("IpProtocol")]
            [Validation(Required=false)]
            public string IpProtocol { get; set; }

            /// <summary>
            /// <para>The authorization policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Accept</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <para>The range of destination ports for the transport layer protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>TCP or UDP: <b>1</b> to <b>65535</b>. Use a forward slash (/) to separate the start port and the end port. Correct example: <b>1/200</b>. Incorrect example: <b>200/1</b>.</description></item>
            /// <item><description>ICMP: <b>-1/-1</b>.</description></item>
            /// <item><description>GRE: <b>-1/-1</b>.</description></item>
            /// <item><description>ALL: <b>-1/-1</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>80/80</para>
            /// </summary>
            [NameInMap("PortRange")]
            [Validation(Required=false)]
            public string PortRange { get; set; }

            /// <summary>
            /// <para>The priority of the rule. Valid values: 1 to 100. A smaller value indicates a higher priority. If multiple rules have the same priority, the drop rule takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The source IP address range for inbound authorization. CIDR format and IPv4 format IP addresses are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.0.1/12</para>
            /// </summary>
            [NameInMap("SourceCidrIp")]
            [Validation(Required=false)]
            public string SourceCidrIp { get; set; }

            /// <summary>
            /// <para>The range of source ports for the transport layer protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>TCP or UDP: <b>1</b> to <b>65535</b>. Use a forward slash (/) to separate the start port and the end port. Correct example: <b>1/200</b>. Incorrect example: <b>200/1</b>.</description></item>
            /// <item><description>ICMP: <b>-1/-1</b>.</description></item>
            /// <item><description>GRE: <b>-1/-1</b>.</description></item>
            /// <item><description>ALL: <b>-1/-1</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>80/80</para>
            /// </summary>
            [NameInMap("SourcePortRange")]
            [Validation(Required=false)]
            public string SourcePortRange { get; set; }

        }

    }

}
