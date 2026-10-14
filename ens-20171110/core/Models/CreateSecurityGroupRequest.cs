// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateSecurityGroupRequest : TeaModel {
        /// <summary>
        /// <para>The description of the security group. The description must be 2 to 256 characters in length. It must start with a letter and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The rules of the security group. Valid values of N: 0 to 200.</para>
        /// </summary>
        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public List<CreateSecurityGroupRequestPermissions> Permissions { get; set; }
        public class CreateSecurityGroupRequestPermissions : TeaModel {
            /// <summary>
            /// <para>The description of the security group rule. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testDescription</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The destination IPv4 CIDR block. CIDR blocks and IPv4 addresses are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0.0.0/0</para>
            /// </summary>
            [NameInMap("DestCidrIp")]
            [Validation(Required=false)]
            public string DestCidrIp { get; set; }

            /// <summary>
            /// <para>The direction of the security group rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>egress: outbound</para>
            /// </description></item>
            /// <item><description><para>ingress: inbound</para>
            /// </description></item>
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
            /// <para>The transport layer protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>TCP</para>
            /// </description></item>
            /// <item><description><para>UDP</para>
            /// </description></item>
            /// <item><description><para>ICMP</para>
            /// </description></item>
            /// <item><description><para>ALL</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("IpProtocol")]
            [Validation(Required=false)]
            public string IpProtocol { get; set; }

            [NameInMap("Ipv6DestCidrIp")]
            [Validation(Required=false)]
            public string Ipv6DestCidrIp { get; set; }

            [NameInMap("Ipv6SourceCidrIp")]
            [Validation(Required=false)]
            public string Ipv6SourceCidrIp { get; set; }

            /// <summary>
            /// <para>The policy of the security group rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Accept: allows access.</para>
            /// </description></item>
            /// <item><description><para>Drop: denies access.</para>
            /// </description></item>
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
            /// <para>The range of the destination ports for the security group rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>If you set the IpProtocol to TCP or UDP, the port range is 1 to 65535. You must use a forward slash (/) to separate the start port and the end port, for example, 1/200.</para>
            /// </description></item>
            /// <item><description><para>If you set the IpProtocol to ICMP, the port range is -1/-1.</para>
            /// </description></item>
            /// <item><description><para>If you set the IpProtocol to ALL, the port range is -1/-1.</para>
            /// </description></item>
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
            /// <para>The source IPv4 CIDR block. CIDR blocks and IPv4 addresses are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0.0.0/0</para>
            /// </summary>
            [NameInMap("SourceCidrIp")]
            [Validation(Required=false)]
            public string SourceCidrIp { get; set; }

            /// <summary>
            /// <para>The range of the source ports for the security group rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>If you set the IpProtocol to TCP or UDP, the port range is 1 to 65535. You must use a forward slash (/) to separate the start port and the end port, for example, 1/200.</para>
            /// </description></item>
            /// <item><description><para>If you set the IpProtocol to ICMP, the port range is -1/-1.</para>
            /// </description></item>
            /// <item><description><para>If you set the IpProtocol to ALL, the port range is -1/-1.</para>
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

        /// <summary>
        /// <para>The name of the security group. The name must be 2 to 128 characters in length, and can contain digits, colons (:), underscores (_), and hyphens (-). It must start with a letter and cannot start with <c>http://</c> or <c>https://</c>. By default, this parameter is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Dcdn1:2_3-4</para>
        /// </summary>
        [NameInMap("SecurityGroupName")]
        [Validation(Required=false)]
        public string SecurityGroupName { get; set; }

    }

}
