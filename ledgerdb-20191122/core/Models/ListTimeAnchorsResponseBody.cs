// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ledgerdb20191122.Models
{
    public class ListTimeAnchorsResponseBody : TeaModel {
        [NameInMap("TimeAnchors")]
        [Validation(Required=false)]
        public List<ListTimeAnchorsResponseBodyTimeAnchors> TimeAnchors { get; set; }
        public class ListTimeAnchorsResponseBodyTimeAnchors : TeaModel {
            [NameInMap("JournalId")]
            [Validation(Required=false)]
            public long? JournalId { get; set; }

            [NameInMap("LedgerVersion")]
            [Validation(Required=false)]
            public long? LedgerVersion { get; set; }

            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            public long? TimeStamp { get; set; }

            [NameInMap("LedgerDigest")]
            [Validation(Required=false)]
            public string LedgerDigest { get; set; }

            [NameInMap("LedgerDigestType")]
            [Validation(Required=false)]
            public string LedgerDigestType { get; set; }

            [NameInMap("Proof")]
            [Validation(Required=false)]
            public string Proof { get; set; }

        }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

    }

}
