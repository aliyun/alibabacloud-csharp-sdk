// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class CompareFaceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CompareFaceResponseBodyData Data { get; set; }
        public class CompareFaceResponseBodyData : TeaModel {
            [NameInMap("Confidence")]
            [Validation(Required=false)]
            public float? Confidence { get; set; }

            [NameInMap("IsMaskA")]
            [Validation(Required=false)]
            public long? IsMaskA { get; set; }

            [NameInMap("IsMaskB")]
            [Validation(Required=false)]
            public long? IsMaskB { get; set; }

            [NameInMap("LandmarksAList")]
            [Validation(Required=false)]
            public List<long?> LandmarksAList { get; set; }

            [NameInMap("LandmarksBList")]
            [Validation(Required=false)]
            public List<long?> LandmarksBList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>imageB quality score less threshold</para>
            /// </summary>
            [NameInMap("MessageTips")]
            [Validation(Required=false)]
            public string MessageTips { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>75.16</para>
            /// </summary>
            [NameInMap("QualityScoreA")]
            [Validation(Required=false)]
            public float? QualityScoreA { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>75.20</para>
            /// </summary>
            [NameInMap("QualityScoreB")]
            [Validation(Required=false)]
            public float? QualityScoreB { get; set; }

            /// <summary>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RectAList")]
            [Validation(Required=false)]
            public List<int?> RectAList { get; set; }

            /// <summary>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RectBList")]
            [Validation(Required=false)]
            public List<int?> RectBList { get; set; }

            /// <summary>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Thresholds")]
            [Validation(Required=false)]
            public List<float?> Thresholds { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
