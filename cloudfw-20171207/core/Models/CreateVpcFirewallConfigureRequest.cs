// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateVpcFirewallConfigureRequest : TeaModel {
        /// <summary>
        /// <para>Settings for the enabling status of the virtual private cloud (VPC) firewall after it is created. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>open</b> (default): Protection is automatically enabled after the VPC firewall is created.</para>
        /// </description></item>
        /// <item><description><para><b>close</b>: Protection is not automatically enabled after the VPC firewall is created. You can invoke the <a href="https://help.aliyun.com/document_detail/342935.html">ModifyVpcFirewallSwitchStatus</a> operation to enable protection.</para>
        /// </description></item>
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
        /// <para>The language of the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (default): Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The CIDR block list of the local VPC, in JSON format. This parameter contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>RouteTableId</b>: the route table ID of the local VPC.</description></item>
        /// <item><description><b>RouteEntryList</b>: specified in JSON format. This field contains DestinationCidr (the destination CIDR block of the local VPC) and NextHopInstanceId (the next hop instance ID of the local VPC).</description></item>
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
        /// <para>The instance ID of the local VPC.</para>
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
        /// <para>For more information about the regions supported by Cloud Firewall, see <a href="https://help.aliyun.com/document_detail/195657.html">Supported regions</a>.</para>
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
        /// <para>The UID of the Alibaba Cloud member account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>258039427902****</para>
        /// </summary>
        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public string MemberUid { get; set; }

        /// <summary>
        /// <para>The CIDR block list of the peer VPC, in JSON format. This parameter contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>RouteTableId</b>: the route table ID of the peer VPC.</description></item>
        /// <item><description><b>RouteEntryList</b>: specified in JSON format. This field contains DestinationCidr (the destination CIDR block of the peer VPC) and NextHopInstanceId (the next hop instance ID of the peer VPC).</description></item>
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
        /// <para>The instance ID of the peer VPC.</para>
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
        /// <para>For more information about the regions supported by Cloud Firewall, see <a href="https://help.aliyun.com/document_detail/195657.html">Supported regions</a>.</para>
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
        /// <para>The instance name of the virtual private cloud (VPC) firewall.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-vpc-firewall</para>
        /// </summary>
        [NameInMap("VpcFirewallName")]
        [Validation(Required=false)]
        public string VpcFirewallName { get; set; }

    }

}
