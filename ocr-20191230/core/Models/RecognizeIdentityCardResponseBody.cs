// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizeIdentityCardResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeIdentityCardResponseBodyData Data { get; set; }
        public class RecognizeIdentityCardResponseBodyData : TeaModel {
            [NameInMap("BackResult")]
            [Validation(Required=false)]
            public RecognizeIdentityCardResponseBodyDataBackResult BackResult { get; set; }
            public class RecognizeIdentityCardResponseBodyDataBackResult : TeaModel {
                [NameInMap("EndDate")]
                [Validation(Required=false)]
                public string EndDate { get; set; }

                [NameInMap("Issue")]
                [Validation(Required=false)]
                public string Issue { get; set; }

                [NameInMap("StartDate")]
                [Validation(Required=false)]
                public string StartDate { get; set; }

            }
            [NameInMap("FrontResult")]
            [Validation(Required=false)]
            public RecognizeIdentityCardResponseBodyDataFrontResult FrontResult { get; set; }
            public class RecognizeIdentityCardResponseBodyDataFrontResult : TeaModel {
                [NameInMap("FaceRectangle")]
                [Validation(Required=false)]
                public RecognizeIdentityCardResponseBodyDataFrontResultFaceRectangle FaceRectangle { get; set; }
                public class RecognizeIdentityCardResponseBodyDataFrontResultFaceRectangle : TeaModel {
                    [NameInMap("Size")]
                    [Validation(Required=false)]
                    public RecognizeIdentityCardResponseBodyDataFrontResultFaceRectangleSize Size { get; set; }
                    public class RecognizeIdentityCardResponseBodyDataFrontResultFaceRectangleSize : TeaModel {
                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public float? Width { get; set; }

                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public float? Height { get; set; }

                    }
                    [NameInMap("Angle")]
                    [Validation(Required=false)]
                    public float? Angle { get; set; }
                    [NameInMap("Center")]
                    [Validation(Required=false)]
                    public RecognizeIdentityCardResponseBodyDataFrontResultFaceRectangleCenter Center { get; set; }
                    public class RecognizeIdentityCardResponseBodyDataFrontResultFaceRectangleCenter : TeaModel {
                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public float? Y { get; set; }

                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public float? X { get; set; }

                    }
                };

                [NameInMap("BirthDate")]
                [Validation(Required=false)]
                public string BirthDate { get; set; }

                [NameInMap("Gender")]
                [Validation(Required=false)]
                public string Gender { get; set; }

                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                [NameInMap("FaceRectVertices")]
                [Validation(Required=false)]
                public List<RecognizeIdentityCardResponseBodyDataFrontResultFaceRectVertices> FaceRectVertices { get; set; }
                public class RecognizeIdentityCardResponseBodyDataFrontResultFaceRectVertices : TeaModel {
                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public float? Y { get; set; }

                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public float? X { get; set; }

                }

                [NameInMap("CardAreas")]
                [Validation(Required=false)]
                public List<RecognizeIdentityCardResponseBodyDataFrontResultCardAreas> CardAreas { get; set; }
                public class RecognizeIdentityCardResponseBodyDataFrontResultCardAreas : TeaModel {
                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public float? Y { get; set; }

                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public float? X { get; set; }

                }

                [NameInMap("Nationality")]
                [Validation(Required=false)]
                public string Nationality { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("IDNumber")]
                [Validation(Required=false)]
                public string IDNumber { get; set; }

            }
        };

    }

}
