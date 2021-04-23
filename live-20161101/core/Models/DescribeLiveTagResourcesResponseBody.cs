// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveTagResourcesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TagResources")]
        [Validation(Required=false)]
        public List<DescribeLiveTagResourcesResponseBodyTagResources> TagResources { get; set; }
        public class DescribeLiveTagResourcesResponseBodyTagResources : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<DescribeLiveTagResourcesResponseBodyTagResourcesTag> Tag { get; set; }
            public class DescribeLiveTagResourcesResponseBodyTagResourcesTag : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

        }

    }

}
