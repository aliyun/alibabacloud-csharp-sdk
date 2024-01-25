// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tablestore20201209.Models
{
    public class TagResourcesRequest : TeaModel {
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public List<string> ResourceIds { get; set; }

        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<TagResourcesRequestTags> Tags { get; set; }
        public class TagResourcesRequestTags : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
