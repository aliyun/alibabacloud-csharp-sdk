// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListResourcesResponse : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=true)]
        public int? PageNumber { get; set; }

        [NameInMap("Resources")]
        [Validation(Required=true)]
        public ListResourcesResponseResources Resources { get; set; }
        public class ListResourcesResponseResources : TeaModel {
            [NameInMap("Resource")]
            [Validation(Required=true)]
            public List<ListResourcesResponseResourcesResource> Resource { get; set; }
            public class ListResourcesResponseResourcesResource : TeaModel {
                public string ResourceGroupId { get; set; }
                public string ResourceId { get; set; }
                public string Service { get; set; }
                public string ResourceType { get; set; }
                public string RegionId { get; set; }
                public string CreateDate { get; set; }
            }
        };

    }

}
