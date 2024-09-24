// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyNatFirewallControlPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The action that Cloud Firewall performs on the traffic. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>accept</b>: allows the traffic.</description></item>
        /// <item><description><b>drop</b>: denies the traffic.</description></item>
        /// <item><description><b>log</b>: monitors the traffic.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>log</para>
        /// </summary>
        [NameInMap("AclAction")]
        [Validation(Required=false)]
        public string AclAction { get; set; }

        /// <summary>
        /// <para>The UUID of the access control policy.</para>
        /// <para>To modify the configurations of an access control policy, you must provide the UUID of the policy. You can call the DescribeNatFirewallControlPolicy operation to query the UUIDs of access control policies.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>61ab1c02-926a-4d1b-9ef7-595eed8c4226</para>
        /// </summary>
        [NameInMap("AclUuid")]
        [Validation(Required=false)]
        public string AclUuid { get; set; }

        /// <summary>
        /// <para>The name of the application.</para>
        /// </summary>
        [NameInMap("ApplicationNameList")]
        [Validation(Required=false)]
        public List<string> ApplicationNameList { get; set; }

        /// <summary>
        /// <para>The description of the access control policy. Fuzzy match is supported.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the descriptions of all policies are queried.</para>
        /// </remarks>
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
        /// <para>If <b>DestPortType</b> is set to <c>port</c>, you must specify this parameter.</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>my_dest_port_group</para>
        /// </summary>
        [NameInMap("DestPortGroup")]
        [Validation(Required=false)]
        public string DestPortGroup { get; set; }

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
        /// <para>The destination address in the access control policy.</para>
        /// <list type="bullet">
        /// <item><description>If <b>DestinationType</b> is set to net, the value of <b>Destination</b> is a CIDR block. Example: 1.2.3.4/24</description></item>
        /// <item><description>If <b>DestinationType</b> is set to group, the value of <b>Destination</b> is an address book. Example: db_group</description></item>
        /// <item><description>If <b>DestinationType</b> is set to domain, the value of <b>Destination</b> is a domain name. Example: \*.aliyuncs.com</description></item>
        /// <item><description>If <b>DestinationType</b> is set to location, the value of <b>Destination</b> is a location. For more information about the location codes, see the &quot;AddControlPolicy&quot; topic. Example: [&quot;BJ11&quot;, &quot;ZB&quot;]</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>x.x.x.x/32</para>
        /// </summary>
        [NameInMap("Destination")]
        [Validation(Required=false)]
        public string Destination { get; set; }

        /// <summary>
        /// <para>The type of the destination address in the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>net</b>: CIDR block</description></item>
        /// <item><description><b>group</b>: address book</description></item>
        /// <item><description><b>domain</b>: domain name</description></item>
        /// <item><description><b>location</b>: destination location</description></item>
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
        /// <para>The direction of the traffic to which the access control policy applies. Valid value:</para>
        /// <list type="bullet">
        /// <item><description><b>out</b>: outbound.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>out</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The domain name resolution method of the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Fully qualified domain name (FQDN)-based resolution</description></item>
        /// <item><description><b>1</b>: Domain Name System (DNS)-based dynamic resolution</description></item>
        /// <item><description><b>2</b>: FQDN and DNS-based dynamic resolution</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
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
        /// <para>The language of the content within the request and the response. Valid values:</para>
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
        /// <para>The ID of the NAT gateway.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ngw-xxxxxx</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// <para>The protocol type in the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ANY</b></description></item>
        /// <item><description><b>TCP</b></description></item>
        /// <item><description><b>UDP</b></description></item>
        /// <item><description><b>ICMP</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> The value <b>ANY</b> indicates all types of applications.</para>
        /// </remarks>
        /// <remarks>
        /// <para> If the destination address type is a threat intelligence address book of the domain name type or a cloud service address book, you can set Proto to TCP. If you set Proto to TCP, you can set application types to HTTP, HTTPS, SMTP, SMTPS, and SSL.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TCP</para>
        /// </summary>
        [NameInMap("Proto")]
        [Validation(Required=false)]
        public string Proto { get; set; }

        /// <summary>
        /// <para>The status of the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enabled</description></item>
        /// <item><description><b>false</b>: disabled</description></item>
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
        /// <item><description>If <b>SourceType</b> is set to <c>net</c>, the value of this parameter is a CIDR block. Example: 10.2.XX.XX/24.</description></item>
        /// <item><description>If <b>SourceType</b> is set to <c>group</c>, the value of this parameter is an address book name. Example: db_group.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.25/32</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The type of the source address in the access control policy. Valid values:</para>
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

}
