// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateNatFirewallControlPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The action that Cloud Firewall performs on traffic that matches the access control policy.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>accept</b>: Allows the traffic.</para>
        /// </description></item>
        /// <item><description><para><b>drop</b>: Drops the traffic.</para>
        /// </description></item>
        /// <item><description><para><b>log</b>: Logs the traffic.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>log</para>
        /// </summary>
        [NameInMap("AclAction")]
        [Validation(Required=false)]
        public string AclAction { get; set; }

        /// <summary>
        /// <para>The list of applications to which the access control policy applies.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ApplicationNameList")]
        [Validation(Required=false)]
        public List<string> ApplicationNameList { get; set; }

        /// <summary>
        /// <para>The description of the access control policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>放行流量</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The destination port for the traffic. The value of this parameter depends on the <c>Proto</c> and <c>DestPortType</c> parameters.</para>
        /// <list type="bullet">
        /// <item><description>If <c>Proto</c> is <c>ICMP</c>, leave this parameter empty.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Access control cannot be configured based on the destination port for ICMP traffic.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If the destination port type (<c>DestPortType</c>) is <c>group</c>, leave this parameter empty.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If <c>DestPortType</c> is set to <c>group</c>, you do not need to specify a destination port because the required ports are defined in the selected port address book.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If the protocol is TCP, UDP, or ANY and the destination port type (<c>DestPortType</c>) is <c>port</c>, specify the destination port number.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("DestPort")]
        [Validation(Required=false)]
        public string DestPort { get; set; }

        /// <summary>
        /// <para>The name of the destination port address book.</para>
        /// <remarks>
        /// <para>This parameter is required if <c>DestPortType</c> is set to <c>group</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>my_port_group</para>
        /// </summary>
        [NameInMap("DestPortGroup")]
        [Validation(Required=false)]
        public string DestPortGroup { get; set; }

        /// <summary>
        /// <para>The type of the destination port.</para>
        /// <list type="bullet">
        /// <item><description><para><b>port</b>: Port or port range</para>
        /// </description></item>
        /// <item><description><para><b>group</b>: Port address book</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>port</para>
        /// </summary>
        [NameInMap("DestPortType")]
        [Validation(Required=false)]
        public string DestPortType { get; set; }

        /// <summary>
        /// <para>The destination address in the access control policy.</para>
        /// <para>The value of this parameter varies based on the value of <c>DestinationType</c>:</para>
        /// <list type="bullet">
        /// <item><description><para>If <c>DestinationType</c> is <c>net</c>, set this parameter to the destination CIDR.</para>
        /// <para>Example: <c>1.2.XX.XX/24</c></para>
        /// </description></item>
        /// <item><description><para>If <c>DestinationType</c> is <c>group</c>, set this parameter to the name of the destination address book.</para>
        /// <para>Example: <c>db_group</c></para>
        /// </description></item>
        /// <item><description><para>If <c>DestinationType</c> is <c>domain</c>, set this parameter to the destination domain.</para>
        /// <para>Example: \*.aliyuncs.com</para>
        /// </description></item>
        /// <item><description><para>If <c>DestinationType</c> is <c>location</c>, set this parameter to the destination location.</para>
        /// <para>Example: [&quot;BJ11&quot;, &quot;ZB&quot;]</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>XX.XX.XX.XX/24</para>
        /// </summary>
        [NameInMap("Destination")]
        [Validation(Required=false)]
        public string Destination { get; set; }

        /// <summary>
        /// <para>The type of the destination address in the access control policy.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>net</b>: Destination CIDR</para>
        /// </description></item>
        /// <item><description><para><b>group</b>: Destination address book</para>
        /// </description></item>
        /// <item><description><para><b>domain</b>: Destination domain</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>net</para>
        /// </summary>
        [NameInMap("DestinationType")]
        [Validation(Required=false)]
        public string DestinationType { get; set; }

        /// <summary>
        /// <para>The traffic direction for the access control policy. Valid values:</para>
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
        /// <para>The domain name resolution method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: FQDN-based resolution</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Dynamic DNS-based resolution</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: FQDN-based and dynamic DNS-based resolution</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If the resolution method includes FQDN, you can set the protocol only to TCP. The supported applications are HTTP, HTTPS, SMTP, SMTPS, and SSL.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DomainResolveType")]
        [Validation(Required=false)]
        public int? DomainResolveType { get; set; }

        /// <summary>
        /// <para>The end time of the policy\&quot;s validity period, specified as a Unix timestamp. The time must be on the hour or half-hour and be at least 30 minutes after the start time.</para>
        /// <remarks>
        /// <para>This parameter is required if <c>RepeatType</c> is <c>None</c>, <c>Daily</c>, <c>Weekly</c>, or <c>Monthly</c>. If <c>RepeatType</c> is <c>Permanent</c>, leave this parameter empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1694764800</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The IP version for the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>4</b> (default): IPv4</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

        /// <summary>
        /// <para>The language of the response messages.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b>: Chinese (default)</para>
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
        /// <para>The instance ID of the NAT Gateway.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ngw-2vc2ustolqn6sr0******</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// <para>The priority of the access control policy. Values start from 1. A smaller value indicates a higher priority.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NewOrder")]
        [Validation(Required=false)]
        public string NewOrder { get; set; }

        /// <summary>
        /// <para>The protocol for the traffic in the access control policy.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ANY: all protocols</para>
        /// </description></item>
        /// <item><description><para>TCP</para>
        /// </description></item>
        /// <item><description><para>UDP</para>
        /// </description></item>
        /// <item><description><para>ICMP</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If the destination is a domain, a threat intelligence address book, or a cloud service address book, you can only set this parameter to <c>TCP</c>. The supported application types are HTTP, HTTPS, SMTP, SMTPS, and SSL.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ANY</para>
        /// </summary>
        [NameInMap("Proto")]
        [Validation(Required=false)]
        public string Proto { get; set; }

        /// <summary>
        /// <para>Specifies whether the access control policy is enabled. By default, policies are enabled upon creation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enables the policy.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disables the policy.</para>
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
        /// <para>The days of the week or month on which the policy recurs.</para>
        /// <list type="bullet">
        /// <item><description><para>If <c>RepeatType</c> is set to <c>Permanent</c>, <c>None</c>, or <c>Daily</c>, leave this parameter empty. Example: <c>[]</c></para>
        /// </description></item>
        /// <item><description><para>If <c>RepeatType</c> is <c>Weekly</c>, this parameter is required. Example: <c>[0, 6]</c></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If <c>RepeatType</c> is <c>Weekly</c>, the values in <c>RepeatDays</c> must be unique.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If <c>RepeatType</c> is <c>Monthly</c>, this parameter is required. Example: <c>[1, 31]</c></description></item>
        /// </list>
        /// <remarks>
        /// <para>If <c>RepeatType</c> is <c>Monthly</c>, the values in <c>RepeatDays</c> must be unique.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("RepeatDays")]
        [Validation(Required=false)]
        public List<long?> RepeatDays { get; set; }

        /// <summary>
        /// <para>The end time of the recurrence. The time must be on the hour or half-hour, and must be at least 30 minutes later than the start time.</para>
        /// <remarks>
        /// <para>This parameter is required if <c>RepeatType</c> is set to <c>Daily</c>, <c>Weekly</c>, or <c>Monthly</c>. If <c>RepeatType</c> is <c>Permanent</c> or <c>None</c>, leave this parameter empty.
        /// The time is in the HH:mm format (24-hour). For example, <c>08:00</c> or <c>23:30</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>23:30</para>
        /// </summary>
        [NameInMap("RepeatEndTime")]
        [Validation(Required=false)]
        public string RepeatEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the recurrence. The time must be on the hour or half-hour, and must be at least 30 minutes earlier than the end time.</para>
        /// <remarks>
        /// <para>This parameter is required if <c>RepeatType</c> is set to <c>Daily</c>, <c>Weekly</c>, or <c>Monthly</c>. If <c>RepeatType</c> is <c>Permanent</c> or <c>None</c>, leave this parameter empty.
        /// The time is in the HH:mm format (24-hour). For example, <c>08:00</c> or <c>23:30</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>08:00</para>
        /// </summary>
        [NameInMap("RepeatStartTime")]
        [Validation(Required=false)]
        public string RepeatStartTime { get; set; }

        /// <summary>
        /// <para>The recurrence type for the policy validity period. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Permanent</b> (default): The policy is always active.</para>
        /// </description></item>
        /// <item><description><para><b>None</b>: The policy runs once for a specified duration.</para>
        /// </description></item>
        /// <item><description><para><b>Daily</b>: The policy recurs daily.</para>
        /// </description></item>
        /// <item><description><para><b>Weekly</b>: The policy recurs weekly within a specified time range.</para>
        /// </description></item>
        /// <item><description><para><b>Monthly</b>: The policy recurs monthly within a specified time range.</para>
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
        /// <para>The source address in the access control policy.</para>
        /// <para>The value of this parameter varies based on the value of <c>SourceType</c>:</para>
        /// <list type="bullet">
        /// <item><description><para>If <b>SourceType</b> is <c>net</c>, set this parameter to the source CIDR.</para>
        /// <para>Example: 10.2.4.0/24</para>
        /// </description></item>
        /// <item><description><para>If <b>SourceType</b> is <c>group</c>, set this parameter to the name of the source address book.</para>
        /// <para>Example: db_group</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.25/32</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The type of the source address in the access control policy.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>net</b>: Source CIDR</para>
        /// </description></item>
        /// <item><description><para><b>group</b>: Source address book</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>net</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The start time of the policy\&quot;s validity period, specified as a Unix timestamp. The time must be on the hour or half-hour and be at least 30 minutes before the end time.</para>
        /// <remarks>
        /// <para>This parameter is required if <c>RepeatType</c> is <c>None</c>, <c>Daily</c>, <c>Weekly</c>, or <c>Monthly</c>. If <c>RepeatType</c> is <c>Permanent</c>, leave this parameter empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1694761200</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
