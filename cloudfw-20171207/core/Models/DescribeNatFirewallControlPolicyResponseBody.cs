// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeNatFirewallControlPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the access control policies for the NAT firewall.</para>
        /// </summary>
        [NameInMap("Policys")]
        [Validation(Required=false)]
        public List<DescribeNatFirewallControlPolicyResponseBodyPolicys> Policys { get; set; }
        public class DescribeNatFirewallControlPolicyResponseBodyPolicys : TeaModel {
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
            /// <para>01281255-d220-4db1-8f4f-c4df221a****</para>
            /// </summary>
            [NameInMap("AclUuid")]
            [Validation(Required=false)]
            public string AclUuid { get; set; }

            /// <summary>
            /// <para>The application names. Multiple applications are supported.</para>
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
            /// <para>test-description</para>
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
            /// <para>The destination address in the access control policy. The value of this parameter varies based on the value of the DestinationType parameter. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>If <b>DestinationType</b> is <b>net</b>, the value of this parameter is a CIDR block. Example: 192.0.XX.XX/24.</para>
            /// </description></item>
            /// <item><description><para>If <b>DestinationType</b> is <b>domain</b>, the value of this parameter is a domain name. Example: aliyuncs.com.</para>
            /// </description></item>
            /// <item><description><para>If <b>DestinationType</b> is <b>group</b>, the value of this parameter is the name of an address book. Example: db_group.</para>
            /// </description></item>
            /// <item><description><para>If <b>DestinationType</b> is <b>location</b>, the value of this parameter is a region name. For more information, see <a href="https://help.aliyun.com/document_detail/138867.html">AddControlPolicy</a>. Example: [&quot;BJ11&quot;, &quot;ZB&quot;].</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>x.x.x.x/32</para>
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
            /// <item><description><para><b>ip</b>: an IP address book that contains one or more IP address CIDR blocks.</para>
            /// </description></item>
            /// <item><description><para><b>domain</b>: a domain name address book that contains one or more domain names.</para>
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
            /// <para>The DNS resolution result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>111.0.XX.XX,112.0.XX.XX</para>
            /// </summary>
            [NameInMap("DnsResult")]
            [Validation(Required=false)]
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
            /// <para>The domain name resolution method of the access control policy. By default, this feature is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: FQDN-based</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: DNS-based dynamic resolution</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: FQDN- and DNS-based dynamic resolution</para>
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
            /// <para>The end time of the policy validity period. The value is a UNIX timestamp. Unit: seconds. The time must be on the hour or half hour, and at least 30 minutes later than the start time.</para>
            /// <remarks>
            /// <para>If RepeatType is set to Permanent, this parameter is empty. If RepeatType is set to None, Daily, Weekly, or Monthly, you must set this parameter.</para>
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
            /// <para>ngw-xxxxxx</para>
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
            /// <para>The status of the access control policy. By default, an access control policy is enabled after it is created. Valid values:</para>
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
            /// <para>The days of the week or month for the policy to repeat.</para>
            /// <list type="bullet">
            /// <item><description><para>If RepeatType is set to <c>Permanent</c>, <c>None</c>, or <c>Daily</c>, this parameter is an empty set.
            /// Example: []</para>
            /// </description></item>
            /// <item><description><para>If RepeatType is set to Weekly, this parameter cannot be empty.
            /// Example: [0, 6]</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>If RepeatType is set to Weekly, the days in RepeatDays cannot be repeated.</para>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>If RepeatType is set to <c>Monthly</c>, this parameter cannot be empty.
            /// Example: [1, 31]</description></item>
            /// </list>
            /// <remarks>
            /// <para>If RepeatType is set to Monthly, the days in RepeatDays cannot be repeated.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("RepeatDays")]
            [Validation(Required=false)]
            public List<long?> RepeatDays { get; set; }

            /// <summary>
            /// <para>The end time of the recurrence. The time is in the HH:mm format, based on a 24-hour clock. Example: 23:00.</para>
            /// <remarks>
            /// <para>If RepeatType is set to Permanent or None, this parameter is empty. If RepeatType is set to Daily, Weekly, or Monthly, you must set this parameter.
            /// The time is in the HH:mm format, based on a 24-hour clock. Examples: 08:00 and 23:30.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>23:30</para>
            /// </summary>
            [NameInMap("RepeatEndTime")]
            [Validation(Required=false)]
            public string RepeatEndTime { get; set; }

            /// <summary>
            /// <para>The start time of the recurrence. The time is in the HH:mm format, based on a 24-hour clock. Example: 08:00.</para>
            /// <remarks>
            /// <para>If RepeatType is set to Permanent or None, this parameter is empty. If RepeatType is set to Daily, Weekly, or Monthly, you must set this parameter.
            /// The time is in the HH:mm format, based on a 24-hour clock. Examples: 08:00 and 23:30.</para>
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
            /// <item><description><para>If <b>SourceType</b> is <c>net</c>, the value of this parameter is a CIDR block. Example: 192.0.XX.XX/24.</para>
            /// </description></item>
            /// <item><description><para>If <b>SourceType</b> is <c>group</c>, the value of this parameter is the name of a source address book. Example: db_group.</para>
            /// </description></item>
            /// <item><description><para>If <b>SourceType</b> is <c>location</c>, the value of this parameter is a region. For more information, see <a href="https://help.aliyun.com/document_detail/138867.html">AddControlPolicy</a>. Example: [&quot;BJ11&quot;, &quot;ZB&quot;].</para>
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
            /// <para>The type of the source address book in the access control policy. The value is fixed at <b>ip</b>. This indicates an IP address book that contains one or more IP address CIDR blocks.</para>
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
            /// <item><description><para><b>net</b>: CIDR block</para>
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
            /// <para>The number of policy specifications that are occupied. This is the cumulative value of the number of specifications occupied by each policy.
            /// The number of specifications occupied by a single policy = Number of source CIDR blocks × Number of destination addresses (IP address CIDR blocks, regions, or domain names) × Number of applications × Number of port ranges.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10,000</para>
            /// </summary>
            [NameInMap("SpreadCnt")]
            [Validation(Required=false)]
            public string SpreadCnt { get; set; }

            /// <summary>
            /// <para>The start time of the policy validity period. The value is a UNIX timestamp. Unit: seconds. The time must be on the hour or half hour, and at least 30 minutes earlier than the end time.</para>
            /// <remarks>
            /// <para>If RepeatType is set to Permanent, this parameter is empty. If RepeatType is set to None, Daily, Weekly, or Monthly, you must set this parameter.</para>
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
        /// <para>F283567D-8A52-5BAE-9472-*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>28</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
