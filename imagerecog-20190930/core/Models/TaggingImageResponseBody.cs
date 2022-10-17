// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imagerecog20190930.Models
{
    public class TaggingImageResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public TaggingImageResponseBodyData Data { get; set; }
        public class TaggingImageResponseBodyData : TeaModel {
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<TaggingImageResponseBodyDataTags> Tags { get; set; }
            public class TaggingImageResponseBodyDataTags : TeaModel {
                [NameInMap("Confidence")]
                [Validation(Required=false)]
                public float? Confidence { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
