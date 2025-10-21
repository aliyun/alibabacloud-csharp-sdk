// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class NodeExecutionStatusDTO : TeaModel {
        [NameInMap("executionId")]
        [Validation(Required=false)]
        public string ExecutionId { get; set; }

        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("resourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
