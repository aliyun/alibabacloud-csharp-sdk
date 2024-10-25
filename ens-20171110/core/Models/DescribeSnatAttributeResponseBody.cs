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
        /// <para>101.10. XX.XX/24</para>
        /// </summary>
        [NameInMap("DestCIDR")]
        [Validation(Required=false)]
        public string DestCIDR { get; set; }

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
        /// <para>120.72.XX.XX</para>
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
            /// <para>203.132.XX.XX</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The status of the IP address.</para>
            /// <list type="bullet">
            /// <item><description>Running</description></item>
            /// <item><description>Stopping</description></item>
            /// <item><description>Stopped</description></item>
            /// <item><description>Starting</description></item>
            /// <item><description>Releasing</description></item>
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
        /// <para>10.0.XX.XX/24</para>
        /// </summary>
        [NameInMap("SourceCIDR")]
        [Validation(Required=false)]
        public string SourceCIDR { get; set; }

        /// <summary>
        /// <para>The secondary EIP specified in the SNAT entry. Multiple secondary EIPs are separated by commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>101.23. XX.XX</para>
        /// </summary>
        [NameInMap("StandbySnatIp")]
        [Validation(Required=false)]
        public string StandbySnatIp { get; set; }

        /// <summary>
        /// <para>The status of the secondary EIP.</para>
        /// <list type="bullet">
        /// <item><description>Running</description></item>
        /// <item><description>Stopping</description></item>
        /// <item><description>Stopped</description></item>
        /// <item><description>Starting</description></item>
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
        /// <item><description>Pending: The SNAT entry is being created or modified.</description></item>
        /// <item><description>Available: The SNAT entry is available.</description></item>
        /// <item><description>Deleting: The SNAT entry is being deleted.</description></item>
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
        /// <item><description>Empty: symmetric NAT.</description></item>
        /// <item><description>FullCone: full cone NAT.</description></item>
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
