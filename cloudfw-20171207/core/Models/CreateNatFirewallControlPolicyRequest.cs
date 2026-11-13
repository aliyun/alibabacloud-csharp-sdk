// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateNatFirewallControlPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The action that Cloud Firewall performs on traffic in the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>accept</b>: allows the traffic</description></item>
        /// <item><description><b>drop</b>: denies the traffic</description></item>
        /// <item><description><b>log</b>: monitors the traffic</description></item>
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
        /// <para>The list of application types supported by the access control policy.</para>
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
        /// <para>Allow traffic</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The destination port in the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the protocol is ICMP, leave this parameter empty.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Access control based on destination ports is not supported when the protocol is ICMP.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If the protocol is TCP, UDP, or ANY and the destination Protocol Type (DestPortType) is group, leave this parameter empty.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you set DestPortType to group, you do not need to specify a destination port. All ports managed by this policy are included in the destination port address book.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If the protocol is TCP, UDP, or ANY and the destination Protocol Type (DestPortType) is port, set this parameter to the destination port number.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("DestPort")]
        [Validation(Required=false)]
        public string DestPort { get; set; }

        /// <summary>
        /// <para>The name of the destination port address book in the access control policy.</para>
        /// <remarks>
        /// <para>If you set DestPortType to group, you must specify the name of the destination port address book.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>my_port_group</para>
        /// </summary>
        [NameInMap("DestPortGroup")]
        [Validation(Required=false)]
        public string DestPortGroup { get; set; }

        /// <summary>
        /// <para>The type of the destination port in the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>port</b>: a port</description></item>
        /// <item><description><b>group</b>: a port address book</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>port</para>
        /// </summary>
        [NameInMap("DestPortType")]
        [Validation(Required=false)]
        public string DestPortType { get; set; }

        /// <summary>
        /// <para>The destination address in the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If DestinationType is set to net, set Destination to the destination CIDR block.</para>
        /// <para>Example: 1.2.XX.XX/24</para>
        /// </description></item>
        /// <item><description><para>If DestinationType is set to group, set Destination to the name of the destination address book.</para>
        /// <para>Example: db_group</para>
        /// </description></item>
        /// <item><description><para>If DestinationType is set to domain, set Destination to the destination domain name.</para>
        /// <para>Example: *.aliyuncs.com</para>
        /// </description></item>
        /// <item><description><para>If DestinationType is set to location, set Destination to the destination region.</para>
        /// <para>Example: [&quot;BJ11&quot;, &quot;ZB&quot;\]</para>
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
        /// <para>The type of the destination address in the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>net</b>: a destination CIDR block</description></item>
        /// <item><description><b>group</b>: a destination address book</description></item>
        /// <item><description><b>domain</b>: a destination domain name</description></item>
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
        /// <para>The domain name parse method of the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: FQDN-based parse</description></item>
        /// <item><description><b>1</b>: DNS-based dynamic parse</description></item>
        /// <item><description><b>2</b>: FQDN-based and DNS-based dynamic parse</description></item>
        /// </list>
        /// <remarks>
        /// <para>If the domain name identification mode includes FQDN, you can only configure the TCP protocol. The supported applications are HTTP, HTTPS, SMTP, SMTPS, SSL, IMAPS, and POPS.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DomainResolveType")]
        [Validation(Required=false)]
        public int? DomainResolveType { get; set; }

        /// <summary>
        /// <para>The end time for the Policy Validity Period of the access control policy. The value is in the format of a UNIX timestamp in seconds. The time must be on the hour or half hour, and must be at least 30 minutes later than the start time.</para>
        /// <remarks>
        /// <para>If RepeatType is set to Permanent, leave EndTime empty. If RepeatType is set to None, Daily, Weekly, or Monthly, EndTime must have a value, and you must specify the Settings for the end time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1694764800</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The IP address version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>4</b>: IPv4 (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

        /// <summary>
        /// <para>The language of the response message. Valid values:</para>
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
        /// <para>The instance ID of the NAT gateway.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ngw-2vc2ustolqn6sr0******</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// <para>The priority of the access control policy. The priority value starts from 1 and increases sequentially. A smaller value indicates a higher priority.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NewOrder")]
        [Validation(Required=false)]
        public string NewOrder { get; set; }

        /// <summary>
        /// <para>The protocol type of the traffic in the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ANY: all protocols</description></item>
        /// <item><description>TCP</description></item>
        /// <item><description>UDP</description></item>
        /// <item><description>ICMP</description></item>
        /// </list>
        /// <remarks>
        /// <para>If the destination address is a threat intelligence address book or a cloud service address book of the domain name type, you can only configure the TCP protocol. The supported applications are HTTP, HTTPS, SMTP, SMTPS, and SSL.</para>
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
        /// <para>Specifies whether to enable the access control policy. By default, the policy is enabled after it is created. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables the access control policy</description></item>
        /// <item><description><b>false</b>: does not enable the access control policy</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Release")]
        [Validation(Required=false)]
        public string Release { get; set; }

        /// <summary>
        /// <para>The set of recurrence days for the Policy Validity Period of the access control policy.</para>
        /// <list type="bullet">
        /// <item><description>If RepeatType is set to <c>Permanent</c>, <c>None</c>, or <c>Daily</c>, leave RepeatDays empty.
        /// Example: []</description></item>
        /// <item><description>If RepeatType is set to Weekly, RepeatDays cannot be empty.
        /// Example: [0, 6]<remarks>
        /// <para>When the RepeatType Settings are Weekly, the values in RepeatDays cannot be duplicate.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description>If RepeatType is set to <c>Monthly</c>, RepeatDays cannot be empty.
        /// Example: [1, 31]<remarks>
        /// <para>When the RepeatType Settings are Monthly, the values in RepeatDays cannot be duplicate.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("RepeatDays")]
        [Validation(Required=false)]
        public List<long?> RepeatDays { get; set; }

        /// <summary>
        /// <para>The recurrence end time for the Policy Validity Period of the access control policy. Example: 23:30. The time must be on the hour or half hour, and must be at least 30 minutes later than the recurrence start time.</para>
        /// <remarks>
        /// <para>If RepeatType is set to Permanent or None, leave RepeatEndTime empty. If RepeatType is set to Daily, Weekly, or Monthly, RepeatEndTime must have a value, and you must specify the Settings for the recurrence end time.
        /// The time format is HH:mm (24-hour clock), such as 08:00 and 23:30.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>23:30</para>
        /// </summary>
        [NameInMap("RepeatEndTime")]
        [Validation(Required=false)]
        public string RepeatEndTime { get; set; }

        /// <summary>
        /// <para>The recurrence start time for the Policy Validity Period of the access control policy. Example: 08:00. The time must be on the hour or half hour, and must be at least 30 minutes earlier than the recurrence end time.</para>
        /// <remarks>
        /// <para>If RepeatType is set to Permanent or None, leave RepeatStartTime empty. If RepeatType is set to Daily, Weekly, or Monthly, RepeatStartTime must have a value, and you must specify the Settings for the recurrence start time.
        /// The time format is HH:mm (24-hour clock), such as 08:00 and 23:30.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>08:00</para>
        /// </summary>
        [NameInMap("RepeatStartTime")]
        [Validation(Required=false)]
        public string RepeatStartTime { get; set; }

        /// <summary>
        /// <para>The recurrence type of the Policy Validity Period for the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Permanent</b>: always (default)</description></item>
        /// <item><description><b>None</b>: a specific single time</description></item>
        /// <item><description><b>Daily</b>: every day</description></item>
        /// <item><description><b>Weekly</b>: every week</description></item>
        /// <item><description><b>Monthly</b>: every month</description></item>
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
        /// <item><description><para>If <b>SourceType</b> is set to <c>net</c>, set Source to the source CIDR block.</para>
        /// <para>Example: 10.2.4.0/24</para>
        /// </description></item>
        /// <item><description><para>If <b>SourceType</b> is set to <c>group</c>, set Source to the name of the source address book.</para>
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
        /// <para>The type of the source address in the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>net</b>: a source CIDR block</description></item>
        /// <item><description><b>group</b>: a source address book</description></item>
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
        /// <para>The start time for the Policy Validity Period of the access control policy. The value is in the format of a UNIX timestamp in seconds. The time must be on the hour or half hour, and must be at least 30 minutes earlier than the end time.</para>
        /// <remarks>
        /// <para>If RepeatType is set to Permanent, leave StartTime empty. If RepeatType is set to None, Daily, Weekly, or Monthly, StartTime must have a value, and you must specify the Settings for the start time.</para>
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
