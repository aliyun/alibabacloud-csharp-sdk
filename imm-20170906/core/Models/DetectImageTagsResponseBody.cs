// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20170906.Models
{
    public class DetectImageTagsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ImageUri")]
        [Validation(Required=false)]
        public string ImageUri { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<DetectImageTagsResponseBodyTags> Tags { get; set; }
        public class DetectImageTagsResponseBodyTags : TeaModel {
            [NameInMap("ParentTagEnName")]
            [Validation(Required=false)]
            public string ParentTagEnName { get; set; }

            [NameInMap("TagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }

            [NameInMap("TagConfidence")]
            [Validation(Required=false)]
            public float? TagConfidence { get; set; }

            [NameInMap("TagEnName")]
            [Validation(Required=false)]
            public string TagEnName { get; set; }

            [NameInMap("TagLevel")]
            [Validation(Required=false)]
            public int? TagLevel { get; set; }

            [NameInMap("ParentTagName")]
            [Validation(Required=false)]
            public string ParentTagName { get; set; }

        }

    }

}
