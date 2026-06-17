// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeControlPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The action that Cloud Firewall performs on the traffic. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>accept</b>: Allow</para>
        /// </description></item>
        /// <item><description><para><b>drop</b>: Deny</para>
        /// </description></item>
        /// <item><description><para><b>log</b>: Monitor</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not set this parameter, all action types are queried.</para>
        /// </remarks>
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
        /// <para>00281255-d220-4db1-8f4f-c4df221a****</para>
        /// </summary>
        [NameInMap("AclUuid")]
        [Validation(Required=false)]
        public string AclUuid { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// <para>Default value: 1.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The destination address in the access control policy. Fuzzy queries are supported. The value of this parameter varies based on the value of the \<c>DestinationType\\</c> parameter.</para>
        /// <list type="bullet">
        /// <item><description><para>If \<c>DestinationType\\</c> is \<c>net\\</c>, the value of this parameter is a CIDR block. Example: 10.0.3.0/24.</para>
        /// </description></item>
        /// <item><description><para>If \<c>DestinationType\\</c> is \<c>domain\\</c>, the value of this parameter is a domain name. Example: aliyun.</para>
        /// </description></item>
        /// <item><description><para>If \<c>DestinationType\\</c> is \<c>group\\</c>, the value of this parameter is the name of an address book. Example: db_group.</para>
        /// </description></item>
        /// <item><description><para>If \<c>DestinationType\\</c> is \<c>location\\</c>, the value of this parameter is a region name. For more information about region codes, see AddControlPolicy. Example: \<c>[&quot;BJ11&quot;, &quot;ZB&quot;]\\</c>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not set this parameter, all types of destination addresses are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX</para>
        /// </summary>
        [NameInMap("Destination")]
        [Validation(Required=false)]
        public string Destination { get; set; }

        /// <summary>
        /// <para>The traffic direction that the access control policy controls. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>in</b>: Inbound traffic from an external source to an internal destination.</para>
        /// </description></item>
        /// <item><description><para><b>out</b>: Outbound traffic from an internal source to an external destination.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>in</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The IP version supported. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>4</b> (default): IPv4 address</para>
        /// </description></item>
        /// <item><description><para><b>6</b>: IPv6 address</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

        /// <summary>
        /// <para>The language of the response message. Valid values:</para>
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
        /// <para>The number of entries to return on each page.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>TCP</para>
        /// </summary>
        [NameInMap("Proto")]
        [Validation(Required=false)]
        public string Proto { get; set; }

        /// <summary>
        /// <para>The status of the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The access control policy is enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The access control policy is disabled.</para>
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
        /// <para>The recurrence type for the policy validity period of the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Permanent</b> (default): Always</para>
        /// </description></item>
        /// <item><description><para><b>None</b>: One-time</para>
        /// </description></item>
        /// <item><description><para><b>Daily</b>: Daily</para>
        /// </description></item>
        /// <item><description><para><b>Weekly</b>: Weekly</para>
        /// </description></item>
        /// <item><description><para><b>Monthly</b>: Monthly</para>
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
        /// <para>The source address in the access control policy. Fuzzy queries are supported. The value of this parameter varies based on the value of the \<c>SourceType\\</c> parameter.</para>
        /// <list type="bullet">
        /// <item><description><para>If \<c>SourceType\\</c> is \<c>net\\</c>, the value of this parameter is a CIDR block. Example: 192.0.XX.XX/24.</para>
        /// </description></item>
        /// <item><description><para>If \<c>SourceType\\</c> is \<c>group\\</c>, the value of this parameter is the name of a source address book. Example: \<c>db_group\\</c>. If you leave this parameter empty, all source addresses are queried.</para>
        /// </description></item>
        /// <item><description><para>If \<c>SourceType\\</c> is \<c>location\\</c>, the value of this parameter is a source region. Example: \<c>Beijing\\</c> or \<c>beijing\\</c>. You can use either the Chinese name or the English name for the query.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not set this parameter, all types of source addresses are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
