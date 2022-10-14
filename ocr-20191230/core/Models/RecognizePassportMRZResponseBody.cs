// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizePassportMRZResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizePassportMRZResponseBodyData Data { get; set; }
        public class RecognizePassportMRZResponseBodyData : TeaModel {
            [NameInMap("Regions")]
            [Validation(Required=false)]
            public List<RecognizePassportMRZResponseBodyDataRegions> Regions { get; set; }
            public class RecognizePassportMRZResponseBodyDataRegions : TeaModel {
                [NameInMap("BandBoxes")]
                [Validation(Required=false)]
                public List<float?> BandBoxes { get; set; }

                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("DetectionScore")]
                [Validation(Required=false)]
                public float? DetectionScore { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("RecognitionScore")]
                [Validation(Required=false)]
                public float? RecognitionScore { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
