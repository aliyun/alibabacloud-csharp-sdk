// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateTrafficMirrorSessionRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe63****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: performs a dry run. The system checks the required parameters, request syntax, and limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): performs a dry run and sends the request. If the request passes the dry run, the traffic mirror session is created.</para>
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
        /// <para>Specifies whether to enable the traffic mirror session. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b> (default): does not enable the traffic mirror session.</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: enables the traffic mirror session.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The maximum length of the mirrored original packet, excluding the VXLAN packet length. Default value: <b>1500</b>. Valid values: <b>64</b> to <b>8500</b>. Unit: bytes.</para>
        /// <list type="bullet">
        /// <item><description><para>This parameter affects the length of packets received at the traffic mirror destination. For more information, see the mirrored packet length and MTU limits in <a href="https://help.aliyun.com/document_detail/207513.html">Traffic mirroring overview</a>.</para>
        /// </description></item>
        /// <item><description><para>This parameter is available only in specific regions. For more information, see the description of the mirrored packet length parameter in <a href="https://help.aliyun.com/document_detail/207514.html">Create and manage traffic mirrors</a>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1500</para>
        /// </summary>
        [NameInMap("PacketLength")]
        [Validation(Required=false)]
        public int? PacketLength { get; set; }

        /// <summary>
        /// <para>The priority of traffic mirror session. Valid values: <b>1</b> to <b>32766</b>.
        /// A smaller value indicates a higher priority. The priorities of traffic mirror sessions created in the same region under the same account must be unique.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The region ID of the traffic mirror session. You can call <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> to query the most recent region list. For information about the regions that support traffic mirroring, see <a href="https://help.aliyun.com/document_detail/207513.html">Traffic mirroring overview</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hongkong</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the traffic mirroring instance belongs.</para>
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
        public List<CreateTrafficMirrorSessionRequestTag> Tag { get; set; }
        public class CreateTrafficMirrorSessionRequestTag : TeaModel {
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
        /// <para>The instance ID of the traffic mirror filter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tmf-j6cmls82xnc86vtpe****</para>
        /// </summary>
        [NameInMap("TrafficMirrorFilterId")]
        [Validation(Required=false)]
        public string TrafficMirrorFilterId { get; set; }

        /// <summary>
        /// <para>The description of the traffic mirror session.</para>
        /// <para>The description must be 1 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a trafficmirrorsession.</para>
        /// </summary>
        [NameInMap("TrafficMirrorSessionDescription")]
        [Validation(Required=false)]
        public string TrafficMirrorSessionDescription { get; set; }

        /// <summary>
        /// <para>The name of the traffic mirror session.</para>
        /// <para>The name must be 1 to 128 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("TrafficMirrorSessionName")]
        [Validation(Required=false)]
        public string TrafficMirrorSessionName { get; set; }

        /// <summary>
        /// <para>The instance ID of the traffic mirror source. Elastic network interfaces (ENIs) are supported as traffic mirror sources. The default value of <b>N</b> is <b>1</b>, which indicates that only one traffic mirror source can be added to a traffic mirror session.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eni-j6c2fp57q8rr47rp****</para>
        /// </summary>
        [NameInMap("TrafficMirrorSourceIds")]
        [Validation(Required=false)]
        public List<string> TrafficMirrorSourceIds { get; set; }

        /// <summary>
        /// <para>The instance ID of the traffic mirror destination. Elastic network interfaces (ENIs) and private network load balancing instances are supported as traffic mirror destinations.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eni-j6c8znm5l1yt4sox****</para>
        /// </summary>
        [NameInMap("TrafficMirrorTargetId")]
        [Validation(Required=false)]
        public string TrafficMirrorTargetId { get; set; }

        /// <summary>
        /// <para>The type of the traffic mirror destination. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>NetworkInterface</b>: elastic network interface (ENI).</para>
        /// </description></item>
        /// <item><description><para><b>SLB</b>: private network load balancing instance.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NetworkInterface</para>
        /// </summary>
        [NameInMap("TrafficMirrorTargetType")]
        [Validation(Required=false)]
        public string TrafficMirrorTargetType { get; set; }

        /// <summary>
        /// <para>The VXLAN network identifier (VNI) that is used to distinguish mirrored data from different traffic mirror sessions. Valid values: <b>0</b> to <b>16777215</b>.</para>
        /// <para>You can use the VNI to identify mirrored data from different sessions at the traffic mirror destination. You can specify a custom VNI or use a system-assigned value. To use a system-assigned value, do not specify this parameter. The system randomly allocates the value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("VirtualNetworkId")]
        [Validation(Required=false)]
        public int? VirtualNetworkId { get; set; }

    }

}
