// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAclCheckResponseBody : TeaModel {
        /// <summary>
        /// <para>The check record.</para>
        /// </summary>
        [NameInMap("CheckRecord")]
        [Validation(Required=false)]
        public DescribeAclCheckResponseBodyCheckRecord CheckRecord { get; set; }
        public class DescribeAclCheckResponseBodyCheckRecord : TeaModel {
            /// <summary>
            /// <para>The total number of access control policies at the time of the check.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("AclTotalCount")]
            [Validation(Required=false)]
            public long? AclTotalCount { get; set; }

            /// <summary>
            /// <para>The ACL check results.</para>
            /// </summary>
            [NameInMap("Acls")]
            [Validation(Required=false)]
            public List<DescribeAclCheckResponseBodyCheckRecordAcls> Acls { get; set; }
            public class DescribeAclCheckResponseBodyCheckRecordAcls : TeaModel {
                /// <summary>
                /// <para>The ACL check result.</para>
                /// </summary>
                [NameInMap("Acl")]
                [Validation(Required=false)]
                public DescribeAclCheckResponseBodyCheckRecordAclsAcl Acl { get; set; }
                public class DescribeAclCheckResponseBodyCheckRecordAclsAcl : TeaModel {
                    /// <summary>
                    /// <para>The action performed on traffic that matches the access control policy. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>accept</b>: allow</para>
                    /// </description></item>
                    /// <item><description><para><b>drop</b>: deny</para>
                    /// </description></item>
                    /// <item><description><para><b>log</b>: monitor</para>
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
                    /// <para>The unique ID of the access control policy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>997b38e0-01fa-4db7-8d30-02ebf6fdb747</para>
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
                    /// <para>The addresses and their remarks.</para>
                    /// </summary>
                    [NameInMap("Addresses")]
                    [Validation(Required=false)]
                    public List<DescribeAclCheckResponseBodyCheckRecordAclsAclAddresses> Addresses { get; set; }
                    public class DescribeAclCheckResponseBodyCheckRecordAclsAclAddresses : TeaModel {
                        /// <summary>
                        /// <para>The address in the address book.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>192.0.XX.XX/32</para>
                        /// </summary>
                        [NameInMap("Address")]
                        [Validation(Required=false)]
                        public string Address { get; set; }

                        /// <summary>
                        /// <para>The remarks.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Reviewed</para>
                        /// </summary>
                        [NameInMap("Note")]
                        [Validation(Required=false)]
                        public string Note { get; set; }

                    }

                    /// <summary>
                    /// <para>The ID of the application that is used in the access control policy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>plugin_idp4_ciam</para>
                    /// </summary>
                    [NameInMap("ApplicationId")]
                    [Validation(Required=false)]
                    public string ApplicationId { get; set; }

                    /// <summary>
                    /// <para>The application type supported by the access control policy for the VPC firewall. We recommend that you use the ApplicationNameList parameter instead. Valid values:</para>
                    /// <list type="bullet">
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
                    /// <item><description><para><b>ANY</b>: All application types.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ANY</para>
                    /// </summary>
                    [NameInMap("ApplicationName")]
                    [Validation(Required=false)]
                    public string ApplicationName { get; set; }

                    /// <summary>
                    /// <para>The application types that are supported by the access control policy. Valid values:</para>
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
                    /// <item><description><para><b>ANY</b> (indicates all application types)</para>
                    /// </description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("ApplicationNameList")]
                    [Validation(Required=false)]
                    public List<string> ApplicationNameList { get; set; }

                    /// <summary>
                    /// <para>Indicates whether to automatically add the public IP addresses of new ECS instances that match the tags to the address book. New ECS instances include newly purchased instances with the specified tags and existing instances whose tags are modified to match.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AutoAddTagEcs")]
                    [Validation(Required=false)]
                    public int? AutoAddTagEcs { get; set; }

                    /// <summary>
                    /// <para>The time when the policy was created, provided as a UNIX timestamp in seconds.</para>
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
                    /// <para>The destination port that is used in the access control policy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>80/80</para>
                    /// </summary>
                    [NameInMap("DestPort")]
                    [Validation(Required=false)]
                    public string DestPort { get; set; }

                    /// <summary>
                    /// <para>The name of the destination port address book.</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>port</b>: Port</para>
                    /// </description></item>
                    /// <item><description><para><b>group</b>: Port address book</para>
                    /// </description></item>
                    /// </list>
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
                    /// <para>The destination address in the access control policy. The value of this parameter varies based on the value of DestinationType.</para>
                    /// <list type="bullet">
                    /// <item><description><para>If the value of DestinationType is<c>net</c>, the value of this parameter is a CIDR block. Example: 10.0.3.0/24.</para>
                    /// </description></item>
                    /// <item><description><para>If the value of DestinationType is<c>domain</c>, the value of this parameter is a domain name. Example: aliyun.</para>
                    /// </description></item>
                    /// <item><description><para>If the value of DestinationType is<c>group</c>, the value of this parameter is the name of an address book. Example: db_group.</para>
                    /// </description></item>
                    /// <item><description><para>If the value of DestinationType is<c>location</c>, the value of this parameter is a location. For more information about the location codes, see AddControlPolicy. Example: [&quot;BJ11&quot;, &quot;ZB&quot;].</para>
                    /// </description></item>
                    /// </list>
                    /// <remarks>
                    /// <para>If this parameter is omitted, all types of destination addresses are retrieved.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>kms.cn-shanghai.aliyuncs.com</para>
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
                    /// <item><description><para><b>ip</b>: an IP address book, which contains one or more CIDR blocks.</para>
                    /// </description></item>
                    /// <item><description><para><b>tag</b>: an ECS tag-based address book, which contains the public IP addresses of ECS instances that have specific tags.</para>
                    /// </description></item>
                    /// <item><description><para><b>domain</b>: a domain name address book, which contains one or more domain names.</para>
                    /// </description></item>
                    /// <item><description><para><b>threat</b>: a threat intelligence address book, which contains one or more malicious IP addresses or domain names.</para>
                    /// </description></item>
                    /// <item><description><para><b>backsrc</b>: a back-to-source address book, which contains the back-to-source IP addresses of one or more Anti-DDoS or WAF instances.</para>
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
                    /// <para>domain</para>
                    /// </summary>
                    [NameInMap("DestinationType")]
                    [Validation(Required=false)]
                    public string DestinationType { get; set; }

                    /// <summary>
                    /// <para>The direction of internet traffic. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>in</b>: inbound traffic</para>
                    /// </description></item>
                    /// <item><description><para><b>out</b>: outbound traffic</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>out</para>
                    /// </summary>
                    [NameInMap("Direction")]
                    [Validation(Required=false)]
                    public string Direction { get; set; }

                    /// <summary>
                    /// <para>The result of the DNS resolution.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>192.0.XX.XX</para>
                    /// </summary>
                    [NameInMap("DnsResult")]
                    [Validation(Required=false)]
                    public string DnsResult { get; set; }

                    /// <summary>
                    /// <para>The time of the DNS resolution, provided as a UNIX timestamp in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1579261141</para>
                    /// </summary>
                    [NameInMap("DnsResultTime")]
                    [Validation(Required=false)]
                    public long? DnsResultTime { get; set; }

                    /// <summary>
                    /// <para>The DNS resolution method of the domain name in the access control policy. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>0</b>: FQDN-based resolution</para>
                    /// </description></item>
                    /// <item><description><para><b>1</b>: DNS-based dynamic resolution</para>
                    /// </description></item>
                    /// <item><description><para><b>2</b>: FQDN-based and DNS-based dynamic resolution</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>FQDN</para>
                    /// </summary>
                    [NameInMap("DomainResolveType")]
                    [Validation(Required=false)]
                    public int? DomainResolveType { get; set; }

                    /// <summary>
                    /// <para>The end time of the policy validity period. This is a UNIX timestamp, accurate to the second. The time must be on the hour or half-hour and must be at least 30 minutes later than the start time.</para>
                    /// <remarks>
                    /// <para>This parameter is empty if RepeatType is set to Permanent. It is required if RepeatType is set to None, Daily, Weekly, or Monthly.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1758334822</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    /// <summary>
                    /// <para>The name of the address book.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Zhong Kui Open White List</para>
                    /// </summary>
                    [NameInMap("GroupName")]
                    [Validation(Required=false)]
                    public string GroupName { get; set; }

                    /// <summary>
                    /// <para>The type of the address book. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>ip</b>: IP address book</para>
                    /// </description></item>
                    /// <item><description><para><b>domain</b>: domain address book</para>
                    /// </description></item>
                    /// <item><description><para><b>port</b>: port address book</para>
                    /// </description></item>
                    /// <item><description><para><b>tag</b>: ECS tag-based address book</para>
                    /// </description></item>
                    /// <item><description><para><b>allCloud</b>: cloud service address book</para>
                    /// </description></item>
                    /// <item><description><para><b>threat</b>: threat intelligence address book</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ip</para>
                    /// </summary>
                    [NameInMap("GroupType")]
                    [Validation(Required=false)]
                    public string GroupType { get; set; }

                    /// <summary>
                    /// <para>The unique ID of the address book.</para>
                    /// <para>This ID is required for other operations, such as deleting the address book. You can obtain the ID by calling the <a href="https://help.aliyun.com/document_detail/138869.html">DescribeAddressBook</a> operation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>b91d86c3-2b52-4534-aae9-8d0339b12a48</para>
                    /// </summary>
                    [NameInMap("GroupUuid")]
                    [Validation(Required=false)]
                    public string GroupUuid { get; set; }

                    /// <summary>
                    /// <para>The time when the policy was last hit, provided as a UNIX timestamp in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1579261141</para>
                    /// </summary>
                    [NameInMap("HitLastTime")]
                    [Validation(Required=false)]
                    public long? HitLastTime { get; set; }

                    /// <summary>
                    /// <para>The hit count of the access control policy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("HitTimes")]
                    [Validation(Required=false)]
                    public long? HitTimes { get; set; }

                    /// <summary>
                    /// <para>The IP version. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>4</b>: IPv4</para>
                    /// </description></item>
                    /// <item><description><para><b>6</b>: IPv6</para>
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
                    /// <para>The time when the policy was last modified, provided as a UNIX timestamp in seconds.</para>
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
                    /// <para>ngw-2ze4w62zbdkwjmoqeokgl</para>
                    /// </summary>
                    [NameInMap("NatGatewayId")]
                    [Validation(Required=false)]
                    public string NatGatewayId { get; set; }

                    /// <summary>
                    /// <para>The priority of the access control policy.</para>
                    /// <para>The priority starts from 1. A smaller value indicates a higher priority.</para>
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
                    /// <item><description><para><b>TCP</b></para>
                    /// </description></item>
                    /// <item><description><para><b>UDP</b></para>
                    /// </description></item>
                    /// <item><description><para><b>ICMP</b></para>
                    /// </description></item>
                    /// <item><description><para><b>ANY</b>: All protocol types</para>
                    /// </description></item>
                    /// </list>
                    /// <remarks>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TCP</para>
                    /// </summary>
                    [NameInMap("Proto")]
                    [Validation(Required=false)]
                    public string Proto { get; set; }

                    /// <summary>
                    /// <para>The number of policies that reference this address book.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("ReferenceCount")]
                    [Validation(Required=false)]
                    public int? ReferenceCount { get; set; }

                    /// <summary>
                    /// <para>The status of the access control policy. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>true</b>: enabled</para>
                    /// </description></item>
                    /// <item><description><para><b>false</b>: disabled</para>
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
                    /// <para>The days of a week or month on which the policy recurs.</para>
                    /// <remarks>
                    /// <para>If RepeatType is set to Weekly, the valid values are 0 to 6. The week starts on Sunday.
                    /// If RepeatType is set to Monthly, the valid values are 1 to 31.</para>
                    /// </remarks>
                    /// </summary>
                    [NameInMap("RepeatDays")]
                    [Validation(Required=false)]
                    public List<long?> RepeatDays { get; set; }

                    /// <summary>
                    /// <para>The time when the policy stops to take effect. Example: 23:30. The time must be on the hour or half-hour and must be at least 30 minutes later than the recurrence start time.</para>
                    /// <remarks>
                    /// <para>This parameter is returned empty if RepeatType is set to Permanent or None. This parameter is required if RepeatType is set to Daily, Weekly, or Monthly. The time is in the HH:mm format. Examples: 08:00 and 23:30.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>23:30</para>
                    /// </summary>
                    [NameInMap("RepeatEndTime")]
                    [Validation(Required=false)]
                    public string RepeatEndTime { get; set; }

                    /// <summary>
                    /// <para>The time when the policy starts to take effect. Example: 08:00. The time must be on the hour or half-hour and must be at least 30 minutes earlier than the recurrence end time.</para>
                    /// <remarks>
                    /// <para>This parameter is returned empty if RepeatType is set to Permanent or None. This parameter is required if RepeatType is set to Daily, Weekly, or Monthly. The time is in the HH:mm format. Examples: 08:00 and 23:30.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>08:00</para>
                    /// </summary>
                    [NameInMap("RepeatStartTime")]
                    [Validation(Required=false)]
                    public string RepeatStartTime { get; set; }

                    /// <summary>
                    /// <para>The recurrence type of the policy. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>Permanent</b> (default): The policy is always valid.</para>
                    /// </description></item>
                    /// <item><description><para><b>None</b>: The policy is valid only once.</para>
                    /// </description></item>
                    /// <item><description><para><b>Daily</b>: The policy recurs daily.</para>
                    /// </description></item>
                    /// <item><description><para><b>Weekly</b>: The policy recurs weekly.</para>
                    /// </description></item>
                    /// <item><description><para><b>Monthly</b>: The policy recurs monthly.</para>
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
                    /// <para>The source address in the access control policy. The value of this parameter varies based on the value of SourceType.</para>
                    /// <list type="bullet">
                    /// <item><description><para>If <b>SourceType</b> is set to<c>net</c>, the value of this parameter is a CIDR block. Example: 192.0.XX.XX/24.</para>
                    /// </description></item>
                    /// <item><description><para>If <b>SourceType</b> is set to<c>group</c>, the value of this parameter is the name of a source address book. Example: db_group.</para>
                    /// </description></item>
                    /// <item><description><para>If <b>SourceType</b> is set to<c>location</c>, the value of this parameter is a location. For more information, see <a href="https://help.aliyun.com/document_detail/138867.html">AddControlPolicy</a>. Example: [&quot;BJ11&quot;, &quot;ZB&quot;].</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>172.28.7.167</para>
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
                    /// <item><description><para><b>ip</b>: An address book that contains one or more IP addresses or CIDR blocks.</para>
                    /// </description></item>
                    /// <item><description><para><b>tag</b>: An address book that contains the public IP addresses of ECS instances with specific tags.</para>
                    /// </description></item>
                    /// <item><description><para><b>domain</b>: A domain name address book, which contains one or more domain names.</para>
                    /// </description></item>
                    /// <item><description><para><b>threat</b>: a threat intelligence address book, which contains one or more malicious IP addresses or domain names.</para>
                    /// </description></item>
                    /// <item><description><para><b>backsrc</b>: a back-to-source address book, which contains the back-to-source IP addresses of one or more Anti-DDoS or WAF instances.</para>
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
                    /// <item><description><para><b>net</b>: a source CIDR block</para>
                    /// </description></item>
                    /// <item><description><para><b>group</b>: a source address book</para>
                    /// </description></item>
                    /// <item><description><para><b>location</b>: a source region</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>group</para>
                    /// </summary>
                    [NameInMap("SourceType")]
                    [Validation(Required=false)]
                    public string SourceType { get; set; }

                    /// <summary>
                    /// <para>The number of specification units that the policy consumes. The value is calculated by using the following formula: Number of source addresses × Number of destination addresses × Number of port ranges × Number of applications.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("SpreadCnt")]
                    [Validation(Required=false)]
                    public int? SpreadCnt { get; set; }

                    /// <summary>
                    /// <para>The start of the policy\&quot;s validity period, provided as a UNIX timestamp in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1730318400</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                    /// <summary>
                    /// <para>The ECS tags.</para>
                    /// </summary>
                    [NameInMap("TagList")]
                    [Validation(Required=false)]
                    public List<DescribeAclCheckResponseBodyCheckRecordAclsAclTagList> TagList { get; set; }
                    public class DescribeAclCheckResponseBodyCheckRecordAclsAclTagList : TeaModel {
                        /// <summary>
                        /// <para>The key of the ECS tag.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ss</para>
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
                    /// <para>The logical relationship among multiple ECS tags. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>and</b>: An ECS instance must have all the specified tags.</para>
                    /// </description></item>
                    /// <item><description><para><b>or</b>: An ECS instance must have one of the specified tags.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>or</para>
                    /// </summary>
                    [NameInMap("TagRelation")]
                    [Validation(Required=false)]
                    public string TagRelation { get; set; }

                    /// <summary>
                    /// <para>The instance ID of the VPC firewall.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vfw-925514970c2c4bcab222</para>
                    /// </summary>
                    [NameInMap("VpcFirewallId")]
                    [Validation(Required=false)]
                    public string VpcFirewallId { get; set; }

                }

                /// <summary>
                /// <para>The assessment details of the access control policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>No traffic hit policy.</para>
                /// </summary>
                [NameInMap("AclAssessmentDetail")]
                [Validation(Required=false)]
                public string AclAssessmentDetail { get; set; }

                /// <summary>
                /// <para>The status of the ACL check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Pending</para>
                /// </summary>
                [NameInMap("AclStatus")]
                [Validation(Required=false)]
                public string AclStatus { get; set; }

            }

            /// <summary>
            /// <para>The name of the ACL check.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PolicyHitCountZero</para>
            /// </summary>
            [NameInMap("CheckName")]
            [Validation(Required=false)]
            public string CheckName { get; set; }

            /// <summary>
            /// <para>The description of the ACL check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Due to business offline or other reasons, the number of hits of the object policy in a period of time is 0.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The time of the last check, provided as a UNIX timestamp in seconds.</para>
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
            /// <para>The assessment details of the ACL check.</para>
            /// 
            /// <b>Example:</b>
            /// <para>It is recommended to remove the invalid policy, while helping to save the specification.</para>
            /// </summary>
            [NameInMap("RecordAssessmentDetail")]
            [Validation(Required=false)]
            public string RecordAssessmentDetail { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
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
        /// <para>25E655B0-CAED-53D4-8054-F983126****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
