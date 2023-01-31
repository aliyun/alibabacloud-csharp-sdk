// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class GetVpcPrefixListEntriesResponseBody : TeaModel {
        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("PrefixListEntry")]
        [Validation(Required=false)]
        public List<GetVpcPrefixListEntriesResponseBodyPrefixListEntry> PrefixListEntry { get; set; }
        public class GetVpcPrefixListEntriesResponseBodyPrefixListEntry : TeaModel {
            [NameInMap("Cidr")]
            [Validation(Required=false)]
            public string Cidr { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("PrefixListId")]
            [Validation(Required=false)]
            public string PrefixListId { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
