// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class DetectRibFractureResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectRibFractureResponseBodyData Data { get; set; }
        public class DetectRibFractureResponseBodyData : TeaModel {
            [NameInMap("Detections")]
            [Validation(Required=false)]
            public List<DetectRibFractureResponseBodyDataDetections> Detections { get; set; }
            public class DetectRibFractureResponseBodyDataDetections : TeaModel {
                public List<string> Coordinates { get; set; }
                public int? FractureId { get; set; }
                public List<string> CoordinateImage { get; set; }
                public float? FractureConfidence { get; set; }
                public string FractureCategory { get; set; }
            }
            [NameInMap("Origin")]
            [Validation(Required=false)]
            public List<string> Origin { get; set; }
            [NameInMap("ResultURL")]
            [Validation(Required=false)]
            public string ResultURL { get; set; }
            [NameInMap("Spacing")]
            [Validation(Required=false)]
            public List<string> Spacing { get; set; }
        };

    }

}
