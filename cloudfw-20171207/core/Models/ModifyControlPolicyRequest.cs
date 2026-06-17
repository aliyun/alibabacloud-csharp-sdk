// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyControlPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The action that Cloud Firewall performs on the traffic. Valid values:</para>
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
        /// <para>accept</para>
        /// </summary>
        [NameInMap("AclAction")]
        [Validation(Required=false)]
        public string AclAction { get; set; }

        /// <summary>
        /// <para>The unique ID of the access control policy.</para>
        /// <remarks>
        /// <para>To modify an access control policy, provide the unique ID of the policy. Call the <a href="https://help.aliyun.com/document_detail/138866.html">DescribeControlPolicy</a> operation to obtain the ID.</para>
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
        /// <para>The application type supported by the access control policy. The following application types are supported:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ANY</b></para>
        /// </description></item>
        /// <item><description><para><b>HTTP</b></para>
        /// </description></item>
        /// <item><description><para><b>HTTPS</b></para>
        /// </description></item>
        /// <item><description><para><b>MySQL</b></para>
        /// </description></item>
        /// <item><description><para><b>SMTP</b></para>
        /// </description></item>
        /// <item><description><para><b>SMTPS</b></para>
        /// </description></item>
        /// <item><description><para><b>RDP</b></para>
        /// </description></item>
        /// <item><description><para><b>VNC</b></para>
        /// </description></item>
        /// <item><description><para><b>SSH</b></para>
        /// </description></item>
        /// <item><description><para><b>Redis</b></para>
        /// </description></item>
        /// <item><description><para><b>MQTT</b></para>
        /// </description></item>
        /// <item><description><para><b>MongoDB</b></para>
        /// </description></item>
        /// <item><description><para><b>Memcache</b></para>
        /// </description></item>
        /// <item><description><para><b>SSL</b></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para><b>ANY</b> indicates that the policy applies to all application types.</para>
        /// </remarks>
        /// <remarks>
        /// <para>Specify either ApplicationNameList or ApplicationName. You cannot leave both empty. If you specify both, ApplicationNameList takes precedence.</para>
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
        /// <para>Specify either ApplicationNameList or ApplicationName. You cannot leave both empty. If you specify both, ApplicationNameList takes precedence.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ApplicationNameList")]
        [Validation(Required=false)]
        public List<string> ApplicationNameList { get; set; }

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
        /// <para>The destination port in the access control policy.</para>
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
        /// <para>my_port_group</para>
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
        /// <item><description><para>If <b>DestinationType</b> is set to net, set <b>Destination</b> to a destination CIDR block. Example: 1.2.XX.XX/24</para>
        /// </description></item>
        /// <item><description><para>If <b>DestinationType</b> is set to group, set <b>Destination</b> to the name of a destination address book. Example: db_group</para>
        /// </description></item>
        /// <item><description><para>If <b>DestinationType</b> is set to domain, set <b>Destination</b> to a destination domain name. Example: \*.aliyuncs.com</para>
        /// </description></item>
        /// <item><description><para>If <b>DestinationType</b> is set to location, set <b>Destination</b> to a destination location code. Example: [&quot;BJ11&quot;, &quot;ZB&quot;]</para>
        /// </description></item>
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
        /// <item><description><para><b>net</b>: destination CIDR block</para>
        /// </description></item>
        /// <item><description><para><b>group</b>: destination address book</para>
        /// </description></item>
        /// <item><description><para><b>domain</b>: destination domain name</para>
        /// </description></item>
        /// <item><description><para><b>location</b>: destination region</para>
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
        /// <item><description><para><b>in</b>: inbound traffic</para>
        /// </description></item>
        /// <item><description><para><b>out</b>: outbound traffic</para>
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
        /// <para>The domain name resolution method for the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>FQDN</b>: FQDN-based resolution</para>
        /// </description></item>
        /// <item><description><para><b>DNS</b>: DNS-based dynamic resolution</para>
        /// </description></item>
        /// <item><description><para><b>FQDN_AND_DNS</b>: FQDN-based and DNS-based dynamic resolution</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FQDN</para>
        /// </summary>
        [NameInMap("DomainResolveType")]
        [Validation(Required=false)]
        public string DomainResolveType { get; set; }

        /// <summary>
        /// <para>The end time of the policy validity period. The value is a UNIX timestamp. The time must be on the hour or half hour, and at least 30 minutes later than the start time.</para>
        /// <remarks>
        /// <para>If RepeatType is set to Permanent, leave this parameter empty. If RepeatType is set to None, Daily, Weekly, or Monthly, you must specify this parameter.</para>
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
        /// <para>The protocol type of the traffic in the access control policy. Valid values:</para>
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
        /// <para>If the traffic direction is outbound and the destination is a domain name that belongs to a threat intelligence address book or a cloud service address book, you can set this parameter to TCP or ANY. If you set this parameter to TCP, you can set the application to HTTP, HTTPS, SMTP, SMTPS, or SSL. If you set this parameter to ANY, you must set the application to ANY.</para>
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
        /// <item><description><para>true: The policy is enabled.</para>
        /// </description></item>
        /// <item><description><para>false: The policy is disabled.</para>
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
        /// <para>The days of the week or month on which the policy is recurrent.</para>
        /// <list type="bullet">
        /// <item><description><para>If RepeatType is set to <c>Permanent</c>, <c>None</c>, or <c>Daily</c>, leave this parameter empty.
        /// Example: []</para>
        /// </description></item>
        /// <item><description><para>If RepeatType is set to Weekly, you must specify this parameter.
        /// Example: [0, 6]</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If RepeatType is set to Weekly, the values in the array cannot be repeated.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If RepeatType is set to <c>Monthly</c>, you must specify this parameter.
        /// Example: [1, 31]</description></item>
        /// </list>
        /// <remarks>
        /// <para>If RepeatType is set to Monthly, the values in the array cannot be repeated.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("RepeatDays")]
        [Validation(Required=false)]
        public List<long?> RepeatDays { get; set; }

        /// <summary>
        /// <para>The end time of the recurrence. The time is in the HH:mm format and in 24-hour format. Example: 23:00.</para>
        /// <remarks>
        /// <para>If RepeatType is set to Permanent or None, leave this parameter empty. If RepeatType is set to Daily, Weekly, or Monthly, you must specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>23:30</para>
        /// </summary>
        [NameInMap("RepeatEndTime")]
        [Validation(Required=false)]
        public string RepeatEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the recurrence. The time is in the HH:mm format and in 24-hour format. Example: 08:00.</para>
        /// <remarks>
        /// <para>If RepeatType is set to Permanent or None, leave this parameter empty. If RepeatType is set to Daily, Weekly, or Monthly, you must specify this parameter.</para>
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
        /// <item><description><para><b>Permanent</b> (default): The policy is always valid.</para>
        /// </description></item>
        /// <item><description><para><b>None</b>: The policy is valid only once.</para>
        /// </description></item>
        /// <item><description><para><b>Daily</b>: The policy is valid daily.</para>
        /// </description></item>
        /// <item><description><para><b>Weekly</b>: The policy is valid weekly.</para>
        /// </description></item>
        /// <item><description><para><b>Monthly</b>: The policy is valid monthly.</para>
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
        /// <list type="bullet">
        /// <item><description><para>If <b>SourceType</b> is set to net, set <b>Source</b> to a source CIDR block. Example: 1.2.XX.XX/24</para>
        /// </description></item>
        /// <item><description><para>If <b>SourceType</b> is set to group, set <b>Source</b> to the name of a source address book. Example: db_group</para>
        /// </description></item>
        /// <item><description><para>If <b>SourceType</b> is set to location, set <b>Source</b> to a source location code. Example: [&quot;BJ11&quot;, &quot;ZB&quot;]</para>
        /// </description></item>
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
        /// <item><description><para><b>net</b>: source CIDR block</para>
        /// </description></item>
        /// <item><description><para><b>group</b>: source address book</para>
        /// </description></item>
        /// <item><description><para><b>location</b>: source region</para>
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
        /// <para>The start time of the policy validity period. The value is a UNIX timestamp. The time must be on the hour or half hour, and at least 30 minutes earlier than the end time.</para>
        /// <remarks>
        /// <para>If RepeatType is set to Permanent, leave this parameter empty. If RepeatType is set to None, Daily, Weekly, or Monthly, you must specify this parameter.</para>
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
