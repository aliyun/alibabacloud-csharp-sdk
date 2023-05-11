// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class DetectUserFaceByUrlResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectUserFaceByUrlResponseBodyData Data { get; set; }
        public class DetectUserFaceByUrlResponseBodyData : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public List<DetectUserFaceByUrlResponseBodyDataData> Data { get; set; }
            public class DetectUserFaceByUrlResponseBodyDataData : TeaModel {
                [NameInMap("Age")]
                [Validation(Required=false)]
                public int? Age { get; set; }

                [NameInMap("BlurScore")]
                [Validation(Required=false)]
                public float? BlurScore { get; set; }

                [NameInMap("FaceProbability")]
                [Validation(Required=false)]
                public float? FaceProbability { get; set; }

                [NameInMap("FaceRects")]
                [Validation(Required=false)]
                public DetectUserFaceByUrlResponseBodyDataDataFaceRects FaceRects { get; set; }
                public class DetectUserFaceByUrlResponseBodyDataDataFaceRects : TeaModel {
                    [NameInMap("FaceRectsData")]
                    [Validation(Required=false)]
                    public List<string> FaceRectsData { get; set; }

                }

                [NameInMap("Gender")]
                [Validation(Required=false)]
                public int? Gender { get; set; }

                [NameInMap("GoodForLibrary")]
                [Validation(Required=false)]
                public bool? GoodForLibrary { get; set; }

                [NameInMap("GoodForRecognition")]
                [Validation(Required=false)]
                public bool? GoodForRecognition { get; set; }

                [NameInMap("Landmarks")]
                [Validation(Required=false)]
                public DetectUserFaceByUrlResponseBodyDataDataLandmarks Landmarks { get; set; }
                public class DetectUserFaceByUrlResponseBodyDataDataLandmarks : TeaModel {
                    [NameInMap("LandmarksData")]
                    [Validation(Required=false)]
                    public List<string> LandmarksData { get; set; }

                }

                [NameInMap("OcclusionScore")]
                [Validation(Required=false)]
                public float? OcclusionScore { get; set; }

                [NameInMap("PoseScore")]
                [Validation(Required=false)]
                public float? PoseScore { get; set; }

            }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
