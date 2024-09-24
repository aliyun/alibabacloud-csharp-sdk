// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateVpcFirewallConfigureRequest : TeaModel {
        /// <summary>
        /// <para>The status of the VPC firewall after you create the firewall. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>open</b>: After you create the VPC firewall, the VPC firewall is automatically enabled. This is the default value.</description></item>
        /// <item><description><b>close</b>: After you create the VPC firewall, the VPC firewall is disabled. To enable the firewall, you can call the <a href="https://help.aliyun.com/document_detail/342935.html">ModifyVpcFirewallSwitchStatus</a> operation.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>open</para>
        /// </summary>
        [NameInMap("FirewallSwitch")]
        [Validation(Required=false)]
        public string FirewallSwitch { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese (default)</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The CIDR blocks of the local VPC. The value is a JSON string that contains the following parameters:</para>
        /// <list type="bullet">
        /// <item><description><b>RouteTableId</b>: the ID of the route table for the local VPC.</description></item>
        /// <item><description><b>RouteEntryList</b>: The value is a JSON string that contains the DestinationCidr and NextHopInstanceId parameters. The DestinationCidr parameter indicates the destination CIDR block of the local VPC. The NextHopInstanceId parameter indicates the instance ID of the next hop for the local VPC.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;RouteTableId&quot;:&quot;vtb-1234&quot;,&quot;RouteEntryList&quot;:[{&quot;DestinationCidr&quot;:&quot;192.168.XX.XX/24&quot;,&quot;NextHopInstanceId&quot;:&quot;vrt-m5eb5me6c3l5sezae****&quot;}]},{&quot;RouteTableId&quot;:&quot;vtb-1235&quot;,&quot;RouteEntryList&quot;:[{&quot;DestinationCidr&quot;:&quot;192.168.XX.XX/24&quot;,&quot;NextHopInstanceId&quot;:&quot;vrt-m5eb5me6c3l5sezae****&quot;}]}]</para>
        /// </summary>
        [NameInMap("LocalVpcCidrTableList")]
        [Validation(Required=false)]
        public string LocalVpcCidrTableList { get; set; }

        /// <summary>
        /// <para>The ID of the local VPC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-8vbwbo90rq0anm6t****</para>
        /// </summary>
        [NameInMap("LocalVpcId")]
        [Validation(Required=false)]
        public string LocalVpcId { get; set; }

        /// <summary>
        /// <para>The region ID of the local VPC.</para>
        /// <remarks>
        /// <para> For more information about the regions in which Cloud Firewall is available, see <a href="https://help.aliyun.com/document_detail/195657.html">Supported regions</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("LocalVpcRegion")]
        [Validation(Required=false)]
        public string LocalVpcRegion { get; set; }

        /// <summary>
        /// <para>The UID of the member that is managed by your Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>258039427902****</para>
        /// </summary>
        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public string MemberUid { get; set; }

        /// <summary>
        /// <para>The CIDR blocks of the peer VPC. The value is a JSON string that contains the following parameters:</para>
        /// <list type="bullet">
        /// <item><description><b>RouteTableId</b>: the ID of the route table for the peer VPC.</description></item>
        /// <item><description><b>RouteEntryList</b>: The value is a JSON string that contains the DestinationCidr and NextHopInstanceId parameters. The DestinationCidr parameter indicates the destination CIDR block of the peer VPC. The NextHopInstanceId parameter indicates the instance ID of the next hop for the peer VPC.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;RouteTableId&quot;:&quot;vtb-1234&quot;,&quot;RouteEntryList&quot;:[{&quot;DestinationCidr&quot;:&quot;192.168.XX.XX/24&quot;,&quot;NextHopInstanceId&quot;:&quot;vrt-m5eb5me6c3l5sezae****&quot;}]},{&quot;RouteTableId&quot;:&quot;vtb-1235&quot;,&quot;RouteEntryList&quot;:[{&quot;DestinationCidr&quot;:&quot;192.168.XX.XX/24&quot;,&quot;NextHopInstanceId&quot;:&quot;vrt-m5eb5me6c3l5sezae****&quot;}]}]</para>
        /// </summary>
        [NameInMap("PeerVpcCidrTableList")]
        [Validation(Required=false)]
        public string PeerVpcCidrTableList { get; set; }

        /// <summary>
        /// <para>The ID of the peer VPC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-wb8vbo90rq0anm6t****</para>
        /// </summary>
        [NameInMap("PeerVpcId")]
        [Validation(Required=false)]
        public string PeerVpcId { get; set; }

        /// <summary>
        /// <para>The region ID of the peer VPC.</para>
        /// <remarks>
        /// <para> For more information about Cloud Firewall supported regions, see <a href="https://help.aliyun.com/document_detail/195657.html">Supported regions</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("PeerVpcRegion")]
        [Validation(Required=false)]
        public string PeerVpcRegion { get; set; }

        /// <summary>
        /// <para>The instance name of the VPC firewall.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-vpc-firewall</para>
        /// </summary>
        [NameInMap("VpcFirewallName")]
        [Validation(Required=false)]
        public string VpcFirewallName { get; set; }

    }

}
