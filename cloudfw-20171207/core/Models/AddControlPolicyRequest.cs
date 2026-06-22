// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class AddControlPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The action that is set in the access control policy. Settings the method in which traffic passes through Cloud Firewall. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>accept</b>: allows the access.</description></item>
        /// <item><description><b>drop</b>: deny the access.</description></item>
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
        /// <item><description><b>ANY</b>: all application types</description></item>
        /// </list>
        /// <remarks>
        /// <para>The valid values of ApplicationName depend on the value of the protocol type (Proto). If Proto is set to TCP, ApplicationName can be set to any of the preceding application types. If Proto is set to UDP, ICMP, or ANY, ApplicationName can be set only to ANY. You must specify either ApplicationNameList or ApplicationName. You cannot leave both of them empty.</para>
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
        /// <para>The application types supported by the access control policy.</para>
        /// </summary>
        [NameInMap("ApplicationNameList")]
        [Validation(Required=false)]
        public List<string> ApplicationNameList { get; set; }

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
        /// <para>The destination port in the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the protocol type is ICMP, the value of DestPort is empty.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If the protocol type is ICMP, access control on the destination port is not supported.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If the protocol type is TCP, UDP, or ANY, and the destination port type (DestPortType) is group, the value of DestPort is empty.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If the destination port type of the access control policy is set to group (port address book), you do not need to specify a destination port number. All ports that the access control policy manages are included in the port address book.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If the protocol type is TCP, UDP, or ANY, and the destination port type (DestPortType) is port, the value of DestPort is the destination port number.</description></item>
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
        /// <para>If DestPortType is set to group, you must specify the destination port address book name.</para>
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
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If DestinationType is set to net, the value of Destination is a destination CIDR block.</para>
        /// <para>Example: 1.2.XX.XX/24</para>
        /// </description></item>
        /// <item><description><para>If DestinationType is set to group, the value of Destination is a destination address book name.</para>
        /// <para>Example: db_group</para>
        /// </description></item>
        /// <item><description><para>If DestinationType is set to domain, the value of Destination is a destination domain name.</para>
        /// <para>Example: *.aliyuncs.com</para>
        /// </description></item>
        /// <item><description><para>If DestinationType is set to location, the value of Destination is a destination region.</para>
        /// <para>Example: [&quot;BJ11&quot;, &quot;ZB&quot;\]</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If Destination is set to a destination region, for more information, see <a href="https://help.aliyun.com/document_detail/2854161.html">Region codes</a>.</para>
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
        /// <para>The type of the destination address in the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>net</b>: destination CIDR block</description></item>
        /// <item><description><b>group</b>: destination address book</description></item>
        /// <item><description><b>domain</b>: destination domain name</description></item>
        /// <item><description><b>location</b>: destination region.</description></item>
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
        /// <item><description><b>in</b>: inbound traffic</description></item>
        /// <item><description><b>out</b>: outbound traffic.</description></item>
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
        /// <para>The domain name resolution method of the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>FQDN</b>: FQDN-based resolution</description></item>
        /// <item><description><b>DNS</b>: DNS-based dynamic resolution</description></item>
        /// <item><description><b>FQDN_AND_DNS</b>: FQDN-based and DNS-based dynamic resolution.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FQDN</para>
        /// </summary>
        [NameInMap("DomainResolveType")]
        [Validation(Required=false)]
        public string DomainResolveType { get; set; }

        /// <summary>
        /// <para>The end time of the policy validity period for the access control policy. The value is a UNIX timestamp in seconds. The value must be on the hour or on the half hour, and at least 30 minutes later than the start time.</para>
        /// <remarks>
        /// <para>If RepeatType is set to Permanent, this parameter is left empty. If RepeatType is set to None, Daily, Weekly, or Monthly, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1694764800</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The IP address version supported.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>4</b>: IPv4</para>
        /// </description></item>
        /// <item><description><para><b>6</b>: IPv6.</para>
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
        /// <para>The priority of the access control policy. The priority value starts from 1. A smaller value indicates a higher priority.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NewOrder")]
        [Validation(Required=false)]
        public string NewOrder { get; set; }

        /// <summary>
        /// <para>The protocol type in the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ANY</b>: any protocol</description></item>
        /// <item><description><b>TCP</b></description></item>
        /// <item><description><b>UDP</b></description></item>
        /// <item><description><b>ICMP</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>If the traffic direction is outbound and the destination address is a threat intelligence address book or cloud service address book of the domain name type, only TCP is supported. The application type can be set to HTTP, HTTPS, SMTP, SMTPS, or SSL.</para>
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
        /// <para>Specifies whether to enable the access control policy. The policy is enabled by default after it is created. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enables the access control policy.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: disables the access control policy.</para>
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
        /// <para>The days of the recurrence for the policy validity period of the access control policy.</para>
        /// <list type="bullet">
        /// <item><description>If RepeatType is set to <c>Permanent</c>, <c>None</c>, or <c>Daily</c>, the value of RepeatDays is an empty array.
        /// Example: []</description></item>
        /// <item><description>If RepeatType is set to Weekly, the value of RepeatDays must not be empty.
        /// Example: [0, 6]<remarks>
        /// <para>If RepeatType is set to Weekly, the values in RepeatDays cannot be repeated.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description>If RepeatType is set to <c>Monthly</c>, the value of RepeatDays must not be empty.
        /// Example: [1, 31]<remarks>
        /// <para>If RepeatType is set to Monthly, the values in RepeatDays cannot be repeated.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("RepeatDays")]
        [Validation(Required=false)]
        public List<long?> RepeatDays { get; set; }

        /// <summary>
        /// <para>The recurrence end time of the policy validity period for the access control policy. Example: 23:30. The value must be on the hour or on the half hour, and at least 30 minutes later than the recurrence start time.</para>
        /// <remarks>
        /// <para>If RepeatType is set to Permanent or None, this parameter is left empty. If RepeatType is set to Daily, Weekly, or Monthly, this parameter is required.
        /// The time is in the HH:mm format (24-hour clock). Example: 08:00 or 23:30.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>23:30</para>
        /// </summary>
        [NameInMap("RepeatEndTime")]
        [Validation(Required=false)]
        public string RepeatEndTime { get; set; }

        /// <summary>
        /// <para>The recurrence start time of the policy validity period for the access control policy. Example: 08:00. The value must be on the hour or on the half hour, and at least 30 minutes earlier than the recurrence end time.</para>
        /// <remarks>
        /// <para>If RepeatType is set to Permanent or None, this parameter is left empty. If RepeatType is set to Daily, Weekly, or Monthly, this parameter is required.
        /// The time is in the HH:mm format (24-hour clock). Example: 08:00 or 23:30.</para>
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
        /// <item><description><b>Permanent</b> (default): The policy is always valid.</description></item>
        /// <item><description><b>None</b>: The policy is valid for a specified single time period.</description></item>
        /// <item><description><b>Daily</b>: The policy is valid on a daily basis.</description></item>
        /// <item><description><b>Weekly</b>: The policy is valid on a weekly basis.</description></item>
        /// <item><description><b>Monthly</b>: The policy is valid on a monthly basis.</description></item>
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
        /// <item><description><para>If SourceType is set to net, the value of Source is a source CIDR block.</para>
        /// <para>Example: 1.1.XX.XX/24</para>
        /// </description></item>
        /// <item><description><para>If SourceType is set to group, the value of Source is a source address book name.</para>
        /// <para>Example: db_group</para>
        /// </description></item>
        /// <item><description><para>If SourceType is set to location, the value of Source is a source region.</para>
        /// <para>Example: [&quot;BJ11&quot;, &quot;ZB&quot;\]</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If Source is set to a source region, for more information, see <a href="https://help.aliyun.com/document_detail/2854161.html">Region codes</a>.</para>
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
        /// <item><description><b>location</b>: source region.</description></item>
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
        /// <para>The start time of the policy validity period for the access control policy. The value is a UNIX timestamp in seconds. The value must be on the hour or on the half hour, and at least 30 minutes earlier than the end time.</para>
        /// <remarks>
        /// <para>If RepeatType is set to Permanent, this parameter is left empty. If RepeatType is set to None, Daily, Weekly, or Monthly, this parameter is required.</para>
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
