// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yuqing20220301.Models
{
    public class SubmitAnalysisTaskResponseBody : TeaModel {
        [NameInMap("analysisId")]
        [Validation(Required=false)]
        public long? AnalysisId { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultJson")]
        [Validation(Required=false)]
        public string ResultJson { get; set; }

    }

}
