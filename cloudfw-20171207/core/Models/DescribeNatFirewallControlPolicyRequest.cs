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
        /// <item><description><b>accept</b>: allows the traffic.</description></item>
        /// <item><description><b>drop</b>: denies the traffic.</description></item>
        /// <item><description><b>log</b>: monitors the traffic.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>accept</para>
        /// </summary>
        [NameInMap("AclAction")]
        [Validation(Required=false)]
        public string AclAction { get; set; }

        /// <summary>
        /// <para>The UUID of the access control policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>303f0697-2a21-4e43-b142-4a77adf7b358</para>
        /// </summary>
        [NameInMap("AclUuid")]
        [Validation(Required=false)]
        public string AclUuid { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// <para>The description of the access control policy. Fuzzy match is supported.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the descriptions of all policies are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The destination address in the access control policy. Fuzzy match is supported. The value of this parameter varies based on the value of the DestinationType parameter.</para>
        /// <list type="bullet">
        /// <item><description>If DestinationType is set to <c>net</c>, the value of Destination must be a CIDR block. Example: 10.0.3.0/24.</description></item>
        /// <item><description>If DestinationType is set to <c>domain</c>, the value of Destination must be a domain name. Example: aliyun.</description></item>
        /// <item><description>If DestinationType is set to <c>group</c>, the value of Destination must be the name of an address book. Example: db_group.</description></item>
        /// <item><description>If DestinationType is set to <c>location</c>, the value of Destination is a location. For more information about location codes, see <a href="https://help.aliyun.com/document_detail/474128.html">AddControlPolicy</a>. Example: [&quot;BJ11&quot;, &quot;ZB&quot;].</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify this parameter, all types of destination addresses are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>x.x.x.x/32</para>
        /// </summary>
        [NameInMap("Destination")]
        [Validation(Required=false)]
        public string Destination { get; set; }

        /// <summary>
        /// <para>The direction of the traffic to which the access control policy applies. Valid values:</para>
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
        /// <para>The language of the content within the response. Valid values:</para>
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
        /// <para>The ID of the NAT gateway.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ngw-xxxxxx</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The type of the protocol in the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>TCP</b></description></item>
        /// <item><description><b>UDP</b></description></item>
        /// <item><description><b>ICMP</b></description></item>
        /// <item><description><b>ANY</b>: all types of protocols</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify this parameter, access control policies of all protocol types are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ANY</para>
        /// </summary>
        [NameInMap("Proto")]
        [Validation(Required=false)]
        public string Proto { get; set; }

        /// <summary>
        /// <para>Specifies whether the access control policy is enabled. By default, an access control policy is enabled after it is created. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Release")]
        [Validation(Required=false)]
        public string Release { get; set; }

        /// <summary>
        /// <para>The recurrence type for the access control policy to take effect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Permanent</b> (default): The policy always takes effect.</description></item>
        /// <item><description><b>None</b>: The policy takes effect only once.</description></item>
        /// <item><description><b>Daily</b>: The policy takes effect on a daily basis.</description></item>
        /// <item><description><b>Weekly</b>: The policy takes effect on a weekly basis.</description></item>
        /// <item><description><b>Monthly</b>: The policy takes effect on a monthly basis.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Permanent</para>
        /// </summary>
        [NameInMap("RepeatType")]
        [Validation(Required=false)]
        public string RepeatType { get; set; }

        /// <summary>
        /// <para>The source address in the access control policy. Fuzzy match is supported. The value of this parameter varies based on the value of the SourceType parameter.</para>
        /// <list type="bullet">
        /// <item><description>If SourceType is set to <c>net</c>, the value of Source must be a CIDR block. Example: 192.0.XX.XX/24.</description></item>
        /// <item><description>If SourceType is set to <c>group</c>, the value of Source must be the name of an address book. Example: db_group. If the db_group address book does not contain addresses, all source addresses are queried.</description></item>
        /// <item><description>If SourceType is set to <c>location</c>, the value of Source must be a location. Example: beijing.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify this parameter, all types of source addresses are queried.</para>
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
