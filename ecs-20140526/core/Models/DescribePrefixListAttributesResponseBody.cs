// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribePrefixListAttributesResponseBody : TeaModel {
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
        /// Details about the entries in the prefix list.
        /// </summary>
        [NameInMap("Entries")]
        [Validation(Required=false)]
        public DescribePrefixListAttributesResponseBodyEntries Entries { get; set; }
        public class DescribePrefixListAttributesResponseBodyEntries : TeaModel {
            [NameInMap("Entry")]
            [Validation(Required=false)]
            public List<DescribePrefixListAttributesResponseBodyEntriesEntry> Entry { get; set; }
            public class DescribePrefixListAttributesResponseBodyEntriesEntry : TeaModel {
                /// <summary>
                /// The CIDR block in the entry in the prefix list.
                /// </summary>
                [NameInMap("Cidr")]
                [Validation(Required=false)]
                public string Cidr { get; set; }

                /// <summary>
                /// The description of the entry in the prefix list.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

            }

        }

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

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
