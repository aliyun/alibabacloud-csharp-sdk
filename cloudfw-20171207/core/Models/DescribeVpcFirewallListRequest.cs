// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallListRequest : TeaModel {
        /// <summary>
        /// <para>The connection subtype. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>vpc2vpc</b>: Express Connect.</description></item>
        /// <item><description><b>vpcpeer</b>: VPC peering connection.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vpcpeer</para>
        /// </summary>
        [NameInMap("ConnectSubType")]
        [Validation(Required=false)]
        public string ConnectSubType { get; set; }

        /// <summary>
        /// <para>The page number Settings for a paging query.</para>
        /// <para>Default value: <b>1</b>, which indicates the first page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// <para>The status of the virtual private cloud (VPC) border firewall. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>opened</b>: Enabled.</description></item>
        /// <item><description><b>closed</b>: Disabled.</description></item>
        /// <item><description><b>notconfigured</b>: The virtual private cloud (VPC) border firewall is not configured.</description></item>
        /// <item><description><b>configured</b>: The virtual private cloud (VPC) border firewall is configured.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify the Settings for this parameter, virtual private cloud (VPC) border firewalls in all states are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>opened</para>
        /// </summary>
        [NameInMap("FirewallSwitchStatus")]
        [Validation(Required=false)]
        public string FirewallSwitchStatus { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese.</description></item>
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
        /// <para>The UID of the member accounts of the current Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>258039427902****</para>
        /// </summary>
        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public string MemberUid { get; set; }

        /// <summary>
        /// <para>The number Settings of virtual private cloud (VPC) border firewalls per page for a paging query.</para>
        /// <para>Default value: <b>10</b>. Maximum value: <b>50</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The UID of the Alibaba Cloud account to which the peer VPC belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>258039427902****</para>
        /// </summary>
        [NameInMap("PeerUid")]
        [Validation(Required=false)]
        public string PeerUid { get; set; }

        /// <summary>
        /// <para>The region ID of the VPC.</para>
        /// <remarks>
        /// <para>For more information about the regions supported by Cloud Firewall, see <a href="https://help.aliyun.com/document_detail/195657.html">Supported regions</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionNo")]
        [Validation(Required=false)]
        public string RegionNo { get; set; }

        /// <summary>
        /// <para>The instance ID of the virtual private cloud (VPC) border firewall.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vfw-m5e7dbc4y****</para>
        /// </summary>
        [NameInMap("VpcFirewallId")]
        [Validation(Required=false)]
        public string VpcFirewallId { get; set; }

        /// <summary>
        /// <para>The instance name of the virtual private cloud (VPC) border firewall.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-vpc-firewall</para>
        /// </summary>
        [NameInMap("VpcFirewallName")]
        [Validation(Required=false)]
        public string VpcFirewallName { get; set; }

        /// <summary>
        /// <para>The instance ID of the VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-8vbwbo90rq0anm6t****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
