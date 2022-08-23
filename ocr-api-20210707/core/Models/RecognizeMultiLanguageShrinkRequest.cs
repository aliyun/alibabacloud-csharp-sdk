// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr_api20210707.Models
{
    public class RecognizeMultiLanguageShrinkRequest : TeaModel {
        [NameInMap("Languages")]
        [Validation(Required=false)]
        public string LanguagesShrink { get; set; }

        [NameInMap("NeedRotate")]
        [Validation(Required=false)]
        public bool? NeedRotate { get; set; }

        [NameInMap("NeedSortPage")]
        [Validation(Required=false)]
        public bool? NeedSortPage { get; set; }

        [NameInMap("OutputCharInfo")]
        [Validation(Required=false)]
        public bool? OutputCharInfo { get; set; }

        [NameInMap("OutputTable")]
        [Validation(Required=false)]
        public bool? OutputTable { get; set; }

        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public Stream Body { get; set; }

    }

}
