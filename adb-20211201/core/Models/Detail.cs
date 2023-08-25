// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class Detail : TeaModel {
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        [NameInMap("DurationInMillis")]
        [Validation(Required=false)]
        public long? DurationInMillis { get; set; }

        [NameInMap("EstimateExecutionCpuTimeInSeconds")]
        [Validation(Required=false)]
        public long? EstimateExecutionCpuTimeInSeconds { get; set; }

        [NameInMap("LastAttemptId")]
        [Validation(Required=false)]
        public string LastAttemptId { get; set; }

        [NameInMap("LastUpdatedTimeInMillis")]
        [Validation(Required=false)]
        public long? LastUpdatedTimeInMillis { get; set; }

        [NameInMap("LogRootPath")]
        [Validation(Required=false)]
        public string LogRootPath { get; set; }

        [NameInMap("ResourceGroupName")]
        [Validation(Required=false)]
        public string ResourceGroupName { get; set; }

        [NameInMap("StartedTimeInMillis")]
        [Validation(Required=false)]
        public long? StartedTimeInMillis { get; set; }

        [NameInMap("SubmittedTimeInMillis")]
        [Validation(Required=false)]
        public long? SubmittedTimeInMillis { get; set; }

        [NameInMap("TerminatedTimeInMillis")]
        [Validation(Required=false)]
        public long? TerminatedTimeInMillis { get; set; }

        [NameInMap("WebUiAddress")]
        [Validation(Required=false)]
        public string WebUiAddress { get; set; }

    }

}
