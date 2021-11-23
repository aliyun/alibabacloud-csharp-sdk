// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizeQrCodeResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeQrCodeResponseBodyData Data { get; set; }
        public class RecognizeQrCodeResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<RecognizeQrCodeResponseBodyDataElements> Elements { get; set; }
            public class RecognizeQrCodeResponseBodyDataElements : TeaModel {
                public string ImageURL { get; set; }
                public List<RecognizeQrCodeResponseBodyDataElementsResults> Results { get; set; }
                public class RecognizeQrCodeResponseBodyDataElementsResults : TeaModel {
                    public string Label { get; set; }
                    public List<string> QrCodesData { get; set; }
                    public float? Rate { get; set; }
                    public string Suggestion { get; set; }
                }
                public string TaskId { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
