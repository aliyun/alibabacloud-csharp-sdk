// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizePassportMRZResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizePassportMRZResponseBodyData Data { get; set; }
        public class RecognizePassportMRZResponseBodyData : TeaModel {
            [NameInMap("Regions")]
            [Validation(Required=false)]
            public List<RecognizePassportMRZResponseBodyDataRegions> Regions { get; set; }
            public class RecognizePassportMRZResponseBodyDataRegions : TeaModel {
                public float? RecognitionScore { get; set; }
                public float? DetectionScore { get; set; }
                public string Name { get; set; }
                public string Content { get; set; }
                public List<string> BandBoxes { get; set; }
            }
        };

    }

}
