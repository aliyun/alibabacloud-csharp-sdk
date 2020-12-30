// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ledgerdb20191122.Models
{
    public class ListJournalsRequest : TeaModel {
        [NameInMap("LedgerId")]
        [Validation(Required=false)]
        public string LedgerId { get; set; }

        [NameInMap("Clue")]
        [Validation(Required=false)]
        public string Clue { get; set; }

        [NameInMap("MemberId")]
        [Validation(Required=false)]
        public string MemberId { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("Reverse")]
        [Validation(Required=false)]
        public bool? Reverse { get; set; }

    }

}
