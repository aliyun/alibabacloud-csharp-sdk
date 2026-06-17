// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateVpcFirewallControlPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The action that Cloud Firewall performs on the traffic. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>accept</b>: Allows the traffic.</para>
        /// </description></item>
        /// <item><description><para><b>drop</b>: Denies the traffic.</para>
        /// </description></item>
        /// <item><description><para><b>log</b>: Monitors the traffic.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>accept</para>
        /// </summary>
        [NameInMap("AclAction")]
        [Validation(Required=false)]
        public string AclAction { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The application type that the access control policy supports. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>FTP</b></para>
        /// </description></item>
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
        [Obsolete]
        public string ApplicationName { get; set; }

        /// <summary>
        /// <para>The list of application types that the access control policy supports.</para>
        /// </summary>
        [NameInMap("ApplicationNameList")]
        [Validation(Required=false)]
        public List<string> ApplicationNameList { get; set; }

        /// <summary>
        /// <para>The description of the access control policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The destination port in the access control policy.</para>
        /// <remarks>
        /// <para>Set this parameter when <b>DestPortType</b> is set to <c>port</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("DestPort")]
        [Validation(Required=false)]
        public string DestPort { get; set; }

        /// <summary>
        /// <para>The name of the destination port address book in the access control policy.</para>
        /// <remarks>
        /// <para>Set this parameter when <b>DestPortType</b> is set to <c>group</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>my_port_group</para>
        /// </summary>
        [NameInMap("DestPortGroup")]
        [Validation(Required=false)]
        public string DestPortGroup { get; set; }

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
        /// <para>The destination address in the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If <b>DestinationType</b> is <c>net</c>, set this parameter to a destination CIDR block.</para>
        /// </description></item>
        /// <item><description><para>If <b>DestinationType</b> is <c>group</c>, set this parameter to the name of a destination address book.</para>
        /// </description></item>
        /// <item><description><para>If <b>DestinationType</b> is <c>domain</c>, set this parameter to a destination domain name.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.2.XX.XX/24</para>
        /// </summary>
        [NameInMap("Destination")]
        [Validation(Required=false)]
        public string Destination { get; set; }

        /// <summary>
        /// <para>The type of the destination address in the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>net</b>: CIDR block</para>
        /// </description></item>
        /// <item><description><para><b>group</b>: address book</para>
        /// </description></item>
        /// <item><description><para><b>domain</b>: domain name</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>net</para>
        /// </summary>
        [NameInMap("DestinationType")]
        [Validation(Required=false)]
        public string DestinationType { get; set; }

        /// <summary>
        /// <para>The domain name resolution method for the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>FQDN</b>: FQDN-based</para>
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
        /// <para>The end time of the policy validity period. This value is a UNIX timestamp. The time must be on the hour or half-hour and must be at least 30 minutes later than the start time.</para>
        /// <remarks>
        /// <para>If RepeatType is \<c>Permanent\\</c>, leave this parameter empty. If RepeatType is \<c>None\\</c>, \<c>Daily\\</c>, \<c>Weekly\\</c>, or \<c>Monthly\\</c>, set this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1694764800</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (default): Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

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
        /// <para>The priority of the access control policy.</para>
        /// <para>The priority starts from 1. A smaller value indicates a higher priority.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NewOrder")]
        [Validation(Required=false)]
        public string NewOrder { get; set; }

        /// <summary>
        /// <para>The protocol type in the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ANY</b> (Set this value if you are unsure of the protocol type.)</para>
        /// </description></item>
        /// <item><description><para><b>TCP</b></para>
        /// </description></item>
        /// <item><description><para><b>UDP</b></para>
        /// </description></item>
        /// <item><description><para><b>ICMP</b></para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TCP</para>
        /// </summary>
        [NameInMap("Proto")]
        [Validation(Required=false)]
        public string Proto { get; set; }

        /// <summary>
        /// <para>The status of the access control policy. The policy is enabled by default after it is created. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enables the access control policy.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disables the access control policy.</para>
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
        /// <para>The days of the week or month on which the policy is recurrently active.</para>
        /// <list type="bullet">
        /// <item><description><para>If RepeatType is <c>Permanent</c>, <c>None</c>, or <c>Daily</c>, leave this parameter empty. Example: \<c>[]\\</c></para>
        /// </description></item>
        /// <item><description><para>If RepeatType is \<c>Weekly\\</c>, set this parameter. Example: \<c>[0, 6]\\</c></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If RepeatType is set to \<c>Weekly\\</c>, the values in RepeatDays cannot be duplicates.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If <b>RepeatType</b> is \<c>Monthly\\</c>, set this parameter. Example: \<c>[1, 31]\\</c></description></item>
        /// </list>
        /// <remarks>
        /// <para>If RepeatType is set to \<c>Monthly\\</c>, the values in RepeatDays cannot be duplicates.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("RepeatDays")]
        [Validation(Required=false)]
        public List<long?> RepeatDays { get; set; }

        /// <summary>
        /// <para>The recurring end time of the policy validity period. For example: \<c>23:30\\</c>. The time must be on the hour or half-hour and must be at least 30 minutes later than the recurring start time.</para>
        /// <remarks>
        /// <para>If RepeatType is \<c>Permanent\\</c> or \<c>None\\</c>, leave this parameter empty. If RepeatType is \<c>Daily\\</c>, \<c>Weekly\\</c>, or \<c>Monthly\\</c>, set this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>23:30</para>
        /// </summary>
        [NameInMap("RepeatEndTime")]
        [Validation(Required=false)]
        public string RepeatEndTime { get; set; }

        /// <summary>
        /// <para>The recurring start time of the policy validity period. For example: \<c>08:00\\</c>. The time must be on the hour or half-hour and must be at least 30 minutes earlier than the recurring end time.</para>
        /// <remarks>
        /// <para>If RepeatType is \<c>Permanent\\</c> or \<c>None\\</c>, leave this parameter empty. If RepeatType is \<c>Daily\\</c>, \<c>Weekly\\</c>, or \<c>Monthly\\</c>, set this parameter.</para>
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
        /// <para>The source address in the access control policy.</para>
        /// <list type="bullet">
        /// <item><description><para>If SourceType is <c>net</c>, set this parameter to a source CIDR block.</para>
        /// </description></item>
        /// <item><description><para>If SourceType is <c>group</c>, set this parameter to the name of a source address book.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.2.XX.XX/24</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The type of the source address in the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>net</b>: CIDR block</para>
        /// </description></item>
        /// <item><description><para><b>group</b>: address book</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>net</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The start time of the policy validity period. This value is a UNIX timestamp. The time must be on the hour or half-hour and must be at least 30 minutes earlier than the end time.</para>
        /// <remarks>
        /// <para>If RepeatType is \<c>Permanent\\</c>, leave this parameter empty. If RepeatType is \<c>None\\</c>, \<c>Daily\\</c>, \<c>Weekly\\</c>, or \<c>Monthly\\</c>, set this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1694761200</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The ID of the policy group for the VPC border firewall.</para>
        /// <list type="bullet">
        /// <item><description><para>If the VPC border firewall protects traffic between two VPCs that are connected using a CEN instance, set this parameter to the ID of the CEN instance.</para>
        /// </description></item>
        /// <item><description><para>If the VPC border firewall protects traffic between two VPCs that are connected using an Express Connect circuit, set this parameter to the ID of the VPC border firewall instance.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/159760.html">DescribeVpcFirewallAclGroupList</a> operation to get this ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vfw-a42bbb7b887148c9****</para>
        /// </summary>
        [NameInMap("VpcFirewallId")]
        [Validation(Required=false)]
        public string VpcFirewallId { get; set; }

    }

}
