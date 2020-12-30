// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Multimediaai20190810.Models
{
    public class GetTaskResultResponseBody : TeaModel {
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetTaskResultResponseBodyResult Result { get; set; }
        public class GetTaskResultResponseBodyResult : TeaModel {
            [NameInMap("ErrorName")]
            [Validation(Required=false)]
            public string ErrorName { get; set; }
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }
            [NameInMap("VideoName")]
            [Validation(Required=false)]
            public string VideoName { get; set; }
            [NameInMap("AnalysisUseTime")]
            [Validation(Required=false)]
            public long? AnalysisUseTime { get; set; }
            [NameInMap("ProcessResultUrl")]
            [Validation(Required=false)]
            public string ProcessResultUrl { get; set; }
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }
            [NameInMap("ErrorReason")]
            [Validation(Required=false)]
            public string ErrorReason { get; set; }
            [NameInMap("VideoUrl")]
            [Validation(Required=false)]
            public string VideoUrl { get; set; }
        };

    }

}
