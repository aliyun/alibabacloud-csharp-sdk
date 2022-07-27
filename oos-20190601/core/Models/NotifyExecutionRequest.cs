// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class NotifyExecutionRequest : TeaModel {
        [NameInMap("ExecutionId")]
        [Validation(Required=false)]
        public string ExecutionId { get; set; }

        [NameInMap("ExecutionStatus")]
        [Validation(Required=false)]
        public string ExecutionStatus { get; set; }

        [NameInMap("LoopItem")]
        [Validation(Required=false)]
        public string LoopItem { get; set; }

        [NameInMap("NotifyNote")]
        [Validation(Required=false)]
        public string NotifyNote { get; set; }

        [NameInMap("NotifyType")]
        [Validation(Required=false)]
        public string NotifyType { get; set; }

        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("TaskExecutionId")]
        [Validation(Required=false)]
        public string TaskExecutionId { get; set; }

        [NameInMap("TaskExecutionIds")]
        [Validation(Required=false)]
        public string TaskExecutionIds { get; set; }

        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
