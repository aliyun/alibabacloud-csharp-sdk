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
        /// <para>You can generate the value from your client and make sure that the value is unique across different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request may be different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to only precheck the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The system prechecks the request but does not create the inbound or outbound rules. The system checks whether the required parameters are specified, the request format, and the limits. If the request fails the precheck, the system returns an error. If the request passes the precheck, the system returns the DryRunOperation error code.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): The system sends a normal request. After the request passes the precheck, the system creates the inbound or outbound rules.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The details of the outbound rules.</para>
        /// </summary>
        [NameInMap("EgressRules")]
        [Validation(Required=false)]
        public List<CreateTrafficMirrorFilterRulesRequestEgressRules> EgressRules { get; set; }
        public class CreateTrafficMirrorFilterRulesRequestEgressRules : TeaModel {
            /// <summary>
            /// <para>The collection policy of the outbound rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>accept</b>: Collects network traffic.</description></item>
            /// <item><description><b>drop</b>: Does not collect network traffic.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>accept</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>The destination CIDR block of the network traffic for the outbound rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.0/24</para>
            /// </summary>
            [NameInMap("DestinationCidrBlock")]
            [Validation(Required=false)]
            public string DestinationCidrBlock { get; set; }

            /// <summary>
            /// <para>The destination port range of the network traffic for the outbound rule. Valid values are from <b>1</b> to <b>65535</b>. Separate the start port and the end port with a forward slash (/). Examples: <b>1/200</b> and <b>80/80</b>. You cannot set this parameter only to <b>-1/-1</b>, which indicates that all ports are allowed.</para>
            /// <remarks>
            /// <para>If <b>EgressRules.N.Protocol</b> is set to <b>ALL</b> or <b>ICMP</b>, you do not need to specify this parameter, which indicates that all ports are allowed.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>22/40</para>
            /// </summary>
            [NameInMap("DestinationPortRange")]
            [Validation(Required=false)]
            public string DestinationPortRange { get; set; }

            /// <summary>
            /// <para>The IP version of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>IPv4</b>: IPv4.</description></item>
            /// <item><description><b>IPv6</b>: IPv6.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>IPv4</para>
            /// </summary>
            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public string IpVersion { get; set; }

            /// <summary>
            /// <para>The priority of the outbound rule. A smaller value indicates a higher priority. The maximum value of <b>N</b> is <b>10</b>, which indicates that you can configure up to 10 outbound rules for a traffic mirror filter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The protocol type of the network traffic to be mirrored for the outbound rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ALL</b>: All protocols.</description></item>
            /// <item><description><b>ICMP</b>: Internet Control Message Protocol (ICMP).</description></item>
            /// <item><description><b>TCP</b>: Transmission Control Protocol (TCP).</description></item>
            /// <item><description><b>UDP</b>: User Datagram Protocol (UDP).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The source CIDR block of the network traffic for the outbound rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.0/24</para>
            /// </summary>
            [NameInMap("SourceCidrBlock")]
            [Validation(Required=false)]
            public string SourceCidrBlock { get; set; }

            /// <summary>
            /// <para>The source port range of the network traffic for the outbound rule. Valid values are from <b>1</b> to <b>65535</b>. Separate the start port and the end port with a forward slash (/). Examples: <b>1/200</b> and <b>80/80</b>. You cannot set this parameter only to <b>-1/-1</b>, which indicates that all ports are allowed.</para>
            /// <remarks>
            /// <para>If <b>EgressRules.N.Protocol</b> is set to <b>ALL</b> or <b>ICMP</b>, you do not need to specify this parameter, which indicates that all ports are allowed.</para>
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
        /// <para>The details of the inbound rules.</para>
        /// </summary>
        [NameInMap("IngressRules")]
        [Validation(Required=false)]
        public List<CreateTrafficMirrorFilterRulesRequestIngressRules> IngressRules { get; set; }
        public class CreateTrafficMirrorFilterRulesRequestIngressRules : TeaModel {
            /// <summary>
            /// <para>The collection policy of the inbound rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>accept</b>: Collects network traffic.</description></item>
            /// <item><description><b>drop</b>: Does not collect network traffic.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>accept</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>The destination CIDR block of the network traffic for the inbound rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.0/24</para>
            /// </summary>
            [NameInMap("DestinationCidrBlock")]
            [Validation(Required=false)]
            public string DestinationCidrBlock { get; set; }

            /// <summary>
            /// <para>The destination port range of the network traffic for the inbound rule. Valid values are from <b>1</b> to <b>65535</b>. Separate the start port and the end port with a forward slash (/). Examples: <b>1/200</b> and <b>80/80</b>.</para>
            /// <remarks>
            /// <para>If <b>IngressRules.N.Protocol</b> is set to <b>ALL</b> or <b>ICMP</b>, you do not need to specify this parameter, which indicates that all ports are allowed.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>80/120</para>
            /// </summary>
            [NameInMap("DestinationPortRange")]
            [Validation(Required=false)]
            public string DestinationPortRange { get; set; }

            /// <summary>
            /// <para>The IP version of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>IPv4</b>: IPv4.</description></item>
            /// <item><description><b>IPv6</b>: IPv6.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>IPv4</para>
            /// </summary>
            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public string IpVersion { get; set; }

            /// <summary>
            /// <para>The priority of the inbound rule. A smaller value indicates a higher priority. The maximum value of <b>N</b> is <b>10</b>, which indicates that you can configure up to 10 inbound rules for a traffic mirror filter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The protocol type of the network traffic to be mirrored for the inbound rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ALL</b>: All protocols.</description></item>
            /// <item><description><b>ICMP</b>: Internet Control Message Protocol (ICMP).</description></item>
            /// <item><description><b>TCP</b>: Transmission Control Protocol (TCP).</description></item>
            /// <item><description><b>UDP</b>: User Datagram Protocol (UDP).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The source CIDR block of the network traffic for the inbound rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.0/24</para>
            /// </summary>
            [NameInMap("SourceCidrBlock")]
            [Validation(Required=false)]
            public string SourceCidrBlock { get; set; }

            /// <summary>
            /// <para>The source port range of the network traffic for the inbound rule. Valid values are from <b>1</b> to <b>65535</b>. Separate the start port and the end port with a forward slash (/). Examples: <b>1/200</b> and <b>80/80</b>. You cannot set this parameter only to <b>-1/-1</b>, which indicates that all ports are allowed.</para>
            /// <remarks>
            /// <para>If <b>IngressRules.N.Protocol</b> is set to <b>ALL</b> or <b>ICMP</b>, you do not need to specify this parameter, which indicates that all ports are allowed.</para>
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
        /// <para>The region ID of the traffic mirror filter.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query region IDs. For more information about the regions that support traffic mirroring, see <a href="https://help.aliyun.com/document_detail/207513.html">Traffic mirroring overview</a>.</para>
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
        /// <para>The instance ID of the traffic mirror filter.</para>
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
