// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20170906.Models
{
    public class GetImageQualityResponseBody : TeaModel {
        [NameInMap("ImageQuality")]
        [Validation(Required=false)]
        public GetImageQualityResponseBodyImageQuality ImageQuality { get; set; }
        public class GetImageQualityResponseBodyImageQuality : TeaModel {
            [NameInMap("OverallScore")]
            [Validation(Required=false)]
            public float? OverallScore { get; set; }
            [NameInMap("Color")]
            [Validation(Required=false)]
            public float? Color { get; set; }
            [NameInMap("ColorScore")]
            [Validation(Required=false)]
            public float? ColorScore { get; set; }
            [NameInMap("ContrastScore")]
            [Validation(Required=false)]
            public float? ContrastScore { get; set; }
            [NameInMap("Contrast")]
            [Validation(Required=false)]
            public float? Contrast { get; set; }
            [NameInMap("ExposureScore")]
            [Validation(Required=false)]
            public float? ExposureScore { get; set; }
            [NameInMap("ClarityScore")]
            [Validation(Required=false)]
            public float? ClarityScore { get; set; }
            [NameInMap("Clarity")]
            [Validation(Required=false)]
            public float? Clarity { get; set; }
            [NameInMap("Exposure")]
            [Validation(Required=false)]
            public float? Exposure { get; set; }
            [NameInMap("CompositionScore")]
            [Validation(Required=false)]
            public float? CompositionScore { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ImageUri")]
        [Validation(Required=false)]
        public string ImageUri { get; set; }

    }

}
