// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class Operation : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("OperationId")]
        [Validation(Required=false)]
        public string OperationId { get; set; }

        [NameInMap("OperationState")]
        [Validation(Required=false)]
        public string OperationState { get; set; }

        [NameInMap("OperationType")]
        [Validation(Required=false)]
        public string OperationType { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("StateChangeReason")]
        [Validation(Required=false)]
        public OperationStateChangeReason StateChangeReason { get; set; }

    }

}
