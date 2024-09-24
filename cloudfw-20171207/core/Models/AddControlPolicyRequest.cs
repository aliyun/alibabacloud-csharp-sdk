// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class AddControlPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The action that Cloud Firewall performs on the traffic. Valid values:</para>
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
        /// <item><description><b>ANY</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>The value of this parameter is based on the value of Proto. If Proto is set to TCP, you can set ApplicationName to any valid value. If Proto is set to UDP, ICMP, or ANY, you can set ApplicationName only to ANY. You must specify at least one of the ApplicationNameList and ApplicationName parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ANY</para>
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
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
        /// <para>Allows traffic</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The destination port in the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If Proto is set to ICMP, DestPort is automatically left empty.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If Proto is set to ICMP, access control does not take effect on the destination port.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If Proto is set to TCP, UDP, or ANY and DestPortType is set to group, DestPort is empty.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If DestPortType is set to group, you do not need to specify the destination port number. All ports on which the access control policy takes effect are included in the destination port address book.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If Proto is set to TCP, UDP, or ANY and DestPortType is set to port, the value of DestPort is the destination port number.</description></item>
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
        /// <item><description><para>If DestinationType is set to net, the value of this parameter is a CIDR block.</para>
        /// <para>Example: 1.2.XX.XX/24</para>
        /// </description></item>
        /// <item><description><para>If DestinationType is set to group, the value of this parameter is an address book name.</para>
        /// <para>Example: db_group</para>
        /// </description></item>
        /// <item><description><para>If DestinationType is set to domain, the value of this parameter is a domain name.</para>
        /// <para>Example: \*.aliyuncs.com</para>
        /// </description></item>
        /// <item><description><para>If DestinationType is set to location, the value of this parameter is a location.</para>
        /// <para>Example: [&quot;BJ11&quot;, &quot;ZB&quot;]</para>
        /// </description></item>
        /// </list>
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
        /// <item><description><b>net</b>: CIDR block</description></item>
        /// <item><description><b>group</b>: address book</description></item>
        /// <item><description><b>domain</b>: domain name</description></item>
        /// <item><description><b>location</b>: location</description></item>
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
        /// <para>The direction of the traffic to which the access control policy applies. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>in</b>: inbound traffic</description></item>
        /// <item><description><b>out</b>: outbound traffic</description></item>
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
        /// <item><description><b>FQDN</b>: fully qualified domain name (FQDN)-based resolution</description></item>
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
        /// <para>The time when the access control policy stops taking effect. The value is a UNIX timestamp. Unit: seconds. The value must be on the hour or on the half hour, and at least 30 minutes later than the start time.</para>
        /// <remarks>
        /// <para> If you set RepeatType to Permanent, leave this parameter empty. If you set RepeatType to None, Daily, Weekly, or Monthly, you must specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1694764800</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The IP version supported by the access control policy.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>4</b>: IPv4</description></item>
        /// <item><description><b>6</b>: IPv6</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Valid values:</para>
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
        /// <para>The priority of the access control policy. The priority value starts from 1. A smaller priority value indicates a higher priority.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NewOrder")]
        [Validation(Required=false)]
        public string NewOrder { get; set; }

        /// <summary>
        /// <para>The protocol type supported by the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ANY</b></description></item>
        /// <item><description><b>TCP</b></description></item>
        /// <item><description><b>UDP</b></description></item>
        /// <item><description><b>ICMP</b></description></item>
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
        /// <para>Specifies whether to enable the access control policy. By default, an access control policy is enabled after the policy is created. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables the access control policy.</description></item>
        /// <item><description><b>false</b>: disables the access control policy.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Release")]
        [Validation(Required=false)]
        public string Release { get; set; }

        /// <summary>
        /// <para>The days of a week or of a month on which the access control policy takes effect.</para>
        /// <list type="bullet">
        /// <item><description>If you set RepeatType to <c>Permanent</c>, <c>None</c>, or <c>Daily</c>, leave this parameter empty. Example: [].</description></item>
        /// <item><description>If you set RepeatType to Weekly, you must specify this parameter. Example: [0, 6].</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you set RepeatType to Weekly, the fields in the value of this parameter cannot be repeated.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If you set RepeatType to <c>Monthly</c>, you must specify this parameter. Example: [1, 31].</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you set RepeatType to Monthly, the fields in the value of this parameter cannot be repeated.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("RepeatDays")]
        [Validation(Required=false)]
        public List<long?> RepeatDays { get; set; }

        /// <summary>
        /// <para>The point in time when the recurrence ends. Example: 23:30. The end time must be on the hour or on the half hour, and at least 30 minutes later than the start time.</para>
        /// <remarks>
        /// <para> If you set RepeatType to Permanent or None, leave this parameter empty. If you set RepeatType to Daily, Weekly, or Monthly, you must specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>23:30</para>
        /// </summary>
        [NameInMap("RepeatEndTime")]
        [Validation(Required=false)]
        public string RepeatEndTime { get; set; }

        /// <summary>
        /// <para>The point in time when the recurrence starts. Example: 08:00. The start time must be on the hour or on the half hour, and at least 30 minutes earlier than the end time.</para>
        /// <remarks>
        /// <para> If you set RepeatType to Permanent or None, leave this parameter empty. If you set RepeatType to Daily, Weekly, or Monthly, you must specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>08:00</para>
        /// </summary>
        [NameInMap("RepeatStartTime")]
        [Validation(Required=false)]
        public string RepeatStartTime { get; set; }

        /// <summary>
        /// <para>The recurrence type for the access control policy to take effect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Permanent</b> (default): The policy always takes effect.</description></item>
        /// <item><description><b>None</b>: The policy takes effect for only once.</description></item>
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
        /// <para>The source address in the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If SourceType is set to net, the value of this parameter is a CIDR block.</para>
        /// <para>Example: 1.1.XX.XX/24</para>
        /// </description></item>
        /// <item><description><para>If SourceType is set to group, the value of this parameter is an address book name.</para>
        /// <para>Example: db_group</para>
        /// </description></item>
        /// <item><description><para>If SourceType is set to location, the value of this parameter is a location.</para>
        /// <para>Example: [&quot;BJ11&quot;, &quot;ZB&quot;]</para>
        /// </description></item>
        /// </list>
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
        /// <item><description><b>net</b>: CIDR block</description></item>
        /// <item><description><b>group</b>: address book</description></item>
        /// <item><description><b>location</b>: location</description></item>
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
        /// <para>The time when the access control policy starts to take effect. The value is a UNIX timestamp. Unit: seconds. The value must be on the hour or on the half hour, and at least 30 minutes earlier than the end time.</para>
        /// <remarks>
        /// <para> If you set RepeatType to Permanent, leave this parameter empty. If you set RepeatType to None, Daily, Weekly, or Monthly, you must specify this parameter.</para>
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
