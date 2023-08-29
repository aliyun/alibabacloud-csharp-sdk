// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class WorkflowInstance : TeaModel {
        [NameInMap("BatchProgress")]
        [Validation(Required=false)]
        public int? BatchProgress { get; set; }

        [NameInMap("DlfWorkflowId")]
        [Validation(Required=false)]
        public string DlfWorkflowId { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("ExternalInstanceId")]
        [Validation(Required=false)]
        public string ExternalInstanceId { get; set; }

        [NameInMap("RuntimeLogs")]
        [Validation(Required=false)]
        public List<LogInfo> RuntimeLogs { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
