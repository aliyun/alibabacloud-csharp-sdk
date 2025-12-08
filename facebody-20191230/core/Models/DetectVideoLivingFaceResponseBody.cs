// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class DetectVideoLivingFaceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectVideoLivingFaceResponseBodyData Data { get; set; }
        public class DetectVideoLivingFaceResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<DetectVideoLivingFaceResponseBodyDataElements> Elements { get; set; }
            public class DetectVideoLivingFaceResponseBodyDataElements : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0.84644949436187744</para>
                /// </summary>
                [NameInMap("FaceConfidence")]
                [Validation(Required=false)]
                public float? FaceConfidence { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.72464925050735474</para>
                /// </summary>
                [NameInMap("LiveConfidence")]
                [Validation(Required=false)]
                public float? LiveConfidence { get; set; }

                [NameInMap("Rect")]
                [Validation(Required=false)]
                public List<int?> Rect { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8E92F28B-F889-48CB-9FCC-3207CFA2215E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
