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
            /// <item><description><b>accept</b>: allows the traffic.</description></item>
            /// <item><description><b>drop</b>: denies the traffic.</description></item>
            /// <item><description><b>log</b>: monitors the traffic.</description></item>
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
            /// 
            /// <b>Example:</b>
            /// <para>00281255-d220-4db1-8f4f-c4df221a****</para>
            /// </summary>
            [NameInMap("AclUuid")]
            [Validation(Required=false)]
            public string AclUuid { get; set; }

            /// <summary>
            /// <para>The application ID in the access control policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10***</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// <para>The application type supported by the access control policy. We recommend that you specify ApplicationNameList. Valid values:</para>
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
            /// <item><description><b>ANY</b>: all types of applications</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("ApplicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }

            /// <summary>
            /// <para>The application names.</para>
            /// </summary>
            [NameInMap("ApplicationNameList")]
            [Validation(Required=false)]
            public List<string> ApplicationNameList { get; set; }

            /// <summary>
            /// <para>The time when the access control policy was created.</para>
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
            /// <para>The ports in the destination port address book.</para>
            /// </summary>
            [NameInMap("DestPortGroupPorts")]
            [Validation(Required=false)]
            public List<string> DestPortGroupPorts { get; set; }

            /// <summary>
            /// <para>The type of the destination port in the access control policy. Valid values:</para>
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
            /// <para>The destination address in the access control policy. The value of this parameter varies based on the value of DestinationType.</para>
            /// <list type="bullet">
            /// <item><description>If the value of <b>DestinationType</b> is <b>net</b>, the value of Destination is a CIDR block. Example: 192.0.XX.XX/24.</description></item>
            /// <item><description>If the value of <b>DestinationType</b> is <b>domain</b>, the value of Destination is a domain name. Example: aliyuncs.com.</description></item>
            /// <item><description>If the value of <b>DestinationType</b> is <b>group</b>, the value of Destination is the name of an address book. Example: db_group.</description></item>
            /// <item><description>If the value of <b>DestinationType</b> is <b>location</b>, the value of Destination is the name of a location. For more information about location codes, see AddControlPolicy. Example: [&quot;BJ11&quot;, &quot;ZB&quot;].</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>192.0.XX.XX/24</para>
            /// </summary>
            [NameInMap("Destination")]
            [Validation(Required=false)]
            public string Destination { get; set; }

            /// <summary>
            /// <para>The CIDR blocks in the destination address book.</para>
            /// </summary>
            [NameInMap("DestinationGroupCidrs")]
            [Validation(Required=false)]
            public List<string> DestinationGroupCidrs { get; set; }

            /// <summary>
            /// <para>The type of the destination address book in the access control policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ip</b>: an address book that includes one or more IP addresses</description></item>
            /// <item><description><b>tag</b>: an ECS tag-based address book that includes the IP addresses of the ECS instances with one or more specific tags</description></item>
            /// <item><description><b>domain</b>: an address book that includes one or more domain names</description></item>
            /// <item><description><b>threat</b>: an address book that includes one or more malicious IP addresses or domain names</description></item>
            /// <item><description><b>backsrc</b>: an address book that includes one or more back-to-origin addresses of Anti-DDoS Pro or Anti-DDoS Premium instances or WAF instances</description></item>
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
            /// <item><description><b>net</b>: CIDR block</description></item>
            /// <item><description><b>group</b>: address book</description></item>
            /// <item><description><b>domain</b>: domain name</description></item>
            /// <item><description><b>location</b>: location</description></item>
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

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The DNS resolution results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.0.XX.XX,192.0.XX.XX</para>
            /// </summary>
            [NameInMap("DnsResult")]
            [Validation(Required=false)]
            [Obsolete]
            public string DnsResult { get; set; }

            /// <summary>
            /// <para>The time when the Domain Name System (DNS) resolution was performed. The value is a timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1579261141</para>
            /// </summary>
            [NameInMap("DnsResultTime")]
            [Validation(Required=false)]
            public long? DnsResultTime { get; set; }

            /// <summary>
            /// <para>The domain name resolution method of the access control policy. By default, an access control policy is enabled after the policy is created. Valid values:</para>
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
            /// <para>The time when the access control policy stops taking effect. The value is a timestamp. Unit: seconds. The end time must be on the hour or on the half hour, and at least 30 minutes later than the start time.</para>
            /// <remarks>
            /// <para> If RepeatType is set to Permanent, this parameter is left empty. If RepeatType is set to None, Daily, Weekly, or Monthly, this parameter must be specified.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1694764800</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The time when the access control policy was last hit. The value is a timestamp. Unit: seconds.</para>
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
            /// <para>The IP version used in the access control policy. Valid values:</para>
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
            /// <para>The time when the access control policy was modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1761062400</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <para>The priority of the access control policy.</para>
            /// <para>The priority value starts from 1. A smaller priority value indicates a higher priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Order")]
            [Validation(Required=false)]
            public int? Order { get; set; }

            /// <summary>
            /// <para>The protocol type in the access control policy. Valid values:</para>
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
            /// <para>The status of the access control policy. By default, an access control policy is enabled after it is created. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: enabled</description></item>
            /// <item><description><b>false</b>: disabled</description></item>
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
            /// <item><description>If RepeatType is set to <c>Permanent</c>, <c>None</c>, or <c>Daily</c>, this parameter is left empty. Example: [].</description></item>
            /// <item><description>If RepeatType is set to Weekly, this parameter must be specified. Example: [0, 6].</description></item>
            /// </list>
            /// <remarks>
            /// <para> If RepeatType is set to Weekly, the fields in the value of RepeatDays cannot be repeated.</para>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>If RepeatType is set to <c>Monthly</c>, this parameter must be specified. Example: [1, 31].</description></item>
            /// </list>
            /// <remarks>
            /// <para> If RepeatType is set to Monthly, the fields in the value of RepeatDays cannot be repeated.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("RepeatDays")]
            [Validation(Required=false)]
            public List<long?> RepeatDays { get; set; }

            /// <summary>
            /// <para>The point in time when the recurrence ends. Example: 23:30. The value must be on the hour or on the half hour, and at least 30 minutes later than the start time.</para>
            /// <remarks>
            /// <para> If RepeatType is set to Permanent or None, this parameter is left empty. If RepeatType is set to Daily, Weekly, or Monthly, this parameter must be specified.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>23:30</para>
            /// </summary>
            [NameInMap("RepeatEndTime")]
            [Validation(Required=false)]
            public string RepeatEndTime { get; set; }

            /// <summary>
            /// <para>The point in time when the recurrence starts. Example: 08:00. The value must be on the hour or on the half hour, and at least 30 minutes earlier than the end time.</para>
            /// <remarks>
            /// <para> If RepeatType is set to Permanent or None, this parameter is left empty. If RepeatType is set to Daily, Weekly, or Monthly, this parameter must be specified.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>08:00</para>
            /// </summary>
            [NameInMap("RepeatStartTime")]
            [Validation(Required=false)]
            public string RepeatStartTime { get; set; }

            /// <summary>
            /// <para>The recurrence type based on which the access control policy takes effect. Valid values:</para>
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
            /// <item><description>If <b>SourceType</b> is set to <c>net</c>, the value of Source is a CIDR block. Example: 192.0.XX.XX/24.</description></item>
            /// <item><description>If <b>SourceType</b> is set to <c>group</c>, the value of Source is the name of an address book. Example: db_group.</description></item>
            /// <item><description>If <b>SourceType</b> is set to <c>location</c>, the value of Source is a location. For more information about location codes, see <a href="https://help.aliyun.com/document_detail/138867.html">AddControlPolicy</a>. Example: [&quot;BJ11&quot;, &quot;ZB&quot;].</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>192.0.XX.XX/24</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The CIDR blocks in the source address book.</para>
            /// </summary>
            [NameInMap("SourceGroupCidrs")]
            [Validation(Required=false)]
            public List<string> SourceGroupCidrs { get; set; }

            /// <summary>
            /// <para>The type of the source address book in the access control policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ip</b>: an address book that includes one or more IP addresses</description></item>
            /// <item><description><b>tag</b>: an Elastic Compute Service (ECS) tag-based address book that includes the IP addresses of the ECS instances with one or more specific tags</description></item>
            /// <item><description><b>domain</b>: an address book that includes one or more domain names</description></item>
            /// <item><description><b>threat</b>: an address book that includes one or more malicious IP addresses or domain names</description></item>
            /// <item><description><b>backsrc</b>: an address book that includes one or more back-to-origin addresses of Anti-DDoS Pro or Anti-DDoS Premium instances or Web Application Firewall (WAF) instances</description></item>
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
            /// <item><description><b>net</b>: CIDR block</description></item>
            /// <item><description><b>group</b>: address book</description></item>
            /// <item><description><b>location</b>: location</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>net</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>The total quota consumed by the returned access control policies, which is the sum of the quota consumed by each policy. The quota that is consumed by an access control policy is calculated by using the following formula: Quota that is consumed by an access control policy = Number of source addresses (number of CIDR blocks or regions) × Number of destination addresses (number of CIDR blocks, regions, or domain names) × Number of port ranges × Number of applications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10,000</para>
            /// </summary>
            [NameInMap("SpreadCnt")]
            [Validation(Required=false)]
            public int? SpreadCnt { get; set; }

            /// <summary>
            /// <para>The time when the access control policy starts to take effect. The value is a timestamp. Unit: seconds. The start time must be on the hour or on the half hour, and at least 30 minutes earlier than the end time.</para>
            /// <remarks>
            /// <para> If RepeatType is set to Permanent, this parameter is left empty. If RepeatType is set to None, Daily, Weekly, or Monthly, this parameter must be specified.</para>
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
        /// <para>The total number of the returned access control policies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
