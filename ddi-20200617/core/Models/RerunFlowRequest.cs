// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddi20200617.Models
{
    public class RerunFlowRequest : TeaModel {
        [NameInMap("FlowInstanceId")]
        [Validation(Required=false)]
        public string FlowInstanceId { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("ReRunFail")]
        [Validation(Required=false)]
        public bool? ReRunFail { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
