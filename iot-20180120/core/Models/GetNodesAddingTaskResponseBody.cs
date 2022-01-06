// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetNodesAddingTaskResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("SuccessCount")]
        [Validation(Required=false)]
        public long? SuccessCount { get; set; }

        [NameInMap("SuccessDevEuis")]
        [Validation(Required=false)]
        public GetNodesAddingTaskResponseBodySuccessDevEuis SuccessDevEuis { get; set; }
        public class GetNodesAddingTaskResponseBodySuccessDevEuis : TeaModel {
            [NameInMap("SuccessDevEui")]
            [Validation(Required=false)]
            public List<string> SuccessDevEui { get; set; }
        };

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("TaskState")]
        [Validation(Required=false)]
        public string TaskState { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
