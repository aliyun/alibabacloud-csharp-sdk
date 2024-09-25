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
        /// <para>You can use the client to generate the value, but you must make sure that it is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not set this parameter, the system uses <b>RequestId</b> as <b>ClientToken</b>. <b>RequestId</b> may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe637760</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The new destination CIDR block of the inbound or outbound traffic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.0/24</para>
        /// </summary>
        [NameInMap("DestinationCidrBlock")]
        [Validation(Required=false)]
        public string DestinationCidrBlock { get; set; }

        /// <summary>
        /// <para>The new destination port range of the inbound or outbound traffic.</para>
        /// <remarks>
        /// <para> If you set <b>Protocol</b> to <b>ICMP</b>, you cannot change the port range.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>-1/-1</para>
        /// </summary>
        [NameInMap("DestinationPortRange")]
        [Validation(Required=false)]
        public string DestinationPortRange { get; set; }

        /// <summary>
        /// <para>Specifies whether to check the request without performing the operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: only checks the API request. The configuration of the inbound or outbound rule is not modified. The system checks the required parameters, request syntax, and limits. If the request fails to pass the check, an error message is returned. If the request passes the precheck, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b>: sends the request. This is the default value. If the request passes the check, a 2xx HTTP status code is returned and the configuration of the inbound or outbound rule is modified.</description></item>
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
        /// <para>The new priority of the inbound or outbound rule. A smaller value indicates a higher priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The new protocol that is used by the traffic to be mirrored by the inbound or outbound rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ALL</b>: all protocols</description></item>
        /// <item><description><b>ICMP</b>: Internet Control Message Protocol (ICMP)</description></item>
        /// <item><description><b>TCP</b>: TCP</description></item>
        /// <item><description><b>UDP</b>: User Datagram Protocol (UDP)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ICMP</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

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
        /// <para>The new action of the inbound or outbound rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>accept</b>: accepts network traffic.</description></item>
        /// <item><description><b>drop</b>: drops network traffic.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>accept</para>
        /// </summary>
        [NameInMap("RuleAction")]
        [Validation(Required=false)]
        public string RuleAction { get; set; }

        /// <summary>
        /// <para>The new source CIDR block of the inbound or outbound traffic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0.0.0/0</para>
        /// </summary>
        [NameInMap("SourceCidrBlock")]
        [Validation(Required=false)]
        public string SourceCidrBlock { get; set; }

        /// <summary>
        /// <para>The new source port range of the inbound or outbound traffic.</para>
        /// <remarks>
        /// <para> If you set <b>Protocol</b> to <b>ICMP</b>, you cannot change the port range.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>22/40</para>
        /// </summary>
        [NameInMap("SourcePortRange")]
        [Validation(Required=false)]
        public string SourcePortRange { get; set; }

        /// <summary>
        /// <para>The ID of the inbound or outbound rule.</para>
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
