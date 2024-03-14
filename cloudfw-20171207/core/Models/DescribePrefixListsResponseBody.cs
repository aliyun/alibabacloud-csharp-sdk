// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribePrefixListsResponseBody : TeaModel {
        /// <summary>
        /// Details about the prefix lists.
        /// </summary>
        [NameInMap("PrefixList")]
        [Validation(Required=false)]
        public List<DescribePrefixListsResponseBodyPrefixList> PrefixList { get; set; }
        public class DescribePrefixListsResponseBodyPrefixList : TeaModel {
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
            /// The creation time.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The description.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The maximum number of entries in the prefix list.
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

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
