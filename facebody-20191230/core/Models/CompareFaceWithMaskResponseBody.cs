// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class CompareFaceWithMaskResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CompareFaceWithMaskResponseBodyData Data { get; set; }
        public class CompareFaceWithMaskResponseBodyData : TeaModel {
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

            [NameInMap("QualityScoreA")]
            [Validation(Required=false)]
            public float? QualityScoreA { get; set; }

            [NameInMap("QualityScoreB")]
            [Validation(Required=false)]
            public float? QualityScoreB { get; set; }

            [NameInMap("RectAList")]
            [Validation(Required=false)]
            public List<long?> RectAList { get; set; }

            [NameInMap("RectBList")]
            [Validation(Required=false)]
            public List<long?> RectBList { get; set; }

            [NameInMap("Thresholds")]
            [Validation(Required=false)]
            public List<long?> Thresholds { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C6499918-E932-41B3-96F5-A18F50D262DD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
