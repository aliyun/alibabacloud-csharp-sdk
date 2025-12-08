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
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FaceCount")]
            [Validation(Required=false)]
            public int? FaceCount { get; set; }

            /// <summary>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FaceProbabilityList")]
            [Validation(Required=false)]
            public List<float?> FaceProbabilityList { get; set; }

            /// <summary>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FaceRectangles")]
            [Validation(Required=false)]
            public List<int?> FaceRectangles { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>105</para>
            /// </summary>
            [NameInMap("LandmarkCount")]
            [Validation(Required=false)]
            public int? LandmarkCount { get; set; }

            [NameInMap("LandmarkScore")]
            [Validation(Required=false)]
            public List<float?> LandmarkScore { get; set; }

            /// <summary>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Landmarks")]
            [Validation(Required=false)]
            public List<float?> Landmarks { get; set; }

            /// <summary>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PoseList")]
            [Validation(Required=false)]
            public List<float?> PoseList { get; set; }

            /// <summary>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Pupils")]
            [Validation(Required=false)]
            public List<double?> Pupils { get; set; }

            [NameInMap("Qualities")]
            [Validation(Required=false)]
            public DetectFaceResponseBodyDataQualities Qualities { get; set; }
            public class DetectFaceResponseBodyDataQualities : TeaModel {
                /// <summary>
                /// <para>1</para>
                /// </summary>
                [NameInMap("BlurList")]
                [Validation(Required=false)]
                public List<float?> BlurList { get; set; }

                /// <summary>
                /// <para>1</para>
                /// </summary>
                [NameInMap("FnfList")]
                [Validation(Required=false)]
                public List<float?> FnfList { get; set; }

                /// <summary>
                /// <para>1</para>
                /// </summary>
                [NameInMap("GlassList")]
                [Validation(Required=false)]
                public List<float?> GlassList { get; set; }

                /// <summary>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IlluList")]
                [Validation(Required=false)]
                public List<float?> IlluList { get; set; }

                /// <summary>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MaskList")]
                [Validation(Required=false)]
                public List<float?> MaskList { get; set; }

                /// <summary>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NoiseList")]
                [Validation(Required=false)]
                public List<float?> NoiseList { get; set; }

                /// <summary>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PoseList")]
                [Validation(Required=false)]
                public List<float?> PoseList { get; set; }

                /// <summary>
                /// <para>1</para>
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
