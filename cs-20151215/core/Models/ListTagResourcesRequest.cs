// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ListTagResourcesRequest : TeaModel {
        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("next_token")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("region_id")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The list of cluster IDs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("resource_ids")]
        [Validation(Required=false)]
        public List<string> ResourceIds { get; set; }

        /// <summary>
        /// The resource type. Set the value to `CLUSTER`.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("resource_type")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The list of labels that you want to query. You can specify at most 20 labels.
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

    }

}
