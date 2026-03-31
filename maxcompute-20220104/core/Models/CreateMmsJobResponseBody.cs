// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class CreateMmsJobResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateMmsJobResponseBodyData Data { get; set; }
        public class CreateMmsJobResponseBodyData : TeaModel {
            [NameInMap("asyncTaskId")]
            [Validation(Required=false)]
            public long? AsyncTaskId { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
