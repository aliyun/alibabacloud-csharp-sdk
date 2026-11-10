// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class CreateTransitRouterPolicyBasedRouteRequest : TeaModel {
        /// <summary>
        /// <para>The address family. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>IPv4</description></item>
        /// <item><description>IPv6</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>IPv4</para>
        /// </summary>
        [NameInMap("AddressFamily")]
        [Validation(Required=false)]
        public string AddressFamily { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the value, but you must ensure that it is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request may be different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the policy-based route.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desctest</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The destination port. Valid values: <b>-1</b> or <b>1</b> to <b>65535</b>.</para>
        /// <para>This parameter matches traffic whose port numbers fall within the destination port range. If you do not specify this parameter, traffic to any destination port is matched.</para>
        /// <para>The port range is specified in the following formats:</para>
        /// <list type="bullet">
        /// <item><description>80: port 80.</description></item>
        /// <item><description>80/80: port 80.</description></item>
        /// <item><description>1/200: ports 1 to 200.</description></item>
        /// <item><description>-1/-1: all ports.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>80/80</para>
        /// </summary>
        [NameInMap("DestPortRange")]
        [Validation(Required=false)]
        public string DestPortRange { get; set; }

        /// <summary>
        /// <para>The destination CIDR block of the route entry. Both IPv4 and IPv6 addresses are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.19.2.0/24</para>
        /// </summary>
        [NameInMap("DestinationCidr")]
        [Validation(Required=false)]
        public string DestinationCidr { get; set; }

        /// <summary>
        /// <para>Specifies whether to only precheck the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: prechecks the request without creating the routing rule entry in the policy route table. The system checks whether required parameters are specified, the request format, and service limits. If the request fails the precheck, the corresponding error is returned. If the request passes the precheck, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): sends the request. After the request passes the precheck, the routing rule entry is created in the policy route table.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The Differentiated Services Code Point (DSCP) value of the traffic packet to be matched. Valid values: <b>0</b> to <b>63</b>.</para>
        /// <para>The DSCP range is specified in the following formats:</para>
        /// <list type="bullet">
        /// <item><description>1: traffic with a DSCP value of 1.</description></item>
        /// <item><description>1/10: traffic with a DSCP value from 1 to 10.</description></item>
        /// <item><description>-1/-1: traffic with any DSCP value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Dscp")]
        [Validation(Required=false)]
        public string Dscp { get; set; }

        /// <summary>
        /// <para>The name of the policy-based route.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nametest</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The instance ID of the policy routing table.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ptbl-abc123xyz</para>
        /// </summary>
        [NameInMap("PolicyTableId")]
        [Validation(Required=false)]
        public string PolicyTableId { get; set; }

        /// <summary>
        /// <para>The priority of the policy-based route. Valid values: <b>1</b> to <b>100</b>.</para>
        /// <para>The priority of each policy-based route in a policy route table of a transit router must be unique. A smaller value indicates a higher priority.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The protocol type of the traffic packet.</para>
        /// <para>Traffic classification rules support matching traffic of various protocol types, such as <b>HTTP</b>, <b>HTTPS</b>, <b>TCP</b>, <b>UDP</b>, <b>SSH</b>, and <b>Telnet</b>. For more protocol types, log on to the <a href="https://cen.console.aliyun.com/cen/list">Cloud Enterprise Network (CEN) console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ICMP</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The source CIDR block. The source CIDR block must be in CIDR format. Example: 192.168.1.0/24.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.0/8</para>
        /// </summary>
        [NameInMap("SourceCidr")]
        [Validation(Required=false)]
        public string SourceCidr { get; set; }

        /// <summary>
        /// <para>The source port. Valid values: <b>-1</b> or <b>1</b> to <b>65535</b>.</para>
        /// <para>This parameter matches traffic whose port numbers fall within the source port range. If you do not specify this parameter, traffic from any source port is matched.</para>
        /// <para>The port range is specified in the following formats:</para>
        /// <list type="bullet">
        /// <item><description>80: port 80.</description></item>
        /// <item><description>80/80: port 80.</description></item>
        /// <item><description>1/200: ports 1 to 200.</description></item>
        /// <item><description>-1/-1: all ports.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>80/80</para>
        /// </summary>
        [NameInMap("SourcePortRange")]
        [Validation(Required=false)]
        public string SourcePortRange { get; set; }

        /// <summary>
        /// <para>The destination route table.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vtb-123abcxyz</para>
        /// </summary>
        [NameInMap("TargetRouteTableId")]
        [Validation(Required=false)]
        public string TargetRouteTableId { get; set; }

    }

}
