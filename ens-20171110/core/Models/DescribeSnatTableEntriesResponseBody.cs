// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeSnatTableEntriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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
        /// <para>The details of the SNAT entries.</para>
        /// </summary>
        [NameInMap("SnatTableEntries")]
        [Validation(Required=false)]
        public List<DescribeSnatTableEntriesResponseBodySnatTableEntries> SnatTableEntries { get; set; }
        public class DescribeSnatTableEntriesResponseBodySnatTableEntries : TeaModel {
            /// <summary>
            /// <para>The timeout period for idle connections. Valid values: <b>1</b> to <b>86400</b>. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>900</para>
            /// </summary>
            [NameInMap("IdleTimeout")]
            [Validation(Required=false)]
            public int? IdleTimeout { get; set; }

            /// <summary>
            /// <para>The ID of the NAT gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nat-5t7nh1cfm6kxiszlttr38****</para>
            /// </summary>
            [NameInMap("NatGatewayId")]
            [Validation(Required=false)]
            public string NatGatewayId { get; set; }

            /// <summary>
            /// <para>The ID of the SNAT entry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>snat-5tfjp3537mi6iokl59g5c****</para>
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
            /// <para>The EIP specified in the SNAT entry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120.XXX.XXX.71</para>
            /// </summary>
            [NameInMap("SnatIp")]
            [Validation(Required=false)]
            public string SnatIp { get; set; }

            /// <summary>
            /// <para>The source CIDR block specified in the SNAT entry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.13/32</para>
            /// </summary>
            [NameInMap("SourceCIDR")]
            [Validation(Required=false)]
            public string SourceCIDR { get; set; }

            /// <summary>
            /// <para>The secondary EIP. Multiple EIPs are separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>101.XXX.XXX.7</para>
            /// </summary>
            [NameInMap("StandbySnatIp")]
            [Validation(Required=false)]
            public string StandbySnatIp { get; set; }

            /// <summary>
            /// <para>The status of the secondary EIP. Valid values:</para>
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
            /// <para>The status of the SNAT entry. Valid values:</para>
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

        }

        /// <summary>
        /// <para>The number of SNAT entries that are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
