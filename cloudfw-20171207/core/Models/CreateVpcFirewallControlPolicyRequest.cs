// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateVpcFirewallControlPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The action that Cloud Firewall performs on the traffic in the virtual private cloud (VPC) firewall access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>accept</b>: allows the traffic.</description></item>
        /// <item><description><b>drop</b>: denies the traffic.</description></item>
        /// <item><description><b>log</b>: monitors the traffic.</description></item>
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
        /// <para>The application type supported by the virtual private cloud (VPC) firewall access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>FTP</b></description></item>
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
        [Obsolete]
        public string ApplicationName { get; set; }

        /// <summary>
        /// <para>The application types supported by the access control policy.</para>
        /// </summary>
        [NameInMap("ApplicationNameList")]
        [Validation(Required=false)]
        public List<string> ApplicationNameList { get; set; }

        /// <summary>
        /// <para>The description of the virtual private cloud (VPC) firewall access control policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The destination port in the virtual private cloud (VPC) firewall access control policy for traffic access.</para>
        /// <remarks>
        /// <para>When <b>DestPortType</b> is set to <c>port</c>, configure this parameter. When Proto is set to TCP/UDP/ICMP, either DestPort (with DestPortType=port) or DestPortGroup (with DestPortType=group) is conditionally required. Otherwise, ErrorParametersDestPort(400) is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("DestPort")]
        [Validation(Required=false)]
        public string DestPort { get; set; }

        /// <summary>
        /// <para>The name of the destination port address book for traffic access in the virtual private cloud (VPC) firewall access control policy.</para>
        /// <remarks>
        /// <para>When <b>DestPortType</b> is set to <c>group</c>, configure this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>my_port_group</para>
        /// </summary>
        [NameInMap("DestPortGroup")]
        [Validation(Required=false)]
        public string DestPortGroup { get; set; }

        /// <summary>
        /// <para>The type of the destination port for traffic access in the virtual private cloud (VPC) firewall access control policy. Valid values:</para>
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
        /// <para>The destination address in the virtual private cloud (VPC) firewall access control policy for traffic access. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If <b>DestinationType</b> is set to <c>net</c>, the value of <b>Destination</b> is a destination CIDR block.</para>
        /// </description></item>
        /// <item><description><para>If <b>DestinationType</b> is set to <c>group</c>, the value of <b>Destination</b> is a destination address book name.</para>
        /// </description></item>
        /// <item><description><para>If <b>DestinationType</b> is set to <c>domain</c>, the value of <b>Destination</b> is a destination domain name.</para>
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
        /// <para>The type of the destination address in the virtual private cloud (VPC) firewall access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>net</b>: destination CIDR block</description></item>
        /// <item><description><b>group</b>: destination address book</description></item>
        /// <item><description><b>domain</b>: destination domain name</description></item>
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
        /// <para>The domain name resolution method of the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>FQDN</b>: FQDN-based</description></item>
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
        /// <para>The end time of the policy validity period for the access control policy. The value is a UNIX timestamp in seconds. The value must be on the hour or on the half hour and must be at least 30 minutes later than the start time.</para>
        /// <remarks>
        /// <para>When RepeatType is set to Permanent, EndTime is empty. When RepeatType is set to None, Daily, Weekly, or Monthly, EndTime must have a value.</para>
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
        /// <item><description><b>zh</b> (default): Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The UID of a member account of the current Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>258039427902****</para>
        /// </summary>
        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public string MemberUid { get; set; }

        /// <summary>
        /// <para>The priority of the virtual private cloud (VPC) firewall access control policy.</para>
        /// <para>The priority value starts from 1 and increases by increment. A smaller value indicates a higher priority.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NewOrder")]
        [Validation(Required=false)]
        public string NewOrder { get; set; }

        /// <summary>
        /// <para>The security protocol type for traffic access in the virtual private cloud (VPC) firewall access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ANY</b>: any protocol type</description></item>
        /// <item><description><b>TCP</b></description></item>
        /// <item><description><b>UDP</b></description></item>
        /// <item><description><b>ICMP</b></description></item>
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
        /// <para>Specifies whether to enable the access control policy. The policy is enabled by default after it is created. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables the access control policy.</description></item>
        /// <item><description><b>false</b>: does not enable the access control policy.</description></item>
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
        /// <item><description>When RepeatType is set to <c>Permanent</c>, <c>None</c>, or <c>Daily</c>, RepeatDays is an empty collection.
        /// Example: []</description></item>
        /// <item><description>When RepeatType is set to Weekly, RepeatDays cannot be empty.
        /// Example: [0, 6]<remarks>
        /// <para>When RepeatType is set to Weekly, RepeatDays does not allow duplicate values.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description>When RepeatType is set to <c>Monthly</c>, RepeatDays cannot be empty.
        /// Example: [1, 31]<remarks>
        /// <para>When RepeatType is set to Monthly, RepeatDays does not allow duplicate values.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("RepeatDays")]
        [Validation(Required=false)]
        public List<long?> RepeatDays { get; set; }

        /// <summary>
        /// <para>The recurrence end time of the policy validity period for the access control policy. Example: 23:30. The value must be on the hour or on the half hour and must be at least 30 minutes later than the recurrence start time.</para>
        /// <remarks>
        /// <para>When RepeatType is set to Permanent or None, RepeatEndTime is empty. When RepeatType is set to Daily, Weekly, or Monthly, RepeatEndTime must have a value. Format: HH:MM (24-hour clock). Example: 08:00.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>23:30</para>
        /// </summary>
        [NameInMap("RepeatEndTime")]
        [Validation(Required=false)]
        public string RepeatEndTime { get; set; }

        /// <summary>
        /// <para>The recurrence start time of the policy validity period for the access control policy. Example: 08:00. The value must be on the hour or on the half hour and must be at least 30 minutes earlier than the recurrence end time.</para>
        /// <remarks>
        /// <para>When RepeatType is set to Permanent or None, RepeatStartTime is empty. When RepeatType is set to Daily, Weekly, or Monthly, RepeatStartTime must have a value. Format: HH:MM (24-hour clock). Example: 08:00.</para>
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
        /// <item><description><b>Permanent</b> (default): always</description></item>
        /// <item><description><b>None</b>: one-time</description></item>
        /// <item><description><b>Daily</b>: daily</description></item>
        /// <item><description><b>Weekly</b>: weekly</description></item>
        /// <item><description><b>Monthly</b>: monthly</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Permanent</para>
        /// </summary>
        [NameInMap("RepeatType")]
        [Validation(Required=false)]
        public string RepeatType { get; set; }

        /// <summary>
        /// <para>The source address in the virtual private cloud (VPC) firewall access control policy.</para>
        /// <list type="bullet">
        /// <item><description>If SourceType is set to <c>net</c>, the value of Source is a source CIDR block.</description></item>
        /// <item><description>If SourceType is set to <c>group</c>, the value of Source is a source address book name.</description></item>
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
        /// <para>The type of the source address in the virtual private cloud (VPC) firewall access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>net</b>: source CIDR block</para>
        /// </description></item>
        /// <item><description><para><b>group</b>: source address book</para>
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
        /// <para>The start time of the policy validity period for the access control policy. The value is a UNIX timestamp in seconds. The value must be on the hour or on the half hour and must be at least 30 minutes earlier than the end time.</para>
        /// <remarks>
        /// <para>When RepeatType is set to Permanent, StartTime is empty. When RepeatType is set to None, Daily, Weekly, or Monthly, StartTime must have a value.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1694761200</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC) firewall access control policy group.</para>
        /// <list type="bullet">
        /// <item><description><para>If the VPC firewall protects traffic between two VPCs connected through a CEN instance, the value of this parameter is the CEN instance ID.</para>
        /// </description></item>
        /// <item><description><para>If the VPC firewall protects traffic between two VPCs connected through an Express Connect circuit, the value of this parameter is the VPC firewall instance ID.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/159760.html">DescribeVpcFirewallAclGroupList</a> operation to query the ID.</para>
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
