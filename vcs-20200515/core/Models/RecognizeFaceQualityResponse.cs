// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class RecognizeFaceQualityResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public RecognizeFaceQualityResponseData Data { get; set; }
        public class RecognizeFaceQualityResponseData : TeaModel {
            [NameInMap("QualityScore")]
            [Validation(Required=true)]
            public string QualityScore { get; set; }
            [NameInMap("Description")]
            [Validation(Required=true)]
            public string Description { get; set; }
            [NameInMap("Attributes")]
            [Validation(Required=true)]
            public RecognizeFaceQualityResponseDataAttributes Attributes { get; set; }
            public class RecognizeFaceQualityResponseDataAttributes : TeaModel {
                [NameInMap("LeftTopX")]
                [Validation(Required=true)]
                public int? LeftTopX { get; set; }

                [NameInMap("LeftTopY")]
                [Validation(Required=true)]
                public int? LeftTopY { get; set; }

                [NameInMap("RightBottomX")]
                [Validation(Required=true)]
                public int? RightBottomX { get; set; }

                [NameInMap("RightBottomY")]
                [Validation(Required=true)]
                public int? RightBottomY { get; set; }

                [NameInMap("TargetImageStoragePath")]
                [Validation(Required=true)]
                public string TargetImageStoragePath { get; set; }

                [NameInMap("FaceStyle")]
                [Validation(Required=true)]
                public string FaceStyle { get; set; }

                [NameInMap("FaceQuality")]
                [Validation(Required=true)]
                public string FaceQuality { get; set; }

                [NameInMap("FaceScore")]
                [Validation(Required=true)]
                public string FaceScore { get; set; }

            }
        };

    }

}
