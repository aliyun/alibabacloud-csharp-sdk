// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class TaskStatus : TeaModel {
        [NameInMap("executionDetails")]
        [Validation(Required=false)]
        public List<string> ExecutionDetails { get; set; }

        [NameInMap("invocations")]
        [Validation(Required=false)]
        public List<TaskInvocation> Invocations { get; set; }

        [NameInMap("latestExecError")]
        [Validation(Required=false)]
        public TaskExecError LatestExecError { get; set; }

        [NameInMap("phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        [NameInMap("statusGeneration")]
        [Validation(Required=false)]
        public long? StatusGeneration { get; set; }

    }

}
