// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class DetectCardScreenshotResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectCardScreenshotResponseBodyData Data { get; set; }
        public class DetectCardScreenshotResponseBodyData : TeaModel {
            [NameInMap("IsBlur")]
            [Validation(Required=false)]
            public bool? IsBlur { get; set; }

            [NameInMap("IsCard")]
            [Validation(Required=false)]
            public bool? IsCard { get; set; }

            [NameInMap("SpoofResult")]
            [Validation(Required=false)]
            public DetectCardScreenshotResponseBodyDataSpoofResult SpoofResult { get; set; }
            public class DetectCardScreenshotResponseBodyDataSpoofResult : TeaModel {
                [NameInMap("IsSpoof")]
                [Validation(Required=false)]
                public bool? IsSpoof { get; set; }

                [NameInMap("ResultMap")]
                [Validation(Required=false)]
                public DetectCardScreenshotResponseBodyDataSpoofResultResultMap ResultMap { get; set; }
                public class DetectCardScreenshotResponseBodyDataSpoofResultResultMap : TeaModel {
                    [NameInMap("ScreenScore")]
                    [Validation(Required=false)]
                    public float? ScreenScore { get; set; }

                    [NameInMap("ScreenThreshold")]
                    [Validation(Required=false)]
                    public float? ScreenThreshold { get; set; }

                }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
