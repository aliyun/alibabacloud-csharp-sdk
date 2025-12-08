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
            /// <summary>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AgeList")]
            [Validation(Required=false)]
            public List<int?> AgeList { get; set; }

            /// <summary>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BeautyList")]
            [Validation(Required=false)]
            public List<float?> BeautyList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("DenseFeatureLength")]
            [Validation(Required=false)]
            public int? DenseFeatureLength { get; set; }

            /// <summary>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DenseFeatures")]
            [Validation(Required=false)]
            public List<string> DenseFeatures { get; set; }

            /// <summary>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Expressions")]
            [Validation(Required=false)]
            public List<int?> Expressions { get; set; }

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
            /// <para>1</para>
            /// </summary>
            [NameInMap("GenderList")]
            [Validation(Required=false)]
            public List<int?> GenderList { get; set; }

            /// <summary>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Glasses")]
            [Validation(Required=false)]
            public List<int?> Glasses { get; set; }

            /// <summary>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HatList")]
            [Validation(Required=false)]
            public List<int?> HatList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>105</para>
            /// </summary>
            [NameInMap("LandmarkCount")]
            [Validation(Required=false)]
            public int? LandmarkCount { get; set; }

            /// <summary>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Landmarks")]
            [Validation(Required=false)]
            public List<float?> Landmarks { get; set; }

            /// <summary>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Masks")]
            [Validation(Required=false)]
            public List<long?> Masks { get; set; }

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
            public List<float?> Pupils { get; set; }

            [NameInMap("Qualities")]
            [Validation(Required=false)]
            public RecognizeFaceResponseBodyDataQualities Qualities { get; set; }
            public class RecognizeFaceResponseBodyDataQualities : TeaModel {
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>8251C88E-8273-4DBF-94FB-A6BCB268CEA2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
