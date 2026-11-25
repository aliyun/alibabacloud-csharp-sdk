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
        /// <item><description><b>accept</b>: Allows the traffic.</description></item>
        /// <item><description><b>drop</b>: Denies the traffic.</description></item>
        /// <item><description><b>log</b>: Monitors the traffic.</description></item>
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
        /// <item><description>If the protocol is ICMP, leave this parameter empty.<remarks>
        /// <para>When the protocol is ICMP, access control based on the destination port is not supported.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description>If the protocol is TCP, UDP, or ANY, and the destination Protocol Type (DestPortType) is group, leave this parameter empty.<remarks>
        /// <para>When the destination Protocol Type is set to group (destination port address book), you do not need to specify a destination port number. All ports managed by this access control policy are included in the destination port address book.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description>If the protocol is TCP, UDP, or ANY, and the destination Protocol Type (DestPortType) is port, set this parameter to the destination port number.</description></item>
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
        /// <para>If DestPortType is set to group, you must specify the name of the destination port address book.</para>
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
        /// <para>The destination address in the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If DestinationType is set to net, Destination is the destination CIDR block. Example: 1.2.XX.XX/24.</description></item>
        /// <item><description>If DestinationType is set to group, Destination is the name of the destination address book. Example: db_group.</description></item>
        /// <item><description>If DestinationType is set to domain, Destination is the destination domain name. Example: *.aliyuncs.com.</description></item>
        /// <item><description>If DestinationType is set to location, Destination is the destination region. Example: [&quot;BJ11&quot;, &quot;ZB&quot;].</description></item>
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
        /// <item><description><b>net</b>: destination CIDR block.</description></item>
        /// <item><description><b>group</b>: destination address book.</description></item>
        /// <item><description><b>domain</b>: destination domain name.</description></item>
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
        /// <item><description><b>out</b>: outbound traffic.</description></item>
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
        /// <para>The domain name parse pattern of the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: FQDN-based resolution.</description></item>
        /// <item><description><b>1</b>: DNS-based dynamic resolution.</description></item>
        /// <item><description><b>2</b>: FQDN- and DNS-based dynamic resolution.<remarks>
        /// <para>If the domain name identification mode includes FQDN, only the TCP protocol is allowed. The application can be HTTP, HTTPS, SMTP, SMTPS, SSL, IMAPS, or POPS.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DomainResolveType")]
        [Validation(Required=false)]
        public int? DomainResolveType { get; set; }

        /// <summary>
        /// <para>The end time of the Policy Validity Period of the access control policy. The value is in the UNIX timestamp format in seconds. The time must be on the hour or half-hour, and must be at least 30 minutes later than the start time.</para>
        /// <remarks>
        /// <para>If RepeatType is set to Permanent, EndTime is empty. If RepeatType is set to None, Daily, Weekly, or Monthly, EndTime must be specified, and you must configure the Settings for the end time.</para>
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
        /// <item><description><b>4</b>: IPv4 (default).</description></item>
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
        /// <item><description><b>zh</b>: Chinese (default).</description></item>
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
        /// <item><description>ANY: all protocols.</description></item>
        /// <item><description>TCP</description></item>
        /// <item><description>UDP</description></item>
        /// <item><description>ICMP<remarks>
        /// <para>If the destination address is a threat intelligence address book or a cloud service address book of the domain name type, only the TCP protocol is allowed. The application can be HTTP, HTTPS, SMTP, SMTPS, or SSL.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
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
        /// <item><description><b>true</b>: Enables the access control policy.</description></item>
        /// <item><description><b>false</b>: Does not enable the access control policy.</description></item>
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
        /// <item><description>If RepeatType is set to <c>Permanent</c>, <c>None</c>, or <c>Daily</c>, RepeatDays is an empty set. Example: [].</description></item>
        /// <item><description>If RepeatType is set to Weekly, RepeatDays cannot be empty. Example: [0, 6].<remarks>
        /// <para>When RepeatType is set to Weekly, the values in RepeatDays cannot be duplicated.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description>If RepeatType is set to <c>Monthly</c>, RepeatDays cannot be empty. Example: [1, 31].<remarks>
        /// <para>When RepeatType is set to Monthly, the values in RepeatDays cannot be duplicated.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("RepeatDays")]
        [Validation(Required=false)]
        public List<long?> RepeatDays { get; set; }

        /// <summary>
        /// <para>The recurrence end time of the Policy Validity Period of the access control policy. Example: 23:30. The time must be on the hour or half-hour, and must be at least 30 minutes later than the recurrence start time.</para>
        /// <remarks>
        /// <para>If RepeatType is set to Permanent or None, RepeatEndTime is empty. If RepeatType is set to Daily, Weekly, or Monthly, RepeatEndTime must be specified, and you must configure the Settings for the recurrence end time.
        /// The time format is HH:mm (24-hour clock). Example: 08:00 or 23:30.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>23:30</para>
        /// </summary>
        [NameInMap("RepeatEndTime")]
        [Validation(Required=false)]
        public string RepeatEndTime { get; set; }

        /// <summary>
        /// <para>The recurrence start time of the Policy Validity Period of the access control policy. Example: 08:00. The time must be on the hour or half-hour, and must be at least 30 minutes earlier than the recurrence end time.</para>
        /// <remarks>
        /// <para>If RepeatType is set to Permanent or None, RepeatStartTime is empty. If RepeatType is set to Daily, Weekly, or Monthly, RepeatStartTime must be specified, and you must configure the Settings for the recurrence start time.
        /// The time format is HH:mm (24-hour clock). Example: 08:00 or 23:30.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>08:00</para>
        /// </summary>
        [NameInMap("RepeatStartTime")]
        [Validation(Required=false)]
        public string RepeatStartTime { get; set; }

        /// <summary>
        /// <para>The recurrence type of the Policy Validity Period of the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Permanent</b>: always (default).</description></item>
        /// <item><description><b>None</b>: specified single time.</description></item>
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
        /// <para>The source address in the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>SourceType</b> is set to <c>net</c>, Source is the source CIDR block. Example: 10.2.4.0/24.</description></item>
        /// <item><description>If <b>SourceType</b> is set to <c>group</c>, Source is the name of the source address book. Example: db_group.</description></item>
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
        /// <item><description><b>net</b>: source CIDR block.</description></item>
        /// <item><description><b>group</b>: source address book.</description></item>
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
        /// <para>The start time of the Policy Validity Period of the access control policy. The value is in the UNIX timestamp format in seconds. The time must be on the hour or half-hour, and must be at least 30 minutes earlier than the end time.</para>
        /// <remarks>
        /// <para>If RepeatType is set to Permanent, StartTime is empty. If RepeatType is set to None, Daily, Weekly, or Monthly, StartTime must be specified, and you must configure the Settings for the start time.</para>
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
