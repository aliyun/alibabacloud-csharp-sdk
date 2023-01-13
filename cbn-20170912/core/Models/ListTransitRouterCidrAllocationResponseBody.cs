// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterCidrAllocationResponseBody : TeaModel {
        /// <summary>
        /// The number of entries returned on each page.
        /// 
        /// *   If no value is specified for **MaxResults**, query results are returned in one batch. The value of **MaxResults** indicates the total number of entries.
        /// *   If a value is specified for **MaxResults**, query results are returned in batches. The value of **MaxResults** in the response indicates the number of entries in the current batch.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that determines the start point of the query. Valid values:
        /// 
        /// *   If **NextToken** was not returned, it indicates that no additional results exist.
        /// *   If **NextToken** was returned in the previous query, specify the value to obtain the next set of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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

        /// <summary>
        /// The information about the allocated CIDR blocks.
        /// </summary>
        [NameInMap("TransitRouterCidrAllocations")]
        [Validation(Required=false)]
        public List<ListTransitRouterCidrAllocationResponseBodyTransitRouterCidrAllocations> TransitRouterCidrAllocations { get; set; }
        public class ListTransitRouterCidrAllocationResponseBodyTransitRouterCidrAllocations : TeaModel {
            /// <summary>
            /// The CIDR blocks that have been allocated to network instances.
            /// </summary>
            [NameInMap("AllocatedCidrBlock")]
            [Validation(Required=false)]
            public string AllocatedCidrBlock { get; set; }

            /// <summary>
            /// The ID of the network instance connection.
            /// </summary>
            [NameInMap("AttachmentId")]
            [Validation(Required=false)]
            public string AttachmentId { get; set; }

            /// <summary>
            /// The name of the network instance connection.
            /// </summary>
            [NameInMap("AttachmentName")]
            [Validation(Required=false)]
            public string AttachmentName { get; set; }

            /// <summary>
            /// The ID of the transit router CIDR block.
            /// </summary>
            [NameInMap("Cidr")]
            [Validation(Required=false)]
            public string Cidr { get; set; }

            /// <summary>
            /// The ID of the transit router CIDR block.
            /// </summary>
            [NameInMap("TransitRouterCidrId")]
            [Validation(Required=false)]
            public string TransitRouterCidrId { get; set; }

        }

    }

}
