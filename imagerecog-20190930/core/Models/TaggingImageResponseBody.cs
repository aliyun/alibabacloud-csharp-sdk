// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imagerecog20190930.Models
{
    public class TaggingImageResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public TaggingImageResponseBodyData Data { get; set; }
        public class TaggingImageResponseBodyData : TeaModel {
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<TaggingImageResponseBodyDataTags> Tags { get; set; }
            public class TaggingImageResponseBodyDataTags : TeaModel {
                public string Value { get; set; }
                public float? Confidence { get; set; }
            }
        };

    }

}
