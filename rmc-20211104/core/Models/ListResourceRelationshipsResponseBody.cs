// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RMC20211104.Models
{
    public class ListResourceRelationshipsResponseBody : TeaModel {
        /// <summary>
        /// The maximum number of entries returned per page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that is used to initiate the next request.
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
        /// The information of the associated resources.
        /// </summary>
        [NameInMap("ResourceRelationships")]
        [Validation(Required=false)]
        public List<ListResourceRelationshipsResponseBodyResourceRelationships> ResourceRelationships { get; set; }
        public class ListResourceRelationshipsResponseBodyResourceRelationships : TeaModel {
            /// <summary>
            /// The ID of the Alibaba Cloud account.
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// The region ID of the specified resource.
            /// </summary>
            [NameInMap("SourceRegionId")]
            [Validation(Required=false)]
            public string SourceRegionId { get; set; }

            /// <summary>
            /// The ID of the specified resource.
            /// </summary>
            [NameInMap("SourceResourceId")]
            [Validation(Required=false)]
            public string SourceResourceId { get; set; }

            /// <summary>
            /// The type of the specified resource.
            /// </summary>
            [NameInMap("SourceResourceType")]
            [Validation(Required=false)]
            public string SourceResourceType { get; set; }

            /// <summary>
            /// The region ID of the associated resource.
            /// </summary>
            [NameInMap("TargetRegionId")]
            [Validation(Required=false)]
            public string TargetRegionId { get; set; }

            /// <summary>
            /// The ID of the associated resource.
            /// </summary>
            [NameInMap("TargetResourceId")]
            [Validation(Required=false)]
            public string TargetResourceId { get; set; }

            /// <summary>
            /// The type of the associated resource.
            /// </summary>
            [NameInMap("TargetResourceType")]
            [Validation(Required=false)]
            public string TargetResourceType { get; set; }

        }

    }

}
