// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class AddControlPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The action that Cloud Firewall performs on traffic based on the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>accept</b>: allows the traffic.</description></item>
        /// <item><description><b>drop</b>: denies the traffic.</description></item>
        /// <item><description><b>log</b>: monitors the traffic.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>accept</para>
        /// </summary>
        [NameInMap("AclAction")]
        [Validation(Required=false)]
        public string AclAction { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The application type supported by the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>FTP</b></description></item>
        /// <item><description><b>HTTP</b></description></item>
        /// <item><description><b>HTTPS</b></description></item>
        /// <item><description><b>Memcache</b></description></item>
        /// <item><description><b>MongoDB</b></description></item>
        /// <item><description><b>MQTT</b></description></item>
        /// <item><description><b>MySQL</b></description></item>
        /// <item><description><b>RDP</b></description></item>
        /// <item><description><b>Redis</b></description></item>
        /// <item><description><b>SMTP</b></description></item>
        /// <item><description><b>SMTPS</b></description></item>
        /// <item><description><b>SSH</b></description></item>
        /// <item><description><b>SSL_No_Cert</b></description></item>
        /// <item><description><b>SSL</b></description></item>
        /// <item><description><b>VNC</b></description></item>
        /// <item><description><b>ANY</b> (all application types)</description></item>
        /// </list>
        /// <remarks>
        /// <para>The supported application types depend on the protocol type specified by the Proto parameter. If Proto is set to TCP, ApplicationName can be set to any of the preceding application types. If Proto is set to UDP, ICMP, or ANY, ApplicationName can only be set to ANY. You must specify either ApplicationNameList or ApplicationName. You cannot leave both parameters empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ANY</para>
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        [Obsolete]
        public string ApplicationName { get; set; }

        /// <summary>
        /// <para>The list of application types supported by the access control policy.</para>
        /// </summary>
        [NameInMap("ApplicationNameList")]
        [Validation(Required=false)]
        public List<string> ApplicationNameList { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddadxefexxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the access control policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Release flow</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The destination port for traffic in the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the protocol type is ICMP, leave DestPort empty.<remarks>
        /// <para>If the protocol type is ICMP, access control on destination ports is not supported.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description>If the protocol type is TCP, UDP, or ANY, and the destination port type (DestPortType) is group, leave DestPort empty.<remarks>
        /// <para>If you set the destination port type to group (destination port address book), you do not need to specify a destination port number. All ports managed by the access control policy are included in the destination port address book.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description>If the protocol type is TCP, UDP, or ANY, and the destination port type (DestPortType) is port, set DestPort to the destination port number.</description></item>
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
        /// <para>The type of the destination port in the access control policy.</para>
        /// <para>Valid values:</para>
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
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If DestinationType is set to net, Destination specifies the destination CIDR block.</para>
        /// <para>Example: 1.2.XX.XX/24</para>
        /// </description></item>
        /// <item><description><para>If DestinationType is set to group, Destination specifies the name of the destination address book.</para>
        /// <para>Example: db_group</para>
        /// </description></item>
        /// <item><description><para>If DestinationType is set to domain, Destination specifies the destination domain name.</para>
        /// <para>Example: *.aliyuncs.com</para>
        /// </description></item>
        /// <item><description><para>If DestinationType is set to location, Destination specifies the destination location.</para>
        /// <para>Example: [&quot;BJ11&quot;, &quot;ZB&quot;]</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If Destination specifies a destination location, for more information, see <a href="https://help.aliyun.com/document_detail/2854161.html">Location codes</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX/24</para>
        /// </summary>
        [NameInMap("Destination")]
        [Validation(Required=false)]
        public string Destination { get; set; }

        /// <summary>
        /// <para>The destination address type in the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>net</b>: destination CIDR block</description></item>
        /// <item><description><b>group</b>: destination address book</description></item>
        /// <item><description><b>domain</b>: destination domain name</description></item>
        /// <item><description><b>location</b>: destination region</description></item>
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
        /// <item><description><b>in</b>: Inbound traffic.</description></item>
        /// <item><description><b>out</b>: Outbound traffic.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
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
        /// <item><description><b>FQDN</b>: FQDN-based resolution</description></item>
        /// <item><description><b>DNS</b>: DNS-based dynamic resolution</description></item>
        /// <item><description><b>FQDN_AND_DNS</b>: FQDN- and DNS-based dynamic resolution</description></item>
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
        /// <para>The end time of the Policy Validity Period for the access control policy. The time is expressed in the UNIX timestamp in seconds format. The time must be on the hour or half hour, and must be at least 30 minutes later than the start time.</para>
        /// <remarks>
        /// <para>When RepeatType is set to <c>Permanent</c>, EndTime is empty. When RepeatType is set to <c>None</c>, <c>Daily</c>, <c>Weekly</c>, or <c>Monthly</c>, EndTime is required, and you must specify the end time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1694764800</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The IP address version.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>4</b>: IPv4</para>
        /// </description></item>
        /// <item><description><para><b>6</b>: IPv6</para>
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
        /// <para>The protocol type of traffic in the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ANY</b>: all protocols</description></item>
        /// <item><description><b>TCP</b></description></item>
        /// <item><description><b>UDP</b></description></item>
        /// <item><description><b>ICMP</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>If the traffic direction is outbound and the destination address is a domain name in a threat intelligence address book or a cloud service address book, you can only set Proto to TCP. In this case, you can set the application type to HTTP, HTTPS, SMTP, SMTPS, or SSL.</para>
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
        /// <item><description><para><b>true</b>: enables the access control policy.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: does not enable the access control policy.</para>
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
        /// <para>The set of repeat days for the Policy Validity Period of the access control policy.</para>
        /// <list type="bullet">
        /// <item><description>When RepeatType is set to <c>Permanent</c>, <c>None</c>, or <c>Daily</c>, RepeatDays is an empty set. Example: []</description></item>
        /// <item><description>When RepeatType is set to <c>Weekly</c>, RepeatDays cannot be empty. Example: [0, 6]<remarks>
        /// <para>When RepeatType is set to Weekly, the values in RepeatDays must be unique.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description>When RepeatType is set to <c>Monthly</c>, RepeatDays cannot be empty. Example: [1, 31]<remarks>
        /// <para>When RepeatType is set to Monthly, the values in RepeatDays must be unique.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("RepeatDays")]
        [Validation(Required=false)]
        public List<long?> RepeatDays { get; set; }

        /// <summary>
        /// <para>The repeat end time for the Policy Validity Period of the access control policy. Example: 23:30. The time must be on the hour or half hour, and must be at least 30 minutes later than the repeat start time.</para>
        /// <remarks>
        /// <para>When RepeatType is set to <c>Permanent</c> or <c>None</c>, RepeatEndTime is empty. When RepeatType is set to <c>Daily</c>, <c>Weekly</c>, or <c>Monthly</c>, RepeatEndTime is required, and you must specify the repeat end time.
        /// The time format is HH:mm (24-hour clock). Examples: 08:00 and 23:30.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>23:30</para>
        /// </summary>
        [NameInMap("RepeatEndTime")]
        [Validation(Required=false)]
        public string RepeatEndTime { get; set; }

        /// <summary>
        /// <para>The repeat start time for the Policy Validity Period of the access control policy. Example: 08:00. The time must be on the hour or half hour, and must be at least 30 minutes earlier than the repeat end time.</para>
        /// <remarks>
        /// <para>When RepeatType is set to <c>Permanent</c> or <c>None</c>, RepeatStartTime is empty. When RepeatType is set to <c>Daily</c>, <c>Weekly</c>, or <c>Monthly</c>, RepeatStartTime is required, and you must specify the repeat start time.
        /// The time format is HH:mm (24-hour clock). Examples: 08:00 and 23:30.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>08:00</para>
        /// </summary>
        [NameInMap("RepeatStartTime")]
        [Validation(Required=false)]
        public string RepeatStartTime { get; set; }

        /// <summary>
        /// <para>The repeat type of the Policy Validity Period for the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Permanent</b> (default): always</description></item>
        /// <item><description><b>None</b>: a single specified time</description></item>
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
        /// <para>The source address in the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If SourceType is set to net, set Source to the source CIDR block.</para>
        /// <para>Example: 1.1.XX.XX/24</para>
        /// </description></item>
        /// <item><description><para>If SourceType is set to group, set Source to the name of the source address book.</para>
        /// <para>Example: db_group</para>
        /// </description></item>
        /// <item><description><para>If SourceType is set to location, set Source to the source region.</para>
        /// <para>Example: [&quot;BJ11&quot;, &quot;ZB&quot;]</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>For more information about source regions, see <a href="https://help.aliyun.com/document_detail/2854161.html">Region codes</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX/24</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        [Obsolete]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The type of the source address in the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>net</b>: source CIDR block</description></item>
        /// <item><description><b>group</b>: source address book</description></item>
        /// <item><description><b>location</b>: source location</description></item>
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
        /// <para>The start time of the Policy Validity Period for the access control policy. The time is expressed in the UNIX timestamp in seconds format. The time must be on the hour or half hour, and must be at least 30 minutes earlier than the end time.</para>
        /// <remarks>
        /// <para>When RepeatType is set to <c>Permanent</c>, StartTime is empty. When RepeatType is set to <c>None</c>, <c>Daily</c>, <c>Weekly</c>, or <c>Monthly</c>, StartTime is required, and you must specify the start time.</para>
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
