// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class ListSharedResourcesResponseBody : TeaModel {
        /// <summary>
        /// The token that is used to initiate the next request. If the response of the current request is truncated, you can use the token to initiate another request and obtain the remaining records.
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
        /// The information of the shared resources.
        /// </summary>
        [NameInMap("SharedResources")]
        [Validation(Required=false)]
        public List<ListSharedResourcesResponseBodySharedResources> SharedResources { get; set; }
        public class ListSharedResourcesResponseBodySharedResources : TeaModel {
            /// <summary>
            /// The time when the shared resource was associated with the resource share.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The ID of the shared resource.
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// The ID of the resource share.
            /// </summary>
            [NameInMap("ResourceShareId")]
            [Validation(Required=false)]
            public string ResourceShareId { get; set; }

            /// <summary>
            /// The status of the shared resource. This parameter is returned only when you query the resources that other accounts share with you.
            /// 
            /// Valid values:
            /// 
            /// *   Available: The resource is available.
            /// *   ZonalResourceInaccessible: The resource is unavailable in the current zone.
            /// *   LimitExceeded: The resource is unavailable because the maximum number of resources that other accounts can share with you exceeds the upper limit.
            /// *   Unavailable: The resource is unavailable.
            /// </summary>
            [NameInMap("ResourceStatus")]
            [Validation(Required=false)]
            public string ResourceStatus { get; set; }

            /// <summary>
            /// The cause of the association failure.
            /// </summary>
            [NameInMap("ResourceStatusMessage")]
            [Validation(Required=false)]
            public string ResourceStatusMessage { get; set; }

            /// <summary>
            /// The type of the shared resource.
            /// 
            /// For more information about the types of resources that can be shared, see [Services that work with Resource Sharing](~~450526~~).
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// The time when the association of the shared resource was updated.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

    }

}
