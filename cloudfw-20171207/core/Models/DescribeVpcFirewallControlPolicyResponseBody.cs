// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallControlPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the access control policies of the virtual private cloud (VPC) firewalls.</para>
        /// </summary>
        [NameInMap("Policys")]
        [Validation(Required=false)]
        public List<DescribeVpcFirewallControlPolicyResponseBodyPolicys> Policys { get; set; }
        public class DescribeVpcFirewallControlPolicyResponseBodyPolicys : TeaModel {
            /// <summary>
            /// <para>The action that Cloud Firewall performs on the traffic in the access control policy of the virtual private cloud (VPC) firewalls. Valid values:</para>
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
            /// <para>The unique identifier of the access control policy of the virtual private cloud (VPC) firewalls.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4037fbf7-3e39-4634-92a4-d0155247****</para>
            /// </summary>
            [NameInMap("AclUuid")]
            [Validation(Required=false)]
            public string AclUuid { get; set; }

            /// <summary>
            /// <para>The ID of the application configured for the traffic in the access control policy of the virtual private cloud (VPC) firewalls.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10**</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// <para>The application type supported by the access control policy of the virtual private cloud (VPC) firewalls. Use ApplicationNameList instead. Valid values:</para>
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
            /// <item><description><b>ANY</b>: all application types supported by the access control policy.</description></item>
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
            /// <para>The time when the policy was created. The value is a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1761062400</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the access control policy of the virtual private cloud (VPC) firewalls.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The destination port for the traffic in the access control policy of the virtual private cloud (VPC) firewalls.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("DestPort")]
            [Validation(Required=false)]
            public string DestPort { get; set; }

            /// <summary>
            /// <para>The name of the destination port address book for the traffic in the access control policy of the virtual private cloud (VPC) firewalls.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my_port_group</para>
            /// </summary>
            [NameInMap("DestPortGroup")]
            [Validation(Required=false)]
            public string DestPortGroup { get; set; }

            /// <summary>
            /// <para>The details of the destination port address book in the access control policy of the virtual private cloud (VPC) firewalls.</para>
            /// </summary>
            [NameInMap("DestPortGroupPorts")]
            [Validation(Required=false)]
            public List<string> DestPortGroupPorts { get; set; }

            /// <summary>
            /// <para>The type of the destination port for the traffic in the access control policy of the virtual private cloud (VPC) firewalls. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>port</b>: a single port.</description></item>
            /// <item><description><b>group</b>: a port address book.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>port</para>
            /// </summary>
            [NameInMap("DestPortType")]
            [Validation(Required=false)]
            public string DestPortType { get; set; }

            /// <summary>
            /// <para>The destination address in the access control policy of the virtual private cloud (VPC) firewalls. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>If <b>DestinationType</b> is <c>net</c>, Destination is the destination CIDR block.</para>
            /// </description></item>
            /// <item><description><para>If <b>DestinationType</b> is <c>domain</c>, Destination is the destination domain name.</para>
            /// </description></item>
            /// <item><description><para>If <b>DestinationType</b> is <c>group</c>, Destination is the name of the destination address book.</para>
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
            /// <para>The CIDR block information in the destination address book of the access control policy of the virtual private cloud (VPC) firewalls.</para>
            /// </summary>
            [NameInMap("DestinationGroupCidrs")]
            [Validation(Required=false)]
            public List<string> DestinationGroupCidrs { get; set; }

            /// <summary>
            /// <para>The type of the destination address book in the access control policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ip</b>: an IP address book that contains one or more CIDR blocks.</description></item>
            /// <item><description><b>domain</b>: a domain name address book that contains one or more domain names.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ip</para>
            /// </summary>
            [NameInMap("DestinationGroupType")]
            [Validation(Required=false)]
            public string DestinationGroupType { get; set; }

            /// <summary>
            /// <para>The type of the destination address in the access control policy of the virtual private cloud (VPC) firewalls. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>net</b>: destination CIDR block.</description></item>
            /// <item><description><b>group</b>: destination address book.</description></item>
            /// <item><description><b>domain</b>: destination domain name.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>net</para>
            /// </summary>
            [NameInMap("DestinationType")]
            [Validation(Required=false)]
            public string DestinationType { get; set; }

            /// <summary>
            /// <para>The domain name resolution method of the access control policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>FQDN</b>: FQDN-based resolution.</description></item>
            /// <item><description><b>DNS</b>: DNS-based dynamic resolution.</description></item>
            /// <item><description><b>FQDN_AND_DNS</b>: FQDN and DNS-based dynamic resolution.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>FQDN</para>
            /// </summary>
            [NameInMap("DomainResolveType")]
            [Validation(Required=false)]
            public string DomainResolveType { get; set; }

            /// <summary>
            /// <para>The end time of the policy validity period for the access control policy. The value is a UNIX timestamp in seconds. The time must be on the hour or half-hour, and it must be at least 30 minutes later than the start time.</para>
            /// <remarks>
            /// <para>If RepeatType is <c>Permanent</c>, EndTime is empty. If RepeatType is <c>None</c>, <c>Daily</c>, <c>Weekly</c>, or <c>Monthly</c>, EndTime must be specified.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1694764800</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The latest hit timestamp. The value is a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1579261141</para>
            /// </summary>
            [NameInMap("HitLastTime")]
            [Validation(Required=false)]
            public long? HitLastTime { get; set; }

            /// <summary>
            /// <para>The number of hits of the access control policy of the virtual private cloud (VPC) firewalls.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("HitTimes")]
            [Validation(Required=false)]
            public long? HitTimes { get; set; }

            /// <summary>
            /// <para>The UID of the member account of the current Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>258039427902****</para>
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public string MemberUid { get; set; }

            /// <summary>
            /// <para>The time when the policy was modified. The value is a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1761062400</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <para>The priority of the access control policy of the virtual private cloud (VPC) firewalls.</para>
            /// <para>The priority value starts from 1 and increments sequentially. A smaller value indicates a higher priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Order")]
            [Validation(Required=false)]
            public int? Order { get; set; }

            /// <summary>
            /// <para>The protocol type of the traffic in the access control policy of the virtual private cloud (VPC) firewalls. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>TCP</b></description></item>
            /// <item><description><b>UDP</b></description></item>
            /// <item><description><b>ICMP</b></description></item>
            /// <item><description><b>ANY</b>: all protocol types.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("Proto")]
            [Validation(Required=false)]
            public string Proto { get; set; }

            /// <summary>
            /// <para>The enabling status of the access control policy. By default, a policy is enabled after it is created. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The access control policy is enabled.</description></item>
            /// <item><description><b>false</b>: The access control policy is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Release")]
            [Validation(Required=false)]
            public string Release { get; set; }

            /// <summary>
            /// <para>The set of recurrence days for the policy validity period of the access control policy.</para>
            /// <list type="bullet">
            /// <item><description>If RepeatType is <c>Permanent</c>, <c>None</c>, or <c>Daily</c>, RepeatDays is an empty set.
            /// Example: []</description></item>
            /// <item><description>If RepeatType is <c>Weekly</c>, RepeatDays cannot be empty.
            /// Example: [0, 6]<remarks>
            /// <para>When RepeatType is <c>Weekly</c>, the values in RepeatDays must be unique.</para>
            /// </remarks>
            /// </description></item>
            /// <item><description>If RepeatType is <c>Monthly</c>, RepeatDays cannot be empty.
            /// Example: [1, 31]<remarks>
            /// <para>When RepeatType is <c>Monthly</c>, the values in RepeatDays must be unique.</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("RepeatDays")]
            [Validation(Required=false)]
            public List<long?> RepeatDays { get; set; }

            /// <summary>
            /// <para>The recurrence end time when the policy takes effect. The time is in the 24-hour HH:mm format, such as 23:00.</para>
            /// <remarks>
            /// <para>If RepeatType is <c>Permanent</c> or <c>None</c>, RepeatEndTime is empty. If RepeatType is <c>Daily</c>, <c>Weekly</c>, or <c>Monthly</c>, RepeatEndTime must be specified.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>23:30</para>
            /// </summary>
            [NameInMap("RepeatEndTime")]
            [Validation(Required=false)]
            public string RepeatEndTime { get; set; }

            /// <summary>
            /// <para>The recurrence start time when the policy takes effect. The time is in the 24-hour HH:mm format, such as 08:00.</para>
            /// <remarks>
            /// <para>If RepeatType is <c>Permanent</c> or <c>None</c>, RepeatStartTime is empty. If RepeatType is <c>Daily</c>, <c>Weekly</c>, or <c>Monthly</c>, RepeatStartTime must be specified.</para>
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
            /// <item><description><b>None</b>: a specific single time.</description></item>
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
            /// <para>The source address in the access control policy of the virtual private cloud (VPC) firewalls. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>If <b>SourceType</b> is <c>net</c>, Source is the source CIDR block.</para>
            /// </description></item>
            /// <item><description><para>If <b>SourceType</b> is <c>group</c>, Source is the name of the address book.</para>
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
            /// <para>The details of the source address book in the access control policy of the virtual private cloud (VPC) firewalls.</para>
            /// </summary>
            [NameInMap("SourceGroupCidrs")]
            [Validation(Required=false)]
            public List<string> SourceGroupCidrs { get; set; }

            /// <summary>
            /// <para>The type of the source address book in the access control policy. Valid value: <b>ip</b>, which indicates an IP address book that contains one or more CIDR blocks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ip</para>
            /// </summary>
            [NameInMap("SourceGroupType")]
            [Validation(Required=false)]
            public string SourceGroupType { get; set; }

            /// <summary>
            /// <para>The type of the source address in the access control policy of the virtual private cloud (VPC) firewalls. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>net</b>: source CIDR block.</description></item>
            /// <item><description><b>group</b>: source address book.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>net</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>The number of access control policy quotas consumed. This value is the sum of the quotas consumed by each policy.
            /// The number of quotas consumed by a single policy = Number of source CIDR blocks × Number of destination addresses (CIDR blocks or domain names) × Number of applications × Number of port ranges.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("SpreadCnt")]
            [Validation(Required=false)]
            public long? SpreadCnt { get; set; }

            /// <summary>
            /// <para>The start time of the policy validity period for the access control policy. The value is a UNIX timestamp in seconds. The time must be on the hour or half-hour, and it must be at least 30 minutes earlier than the end time.</para>
            /// <remarks>
            /// <para>If RepeatType is <c>Permanent</c>, StartTime is empty. If RepeatType is <c>None</c>, <c>Daily</c>, <c>Weekly</c>, or <c>Monthly</c>, StartTime must be specified.</para>
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
        /// <para>CBF1E9B7-D6A0-4E9E-AD3E-2B47E6C2837D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of access control policies of the virtual private cloud (VPC) firewalls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
