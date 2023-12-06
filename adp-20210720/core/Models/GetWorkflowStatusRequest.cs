// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class GetWorkflowStatusRequest : TeaModel {
        [NameInMap("workflowType")]
        [Validation(Required=false)]
        public string WorkflowType { get; set; }

        [NameInMap("xuid")]
        [Validation(Required=false)]
        public string Xuid { get; set; }

    }

}
