// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizeCharacterRequest : TeaModel {
        [NameInMap("ImageType")]
        [Validation(Required=false)]
        public int? ImageType { get; set; }

        [NameInMap("ImageURL")]
        [Validation(Required=false)]
        public string ImageURL { get; set; }

        [NameInMap("MinHeight")]
        [Validation(Required=false)]
        public int? MinHeight { get; set; }

        [NameInMap("OutputProbability")]
        [Validation(Required=false)]
        public bool? OutputProbability { get; set; }

    }

}
