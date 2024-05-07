// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idrsservice20200630.Models
{
    public class FaceRecognizeResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public FaceRecognizeResponseBodyData Data { get; set; }
        public class FaceRecognizeResponseBodyData : TeaModel {
            [NameInMap("ComparePassed")]
            [Validation(Required=false)]
            public string ComparePassed { get; set; }

            [NameInMap("CompareScore")]
            [Validation(Required=false)]
            public float? CompareScore { get; set; }

            [NameInMap("LivenessPassed")]
            [Validation(Required=false)]
            public string LivenessPassed { get; set; }

            [NameInMap("LivenessScore")]
            [Validation(Required=false)]
            public float? LivenessScore { get; set; }

        }

        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
