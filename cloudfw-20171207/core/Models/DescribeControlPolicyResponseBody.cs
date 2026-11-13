// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeControlPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the current page returned for a paged query during paging.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public string PageNo { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page for a paged query during paging.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The information about each access control policy.</para>
        /// </summary>
        [NameInMap("Policys")]
        [Validation(Required=false)]
        public List<DescribeControlPolicyResponseBodyPolicys> Policys { get; set; }
        public class DescribeControlPolicyResponseBodyPolicys : TeaModel {
            /// <summary>
            /// <para>The action that Cloud Firewall performs on the traffic that matches the access control policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>accept</b>: Allow</description></item>
            /// <item><description><b>drop</b>: Deny</description></item>
            /// <item><description><b>log</b>: Monitor</description></item>
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
            /// <para>The ID of the application for the traffic in the access control policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10***</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// <para>The application type supported by the access control policy. ApplicationNameList is recommended. Valid values:</para>
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
            /// <item><description><b>SSL</b></description></item>
            /// <item><description><b>VNC</b></description></item>
            /// <item><description><b>ANY</b> (all application types)</description></item>
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
            /// <para>The time when the policy was created. The value is a UNIX timestamp in seconds, which indicates the number of seconds that have elapsed since January 1, 1970 (UTC).</para>
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
            /// <para>Allow access to the office CIDR block</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The destination port of the traffic in the access control policy.</para>
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
            /// <para>The ports in the destination port address book.</para>
            /// </summary>
            [NameInMap("DestPortGroupPorts")]
            [Validation(Required=false)]
            public List<string> DestPortGroupPorts { get; set; }

            /// <summary>
            /// <para>The type of the destination port in the access control policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>port</b>: Port</description></item>
            /// <item><description><b>group</b>: Port address book</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>port</para>
            /// </summary>
            [NameInMap("DestPortType")]
            [Validation(Required=false)]
            public string DestPortType { get; set; }

            /// <summary>
            /// <para>The destination address in the access control policy. The value of Destination varies based on the destination type (DestinationType). Valid values:</para>
            /// <list type="bullet">
            /// <item><description>If <b>DestinationType</b> is set to <b>net</b>, the destination address is a CIDR block. Example: 192.0.XX.XX/24.</description></item>
            /// <item><description>If <b>DestinationType</b> is set to <b>domain</b>, the destination address is a domain name. Example: aliyuncs.com.</description></item>
            /// <item><description>If <b>DestinationType</b> is set to <b>group</b>, the destination address is the name of an address book. Example: db_group.</description></item>
            /// <item><description>If <b>DestinationType</b> is set to <b>location</b>, the destination address is an area name. For more information about the area positional encoding, see AddControlPolicy. Example: [&quot;BJ11&quot;, &quot;ZB&quot;\].</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>192.0.XX.XX/24</para>
            /// </summary>
            [NameInMap("Destination")]
            [Validation(Required=false)]
            public string Destination { get; set; }

            /// <summary>
            /// <para>The CIDR blocks in the destination address book of the access control policy.</para>
            /// </summary>
            [NameInMap("DestinationGroupCidrs")]
            [Validation(Required=false)]
            public List<string> DestinationGroupCidrs { get; set; }

            /// <summary>
            /// <para>The type of the destination address book in the access control policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>ip</b>: IP address book, which contains one or more CIDR blocks.</para>
            /// </description></item>
            /// <item><description><para><b>tag</b>: ECS tag-based address book, which contains the IP addresses of one or more ECS tags.</para>
            /// </description></item>
            /// <item><description><para><b>domain</b>: Domain name address book, which contains one or more domain names.</para>
            /// </description></item>
            /// <item><description><para><b>threat</b>: Threat intelligence address book, which contains one or more malicious IP addresses or domain names.</para>
            /// </description></item>
            /// <item><description><para><b>backsrc</b>: Back-to-origin address book, which contains the back-to-origin IP addresses of one or more Anti-DDoS or WAF instances.</para>
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
            /// <para>The type of the destination address in the access control policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>net</b>: Destination CIDR block</description></item>
            /// <item><description><b>group</b>: Destination address book</description></item>
            /// <item><description><b>domain</b>: Destination domain name</description></item>
            /// <item><description><b>location</b>: Destination region</description></item>
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
            /// <item><description><b>in</b>: Inbound traffic</description></item>
            /// <item><description><b>out</b>: Outbound traffic</description></item>
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
            /// <para>The DNS resolution result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.0.XX.XX,192.0.XX.XX</para>
            /// </summary>
            [NameInMap("DnsResult")]
            [Validation(Required=false)]
            [Obsolete]
            public string DnsResult { get; set; }

            /// <summary>
            /// <para>The timestamp of the DNS resolution. The value is a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1579261141</para>
            /// </summary>
            [NameInMap("DnsResultTime")]
            [Validation(Required=false)]
            public long? DnsResultTime { get; set; }

            /// <summary>
            /// <para>The domain name resolution mode of the access control policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>FQDN</b>: FQDN-based</description></item>
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
            /// <para>The end time of the Policy Validity Period for the access control policy. The value is in the UNIX timestamp format in seconds. The time must be on the hour or half-hour, and must be at least 30 minutes later than the start time.</para>
            /// <remarks>
            /// <para>If RepeatType is Permanent, EndTime is empty. If RepeatType is None, Daily, Weekly, or Monthly, EndTime is required, and you must configure the Settings for the end time.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1694764800</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The latest time of hits. The value is in the UNIX timestamp format in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1579261141</para>
            /// </summary>
            [NameInMap("HitLastTime")]
            [Validation(Required=false)]
            public long? HitLastTime { get; set; }

            /// <summary>
            /// <para>The number of times the access control policy is hit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("HitTimes")]
            [Validation(Required=false)]
            public long? HitTimes { get; set; }

            /// <summary>
            /// <para>The IP address version. Valid values:</para>
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
            public int? IpVersion { get; set; }

            /// <summary>
            /// <para>The time when the policy was modified. The value is a UNIX timestamp in seconds, which indicates the number of seconds that have elapsed since January 1, 1970 (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1761062400</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <para>The priority of the access control policy.</para>
            /// <para>The priority value starts from 1 and increments. A smaller value indicates a higher priority.</para>
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
            /// <item><description><b>ANY</b></description></item>
            /// <item><description><b>TCP</b></description></item>
            /// <item><description><b>UDP</b></description></item>
            /// <item><description><b>ICMP</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("Proto")]
            [Validation(Required=false)]
            public string Proto { get; set; }

            /// <summary>
            /// <para>Specifies whether the access control policy is enabled. By default, a policy is enabled after it is created. Valid values:</para>
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
            /// <para>The recurrence days of the Policy Validity Period for the access control policy.</para>
            /// <list type="bullet">
            /// <item><description>If RepeatType is set to <c>Permanent</c>, <c>None</c>, or <c>Daily</c>, RepeatDays is an empty set.
            /// Example: []</description></item>
            /// <item><description>When the Settings specify Weekly for RepeatType, RepeatDays cannot be empty.
            /// Example: [0, 6]<remarks>
            /// <para>When the Settings specify Weekly for RepeatType, the values in RepeatDays must be unique.</para>
            /// </remarks>
            /// </description></item>
            /// <item><description>If RepeatType is set to <c>Monthly</c>, RepeatDays cannot be empty.
            /// Example: [1, 31]<remarks>
            /// <para>When the Settings specify Monthly for RepeatType, the values in RepeatDays must be unique.</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("RepeatDays")]
            [Validation(Required=false)]
            public List<long?> RepeatDays { get; set; }

            /// <summary>
            /// <para>The recurrence end time of the Policy Validity Period for the access control policy. Example: 23:30. The time must be on the hour or half-hour, and must be at least 30 minutes later than the recurrence start time.</para>
            /// <remarks>
            /// <para>If RepeatType is Permanent or None, RepeatEndTime is empty. If RepeatType is Daily, Weekly, or Monthly, RepeatEndTime is required, and you must configure the Settings for the recurrence end time.
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
            /// <para>The recurrence start time of the Policy Validity Period for the access control policy. Example: 08:00. The time must be on the hour or half-hour, and must be at least 30 minutes earlier than the recurrence end time.</para>
            /// <remarks>
            /// <para>If RepeatType is Permanent or None, RepeatStartTime is empty. If RepeatType is Daily, Weekly, or Monthly, RepeatStartTime is required, and you must configure the Settings for the recurrence start time.
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
            /// <para>The recurrence type of the Policy Validity Period for the access control policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Permanent</b> (default): Always</description></item>
            /// <item><description><b>None</b>: One-time</description></item>
            /// <item><description><b>Daily</b>: Daily</description></item>
            /// <item><description><b>Weekly</b>: Weekly</description></item>
            /// <item><description><b>Monthly</b>: Monthly</description></item>
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
            /// <item><description>If <b>SourceType</b> is set to <c>net</c>, the source address is a CIDR block. Example: 192.0.XX.XX/24.</description></item>
            /// <item><description>If <b>SourceType</b> is set to <c>group</c>, the source address is the name of a source address book. Example: db_group.</description></item>
            /// <item><description>If <b>SourceType</b> is set to <c>location</c>, the source address is an area. For more information about the area positional encoding, see <a href="https://help.aliyun.com/document_detail/138867.html">AddControlPolicy</a>. Example: [&quot;BJ11&quot;, &quot;ZB&quot;\].</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>192.0.XX.XX/24</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The CIDR blocks in the source address book of the access control policy.</para>
            /// </summary>
            [NameInMap("SourceGroupCidrs")]
            [Validation(Required=false)]
            public List<string> SourceGroupCidrs { get; set; }

            /// <summary>
            /// <para>The type of the source address book in the access control policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>ip</b>: IP address book, which contains one or more CIDR blocks.</para>
            /// </description></item>
            /// <item><description><para><b>tag</b>: ECS tag-based address book, which contains the IP addresses of one or more ECS tags.</para>
            /// </description></item>
            /// <item><description><para><b>domain</b>: Domain name address book, which contains one or more domain names.</para>
            /// </description></item>
            /// <item><description><para><b>threat</b>: Threat intelligence address book, which contains one or more malicious IP addresses or domain names.</para>
            /// </description></item>
            /// <item><description><para><b>backsrc</b>: Back-to-origin address book, which contains the back-to-origin IP addresses of one or more Anti-DDoS or WAF instances.</para>
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
            /// <para>The type of the source address in the access control policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>net</b>: Source CIDR block</description></item>
            /// <item><description><b>group</b>: Source address book</description></item>
            /// <item><description><b>location</b>: Source region</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>net</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>The quota consumed by the access control policy, which is the sum of the quota consumed by each policy.
            /// Quota consumed by a single policy = Number of source addresses (number of CIDR blocks or area) \* Number of destination addresses (number of CIDR blocks, area, or domain names) \* Number of port ranges \* Number of applications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("SpreadCnt")]
            [Validation(Required=false)]
            public int? SpreadCnt { get; set; }

            /// <summary>
            /// <para>The start time of the Policy Validity Period for the access control policy. The value is in the UNIX timestamp format in seconds. The time must be on the hour or half-hour, and must be at least 30 minutes earlier than the end time.</para>
            /// <remarks>
            /// <para>If RepeatType is Permanent, StartTime is empty. If RepeatType is None, Daily, Weekly, or Monthly, StartTime is required, and you must configure the Settings for the start time.</para>
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
        /// <para>The total number of access control policy entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
