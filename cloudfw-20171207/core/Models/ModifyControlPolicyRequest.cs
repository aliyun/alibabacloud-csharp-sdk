// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyControlPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The action that Cloud Firewall performs on traffic in the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>accept</b>: Allows the traffic.</description></item>
        /// <item><description><b>drop</b>: Denies the traffic.</description></item>
        /// <item><description><b>log</b>: Monitors the traffic.</description></item>
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
        /// <remarks>
        /// <para>To modify an access control policy, you must provide its UUID. You can call the <a href="https://help.aliyun.com/document_detail/138866.html">DescribeControlPolicy</a> operation to obtain the UUID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00281255-d220-4db1-8f4f-c4df221ad84c</para>
        /// </summary>
        [NameInMap("AclUuid")]
        [Validation(Required=false)]
        public string AclUuid { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The application type supported by the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ANY</b></description></item>
        /// <item><description><b>HTTP</b></description></item>
        /// <item><description><b>HTTPS</b></description></item>
        /// <item><description><b>MySQL</b></description></item>
        /// <item><description><b>SMTP</b></description></item>
        /// <item><description><b>SMTPS</b></description></item>
        /// <item><description><b>RDP</b></description></item>
        /// <item><description><b>VNC</b></description></item>
        /// <item><description><b>SSH</b></description></item>
        /// <item><description><b>Redis</b></description></item>
        /// <item><description><b>MQTT</b></description></item>
        /// <item><description><b>MongoDB</b></description></item>
        /// <item><description><b>Memcache</b></description></item>
        /// <item><description><b>SSL</b></description></item>
        /// </list>
        /// <remarks>
        /// <para><b>ANY</b> indicates that the policy applies to all application types.</para>
        /// </remarks>
        /// <remarks>
        /// <para>You must specify either ApplicationNameList or ApplicationName. They cannot be both empty. If both are specified, ApplicationNameList takes precedence.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        [Obsolete]
        public string ApplicationName { get; set; }

        /// <summary>
        /// <para>The list of application names.</para>
        /// <remarks>
        /// <para>You must specify either ApplicationNameList or ApplicationName. They cannot be both empty. If both are specified, ApplicationNameList takes precedence.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ApplicationNameList")]
        [Validation(Required=false)]
        public List<string> ApplicationNameList { get; set; }

        /// <summary>
        /// <para>The idempotency token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddadxefexxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the access control policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The destination port for traffic in the access control policy.</para>
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
        /// <para>my_port_group</para>
        /// </summary>
        [NameInMap("DestPortGroup")]
        [Validation(Required=false)]
        public string DestPortGroup { get; set; }

        /// <summary>
        /// <para>The type of the destination port for traffic in the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>port</b>: port</description></item>
        /// <item><description><b>group</b>: port address book</description></item>
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
        /// <item><description>If <b>DestinationType</b> is set to net, <b>Destination</b> is the destination CIDR block. Example: 1.2.XX.XX/24.</description></item>
        /// <item><description>If <b>DestinationType</b> is set to group, <b>Destination</b> is the name of the destination address book. Example: db_group.</description></item>
        /// <item><description>If <b>DestinationType</b> is set to domain, <b>Destination</b> is the destination domain name. Example: *.aliyuncs.com.</description></item>
        /// <item><description>If <b>DestinationType</b> is set to location, <b>Destination</b> is the destination area (for the positional encoding of specific areas, see below). Example: [&quot;BJ11&quot;, &quot;ZB&quot;].</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX/24</para>
        /// </summary>
        [NameInMap("Destination")]
        [Validation(Required=false)]
        public string Destination { get; set; }

        /// <summary>
        /// <para>The type of the destination address in the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>net</b>: destination CIDR block</description></item>
        /// <item><description><b>group</b>: destination address book</description></item>
        /// <item><description><b>domain</b>: destination domain name</description></item>
        /// <item><description><b>location</b>: destination region</description></item>
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
        /// <item><description><b>in</b>: inbound traffic</description></item>
        /// <item><description><b>out</b>: outbound traffic</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>in</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The domain name resolution mode of the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>FQDN</b>: FQDN</description></item>
        /// <item><description><b>DNS</b>: DNS-based dynamic resolution</description></item>
        /// <item><description><b>FQDN_AND_DNS</b>: FQDN and DNS-based dynamic resolution</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FQDN</para>
        /// </summary>
        [NameInMap("DomainResolveType")]
        [Validation(Required=false)]
        public string DomainResolveType { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run.</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The end time of the Policy Validity Period for the access control policy. The value is expressed in the format of a UNIX timestamp in seconds. The time must be on the hour or half-hour, and must be at least 30 minutes later than the start time.</para>
        /// <remarks>
        /// <para>When RepeatType is Permanent, EndTime is empty. When RepeatType is None, Daily, Weekly, or Monthly, EndTime must have a value, and you need to configure the end time Settings.</para>
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
        /// <item><description><b>zh</b> (default): Chinese</description></item>
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
        /// <para>The protocol type of traffic in the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ANY</b></description></item>
        /// <item><description><b>TCP</b></description></item>
        /// <item><description><b>UDP</b></description></item>
        /// <item><description><b>ICMP</b></description></item>
        /// </list>
        /// <remarks>
        /// <para><b>ANY</b> indicates that the policy applies to all protocol types.</para>
        /// </remarks>
        /// <remarks>
        /// <para>If the traffic direction is outbound and the destination address is a threat intelligence address book or cloud service address book of the domain name type, you can set this parameter to TCP or ANY. If you select TCP, you can set the application to HTTP, HTTPS, SMTP, SMTPS, or SSL. If you select ANY, you can set the application to ANY.</para>
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
        /// <item><description>true: enabling status.</description></item>
        /// <item><description>false: shutdown.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Release")]
        [Validation(Required=false)]
        public string Release { get; set; }

        /// <summary>
        /// <para>The collection of recurrence days for the Policy Validity Period of the access control policy.</para>
        /// <list type="bullet">
        /// <item><description>If RepeatType is set to <c>Permanent</c>, <c>None</c>, or <c>Daily</c>, RepeatDays is an empty set. Example: [].</description></item>
        /// <item><description>If RepeatType is set to Weekly, RepeatDays cannot be empty. Example: [0, 6].<remarks>
        /// <para>When the RepeatType Settings is Weekly, the values in RepeatDays cannot be duplicate.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description>If RepeatType is set to <c>Monthly</c>, RepeatDays cannot be empty. Example: [1, 31].<remarks>
        /// <para>When the RepeatType Settings is Monthly, the values in RepeatDays cannot be duplicate.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("RepeatDays")]
        [Validation(Required=false)]
        public List<long?> RepeatDays { get; set; }

        /// <summary>
        /// <para>The recurrence end time when the policy takes effect. Use the 24-hour time format HH:mm, such as 23:00.</para>
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
        /// <para>The recurrence start time when the policy takes effect. Use the 24-hour time format HH:mm, such as 08:00.</para>
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
        /// <para>The recurrence type of the Policy Validity Period for the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Permanent</b> (default): always</description></item>
        /// <item><description><b>None</b>: single occurrence</description></item>
        /// <item><description><b>Daily</b>: daily</description></item>
        /// <item><description><b>Weekly</b>: weekly</description></item>
        /// <item><description><b>Monthly</b>: monthly</description></item>
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
        /// <list type="bullet">
        /// <item><description>If <b>SourceType</b> is set to net, <b>Source</b> is the source CIDR block. Example: 1.2.XX.XX/24.</description></item>
        /// <item><description>If <b>SourceType</b> is set to group, <b>Source</b> is the name of the source address book. Example: db_group.</description></item>
        /// <item><description>If <b>SourceType</b> is set to location, <b>Source</b> is the source area (for the positional encoding of specific areas, see below). Example: [&quot;BJ11&quot;, &quot;ZB&quot;].</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX/24</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The type of the source address in the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>net</b>: source CIDR block</description></item>
        /// <item><description><b>group</b>: source address book</description></item>
        /// <item><description><b>location</b>: source region</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>net</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The start time of the Policy Validity Period for the access control policy. The value is expressed in the format of a UNIX timestamp in seconds. The time must be on the hour or half-hour, and must be at least 30 minutes earlier than the end time.</para>
        /// <remarks>
        /// <para>When RepeatType is Permanent, StartTime is empty. When RepeatType is None, Daily, Weekly, or Monthly, StartTime must have a value, and you need to configure the start time Settings.</para>
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
