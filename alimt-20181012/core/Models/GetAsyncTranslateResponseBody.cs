// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alimt20181012.Models
{
    public class GetAsyncTranslateResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAsyncTranslateResponseBodyData Data { get; set; }
        public class GetAsyncTranslateResponseBodyData : TeaModel {
            [NameInMap("DetectedLanguage")]
            [Validation(Required=false)]
            public string DetectedLanguage { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TranslatedText")]
            [Validation(Required=false)]
            public string TranslatedText { get; set; }

            [NameInMap("WordCount")]
            [Validation(Required=false)]
            public string WordCount { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
