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
                public float? FaceConfidence { get; set; }
                public float? LiveConfidence { get; set; }
                public List<string> Rect { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
