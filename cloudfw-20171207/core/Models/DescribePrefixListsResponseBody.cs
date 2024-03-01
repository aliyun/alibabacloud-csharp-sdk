// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribePrefixListsResponseBody : TeaModel {
        [NameInMap("PrefixList")]
        [Validation(Required=false)]
        public List<DescribePrefixListsResponseBodyPrefixList> PrefixList { get; set; }
        public class DescribePrefixListsResponseBodyPrefixList : TeaModel {
            [NameInMap("AddressFamily")]
            [Validation(Required=false)]
            public string AddressFamily { get; set; }

            [NameInMap("AssociationCount")]
            [Validation(Required=false)]
            public int? AssociationCount { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("MaxEntries")]
            [Validation(Required=false)]
            public int? MaxEntries { get; set; }

            [NameInMap("PrefixListId")]
            [Validation(Required=false)]
            public string PrefixListId { get; set; }

            [NameInMap("PrefixListName")]
            [Validation(Required=false)]
            public string PrefixListName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
