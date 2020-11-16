// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveTagResourcesResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TagResources")]
        [Validation(Required=true)]
        public List<DescribeLiveTagResourcesResponseTagResources> TagResources { get; set; }
        public class DescribeLiveTagResourcesResponseTagResources : TeaModel {
            [NameInMap("ResourceId")]
            [Validation(Required=true)]
            public string ResourceId { get; set; }

            [NameInMap("Tag")]
            [Validation(Required=true)]
            public List<DescribeLiveTagResourcesResponseTagResourcesTag> Tag { get; set; }
            public class DescribeLiveTagResourcesResponseTagResourcesTag : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=true)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=true)]
                public string Value { get; set; }

            }

        }

    }

}
