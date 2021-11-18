// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class StartBack2BackCallRequest : TeaModel {
        [NameInMap("CallCenterNumber")]
        [Validation(Required=false)]
        public string CallCenterNumber { get; set; }

        [NameInMap("Callee")]
        [Validation(Required=false)]
        public string Callee { get; set; }

        [NameInMap("Caller")]
        [Validation(Required=false)]
        public string Caller { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("WorkflowId")]
        [Validation(Required=false)]
        public string WorkflowId { get; set; }

    }

}
