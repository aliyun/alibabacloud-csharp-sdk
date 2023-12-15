// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CDRS20201101.Models
{
    public class RecognizeImageResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeImageResponseBodyData Data { get; set; }
        public class RecognizeImageResponseBodyData : TeaModel {
            [NameInMap("BodyList")]
            [Validation(Required=false)]
            public List<RecognizeImageResponseBodyDataBodyList> BodyList { get; set; }
            public class RecognizeImageResponseBodyDataBodyList : TeaModel {
                [NameInMap("CropAlgorithmCode")]
                [Validation(Required=false)]
                public string CropAlgorithmCode { get; set; }

                [NameInMap("Feature")]
                [Validation(Required=false)]
                public string Feature { get; set; }

                [NameInMap("LeftTopX")]
                [Validation(Required=false)]
                public int? LeftTopX { get; set; }

                [NameInMap("LeftTopY")]
                [Validation(Required=false)]
                public int? LeftTopY { get; set; }

                [NameInMap("RightBottomX")]
                [Validation(Required=false)]
                public int? RightBottomX { get; set; }

                [NameInMap("RightBottomY")]
                [Validation(Required=false)]
                public int? RightBottomY { get; set; }

                [NameInMap("TargetImageContent")]
                [Validation(Required=false)]
                public string TargetImageContent { get; set; }

            }

            [NameInMap("FaceList")]
            [Validation(Required=false)]
            public List<RecognizeImageResponseBodyDataFaceList> FaceList { get; set; }
            public class RecognizeImageResponseBodyDataFaceList : TeaModel {
                [NameInMap("CropAlgorithmCode")]
                [Validation(Required=false)]
                public string CropAlgorithmCode { get; set; }

                [NameInMap("FaceKeyPointQuality")]
                [Validation(Required=false)]
                public float? FaceKeyPointQuality { get; set; }

                [NameInMap("FaceQuality")]
                [Validation(Required=false)]
                public float? FaceQuality { get; set; }

                [NameInMap("Feature")]
                [Validation(Required=false)]
                public string Feature { get; set; }

                [NameInMap("LeftTopX")]
                [Validation(Required=false)]
                public int? LeftTopX { get; set; }

                [NameInMap("LeftTopY")]
                [Validation(Required=false)]
                public int? LeftTopY { get; set; }

                [NameInMap("RightBottomX")]
                [Validation(Required=false)]
                public int? RightBottomX { get; set; }

                [NameInMap("RightBottomY")]
                [Validation(Required=false)]
                public int? RightBottomY { get; set; }

                [NameInMap("TargetImageContent")]
                [Validation(Required=false)]
                public string TargetImageContent { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
