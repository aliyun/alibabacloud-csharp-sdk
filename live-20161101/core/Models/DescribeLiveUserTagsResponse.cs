// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveUserTagsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=true)]
        public List<DescribeLiveUserTagsResponseTags> Tags { get; set; }
        public class DescribeLiveUserTagsResponseTags : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=true)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=true)]
            public List<string> Value { get; set; }

        }

    }

}
