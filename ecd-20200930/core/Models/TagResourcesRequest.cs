// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class TagResourcesRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=true)]
        public string RegionId { get; set; }

        [NameInMap("ResourceType")]
        [Validation(Required=true)]
        public string ResourceType { get; set; }

        [NameInMap("ResourceId")]
        [Validation(Required=true)]
        public List<string> ResourceId { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=true)]
        public List<TagResourcesRequestTag> Tag { get; set; }
        public class TagResourcesRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
