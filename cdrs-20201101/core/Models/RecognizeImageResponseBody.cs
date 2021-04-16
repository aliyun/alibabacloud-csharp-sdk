// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CDRS20201101.Models
{
    public class RecognizeImageResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeImageResponseBodyData Data { get; set; }
        public class RecognizeImageResponseBodyData : TeaModel {
            [NameInMap("BodyList")]
            [Validation(Required=false)]
            public List<RecognizeImageResponseBodyDataBodyList> BodyList { get; set; }
            public class RecognizeImageResponseBodyDataBodyList : TeaModel {
                public string CropAlgorithmCode { get; set; }
                public int? RightBottomY { get; set; }
                public string Feature { get; set; }
                public int? LeftTopY { get; set; }
                public string TargetImageContent { get; set; }
                public int? LeftTopX { get; set; }
                public int? RightBottomX { get; set; }
            }
            [NameInMap("FaceList")]
            [Validation(Required=false)]
            public List<RecognizeImageResponseBodyDataFaceList> FaceList { get; set; }
            public class RecognizeImageResponseBodyDataFaceList : TeaModel {
                public string CropAlgorithmCode { get; set; }
                public string Feature { get; set; }
                public int? RightBottomY { get; set; }
                public int? LeftTopY { get; set; }
                public string TargetImageContent { get; set; }
                public float? FaceQuality { get; set; }
                public int? RightBottomX { get; set; }
                public int? LeftTopX { get; set; }
                public float? FaceKeyPointQuality { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
