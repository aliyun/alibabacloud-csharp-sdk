// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListPrefixListsResponseBody : TeaModel {
        /// <summary>
        /// The number of entries per page. Valid values: **1** to **100**. Default value: **20**.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results. Valid values:
        /// 
        /// *   If **NextToken** is empty, no next page exists.
        /// *   If a value is returned for **NextToken**, the value indicates the token that is used for the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The information about the prefix lists.
        /// </summary>
        [NameInMap("PrefixLists")]
        [Validation(Required=false)]
        public List<ListPrefixListsResponseBodyPrefixLists> PrefixLists { get; set; }
        public class ListPrefixListsResponseBodyPrefixLists : TeaModel {
            /// <summary>
            /// The CIDR block specified in the prefix list.
            /// </summary>
            [NameInMap("CidrBlocks")]
            [Validation(Required=false)]
            public List<string> CidrBlocks { get; set; }

            /// <summary>
            /// The time when the prefix list was created.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The IP version of the prefix list. Valid values:
            /// 
            /// *   **IPV4**
            /// *   **IPV6**
            /// </summary>
            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public string IpVersion { get; set; }

            /// <summary>
            /// The maximum number of CIDR blocks that you can specify in the prefix list.
            /// </summary>
            [NameInMap("MaxEntries")]
            [Validation(Required=false)]
            public int? MaxEntries { get; set; }

            /// <summary>
            /// The Alibaba Cloud account to which the prefix list belongs.
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// The description of the prefix list.
            /// </summary>
            [NameInMap("PrefixListDescription")]
            [Validation(Required=false)]
            public string PrefixListDescription { get; set; }

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
            /// The status of the prefix list. Valid values:
            /// 
            /// *   **Created**
            /// *   **Deleted**
            /// *   **Modifying**
            /// 
            /// >  This parameter is the same as the **Status** parameter.
            /// </summary>
            [NameInMap("PrefixListStatus")]
            [Validation(Required=false)]
            public string PrefixListStatus { get; set; }

            /// <summary>
            /// The region ID of the prefix list.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The ID of the resource group to which the prefix list belongs.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// Indicates whether the prefix list is shared. Valid values:
            /// 
            /// *   **Shared**: The prefix list is shared.
            /// *   If an empty value is returned, the prefix list is not shared.
            /// </summary>
            [NameInMap("ShareType")]
            [Validation(Required=false)]
            public string ShareType { get; set; }

            /// <summary>
            /// The status of the prefix list. Valid values:
            /// 
            /// *   **Created**
            /// *   **Deleted**
            /// *   **Modifying**
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The tags.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListPrefixListsResponseBodyPrefixListsTags> Tags { get; set; }
            public class ListPrefixListsResponseBodyPrefixListsTags : TeaModel {
                /// <summary>
                /// The tag key.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
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
