// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeSnatTableEntriesResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SnatTableEntries")]
        [Validation(Required=false)]
        public List<DescribeSnatTableEntriesResponseBodySnatTableEntries> SnatTableEntries { get; set; }
        public class DescribeSnatTableEntriesResponseBodySnatTableEntries : TeaModel {
            [NameInMap("NatGatewayId")]
            [Validation(Required=false)]
            public string NatGatewayId { get; set; }

            [NameInMap("SnatEntryId")]
            [Validation(Required=false)]
            public string SnatEntryId { get; set; }

            [NameInMap("SnatEntryName")]
            [Validation(Required=false)]
            public string SnatEntryName { get; set; }

            [NameInMap("SnatIp")]
            [Validation(Required=false)]
            public string SnatIp { get; set; }

            [NameInMap("SourceCIDR")]
            [Validation(Required=false)]
            public string SourceCIDR { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
