// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class GetVpcPrefixListAssociationsResponseBody : TeaModel {
        /// <summary>
        /// The number of entries.
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results. Valid values:
        /// 
        /// *   If **NextToken** is empty, no next page exists.
        /// *   If a value is returned for **NextToken**, the value is used to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The information about the network instances that are associated with the prefix list.
        /// </summary>
        [NameInMap("PrefixListAssociation")]
        [Validation(Required=false)]
        public List<GetVpcPrefixListAssociationsResponseBodyPrefixListAssociation> PrefixListAssociation { get; set; }
        public class GetVpcPrefixListAssociationsResponseBodyPrefixListAssociation : TeaModel {
            /// <summary>
            /// The ID of the Alibaba Cloud account to which the prefix list belongs.
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// The prefix list ID.
            /// </summary>
            [NameInMap("PrefixListId")]
            [Validation(Required=false)]
            public string PrefixListId { get; set; }

            /// <summary>
            /// The reason why the association failed.
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// The region ID of the prefix list.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The ID of the associated resource.
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// The type of the associated resource. Valid values:
            /// 
            /// *   **vpcRouteTable**: virtual private cloud (VPC) route table.
            /// *   **trRouteTable**: route table of a transit router.
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account to which the resource associated with the prefix list belongs.
            /// </summary>
            [NameInMap("ResourceUid")]
            [Validation(Required=false)]
            public string ResourceUid { get; set; }

            /// <summary>
            /// The status of the prefix list. Valid values:
            /// 
            /// *   **Created**
            /// *   **ModifyFailed**
            /// *   **Creating**
            /// *   **Modifying**
            /// *   **Deleting**
            /// *   **Deleted**
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
