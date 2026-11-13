// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallControlPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The action that Cloud Firewall performs on the traffic in the access control policy of the virtual private cloud (VPC) firewalls. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>accept</b>: allows the traffic.</description></item>
        /// <item><description><b>drop</b>: denies the traffic.</description></item>
        /// <item><description><b>log</b>: monitors the traffic.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify this parameter, all actions are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>accept</para>
        /// </summary>
        [NameInMap("AclAction")]
        [Validation(Required=false)]
        public string AclAction { get; set; }

        /// <summary>
        /// <para>The unique identifier of the access control policy of the virtual private cloud (VPC) firewalls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4037fbf7-3e39-4634-92a4-d0155247****</para>
        /// </summary>
        [NameInMap("AclUuid")]
        [Validation(Required=false)]
        public string AclUuid { get; set; }

        /// <summary>
        /// <para>The page number of the current page for a paged query.</para>
        /// <remarks>
        /// <para>You must specify both CurrentPage and PageSize or omit both. If you specify only one of them, the operation returns the ErrorParametersPageSizeOrNo (400) error.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// <para>The description of the access control policy of the virtual private cloud (VPC) firewalls. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The destination address in the access control policy of the virtual private cloud (VPC) firewalls. Fuzzy match is supported.</para>
        /// <remarks>
        /// <para>Destination can be a single CIDR block, a domain name, or an address book name.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX/24</para>
        /// </summary>
        [NameInMap("Destination")]
        [Validation(Required=false)]
        public string Destination { get; set; }

        /// <summary>
        /// <para>The language of the request and response.</para>
        /// <para>Valid values:</para>
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
        /// <para>The UID of the member account of the current Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>258039427902****</para>
        /// </summary>
        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public string MemberUid { get; set; }

        /// <summary>
        /// <para>The number of access control policies of the virtual private cloud (VPC) firewalls to return on each page for a paged query.</para>
        /// <para>Maximum value: 50.</para>
        /// <remarks>
        /// <para>You must specify both CurrentPage and PageSize or omit both. If you specify only one of them, the operation returns the ErrorParametersPageSizeOrNo (400) error.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The protocol type of the traffic in the access control policy of the virtual private cloud (VPC) firewalls. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>TCP</b></description></item>
        /// <item><description><b>UDP</b></description></item>
        /// <item><description><b>ICMP</b></description></item>
        /// <item><description><b>ANY</b>: all protocol types.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify this parameter, all protocol types are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>TCP</para>
        /// </summary>
        [NameInMap("Proto")]
        [Validation(Required=false)]
        public string Proto { get; set; }

        /// <summary>
        /// <para>The enabling status of the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The access control policy is enabled.</description></item>
        /// <item><description><b>false</b>: The access control policy is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Release")]
        [Validation(Required=false)]
        public string Release { get; set; }

        /// <summary>
        /// <para>The recurrence type of the policy validity period for the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Permanent</b> (default): always.</description></item>
        /// <item><description><b>None</b>: a specific single time.</description></item>
        /// <item><description><b>Daily</b>: every day.</description></item>
        /// <item><description><b>Weekly</b>: every week.</description></item>
        /// <item><description><b>Monthly</b>: every month.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Permanent</para>
        /// </summary>
        [NameInMap("RepeatType")]
        [Validation(Required=false)]
        public string RepeatType { get; set; }

        /// <summary>
        /// <para>The source address in the access control policy of the virtual private cloud (VPC) firewalls. Fuzzy match is supported.</para>
        /// <remarks>
        /// <para>Source can be a single CIDR block or an address book name.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX/24</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The instance ID of the virtual private cloud (VPC) firewalls. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If the virtual private cloud (VPC) firewalls protect traffic between two VPCs connected by CEN, set this parameter to the instance ID of the CEN instance.</para>
        /// </description></item>
        /// <item><description><para>If the virtual private cloud (VPC) firewalls protect traffic between two VPCs connected by Express Connect, set this parameter to the instance ID of the virtual private cloud (VPC) firewalls.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/159760.html">DescribeVpcFirewallAclGroupList</a> operation to obtain the instance ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vfw-a42bbb7b887148c9****</para>
        /// </summary>
        [NameInMap("VpcFirewallId")]
        [Validation(Required=false)]
        public string VpcFirewallId { get; set; }

    }

}
