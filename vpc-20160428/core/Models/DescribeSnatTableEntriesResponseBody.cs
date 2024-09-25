// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeSnatTableEntriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of the returned page.</para>
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
        /// <para>5</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6D7E89B1-1C5B-412B-8585-4908E222EED5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Details of SNAT entries.</para>
        /// </summary>
        [NameInMap("SnatTableEntries")]
        [Validation(Required=false)]
        public DescribeSnatTableEntriesResponseBodySnatTableEntries SnatTableEntries { get; set; }
        public class DescribeSnatTableEntriesResponseBodySnatTableEntries : TeaModel {
            [NameInMap("SnatTableEntry")]
            [Validation(Required=false)]
            public List<DescribeSnatTableEntriesResponseBodySnatTableEntriesSnatTableEntry> SnatTableEntry { get; set; }
            public class DescribeSnatTableEntriesResponseBodySnatTableEntriesSnatTableEntry : TeaModel {
                [NameInMap("EipAffinity")]
                [Validation(Required=false)]
                public string EipAffinity { get; set; }

                /// <summary>
                /// <para>The ID of the NAT gateway to which the SNAT entry belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ngw-bp1uewa15k4iy5770****</para>
                /// </summary>
                [NameInMap("NatGatewayId")]
                [Validation(Required=false)]
                public string NatGatewayId { get; set; }

                [NameInMap("NetworkInterfaceId")]
                [Validation(Required=false)]
                public string NetworkInterfaceId { get; set; }

                /// <summary>
                /// <para>The ID of the SNAT entry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>snat-kmd6nv8fy****</para>
                /// </summary>
                [NameInMap("SnatEntryId")]
                [Validation(Required=false)]
                public string SnatEntryId { get; set; }

                /// <summary>
                /// <para>The name of the SNAT entry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SnatEntry-1</para>
                /// </summary>
                [NameInMap("SnatEntryName")]
                [Validation(Required=false)]
                public string SnatEntryName { get; set; }

                /// <summary>
                /// <list type="bullet">
                /// <item><description>When you query SNAT entries of Internet NAT gateways, this parameter indicates the EIP in an SNAT entry.</description></item>
                /// <item><description>When you query SNAT entries of VPC NAT gateways, this parameter indicates the NAT IP address in an SNAT entry.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>116.22.XX.XX</para>
                /// </summary>
                [NameInMap("SnatIp")]
                [Validation(Required=false)]
                public string SnatIp { get; set; }

                /// <summary>
                /// <para>The ID of the SNAT table to which the SNAT entry belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>stb-gz3r3odawdgffde****</para>
                /// </summary>
                [NameInMap("SnatTableId")]
                [Validation(Required=false)]
                public string SnatTableId { get; set; }

                /// <summary>
                /// <para>The source CIDR block specified in the SNAT entry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>116.22.XX.XX/24</para>
                /// </summary>
                [NameInMap("SourceCIDR")]
                [Validation(Required=false)]
                public string SourceCIDR { get; set; }

                /// <summary>
                /// <list type="bullet">
                /// <item><description>When you query SNAT entries of Internet NAT gateways, this parameter indicates the ID of the vSwitch that uses SNAT to access the Internet.</description></item>
                /// <item><description>When you query SNAT entries of VPC NAT gateways, this parameter indicates the ID of the vSwitch that uses SNAT to access external networks.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-3xbdsffvfgdfds****</para>
                /// </summary>
                [NameInMap("SourceVSwitchId")]
                [Validation(Required=false)]
                public string SourceVSwitchId { get; set; }

                /// <summary>
                /// <para>The status of the SNAT entry. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Pending</b></description></item>
                /// <item><description><b>Available</b></description></item>
                /// <item><description><b>Deleting</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Pending</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
