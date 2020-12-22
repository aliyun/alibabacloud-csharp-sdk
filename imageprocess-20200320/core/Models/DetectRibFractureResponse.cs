// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class DetectRibFractureResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public DetectRibFractureResponseData Data { get; set; }
        public class DetectRibFractureResponseData : TeaModel {
            [NameInMap("ResultURL")]
            [Validation(Required=true)]
            public string ResultURL { get; set; }
            [NameInMap("Detections")]
            [Validation(Required=true)]
            public List<DetectRibFractureResponseDataDetections> Detections { get; set; }
            public class DetectRibFractureResponseDataDetections : TeaModel {
                public int? FractureId { get; set; }
                public float? FractureConfidence { get; set; }
                public string FractureCategory { get; set; }
                public List<string> Coordinates { get; set; }
                public List<string> CoordinateImage { get; set; }
            }
            [NameInMap("Spacing")]
            [Validation(Required=true)]
            public List<string> Spacing { get; set; }
            [NameInMap("Origin")]
            [Validation(Required=true)]
            public List<string> Origin { get; set; }
        };

    }

}
