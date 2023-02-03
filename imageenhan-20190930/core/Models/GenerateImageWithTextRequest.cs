// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class GenerateImageWithTextRequest : TeaModel {
        [NameInMap("Number")]
        [Validation(Required=false)]
        public int? Number { get; set; }

        [NameInMap("Resolution")]
        [Validation(Required=false)]
        public string Resolution { get; set; }

        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

    }

}
