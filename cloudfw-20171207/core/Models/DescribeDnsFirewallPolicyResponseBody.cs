// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeDnsFirewallPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public string PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The DNS firewall access control policies.</para>
        /// </summary>
        [NameInMap("Policys")]
        [Validation(Required=false)]
        public List<DescribeDnsFirewallPolicyResponseBodyPolicys> Policys { get; set; }
        public class DescribeDnsFirewallPolicyResponseBodyPolicys : TeaModel {
            /// <summary>
            /// <para>The action that is performed on traffic that matches the access control policy. Valid values:</para>
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
            /// 
            /// <b>Example:</b>
            /// <para>01281255-d220-4db1-8f4f-c4df221a****</para>
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
            /// <para>The destination address in the access control policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>If <b>DestinationType</b> is <c>net</c>, the value of this parameter is a destination CIDR block.</para>
            /// </description></item>
            /// <item><description><para>If <b>DestinationType</b> is <c>domain</c>, the value of this parameter is a destination domain.</para>
            /// </description></item>
            /// <item><description><para>If <b>DestinationType</b> is <c>group</c>, the value of this parameter is the name of a destination address book.</para>
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
            /// <para>The destination addresses in the address book.</para>
            /// </summary>
            [NameInMap("DestinationAddrs")]
            [Validation(Required=false)]
            public List<string> DestinationAddrs { get; set; }

            /// <summary>
            /// <para>The type of the destination address book in the access control policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>ip</b>: an IP address book</para>
            /// </description></item>
            /// <item><description><para><b>domain</b>: a domain address book</para>
            /// </description></item>
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
            /// <item><description><para><b>net</b>: destination CIDR block</para>
            /// </description></item>
            /// <item><description><para><b>group</b>: destination address book</para>
            /// </description></item>
            /// <item><description><para><b>domain</b>: destination domain</para>
            /// </description></item>
            /// <item><description><para><b>location</b>: destination location</para>
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
            /// <para>The direction of the traffic to which the access control policy applies. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>in</b>: inbound traffic</para>
            /// </description></item>
            /// <item><description><para><b>out</b>: outbound traffic</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>in</para>
            /// </summary>
            [NameInMap("Direction")]
            [Validation(Required=false)]
            public string Direction { get; set; }

            /// <summary>
            /// <para>The last time the policy was hit. The value is a UNIX timestamp. Unit: seconds.</para>
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
            /// <para>The IP version supported by the access control policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>4</b>: IPv4</para>
            /// </description></item>
            /// <item><description><para><b>6</b>: IPv6</para>
            /// </description></item>
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
            /// <para>Indicates whether the access control policy is enabled. After a policy is created, it is enabled by default. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: enabled</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: disabled</para>
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
            /// <item><description><para>If <b>SourceType</b> is <c>net</c>, the value of this parameter is a source CIDR block. Example: 192.0.XX.XX/24.</para>
            /// </description></item>
            /// <item><description><para>If <b>SourceType</b> is <c>group</c>, the value of this parameter is the name of a source address book. Example: db_group.</para>
            /// </description></item>
            /// <item><description><para>If <b>SourceType</b> is <c>location</c>, the value of this parameter is a location. For more information about the valid values of this parameter, see <a href="https://help.aliyun.com/document_detail/138867.html">AddControlPolicy</a>. Example: [&quot;BJ11&quot;, &quot;ZB&quot;].</para>
            /// </description></item>
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
            /// <item><description><para><b>ip</b>: an IP address book</para>
            /// </description></item>
            /// <item><description><para><b>tag</b>: a tag address book</para>
            /// </description></item>
            /// <item><description><para><b>domain</b>: a domain address book</para>
            /// </description></item>
            /// <item><description><para><b>threat</b>: a threat intelligence address book</para>
            /// </description></item>
            /// <item><description><para><b>backsrc</b>: a back-to-origin address book</para>
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
            /// <para>The type of the source address in the access control policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>net</b>: a source CIDR block</para>
            /// </description></item>
            /// <item><description><para><b>group</b>: a source address book</para>
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
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
