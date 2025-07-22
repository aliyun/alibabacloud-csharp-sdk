// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeSnatTableEntriesResponseBody : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SnatTableEntries")]
        [Validation(Required=false)]
        public List<DescribeSnatTableEntriesResponseBodySnatTableEntries> SnatTableEntries { get; set; }
        public class DescribeSnatTableEntriesResponseBodySnatTableEntries : TeaModel {
            [NameInMap("EipAffinity")]
            [Validation(Required=false)]
            public string EipAffinity { get; set; }

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

            [NameInMap("SnatTableId")]
            [Validation(Required=false)]
            public string SnatTableId { get; set; }

            [NameInMap("SourceCIDR")]
            [Validation(Required=false)]
            public string SourceCIDR { get; set; }

            [NameInMap("SourceVSwitchId")]
            [Validation(Required=false)]
            public string SourceVSwitchId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
