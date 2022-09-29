// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class DetectLivingFaceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectLivingFaceResponseBodyData Data { get; set; }
        public class DetectLivingFaceResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<DetectLivingFaceResponseBodyDataElements> Elements { get; set; }
            public class DetectLivingFaceResponseBodyDataElements : TeaModel {
                [NameInMap("ImageURL")]
                [Validation(Required=false)]
                public string ImageURL { get; set; }

                [NameInMap("Results")]
                [Validation(Required=false)]
                public List<DetectLivingFaceResponseBodyDataElementsResults> Results { get; set; }
                public class DetectLivingFaceResponseBodyDataElementsResults : TeaModel {
                    [NameInMap("Frames")]
                    [Validation(Required=false)]
                    public List<DetectLivingFaceResponseBodyDataElementsResultsFrames> Frames { get; set; }
                    public class DetectLivingFaceResponseBodyDataElementsResultsFrames : TeaModel {
                        [NameInMap("Rate")]
                        [Validation(Required=false)]
                        public float? Rate { get; set; }

                        [NameInMap("Url")]
                        [Validation(Required=false)]
                        public string Url { get; set; }

                    }

                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    [NameInMap("Rate")]
                    [Validation(Required=false)]
                    public float? Rate { get; set; }

                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                }

                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
