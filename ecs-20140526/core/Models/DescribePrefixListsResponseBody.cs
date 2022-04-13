// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribePrefixListsResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("PrefixLists")]
        [Validation(Required=false)]
        public DescribePrefixListsResponseBodyPrefixLists PrefixLists { get; set; }
        public class DescribePrefixListsResponseBodyPrefixLists : TeaModel {
            [NameInMap("PrefixList")]
            [Validation(Required=false)]
            public List<DescribePrefixListsResponseBodyPrefixListsPrefixList> PrefixList { get; set; }
            public class DescribePrefixListsResponseBodyPrefixListsPrefixList : TeaModel {
                public string AddressFamily { get; set; }
                public int? AssociationCount { get; set; }
                public string CreationTime { get; set; }
                public string Description { get; set; }
                public int? MaxEntries { get; set; }
                public string PrefixListId { get; set; }
                public string PrefixListName { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
