// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeDnsFirewallPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The action that is performed on traffic that hits the DNS firewall policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>accept</b>: allows the traffic.</para>
        /// </description></item>
        /// <item><description><para><b>drop</b>: denies the traffic.</para>
        /// </description></item>
        /// <item><description><para><b>log</b>: monitors the traffic.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify this parameter, policies of all action types are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>accept</para>
        /// </summary>
        [NameInMap("AclAction")]
        [Validation(Required=false)]
        public string AclAction { get; set; }

        /// <summary>
        /// <para>The unique ID of the firewall rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b6c8f905-2eb6-442a-ba35-9416e****</para>
        /// </summary>
        [NameInMap("AclUuid")]
        [Validation(Required=false)]
        public string AclUuid { get; set; }

        /// <summary>
        /// <para>The page number to return. Default value: 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// <para>The description of the DNS firewall policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The destination address in the DNS firewall policy. Fuzzy match is supported.</para>
        /// <remarks>
        /// <para>The value of Destination can be a CIDR block, a domain name, or an address book.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10.2.XX.XX/24</para>
        /// </summary>
        [NameInMap("Destination")]
        [Validation(Required=false)]
        public string Destination { get; set; }

        /// <summary>
        /// <para>The IP version that is supported. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>4</b>: IPv4</para>
        /// </description></item>
        /// <item><description><para><b>6</b>: IPv6</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

        /// <summary>
        /// <para>The language of the response messages. Valid values: <b>zh</b> (Chinese) and <b>en</b> (English).</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The status of the access control policy. The policy is enabled by default after it is created. Valid values:</para>
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
        /// <para>The source address in the DNS firewall policy. Fuzzy match is supported.</para>
        /// <remarks>
        /// <para>The value of Source can be a CIDR block or an address book.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX/24</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>140.205.118.XXX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
