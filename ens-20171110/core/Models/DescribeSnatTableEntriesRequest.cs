// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeSnatTableEntriesRequest : TeaModel {
        /// <summary>
        /// The ID of the Network Address Translation (NAT) gateway.
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// The page number. Pages start from page **1**.
        /// 
        /// Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. The maximum value is **100**.
        /// 
        /// Default value: **10**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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
        /// The elastic IP address (EIP) specified in the SNAT entry.
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

    }

}
