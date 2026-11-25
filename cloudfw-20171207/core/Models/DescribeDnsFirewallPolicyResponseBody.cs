// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeDnsFirewallPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public string PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries to return in the current query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The information about the access control policy of the DNS firewall.</para>
        /// </summary>
        [NameInMap("Policys")]
        [Validation(Required=false)]
        public List<DescribeDnsFirewallPolicyResponseBodyPolicys> Policys { get; set; }
        public class DescribeDnsFirewallPolicyResponseBodyPolicys : TeaModel {
            /// <summary>
            /// <para>The action that Cloud Firewall performs on the traffic in the access control policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>accept</b>: Allow</description></item>
            /// <item><description><b>drop</b>: Deny</description></item>
            /// <item><description><b>log</b>: Monitor</description></item>
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
            /// 
            /// <b>Example:</b>
            /// <para>01281255-d220-4db1-8f4f-c4df221a****</para>
            /// </summary>
            [NameInMap("AclUuid")]
            [Validation(Required=false)]
            public string AclUuid { get; set; }

            /// <summary>
            /// <para>The description of the access control policy of the DNS border firewall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The destination address in the access control policy of the DNS border firewall. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>If <b>DestinationType</b> is set to <c>net</c>, the value of Destination is the destination CIDR block.</para>
            /// </description></item>
            /// <item><description><para>If <b>DestinationType</b> is set to <c>domain</c>, the value of Destination is the destination domain name.</para>
            /// </description></item>
            /// <item><description><para>If <b>DestinationType</b> is set to <c>group</c>, the value of Destination is the name of the destination address book.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>x.x.x.x/32</para>
            /// </summary>
            [NameInMap("Destination")]
            [Validation(Required=false)]
            public string Destination { get; set; }

            /// <summary>
            /// <para>The list of addresses in the destination address book.</para>
            /// </summary>
            [NameInMap("DestinationAddrs")]
            [Validation(Required=false)]
            public List<string> DestinationAddrs { get; set; }

            /// <summary>
            /// <para>The type of the destination address book in the access control policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ip</b>: IP address book, which contains one or more CIDR blocks</description></item>
            /// <item><description><b>domain</b>: domain name address book, which contains one or more domain names</description></item>
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
            /// <item><description><b>net</b>: destination CIDR block</description></item>
            /// <item><description><b>group</b>: destination address book</description></item>
            /// <item><description><b>domain</b>: destination domain name</description></item>
            /// <item><description><b>location</b>: destination region</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>net</para>
            /// </summary>
            [NameInMap("DestinationType")]
            [Validation(Required=false)]
            public string DestinationType { get; set; }

            /// <summary>
            /// <para>The traffic direction of the access control policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>in</b>: inbound traffic</description></item>
            /// <item><description><b>out</b>: outbound traffic</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>in</para>
            /// </summary>
            [NameInMap("Direction")]
            [Validation(Required=false)]
            public string Direction { get; set; }

            /// <summary>
            /// <para>The latest hit UNIX timestamp. The value is a UNIX timestamp in seconds.</para>
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
            /// <para>The IP address version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>4</b>: IPv4</description></item>
            /// <item><description><b>6</b>: IPv6</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public int? IpVersion { get; set; }

            /// <summary>
            /// <para>The priority of the access control policy. A smaller value indicates a higher priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>110</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The status of the access control policy. By default, the policy is enabled after it is created. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Enabled</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Disabled</para>
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
            /// <para>The source address in the access control policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>If <b>SourceType</b> is set to <c>net</c>, the source address is a CIDR block. Example: 192.0.XX.XX/24.</description></item>
            /// <item><description>If <b>SourceType</b> is set to <c>group</c>, the source address is the name of the source address book. Example: db_group.</description></item>
            /// <item><description>If <b>SourceType</b> is set to <c>location</c>, the source address is an area. For more information about the specific area positional encoding, see <a href="https://help.aliyun.com/document_detail/138867.html">AddControlPolicy</a>. Example: [&quot;BJ11&quot;, &quot;ZB&quot;].</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>192.0.XX.XX/24</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The source addresses.</para>
            /// </summary>
            [NameInMap("SourceAddrs")]
            [Validation(Required=false)]
            public List<string> SourceAddrs { get; set; }

            /// <summary>
            /// <para>The type of the source address book in the access control policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>ip</b>: IP address book, which contains one or more CIDR blocks.</para>
            /// </description></item>
            /// <item><description><para><b>tag</b>: ECS tag-based address book, which contains the IP addresses of one or more ECS tags.</para>
            /// </description></item>
            /// <item><description><para><b>domain</b>: domain name address book, which contains one or more domain names.</para>
            /// </description></item>
            /// <item><description><para><b>threat</b>: threat intelligence address book, which contains one or more malicious IP addresses or domain names.</para>
            /// </description></item>
            /// <item><description><para><b>backsrc</b>: back-to-origin address book, which contains the back-to-origin IP addresses of one or more Anti-DDoS or WAF instances.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ip</para>
            /// </summary>
            [NameInMap("SourceGroupType")]
            [Validation(Required=false)]
            public string SourceGroupType { get; set; }

            /// <summary>
            /// <para>The type of the source address in the access control policy of the DNS border firewall. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>net</b>: source CIDR block</description></item>
            /// <item><description><b>group</b>: source address book</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>net</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0A4ACDE9-9F9F-56C1-B3B7-60971BA1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
