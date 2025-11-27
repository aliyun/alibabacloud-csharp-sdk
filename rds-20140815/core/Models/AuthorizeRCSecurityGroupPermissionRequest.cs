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
        /// <item><description><b>ingress</b>: the inbound security group rule.</description></item>
        /// <item><description><b>egress</b>: the outbound security group rule.</description></item>
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
        /// <para>The ID of the security group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-2ze27hs990o2hn9****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The information about the security group.</para>
        /// </summary>
        [NameInMap("SecurityGroupPermissions")]
        [Validation(Required=false)]
        public List<AuthorizeRCSecurityGroupPermissionRequestSecurityGroupPermissions> SecurityGroupPermissions { get; set; }
        public class AuthorizeRCSecurityGroupPermissionRequestSecurityGroupPermissions : TeaModel {
            /// <summary>
            /// <para>The destination CIDR block for outbound access control. CIDR blocks and IPv4 addresses are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.0.1/12</para>
            /// </summary>
            [NameInMap("DestCidrIp")]
            [Validation(Required=false)]
            public string DestCidrIp { get; set; }

            /// <summary>
            /// <para>The protocol type supported by the rule. The value is not case-sensitive. Valid values:</para>
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
            /// <para>The action that you want to specify in the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Accept</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <para>The range of destination ports that correspond to the transport layer protocol of the destination security group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>The value is in the X/Y format when IpProtocol is set to TCP or UDP. X specifies the start port number and Y specifies the end port number. X and Y range from <b>1</b> to <b>65535</b>. The start port number and the end port number are separated by a forward slash (/). Correct example: <b>1/200</b>. Incorrect example: <b>200/1</b>.</description></item>
            /// <item><description>Valid value when IpProtocol is set to ICMP: <b>-1/-1</b>.</description></item>
            /// <item><description>Valid value when IpProtocol is set to GRE: <b>-1/-1</b>.</description></item>
            /// <item><description>Valid value when IpProtocol is set to ALL: <b>-1/-1</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>80/80</para>
            /// </summary>
            [NameInMap("PortRange")]
            [Validation(Required=false)]
            public string PortRange { get; set; }

            /// <summary>
            /// <para>The priority of the rule. Valid values: 1 to 100. A smaller value indicates a higher priority. When multiple security group rules have the same priority, drop rules take precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The source CIDR block for inbound access control. CIDR blocks and IPv4 addresses are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.0.1/12</para>
            /// </summary>
            [NameInMap("SourceCidrIp")]
            [Validation(Required=false)]
            public string SourceCidrIp { get; set; }

            /// <summary>
            /// <para>The range of port numbers that correspond to the transport layer protocol for the source security group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>The value is in the X/Y format when IpProtocol is set to TCP or UDP. X specifies the start port number and Y specifies the end port number. X and Y range from <b>1</b> to <b>65535</b>. The start port number and the end port number are separated by a forward slash (/). Correct example: <b>1/200</b>. Incorrect example: <b>200/1</b>.</description></item>
            /// <item><description>Valid value when IpProtocol is set to ICMP: <b>-1/-1</b>.</description></item>
            /// <item><description>Valid value when IpProtocol is set to GRE: <b>-1/-1</b>.</description></item>
            /// <item><description>Valid value when IpProtocol is set to ALL: <b>-1/-1</b>.</description></item>
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
