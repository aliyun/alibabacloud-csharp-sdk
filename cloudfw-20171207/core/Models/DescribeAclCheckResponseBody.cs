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
            /// <para>The total number of access control list (ACL) policies at the time of the check.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("AclTotalCount")]
            [Validation(Required=false)]
            public long? AclTotalCount { get; set; }

            /// <summary>
            /// <para>The list of ACL check results.</para>
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
                    /// <para>The action that Cloud Firewall performs on the traffic in the access control policy. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>accept</b>: allows the traffic.</description></item>
                    /// <item><description><b>drop</b>: blocks the traffic.</description></item>
                    /// <item><description><b>log</b>: monitors the traffic.</description></item>
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
                    /// <para>The address information in the address book.</para>
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
                    /// <para>The list of addresses and description notes.</para>
                    /// </summary>
                    [NameInMap("Addresses")]
                    [Validation(Required=false)]
                    public List<DescribeAclCheckResponseBodyCheckRecordAclsAclAddresses> Addresses { get; set; }
                    public class DescribeAclCheckResponseBodyCheckRecordAclsAclAddresses : TeaModel {
                        /// <summary>
                        /// <para>The address information in the address book.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>192.0.XX.XX/32</para>
                        /// </summary>
                        [NameInMap("Address")]
                        [Validation(Required=false)]
                        public string Address { get; set; }

                        /// <summary>
                        /// <para>The description note.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Reviewed</para>
                        /// </summary>
                        [NameInMap("Note")]
                        [Validation(Required=false)]
                        public string Note { get; set; }

                    }

                    /// <summary>
                    /// <para>The ID of the application for the traffic in the access control policy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>plugin_idp4_ciam</para>
                    /// </summary>
                    [NameInMap("ApplicationId")]
                    [Validation(Required=false)]
                    public string ApplicationId { get; set; }

                    /// <summary>
                    /// <para>The application types supported by the access control policies of VPC border firewalls. Use ApplicationNameList. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>HTTP</b></description></item>
                    /// <item><description><b>HTTPS</b></description></item>
                    /// <item><description><b>MySQL</b></description></item>
                    /// <item><description><b>SMTP</b></description></item>
                    /// <item><description><b>SMTPS</b></description></item>
                    /// <item><description><b>RDP</b></description></item>
                    /// <item><description><b>VNC</b></description></item>
                    /// <item><description><b>SSH</b></description></item>
                    /// <item><description><b>Redis</b></description></item>
                    /// <item><description><b>MQTT</b></description></item>
                    /// <item><description><b>MongoDB</b></description></item>
                    /// <item><description><b>Memcache</b></description></item>
                    /// <item><description><b>SSL</b></description></item>
                    /// <item><description><b>ANY</b>: all application types.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ANY</para>
                    /// </summary>
                    [NameInMap("ApplicationName")]
                    [Validation(Required=false)]
                    public string ApplicationName { get; set; }

                    /// <summary>
                    /// <para>The list of application types supported by the access control policy. Valid values:</para>
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
                    /// <item><description><b>ANY</b>: all application types.</description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("ApplicationNameList")]
                    [Validation(Required=false)]
                    public List<string> ApplicationNameList { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to automatically add the public IP addresses of newly matched ECS instances to the address book. Newly matched ECS instances refer to newly purchased ECS instances with tags configured or ECS instances with modified tags.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AutoAddTagEcs")]
                    [Validation(Required=false)]
                    public int? AutoAddTagEcs { get; set; }

                    /// <summary>
                    /// <para>The time when the policy was created. The value is a UNIX timestamp measured in seconds.</para>
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
                    /// <para>The destination port of the traffic in the access control policy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>80/80</para>
                    /// </summary>
                    [NameInMap("DestPort")]
                    [Validation(Required=false)]
                    public string DestPort { get; set; }

                    /// <summary>
                    /// <para>The type of the destination port for traffic access in the access control policy. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>port</b>: port.</description></item>
                    /// <item><description><b>group</b>: port address book.</description></item>
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
                    /// <para>The type of the destination port for traffic access in the access control policy. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>port</b>: port.</description></item>
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
                    /// <para>The destination address in the access control policy. Fuzzy match is supported. The value varies based on the destination type (DestinationType).</para>
                    /// <list type="bullet">
                    /// <item><description><para>If DestinationType is set to <c>net</c>, the destination address is a CIDR block. Example: 10.0.3.0/24.</para>
                    /// </description></item>
                    /// <item><description><para>If DestinationType is set to <c>domain</c>, the destination address is a domain name. Example: aliyun.</para>
                    /// </description></item>
                    /// <item><description><para>If DestinationType is set to <c>group</c>, the destination address is the name of an address book. Example: db_group.</para>
                    /// </description></item>
                    /// <item><description><para>If DestinationType is set to <c>location</c>, the destination address is an area name. For more information about area positional encoding, see AddControlPolicy. Example: [&quot;BJ11&quot;, &quot;ZB&quot;].</para>
                    /// </description></item>
                    /// </list>
                    /// <remarks>
                    /// <para>If you do not specify this parameter, destination addresses of all types are queried.</para>
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
                    /// <para>The type of the destination address book in the access control policy. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>ip</b>: IP address book, which contains one or more CIDR blocks.</para>
                    /// </description></item>
                    /// <item><description><para><b>tag</b>: ECS tag-based address book, which contains the IP addresses of one or more ECS tags.</para>
                    /// </description></item>
                    /// <item><description><para><b>domain</b>: domain name address book, which contains one or more domain names.</para>
                    /// </description></item>
                    /// <item><description><para><b>threat</b>: threat intelligence address book, which contains one or more malicious IP addresses or domain names.</para>
                    /// </description></item>
                    /// <item><description><para><b>backsrc</b>: back-to-origin address book, which contains the back-to-origin IP addresses of one or more Anti-DDoS or WAF instances.</para>
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
                    /// <item><description><b>net</b>: destination CIDR block.</description></item>
                    /// <item><description><b>group</b>: destination address book.</description></item>
                    /// <item><description><b>domain</b>: destination domain name.</description></item>
                    /// <item><description><b>location</b>: destination location.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>domain</para>
                    /// </summary>
                    [NameInMap("DestinationType")]
                    [Validation(Required=false)]
                    public string DestinationType { get; set; }

                    /// <summary>
                    /// <para>The traffic direction on the Internet. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>in</b>: access control for inbound traffic.</description></item>
                    /// <item><description><b>out</b>: access control for outbound traffic.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>out</para>
                    /// </summary>
                    [NameInMap("Direction")]
                    [Validation(Required=false)]
                    public string Direction { get; set; }

                    /// <summary>
                    /// <para>The DNS resolution result.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>192.0.XX.XX</para>
                    /// </summary>
                    [NameInMap("DnsResult")]
                    [Validation(Required=false)]
                    public string DnsResult { get; set; }

                    /// <summary>
                    /// <para>The timestamp of the DNS resolution. The value is a UNIX timestamp measured in seconds.</para>
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
                    /// <item><description><b>FQDN_AND_DNS</b>: FQDN- and DNS-based dynamic resolution.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>FQDN</para>
                    /// </summary>
                    [NameInMap("DomainResolveType")]
                    [Validation(Required=false)]
                    public int? DomainResolveType { get; set; }

                    /// <summary>
                    /// <para>The end time of the policy validity period for the access control policy. The value is a UNIX timestamp measured in seconds. The time must be on the hour or half-hour, and must be at least 30 minutes later than the start time.</para>
                    /// <remarks>
                    /// <para>If RepeatType is set to Permanent, EndTime is empty. If RepeatType is set to None, Daily, Weekly, or Monthly, EndTime must be specified.</para>
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
                    /// <item><description><para><b>ip</b>: IP address book.</para>
                    /// </description></item>
                    /// <item><description><para><b>domain</b>: domain name address book.</para>
                    /// </description></item>
                    /// <item><description><para><b>port</b>: port address book.</para>
                    /// </description></item>
                    /// <item><description><para><b>tag</b>: ECS tag-based address book.</para>
                    /// </description></item>
                    /// <item><description><para><b>allCloud</b>: cloud service address book.</para>
                    /// </description></item>
                    /// <item><description><para><b>threat</b>: threat intelligence address book.</para>
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
                    /// <para>To delete an address book for access control, you must provide the unique ID of the address book. You can call the <a href="https://help.aliyun.com/document_detail/138869.html">DescribeAddressBook</a> operation to obtain the ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>b91d86c3-2b52-4534-aae9-8d0339b12a48</para>
                    /// </summary>
                    [NameInMap("GroupUuid")]
                    [Validation(Required=false)]
                    public string GroupUuid { get; set; }

                    /// <summary>
                    /// <para>The UNIX timestamp of the latest hit. The value is a UNIX timestamp measured in seconds.</para>
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
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("HitTimes")]
                    [Validation(Required=false)]
                    public long? HitTimes { get; set; }

                    /// <summary>
                    /// <para>The IP address version. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>4</b>: IPv4.</description></item>
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
                    /// <para>The time when the policy was last modified. The value is a UNIX timestamp measured in seconds.</para>
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
                    /// <para>The priority starts from 1 and increases in ascending order. A smaller value indicates a higher priority.</para>
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
                    /// <item><description><b>TCP</b></description></item>
                    /// <item><description><b>UDP</b></description></item>
                    /// <item><description><b>ICMP</b></description></item>
                    /// <item><description><b>ANY</b>: all protocol types.<remarks>
                    /// <para>If you do not specify this parameter, all protocol types are queried.</para>
                    /// </remarks>
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
                    /// <para>The number of times the address book is referenced.</para>
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
                    /// <para>The recurrence days of the policy validity period for the access control policy.</para>
                    /// <remarks>
                    /// <para>If RepeatType is set to Weekly, valid values are 0 to 6. A week starts on Sunday.
                    /// If RepeatType is set to Monthly, valid values are 1 to 31.</para>
                    /// </remarks>
                    /// </summary>
                    [NameInMap("RepeatDays")]
                    [Validation(Required=false)]
                    public List<long?> RepeatDays { get; set; }

                    /// <summary>
                    /// <para>The recurrence end time of the policy validity period for the access control policy. Example: 23:30. The time must be on the hour or half-hour, and must be at least 30 minutes later than the recurrence start time.</para>
                    /// <remarks>
                    /// <para>If RepeatType is set to Permanent or None, RepeatEndTime is empty. If RepeatType is set to Daily, Weekly, or Monthly, RepeatEndTime must be specified.
                    /// The time is in the HH:mm format (24-hour clock). Examples: 08:00 and 23:30.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>23:30</para>
                    /// </summary>
                    [NameInMap("RepeatEndTime")]
                    [Validation(Required=false)]
                    public string RepeatEndTime { get; set; }

                    /// <summary>
                    /// <para>The recurrence start time of the policy validity period for the access control policy. Example: 08:00. The time must be on the hour or half-hour, and must be at least 30 minutes earlier than the recurrence end time.</para>
                    /// <remarks>
                    /// <para>If RepeatType is set to Permanent or None, RepeatStartTime is empty. If RepeatType is set to Daily, Weekly, or Monthly, RepeatStartTime must be specified.
                    /// The time is in the HH:mm format (24-hour clock). Examples: 08:00 and 23:30.</para>
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
                    /// <item><description><b>Permanent</b> (default): always.</description></item>
                    /// <item><description><b>None</b>: specified single time.</description></item>
                    /// <item><description><b>Daily</b>: every day.</description></item>
                    /// <item><description><b>Weekly</b>: every week.</description></item>
                    /// <item><description><b>Monthly</b>: every month.</description></item>
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
                    /// <item><description>If <b>SourceType</b> is set to <c>group</c>, the source address is the name of the source address book. Example: db_group.</description></item>
                    /// <item><description>If <b>SourceType</b> is set to <c>location</c>, the source address is an area. For more information about area positional encoding, see <a href="https://help.aliyun.com/document_detail/138867.html">AddControlPolicy</a>. Example: [&quot;BJ11&quot;, &quot;ZB&quot;].</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>172.28.7.167</para>
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
                    /// <item><description><para><b>domain</b>: domain name address book, which contains one or more domain names.</para>
                    /// </description></item>
                    /// <item><description><para><b>threat</b>: threat intelligence address book, which contains one or more malicious IP addresses or domain names.</para>
                    /// </description></item>
                    /// <item><description><para><b>backsrc</b>: back-to-origin address book, which contains the back-to-origin IP addresses of one or more Anti-DDoS or WAF instances.</para>
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
                    /// <item><description><b>net</b>: source CIDR block.</description></item>
                    /// <item><description><b>group</b>: source address book.</description></item>
                    /// <item><description><b>location</b>: source location.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>group</para>
                    /// </summary>
                    [NameInMap("SourceType")]
                    [Validation(Required=false)]
                    public string SourceType { get; set; }

                    /// <summary>
                    /// <para>The number of access control policy quotas consumed. This value is the sum of the quotas consumed by each policy.
                    /// Number of quotas consumed by a single policy = Number of source addresses (CIDR blocks or locations) × Number of destination addresses (CIDR blocks, locations, or domain names) × Number of port ranges × Number of applications.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("SpreadCnt")]
                    [Validation(Required=false)]
                    public int? SpreadCnt { get; set; }

                    /// <summary>
                    /// <para>The start time of the query. The value is a UNIX timestamp measured in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1730318400</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                    /// <summary>
                    /// <para>The list of ECS tags.</para>
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
                    /// <para>The relationship between multiple ECS labels. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>and</b>: The logical AND relation is used. The public IP addresses of Elastic Compute Service (ECS) instances that match all specified labels are added to the address book.</para>
                    /// </description></item>
                    /// <item><description><para><b>or</b>: The logical OR relation is used. The public IP addresses of Elastic Compute Service (ECS) instances that match any of the specified labels are added to the address book.</para>
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
                    /// <para>The instance ID of the VPC border firewall.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vfw-925514970c2c4bcab222</para>
                    /// </summary>
                    [NameInMap("VpcFirewallId")]
                    [Validation(Required=false)]
                    public string VpcFirewallId { get; set; }

                }

                /// <summary>
                /// <para>The assessment details of the ACL policy.</para>
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
