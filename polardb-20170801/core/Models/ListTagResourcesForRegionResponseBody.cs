// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ListTagResourcesForRegionResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TagResources")]
        [Validation(Required=false)]
        public ListTagResourcesForRegionResponseBodyTagResources TagResources { get; set; }
        public class ListTagResourcesForRegionResponseBodyTagResources : TeaModel {
            [NameInMap("TagResource")]
            [Validation(Required=false)]
            public List<ListTagResourcesForRegionResponseBodyTagResourcesTagResource> TagResource { get; set; }
            public class ListTagResourcesForRegionResponseBodyTagResourcesTagResource : TeaModel {
                public string ResourceId { get; set; }
                public string ResourceType { get; set; }
                public string TagKey { get; set; }
                public string TagValue { get; set; }
            }
        };

    }

}
