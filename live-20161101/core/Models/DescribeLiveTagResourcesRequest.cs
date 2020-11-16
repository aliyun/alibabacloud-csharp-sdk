// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveTagResourcesRequest : TeaModel {
        [NameInMap("ResourceId")]
        [Validation(Required=true)]
        public List<string> ResourceId { get; set; }

        [NameInMap("ResourceType")]
        [Validation(Required=true)]
        public string ResourceType { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeLiveTagResourcesRequestTag> Tag { get; set; }
        public class DescribeLiveTagResourcesRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
