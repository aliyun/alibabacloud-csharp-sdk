// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Viapi20210930.Models
{
    public class QueryAiStoreUserTaskPageResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryAiStoreUserTaskPageResponseBodyData Data { get; set; }
        public class QueryAiStoreUserTaskPageResponseBodyData : TeaModel {
            [NameInMap("TaskList")]
            [Validation(Required=false)]
            public List<string> TaskList { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

    }

}
