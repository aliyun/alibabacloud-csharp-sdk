// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class MoveResourcesRequest : TeaModel {
        /// <summary>
        /// The ID of the resource group to which you want to move the resources.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The resources that you want to move.
        /// 
        /// >  You can move a maximum of 10 resources at a time. If you want to move more than 10 resources, move them in batches.
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<MoveResourcesRequestResources> Resources { get; set; }
        public class MoveResourcesRequestResources : TeaModel {
            /// <summary>
            /// The region ID of the resource.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The ID of the resource.
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// The type of the resource.
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud service to which the resource belongs.
            /// </summary>
            [NameInMap("Service")]
            [Validation(Required=false)]
            public string Service { get; set; }

        }

    }

}
