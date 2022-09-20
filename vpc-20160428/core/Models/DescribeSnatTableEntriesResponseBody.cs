// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeSnatTableEntriesResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SnatTableEntries")]
        [Validation(Required=false)]
        public DescribeSnatTableEntriesResponseBodySnatTableEntries SnatTableEntries { get; set; }
        public class DescribeSnatTableEntriesResponseBodySnatTableEntries : TeaModel {
            [NameInMap("SnatTableEntry")]
            [Validation(Required=false)]
            public List<DescribeSnatTableEntriesResponseBodySnatTableEntriesSnatTableEntry> SnatTableEntry { get; set; }
            public class DescribeSnatTableEntriesResponseBodySnatTableEntriesSnatTableEntry : TeaModel {
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

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
