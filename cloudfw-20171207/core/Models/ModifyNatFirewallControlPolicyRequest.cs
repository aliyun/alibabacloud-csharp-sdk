// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyNatFirewallControlPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The action that you want to perform on traffic. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>accept</b>: allows the traffic.</para>
        /// </description></item>
        /// <item><description><para><b>drop</b>: denies the traffic.</para>
        /// </description></item>
        /// <item><description><para><b>log</b>: monitors the traffic.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>log</para>
        /// </summary>
        [NameInMap("AclAction")]
        [Validation(Required=false)]
        public string AclAction { get; set; }

        /// <summary>
        /// <para>The UUID of the access control policy.</para>
        /// <para>To modify an access control policy, you must provide the UUID of the policy. You can call the DescribeNatFirewallControlPolicy operation to query the UUIDs of access control policies.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>63ab1c02-926a-4d1b-9ef7-*****</para>
        /// </summary>
        [NameInMap("AclUuid")]
        [Validation(Required=false)]
        public string AclUuid { get; set; }

        /// <summary>
        /// <para>The application names.</para>
        /// </summary>
        [NameInMap("ApplicationNameList")]
        [Validation(Required=false)]
        public List<string> ApplicationNameList { get; set; }

        /// <summary>
        /// <para>The description of the access control policy. Fuzzy match is supported.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the descriptions of all policies are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The destination port in the access control policy.</para>
        /// <remarks>
        /// <para>This parameter is required when you set <b>DestPortType</b> to <c>port</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("DestPort")]
        [Validation(Required=false)]
        public string DestPort { get; set; }

        /// <summary>
        /// <para>The name of the destination port address book in the access control policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_dest_port_group</para>
        /// </summary>
        [NameInMap("DestPortGroup")]
        [Validation(Required=false)]
        public string DestPortGroup { get; set; }

        /// <summary>
        /// <para>The type of the destination port in the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>port</b>: port</para>
        /// </description></item>
        /// <item><description><para><b>group</b>: port address book</para>
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
        /// <list type="bullet">
        /// <item><description><para>If <b>DestinationType</b> is <c>net</c>, specify a destination CIDR block. Example: <c>1.2.3.4/24</c>.</para>
        /// </description></item>
        /// <item><description><para>If <b>DestinationType</b> is <c>group</c>, specify a destination address book. Example: <c>db_group</c>.</para>
        /// </description></item>
        /// <item><description><para>If <b>DestinationType</b> is <c>domain</c>, specify a destination domain name. Example: <c>*.aliyuncs.com</c>.</para>
        /// </description></item>
        /// <item><description><para>If <b>DestinationType</b> is <c>location</c>, specify a destination location. For more information about location codes, see AddIpamPoolCidr. Example: <c>[&quot;BJ11&quot;, &quot;ZB&quot;]</c>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>x.x.x.x/32</para>
        /// </summary>
        [NameInMap("Destination")]
        [Validation(Required=false)]
        public string Destination { get; set; }

        /// <summary>
        /// <para>The type of the destination address in the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>net</b>: destination CIDR block</para>
        /// </description></item>
        /// <item><description><para><b>group</b>: destination address book</para>
        /// </description></item>
        /// <item><description><para><b>domain</b>: destination domain name</para>
        /// </description></item>
        /// <item><description><para><b>location</b>: destination location</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>net</para>
        /// </summary>
        [NameInMap("DestinationType")]
        [Validation(Required=false)]
        public string DestinationType { get; set; }

        /// <summary>
        /// <para>The direction of the traffic to which the access control policy applies. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>out</b>: outbound traffic</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>out</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The DNS resolution method of the domain name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: FQDN</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: dynamic DNS</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: FQDN and dynamic DNS</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If the domain name is resolved in FQDN mode, you can select only the TCP protocol. The supported applications are HTTP, HTTPS, SMTP, SMTPS, SSL, IMAPS, and POPS.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DomainResolveType")]
        [Validation(Required=false)]
        public string DomainResolveType { get; set; }

        /// <summary>
        /// <para>The end time of the effective period for the access control policy. The time is a Unix timestamp. The time must be on the hour or half-hour and be at least 30 minutes after the start time.</para>
        /// <remarks>
        /// <para>If <c>RepeatType</c> is Permanent, <c>EndTime</c> is empty. If <c>RepeatType</c> is None, Daily, Weekly, or Monthly, <c>EndTime</c> is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1694764800</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Valid values:</para>
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
        /// <para>The protocol type in the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ANY</b></para>
        /// </description></item>
        /// <item><description><para><b>TCP</b></para>
        /// </description></item>
        /// <item><description><para><b>UDP</b></para>
        /// </description></item>
        /// <item><description><para><b>ICMP</b></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para><b>ANY</b> indicates that the policy applies to all protocol types.</para>
        /// </remarks>
        /// <remarks>
        /// <para>If the destination is a domain name-based address book that contains a threat intelligence address book or a cloud service address book, you can select TCP. If you select TCP, you can select HTTP, HTTPS, SMTP, SMTPS, or SSL.</para>
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
        /// <para>The days of a week or a month on which the policy recurs.</para>
        /// <list type="bullet">
        /// <item><description><para>If you set <b>RepeatType</b> to <c>Permanent</c>, <c>None</c>, or <c>Daily</c>, leave this parameter empty. Example: [].</para>
        /// </description></item>
        /// <item><description><para>If you set <b>RepeatType</b> to <c>Weekly</c>, this parameter is required. Example: [0, 6].</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>When RepeatType is set to Weekly, RepeatDays does not allow duplicates.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>When RepeatType is <c>Monthly</c>, RepeatDays cannot be empty. For example: [1, 31]</description></item>
        /// </list>
        /// <remarks>
        /// <para>When RepeatType is set to Monthly, RepeatDays cannot contain duplicate values.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("RepeatDays")]
        [Validation(Required=false)]
        public List<long?> RepeatDays { get; set; }

        /// <summary>
        /// <para>The end time of the policy\&quot;s recurrence period. The time must be in the 24-hour HH:mm format, such as 23:30, be on the hour or half-hour, and be at least half an hour later than the recurrence start time.</para>
        /// <remarks>
        /// <para>When RepeatType is Permanent or None, RepeatEndTime is empty. When RepeatType is Daily, Weekly, or Monthly, you must set RepeatEndTime to specify the end time for the repetition.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>23:30</para>
        /// </summary>
        [NameInMap("RepeatEndTime")]
        [Validation(Required=false)]
        public string RepeatEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the repeat cycle. Use the 24-hour HH:mm format, such as 08:00. The time must be on the hour or half-hour and at least 30 minutes before the repeat end time.</para>
        /// <remarks>
        /// <para>This parameter is not used if <c>RepeatType</c> is set to <c>Permanent</c> or <c>None</c>. This parameter is required if <c>RepeatType</c> is set to <c>Daily</c>, <c>Weekly</c>, or <c>Monthly</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>08:00</para>
        /// </summary>
        [NameInMap("RepeatStartTime")]
        [Validation(Required=false)]
        public string RepeatStartTime { get; set; }

        /// <summary>
        /// <para>The recurrence type for the policy to take effect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Permanent</b> (default): The policy is always in effect.</para>
        /// </description></item>
        /// <item><description><para><b>None</b>: The policy takes effect for a specified period of time.</para>
        /// </description></item>
        /// <item><description><para><b>Daily</b>: The policy takes effect daily.</para>
        /// </description></item>
        /// <item><description><para><b>Weekly</b>: The policy takes effect weekly.</para>
        /// </description></item>
        /// <item><description><para><b>Monthly</b>: The policy takes effect monthly.</para>
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
        /// <para>The source address in the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>When <b>SourceType</b> is <c>net</c>, Source is the source CIDR address, for example, 10.2.XX.XX/24.</para>
        /// </description></item>
        /// <item><description><para>If <b>SourceType</b> is <c>group</c>, specify a source address book. Example: <c>db_group</c>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10.2.XX.XX/24</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The type of the source address in the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>net</b>: source CIDR block</para>
        /// </description></item>
        /// <item><description><para><b>group</b>: source address book</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>net</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The start time of the effective period for the access control policy is specified in the Unix timestamp format. It must be on the hour or half-hour and at least half an hour earlier than the end time.</para>
        /// <remarks>
        /// <para>When RepeatType is Permanent, StartTime is empty. When RepeatType is None, Daily, Weekly, or Monthly, StartTime is required.</para>
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
