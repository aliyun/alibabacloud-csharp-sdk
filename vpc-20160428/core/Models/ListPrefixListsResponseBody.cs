// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListPrefixListsResponseBody : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("PrefixLists")]
        [Validation(Required=false)]
        public List<ListPrefixListsResponseBodyPrefixLists> PrefixLists { get; set; }
        public class ListPrefixListsResponseBodyPrefixLists : TeaModel {
            [NameInMap("CidrBlocks")]
            [Validation(Required=false)]
            public List<string> CidrBlocks { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public string IpVersion { get; set; }

            [NameInMap("MaxEntries")]
            [Validation(Required=false)]
            public int? MaxEntries { get; set; }

            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            [NameInMap("PrefixListDescription")]
            [Validation(Required=false)]
            public string PrefixListDescription { get; set; }

            [NameInMap("PrefixListId")]
            [Validation(Required=false)]
            public string PrefixListId { get; set; }

            [NameInMap("PrefixListName")]
            [Validation(Required=false)]
            public string PrefixListName { get; set; }

            [NameInMap("PrefixListStatus")]
            [Validation(Required=false)]
            public string PrefixListStatus { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("ShareType")]
            [Validation(Required=false)]
            public string ShareType { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListPrefixListsResponseBodyPrefixListsTags> Tags { get; set; }
            public class ListPrefixListsResponseBodyPrefixListsTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
