// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ledgerdb20191122.Models
{
    public class ListJournalsResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("Journals")]
        [Validation(Required=false)]
        public List<ListJournalsResponseBodyJournals> Journals { get; set; }
        public class ListJournalsResponseBodyJournals : TeaModel {
            [NameInMap("JournalId")]
            [Validation(Required=false)]
            public string JournalId { get; set; }

            [NameInMap("Clues")]
            [Validation(Required=false)]
            public List<string> Clues { get; set; }

            [NameInMap("PayloadJsonString")]
            [Validation(Required=false)]
            public string PayloadJsonString { get; set; }

            [NameInMap("JournalHash")]
            [Validation(Required=false)]
            public string JournalHash { get; set; }

            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

            [NameInMap("LedgerId")]
            [Validation(Required=false)]
            public string LedgerId { get; set; }

            [NameInMap("MemberId")]
            [Validation(Required=false)]
            public string MemberId { get; set; }

            [NameInMap("PayloadType")]
            [Validation(Required=false)]
            public string PayloadType { get; set; }

            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

        }

    }

}
