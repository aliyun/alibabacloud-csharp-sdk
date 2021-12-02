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
                public string ImageURL { get; set; }
                public List<DetectLivingFaceResponseBodyDataElementsResults> Results { get; set; }
                public class DetectLivingFaceResponseBodyDataElementsResults : TeaModel {
                    public List<DetectLivingFaceResponseBodyDataElementsResultsFrames> Frames { get; set; }
                    public class DetectLivingFaceResponseBodyDataElementsResultsFrames : TeaModel {
                        public float? Rate { get; set; }
                        public string Url { get; set; }
                    }
                    public string Label { get; set; }
                    public float? Rate { get; set; }
                    public string Suggestion { get; set; }
                }
                public string TaskId { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
