// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyVpcFirewallConfigureRequest : TeaModel {
        /// <summary>
        /// <para>The language of the content within the request and response. Valid values:</para>
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
        /// <para>The CIDR block information of the local VPC, in JSON format. The following parameters are included:</para>
        /// <list type="bullet">
        /// <item><description><para><b>RouteTableId</b>: the routing table ID of the local VPC.</para>
        /// </description></item>
        /// <item><description><para><b>RouteEntryList</b>: specified in JSON format and contains DestinationCidr (the destination CIDR block of the local VPC) and NextHopInstanceId (the next hop instance ID of the local VPC).</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You can invoke the <a href="https://help.aliyun.com/document_detail/342892.html">DescribeVpcFirewallDetail</a> operation to query the CIDR block information of the local VPC for the virtual private cloud (VPC) firewall.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;RouteTableId&quot;:&quot;vtb-1234&quot;,&quot;RouteEntryList&quot;:[{&quot;DestinationCidr&quot;:&quot;192.168.XX.XX/24&quot;,&quot;NextHopInstanceId&quot;:&quot;vrt-m5eb5me6c3l5sezae****&quot;}]},{&quot;RouteTableId&quot;:&quot;vtb-1235&quot;,&quot;RouteEntryList&quot;:[{&quot;DestinationCidr&quot;:&quot;192.168.XX.XX/24&quot;,&quot;NextHopInstanceId&quot;:&quot;vrt-m5eb5me6c3l5sezae****&quot;}]}]</para>
        /// </summary>
        [NameInMap("LocalVpcCidrTableList")]
        [Validation(Required=false)]
        public string LocalVpcCidrTableList { get; set; }

        /// <summary>
        /// <para>The UID of the member accounts of the current Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>258039427902****</para>
        /// </summary>
        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public string MemberUid { get; set; }

        /// <summary>
        /// <para>The CIDR block information of the peer VPC, in JSON format. The following parameters are included:</para>
        /// <list type="bullet">
        /// <item><description><para><b>RouteTableId</b>: the routing table ID of the peer VPC.</para>
        /// </description></item>
        /// <item><description><para><b>RouteEntryList</b>: specified in JSON format and contains DestinationCidr (the destination CIDR block of the peer VPC) and NextHopInstanceId (the next hop instance ID of the peer VPC).</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You can invoke the <a href="https://help.aliyun.com/document_detail/342892.html">DescribeVpcFirewallDetail</a> operation to query the CIDR block information of the peer VPC for the virtual private cloud (VPC) firewall.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;RouteTableId&quot;:&quot;vtb-1234&quot;,&quot;RouteEntryList&quot;:[{&quot;DestinationCidr&quot;:&quot;192.168.XX.XX/24&quot;,&quot;NextHopInstanceId&quot;:&quot;vrt-m5eb5me6c3l5sezae****&quot;}]},{&quot;RouteTableId&quot;:&quot;vtb-1235&quot;,&quot;RouteEntryList&quot;:[{&quot;DestinationCidr&quot;:&quot;192.168.XX.XX/24&quot;,&quot;NextHopInstanceId&quot;:&quot;vrt-m5eb5me6c3l5sezae****&quot;}]}]</para>
        /// </summary>
        [NameInMap("PeerVpcCidrTableList")]
        [Validation(Required=false)]
        public string PeerVpcCidrTableList { get; set; }

        /// <summary>
        /// <para>The instance ID of the virtual private cloud (VPC) firewall.</para>
        /// <remarks>
        /// <para>You can invoke the <a href="https://help.aliyun.com/document_detail/342932.html">DescribeVpcFirewallList</a> operation to query the instance ID of the virtual private cloud (VPC) firewall.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vfw-m5e7dbc4y****</para>
        /// </summary>
        [NameInMap("VpcFirewallId")]
        [Validation(Required=false)]
        public string VpcFirewallId { get; set; }

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
