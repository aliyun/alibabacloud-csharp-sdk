// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallControlPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the access control policies.</para>
        /// </summary>
        [NameInMap("Policys")]
        [Validation(Required=false)]
        public List<DescribeVpcFirewallControlPolicyResponseBodyPolicys> Policys { get; set; }
        public class DescribeVpcFirewallControlPolicyResponseBodyPolicys : TeaModel {
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
            /// <para>4037fbf7-3e39-4634-92a4-d0155247****</para>
            /// </summary>
            [NameInMap("AclUuid")]
            [Validation(Required=false)]
            public string AclUuid { get; set; }

            /// <summary>
            /// <para>The application ID in the access control policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10**</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// <para>The application types supported by the access control policy. We recommend that you specify ApplicationNameList. Valid values:</para>
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
            /// <item><description><b>ANY</b>: all application types</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
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
            /// <para>The time when the access control policy was created. The value is a UNIX timestamp. Unit: seconds.</para>
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
            /// <para>The ports in the destination port address book of the access control policy.</para>
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
            /// <para>The destination address in the access control policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>If <b>DestinationType</b> is set to <c>net</c>, the value of this parameter is a CIDR block.</description></item>
            /// <item><description>If <b>DestinationType</b> is set to <c>domain</c>, the value of this parameter is a domain name.</description></item>
            /// <item><description>If <b>DestinationType</b> is set to <c>group</c>, the value of this parameter is an address book name.</description></item>
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
            /// <item><description><b>ip</b>: an address book that includes one or more CIDR blocks</description></item>
            /// <item><description><b>domain</b>: an address book that includes one or more domain names</description></item>
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
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>net</para>
            /// </summary>
            [NameInMap("DestinationType")]
            [Validation(Required=false)]
            public string DestinationType { get; set; }

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
            /// <para>The time when the access control policy stops taking effect. The value is a UNIX timestamp. Unit: seconds. The value must be on the hour or on the half hour, and at least 30 minutes later than the value of StartTime.</para>
            /// <remarks>
            /// <para> If RepeatType is set to Permanent, EndTime is left empty. If RepeatType is set to None, Daily, Weekly, or Monthly, EndTime must be specified.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1694764800</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The time when the access control policy was last hit. The value is a UNIX timestamp. Unit: seconds.</para>
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
            /// <para>The UID of the member that is managed by your Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>258039427902****</para>
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public string MemberUid { get; set; }

            /// <summary>
            /// <para>The time when the access control policy was modified. The value is a UNIX timestamp. Unit: seconds.</para>
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
            /// <item><description><b>TCP</b></description></item>
            /// <item><description><b>UDP</b></description></item>
            /// <item><description><b>ICMP</b></description></item>
            /// <item><description><b>ANY</b>: all protocol types</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("Proto")]
            [Validation(Required=false)]
            public string Proto { get; set; }

            /// <summary>
            /// <para>Indicates whether the access control policy is enabled. By default, an access control policy is enabled after it is created. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
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
            /// <item><description>If RepeatType is set to <c>Permanent</c>, <c>None</c>, or <c>Daily</c>, RepeatDays is left empty. Example: [].</description></item>
            /// <item><description>If RepeatType is set to Weekly, RepeatDays must be specified. Example: [0, 6].</description></item>
            /// </list>
            /// <remarks>
            /// <para> If RepeatType is set to Weekly, the fields in the value of RepeatDays cannot be repeated.</para>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>If RepeatType is set to <c>Monthly</c>, RepeatDays must be specified. Example: [1, 31].</description></item>
            /// </list>
            /// <remarks>
            /// <para> If RepeatType is set to Monthly, the fields in the value of RepeatDays cannot be repeated.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("RepeatDays")]
            [Validation(Required=false)]
            public List<long?> RepeatDays { get; set; }

            /// <summary>
            /// <para>The point in time when the recurrence ends. Example: 23:30. The value must be on the hour or on the half hour, and at least 30 minutes later than the value of RepeatStartTime.</para>
            /// <remarks>
            /// <para> If RepeatType is set to Permanent or None, RepeatEndTime is left empty. If RepeatType is set to Daily, Weekly, or Monthly, RepeatEndTime must be specified.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>23:30</para>
            /// </summary>
            [NameInMap("RepeatEndTime")]
            [Validation(Required=false)]
            public string RepeatEndTime { get; set; }

            /// <summary>
            /// <para>The point in time when the recurrence starts. Example: 08:00. The value must be on the hour or on the half hour, and at least 30 minutes earlier than the value of RepeatEndTime.</para>
            /// <remarks>
            /// <para> If RepeatType is set to Permanent or None, RepeatStartTime is left empty. If RepeatType is set to Daily, Weekly, or Monthly, this parameter must be specified.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>08:00</para>
            /// </summary>
            [NameInMap("RepeatStartTime")]
            [Validation(Required=false)]
            public string RepeatStartTime { get; set; }

            /// <summary>
            /// <para>The recurrence type for the access control policy to take effect. Valid values:</para>
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
            /// <item><description>If <b>SourceType</b> is set to <c>net</c>, the value of this parameter is a CIDR block.</description></item>
            /// <item><description>If <b>SourceType</b> is set to <c>group</c>, the value of this parameter is an address book name.</description></item>
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
            /// <para>The type of the source address book in the access control policy. The value is fixed as <b>ip</b>. The value indicates an address book that includes one or more CIDR blocks.</para>
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
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>net</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>The total quota consumed by the returned access control policies, which is the sum of the quota consumed by each policy. The quota that is consumed by an access control policy is calculated by using the following formula: Quota that is consumed by an access control policy = Number of source addresses × Number of destination addresses (number of CIDR blocks or domain names) × Number of applications × Number of port ranges.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10,000</para>
            /// </summary>
            [NameInMap("SpreadCnt")]
            [Validation(Required=false)]
            public long? SpreadCnt { get; set; }

            /// <summary>
            /// <para>The time when the access control policy starts to take effect. The value is a UNIX timestamp. Unit: seconds. The value must be on the hour or on the half hour, and at least 30 minutes earlier than the value of EndTime.</para>
            /// <remarks>
            /// <para> If RepeatType is set to Permanent, StartTime is left empty. If RepeatType is set to None, Daily, Weekly, or Monthly, StartTime must be specified.</para>
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
        /// <para>The total number of access control policies returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
