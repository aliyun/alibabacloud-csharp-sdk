// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class UpdateAclCheckDetailStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The ACL check record.</para>
        /// </summary>
        [NameInMap("CheckRecord")]
        [Validation(Required=false)]
        public UpdateAclCheckDetailStatusResponseBodyCheckRecord CheckRecord { get; set; }
        public class UpdateAclCheckDetailStatusResponseBodyCheckRecord : TeaModel {
            /// <summary>
            /// <para>The list of ACL check results.</para>
            /// </summary>
            [NameInMap("Acls")]
            [Validation(Required=false)]
            public List<UpdateAclCheckDetailStatusResponseBodyCheckRecordAcls> Acls { get; set; }
            public class UpdateAclCheckDetailStatusResponseBodyCheckRecordAcls : TeaModel {
                /// <summary>
                /// <para>The ACL check result.</para>
                /// </summary>
                [NameInMap("Acl")]
                [Validation(Required=false)]
                public UpdateAclCheckDetailStatusResponseBodyCheckRecordAclsAcl Acl { get; set; }
                public class UpdateAclCheckDetailStatusResponseBodyCheckRecordAclsAcl : TeaModel {
                    /// <summary>
                    /// <para>The action that Cloud Firewall performs on the traffic in the access control policy. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>accept</b>: Allow.</description></item>
                    /// <item><description><b>drop</b>: Deny.</description></item>
                    /// <item><description><b>log</b>: Monitor.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>log</para>
                    /// </summary>
                    [NameInMap("AclAction")]
                    [Validation(Required=false)]
                    public string AclAction { get; set; }

                    /// <summary>
                    /// <para>The unique ID of the access control policy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1e8ed1b2-cebc-4b95-a9cc-0cb7ce2c0c2c</para>
                    /// </summary>
                    [NameInMap("AclUuid")]
                    [Validation(Required=false)]
                    public string AclUuid { get; set; }

                    /// <summary>
                    /// <para>The addresses in the address book.</para>
                    /// </summary>
                    [NameInMap("AddressList")]
                    [Validation(Required=false)]
                    public List<string> AddressList { get; set; }

                    /// <summary>
                    /// <para>The number of addresses in the address book.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("AddressListCount")]
                    [Validation(Required=false)]
                    public int? AddressListCount { get; set; }

                    /// <summary>
                    /// <para>The application ID of the traffic in the access control policy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HTTP</para>
                    /// </summary>
                    [NameInMap("ApplicationId")]
                    [Validation(Required=false)]
                    public string ApplicationId { get; set; }

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
                    /// </list>
                    /// <remarks>
                    /// <para>The supported application types depend on the protocol type (Proto). When Proto is set to TCP, ApplicationNameList supports all the preceding application types. When both ApplicationNameList and ApplicationName are specified, ApplicationNameList takes precedence.</para>
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
                    /// <para>Indicates whether the public IP addresses of newly matched ECS instances (newly purchased ECS instances with configured tags or ECS instances with modified tags) are automatically added to the address book.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AutoAddTagEcs")]
                    [Validation(Required=false)]
                    public int? AutoAddTagEcs { get; set; }

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
                    /// <para>test_policy</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The destination port of traffic in the access control policy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>22/22</para>
                    /// </summary>
                    [NameInMap("DestPort")]
                    [Validation(Required=false)]
                    public string DestPort { get; set; }

                    /// <summary>
                    /// <para>The type of destination port in the access control policy. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>port</b>: Port.</description></item>
                    /// <item><description><b>group</b>: Port address book.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>port</para>
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
                    /// <para>The type of destination port in the access control policy. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>port</b>: Port.</description></item>
                    /// <item><description><b>group</b>: Port address book.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>port</para>
                    /// </summary>
                    [NameInMap("DestPortType")]
                    [Validation(Required=false)]
                    public string DestPortType { get; set; }

                    /// <summary>
                    /// <para>The destination address in the access control policy. Fuzzy queries are supported. The value varies depending on the value of DestinationType.</para>
                    /// <list type="bullet">
                    /// <item><description><para>If DestinationType is set to <c>net</c>, the destination address is a CIDR block. Example: 10.0.3.0/24.</para>
                    /// </description></item>
                    /// <item><description><para>If DestinationType is set to <c>domain</c>, the destination address is a domain name. Example: aliyun.</para>
                    /// </description></item>
                    /// <item><description><para>If DestinationType is set to <c>group</c>, the destination address is the name of an address book. Example: db_group.</para>
                    /// </description></item>
                    /// <item><description><para>If DestinationType is set to <c>location</c>, the destination address is a region name. For specific region location codes, see AddControlPolicy. Example: [&quot;BJ11&quot;, &quot;ZB&quot;].</para>
                    /// </description></item>
                    /// </list>
                    /// <remarks>
                    /// <para>If you do not set this parameter, destination addresses of all types are queried.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>kms.cn-shanghai.aliyuncs.com</para>
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
                    /// <para>The type of destination address book in the access control policy. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>ip</b>: IP address book, which contains one or more IP address ranges.</para>
                    /// </description></item>
                    /// <item><description><para><b>tag</b>: ECS tag-based address book, which contains the IP addresses of ECS instances with one or more specific tags.</para>
                    /// </description></item>
                    /// <item><description><para><b>domain</b>: Domain address book, which contains one or more domain addresses.</para>
                    /// </description></item>
                    /// <item><description><para><b>threat</b>: Threat intelligence address book, which contains one or more malicious IP addresses or domain names.</para>
                    /// </description></item>
                    /// <item><description><para><b>backsrc</b>: Back-to-origin address book, which contains the back-to-origin addresses of one or more Anti-DDoS or WAF instances.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>domain</para>
                    /// </summary>
                    [NameInMap("DestinationGroupType")]
                    [Validation(Required=false)]
                    public string DestinationGroupType { get; set; }

                    /// <summary>
                    /// <para>The type of destination address in the access control policy.</para>
                    /// <para>Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>net</b>: Destination CIDR block.</description></item>
                    /// <item><description><b>group</b>: Destination address book.</description></item>
                    /// <item><description><b>domain</b>: Destination domain name.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>group</para>
                    /// </summary>
                    [NameInMap("DestinationType")]
                    [Validation(Required=false)]
                    public string DestinationType { get; set; }

                    /// <summary>
                    /// <para>The direction of traffic controlled by the access control policy.</para>
                    /// <para>Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>in</b>: Inbound traffic.</description></item>
                    /// <item><description><b>out</b>: Outbound traffic.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>in</para>
                    /// </summary>
                    [NameInMap("Direction")]
                    [Validation(Required=false)]
                    public string Direction { get; set; }

                    /// <summary>
                    /// <para>The DNS resolution result.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>192.168.0.1/32</para>
                    /// </summary>
                    [NameInMap("DnsResult")]
                    [Validation(Required=false)]
                    public string DnsResult { get; set; }

                    /// <summary>
                    /// <para>The timestamp of DNS resolution. The value is a UNIX timestamp. Unit: seconds.</para>
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
                    /// <item><description><b>FQDN</b>: FQDN-based resolution.</description></item>
                    /// <item><description><b>DNS</b>: DNS-based dynamic resolution.</description></item>
                    /// <item><description><b>FQDN_AND_DNS</b>: FQDN and DNS-based dynamic resolution.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("DomainResolveType")]
                    [Validation(Required=false)]
                    public int? DomainResolveType { get; set; }

                    /// <summary>
                    /// <para>The end time of the query. The value is a UNIX timestamp. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1752754426</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    /// <summary>
                    /// <para>The name of the address book.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>subscribe</para>
                    /// </summary>
                    [NameInMap("GroupName")]
                    [Validation(Required=false)]
                    public string GroupName { get; set; }

                    /// <summary>
                    /// <para>The type of the address book. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>ip</b>: IP address book.</para>
                    /// </description></item>
                    /// <item><description><para><b>domain</b>: Domain address book.</para>
                    /// </description></item>
                    /// <item><description><para><b>port</b>: Port address book.</para>
                    /// </description></item>
                    /// <item><description><para><b>tag</b>: ECS tag-based address book.</para>
                    /// </description></item>
                    /// <item><description><para><b>allCloud</b>: Cloud service address book.</para>
                    /// </description></item>
                    /// <item><description><para><b>threat</b>: Threat intelligence address book.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>port</para>
                    /// </summary>
                    [NameInMap("GroupType")]
                    [Validation(Required=false)]
                    public string GroupType { get; set; }

                    /// <summary>
                    /// <para>The unique ID of the address book.</para>
                    /// <remarks>
                    /// <para>You can call <a href="~~DescribeAddressBook~~">DescribeAddressBook</a> to query the ID.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5a96a798-9b73-47f7-831e-1d7aa3c987a9</para>
                    /// </summary>
                    [NameInMap("GroupUuid")]
                    [Validation(Required=false)]
                    public string GroupUuid { get; set; }

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
                    /// <para>The number of hits on the access control policy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("HitTimes")]
                    [Validation(Required=false)]
                    public long? HitTimes { get; set; }

                    /// <summary>
                    /// <para>The IP version of the asset protected by Cloud Firewall. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>4</b> (default): IPv4.</description></item>
                    /// <item><description><b>6</b>: IPv6.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4</para>
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
                    /// <para>The ID of the NAT gateway.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ngw-gw85zno51npz7lgc04z89</para>
                    /// </summary>
                    [NameInMap("NatGatewayId")]
                    [Validation(Required=false)]
                    public string NatGatewayId { get; set; }

                    /// <summary>
                    /// <para>The priority of the access control policy.</para>
                    /// <para>Priority values start from 1 and increase sequentially. A smaller value indicates a higher priority.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Order")]
                    [Validation(Required=false)]
                    public int? Order { get; set; }

                    /// <summary>
                    /// <para>The protocol type of traffic in the access control policy. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>TCP</b></description></item>
                    /// <item><description><b>UDP</b></description></item>
                    /// <item><description><b>ICMP</b></description></item>
                    /// <item><description><b>ANY</b>: All protocol types.<remarks>
                    /// <para>If you do not set this parameter, all protocol types are queried.</para>
                    /// </remarks>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ANY</para>
                    /// </summary>
                    [NameInMap("Proto")]
                    [Validation(Required=false)]
                    public string Proto { get; set; }

                    /// <summary>
                    /// <para>The number of times the address book is referenced.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("ReferenceCount")]
                    [Validation(Required=false)]
                    public int? ReferenceCount { get; set; }

                    /// <summary>
                    /// <para>The status of the access control policy. By default, the policy is enabled after it is created. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b>: Enable the access control policy.</description></item>
                    /// <item><description><b>false</b>: Disable the access control policy.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Release")]
                    [Validation(Required=false)]
                    public string Release { get; set; }

                    /// <summary>
                    /// <para>The recurrence days of the validity period of the access control policy.</para>
                    /// <list type="bullet">
                    /// <item><description>If RepeatType is set to <c>Permanent</c>, <c>None</c>, or <c>Daily</c>, RepeatDays is an empty collection.
                    /// Example: []</description></item>
                    /// <item><description>If RepeatType is set to Weekly, RepeatDays must not be empty.
                    /// Example: [0, 6]<remarks>
                    /// <para>When RepeatType is set to Weekly, RepeatDays must not contain duplicate values.</para>
                    /// </remarks>
                    /// </description></item>
                    /// <item><description>If RepeatType is set to <c>Monthly</c>, RepeatDays must not be empty.
                    /// Example: [1, 31]<remarks>
                    /// <para>When RepeatType is set to Monthly, RepeatDays must not contain duplicate values.</para>
                    /// </remarks>
                    /// </description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("RepeatDays")]
                    [Validation(Required=false)]
                    public List<long?> RepeatDays { get; set; }

                    /// <summary>
                    /// <para>The recurrence end time of the validity period of the policy. The value is in HH:mm format using the 24-hour clock, such as 23:30. The value must be on the hour or half hour, and must be at least 30 minutes later than the recurrence start time.</para>
                    /// <remarks>
                    /// <para>When RepeatType is set to Permanent or None, RepeatEndTime is empty. When RepeatType is set to Daily, Weekly, or Monthly, RepeatEndTime is required.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>23:30</para>
                    /// </summary>
                    [NameInMap("RepeatEndTime")]
                    [Validation(Required=false)]
                    public string RepeatEndTime { get; set; }

                    /// <summary>
                    /// <para>The recurrence start time of the validity period of the policy. The value is in HH:mm format using the 24-hour clock, such as 08:00. The value must be on the hour or half hour, and must be at least 30 minutes earlier than the recurrence end time.</para>
                    /// <remarks>
                    /// <para>When RepeatType is set to Permanent or None, RepeatStartTime is empty. When RepeatType is set to Daily, Weekly, or Monthly, RepeatStartTime is required.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>08:00</para>
                    /// </summary>
                    [NameInMap("RepeatStartTime")]
                    [Validation(Required=false)]
                    public string RepeatStartTime { get; set; }

                    /// <summary>
                    /// <para>The recurrence type of the validity period of the access control policy. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>Permanent</b> (default): Always.</description></item>
                    /// <item><description><b>None</b>: One-time.</description></item>
                    /// <item><description><b>Daily</b>: Daily.</description></item>
                    /// <item><description><b>Weekly</b>: Weekly.</description></item>
                    /// <item><description><b>Monthly</b>: Monthly.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>None</para>
                    /// </summary>
                    [NameInMap("RepeatType")]
                    [Validation(Required=false)]
                    public string RepeatType { get; set; }

                    /// <summary>
                    /// <para>The source address in the access control policy.</para>
                    /// <para>Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para>If <b>SourceType</b> is set to <c>net</c>, Source is the source CIDR block.</para>
                    /// <para>Example: 10.2.4.0/24</para>
                    /// </description></item>
                    /// <item><description><para>If <b>SourceType</b> is set to <c>group</c>, Source is the name of the source address book.</para>
                    /// <para>Example: db_group</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10.71.94.24</para>
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
                    /// <para>The type of source address book in the access control policy. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>ip</b>: IP address book, which contains one or more IP address ranges.</para>
                    /// </description></item>
                    /// <item><description><para><b>tag</b>: ECS tag-based address book, which contains the IP addresses of ECS instances with one or more specific tags.</para>
                    /// </description></item>
                    /// <item><description><para><b>domain</b>: Domain address book, which contains one or more domain addresses.</para>
                    /// </description></item>
                    /// <item><description><para><b>threat</b>: Threat intelligence address book, which contains one or more malicious IP addresses or domain names.</para>
                    /// </description></item>
                    /// <item><description><para><b>backsrc</b>: Back-to-origin address book, which contains the back-to-origin addresses of one or more Anti-DDoS or WAF instances.</para>
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
                    /// <para>The type of source address in the access control policy. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>net</b>: Source CIDR block.</description></item>
                    /// <item><description><b>group</b>: Source address book.</description></item>
                    /// <item><description><b>location</b>: Source region.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>net</para>
                    /// </summary>
                    [NameInMap("SourceType")]
                    [Validation(Required=false)]
                    public string SourceType { get; set; }

                    /// <summary>
                    /// <para>The number of access control policy specifications consumed, which is the cumulative count of specifications consumed by each policy.
                    /// Specifications consumed by a single policy = Number of source CIDR blocks × Number of destination addresses (IP CIDR blocks, regions, or domain names) × Number of applications × Number of port ranges.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("SpreadCnt")]
                    [Validation(Required=false)]
                    public int? SpreadCnt { get; set; }

                    /// <summary>
                    /// <para>The start time of the query. The value is a UNIX timestamp. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1736130347</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                    /// <summary>
                    /// <para>The ECS tags.</para>
                    /// </summary>
                    [NameInMap("TagList")]
                    [Validation(Required=false)]
                    public List<UpdateAclCheckDetailStatusResponseBodyCheckRecordAclsAclTagList> TagList { get; set; }
                    public class UpdateAclCheckDetailStatusResponseBodyCheckRecordAclsAclTagList : TeaModel {
                        /// <summary>
                        /// <para>The ECS tag key.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>produce</para>
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// <para>The ECS tag value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>tfTestAcc0</para>
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                    /// <summary>
                    /// <para>The logical relationship among multiple ECS tags.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>and</para>
                    /// </summary>
                    [NameInMap("TagRelation")]
                    [Validation(Required=false)]
                    public string TagRelation { get; set; }

                    /// <summary>
                    /// <para>The instance ID of the VPC firewall.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cen-cw4z051hr8x53qniv5</para>
                    /// </summary>
                    [NameInMap("VpcFirewallId")]
                    [Validation(Required=false)]
                    public string VpcFirewallId { get; set; }

                }

                /// <summary>
                /// <para>The assessment details of this ACL policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>No traffic hit policy.</para>
                /// </summary>
                [NameInMap("AclAssessmentDetail")]
                [Validation(Required=false)]
                public string AclAssessmentDetail { get; set; }

                /// <summary>
                /// <para>The ACL check status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>configuring</para>
                /// </summary>
                [NameInMap("AclStatus")]
                [Validation(Required=false)]
                public string AclStatus { get; set; }

            }

            /// <summary>
            /// <para>The ACL check name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>PolicyHitCountZero</b>: Policies with no traffic hits.</para>
            /// </description></item>
            /// <item><description><para><b>PolicySourceDestinationSame</b>: Invalid policies with the same source and destination.</para>
            /// </description></item>
            /// <item><description><para><b>PolicyDuplicate</b>: Duplicate redundant policies.</para>
            /// </description></item>
            /// <item><description><para><b>PolicyConflict</b>: Business conflict policies.</para>
            /// </description></item>
            /// <item><description><para><b>DefaultPolicyNotDeny</b>: Default policy is not Deny All allowlist mechanism.</para>
            /// </description></item>
            /// <item><description><para><b>PolicyPortHighRisk</b>: Policies that allow traffic through high-risk ports.</para>
            /// </description></item>
            /// <item><description><para><b>PolicyTooLoose</b>: Overly permissive control policies.</para>
            /// </description></item>
            /// <item><description><para><b>AddressBookIpSeparated</b>: Duplicate, overlapping, or scattered IP address books.</para>
            /// </description></item>
            /// <item><description><para><b>AddressBookPortSeparated</b>: Duplicate, overlapping, or scattered port address books.</para>
            /// </description></item>
            /// <item><description><para><b>AddressBookDomainValid</b>: Domain address book validity check.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PolicyHitCountZero</para>
            /// </summary>
            [NameInMap("CheckName")]
            [Validation(Required=false)]
            public string CheckName { get; set; }

            /// <summary>
            /// <para>The rule description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dwd_mysql_lingwan_faxing_chat_config_di</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The timestamp of the last check. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1724982259</para>
            /// </summary>
            [NameInMap("LastCheckTime")]
            [Validation(Required=false)]
            public string LastCheckTime { get; set; }

            /// <summary>
            /// <para>The risk level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>High</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>The total number of policies.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PolicyTotalCount")]
            [Validation(Required=false)]
            public long? PolicyTotalCount { get; set; }

            /// <summary>
            /// <para>The assessment details of this ACL check record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Due to business offline or other reasons, the number of hits of the object policy in a period of time is 0.</para>
            /// </summary>
            [NameInMap("RecordAssessmentDetail")]
            [Validation(Required=false)]
            public string RecordAssessmentDetail { get; set; }

            /// <summary>
            /// <para>The ACL check task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task-c92d4544ef7b6a42</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>850A84D6************00090125EEB1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
