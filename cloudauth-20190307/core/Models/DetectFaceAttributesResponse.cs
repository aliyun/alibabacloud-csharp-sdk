// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DetectFaceAttributesResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public DetectFaceAttributesResponseData Data { get; set; }
        public class DetectFaceAttributesResponseData : TeaModel {
            [NameInMap("ImgWidth")]
            [Validation(Required=true)]
            public int? ImgWidth { get; set; }
            [NameInMap("ImgHeight")]
            [Validation(Required=true)]
            public int? ImgHeight { get; set; }
            [NameInMap("FaceInfos")]
            [Validation(Required=true)]
            public DetectFaceAttributesResponseDataFaceInfos FaceInfos { get; set; }
            public class DetectFaceAttributesResponseDataFaceInfos : TeaModel {
                [NameInMap("FaceAttributesDetectInfo")]
                [Validation(Required=true)]
                public List<DetectFaceAttributesResponseDataFaceInfosFaceAttributesDetectInfo> FaceAttributesDetectInfo { get; set; }
                public class DetectFaceAttributesResponseDataFaceInfosFaceAttributesDetectInfo : TeaModel {
                    [NameInMap("FaceRect")]
                    [Validation(Required=true)]
                    public DetectFaceAttributesResponseDataFaceInfosFaceAttributesDetectInfoFaceRect FaceRect { get; set; }
                    public class DetectFaceAttributesResponseDataFaceInfosFaceAttributesDetectInfoFaceRect : TeaModel {
                        [NameInMap("Top")]
                        [Validation(Required=true)]
                        public int? Top { get; set; }
                        [NameInMap("Left")]
                        [Validation(Required=true)]
                        public int? Left { get; set; }
                        [NameInMap("Width")]
                        [Validation(Required=true)]
                        public int? Width { get; set; }
                        [NameInMap("Height")]
                        [Validation(Required=true)]
                        public int? Height { get; set; }
                    };

                    [NameInMap("FaceAttributes")]
                    [Validation(Required=true)]
                    public DetectFaceAttributesResponseDataFaceInfosFaceAttributesDetectInfoFaceAttributes FaceAttributes { get; set; }
                    public class DetectFaceAttributesResponseDataFaceInfosFaceAttributesDetectInfoFaceAttributes : TeaModel {
                        [NameInMap("Age")]
                        [Validation(Required=true)]
                        public int? Age { get; set; }
                        [NameInMap("Glasses")]
                        [Validation(Required=true)]
                        public string Glasses { get; set; }
                        [NameInMap("Facetype")]
                        [Validation(Required=true)]
                        public string Facetype { get; set; }
                        [NameInMap("Blur")]
                        [Validation(Required=true)]
                        public float? Blur { get; set; }
                        [NameInMap("Ethnicity")]
                        [Validation(Required=true)]
                        public string Ethnicity { get; set; }
                        [NameInMap("Gender")]
                        [Validation(Required=true)]
                        public DetectFaceAttributesResponseDataFaceInfosFaceAttributesDetectInfoFaceAttributesGender Gender { get; set; }
                        public class DetectFaceAttributesResponseDataFaceInfosFaceAttributesDetectInfoFaceAttributesGender : TeaModel {
                            [NameInMap("Score")]
                            [Validation(Required=true)]
                            public float? Score { get; set; }

                            [NameInMap("Value")]
                            [Validation(Required=true)]
                            public string Value { get; set; }

                        }
                        [NameInMap("Smiling")]
                        [Validation(Required=true)]
                        public DetectFaceAttributesResponseDataFaceInfosFaceAttributesDetectInfoFaceAttributesSmiling Smiling { get; set; }
                        public class DetectFaceAttributesResponseDataFaceInfosFaceAttributesDetectInfoFaceAttributesSmiling : TeaModel {
                            [NameInMap("Value")]
                            [Validation(Required=true)]
                            public float? Value { get; set; }

                            [NameInMap("Threshold")]
                            [Validation(Required=true)]
                            public float? Threshold { get; set; }

                        }
                        [NameInMap("Headpose")]
                        [Validation(Required=true)]
                        public DetectFaceAttributesResponseDataFaceInfosFaceAttributesDetectInfoFaceAttributesHeadpose Headpose { get; set; }
                        public class DetectFaceAttributesResponseDataFaceInfosFaceAttributesDetectInfoFaceAttributesHeadpose : TeaModel {
                            [NameInMap("PitchAngle")]
                            [Validation(Required=true)]
                            public float? PitchAngle { get; set; }

                            [NameInMap("RollAngle")]
                            [Validation(Required=true)]
                            public float? RollAngle { get; set; }

                            [NameInMap("YawAngle")]
                            [Validation(Required=true)]
                            public float? YawAngle { get; set; }

                        }
                    };

                }

            }
        };

    }

}
