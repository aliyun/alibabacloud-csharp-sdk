// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeSnatAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the entry was created. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-04-26T15:38:27Z</para>
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// <para>The destination CIDR block. The rule takes effect only on requests that access the destination CIDR block.</para>
        /// 
        /// <b>Example:</b>
        /// <ol start="101">
        /// <item><description>XXX. XXX.0/24</description></item>
        /// </ol>
        /// </summary>
        [NameInMap("DestCIDR")]
        [Validation(Required=false)]
        public string DestCIDR { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable IP affinity. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b></para>
        /// </description></item>
        /// <item><description><para><b>true</b></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>After you enable IP affinity, if multiple EIPs are associated with an SNAT entry, one client uses the same EIP to for communication. If IP affinity is disabled, the client uses a random EIP for communication.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EipAffinity")]
        [Validation(Required=false)]
        public bool? EipAffinity { get; set; }

        /// <summary>
        /// <para>The timeout period. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("IdleTimeout")]
        [Validation(Required=false)]
        public int? IdleTimeout { get; set; }

        /// <summary>
        /// <para>Whether to enable operator affinity. Value taking:</para>
        /// <list type="bullet">
        /// <item><description><para>false:Do not open.</para>
        /// </description></item>
        /// <item><description><para>true:Open.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IspAffinity")]
        [Validation(Required=false)]
        public bool? IspAffinity { get; set; }

        /// <summary>
        /// <para>The ID of the Network Address Translation (NAT) gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nat-5t7nh1cfm6kxiszlttr38****</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the SNAT entry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>snat-5tfi6f8gds82mjmlofeym****</para>
        /// </summary>
        [NameInMap("SnatEntryId")]
        [Validation(Required=false)]
        public string SnatEntryId { get; set; }

        /// <summary>
        /// <para>The name of the SNAT entry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test0</para>
        /// </summary>
        [NameInMap("SnatEntryName")]
        [Validation(Required=false)]
        public string SnatEntryName { get; set; }

        /// <summary>
        /// <para>The EIP specified in the SNAT entry. Multiple EIPs are separated by commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <ol start="120">
        /// <item><description>XXX. XXX.71</description></item>
        /// </ol>
        /// </summary>
        [NameInMap("SnatIp")]
        [Validation(Required=false)]
        public string SnatIp { get; set; }

        /// <summary>
        /// <para>The information about the EIP specified in the SNAT entry.</para>
        /// </summary>
        [NameInMap("SnatIps")]
        [Validation(Required=false)]
        public List<DescribeSnatAttributeResponseBodySnatIps> SnatIps { get; set; }
        public class DescribeSnatAttributeResponseBodySnatIps : TeaModel {
            /// <summary>
            /// <para>The time when the IP address was created. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-04-26T15:38:27Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <ol start="203">
            /// <item><description>XXX. XXX.139</description></item>
            /// </ol>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The status of the IP address.</para>
            /// <list type="bullet">
            /// <item><description><para>Running</para>
            /// </description></item>
            /// <item><description><para>Stopping</para>
            /// </description></item>
            /// <item><description><para>Stopped</para>
            /// </description></item>
            /// <item><description><para>Starting</para>
            /// </description></item>
            /// <item><description><para>Releasing</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The source CIDR block specified in the SNAT entry.</para>
        /// 
        /// <b>Example:</b>
        /// <ol start="10">
        /// <item><description>XXX. XXX.0/24</description></item>
        /// </ol>
        /// </summary>
        [NameInMap("SourceCIDR")]
        [Validation(Required=false)]
        public string SourceCIDR { get; set; }

        /// <summary>
        /// <para>The secondary EIP specified in the SNAT entry. Multiple secondary EIPs are separated by commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <ol start="101">
        /// <item><description>XXX. XXX.4</description></item>
        /// </ol>
        /// </summary>
        [NameInMap("StandbySnatIp")]
        [Validation(Required=false)]
        public string StandbySnatIp { get; set; }

        /// <summary>
        /// <para>The status of the secondary EIP.</para>
        /// <list type="bullet">
        /// <item><description><para>Running</para>
        /// </description></item>
        /// <item><description><para>Stopping</para>
        /// </description></item>
        /// <item><description><para>Stopped</para>
        /// </description></item>
        /// <item><description><para>Starting</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Stopped</para>
        /// </summary>
        [NameInMap("StandbyStatus")]
        [Validation(Required=false)]
        public string StandbyStatus { get; set; }

        /// <summary>
        /// <para>The status of the SNAT entry.</para>
        /// <list type="bullet">
        /// <item><description><para>Pending: The SNAT entry is being created or modified.</para>
        /// </description></item>
        /// <item><description><para>Available: The SNAT entry is available.</para>
        /// </description></item>
        /// <item><description><para>Deleting: The SNAT entry is being deleted.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The type of the NAT.</para>
        /// <list type="bullet">
        /// <item><description><para>Empty: symmetric NAT.</para>
        /// </description></item>
        /// <item><description><para>FullCone: full cone NAT.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FullCone</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
