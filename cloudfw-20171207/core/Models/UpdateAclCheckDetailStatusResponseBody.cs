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
            /// <para>A list of ACL check results.</para>
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
                    /// <para>The action performed on traffic that matches the policy. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>accept</b>: Allows the traffic.</para>
                    /// </description></item>
                    /// <item><description><para><b>drop</b>: Denies the traffic.</para>
                    /// </description></item>
                    /// <item><description><para><b>log</b>: Monitors the traffic.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>log</para>
                    /// </summary>
                    [NameInMap("AclAction")]
                    [Validation(Required=false)]
                    public string AclAction { get; set; }

                    /// <summary>
                    /// <para>The UUID of the policy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1e8ed1b2-cebc-4b95-a9cc-0cb7ce2c0c2c</para>
                    /// </summary>
                    [NameInMap("AclUuid")]
                    [Validation(Required=false)]
                    public string AclUuid { get; set; }

                    /// <summary>
                    /// <para>A list of addresses in the address book.</para>
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
                    /// <para>The application ID for traffic in the policy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HTTP</para>
                    /// </summary>
                    [NameInMap("ApplicationId")]
                    [Validation(Required=false)]
                    public string ApplicationId { get; set; }

                    /// <summary>
                    /// <para>The application types supported by the access control policy. Valid values:</para>
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
                    /// </list>
                    /// <remarks>
                    /// <para>The available application types depend on the <c>Proto</c> value. When <c>Proto</c> is <c>TCP</c>, all the above application types are supported. If both <c>ApplicationName</c> and <c>ApplicationNameList</c> are specified, <c>ApplicationNameList</c> takes precedence.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ANY</para>
                    /// </summary>
                    [NameInMap("ApplicationName")]
                    [Validation(Required=false)]
                    public string ApplicationName { get; set; }

                    /// <summary>
                    /// <para>A list of application types that are supported by the policy.</para>
                    /// </summary>
                    [NameInMap("ApplicationNameList")]
                    [Validation(Required=false)]
                    public List<string> ApplicationNameList { get; set; }

                    /// <summary>
                    /// <para>Indicates if public IP addresses from new ECS instances with matching tags are automatically added to the address book. This applies to both newly purchased instances and existing instances whose tags are updated to match.</para>
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
                    /// <para>The description of the policy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test_policy</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The destination port for traffic in the policy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>22/22</para>
                    /// </summary>
                    [NameInMap("DestPort")]
                    [Validation(Required=false)]
                    public string DestPort { get; set; }

                    /// <summary>
                    /// <para>The type of the destination port for traffic in the policy. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>port</b>: A single port or a port range.</para>
                    /// </description></item>
                    /// <item><description><para><b>group</b>: A port address book.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>port</para>
                    /// </summary>
                    [NameInMap("DestPortGroup")]
                    [Validation(Required=false)]
                    public string DestPortGroup { get; set; }

                    /// <summary>
                    /// <para>A list of ports in the destination port address book.</para>
                    /// </summary>
                    [NameInMap("DestPortGroupPorts")]
                    [Validation(Required=false)]
                    public List<string> DestPortGroupPorts { get; set; }

                    /// <summary>
                    /// <para>The type of the destination port in the policy. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>port</b>: A single port or a port range.</para>
                    /// </description></item>
                    /// <item><description><para><b>group</b>: A port address book.</para>
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
                    /// <para>The destination address in the access control policy. This parameter supports fuzzy search. The value of this parameter varies based on the value of <c>DestinationType</c>.</para>
                    /// <list type="bullet">
                    /// <item><description><para>If <c>DestinationType</c> is set to<c>net</c>, the value of this parameter is a CIDR block. Example: 10.0.3.0/24.</para>
                    /// </description></item>
                    /// <item><description><para>If <c>DestinationType</c> is set to<c>domain</c>, the value of this parameter is a domain name. Example: aliyun.</para>
                    /// </description></item>
                    /// <item><description><para>If <c>DestinationType</c> is set to<c>group</c>, the value of this parameter is the name of an address book. Example: db_group.</para>
                    /// </description></item>
                    /// <item><description><para>If <c>DestinationType</c> is set to<c>location</c>, the value of this parameter is a location. For more information about location codes, see AddControlPolicy. Example: [&quot;BJ11&quot;, &quot;ZB&quot;].</para>
                    /// </description></item>
                    /// </list>
                    /// <remarks>
                    /// <para>If this parameter is not specified, all types of destination addresses are queried.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>kms.cn-shanghai.aliyuncs.com</para>
                    /// </summary>
                    [NameInMap("Destination")]
                    [Validation(Required=false)]
                    public string Destination { get; set; }

                    /// <summary>
                    /// <para>A list of CIDR blocks in the destination address book of the policy.</para>
                    /// </summary>
                    [NameInMap("DestinationGroupCidrs")]
                    [Validation(Required=false)]
                    public List<string> DestinationGroupCidrs { get; set; }

                    /// <summary>
                    /// <para>The type of the destination address book in the policy. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>ip</b>: An address book containing IP addresses or CIDR blocks.</para>
                    /// </description></item>
                    /// <item><description><para><b>tag</b>: An address book containing the IP addresses of ECS instances that match specified tags.</para>
                    /// </description></item>
                    /// <item><description><para><b>domain</b>: An address book containing one or more domain names.</para>
                    /// </description></item>
                    /// <item><description><para><b>threat</b>: A threat intelligence address book containing malicious IP addresses or domain names.</para>
                    /// </description></item>
                    /// <item><description><para><b>backsrc</b>: A back-to-source address book containing the back-to-source addresses of Anti-DDoS or WAF instances.</para>
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
                    /// <para>The type of the destination address in the policy.</para>
                    /// <para>Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>net</b>: A destination CIDR block.</para>
                    /// </description></item>
                    /// <item><description><para><b>group</b>: A destination address book.</para>
                    /// </description></item>
                    /// <item><description><para><b>domain</b>: A destination domain name.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>group</para>
                    /// </summary>
                    [NameInMap("DestinationType")]
                    [Validation(Required=false)]
                    public string DestinationType { get; set; }

                    /// <summary>
                    /// <para>The traffic direction for the access control policy.</para>
                    /// <para>Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>in</b>: Inbound traffic.</para>
                    /// </description></item>
                    /// <item><description><para><b>out</b>: Outbound traffic.</para>
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
                    /// <para>The result of the DNS resolution.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>192.168.0.1/32</para>
                    /// </summary>
                    [NameInMap("DnsResult")]
                    [Validation(Required=false)]
                    public string DnsResult { get; set; }

                    /// <summary>
                    /// <para>The UNIX timestamp, in seconds, of the DNS resolution.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1579261141</para>
                    /// </summary>
                    [NameInMap("DnsResultTime")]
                    [Validation(Required=false)]
                    public long? DnsResultTime { get; set; }

                    /// <summary>
                    /// <para>The domain name resolution method of the policy. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>FQDN</b>: FQDN-based resolution.</para>
                    /// </description></item>
                    /// <item><description><para><b>DNS</b>: Dynamic DNS-based resolution.</para>
                    /// </description></item>
                    /// <item><description><para><b>FQDN_AND_DNS</b>: A combination of FQDN and dynamic DNS-based resolution.</para>
                    /// </description></item>
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
                    /// <item><description><para><b>ip</b>: An IP address book.</para>
                    /// </description></item>
                    /// <item><description><para><b>domain</b>: A domain address book.</para>
                    /// </description></item>
                    /// <item><description><para><b>port</b>: A port address book.</para>
                    /// </description></item>
                    /// <item><description><para><b>tag</b>: An ECS tag-based address book.</para>
                    /// </description></item>
                    /// <item><description><para><b>allCloud</b>: A cloud service address book.</para>
                    /// </description></item>
                    /// <item><description><para><b>threat</b>: A threat intelligence address book.</para>
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
                    /// <para>The UUID of the address book.</para>
                    /// <remarks>
                    /// <para>For more information, see <a href="~~DescribeAddressBook~~">DescribeAddressBook</a>.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5a96a798-9b73-47f7-831e-1d7aa3c987a9</para>
                    /// </summary>
                    [NameInMap("GroupUuid")]
                    [Validation(Required=false)]
                    public string GroupUuid { get; set; }

                    /// <summary>
                    /// <para>The UNIX timestamp, in seconds, of the last policy hit.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1579261141</para>
                    /// </summary>
                    [NameInMap("HitLastTime")]
                    [Validation(Required=false)]
                    public long? HitLastTime { get; set; }

                    /// <summary>
                    /// <para>The hit count of the policy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("HitTimes")]
                    [Validation(Required=false)]
                    public long? HitTimes { get; set; }

                    /// <summary>
                    /// <para>The IP version of the asset that is protected by Cloud Firewall. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>4</b>: IPv4 (default).</para>
                    /// </description></item>
                    /// <item><description><para><b>6</b>: IPv6.</para>
                    /// </description></item>
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
                    /// <para>The ID of the NAT Gateway.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ngw-gw85zno51npz7lgc04z89</para>
                    /// </summary>
                    [NameInMap("NatGatewayId")]
                    [Validation(Required=false)]
                    public string NatGatewayId { get; set; }

                    /// <summary>
                    /// <para>The priority of the access control policy.</para>
                    /// <para>The priority value starts from 1. A smaller value indicates a higher priority.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>desc</para>
                    /// </summary>
                    [NameInMap("Order")]
                    [Validation(Required=false)]
                    public int? Order { get; set; }

                    /// <summary>
                    /// <para>The protocol type of traffic in the access control policy. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>TCP</b></para>
                    /// </description></item>
                    /// <item><description><para><b>UDP</b></para>
                    /// </description></item>
                    /// <item><description><para><b>ICMP</b></para>
                    /// </description></item>
                    /// <item><description><para><b>ANY</b>: All protocol types.</para>
                    /// </description></item>
                    /// </list>
                    /// <remarks>
                    /// <para>If this parameter is not specified, all protocol types are queried.</para>
                    /// </remarks>
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
                    /// <para>Indicates whether the policy is enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>true</b>: The policy is enabled.</para>
                    /// </description></item>
                    /// <item><description><para><b>false</b>: The policy is disabled.</para>
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
                    /// <para>An array of the days of a week or month on which the policy recurs.</para>
                    /// <list type="bullet">
                    /// <item><description><para>If <c>RepeatType</c> is set to<c>Permanent</c>,<c>None</c>, or<c>Daily</c>, <c>RepeatDays</c> is an empty array.
                    /// Example: []</para>
                    /// </description></item>
                    /// <item><description><para>If <c>RepeatType</c> is set to <c>Weekly</c>, <c>RepeatDays</c> cannot be empty.
                    /// Example: [0, 6]</para>
                    /// </description></item>
                    /// </list>
                    /// <remarks>
                    /// <para>If <c>RepeatType</c> is set to <c>Weekly</c>, <c>RepeatDays</c> cannot contain duplicate values.</para>
                    /// </remarks>
                    /// <list type="bullet">
                    /// <item><description>If <c>RepeatType</c> is set to<c>Monthly</c>, <c>RepeatDays</c> cannot be empty.
                    /// Example: [1, 31]</description></item>
                    /// </list>
                    /// <remarks>
                    /// <para>If <c>RepeatType</c> is set to <c>Monthly</c>, <c>RepeatDays</c> cannot contain duplicate values.</para>
                    /// </remarks>
                    /// </summary>
                    [NameInMap("RepeatDays")]
                    [Validation(Required=false)]
                    public List<long?> RepeatDays { get; set; }

                    /// <summary>
                    /// <para>The recurrence end time in HH:mm format. The time must be on the hour or half-hour and at least 30 minutes after the start time.</para>
                    /// <remarks>
                    /// <para>This parameter is returned only if <c>RepeatType</c> is <c>Daily</c>, <c>Weekly</c>, or <c>Monthly</c>.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>23:30</para>
                    /// </summary>
                    [NameInMap("RepeatEndTime")]
                    [Validation(Required=false)]
                    public string RepeatEndTime { get; set; }

                    /// <summary>
                    /// <para>The recurrence start time in HH:mm format. The time must be on the hour or half-hour and at least 30 minutes before the end time.</para>
                    /// <remarks>
                    /// <para>This parameter is returned only if <c>RepeatType</c> is <c>Daily</c>, <c>Weekly</c>, or <c>Monthly</c>.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>08:00</para>
                    /// </summary>
                    [NameInMap("RepeatStartTime")]
                    [Validation(Required=false)]
                    public string RepeatStartTime { get; set; }

                    /// <summary>
                    /// <para>The recurrence type for the validity period of the policy. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>Permanent</b>: Always.</para>
                    /// </description></item>
                    /// <item><description><para><b>None</b>: A single occurrence.</para>
                    /// </description></item>
                    /// <item><description><para><b>Daily</b>: Daily.</para>
                    /// </description></item>
                    /// <item><description><para><b>Weekly</b>: Weekly.</para>
                    /// </description></item>
                    /// <item><description><para><b>Monthly</b>: Monthly.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>None</para>
                    /// </summary>
                    [NameInMap("RepeatType")]
                    [Validation(Required=false)]
                    public string RepeatType { get; set; }

                    /// <summary>
                    /// <para>The source address in the policy.</para>
                    /// <para>Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para>If <b>SourceType</b> is set to<c>net</c>, the value of <c>Source</c> is a source CIDR block.</para>
                    /// <para>Example: 10.2.4.0/24</para>
                    /// </description></item>
                    /// <item><description><para>If <b>SourceType</b> is set to<c>group</c>, the value of <c>Source</c> is the name of a source address book.</para>
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
                    /// <para>A list of CIDR blocks in the source address book of the policy.</para>
                    /// </summary>
                    [NameInMap("SourceGroupCidrs")]
                    [Validation(Required=false)]
                    public List<string> SourceGroupCidrs { get; set; }

                    /// <summary>
                    /// <para>The type of the source address book in the policy. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>ip</b>: An address book containing IP addresses or CIDR blocks.</para>
                    /// </description></item>
                    /// <item><description><para><b>tag</b>: An address book containing the IP addresses of ECS instances that match specified tags.</para>
                    /// </description></item>
                    /// <item><description><para><b>domain</b>: An address book containing one or more domain names.</para>
                    /// </description></item>
                    /// <item><description><para><b>threat</b>: A threat intelligence address book containing malicious IP addresses or domain names.</para>
                    /// </description></item>
                    /// <item><description><para><b>backsrc</b>: A back-to-source address book containing the back-to-source addresses of Anti-DDoS or WAF instances.</para>
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
                    /// <para>The type of the source address in the policy. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>net</b>: A source CIDR block.</para>
                    /// </description></item>
                    /// <item><description><para><b>group</b>: A source address book.</para>
                    /// </description></item>
                    /// <item><description><para><b>location</b>: A source region.</para>
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
                    /// <para>The number of rule entries that the policy consumes. The number of entries that a single policy consumes is calculated by using the following formula: Number of source CIDR blocks × Number of destination addresses (CIDR blocks, locations, or domain names) × Number of applications × Number of port ranges.</para>
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
                    /// <para>A list of ECS tags.</para>
                    /// </summary>
                    [NameInMap("TagList")]
                    [Validation(Required=false)]
                    public List<UpdateAclCheckDetailStatusResponseBodyCheckRecordAclsAclTagList> TagList { get; set; }
                    public class UpdateAclCheckDetailStatusResponseBodyCheckRecordAclsAclTagList : TeaModel {
                        /// <summary>
                        /// <para>The key of the ECS tag.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>produce</para>
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// <para>The value of the ECS tag.</para>
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
                /// <para>The assessment details of the policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>No traffic hit policy.</para>
                /// </summary>
                [NameInMap("AclAssessmentDetail")]
                [Validation(Required=false)]
                public string AclAssessmentDetail { get; set; }

                /// <summary>
                /// <para>The status of the policy check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>configuring</para>
                /// </summary>
                [NameInMap("AclStatus")]
                [Validation(Required=false)]
                public string AclStatus { get; set; }

            }

            /// <summary>
            /// <para>The name of the ACL check. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>PolicyHitCountZero</b>: The policy has no traffic hits.</para>
            /// </description></item>
            /// <item><description><para><b>PolicySourceDestinationSame</b>: The source and destination are the same, rendering the policy invalid.</para>
            /// </description></item>
            /// <item><description><para><b>PolicyDuplicate</b>: The policy is duplicate or redundant.</para>
            /// </description></item>
            /// <item><description><para><b>PolicyConflict</b>: The policy conflicts with business requirements.</para>
            /// </description></item>
            /// <item><description><para><b>DefaultPolicyNotDeny</b>: The default policy is not a Deny All policy, which is recommended for whitelist mechanisms.</para>
            /// </description></item>
            /// <item><description><para><b>PolicyPortHighRisk</b>: The policy allows traffic on high-risk ports.</para>
            /// </description></item>
            /// <item><description><para><b>PolicyTooLoose</b>: The policy is overly permissive or too broad.</para>
            /// </description></item>
            /// <item><description><para><b>AddressBookIpSeparated</b>: The IP address books contain duplicate, overlapping, or scattered entries.</para>
            /// </description></item>
            /// <item><description><para><b>AddressBookPortSeparated</b>: The port address books contain duplicate, overlapping, or scattered entries.</para>
            /// </description></item>
            /// <item><description><para><b>AddressBookDomainValid</b>: The domain name address book contains invalid entries.</para>
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
            /// <para>The description of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dwd_mysql_lingwan_faxing_chat_config_di</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The UNIX timestamp, in seconds, of the last check.</para>
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
            /// <para>The assessment details of the check.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Due to business offline or other reasons, the number of hits of the object policy in a period of time is 0.</para>
            /// </summary>
            [NameInMap("RecordAssessmentDetail")]
            [Validation(Required=false)]
            public string RecordAssessmentDetail { get; set; }

            /// <summary>
            /// <para>The ID of the ACL check task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task-c92d4544ef7b6a42</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>850A84D6************00090125EEB1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
