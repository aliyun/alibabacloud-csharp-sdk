// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallControlPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The VPC firewall access control policies.</para>
        /// </summary>
        [NameInMap("Policys")]
        [Validation(Required=false)]
        public List<DescribeVpcFirewallControlPolicyResponseBodyPolicys> Policys { get; set; }
        public class DescribeVpcFirewallControlPolicyResponseBodyPolicys : TeaModel {
            /// <summary>
            /// <para>The action to perform on traffic that matches the access control policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>accept</b>: allows the traffic.</para>
            /// </description></item>
            /// <item><description><para><b>drop</b>: denies the traffic.</para>
            /// </description></item>
            /// <item><description><para><b>log</b>: logs the traffic.</para>
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
            /// <para>The unique identifier of the access control policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4037fbf7-3e39-4634-92a4-d0155247****</para>
            /// </summary>
            [NameInMap("AclUuid")]
            [Validation(Required=false)]
            public string AclUuid { get; set; }

            /// <summary>
            /// <para>The ID of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10**</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// <para>The application type. We recommend that you use <c>ApplicationNameList</c> instead. Valid values:</para>
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
            /// <para>The UNIX timestamp, in seconds, of when the policy was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1761062400</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The policy description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The destination port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("DestPort")]
            [Validation(Required=false)]
            public string DestPort { get; set; }

            /// <summary>
            /// <para>The name of the destination port address book.</para>
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
            /// <para>The type of the destination port. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>port</b>: a single port</para>
            /// </description></item>
            /// <item><description><para><b>group</b>: a port address book</para>
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
            /// <para>The destination address for the access control policy. The value depends on <c>DestinationType</c>.</para>
            /// <list type="bullet">
            /// <item><description><para>If <c>DestinationType</c> is <c>net</c>, the value is a destination CIDR block.</para>
            /// </description></item>
            /// <item><description><para>If <c>DestinationType</c> is <c>domain</c>, the value is a destination domain name.</para>
            /// </description></item>
            /// <item><description><para>If <c>DestinationType</c> is <c>group</c>, the value is the name of a destination address book.</para>
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
            /// <para>The CIDR blocks in the destination address book.</para>
            /// </summary>
            [NameInMap("DestinationGroupCidrs")]
            [Validation(Required=false)]
            public List<string> DestinationGroupCidrs { get; set; }

            /// <summary>
            /// <para>The type of the destination address book. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>ip</b>: an address book of IP addresses or CIDR blocks.</para>
            /// </description></item>
            /// <item><description><para><b>domain</b>: an address book of domain names.</para>
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
            /// <para>The type of the destination address. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>net</b>: a destination CIDR block</para>
            /// </description></item>
            /// <item><description><para><b>group</b>: a destination address book</para>
            /// </description></item>
            /// <item><description><para><b>domain</b>: a destination domain name</para>
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
            /// <para>The domain name resolution mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>FQDN</b>: FQDN-based resolution</para>
            /// </description></item>
            /// <item><description><para><b>DNS</b>: DNS-based dynamic resolution</para>
            /// </description></item>
            /// <item><description><para><b>FQDN_AND_DNS</b>: FQDN-based and DNS-based dynamic resolution</para>
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
            /// <para>The UNIX timestamp, in seconds, for the end of the policy\&quot;s effective period. The time must be on the hour or half-hour and at least 30 minutes after the start time.</para>
            /// <remarks>
            /// <para>This parameter is not used if <c>RepeatType</c> is <c>Permanent</c>. It is required for <c>None</c>, <c>Daily</c>, <c>Weekly</c>, or <c>Monthly</c> recurrence.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1694764800</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

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
            /// <para>The number of policy hits.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("HitTimes")]
            [Validation(Required=false)]
            public long? HitTimes { get; set; }

            /// <summary>
            /// <para>The UID of the member account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>258039427902****</para>
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public string MemberUid { get; set; }

            /// <summary>
            /// <para>The UNIX timestamp, in seconds, of when the policy was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1761062400</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <para>The priority of the access control policy, starting from 1. A smaller value indicates a higher priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Order")]
            [Validation(Required=false)]
            public int? Order { get; set; }

            /// <summary>
            /// <para>The protocol type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>TCP</b></para>
            /// </description></item>
            /// <item><description><para><b>UDP</b></para>
            /// </description></item>
            /// <item><description><para><b>ICMP</b></para>
            /// </description></item>
            /// <item><description><para><b>ANY</b> (all protocol types)</para>
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
            /// <para>The enabled status of the access control policy. A policy is enabled by default after it is created. Valid values:</para>
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
            /// <para>The days of the week or month on which the policy recurs.</para>
            /// <list type="bullet">
            /// <item><description><para>If <c>RepeatType</c> is set to <c>Permanent</c>, <c>None</c>, or <c>Daily</c>, this parameter is empty. Example: <c>[]</c></para>
            /// </description></item>
            /// <item><description><para>If <c>RepeatType</c> is set to <c>Weekly</c>, this parameter is required. Example: <c>[0, 6]</c></para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>If <c>RepeatType</c> is set to <c>Weekly</c>, do not specify duplicate values for this parameter.</para>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>If <c>RepeatType</c> is set to <c>Monthly</c>, this parameter is required. Example: <c>[1, 31]</c></description></item>
            /// </list>
            /// <remarks>
            /// <para>If <c>RepeatType</c> is set to <c>Monthly</c>, do not specify duplicate values for this parameter.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("RepeatDays")]
            [Validation(Required=false)]
            public List<long?> RepeatDays { get; set; }

            /// <summary>
            /// <para>The recurrence end time. The time is in the <c>HH:mm</c> 24-hour format, such as <c>23:30</c>.</para>
            /// <remarks>
            /// <para>This parameter is not used if <c>RepeatType</c> is <c>Permanent</c> or <c>None</c>. It is required for <c>Daily</c>, <c>Weekly</c>, or <c>Monthly</c> recurrence.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>23:30</para>
            /// </summary>
            [NameInMap("RepeatEndTime")]
            [Validation(Required=false)]
            public string RepeatEndTime { get; set; }

            /// <summary>
            /// <para>The recurrence start time. The time is in the <c>HH:mm</c> 24-hour format, such as <c>08:00</c>.</para>
            /// <remarks>
            /// <para>This parameter is not used if <c>RepeatType</c> is <c>Permanent</c> or <c>None</c>. It is required for <c>Daily</c>, <c>Weekly</c>, or <c>Monthly</c> recurrence.</para>
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
            /// <item><description><para><b>Permanent</b> (default): The policy is always active.</para>
            /// </description></item>
            /// <item><description><para><b>None</b>: The policy applies only once.</para>
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
            /// <para>The source address for the access control policy. The value depends on <c>SourceType</c>.</para>
            /// <list type="bullet">
            /// <item><description><para>If <c>SourceType</c> is <c>net</c>, the value is a source CIDR block.</para>
            /// </description></item>
            /// <item><description><para>If <c>SourceType</c> is <c>group</c>, the value is the name of a source address book.</para>
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
            /// <para>The CIDR blocks in the source address book.</para>
            /// </summary>
            [NameInMap("SourceGroupCidrs")]
            [Validation(Required=false)]
            public List<string> SourceGroupCidrs { get; set; }

            /// <summary>
            /// <para>The type of the source address book. The value is always <b>ip</b>, which indicates an address book that contains IP addresses or CIDR blocks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ip</para>
            /// </summary>
            [NameInMap("SourceGroupType")]
            [Validation(Required=false)]
            public string SourceGroupType { get; set; }

            /// <summary>
            /// <para>The type of the source address. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>net</b>: a source CIDR block</para>
            /// </description></item>
            /// <item><description><para><b>group</b>: a source address book</para>
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
            /// <para>The number of rule capacity units that the access control policy consumes. This is calculated as: Number of source addresses × Number of destination addresses × Number of applications × Number of port ranges.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("SpreadCnt")]
            [Validation(Required=false)]
            public long? SpreadCnt { get; set; }

            /// <summary>
            /// <para>The UNIX timestamp, in seconds, for the start of the policy\&quot;s effective period. The time must be on the hour or half-hour and at least 30 minutes before the end time.</para>
            /// <remarks>
            /// <para>This parameter is not used if <c>RepeatType</c> is <c>Permanent</c>. It is required for <c>None</c>, <c>Daily</c>, <c>Weekly</c>, or <c>Monthly</c> recurrence.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CBF1E9B7-D6A0-4E9E-AD3E-2B47E6C2837D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of VPC firewall access control policies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
