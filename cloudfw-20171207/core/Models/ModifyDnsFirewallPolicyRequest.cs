// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyDnsFirewallPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The action that is performed on traffic that hits the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>accept</b>: Allow</para>
        /// </description></item>
        /// <item><description><para><b>drop</b>: Deny</para>
        /// </description></item>
        /// <item><description><para><b>log</b>: Monitor</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>log</para>
        /// </summary>
        [NameInMap("AclAction")]
        [Validation(Required=false)]
        public string AclAction { get; set; }

        /// <summary>
        /// <para>The unique ID of the access control policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00281255-d220-4db1-8f4f-c4df22****</para>
        /// </summary>
        [NameInMap("AclUuid")]
        [Validation(Required=false)]
        public string AclUuid { get; set; }

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
        /// <para>The destination address in the access control policy.</para>
        /// <list type="bullet">
        /// <item><description><para>If <b>DestinationType</b> is set to net, <b>Destination</b> specifies the destination CIDR block. For example: 1.2.3.4/24</para>
        /// </description></item>
        /// <item><description><para>If <b>DestinationType</b> is set to group, <b>Destination</b> specifies the name of the destination address book. For example: db_group</para>
        /// </description></item>
        /// <item><description><para>If <b>DestinationType</b> is set to domain, <b>Destination</b> specifies the destination domain name. For example: \*.aliyuncs.com</para>
        /// </description></item>
        /// <item><description><para>If <b>DestinationType</b> is set to location, <b>Destination</b> specifies the destination region. For more information about the location codes, see the following description. For example: [&quot;BJ11&quot;, &quot;ZB&quot;]</para>
        /// </description></item>
        /// </list>
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
        /// <item><description><para><b>net</b>: destination CIDR block (CIDR address)</para>
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
        /// <para>The language of the content within the request and response. Valid values:-<b>zh</b>: Chinese-<b>en</b>: English</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The priority of the access control policy before the modification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public string Priority { get; set; }

        /// <summary>
        /// <para>The status of the access control policy. By default, the policy is enabled after it is created. Valid values:</para>
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

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The source IP address of the visitor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The type of the source address in the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>net</b>: source CIDR block (CIDR)</para>
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

    }

}
