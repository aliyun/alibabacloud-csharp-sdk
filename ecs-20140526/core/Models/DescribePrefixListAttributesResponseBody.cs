// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribePrefixListAttributesResponseBody : TeaModel {
        [NameInMap("AddressFamily")]
        [Validation(Required=false)]
        public string AddressFamily { get; set; }

        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Entries")]
        [Validation(Required=false)]
        public DescribePrefixListAttributesResponseBodyEntries Entries { get; set; }
        public class DescribePrefixListAttributesResponseBodyEntries : TeaModel {
            [NameInMap("Entry")]
            [Validation(Required=false)]
            public List<DescribePrefixListAttributesResponseBodyEntriesEntry> Entry { get; set; }
            public class DescribePrefixListAttributesResponseBodyEntriesEntry : TeaModel {
                [NameInMap("Cidr")]
                [Validation(Required=false)]
                public string Cidr { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

            }

        }

        [NameInMap("MaxEntries")]
        [Validation(Required=false)]
        public int? MaxEntries { get; set; }

        [NameInMap("PrefixListId")]
        [Validation(Required=false)]
        public string PrefixListId { get; set; }

        [NameInMap("PrefixListName")]
        [Validation(Required=false)]
        public string PrefixListName { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
