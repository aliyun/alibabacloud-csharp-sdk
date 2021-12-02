// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class DetectFaceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectFaceResponseBodyData Data { get; set; }
        public class DetectFaceResponseBodyData : TeaModel {
            [NameInMap("FaceCount")]
            [Validation(Required=false)]
            public int? FaceCount { get; set; }
            [NameInMap("FaceProbabilityList")]
            [Validation(Required=false)]
            public List<string> FaceProbabilityList { get; set; }
            [NameInMap("FaceRectangles")]
            [Validation(Required=false)]
            public List<string> FaceRectangles { get; set; }
            [NameInMap("LandmarkCount")]
            [Validation(Required=false)]
            public int? LandmarkCount { get; set; }
            [NameInMap("Landmarks")]
            [Validation(Required=false)]
            public List<string> Landmarks { get; set; }
            [NameInMap("PoseList")]
            [Validation(Required=false)]
            public List<string> PoseList { get; set; }
            [NameInMap("Pupils")]
            [Validation(Required=false)]
            public List<string> Pupils { get; set; }
            [NameInMap("Qualities")]
            [Validation(Required=false)]
            public DetectFaceResponseBodyDataQualities Qualities { get; set; }
            public class DetectFaceResponseBodyDataQualities : TeaModel {
                [NameInMap("BlurList")]
                [Validation(Required=false)]
                public List<float?> BlurList { get; set; }

                [NameInMap("FnfList")]
                [Validation(Required=false)]
                public List<float?> FnfList { get; set; }

                [NameInMap("GlassList")]
                [Validation(Required=false)]
                public List<float?> GlassList { get; set; }

                [NameInMap("IlluList")]
                [Validation(Required=false)]
                public List<float?> IlluList { get; set; }

                [NameInMap("MaskList")]
                [Validation(Required=false)]
                public List<float?> MaskList { get; set; }

                [NameInMap("NoiseList")]
                [Validation(Required=false)]
                public List<float?> NoiseList { get; set; }

                [NameInMap("PoseList")]
                [Validation(Required=false)]
                public List<float?> PoseList { get; set; }

                [NameInMap("ScoreList")]
                [Validation(Required=false)]
                public List<float?> ScoreList { get; set; }

            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
