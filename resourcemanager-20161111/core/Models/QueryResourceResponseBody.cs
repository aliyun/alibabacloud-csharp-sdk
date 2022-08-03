// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20161111.Models
{
    public class QueryResourceResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Resources")]
        [Validation(Required=false)]
        public QueryResourceResponseBodyResources Resources { get; set; }
        public class QueryResourceResponseBodyResources : TeaModel {
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public List<QueryResourceResponseBodyResourcesResource> Resource { get; set; }
            public class QueryResourceResponseBodyResourcesResource : TeaModel {
                public string CreateDate { get; set; }
                public string RegionId { get; set; }
                public string ResourceGroupId { get; set; }
                public string ResourceId { get; set; }
                public string ResourceType { get; set; }
                public string Service { get; set; }
            }
        };

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
