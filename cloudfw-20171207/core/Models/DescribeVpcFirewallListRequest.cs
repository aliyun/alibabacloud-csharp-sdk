// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallListRequest : TeaModel {
        /// <summary>
        /// <para>The sub-type of the connection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>vpc2vpc</b>: Express Connect connection</description></item>
        /// <item><description><b>vpcpeer</b>: peer connection</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vpcpeer</para>
        /// </summary>
        [NameInMap("ConnectSubType")]
        [Validation(Required=false)]
        public string ConnectSubType { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// <para>Pages start from page <b>1</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// <para>The status of the VPC firewall. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>opened</b>: The VPC firewall is enabled.</description></item>
        /// <item><description><b>closed</b>: The VPC firewall is disabled.</description></item>
        /// <item><description><b>notconfigured</b>: The VPC firewall is not configured.</description></item>
        /// <item><description><b>configured</b>: The VPC firewall is configured.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify this parameter, VPC firewalls in all states are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>opened</para>
        /// </summary>
        [NameInMap("FirewallSwitchStatus")]
        [Validation(Required=false)]
        public string FirewallSwitchStatus { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese (default)</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

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
        /// <para>The number of entries to return on each page.</para>
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
        /// <para>For more information about the regions, see <a href="https://help.aliyun.com/document_detail/195657.html">Supported regions</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionNo")]
        [Validation(Required=false)]
        public string RegionNo { get; set; }

        /// <summary>
        /// <para>The instance ID of the VPC firewall.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vfw-m5e7dbc4y****</para>
        /// </summary>
        [NameInMap("VpcFirewallId")]
        [Validation(Required=false)]
        public string VpcFirewallId { get; set; }

        /// <summary>
        /// <para>The instance name of the VPC firewall.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test firewall</para>
        /// </summary>
        [NameInMap("VpcFirewallName")]
        [Validation(Required=false)]
        public string VpcFirewallName { get; set; }

        /// <summary>
        /// <para>The ID of the VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-8vbwbo90rq0anm6t****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
