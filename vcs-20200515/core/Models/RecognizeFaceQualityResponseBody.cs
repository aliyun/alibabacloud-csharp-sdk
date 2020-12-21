// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class RecognizeFaceQualityResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeFaceQualityResponseBodyData Data { get; set; }
        public class RecognizeFaceQualityResponseBodyData : TeaModel {
            [NameInMap("QualityScore")]
            [Validation(Required=false)]
            public string QualityScore { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public RecognizeFaceQualityResponseBodyDataAttributes Attributes { get; set; }
            public class RecognizeFaceQualityResponseBodyDataAttributes : TeaModel {
                [NameInMap("FaceScore")]
                [Validation(Required=false)]
                public string FaceScore { get; set; }

                [NameInMap("RightBottomY")]
                [Validation(Required=false)]
                public int? RightBottomY { get; set; }

                [NameInMap("LeftTopY")]
                [Validation(Required=false)]
                public int? LeftTopY { get; set; }

                [NameInMap("FaceStyle")]
                [Validation(Required=false)]
                public string FaceStyle { get; set; }

                [NameInMap("FaceQuality")]
                [Validation(Required=false)]
                public string FaceQuality { get; set; }

                [NameInMap("LeftTopX")]
                [Validation(Required=false)]
                public int? LeftTopX { get; set; }

                [NameInMap("RightBottomX")]
                [Validation(Required=false)]
                public int? RightBottomX { get; set; }

                [NameInMap("TargetImageStoragePath")]
                [Validation(Required=false)]
                public string TargetImageStoragePath { get; set; }

            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
