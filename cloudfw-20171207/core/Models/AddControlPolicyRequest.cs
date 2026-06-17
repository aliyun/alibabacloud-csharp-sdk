// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class AddControlPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The action to perform on traffic that matches the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>accept</b>: allows the traffic.</para>
        /// </description></item>
        /// <item><description><para><b>drop</b>: denies the traffic.</para>
        /// </description></item>
        /// <item><description><para><b>log</b>: monitors the traffic.</para>
        /// </description></item>
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
        /// <para>The application type that the access control policy supports. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>FTP</b></para>
        /// </description></item>
        /// <item><description><para><b>HTTP</b></para>
        /// </description></item>
        /// <item><description><para><b>HTTPS</b></para>
        /// </description></item>
        /// <item><description><para><b>Memcache</b></para>
        /// </description></item>
        /// <item><description><para><b>MongoDB</b></para>
        /// </description></item>
        /// <item><description><para><b>MQTT</b></para>
        /// </description></item>
        /// <item><description><para><b>MySQL</b></para>
        /// </description></item>
        /// <item><description><para><b>RDP</b></para>
        /// </description></item>
        /// <item><description><para><b>Redis</b></para>
        /// </description></item>
        /// <item><description><para><b>SMTP</b></para>
        /// </description></item>
        /// <item><description><para><b>SMTPS</b></para>
        /// </description></item>
        /// <item><description><para><b>SSH</b></para>
        /// </description></item>
        /// <item><description><para><b>SSL_No_Cert</b></para>
        /// </description></item>
        /// <item><description><para><b>SSL</b></para>
        /// </description></item>
        /// <item><description><para><b>VNC</b></para>
        /// </description></item>
        /// <item><description><para><b>ANY</b> (all application types)</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The available application types depend on the protocol type (\<c>Proto\\</c>). If you set \<c>Proto\\</c> to \<c>TCP\\</c>, you can set \<c>ApplicationName\\</c> to any of the listed application types. If you set \<c>Proto\\</c> to \<c>UDP\\</c>, \<c>ICMP\\</c>, or \<c>ANY\\</c>, you can set \<c>ApplicationName\\</c> only to \<c>ANY\\</c>. Specify either \<c>ApplicationNameList\\</c> or \<c>ApplicationName\\</c>.</para>
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
        /// <para>The application types that the access control policy supports.</para>
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
        /// <item><description>If \<c>Proto\\</c> is \<c>ICMP\\</c>, leave this parameter empty.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If the protocol type is ICMP, you cannot control access based on the destination port.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If \<c>Proto\\</c> is \<c>TCP\\</c>, \<c>UDP\\</c>, or \<c>ANY\\</c>, and \<c>DestPortType\\</c> is \<c>group\\</c>, leave this parameter empty.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you set \<c>DestPortType\\</c> to \<c>group\\</c> (port address book), you do not need to specify a destination port number. The port address book contains all the destination ports that the policy manages.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If \<c>Proto\\</c> is \<c>TCP\\</c>, \<c>UDP\\</c>, or \<c>ANY\\</c>, and \<c>DestPortType\\</c> is \<c>port\\</c>, set this parameter to the destination port number.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("DestPort")]
        [Validation(Required=false)]
        public string DestPort { get; set; }

        /// <summary>
        /// <para>The name of the destination port address book for the traffic in the access control policy.</para>
        /// <remarks>
        /// <para>If you set \<c>DestPortType\\</c> to \<c>group\\</c>, you must specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>my_port_group</para>
        /// </summary>
        [NameInMap("DestPortGroup")]
        [Validation(Required=false)]
        public string DestPortGroup { get; set; }

        /// <summary>
        /// <para>The type of the destination port for the traffic in the access control policy.</para>
        /// <para>Valid values:</para>
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
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If \<c>DestinationType\\</c> is \<c>net\\</c>, set this parameter to the destination CIDR block.</para>
        /// <para>Example: 1.2.XX.XX/24</para>
        /// </description></item>
        /// <item><description><para>If \<c>DestinationType\\</c> is \<c>group\\</c>, set this parameter to the name of the destination address book.</para>
        /// <para>Example: db_group</para>
        /// </description></item>
        /// <item><description><para>If \<c>DestinationType\\</c> is \<c>domain\\</c>, set this parameter to the destination domain name.</para>
        /// <para>Example: \*.aliyuncs.com</para>
        /// </description></item>
        /// <item><description><para>If \<c>DestinationType\\</c> is \<c>location\\</c>, set this parameter to the destination region.</para>
        /// <para>Example: [&quot;BJ11&quot;, &quot;ZB&quot;]</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>For more information about region codes, see <a href="https://help.aliyun.com/document_detail/2854161.html">Region codes</a>.</para>
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
        /// <item><description><para><b>net</b>: destination CIDR block</para>
        /// </description></item>
        /// <item><description><para><b>group</b>: destination address book</para>
        /// </description></item>
        /// <item><description><para><b>domain</b>: destination domain name</para>
        /// </description></item>
        /// <item><description><para><b>location</b>: destination region</para>
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
        /// <para>The direction of the traffic to which the access control policy applies. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>in</b>: inbound traffic</para>
        /// </description></item>
        /// <item><description><para><b>out</b>: outbound traffic</para>
        /// </description></item>
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
        /// <para>The domain name resolution method for the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>FQDN</b>: based on FQDN</para>
        /// </description></item>
        /// <item><description><para><b>DNS</b>: based on dynamic DNS resolution</para>
        /// </description></item>
        /// <item><description><para><b>FQDN_AND_DNS</b>: based on FQDN and dynamic DNS resolution</para>
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
        /// <para>The time when the policy becomes ineffective. This is a UNIX timestamp. The time must be on the hour or half-hour, and at least 30 minutes after the start time.</para>
        /// <remarks>
        /// <para>If \<c>RepeatType\\</c> is \<c>Permanent\\</c>, leave this parameter empty. This parameter is required if \<c>RepeatType\\</c> is \<c>None\\</c>, \<c>Daily\\</c>, \<c>Weekly\\</c>, or \<c>Monthly\\</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1694764800</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The IP version supported.</para>
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
        /// <para>The priority of the access control policy. The priority starts from 1. A smaller value indicates a higher priority.</para>
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
        /// <item><description><para><b>ANY</b> (any protocol)</para>
        /// </description></item>
        /// <item><description><para><b>TCP</b></para>
        /// </description></item>
        /// <item><description><para><b>UDP</b></para>
        /// </description></item>
        /// <item><description><para><b>ICMP</b></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If the traffic direction is \<c>out\\</c> and the destination is a domain-based threat intelligence or cloud service address book, you can set the protocol only to \<c>TCP\\</c>. The supported applications are HTTP, HTTPS, SMTP, SMTPS, and SSL.</para>
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
        /// <para>The status of the access control policy. By default, the policy is enabled after it is created. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enables the access control policy</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: disables the access control policy</para>
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
        /// <para>The days of the week or month when the policy is active.</para>
        /// <list type="bullet">
        /// <item><description><para>If \<c>RepeatType\\</c> is \<c>Permanent\\</c>, \<c>None\\</c>, or \<c>Daily\\</c>, leave this parameter empty.
        /// Example: []</para>
        /// </description></item>
        /// <item><description><para>This parameter is required if \<c>RepeatType\\</c> is \<c>Weekly\\</c>.
        /// Example: [0, 6]</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you set \<c>RepeatType\\</c> to \<c>Weekly\\</c>, the values in \<c>RepeatDays\\</c> cannot be duplicates.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is required if \<c>RepeatType\\</c> is \<c>Monthly\\</c>.
        /// Example: [1, 31]</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you set \<c>RepeatType\\</c> to \<c>Monthly\\</c>, the values in \<c>RepeatDays\\</c> cannot be duplicates.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("RepeatDays")]
        [Validation(Required=false)]
        public List<long?> RepeatDays { get; set; }

        /// <summary>
        /// <para>The end time of the recurrence. Example: 23:30. The time must be on the hour or half-hour, and at least 30 minutes after the start time.</para>
        /// <remarks>
        /// <para>If \<c>RepeatType\\</c> is \<c>Permanent\\</c> or \<c>None\\</c>, leave this parameter empty. This parameter is required if \<c>RepeatType\\</c> is \<c>Daily\\</c>, \<c>Weekly\\</c>, or \<c>Monthly\\</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>23:30</para>
        /// </summary>
        [NameInMap("RepeatEndTime")]
        [Validation(Required=false)]
        public string RepeatEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the recurrence. Example: 08:00. The time must be on the hour or half-hour, and at least 30 minutes before the end time.</para>
        /// <remarks>
        /// <para>If \<c>RepeatType\\</c> is \<c>Permanent\\</c> or \<c>None\\</c>, leave this parameter empty. This parameter is required if \<c>RepeatType\\</c> is \<c>Daily\\</c>, \<c>Weekly\\</c>, or \<c>Monthly\\</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>08:00</para>
        /// </summary>
        [NameInMap("RepeatStartTime")]
        [Validation(Required=false)]
        public string RepeatStartTime { get; set; }

        /// <summary>
        /// <para>The recurrence type for the policy\&quot;s effective period. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Permanent</b> (default): always</para>
        /// </description></item>
        /// <item><description><para><b>None</b>: one-time</para>
        /// </description></item>
        /// <item><description><para><b>Daily</b>: daily</para>
        /// </description></item>
        /// <item><description><para><b>Weekly</b>: weekly</para>
        /// </description></item>
        /// <item><description><para><b>Monthly</b>: monthly</para>
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
        /// <item><description><para>If \<c>SourceType\\</c> is \<c>net\\</c>, set this parameter to the source CIDR block.</para>
        /// <para>Example: 1.1.XX.XX/24</para>
        /// </description></item>
        /// <item><description><para>If \<c>SourceType\\</c> is \<c>group\\</c>, set this parameter to the name of the source address book.</para>
        /// <para>Example: db_group</para>
        /// </description></item>
        /// <item><description><para>If \<c>SourceType\\</c> is \<c>location\\</c>, set this parameter to the source region.</para>
        /// <para>Example: [&quot;BJ11&quot;, &quot;ZB&quot;]</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>For more information about region codes, see <a href="https://help.aliyun.com/document_detail/2854161.html">Region codes</a>.</para>
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
        /// <para>The source IP address of the traffic.</para>
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
        /// <item><description><para><b>net</b>: source CIDR block</para>
        /// </description></item>
        /// <item><description><para><b>group</b>: source address book</para>
        /// </description></item>
        /// <item><description><para><b>location</b>: source region</para>
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
        /// <para>The time when the policy becomes effective. This is a UNIX timestamp. The time must be on the hour or half-hour, and at least 30 minutes before the end time.</para>
        /// <remarks>
        /// <para>If \<c>RepeatType\\</c> is \<c>Permanent\\</c>, leave this parameter empty. This parameter is required if \<c>RepeatType\\</c> is \<c>None\\</c>, \<c>Daily\\</c>, \<c>Weekly\\</c>, or \<c>Monthly\\</c>.</para>
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
