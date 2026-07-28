// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateTrafficMirrorFilterRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> value as the <b>ClientToken</b> value. The <b>RequestId</b> value is different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: performs a dry run. The system checks the required parameters, request format, and limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): sends a normal request. If the request passes the dry run, a 2xx HTTP status code is returned and the traffic mirror filter is created.</para>
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
        /// <para>The information about outbound rules.</para>
        /// </summary>
        [NameInMap("EgressRules")]
        [Validation(Required=false)]
        public List<CreateTrafficMirrorFilterRequestEgressRules> EgressRules { get; set; }
        public class CreateTrafficMirrorFilterRequestEgressRules : TeaModel {
            /// <summary>
            /// <para>The collection policy of the outbound rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>accept</b>: collects network traffic.</description></item>
            /// <item><description><b>drop</b>: does not collect network traffic.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>accept</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>The destination CIDR block of network traffic for the outbound rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.0/24</para>
            /// </summary>
            [NameInMap("DestinationCidrBlock")]
            [Validation(Required=false)]
            public string DestinationCidrBlock { get; set; }

            /// <summary>
            /// <para>The destination port range of network traffic for the outbound rule. The port range is <b>1</b> to <b>65535</b>. Separate the start port and end port with a forward slash (/). Example: <b>1/200</b> or <b>80/80</b>. The value <b>-1/-1</b> cannot be set independently and indicates that all ports are available.</para>
            /// <remarks>
            /// <para>If <b>EgressRules.N.Protocol</b> is set to <b>ALL</b> or <b>ICMP</b>, you do not need to set this parameter, which indicates that all ports are available.</para>
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
            /// <para>The priority of the outbound rule. A smaller value indicates a higher priority.
            /// The maximum value of <b>N</b> is <b>10</b>, which indicates that you can configure up to 10 outbound rules for a traffic mirror filter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The protocol type of network traffic to be mirrored for the outbound rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ALL</b>: all protocols.</description></item>
            /// <item><description><b>ICMP</b>: Internet Control Message Protocol.</description></item>
            /// <item><description><b>TCP</b>: Transmission Control Protocol.</description></item>
            /// <item><description><b>UDP</b>: User Datagram Protocol.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The source CIDR block of network traffic for the outbound rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.0/24</para>
            /// </summary>
            [NameInMap("SourceCidrBlock")]
            [Validation(Required=false)]
            public string SourceCidrBlock { get; set; }

            /// <summary>
            /// <para>The source port range of network traffic for the outbound rule. The port range is <b>1</b> to <b>65535</b>. Separate the start port and end port with a forward slash (/). Example: <b>1/200</b> or <b>80/80</b>. The value <b>-1/-1</b> cannot be set independently and indicates that all ports are available.</para>
            /// <remarks>
            /// <para>If <b>EgressRules.N.Protocol</b> is set to <b>ALL</b> or <b>ICMP</b>, you do not need to set this parameter, which indicates that all ports are available.</para>
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
        /// <para>The information about inbound rules.</para>
        /// </summary>
        [NameInMap("IngressRules")]
        [Validation(Required=false)]
        public List<CreateTrafficMirrorFilterRequestIngressRules> IngressRules { get; set; }
        public class CreateTrafficMirrorFilterRequestIngressRules : TeaModel {
            /// <summary>
            /// <para>The collection policy of the inbound rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>accept</b>: collects network traffic.</description></item>
            /// <item><description><b>drop</b>: does not collect network traffic.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>accept</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>The destination CIDR block of network traffic for the inbound rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.0/24</para>
            /// </summary>
            [NameInMap("DestinationCidrBlock")]
            [Validation(Required=false)]
            public string DestinationCidrBlock { get; set; }

            /// <summary>
            /// <para>The destination port range of network traffic for the inbound rule. The port range is <b>1</b> to <b>65535</b>. Separate the start port and end port with a forward slash (/). Example: <b>1/200</b> or <b>80/80</b>.</para>
            /// <remarks>
            /// <para>If <b>IngressRules.N.Protocol</b> is set to <b>ALL</b> or <b>ICMP</b>, you do not need to set this parameter, which indicates that all ports are available.</para>
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
            /// <para>The priority of the inbound rule. A smaller value indicates a higher priority.
            /// The maximum value of <b>N</b> is <b>10</b>, which indicates that you can configure up to 10 inbound rules for a traffic mirror filter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The protocol type of network traffic to be mirrored for the inbound rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ALL</b>: all protocols.</description></item>
            /// <item><description><b>ICMP</b>: Internet Control Message Protocol.</description></item>
            /// <item><description><b>TCP</b>: Transmission Control Protocol.</description></item>
            /// <item><description><b>UDP</b>: User Datagram Protocol.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The source CIDR block of network traffic for the inbound rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.0/24</para>
            /// </summary>
            [NameInMap("SourceCidrBlock")]
            [Validation(Required=false)]
            public string SourceCidrBlock { get; set; }

            /// <summary>
            /// <para>The source port range of network traffic for the inbound rule. The port range is <b>1</b> to <b>65535</b>. Separate the start port and end port with a forward slash (/). Example: <b>1/200</b> or <b>80/80</b>.</para>
            /// <remarks>
            /// <para>If <b>IngressRules.N.Protocol</b> is set to <b>ALL</b> or <b>ICMP</b>, you do not need to set this parameter, which indicates that all ports are available.</para>
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
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> to query the most recent region list. For more information about regions that support traffic mirroring, see <a href="https://help.aliyun.com/document_detail/207513.html">Traffic mirroring overview</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hongkong</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the traffic mirroring filter belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4ph****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The tags of the resource.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateTrafficMirrorFilterRequestTag> Tag { get; set; }
        public class CreateTrafficMirrorFilterRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource. You can specify up to 20 tag keys. The tag key cannot be an empty string.</para>
            /// <para>The tag key can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource. You can specify up to 20 tag values. The tag value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The description of the traffic mirror filter.</para>
        /// <para>The description must be 1 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is a filter.</para>
        /// </summary>
        [NameInMap("TrafficMirrorFilterDescription")]
        [Validation(Required=false)]
        public string TrafficMirrorFilterDescription { get; set; }

        /// <summary>
        /// <para>The name of the traffic mirror filter.</para>
        /// <para>The name must be 1 to 128 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("TrafficMirrorFilterName")]
        [Validation(Required=false)]
        public string TrafficMirrorFilterName { get; set; }

    }

}
