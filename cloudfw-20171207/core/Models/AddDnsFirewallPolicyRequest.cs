// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class AddDnsFirewallPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The action that Cloud Firewall performs on the traffic in the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>accept</b>: Allow.</description></item>
        /// <item><description><b>drop</b>: Deny.</description></item>
        /// <item><description><b>log</b>: Monitor.</description></item>
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
        /// <para>Allow specified domain names</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The destination address in the access control policy.</para>
        /// <list type="bullet">
        /// <item><description>If <b>DestinationType</b> is set to net, <b>Destination</b> is a destination CIDR block. Example: 1.2.3.4/24.</description></item>
        /// <item><description>If <b>DestinationType</b> is set to group, <b>Destination</b> is a destination address book name. Example: db_group.</description></item>
        /// <item><description>If <b>DestinationType</b> is set to domain, <b>Destination</b> is a destination domain name. Example: *.aliyuncs.com.</description></item>
        /// <item><description>If <b>DestinationType</b> is set to location, <b>Destination</b> is a destination area (see the area positional encoding below). Example: [&quot;BJ11&quot;, &quot;ZB&quot;\].</description></item>
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
        /// <para>The type of the destination address in the DNS firewall access control policy. Only group (destination address book) and domain (destination domain name) are supported. net and CIDR addresses are not applicable to this operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>domain</para>
        /// </summary>
        [NameInMap("DestinationType")]
        [Validation(Required=false)]
        public string DestinationType { get; set; }

        /// <summary>
        /// <para>The traffic direction of the DNS firewall access control policy.</para>
        /// <remarks>
        /// <para>This parameter is not validated on the backend. When you create or modify a DNS firewall policy, the direction is always stored as <b>out</b> (outbound). Passing <b>in</b> does not cause an error or take effect. The DNS firewall supports only outbound policies.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>out</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The IP address version. Valid values:</para>
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
        /// <para>The language of the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
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
        /// <para>The policy priority of the DNS firewall policy. Valid values: 1 to 20000. A smaller value indicates a higher policy priority.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public string Priority { get; set; }

        /// <summary>
        /// <para>The enabled status of the access control policy. The policy is enabled by default after creation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enable the access control policy.</description></item>
        /// <item><description><b>false</b>: Disable the access control policy.</description></item>
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
        /// <para>The source address in the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If <b>SourceType</b> is set to <c>net</c>, Source is a source CIDR block. Example: 10.2.XX.XX/24.</para>
        /// </description></item>
        /// <item><description><para>If <b>SourceType</b> is set to <c>group</c>, Source is a source address book name. Example: db_group.</para>
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
