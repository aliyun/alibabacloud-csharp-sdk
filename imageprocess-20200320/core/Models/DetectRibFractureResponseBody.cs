// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class DetectRibFractureResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectRibFractureResponseBodyData Data { get; set; }
        public class DetectRibFractureResponseBodyData : TeaModel {
            [NameInMap("Detections")]
            [Validation(Required=false)]
            public List<DetectRibFractureResponseBodyDataDetections> Detections { get; set; }
            public class DetectRibFractureResponseBodyDataDetections : TeaModel {
                [NameInMap("CoordinateImage")]
                [Validation(Required=false)]
                public List<int?> CoordinateImage { get; set; }

                [NameInMap("Coordinates")]
                [Validation(Required=false)]
                public List<int?> Coordinates { get; set; }

                [NameInMap("FractureCategory")]
                [Validation(Required=false)]
                public string FractureCategory { get; set; }

                [NameInMap("FractureConfidence")]
                [Validation(Required=false)]
                public float? FractureConfidence { get; set; }

                [NameInMap("FractureId")]
                [Validation(Required=false)]
                public int? FractureId { get; set; }

                [NameInMap("FractureLocation")]
                [Validation(Required=false)]
                public string FractureLocation { get; set; }

                [NameInMap("FractureSegment")]
                [Validation(Required=false)]
                public long? FractureSegment { get; set; }

            }

            [NameInMap("Origin")]
            [Validation(Required=false)]
            public List<float?> Origin { get; set; }

            [NameInMap("ResultURL")]
            [Validation(Required=false)]
            public string ResultURL { get; set; }

            [NameInMap("Spacing")]
            [Validation(Required=false)]
            public List<float?> Spacing { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
