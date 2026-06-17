// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class AddDnsFirewallPolicyRequest : TeaModel {
        /// <summary>
        /// <para>Specifies the action to take on traffic that matches the access control policy. Valid values:</para>
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
        /// <para>log</para>
        /// </summary>
        [NameInMap("AclAction")]
        [Validation(Required=false)]
        public string AclAction { get; set; }

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
        /// <para>The destination address in the access control policy.</para>
        /// <list type="bullet">
        /// <item><description><para>When <b>DestinationType</b> is <c>net</c>, this parameter specifies the destination CIDR block. Example: <c>1.2.3.4/24</c>.</para>
        /// </description></item>
        /// <item><description><para>When <b>DestinationType</b> is <c>group</c>, this parameter specifies the name of the destination address book. Example: <c>db_group</c>.</para>
        /// </description></item>
        /// <item><description><para>When <b>DestinationType</b> is <c>domain</c>, this parameter specifies the destination domain name. Example: <c>*.aliyuncs.com</c>.</para>
        /// </description></item>
        /// <item><description><para>When <b>DestinationType</b> is <c>location</c>, this parameter specifies the destination region. For more information about location codes, see the documentation. Example: <c>[&quot;BJ11&quot;, &quot;ZB&quot;]</c>.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>db_group</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>domain</para>
        /// </summary>
        [NameInMap("DestinationType")]
        [Validation(Required=false)]
        public string DestinationType { get; set; }

        /// <summary>
        /// <para>The traffic direction for the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>in</b>: inbound traffic</para>
        /// </description></item>
        /// <item><description><para><b>out</b>: outbound traffic</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>out</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The IP version supported by the policy.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>4</b>: IPv4</para>
        /// </description></item>
        /// <item><description><para><b>6</b>: IPv6</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Valid values:<br>-<b>zh</b>: Chinese<br>-<b>en</b>: English<br><br></para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The priority of the access control policy. A smaller value indicates a higher priority.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public string Priority { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enables the access control policy.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disables the access control policy.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Release")]
        [Validation(Required=false)]
        public string Release { get; set; }

        /// <summary>
        /// <para>The source address in the access control policy.</para>
        /// <list type="bullet">
        /// <item><description><para>When <b>SourceType</b> is <c>net</c>, this parameter specifies the source CIDR block. Example: <c>10.2.XX.XX/24</c>.</para>
        /// </description></item>
        /// <item><description><para>When <b>SourceType</b> is <c>group</c>, this parameter specifies the name of the source address book. Example: <c>db_group</c>.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.223/32</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>140.205.118.97</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The type of the source address in the access control policy. Valid values:</para>
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

    }

}
