// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeSnatTableEntriesResponseBody : TeaModel {
        /// <summary>
        /// The number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Details of SNAT entries.
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
                /// The ID of the NAT gateway to which the SNAT entry belongs.
                /// </summary>
                [NameInMap("NatGatewayId")]
                [Validation(Required=false)]
                public string NatGatewayId { get; set; }

                /// <summary>
                /// The ID of the SNAT entry.
                /// </summary>
                [NameInMap("SnatEntryId")]
                [Validation(Required=false)]
                public string SnatEntryId { get; set; }

                /// <summary>
                /// The name of the SNAT entry.
                /// </summary>
                [NameInMap("SnatEntryName")]
                [Validation(Required=false)]
                public string SnatEntryName { get; set; }

                /// <summary>
                /// *   When you query SNAT entries of Internet NAT gateways, this parameter indicates the EIP in an SNAT entry.
                /// *   When you query SNAT entries of VPC NAT gateways, this parameter indicates the NAT IP address in an SNAT entry.
                /// </summary>
                [NameInMap("SnatIp")]
                [Validation(Required=false)]
                public string SnatIp { get; set; }

                /// <summary>
                /// The ID of the SNAT table to which the SNAT entry belongs.
                /// </summary>
                [NameInMap("SnatTableId")]
                [Validation(Required=false)]
                public string SnatTableId { get; set; }

                /// <summary>
                /// The source CIDR block specified in the SNAT entry.
                /// </summary>
                [NameInMap("SourceCIDR")]
                [Validation(Required=false)]
                public string SourceCIDR { get; set; }

                /// <summary>
                /// *   When you query SNAT entries of Internet NAT gateways, this parameter indicates the ID of the vSwitch that uses SNAT to access the Internet.
                /// *   When you query SNAT entries of VPC NAT gateways, this parameter indicates the ID of the vSwitch that uses SNAT to access external networks.
                /// </summary>
                [NameInMap("SourceVSwitchId")]
                [Validation(Required=false)]
                public string SourceVSwitchId { get; set; }

                /// <summary>
                /// The status of the SNAT entry. Valid values:
                /// 
                /// *   **Pending**
                /// *   **Available**
                /// *   **Deleting**
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// The number of returned entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
