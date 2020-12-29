// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class ListTagResourcesResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TagResources")]
        [Validation(Required=false)]
        public List<ListTagResourcesResponseBodyTagResources> TagResources { get; set; }
        public class ListTagResourcesResponseBodyTagResources : TeaModel {
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

        }

    }

}
