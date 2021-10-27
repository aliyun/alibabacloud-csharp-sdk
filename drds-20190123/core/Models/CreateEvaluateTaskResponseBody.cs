// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class CreateEvaluateTaskResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateEvaluateTaskResponseBodyData Data { get; set; }
        public class CreateEvaluateTaskResponseBodyData : TeaModel {
            [NameInMap("TaskIds")]
            [Validation(Required=false)]
            public List<string> TaskIds { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
