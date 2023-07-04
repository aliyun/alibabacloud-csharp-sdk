// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class GetVpcPrefixListEntriesResponseBody : TeaModel {
        /// <summary>
        /// The number of entries.
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        /// <summary>
        /// The token that is used for the next query. Valid values:
        /// 
        /// *   If no value is returned for **NextToken**, no next queries are sent.
        /// *   If **NextToken** is not empty, the value indicates the token that is used for the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The information about the prefix list.
        /// </summary>
        [NameInMap("PrefixListEntry")]
        [Validation(Required=false)]
        public List<GetVpcPrefixListEntriesResponseBodyPrefixListEntry> PrefixListEntry { get; set; }
        public class GetVpcPrefixListEntriesResponseBodyPrefixListEntry : TeaModel {
            /// <summary>
            /// The CIDR blocks specified in the prefix list.
            /// </summary>
            [NameInMap("Cidr")]
            [Validation(Required=false)]
            public string Cidr { get; set; }

            /// <summary>
            /// The description of the prefix list.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The ID of the prefix list.
            /// </summary>
            [NameInMap("PrefixListId")]
            [Validation(Required=false)]
            public string PrefixListId { get; set; }

            /// <summary>
            /// The region ID of the prefix list.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
