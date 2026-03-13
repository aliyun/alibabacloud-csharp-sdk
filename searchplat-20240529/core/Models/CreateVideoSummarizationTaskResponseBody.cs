// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240529.Models
{
    public class CreateVideoSummarizationTaskResponseBody : TeaModel {
        [NameInMap("latency")]
        [Validation(Required=false)]
        public int? Latency { get; set; }

        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateVideoSummarizationTaskResponseBodyResult Result { get; set; }
        public class CreateVideoSummarizationTaskResponseBodyResult : TeaModel {
            [NameInMap("task_id")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

    }

}
