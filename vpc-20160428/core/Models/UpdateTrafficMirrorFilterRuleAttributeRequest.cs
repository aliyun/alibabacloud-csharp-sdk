// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class UpdateTrafficMirrorFilterRuleAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the value, and you must ensure that the value is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request may be different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe637760</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The destination CIDR block of the network traffic for the inbound or outbound rule to be updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.0/24</para>
        /// </summary>
        [NameInMap("DestinationCidrBlock")]
        [Validation(Required=false)]
        public string DestinationCidrBlock { get; set; }

        /// <summary>
        /// <para>The destination port range of the network traffic for the inbound or outbound rule to be updated.</para>
        /// <remarks>
        /// <para>If <b>Protocol</b> is set to <b>ICMP</b>, you cannot update the port range.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>-1/-1</para>
        /// </summary>
        [NameInMap("DestinationPortRange")]
        [Validation(Required=false)]
        public string DestinationPortRange { get; set; }

        /// <summary>
        /// <para>Specifies whether to only precheck the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: prechecks the request without updating the configuration of the inbound or outbound rule. The system checks whether the required parameters are specified, the request format is valid, and the service limits are met. If the request fails the precheck, the corresponding error is returned. If the request passes the precheck, the <c>DryRunOperation</c> error code is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): sends the request. If the request passes the precheck, a 2xx HTTP status code is returned and the configuration of the inbound or outbound rule is updated.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The priority of the inbound or outbound rule to be updated. A smaller value indicates a higher priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The protocol type of the network traffic to be mirrored by the inbound or outbound rule to be updated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ALL</b>: all protocols.</para>
        /// </description></item>
        /// <item><description><para><b>ICMP</b>: Internet Control Message Protocol.</para>
        /// </description></item>
        /// <item><description><para><b>TCP</b>: Transmission Control Protocol.</para>
        /// </description></item>
        /// <item><description><para><b>UDP</b>: User Datagram Protocol.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ICMP</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The region ID of the traffic mirror.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list. For more information about the regions that support traffic mirroring, see <a href="https://help.aliyun.com/document_detail/207513.html">Traffic mirroring overview</a>.</para>
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
        /// <para>The collection policy of the inbound or outbound rule to be updated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>accept</b>: collects network traffic.</para>
        /// </description></item>
        /// <item><description><para><b>drop</b>: does not collect network traffic.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>accept</para>
        /// </summary>
        [NameInMap("RuleAction")]
        [Validation(Required=false)]
        public string RuleAction { get; set; }

        /// <summary>
        /// <para>The source CIDR block of the network traffic for the inbound or outbound rule to be updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0.0.0/0</para>
        /// </summary>
        [NameInMap("SourceCidrBlock")]
        [Validation(Required=false)]
        public string SourceCidrBlock { get; set; }

        /// <summary>
        /// <para>The source port range of the network traffic for the inbound or outbound rule to be updated.</para>
        /// <remarks>
        /// <para>If <b>Protocol</b> is set to <b>ICMP</b>, you cannot update the port range.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>22/40</para>
        /// </summary>
        [NameInMap("SourcePortRange")]
        [Validation(Required=false)]
        public string SourcePortRange { get; set; }

        /// <summary>
        /// <para>The instance ID of the inbound or outbound traffic mirroring rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tmr-j6c89rzmtd3hhdugq****</para>
        /// </summary>
        [NameInMap("TrafficMirrorFilterRuleId")]
        [Validation(Required=false)]
        public string TrafficMirrorFilterRuleId { get; set; }

    }

}
