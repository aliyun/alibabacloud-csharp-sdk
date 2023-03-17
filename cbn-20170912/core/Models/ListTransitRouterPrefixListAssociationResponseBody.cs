// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterPrefixListAssociationResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// A list of prefix lists.
        /// </summary>
        [NameInMap("PrefixLists")]
        [Validation(Required=false)]
        public List<ListTransitRouterPrefixListAssociationResponseBodyPrefixLists> PrefixLists { get; set; }
        public class ListTransitRouterPrefixListAssociationResponseBodyPrefixLists : TeaModel {
            /// <summary>
            /// The ID of the next hop.
            /// 
            /// > A value of **BlackHole** indicates that all the CIDR blocks in the prefix list are blackhole routes. Packets destined for the CIDR blocks are dropped.
            /// </summary>
            [NameInMap("NextHop")]
            [Validation(Required=false)]
            public string NextHop { get; set; }

            /// <summary>
            /// The ID of the network instance associated with the next hop connection.
            /// </summary>
            [NameInMap("NextHopInstanceId")]
            [Validation(Required=false)]
            public string NextHopInstanceId { get; set; }

            /// <summary>
            /// The type of the next hop. Valid values:
            /// 
            /// *   **BlackHole**: All the CIDR blocks in the prefix list are blackhole routes. Packets destined for the CIDR blocks are dropped.
            /// *   **VPC**: The next hop of the CIDR blocks in the prefix list is a VPC connection.
            /// *   **VBR**: The next hop of the CIDR blocks in the prefix list is a VBR connection.
            /// *   **TR**: The next hop of the CIDR blocks in the prefix list is an inter-region connection.
            /// </summary>
            [NameInMap("NextHopType")]
            [Validation(Required=false)]
            public string NextHopType { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account to which the prefix list belongs.
            /// </summary>
            [NameInMap("OwnerUid")]
            [Validation(Required=false)]
            public long? OwnerUid { get; set; }

            /// <summary>
            /// The ID of the prefix list.
            /// </summary>
            [NameInMap("PrefixListId")]
            [Validation(Required=false)]
            public string PrefixListId { get; set; }

            /// <summary>
            /// The status of the prefix list. Valid values:
            /// 
            /// *   **Active**: The prefix list is effective.
            /// *   **Updating**: The prefix list is being updated.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The ID of the transit router.
            /// </summary>
            [NameInMap("TransitRouterId")]
            [Validation(Required=false)]
            public string TransitRouterId { get; set; }

            /// <summary>
            /// The ID of the route table of the transit router.
            /// </summary>
            [NameInMap("TransitRouterTableId")]
            [Validation(Required=false)]
            public string TransitRouterTableId { get; set; }

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
        public int? TotalCount { get; set; }

    }

}
