// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr_api20210707.Models
{
    public class RecognizeRussianRequest : TeaModel {
        [NameInMap("NeedRotate")]
        [Validation(Required=false)]
        public bool? NeedRotate { get; set; }

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
