// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class DetectUserFaceByUrlResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectUserFaceByUrlResponseBodyData Data { get; set; }
        public class DetectUserFaceByUrlResponseBodyData : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public List<DetectUserFaceByUrlResponseBodyDataData> Data { get; set; }
            public class DetectUserFaceByUrlResponseBodyDataData : TeaModel {
                public int? Gender { get; set; }
                public DetectUserFaceByUrlResponseBodyDataDataFaceRects FaceRects { get; set; }
                public class DetectUserFaceByUrlResponseBodyDataDataFaceRects : TeaModel {
                    [NameInMap("FaceRectsData")]
                    [Validation(Required=false)]
                    public List<string> FaceRectsData { get; set; }

                }
                public int? Age { get; set; }
                public DetectUserFaceByUrlResponseBodyDataDataLandmarks Landmarks { get; set; }
                public class DetectUserFaceByUrlResponseBodyDataDataLandmarks : TeaModel {
                    [NameInMap("LandmarksData")]
                    [Validation(Required=false)]
                    public List<string> LandmarksData { get; set; }

                }
                public float? FaceProbability { get; set; }
            }
        };

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
