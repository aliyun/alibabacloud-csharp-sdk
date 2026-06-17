// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeControlPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public string PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The information about the access control policies.</para>
        /// </summary>
        [NameInMap("Policys")]
        [Validation(Required=false)]
        public List<DescribeControlPolicyResponseBodyPolicys> Policys { get; set; }
        public class DescribeControlPolicyResponseBodyPolicys : TeaModel {
            /// <summary>
            /// <para>The action that Cloud Firewall performs on the traffic. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>accept</b>: Allow</para>
            /// </description></item>
            /// <item><description><para><b>drop</b>: Deny</para>
            /// </description></item>
            /// <item><description><para><b>log</b>: Monitor</para>
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
            /// 
            /// <b>Example:</b>
            /// <para>00281255-d220-4db1-8f4f-c4df221a****</para>
            /// </summary>
            [NameInMap("AclUuid")]
            [Validation(Required=false)]
            public string AclUuid { get; set; }

            /// <summary>
            /// <para>The application ID for the traffic in the access control policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10***</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// <para>The application type supported by the access control policy. Use \<c>ApplicationNameList\\</c> instead. Valid values:</para>
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
            /// <item><description><para><b>SSL</b></para>
            /// </description></item>
            /// <item><description><para><b>VNC</b></para>
            /// </description></item>
            /// <item><description><para><b>ANY</b> (all application types)</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("ApplicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }

            /// <summary>
            /// <para>The list of application names.</para>
            /// </summary>
            [NameInMap("ApplicationNameList")]
            [Validation(Required=false)]
            public List<string> ApplicationNameList { get; set; }

            /// <summary>
            /// <para>The time when the policy was created. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1761062400</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

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
            /// <para>The destination port for the traffic in the access control policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("DestPort")]
            [Validation(Required=false)]
            public string DestPort { get; set; }

            /// <summary>
            /// <para>The name of the destination port address book for the traffic in the access control policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my_port_group</para>
            /// </summary>
            [NameInMap("DestPortGroup")]
            [Validation(Required=false)]
            public string DestPortGroup { get; set; }

            /// <summary>
            /// <para>The list of ports in the destination port address book.</para>
            /// </summary>
            [NameInMap("DestPortGroupPorts")]
            [Validation(Required=false)]
            public List<string> DestPortGroupPorts { get; set; }

            /// <summary>
            /// <para>The destination port type for the traffic in the access control policy. Valid values:</para>
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
            /// <para>The destination address in the access control policy. The value of this parameter varies based on the value of the \<c>DestinationType\\</c> parameter. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>If <b>DestinationType</b> is <b>net</b>, the destination address is a CIDR block. Example: 192.0.XX.XX/24.</para>
            /// </description></item>
            /// <item><description><para>If <b>DestinationType</b> is <b>domain</b>, the destination address is a domain name. Example: aliyuncs.com.</para>
            /// </description></item>
            /// <item><description><para>If <b>DestinationType</b> is <b>group</b>, the destination address is the name of an address book. Example: db_group.</para>
            /// </description></item>
            /// <item><description><para>If <b>DestinationType</b> is <b>location</b>, the destination address is a region name. For more information about region codes, see AddControlPolicy. Example: [&quot;BJ11&quot;, &quot;ZB&quot;].</para>
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
            /// <para>The list of CIDR blocks in the destination address book of the access control policy.</para>
            /// </summary>
            [NameInMap("DestinationGroupCidrs")]
            [Validation(Required=false)]
            public List<string> DestinationGroupCidrs { get; set; }

            /// <summary>
            /// <para>The type of the destination address book in the access control policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>ip</b>: An IP address book that contains one or more CIDR blocks.</para>
            /// </description></item>
            /// <item><description><para><b>tag</b>: An ECS tag-based address book that contains the IP addresses of the ECS instances with one or more tags.</para>
            /// </description></item>
            /// <item><description><para><b>domain</b>: A domain name address book that contains one or more domain names.</para>
            /// </description></item>
            /// <item><description><para><b>threat</b>: A threat intelligence address book that contains one or more malicious IP addresses or domain names.</para>
            /// </description></item>
            /// <item><description><para><b>backsrc</b>: An origin URL address book that contains the origin URLs of one or more Anti-DDoS or WAF instances.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ip</para>
            /// </summary>
            [NameInMap("DestinationGroupType")]
            [Validation(Required=false)]
            public string DestinationGroupType { get; set; }

            /// <summary>
            /// <para>The destination address type in the access control policy. Valid values:</para>
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
            /// <para>The traffic direction of the access control policy. Valid values:</para>
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

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The result of the DNS resolution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.0.XX.XX,192.0.XX.XX</para>
            /// </summary>
            [NameInMap("DnsResult")]
            [Validation(Required=false)]
            [Obsolete]
            public string DnsResult { get; set; }

            /// <summary>
            /// <para>The timestamp of the DNS resolution. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1579261141</para>
            /// </summary>
            [NameInMap("DnsResultTime")]
            [Validation(Required=false)]
            public long? DnsResultTime { get; set; }

            /// <summary>
            /// <para>The domain name resolution method of the access control policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>FQDN</b>: FQDN-based</para>
            /// </description></item>
            /// <item><description><para><b>DNS</b>: DNS-based dynamic resolution</para>
            /// </description></item>
            /// <item><description><para><b>FQDN_AND_DNS</b>: FQDN- and DNS-based dynamic resolution</para>
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
            /// <para>The end time of the policy validity period for the access control policy. The value is a UNIX timestamp. The time must be on the hour or half-hour, and at least 30 minutes later than the start time.</para>
            /// <remarks>
            /// <para>If \<c>RepeatType\\</c> is \<c>Permanent\\</c>, \<c>EndTime\\</c> is empty. If \<c>RepeatType\\</c> is \<c>None\\</c>, \<c>Daily\\</c>, \<c>Weekly\\</c>, or \<c>Monthly\\</c>, this parameter is required.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1694764800</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The timestamp of the last hit. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1579261141</para>
            /// </summary>
            [NameInMap("HitLastTime")]
            [Validation(Required=false)]
            public long? HitLastTime { get; set; }

            /// <summary>
            /// <para>The number of hits for the access control policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("HitTimes")]
            [Validation(Required=false)]
            public long? HitTimes { get; set; }

            /// <summary>
            /// <para>The IP version supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>4</b>: IPv4 address</para>
            /// </description></item>
            /// <item><description><para><b>6</b>: IPv6 address</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public int? IpVersion { get; set; }

            /// <summary>
            /// <para>The time when the policy was last modified. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1761062400</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <para>The priority of the access control policy.</para>
            /// <para>The priority value starts from 1 and increases sequentially. A smaller value indicates a higher priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Order")]
            [Validation(Required=false)]
            public int? Order { get; set; }

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
            /// 
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("Proto")]
            [Validation(Required=false)]
            public string Proto { get; set; }

            /// <summary>
            /// <para>The status of the access control policy. The policy is enabled by default after it is created. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The access control policy is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The access control policy is disabled.</para>
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
            /// <para>The collection of recurring dates for the policy validity period of the access control policy.</para>
            /// <list type="bullet">
            /// <item><description><para>If \<c>RepeatType\\</c> is \<c>Permanent\\</c>, \<c>None\\</c>, or \<c>Daily\\</c>, \<c>RepeatDays\\</c> is an empty collection.
            /// Example: []</para>
            /// </description></item>
            /// <item><description><para>If \<c>RepeatType\\</c> is \<c>Weekly\\</c>, \<c>RepeatDays\\</c> cannot be empty.
            /// Example: [0, 6]</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>If \<c>RepeatType\\</c> is set to \<c>Weekly\\</c>, \<c>RepeatDays\\</c> cannot contain duplicate values.</para>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>If \<c>RepeatType\\</c> is \<c>Monthly\\</c>, \<c>RepeatDays\\</c> cannot be empty.
            /// Example: [1, 31]</description></item>
            /// </list>
            /// <remarks>
            /// <para>If \<c>RepeatType\\</c> is set to \<c>Monthly\\</c>, \<c>RepeatDays\\</c> cannot contain duplicate values.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("RepeatDays")]
            [Validation(Required=false)]
            public List<long?> RepeatDays { get; set; }

            /// <summary>
            /// <para>The recurring end time for the policy validity period of the access control policy. Example: \<c>23:30\\</c>. The time must be on the hour or half-hour, and at least 30 minutes later than the recurring start time.</para>
            /// <remarks>
            /// <para>If \<c>RepeatType\\</c> is \<c>Permanent\\</c> or \<c>None\\</c>, \<c>RepeatEndTime\\</c> is empty. If \<c>RepeatType\\</c> is \<c>Daily\\</c>, \<c>Weekly\\</c>, or \<c>Monthly\\</c>, this parameter is required.
            /// The time is in the HH:mm format (24-hour). Examples: \<c>08:00\\</c> and \<c>23:30\\</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>23:30</para>
            /// </summary>
            [NameInMap("RepeatEndTime")]
            [Validation(Required=false)]
            public string RepeatEndTime { get; set; }

            /// <summary>
            /// <para>The recurring start time for the policy validity period of the access control policy. Example: \<c>08:00\\</c>. The time must be on the hour or half-hour, and at least 30 minutes earlier than the recurring end time.</para>
            /// <remarks>
            /// <para>If \<c>RepeatType\\</c> is \<c>Permanent\\</c> or \<c>None\\</c>, \<c>RepeatStartTime\\</c> is empty. If \<c>RepeatType\\</c> is \<c>Daily\\</c>, \<c>Weekly\\</c>, or \<c>Monthly\\</c>, this parameter is required.
            /// The time is in the HH:mm format (24-hour). Examples: \<c>08:00\\</c> and \<c>23:30\\</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>08:00</para>
            /// </summary>
            [NameInMap("RepeatStartTime")]
            [Validation(Required=false)]
            public string RepeatStartTime { get; set; }

            /// <summary>
            /// <para>The recurrence type for the policy validity period of the access control policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Permanent</b> (default): Always</para>
            /// </description></item>
            /// <item><description><para><b>None</b>: One-time</para>
            /// </description></item>
            /// <item><description><para><b>Daily</b>: Daily</para>
            /// </description></item>
            /// <item><description><para><b>Weekly</b>: Weekly</para>
            /// </description></item>
            /// <item><description><para><b>Monthly</b>: Monthly</para>
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
            /// <item><description><para>If <b>SourceType</b> is <c>net</c>, the source address is a CIDR block. Example: 192.0.XX.XX/24.</para>
            /// </description></item>
            /// <item><description><para>If <b>SourceType</b> is <c>group</c>, the source address is the name of a source address book. Example: db_group.</para>
            /// </description></item>
            /// <item><description><para>If <b>SourceType</b> is <c>location</c>, the source address is a region. For more information about region codes, see <a href="https://help.aliyun.com/document_detail/138867.html">AddControlPolicy</a>. Example: [&quot;BJ11&quot;, &quot;ZB&quot;].</para>
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
            /// <para>The list of CIDR blocks in the source address book of the access control policy.</para>
            /// </summary>
            [NameInMap("SourceGroupCidrs")]
            [Validation(Required=false)]
            public List<string> SourceGroupCidrs { get; set; }

            /// <summary>
            /// <para>The type of the source address book in the access control policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>ip</b>: An IP address book that contains one or more CIDR blocks.</para>
            /// </description></item>
            /// <item><description><para><b>tag</b>: An ECS tag-based address book that contains the IP addresses of the ECS instances with one or more tags.</para>
            /// </description></item>
            /// <item><description><para><b>domain</b>: A domain name address book that contains one or more domain names.</para>
            /// </description></item>
            /// <item><description><para><b>threat</b>: A threat intelligence address book that contains one or more malicious IP addresses or domain names.</para>
            /// </description></item>
            /// <item><description><para><b>backsrc</b>: An origin URL address book that contains the origin URLs of one or more Anti-DDoS or WAF instances.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ip</para>
            /// </summary>
            [NameInMap("SourceGroupType")]
            [Validation(Required=false)]
            public string SourceGroupType { get; set; }

            /// <summary>
            /// <para>The source address type in the access control policy. Valid values:</para>
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
            /// <para>The number of specification entries that the access control policy consumes. This is the sum of entries consumed by each policy.
            /// The number of entries for a single policy is calculated as: Number of source addresses (CIDR blocks or regions) × Number of destination addresses (CIDR blocks, regions, or domain names) × Number of port ranges × Number of applications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("SpreadCnt")]
            [Validation(Required=false)]
            public int? SpreadCnt { get; set; }

            /// <summary>
            /// <para>The start time of the policy validity period for the access control policy. The value is a UNIX timestamp. The time must be on the hour or half-hour, and at least 30 minutes earlier than the end time.</para>
            /// <remarks>
            /// <para>If \<c>RepeatType\\</c> is \<c>Permanent\\</c>, \<c>StartTime\\</c> is empty. If \<c>RepeatType\\</c> is \<c>None\\</c>, \<c>Daily\\</c>, \<c>Weekly\\</c>, or \<c>Monthly\\</c>, this parameter is required.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1694761200</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CBF1E9B7-D6A0-4E9E-AD3E-2B47E6C2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of access control policies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
