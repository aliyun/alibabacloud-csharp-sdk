// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20201112.Models
{
    public class LivenessDetectResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("ResultObject")]
        [Validation(Required=true)]
        public LivenessDetectResponseResultObject ResultObject { get; set; }
        public class LivenessDetectResponseResultObject : TeaModel {
            [NameInMap("Passed")]
            [Validation(Required=true)]
            public string Passed { get; set; }
            [NameInMap("Score")]
            [Validation(Required=true)]
            public float? Score { get; set; }
            [NameInMap("FrameUrl")]
            [Validation(Required=true)]
            public string FrameUrl { get; set; }
        };

    }

}
