// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListAggregateDiscoveredResourcesRequest : TeaModel {
        /// <summary>
        /// The ID of the account group.
        /// 
        /// For more information about how to obtain the ID of the account group, see [ListAggregators](https://help.aliyun.com/document_detail/255797.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AggregatorId")]
        [Validation(Required=false)]
        public string AggregatorId { get; set; }

        [NameInMap("EndUpdateTimestamp")]
        [Validation(Required=false)]
        public long? EndUpdateTimestamp { get; set; }

        [NameInMap("ExcludeResourceTypes")]
        [Validation(Required=false)]
        public string ExcludeResourceTypes { get; set; }

        /// <summary>
        /// The maximum number of entries to return for a single request. Valid values: 1 to 100.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The `token` that you want to use to initiate the current request. If the response of the previous request is truncated, you can use this token to initiate another request and obtain the remaining entries.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the region in which the resource resides. Separate multiple region IDs with commas (,).
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public string Regions { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud account to which the specified resource belongs in the account group.
        /// </summary>
        [NameInMap("ResourceAccountId")]
        [Validation(Required=false)]
        public long? ResourceAccountId { get; set; }

        /// <summary>
        /// The status of the resource. Valid values:
        /// 
        /// *   0: The resource is deleted. If a resource is deleted from the desired cloud service, **Deleted** is displayed in the resource list in the Cloud Config console.
        /// *   1 (default): The resource is retained. If a resource is managed as expected, **Active** is displayed in the resource list in the Cloud Config console.
        /// </summary>
        [NameInMap("ResourceDeleted")]
        [Validation(Required=false)]
        public int? ResourceDeleted { get; set; }

        /// <summary>
        /// The resource ID.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        [Obsolete]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The type of the resource. Separate multiple resource types with commas (,).
        /// </summary>
        [NameInMap("ResourceTypes")]
        [Validation(Required=false)]
        public string ResourceTypes { get; set; }

        [NameInMap("StartUpdateTimestamp")]
        [Validation(Required=false)]
        public long? StartUpdateTimestamp { get; set; }

    }

}
