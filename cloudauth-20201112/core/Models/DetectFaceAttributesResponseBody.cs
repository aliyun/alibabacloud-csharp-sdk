// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20201112.Models
{
    public class DetectFaceAttributesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public DetectFaceAttributesResponseBodyResultObject ResultObject { get; set; }
        public class DetectFaceAttributesResponseBodyResultObject : TeaModel {
            [NameInMap("ImgHeight")]
            [Validation(Required=false)]
            public int? ImgHeight { get; set; }
            [NameInMap("ImgWidth")]
            [Validation(Required=false)]
            public int? ImgWidth { get; set; }
            [NameInMap("FaceInfos")]
            [Validation(Required=false)]
            public DetectFaceAttributesResponseBodyResultObjectFaceInfos FaceInfos { get; set; }
            public class DetectFaceAttributesResponseBodyResultObjectFaceInfos : TeaModel {
                [NameInMap("FaceAttributesDetectInfo")]
                [Validation(Required=false)]
                public List<DetectFaceAttributesResponseBodyResultObjectFaceInfosFaceAttributesDetectInfo> FaceAttributesDetectInfo { get; set; }
                public class DetectFaceAttributesResponseBodyResultObjectFaceInfosFaceAttributesDetectInfo : TeaModel {
                    [NameInMap("FaceRect")]
                    [Validation(Required=false)]
                    public DetectFaceAttributesResponseBodyResultObjectFaceInfosFaceAttributesDetectInfoFaceRect FaceRect { get; set; }
                    public class DetectFaceAttributesResponseBodyResultObjectFaceInfosFaceAttributesDetectInfoFaceRect : TeaModel {
                        [NameInMap("Left")]
                        [Validation(Required=false)]
                        public int? Left { get; set; }
                        [NameInMap("Top")]
                        [Validation(Required=false)]
                        public int? Top { get; set; }
                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public int? Width { get; set; }
                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public int? Height { get; set; }
                    };

                    [NameInMap("FaceAttributes")]
                    [Validation(Required=false)]
                    public DetectFaceAttributesResponseBodyResultObjectFaceInfosFaceAttributesDetectInfoFaceAttributes FaceAttributes { get; set; }
                    public class DetectFaceAttributesResponseBodyResultObjectFaceInfosFaceAttributesDetectInfoFaceAttributes : TeaModel {
                        [NameInMap("Glasses")]
                        [Validation(Required=false)]
                        public string Glasses { get; set; }
                        [NameInMap("Facequal")]
                        [Validation(Required=false)]
                        public float? Facequal { get; set; }
                        [NameInMap("Integrity")]
                        [Validation(Required=false)]
                        public int? Integrity { get; set; }
                        [NameInMap("Facetype")]
                        [Validation(Required=false)]
                        public string Facetype { get; set; }
                        [NameInMap("Respirator")]
                        [Validation(Required=false)]
                        public string Respirator { get; set; }
                        [NameInMap("AppearanceScore")]
                        [Validation(Required=false)]
                        public float? AppearanceScore { get; set; }
                        [NameInMap("Blur")]
                        [Validation(Required=false)]
                        public float? Blur { get; set; }
                        [NameInMap("Smiling")]
                        [Validation(Required=false)]
                        public DetectFaceAttributesResponseBodyResultObjectFaceInfosFaceAttributesDetectInfoFaceAttributesSmiling Smiling { get; set; }
                        public class DetectFaceAttributesResponseBodyResultObjectFaceInfosFaceAttributesDetectInfoFaceAttributesSmiling : TeaModel {
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public float? Value { get; set; }

                            [NameInMap("Threshold")]
                            [Validation(Required=false)]
                            public float? Threshold { get; set; }

                        }
                        [NameInMap("Headpose")]
                        [Validation(Required=false)]
                        public DetectFaceAttributesResponseBodyResultObjectFaceInfosFaceAttributesDetectInfoFaceAttributesHeadpose Headpose { get; set; }
                        public class DetectFaceAttributesResponseBodyResultObjectFaceInfosFaceAttributesDetectInfoFaceAttributesHeadpose : TeaModel {
                            [NameInMap("PitchAngle")]
                            [Validation(Required=false)]
                            public float? PitchAngle { get; set; }

                            [NameInMap("RollAngle")]
                            [Validation(Required=false)]
                            public float? RollAngle { get; set; }

                            [NameInMap("YawAngle")]
                            [Validation(Required=false)]
                            public float? YawAngle { get; set; }

                        }
                    };

                }

            }
        };

    }

}
