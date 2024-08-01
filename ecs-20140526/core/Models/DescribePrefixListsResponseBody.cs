// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribePrefixListsResponseBody : TeaModel {
        /// <summary>
        /// The query token returned in this call. If the return value is empty, no more data is returned.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// Details about the prefix lists.
        /// </summary>
        [NameInMap("PrefixLists")]
        [Validation(Required=false)]
        public DescribePrefixListsResponseBodyPrefixLists PrefixLists { get; set; }
        public class DescribePrefixListsResponseBodyPrefixLists : TeaModel {
            [NameInMap("PrefixList")]
            [Validation(Required=false)]
            public List<DescribePrefixListsResponseBodyPrefixListsPrefixList> PrefixList { get; set; }
            public class DescribePrefixListsResponseBodyPrefixListsPrefixList : TeaModel {
                /// <summary>
                /// The IP address family of the prefix list. Valid values:
                /// 
                /// *   IPv4
                /// *   IPv6
                /// </summary>
                [NameInMap("AddressFamily")]
                [Validation(Required=false)]
                public string AddressFamily { get; set; }

                /// <summary>
                /// The number of associated resources.
                /// </summary>
                [NameInMap("AssociationCount")]
                [Validation(Required=false)]
                public int? AssociationCount { get; set; }

                /// <summary>
                /// The time when the prefix list was created.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The description of the prefix list.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The maximum number of entries that the prefix list can contain.
                /// </summary>
                [NameInMap("MaxEntries")]
                [Validation(Required=false)]
                public int? MaxEntries { get; set; }

                /// <summary>
                /// The ID of the prefix list.
                /// </summary>
                [NameInMap("PrefixListId")]
                [Validation(Required=false)]
                public string PrefixListId { get; set; }

                /// <summary>
                /// The name of the prefix list.
                /// </summary>
                [NameInMap("PrefixListName")]
                [Validation(Required=false)]
                public string PrefixListName { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
