// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ledgerdb20191122.Models
{
    public class DescribeLedgersResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("Ledgers")]
        [Validation(Required=false)]
        public List<DescribeLedgersResponseBodyLedgers> Ledgers { get; set; }
        public class DescribeLedgersResponseBodyLedgers : TeaModel {
            [NameInMap("StorageClass")]
            [Validation(Required=false)]
            public string StorageClass { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            [NameInMap("JournalCount")]
            [Validation(Required=false)]
            public long? JournalCount { get; set; }

            [NameInMap("LedgerDescription")]
            [Validation(Required=false)]
            public string LedgerDescription { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("LedgerType")]
            [Validation(Required=false)]
            public string LedgerType { get; set; }

            [NameInMap("LastTimeAnchor")]
            [Validation(Required=false)]
            public DescribeLedgersResponseBodyLedgersLastTimeAnchor LastTimeAnchor { get; set; }
            public class DescribeLedgersResponseBodyLedgersLastTimeAnchor : TeaModel {
                [NameInMap("JournalId")]
                [Validation(Required=false)]
                public string JournalId { get; set; }
                [NameInMap("LedgerVersion")]
                [Validation(Required=false)]
                public string LedgerVersion { get; set; }
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }
                [NameInMap("LedgerDigest")]
                [Validation(Required=false)]
                public string LedgerDigest { get; set; }
                [NameInMap("LedgerDigestType")]
                [Validation(Required=false)]
                public string LedgerDigestType { get; set; }
                [NameInMap("Proof")]
                [Validation(Required=false)]
                public string Proof { get; set; }
            };

            [NameInMap("LedgerId")]
            [Validation(Required=false)]
            public string LedgerId { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("MemberCount")]
            [Validation(Required=false)]
            public long? MemberCount { get; set; }

            [NameInMap("LedgerStatus")]
            [Validation(Required=false)]
            public string LedgerStatus { get; set; }

            [NameInMap("TimeAnchorCount")]
            [Validation(Required=false)]
            public long? TimeAnchorCount { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            [NameInMap("LedgerName")]
            [Validation(Required=false)]
            public string LedgerName { get; set; }

            [NameInMap("OwnerAliUid")]
            [Validation(Required=false)]
            public string OwnerAliUid { get; set; }

        }

    }

}
