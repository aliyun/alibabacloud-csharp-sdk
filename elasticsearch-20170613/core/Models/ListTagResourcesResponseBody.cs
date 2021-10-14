// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListTagResourcesResponseBody : TeaModel {
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public ListTagResourcesResponseBodyHeaders Headers { get; set; }
        public class ListTagResourcesResponseBodyHeaders : TeaModel {
            [NameInMap("X-Total-Count")]
            [Validation(Required=false)]
            public int? XTotalCount { get; set; }
        };

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TagResources")]
        [Validation(Required=false)]
        public ListTagResourcesResponseBodyTagResources TagResources { get; set; }
        public class ListTagResourcesResponseBodyTagResources : TeaModel {
            [NameInMap("TagResource")]
            [Validation(Required=false)]
            public List<ListTagResourcesResponseBodyTagResourcesTagResource> TagResource { get; set; }
            public class ListTagResourcesResponseBodyTagResourcesTagResource : TeaModel {
                public string TagValue { get; set; }
                public string ResourceType { get; set; }
                public string ResourceId { get; set; }
                public string TagKey { get; set; }
            }
        };

    }

}
