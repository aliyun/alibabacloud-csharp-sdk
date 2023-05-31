// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class DetectLiverSteatosisResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectLiverSteatosisResponseBodyData Data { get; set; }
        public class DetectLiverSteatosisResponseBodyData : TeaModel {
            [NameInMap("Detections")]
            [Validation(Required=false)]
            public List<DetectLiverSteatosisResponseBodyDataDetections> Detections { get; set; }
            public class DetectLiverSteatosisResponseBodyDataDetections : TeaModel {
                [NameInMap("LiverHU")]
                [Validation(Required=false)]
                public float? LiverHU { get; set; }

                [NameInMap("LiverROI1")]
                [Validation(Required=false)]
                public float? LiverROI1 { get; set; }

                [NameInMap("LiverROI2")]
                [Validation(Required=false)]
                public float? LiverROI2 { get; set; }

                [NameInMap("LiverROI3")]
                [Validation(Required=false)]
                public float? LiverROI3 { get; set; }

                [NameInMap("LiverSlice")]
                [Validation(Required=false)]
                public float? LiverSlice { get; set; }

                [NameInMap("LiverSpleenDifference")]
                [Validation(Required=false)]
                public float? LiverSpleenDifference { get; set; }

                [NameInMap("LiverSpleenRatio")]
                [Validation(Required=false)]
                public float? LiverSpleenRatio { get; set; }

                [NameInMap("LiverVolume")]
                [Validation(Required=false)]
                public float? LiverVolume { get; set; }

                [NameInMap("Prediction")]
                [Validation(Required=false)]
                public string Prediction { get; set; }

                [NameInMap("Probability")]
                [Validation(Required=false)]
                public float? Probability { get; set; }

                [NameInMap("ROI1Center")]
                [Validation(Required=false)]
                public List<long?> ROI1Center { get; set; }

                [NameInMap("ROI2Center")]
                [Validation(Required=false)]
                public List<long?> ROI2Center { get; set; }

                [NameInMap("ROI3Center")]
                [Validation(Required=false)]
                public List<long?> ROI3Center { get; set; }

                [NameInMap("Radius")]
                [Validation(Required=false)]
                public long? Radius { get; set; }

                [NameInMap("SpleenCenter")]
                [Validation(Required=false)]
                public List<long?> SpleenCenter { get; set; }

                [NameInMap("SpleenHU")]
                [Validation(Required=false)]
                public float? SpleenHU { get; set; }

                [NameInMap("SpleenROI")]
                [Validation(Required=false)]
                public float? SpleenROI { get; set; }

                [NameInMap("SpleenSlice")]
                [Validation(Required=false)]
                public float? SpleenSlice { get; set; }

                [NameInMap("SpleenVolume")]
                [Validation(Required=false)]
                public float? SpleenVolume { get; set; }

            }

            [NameInMap("Origin")]
            [Validation(Required=false)]
            public List<float?> Origin { get; set; }

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
