// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyVpcFirewallControlPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The action that is performed on traffic that hits the access control policy.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>accept</b>: allows the traffic.</para>
        /// </description></item>
        /// <item><description><para><b>drop</b>: denies the traffic.</para>
        /// </description></item>
        /// <item><description><para><b>log</b>: monitors the traffic.</para>
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
        /// <para>To modify an access control policy, you must provide the unique ID of the policy. You can call the <a href="https://help.aliyun.com/document_detail/159758.html">DescribeVpcFirewallControlPolicy</a> operation to query the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00281255-d220-4db1-8f4f-c4df221a****</para>
        /// </summary>
        [NameInMap("AclUuid")]
        [Validation(Required=false)]
        public string AclUuid { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The application type supported by the access control policy.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ANY (all application types)</para>
        /// </description></item>
        /// <item><description><para>FTP</para>
        /// </description></item>
        /// <item><description><para>HTTP</para>
        /// </description></item>
        /// <item><description><para>HTTPS</para>
        /// </description></item>
        /// <item><description><para>MySQL</para>
        /// </description></item>
        /// <item><description><para>SMTP</para>
        /// </description></item>
        /// <item><description><para>SMTPS</para>
        /// </description></item>
        /// <item><description><para>RDP</para>
        /// </description></item>
        /// <item><description><para>VNC</para>
        /// </description></item>
        /// <item><description><para>SSH</para>
        /// </description></item>
        /// <item><description><para>Redis</para>
        /// </description></item>
        /// <item><description><para>MQTT</para>
        /// </description></item>
        /// <item><description><para>MongoDB</para>
        /// </description></item>
        /// <item><description><para>Memcache</para>
        /// </description></item>
        /// <item><description><para>SSL</para>
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
        /// <para>The list of application names.</para>
        /// </summary>
        [NameInMap("ApplicationNameList")]
        [Validation(Required=false)]
        public List<string> ApplicationNameList { get; set; }

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
        /// <para>The name of the destination port address book for the traffic to which the access control policy applies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_port_group</para>
        /// </summary>
        [NameInMap("DestPortGroup")]
        [Validation(Required=false)]
        public string DestPortGroup { get; set; }

        /// <summary>
        /// <para>The type of the destination port for the traffic to which the access control policy applies.</para>
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
        /// <para>The destination address in the access control policy.</para>
        /// <list type="bullet">
        /// <item><description><para>If <b>DestinationType</b> is set to <c>net</c>, specify a destination CIDR block.</para>
        /// <para>Example: 10.2.3.0/24</para>
        /// </description></item>
        /// <item><description><para>If <b>DestinationType</b> is set to <c>group</c>, specify the name of a destination address book.</para>
        /// <para>Example: db_group</para>
        /// </description></item>
        /// <item><description><para>If <b>DestinationType</b> is set to <c>domain</c>, specify a destination domain name.</para>
        /// <para>Example: \*.aliyuncs.com</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10.2.X.X/XX</para>
        /// </summary>
        [NameInMap("Destination")]
        [Validation(Required=false)]
        public string Destination { get; set; }

        /// <summary>
        /// <para>The type of the destination address in the access control policy.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>net</b>: destination CIDR block</para>
        /// </description></item>
        /// <item><description><para><b>group</b>: destination address book</para>
        /// </description></item>
        /// <item><description><para><b>domain</b>: destination domain name</para>
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
        /// <para>The domain name resolution method for the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>FQDN</b>: based on Fully Qualified Domain Name (FQDN)</para>
        /// </description></item>
        /// <item><description><para><b>DNS</b>: based on dynamic DNS resolution</para>
        /// </description></item>
        /// <item><description><para><b>FQDN_AND_DNS</b>: based on FQDN and dynamic DNS resolution</para>
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
        /// <para>The end time of the policy validity period. The value is a UNIX timestamp. The time is on the hour or on the half hour, and is at least 30 minutes later than the start time.</para>
        /// <remarks>
        /// <para>If RepeatType is set to \<c>Permanent\\</c>, this parameter is empty. If RepeatType is set to \<c>None\\</c>, \<c>Daily\\</c>, \<c>Weekly\\</c>, or \<c>Monthly\\</c>, you must specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1694764800</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The language of the response message.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b>: Chinese (default)</para>
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
        /// <para>The protocol type for the traffic to which the access control policy applies.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ANY (all protocol types)</para>
        /// </description></item>
        /// <item><description><para>TCP</para>
        /// </description></item>
        /// <item><description><para>UDP</para>
        /// </description></item>
        /// <item><description><para>ICMP</para>
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
        /// <item><description><para><b>true</b>: enables the access control policy.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: disables the access control policy.</para>
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
        /// <para>The days of a week or month on which the policy takes effect.</para>
        /// <list type="bullet">
        /// <item><description><para>If RepeatType is set to \<c>Permanent\\</c>, \<c>None\\</c>, or \<c>Daily\\</c>, this parameter is empty.
        /// Example: []</para>
        /// </description></item>
        /// <item><description><para>If RepeatType is set to \<c>Weekly\\</c>, this parameter cannot be empty.
        /// Example: [0, 6]</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If RepeatType is set to \<c>Weekly\\</c>, the elements in the array cannot be repeated.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If RepeatType is set to \<c>Monthly\\</c>, this parameter cannot be empty.
        /// Example: [1, 31]</description></item>
        /// </list>
        /// <remarks>
        /// <para>If RepeatType is set to \<c>Monthly\\</c>, the elements in the array cannot be repeated.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("RepeatDays")]
        [Validation(Required=false)]
        public List<long?> RepeatDays { get; set; }

        /// <summary>
        /// <para>The end time of the recurrence. The time is in the HH:mm format. The time is on the hour or on the half hour, and is at least 30 minutes later than the start time. Example: 23:30.</para>
        /// <remarks>
        /// <para>If RepeatType is set to \<c>Permanent\\</c> or \<c>None\\</c>, this parameter is empty. If RepeatType is set to \<c>Daily\\</c>, \<c>Weekly\\</c>, or \<c>Monthly\\</c>, you must specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>23:30</para>
        /// </summary>
        [NameInMap("RepeatEndTime")]
        [Validation(Required=false)]
        public string RepeatEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the recurrence. The time is in the HH:mm format. The time is on the hour or on the half hour, and is at least 30 minutes earlier than the end time. Example: 08:00.</para>
        /// <remarks>
        /// <para>If RepeatType is set to \<c>Permanent\\</c> or \<c>None\\</c>, this parameter is empty. If RepeatType is set to \<c>Daily\\</c>, \<c>Weekly\\</c>, or \<c>Monthly\\</c>, you must specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>08:00</para>
        /// </summary>
        [NameInMap("RepeatStartTime")]
        [Validation(Required=false)]
        public string RepeatStartTime { get; set; }

        /// <summary>
        /// <para>The recurrence type for the policy to take effect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Permanent</b> (default): The policy is always in effect.</para>
        /// </description></item>
        /// <item><description><para><b>None</b>: The policy takes effect for a specific period of time.</para>
        /// </description></item>
        /// <item><description><para><b>Daily</b>: The policy takes effect daily.</para>
        /// </description></item>
        /// <item><description><para><b>Weekly</b>: The policy takes effect weekly.</para>
        /// </description></item>
        /// <item><description><para><b>Monthly</b>: The policy takes effect monthly.</para>
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
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If <b>SourceType</b> is set to <c>net</c>, specify a source CIDR block.</para>
        /// <para>Example: 10.2.4.0/24</para>
        /// </description></item>
        /// <item><description><para>If <b>SourceType</b> is set to <c>group</c>, specify the name of a source address book.</para>
        /// <para>Example: db_group</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10.2.X.X/XX</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The type of the source address in the access control policy.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>net</b>: source CIDR block</para>
        /// </description></item>
        /// <item><description><para><b>group</b>: source address book</para>
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
        /// <para>The start time of the policy validity period. The value is a UNIX timestamp. The time is on the hour or on the half hour, and is at least 30 minutes earlier than the end time.</para>
        /// <remarks>
        /// <para>If RepeatType is set to \<c>Permanent\\</c>, this parameter is empty. If RepeatType is set to \<c>None\\</c>, \<c>Daily\\</c>, \<c>Weekly\\</c>, or \<c>Monthly\\</c>, you must specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1694761200</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The ID of the VPC firewall instance. You can call the <a href="https://help.aliyun.com/document_detail/159760.html">DescribeVpcFirewallAclGroupList</a> operation to query the ID.</para>
        /// <list type="bullet">
        /// <item><description><para>If the VPC firewall protects a CEN instance, the value of this parameter is the ID of the CEN instance.</para>
        /// <para>Example: cen-ervw0g12b5jbw\<em>\</em>\<em>\</em></para>
        /// </description></item>
        /// <item><description><para>If the VPC firewall protects an Express Connect circuit, the value of this parameter is the ID of the VPC firewall instance.</para>
        /// <para>Example: vfw-a42bbb7b887148c9\<em>\</em>\<em>\</em></para>
        /// </description></item>
        /// </list>
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
