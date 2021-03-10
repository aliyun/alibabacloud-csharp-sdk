// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetNodesAddingTaskResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=true)]
        public string TaskId { get; set; }

        [NameInMap("TaskState")]
        [Validation(Required=true)]
        public string TaskState { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public long? TotalCount { get; set; }

        [NameInMap("SuccessCount")]
        [Validation(Required=true)]
        public long? SuccessCount { get; set; }

        [NameInMap("SuccessDevEuis")]
        [Validation(Required=true)]
        public GetNodesAddingTaskResponseSuccessDevEuis SuccessDevEuis { get; set; }
        public class GetNodesAddingTaskResponseSuccessDevEuis : TeaModel {
            [NameInMap("SuccessDevEui")]
            [Validation(Required=true)]
            public List<string> SuccessDevEui { get; set; }
        };

    }

}
