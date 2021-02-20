// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListResourcesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Resources")]
        [Validation(Required=false)]
        public ListResourcesResponseBodyResources Resources { get; set; }
        public class ListResourcesResponseBodyResources : TeaModel {
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public List<ListResourcesResponseBodyResourcesResource> Resource { get; set; }
            public class ListResourcesResponseBodyResourcesResource : TeaModel {
                public string Service { get; set; }
                public string ResourceType { get; set; }
                public string ResourceGroupId { get; set; }
                public string ResourceId { get; set; }
                public string CreateDate { get; set; }
                public string RegionId { get; set; }
            }
        };

    }

}
