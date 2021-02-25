// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20201112.Models
{
    public class LivenessDetectResponseBody : TeaModel {
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public LivenessDetectResponseBodyResultObject ResultObject { get; set; }
        public class LivenessDetectResponseBodyResultObject : TeaModel {
            [NameInMap("Score")]
            [Validation(Required=false)]
            public float? Score { get; set; }
            [NameInMap("FrameUrl")]
            [Validation(Required=false)]
            public string FrameUrl { get; set; }
            [NameInMap("Passed")]
            [Validation(Required=false)]
            public string Passed { get; set; }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
