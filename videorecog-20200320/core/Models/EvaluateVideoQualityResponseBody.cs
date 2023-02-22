// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videorecog20200320.Models
{
    public class EvaluateVideoQualityResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public EvaluateVideoQualityResponseBodyData Data { get; set; }
        public class EvaluateVideoQualityResponseBodyData : TeaModel {
            [NameInMap("JsonUrl")]
            [Validation(Required=false)]
            public string JsonUrl { get; set; }

            [NameInMap("PdfUrl")]
            [Validation(Required=false)]
            public string PdfUrl { get; set; }

            [NameInMap("VideoQualityInfo")]
            [Validation(Required=false)]
            public EvaluateVideoQualityResponseBodyDataVideoQualityInfo VideoQualityInfo { get; set; }
            public class EvaluateVideoQualityResponseBodyDataVideoQualityInfo : TeaModel {
                [NameInMap("Blurriness")]
                [Validation(Required=false)]
                public float? Blurriness { get; set; }

                [NameInMap("ColorContrast")]
                [Validation(Required=false)]
                public float? ColorContrast { get; set; }

                [NameInMap("ColorSaturation")]
                [Validation(Required=false)]
                public float? ColorSaturation { get; set; }

                [NameInMap("Colorfulness")]
                [Validation(Required=false)]
                public float? Colorfulness { get; set; }

                [NameInMap("CompressiveStrength")]
                [Validation(Required=false)]
                public float? CompressiveStrength { get; set; }

                [NameInMap("Luminance")]
                [Validation(Required=false)]
                public float? Luminance { get; set; }

                [NameInMap("MosScore")]
                [Validation(Required=false)]
                public float? MosScore { get; set; }

                [NameInMap("NoiseIntensity")]
                [Validation(Required=false)]
                public float? NoiseIntensity { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
