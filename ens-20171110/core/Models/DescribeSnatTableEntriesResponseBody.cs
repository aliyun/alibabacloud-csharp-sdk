// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeSnatTableEntriesResponseBody : TeaModel {
        /// <summary>
        /// The page number.
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
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Details of SNAT entries.
        /// </summary>
        [NameInMap("SnatTableEntries")]
        [Validation(Required=false)]
        public List<DescribeSnatTableEntriesResponseBodySnatTableEntries> SnatTableEntries { get; set; }
        public class DescribeSnatTableEntriesResponseBodySnatTableEntries : TeaModel {
            /// <summary>
            /// The ID of the NAT gateway.
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
            /// The EIP specified in the SNAT entry.
            /// </summary>
            [NameInMap("SnatIp")]
            [Validation(Required=false)]
            public string SnatIp { get; set; }

            /// <summary>
            /// The source CIDR block specified in the SNAT entry.
            /// </summary>
            [NameInMap("SourceCIDR")]
            [Validation(Required=false)]
            public string SourceCIDR { get; set; }

            /// <summary>
            /// The secondary EIP. Multiple EIPs are separated by commas (,).
            /// </summary>
            [NameInMap("StandbySnatIp")]
            [Validation(Required=false)]
            public string StandbySnatIp { get; set; }

            /// <summary>
            /// The status of the secondary EIP. Valid values:
            /// 
            /// *   Running
            /// *   Stopping
            /// *   Stopped
            /// *   Starting
            /// </summary>
            [NameInMap("StandbyStatus")]
            [Validation(Required=false)]
            public string StandbyStatus { get; set; }

            /// <summary>
            /// The status of the SNAT entry. Valid values:
            /// 
            /// *   Pending: The SNAT entry is being created or modified.
            /// *   Available: The SNAT entry is available.
            /// *   Deleting: The SNAT entry is being deleted.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The number of SNAT entries that are returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
