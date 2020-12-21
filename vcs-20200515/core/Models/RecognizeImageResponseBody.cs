// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
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
                public string RespiratorColor { get; set; }
                public string RightBottomY { get; set; }
                public string Feature { get; set; }
                public string LeftTopY { get; set; }
                public string ImageBaseSixFour { get; set; }
                public string FileName { get; set; }
                public string RightBottomX { get; set; }
                public string LocalFeature { get; set; }
                public string LeftTopX { get; set; }
            }
            [NameInMap("FaceList")]
            [Validation(Required=false)]
            public List<RecognizeImageResponseBodyDataFaceList> FaceList { get; set; }
            public class RecognizeImageResponseBodyDataFaceList : TeaModel {
                public float? Quality { get; set; }
                public string RespiratorColor { get; set; }
                public float? KeyPointQuality { get; set; }
                public string RightBottomY { get; set; }
                public string Feature { get; set; }
                public string LeftTopY { get; set; }
                public string ImageBaseSixFour { get; set; }
                public string FileName { get; set; }
                public string RightBottomX { get; set; }
                public string LocalFeature { get; set; }
                public string LeftTopX { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
