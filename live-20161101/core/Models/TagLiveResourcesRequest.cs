// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class TagLiveResourcesRequest : TeaModel {
        [NameInMap("ResourceId")]
        [Validation(Required=true)]
        public List<string> ResourceId { get; set; }

        [NameInMap("ResourceType")]
        [Validation(Required=true)]
        public string ResourceType { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=true)]
        public List<TagLiveResourcesRequestTag> Tag { get; set; }
        public class TagLiveResourcesRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=true)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
