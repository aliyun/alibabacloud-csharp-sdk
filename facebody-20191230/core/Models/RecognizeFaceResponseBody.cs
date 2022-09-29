// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class RecognizeFaceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeFaceResponseBodyData Data { get; set; }
        public class RecognizeFaceResponseBodyData : TeaModel {
            [NameInMap("AgeList")]
            [Validation(Required=false)]
            public List<int?> AgeList { get; set; }

            [NameInMap("BeautyList")]
            [Validation(Required=false)]
            public List<float?> BeautyList { get; set; }

            [NameInMap("DenseFeatureLength")]
            [Validation(Required=false)]
            public int? DenseFeatureLength { get; set; }

            [NameInMap("DenseFeatures")]
            [Validation(Required=false)]
            public List<string> DenseFeatures { get; set; }

            [NameInMap("Expressions")]
            [Validation(Required=false)]
            public List<int?> Expressions { get; set; }

            [NameInMap("FaceCount")]
            [Validation(Required=false)]
            public int? FaceCount { get; set; }

            [NameInMap("FaceProbabilityList")]
            [Validation(Required=false)]
            public List<float?> FaceProbabilityList { get; set; }

            [NameInMap("FaceRectangles")]
            [Validation(Required=false)]
            public List<int?> FaceRectangles { get; set; }

            [NameInMap("GenderList")]
            [Validation(Required=false)]
            public List<int?> GenderList { get; set; }

            [NameInMap("Glasses")]
            [Validation(Required=false)]
            public List<int?> Glasses { get; set; }

            [NameInMap("HatList")]
            [Validation(Required=false)]
            public List<int?> HatList { get; set; }

            [NameInMap("LandmarkCount")]
            [Validation(Required=false)]
            public int? LandmarkCount { get; set; }

            [NameInMap("Landmarks")]
            [Validation(Required=false)]
            public List<float?> Landmarks { get; set; }

            [NameInMap("Masks")]
            [Validation(Required=false)]
            public List<long?> Masks { get; set; }

            [NameInMap("PoseList")]
            [Validation(Required=false)]
            public List<float?> PoseList { get; set; }

            [NameInMap("Pupils")]
            [Validation(Required=false)]
            public List<float?> Pupils { get; set; }

            [NameInMap("Qualities")]
            [Validation(Required=false)]
            public RecognizeFaceResponseBodyDataQualities Qualities { get; set; }
            public class RecognizeFaceResponseBodyDataQualities : TeaModel {
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

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
