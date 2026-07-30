// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20260101.Models
{
    public class CheckTuringTaskResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public CheckTuringTaskResponseBodyResult Result { get; set; }
        public class CheckTuringTaskResponseBodyResult : TeaModel {
            [NameInMap("failBizCode")]
            [Validation(Required=false)]
            public string FailBizCode { get; set; }

            [NameInMap("failCode")]
            [Validation(Required=false)]
            public string FailCode { get; set; }

            [NameInMap("failMsg")]
            [Validation(Required=false)]
            public string FailMsg { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("videoUrl")]
            [Validation(Required=false)]
            public string VideoUrl { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
