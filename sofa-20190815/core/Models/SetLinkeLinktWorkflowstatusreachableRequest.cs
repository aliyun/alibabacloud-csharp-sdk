// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class SetLinkeLinktWorkflowstatusreachableRequest : TeaModel {
        [NameInMap("FromStatusId")]
        [Validation(Required=false)]
        public string FromStatusId { get; set; }

        [NameInMap("Reachable")]
        [Validation(Required=false)]
        public string Reachable { get; set; }

        [NameInMap("ToStatusId")]
        [Validation(Required=false)]
        public string ToStatusId { get; set; }

        [NameInMap("WorkflowId")]
        [Validation(Required=false)]
        public string WorkflowId { get; set; }

    }

}
