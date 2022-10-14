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
                [NameInMap("ImageURL")]
                [Validation(Required=false)]
                public string ImageURL { get; set; }

                [NameInMap("Results")]
                [Validation(Required=false)]
                public List<RecognizeQrCodeResponseBodyDataElementsResults> Results { get; set; }
                public class RecognizeQrCodeResponseBodyDataElementsResults : TeaModel {
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    [NameInMap("QrCodesData")]
                    [Validation(Required=false)]
                    public List<string> QrCodesData { get; set; }

                    [NameInMap("Rate")]
                    [Validation(Required=false)]
                    public float? Rate { get; set; }

                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                }

                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
