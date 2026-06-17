// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyVpcFirewallConfigureRequest : TeaModel {
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
        /// <para>The CIDR block information of the local VPC. The value is a JSON string and contains the following parameters:</para>
        /// <list type="bullet">
        /// <item><description><para><b>RouteTableId</b>: The ID of the route table for the local VPC.</para>
        /// </description></item>
        /// <item><description><para><b>RouteEntryList</b>: The route entries for the local VPC. This parameter is a JSON string that contains DestinationCidr (the destination CIDR block of the local VPC) and NextHopInstanceId (the ID of the next hop instance for the local VPC).</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/342892.html">DescribeVpcFirewallDetail</a> operation to query the CIDR block information of the local VPC for the VPC firewall.</para>
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
        /// <para>The UID of the member account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>258039427902****</para>
        /// </summary>
        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public string MemberUid { get; set; }

        /// <summary>
        /// <para>The CIDR block information of the peer VPC. The value is a JSON string and contains the following parameters:</para>
        /// <list type="bullet">
        /// <item><description><para><b>RouteTableId</b>: The ID of the route table for the peer VPC.</para>
        /// </description></item>
        /// <item><description><para><b>RouteEntryList</b>: The route entries for the peer VPC. This parameter is a JSON string that contains DestinationCidr (the destination CIDR block of the peer VPC) and NextHopInstanceId (the ID of the next hop instance for the peer VPC).</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/342892.html">DescribeVpcFirewallDetail</a> operation to query the CIDR block information of the peer VPC for the VPC firewall.</para>
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
        /// <para>The instance ID of the VPC firewall.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/342932.html">DescribeVpcFirewallList</a> operation to query the instance IDs of VPC firewalls.</para>
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
        /// <para>The instance name of the VPC firewall.</para>
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
