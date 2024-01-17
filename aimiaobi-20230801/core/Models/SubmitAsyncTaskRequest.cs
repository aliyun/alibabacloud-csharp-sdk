// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class SubmitAsyncTaskRequest : TeaModel {
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        [NameInMap("TaskCode")]
        [Validation(Required=false)]
        public string TaskCode { get; set; }

        [NameInMap("TaskExecuteTime")]
        [Validation(Required=false)]
        public string TaskExecuteTime { get; set; }

        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        [NameInMap("TaskParam")]
        [Validation(Required=false)]
        public string TaskParam { get; set; }

    }

}
