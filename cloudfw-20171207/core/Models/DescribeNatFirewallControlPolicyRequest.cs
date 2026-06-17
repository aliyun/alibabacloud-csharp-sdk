// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeNatFirewallControlPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The action that Cloud Firewall performs on the traffic.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>accept</b>: Allow</para>
        /// </description></item>
        /// <item><description><para><b>drop</b>: Deny</para>
        /// </description></item>
        /// <item><description><para><b>log</b>: Monitor</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>accept</para>
        /// </summary>
        [NameInMap("AclAction")]
        [Validation(Required=false)]
        public string AclAction { get; set; }

        /// <summary>
        /// <para>The unique ID of the access control policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>323f0697-2a21-4e43-b142-*****</para>
        /// </summary>
        [NameInMap("AclUuid")]
        [Validation(Required=false)]
        public string AclUuid { get; set; }

        /// <summary>
        /// <para>The page number of the current page for a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// <para>The description of the access control policy. Fuzzy queries are supported.</para>
        /// <remarks>
        /// <para>If you do not set this parameter, the descriptions of all policies are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test-description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The destination address in the access control policy. Fuzzy queries are supported. The value of this parameter varies based on the value of the DestinationType parameter.</para>
        /// <list type="bullet">
        /// <item><description><para>If DestinationType is set to <c>net</c>, the value of this parameter is a CIDR block. Example: 10.0.3.0/24.</para>
        /// </description></item>
        /// <item><description><para>If DestinationType is set to <c>domain</c>, the value of this parameter is a domain name. Example: aliyun.</para>
        /// </description></item>
        /// <item><description><para>If DestinationType is set to <c>group</c>, the value of this parameter is the name of an address book. Example: db_group.</para>
        /// </description></item>
        /// <item><description><para>If DestinationType is set to <c>location</c>, the value of this parameter is a region name. For more information, see <a href="https://help.aliyun.com/document_detail/474128.html">AddControlPolicy</a>. Example: [&quot;BJ11&quot;, &quot;ZB&quot;].</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not set this parameter, all types of destination addresses are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>x.x.x.x/32</para>
        /// </summary>
        [NameInMap("Destination")]
        [Validation(Required=false)]
        public string Destination { get; set; }

        /// <summary>
        /// <para>The traffic direction of the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>out</b>: outbound traffic</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>out</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (default): Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
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
        /// <para>The ID of the NAT Gateway.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ngw-xxxxxx</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page for a paged query. The default value is 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The protocol type of the traffic in the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>TCP</b></para>
        /// </description></item>
        /// <item><description><para><b>UDP</b></para>
        /// </description></item>
        /// <item><description><para><b>ICMP</b></para>
        /// </description></item>
        /// <item><description><para><b>ANY</b> (all protocol types)</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not set this parameter, all protocol types are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ANY</para>
        /// </summary>
        [NameInMap("Proto")]
        [Validation(Required=false)]
        public string Proto { get; set; }

        /// <summary>
        /// <para>The status of the access control policy. By default, an access control policy is enabled after it is created. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enabled</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: disabled</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Release")]
        [Validation(Required=false)]
        public string Release { get; set; }

        /// <summary>
        /// <para>The recurrence type for the policy validity period. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Permanent</b> (default): always</para>
        /// </description></item>
        /// <item><description><para><b>None</b>: one-time</para>
        /// </description></item>
        /// <item><description><para><b>Daily</b>: daily</para>
        /// </description></item>
        /// <item><description><para><b>Weekly</b>: weekly</para>
        /// </description></item>
        /// <item><description><para><b>Monthly</b>: monthly</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Permanent</para>
        /// </summary>
        [NameInMap("RepeatType")]
        [Validation(Required=false)]
        public string RepeatType { get; set; }

        /// <summary>
        /// <para>The source address in the access control policy. Fuzzy queries are supported. The value of this parameter varies based on the value of the SourceType parameter.</para>
        /// <list type="bullet">
        /// <item><description><para>If SourceType is set to <c>net</c>, the value of this parameter is a CIDR block. Example: 192.0.XX.XX/24.</para>
        /// </description></item>
        /// <item><description><para>If SourceType is set to <c>group</c>, the value of this parameter is the name of an address book. Example: db_group. If you leave this parameter empty, all source addresses are queried.</para>
        /// </description></item>
        /// <item><description><para>If SourceType is set to <c>location</c>, the value of this parameter is a source region. Example: Beijing or beijing. You can use either Chinese or English to specify the region.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not set this parameter, all types of source addresses are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1.1.1.1/32</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
