// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class DetectCardScreenshotResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public DetectCardScreenshotResponseData Data { get; set; }
        public class DetectCardScreenshotResponseData : TeaModel {
            [NameInMap("IsCard")]
            [Validation(Required=true)]
            public bool? IsCard { get; set; }
            [NameInMap("IsBlur")]
            [Validation(Required=true)]
            public bool? IsBlur { get; set; }
            [NameInMap("SpoofResult")]
            [Validation(Required=true)]
            public DetectCardScreenshotResponseDataSpoofResult SpoofResult { get; set; }
            public class DetectCardScreenshotResponseDataSpoofResult : TeaModel {
                [NameInMap("IsSpoof")]
                [Validation(Required=true)]
                public bool? IsSpoof { get; set; }

                [NameInMap("ResultMap")]
                [Validation(Required=true)]
                public DetectCardScreenshotResponseDataSpoofResultResultMap ResultMap { get; set; }
                public class DetectCardScreenshotResponseDataSpoofResultResultMap : TeaModel {
                    [NameInMap("ScreenScore")]
                    [Validation(Required=true)]
                    public float? ScreenScore { get; set; }
                    [NameInMap("ScreenThreshold")]
                    [Validation(Required=true)]
                    public float? ScreenThreshold { get; set; }
                };

            }
        };

    }

}
