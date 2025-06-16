// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateTrafficMirrorFilterRulesRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the value, but you must make sure that it is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not set this parameter, the system uses <b>RequestId</b> as <b>ClientToken</b>. <b>RequestId</b> may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to check the request without performing the operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: checks the request without performing the operation. The system checks the required parameters, request format, and limits. If the request fails the precheck, an error message is returned. If the request passes the precheck, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): sends the request. After the request passes the check, the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The list of outbound rules.</para>
        /// </summary>
        [NameInMap("EgressRules")]
        [Validation(Required=false)]
        public List<CreateTrafficMirrorFilterRulesRequestEgressRules> EgressRules { get; set; }
        public class CreateTrafficMirrorFilterRulesRequestEgressRules : TeaModel {
            /// <summary>
            /// <para>The action of the outbound rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>accept</b>: accepts network traffic.</description></item>
            /// <item><description><b>drop</b>: drops network traffic.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>accept</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>The destination CIDR block of the outbound traffic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.0/24</para>
            /// </summary>
            [NameInMap("DestinationCidrBlock")]
            [Validation(Required=false)]
            public string DestinationCidrBlock { get; set; }

            /// <summary>
            /// <para>The destination port range of the outbound traffic. Valid values for a port: <b>1</b> to <b>65535</b>. Separate the first port and the last port with a forward slash (/). Examples: <b>1/200</b> and <b>80/80</b>. You cannot set this parameter to only <b>-1/-1</b>, which specifies all ports.</para>
            /// <remarks>
            /// <para> If you set <b>EgressRules.N.Protocol</b> to <b>ALL</b> or <b>ICMP</b>, you do not need to set this parameter. In this case, all ports are available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>22/40</para>
            /// </summary>
            [NameInMap("DestinationPortRange")]
            [Validation(Required=false)]
            public string DestinationPortRange { get; set; }

            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public string IpVersion { get; set; }

            /// <summary>
            /// <para>The priority of the outbound rule. A smaller value indicates a higher priority. The maximum value of <b>N</b> is <b>10</b>. You can configure up to 10 outbound rules for a filter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The protocol that is used by the outbound traffic to be mirrored. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ALL</b>: all protocols</description></item>
            /// <item><description><b>ICMP</b>: ICMP</description></item>
            /// <item><description><b>TCP</b>: TCP</description></item>
            /// <item><description><b>UDP</b>: UDP</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The source CIDR block of the outbound traffic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.0/24</para>
            /// </summary>
            [NameInMap("SourceCidrBlock")]
            [Validation(Required=false)]
            public string SourceCidrBlock { get; set; }

            /// <summary>
            /// <para>The source port range of the outbound traffic. Valid values for a port: <b>1</b> to <b>65535</b>. Separate the first port and the last port with a forward slash (/). Examples: <b>1/200</b> and <b>80/80</b>. You cannot set this parameter to only <b>-1/-1</b>, which specifies all ports.</para>
            /// <remarks>
            /// <para> If you set <b>EgressRules.N.Protocol</b> to <b>ALL</b> or <b>ICMP</b>, you do not need to set this parameter. In this case, all ports are available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>22/40</para>
            /// </summary>
            [NameInMap("SourcePortRange")]
            [Validation(Required=false)]
            public string SourcePortRange { get; set; }

        }

        /// <summary>
        /// <para>The list of inbound rules.</para>
        /// </summary>
        [NameInMap("IngressRules")]
        [Validation(Required=false)]
        public List<CreateTrafficMirrorFilterRulesRequestIngressRules> IngressRules { get; set; }
        public class CreateTrafficMirrorFilterRulesRequestIngressRules : TeaModel {
            /// <summary>
            /// <para>The action of the inbound rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>accept</b>: accepts network traffic.</description></item>
            /// <item><description><b>drop</b>: drops network traffic.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>accept</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>The destination CIDR block of the inbound traffic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.0/24</para>
            /// </summary>
            [NameInMap("DestinationCidrBlock")]
            [Validation(Required=false)]
            public string DestinationCidrBlock { get; set; }

            /// <summary>
            /// <para>The destination port range of the inbound traffic. Valid values for a port: <b>1</b> to <b>65535</b>. Separate the first port and the last port with a forward slash (/). Examples: <b>1/200</b> and <b>80/80</b>.</para>
            /// <remarks>
            /// <para> If you set <b>IngressRules.N.Protocol</b> to <b>ALL</b> or <b>ICMP</b>, you do not need to set this parameter. In this case, all ports are available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>80/120</para>
            /// </summary>
            [NameInMap("DestinationPortRange")]
            [Validation(Required=false)]
            public string DestinationPortRange { get; set; }

            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public string IpVersion { get; set; }

            /// <summary>
            /// <para>The priority of the inbound rule. A smaller value indicates a higher priority. The maximum value of <b>N</b> is <b>10</b>. You can configure up to 10 inbound rules for a filter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The protocol that is used by the inbound traffic to be mirrored. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ALL</b>: all protocols</description></item>
            /// <item><description><b>ICMP</b>: Internet Control Message Protocol (ICMP)</description></item>
            /// <item><description><b>TCP</b>: TCP</description></item>
            /// <item><description><b>UDP</b>: User Datagram Protocol (UDP)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The source CIDR block of the inbound traffic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.0/24</para>
            /// </summary>
            [NameInMap("SourceCidrBlock")]
            [Validation(Required=false)]
            public string SourceCidrBlock { get; set; }

            /// <summary>
            /// <para>The source port range of the inbound traffic. Valid values for a port: <b>1</b> to <b>65535</b>. Separate the first port and the last port with a forward slash (/). Examples: <b>1/200</b> and <b>80/80</b>. You cannot set this parameter to only <b>-1/-1</b>, which specifies all ports.</para>
            /// <remarks>
            /// <para> If you set <b>IngressRules.N.Protocol</b> to <b>ALL</b> or <b>ICMP</b>, you do not need to set this parameter. In this case, all ports are available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>80/120</para>
            /// </summary>
            [NameInMap("SourcePortRange")]
            [Validation(Required=false)]
            public string SourcePortRange { get; set; }

        }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region to which the mirrored traffic belongs.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list. For more information about regions that support traffic mirroring, see <a href="https://help.aliyun.com/document_detail/207513.html">Overview of traffic mirroring</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hongkong</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the filter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tmf-j6cmls82xnc86vtpe****</para>
        /// </summary>
        [NameInMap("TrafficMirrorFilterId")]
        [Validation(Required=false)]
        public string TrafficMirrorFilterId { get; set; }

    }

}
