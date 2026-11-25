// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyNatFirewallControlPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The action that Cloud Firewall performs on traffic in the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>accept</b>: Allows the traffic.</description></item>
        /// <item><description><b>drop</b>: Denies the traffic.</description></item>
        /// <item><description><b>log</b>: Monitors the traffic.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>log</para>
        /// </summary>
        [NameInMap("AclAction")]
        [Validation(Required=false)]
        public string AclAction { get; set; }

        /// <summary>
        /// <para>The UUID of the access control policy.
        /// To delete an access control policy, you must provide the UUID of the policy. You can call the DescribeNatFirewallControlPolicy operation to obtain the UUID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>63ab1c02-926a-4d1b-9ef7-*****</para>
        /// </summary>
        [NameInMap("AclUuid")]
        [Validation(Required=false)]
        public string AclUuid { get; set; }

        /// <summary>
        /// <para>The names of the applications.</para>
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
        /// <para>The destination port for traffic in the access control policy of the virtual private cloud (VPC) firewalls.</para>
        /// <remarks>
        /// <para>Specify this parameter when <b>DestPortType</b> is set to <c>port</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("DestPort")]
        [Validation(Required=false)]
        public string DestPort { get; set; }

        /// <summary>
        /// <para>The name of the destination port address book for traffic in the access control policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_dest_port_group</para>
        /// </summary>
        [NameInMap("DestPortGroup")]
        [Validation(Required=false)]
        public string DestPortGroup { get; set; }

        /// <summary>
        /// <para>The type of the destination port for traffic in the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>port</b>: port.</description></item>
        /// <item><description><b>group</b>: port address book.</description></item>
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
        /// <item><description>If <b>DestinationType</b> is set to net, <b>Destination</b> is the destination CIDR block. Example: 1.2.3.4/24.</description></item>
        /// <item><description>If <b>DestinationType</b> is set to group, <b>Destination</b> is the name of the destination address book. Example: db_group.</description></item>
        /// <item><description>If <b>DestinationType</b> is set to domain, <b>Destination</b> is the destination domain name. Example: *.aliyuncs.com.</description></item>
        /// <item><description>If <b>DestinationType</b> is set to location, <b>Destination</b> is the destination region. For the region codes, see the following section. Example: [&quot;BJ11&quot;, &quot;ZB&quot;].</description></item>
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
        /// <item><description><b>net</b>: destination CIDR block.</description></item>
        /// <item><description><b>group</b>: destination address book.</description></item>
        /// <item><description><b>domain</b>: destination domain name.</description></item>
        /// <item><description><b>location</b>: destination region.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>net</para>
        /// </summary>
        [NameInMap("DestinationType")]
        [Validation(Required=false)]
        public string DestinationType { get; set; }

        /// <summary>
        /// <para>The traffic direction of the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>out</b>: outbound traffic.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>out</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The domain name resolution method of the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: FQDN-based resolution.</description></item>
        /// <item><description><b>1</b>: DNS-based dynamic resolution.</description></item>
        /// <item><description><b>2</b>: FQDN and DNS-based dynamic resolution.<remarks>
        /// <para>If the domain name identification mode includes FQDN, only the TCP protocol is allowed. You can select HTTP, HTTPS, SMTP, SMTPS, SSL, IMAPS, or POPS as the application.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DomainResolveType")]
        [Validation(Required=false)]
        public string DomainResolveType { get; set; }

        /// <summary>
        /// <para>The end time of the policy validity period for the access control policy. Specify the time in the UNIX timestamp format (seconds). The time must be on the hour or half-hour, and must be at least 30 minutes later than the start time.</para>
        /// <remarks>
        /// <para>If RepeatType is set to Permanent, EndTime is empty. If RepeatType is set to None, Daily, Weekly, or Monthly, EndTime must be specified.</para>
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
        /// <para>The type of the security protocol for traffic in the access control policy. Supported protocol types:</para>
        /// <list type="bullet">
        /// <item><description><b>ANY</b></description></item>
        /// <item><description><b>TCP</b></description></item>
        /// <item><description><b>UDP</b></description></item>
        /// <item><description><b>ICMP</b><remarks>
        /// <para><b>ANY</b> indicates that the policy applies to all types of applications.
        /// If the destination address is a threat intelligence address book or a cloud service address book of the domain name type, you can set this parameter to TCP. If you select TCP, you can select HTTP, HTTPS, SMTP, SMTPS, or SSL as the application.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
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
        /// <item><description><b>true</b>: The policy is enabled.</description></item>
        /// <item><description><b>false</b>: The policy is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Release")]
        [Validation(Required=false)]
        public string Release { get; set; }

        /// <summary>
        /// <para>The set of recurrence days for the policy validity period of the access control policy.</para>
        /// <list type="bullet">
        /// <item><description>If RepeatType is set to <c>Permanent</c>, <c>None</c>, or <c>Daily</c>, RepeatDays is an empty set. Example: [].</description></item>
        /// <item><description>If RepeatType is set to Weekly, RepeatDays cannot be empty. Example: [0, 6].<remarks>
        /// <para>If RepeatType is set to Weekly, the values in RepeatDays must be unique.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description>If RepeatType is set to <c>Monthly</c>, RepeatDays cannot be empty. Example: [1, 31].<remarks>
        /// <para>If RepeatType is set to Monthly, the values in RepeatDays must be unique.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("RepeatDays")]
        [Validation(Required=false)]
        public List<long?> RepeatDays { get; set; }

        /// <summary>
        /// <para>The recurrence end time when the policy takes effect. Use the 24-hour time format HH:mm, such as 23:30. The time must be on the hour or half-hour, and must be at least 30 minutes later than the recurrence start time.</para>
        /// <remarks>
        /// <para>If RepeatType is set to Permanent or None, RepeatEndTime is empty. If RepeatType is set to Daily, Weekly, or Monthly, RepeatEndTime must be specified.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>23:30</para>
        /// </summary>
        [NameInMap("RepeatEndTime")]
        [Validation(Required=false)]
        public string RepeatEndTime { get; set; }

        /// <summary>
        /// <para>The recurrence start time when the policy takes effect. Use the 24-hour time format HH:mm, such as 08:00. The time must be on the hour or half-hour, and must be at least 30 minutes earlier than the recurrence end time.</para>
        /// <remarks>
        /// <para>If RepeatType is set to Permanent or None, RepeatStartTime is empty. If RepeatType is set to Daily, Weekly, or Monthly, RepeatStartTime must be specified.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>08:00</para>
        /// </summary>
        [NameInMap("RepeatStartTime")]
        [Validation(Required=false)]
        public string RepeatStartTime { get; set; }

        /// <summary>
        /// <para>The recurrence type of the policy validity period for the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Permanent</b> (default): Always.</description></item>
        /// <item><description><b>None</b>: Specified single time.</description></item>
        /// <item><description><b>Daily</b>: Every day.</description></item>
        /// <item><description><b>Weekly</b>: Every week.</description></item>
        /// <item><description><b>Monthly</b>: Every month.</description></item>
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
        /// <item><description>If <b>SourceType</b> is set to <c>net</c>, Source is the source CIDR block. Example: 10.2.XX.XX/24.</description></item>
        /// <item><description>If <b>SourceType</b> is set to <c>group</c>, Source is the name of the source address book. Example: db_group.</description></item>
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
        /// <item><description><b>net</b>: source CIDR block.</description></item>
        /// <item><description><b>group</b>: source address book.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>net</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The start time of the policy validity period for the access control policy. Specify the time in the UNIX timestamp format (seconds). The time must be on the hour or half-hour, and must be at least 30 minutes earlier than the end time.</para>
        /// <remarks>
        /// <para>If RepeatType is set to Permanent, StartTime is empty. If RepeatType is set to None, Daily, Weekly, or Monthly, StartTime must be specified.</para>
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
