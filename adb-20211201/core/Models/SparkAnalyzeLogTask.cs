// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class SparkAnalyzeLogTask : TeaModel {
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public LogAnalyzeResult Result { get; set; }

        [NameInMap("RuleMatched")]
        [Validation(Required=false)]
        public bool? RuleMatched { get; set; }

        [NameInMap("StartedTimeInMillis")]
        [Validation(Required=false)]
        public long? StartedTimeInMillis { get; set; }

        [NameInMap("SubmittedTimeInMillis")]
        [Validation(Required=false)]
        public long? SubmittedTimeInMillis { get; set; }

        [NameInMap("TaskErrMsg")]
        [Validation(Required=false)]
        public string TaskErrMsg { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

        [NameInMap("TaskState")]
        [Validation(Required=false)]
        public string TaskState { get; set; }

        [NameInMap("TerminatedTimeInMillis")]
        [Validation(Required=false)]
        public long? TerminatedTimeInMillis { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

    }

}
