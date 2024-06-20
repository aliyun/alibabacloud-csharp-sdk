// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateWmExtractTaskResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateWmExtractTaskResponseBodyData Data { get; set; }
        public class CreateWmExtractTaskResponseBodyData : TeaModel {
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
