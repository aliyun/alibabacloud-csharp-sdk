// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeSnatTableEntriesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("SnatTableEntries")]
        [Validation(Required=false)]
        public DescribeSnatTableEntriesResponseBodySnatTableEntries SnatTableEntries { get; set; }
        public class DescribeSnatTableEntriesResponseBodySnatTableEntries : TeaModel {
            [NameInMap("SnatTableEntry")]
            [Validation(Required=false)]
            public List<DescribeSnatTableEntriesResponseBodySnatTableEntriesSnatTableEntry> SnatTableEntry { get; set; }
            public class DescribeSnatTableEntriesResponseBodySnatTableEntriesSnatTableEntry : TeaModel {
                public string Status { get; set; }
                public string SnatEntryName { get; set; }
                public string SourceVSwitchId { get; set; }
                public string SourceCIDR { get; set; }
                public string SnatEntryId { get; set; }
                public string SnatTableId { get; set; }
                public string SnatIp { get; set; }
            }
        };

    }

}
