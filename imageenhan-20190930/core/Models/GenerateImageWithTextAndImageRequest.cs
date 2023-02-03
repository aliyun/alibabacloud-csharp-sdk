// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class GenerateImageWithTextAndImageRequest : TeaModel {
        [NameInMap("AspectRatioMode")]
        [Validation(Required=false)]
        public string AspectRatioMode { get; set; }

        [NameInMap("Number")]
        [Validation(Required=false)]
        public int? Number { get; set; }

        [NameInMap("RefImageUrl")]
        [Validation(Required=false)]
        public string RefImageUrl { get; set; }

        [NameInMap("Resolution")]
        [Validation(Required=false)]
        public string Resolution { get; set; }

        [NameInMap("Similarity")]
        [Validation(Required=false)]
        public float? Similarity { get; set; }

        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

    }

}
