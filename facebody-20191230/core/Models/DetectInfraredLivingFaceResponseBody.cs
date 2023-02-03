// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class DetectInfraredLivingFaceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectInfraredLivingFaceResponseBodyData Data { get; set; }
        public class DetectInfraredLivingFaceResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<DetectInfraredLivingFaceResponseBodyDataElements> Elements { get; set; }
            public class DetectInfraredLivingFaceResponseBodyDataElements : TeaModel {
                [NameInMap("FaceNumber")]
                [Validation(Required=false)]
                public long? FaceNumber { get; set; }

                [NameInMap("ImageURL")]
                [Validation(Required=false)]
                public string ImageURL { get; set; }

                [NameInMap("Results")]
                [Validation(Required=false)]
                public List<DetectInfraredLivingFaceResponseBodyDataElementsResults> Results { get; set; }
                public class DetectInfraredLivingFaceResponseBodyDataElementsResults : TeaModel {
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    [NameInMap("MessageTips")]
                    [Validation(Required=false)]
                    public string MessageTips { get; set; }

                    [NameInMap("Rate")]
                    [Validation(Required=false)]
                    public float? Rate { get; set; }

                    [NameInMap("Rect")]
                    [Validation(Required=false)]
                    public DetectInfraredLivingFaceResponseBodyDataElementsResultsRect Rect { get; set; }
                    public class DetectInfraredLivingFaceResponseBodyDataElementsResultsRect : TeaModel {
                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public long? Height { get; set; }

                        [NameInMap("Left")]
                        [Validation(Required=false)]
                        public long? Left { get; set; }

                        [NameInMap("Top")]
                        [Validation(Required=false)]
                        public long? Top { get; set; }

                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public long? Width { get; set; }

                    }

                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
