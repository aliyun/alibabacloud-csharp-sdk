// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyVpcFirewallControlPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The action that Cloud Firewall performs on the traffic.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>accept</b>: allows the traffic.</description></item>
        /// <item><description><b>drop</b>: blocks the traffic.</description></item>
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

        /// <summary>
        /// <para>The unique ID of the access control policy.</para>
        /// <para>If you want to modify the configurations of an access control policy, you must provide the unique ID of the policy. You can call the <a href="https://help.aliyun.com/document_detail/159758.html">DescribeVpcFirewallControlPolicy</a> operation to query the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00281255-d220-4db1-8f4f-c4df221a****</para>
        /// </summary>
        [NameInMap("AclUuid")]
        [Validation(Required=false)]
        public string AclUuid { get; set; }

        /// <summary>
        /// <para>The type of the application that the access control policy supports.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ANY: all application types</description></item>
        /// <item><description>FTP</description></item>
        /// <item><description>HTTP</description></item>
        /// <item><description>HTTPS</description></item>
        /// <item><description>MySQL</description></item>
        /// <item><description>SMTP</description></item>
        /// <item><description>SMTPS</description></item>
        /// <item><description>RDP</description></item>
        /// <item><description>VNC</description></item>
        /// <item><description>SSH</description></item>
        /// <item><description>Redis</description></item>
        /// <item><description>MQTT</description></item>
        /// <item><description>MongoDB</description></item>
        /// <item><description>Memcache</description></item>
        /// <item><description>SSL</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// <para>The application names.</para>
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
        /// <para>The type of the destination port in the access control policy.</para>
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
        /// <para>The destination address in the access control policy.</para>
        /// <list type="bullet">
        /// <item><description><para>If <b>DestinationType</b> is set to <c>net</c>, the value of this parameter must be a CIDR block.</para>
        /// <para>Example: 10.2.3.0/24</para>
        /// </description></item>
        /// <item><description><para>If <b>DestinationType</b> is set to <c>group</c>, the value of this parameter must be an address book name.</para>
        /// <para>Example: db_group</para>
        /// </description></item>
        /// <item><description><para>If <b>DestinationType</b> is set to <c>domain</c>, the value of this parameter must be a domain name.</para>
        /// <para>Example: \*.aliyuncs.com</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
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
        /// <item><description><b>net</b>: CIDR block</description></item>
        /// <item><description><b>group</b>: address book</description></item>
        /// <item><description><b>domain</b>: domain name</description></item>
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
        /// <para> If you set RepeatType to Permanent, leave this parameter empty. If you set RepeatType to None, Daily, Weekly, or Monthly, you must specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1694764800</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The language of the content within the response.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese (default)</description></item>
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
        /// <para>The protocol type in the access control policy.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ANY: all protocol types</description></item>
        /// <item><description>TCP</description></item>
        /// <item><description>UDP</description></item>
        /// <item><description>ICMP</description></item>
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
        /// <para>Specifies whether to enable the access control policy. By default, an access control policy is enabled after the policy is created. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables the access control policy.</description></item>
        /// <item><description><b>false</b>: disables the access control policy.</description></item>
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
        /// <item><description>If you set RepeatType to <c>Permanent</c>, <c>None</c>, or <c>Daily</c>, the value of this parameter is an empty array. Example: [].</description></item>
        /// <item><description>If you set RepeatType to Weekly, you must specify this parameter. Example: [0, 6].</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you set RepeatType to Weekly, the fields in the value of this parameter cannot be repeated.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If you set RepeatType to <c>Monthly</c>, you must specify this parameter. Example: [1, 31].</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you set RepeatType to Monthly, the fields in the value of this parameter cannot be repeated.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("RepeatDays")]
        [Validation(Required=false)]
        public List<long?> RepeatDays { get; set; }

        /// <summary>
        /// <para>The point in time when the recurrence ends. Example: 23:30. The value must be on the hour or on the half hour, and at least 30 minutes later than the value of RepeatStartTime.</para>
        /// <remarks>
        /// <para> If you set RepeatType to Permanent or None, leave this parameter empty. If you set RepeatType to Daily, Weekly, or Monthly, you must specify this parameter.</para>
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
        /// <para> If you set RepeatType to Permanent or None, leave this parameter empty. If you set RepeatType to Daily, Weekly, or Monthly, you must specify this parameter.</para>
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
        /// <para>The source address in the access control policy.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If <b>SourceType</b> is set to <c>net</c>, the value of this parameter must be a CIDR block.</para>
        /// <para>Example: 10.2.4.0/24</para>
        /// </description></item>
        /// <item><description><para>If <b>SourceType</b> is set to <c>group</c>, the value of this parameter must be an address book name.</para>
        /// <para>Example: db_group</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
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
        /// <item><description><b>net</b>: CIDR block</description></item>
        /// <item><description><b>group</b>: address book</description></item>
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
        /// <para>The time when the access control policy starts to take effect. The value is a UNIX timestamp. Unit: seconds. The value must be on the hour or on the half hour, and at least 30 minutes earlier than the value of EndTime.</para>
        /// <remarks>
        /// <para> If you set RepeatType to Permanent, leave this parameter empty. If you set RepeatType to None, Daily, Weekly, or Monthly, you must specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1694761200</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The instance ID of the VPC firewall. You can call the <a href="https://help.aliyun.com/document_detail/159760.html">DescribeVpcFirewallAclGroupList</a> operation to query the ID.</para>
        /// <list type="bullet">
        /// <item><description><para>If the VPC firewall is used to protect a CEN instance, the value of this parameter must be the ID of the CEN instance.</para>
        /// <para>Example: cen-ervw0g12b5jbw\<em>\</em>\<em>\</em></para>
        /// </description></item>
        /// <item><description><para>If the VPC firewall is used to protect an Express Connect circuit, the value of this parameter must be the instance ID of the VPC firewall.</para>
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
