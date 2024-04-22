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

            /// <summary>
            /// 1
            /// </summary>
            [NameInMap("FaceProbabilityList")]
            [Validation(Required=false)]
            public List<float?> FaceProbabilityList { get; set; }

            /// <summary>
            /// 1
            /// </summary>
            [NameInMap("FaceRectangles")]
            [Validation(Required=false)]
            public List<int?> FaceRectangles { get; set; }

            [NameInMap("LandmarkCount")]
            [Validation(Required=false)]
            public int? LandmarkCount { get; set; }

            [NameInMap("LandmarkScore")]
            [Validation(Required=false)]
            public List<float?> LandmarkScore { get; set; }

            /// <summary>
            /// 1
            /// </summary>
            [NameInMap("Landmarks")]
            [Validation(Required=false)]
            public List<float?> Landmarks { get; set; }

            /// <summary>
            /// 1
            /// </summary>
            [NameInMap("PoseList")]
            [Validation(Required=false)]
            public List<float?> PoseList { get; set; }

            /// <summary>
            /// 1
            /// </summary>
            [NameInMap("Pupils")]
            [Validation(Required=false)]
            public List<double?> Pupils { get; set; }

            [NameInMap("Qualities")]
            [Validation(Required=false)]
            public DetectFaceResponseBodyDataQualities Qualities { get; set; }
            public class DetectFaceResponseBodyDataQualities : TeaModel {
                /// <summary>
                /// 1
                /// </summary>
                [NameInMap("BlurList")]
                [Validation(Required=false)]
                public List<float?> BlurList { get; set; }

                /// <summary>
                /// 1
                /// </summary>
                [NameInMap("FnfList")]
                [Validation(Required=false)]
                public List<float?> FnfList { get; set; }

                /// <summary>
                /// 1
                /// </summary>
                [NameInMap("GlassList")]
                [Validation(Required=false)]
                public List<float?> GlassList { get; set; }

                /// <summary>
                /// 1
                /// </summary>
                [NameInMap("IlluList")]
                [Validation(Required=false)]
                public List<float?> IlluList { get; set; }

                /// <summary>
                /// 1
                /// </summary>
                [NameInMap("MaskList")]
                [Validation(Required=false)]
                public List<float?> MaskList { get; set; }

                /// <summary>
                /// 1
                /// </summary>
                [NameInMap("NoiseList")]
                [Validation(Required=false)]
                public List<float?> NoiseList { get; set; }

                /// <summary>
                /// 1
                /// </summary>
                [NameInMap("PoseList")]
                [Validation(Required=false)]
                public List<float?> PoseList { get; set; }

                /// <summary>
                /// 1
                /// </summary>
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
