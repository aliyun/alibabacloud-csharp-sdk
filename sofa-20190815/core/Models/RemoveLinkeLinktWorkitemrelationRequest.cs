// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class RemoveLinkeLinktWorkitemrelationRequest : TeaModel {
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("TargetSign")]
        [Validation(Required=false)]
        public string TargetSign { get; set; }

        [NameInMap("WorkItemRelationType")]
        [Validation(Required=false)]
        public string WorkItemRelationType { get; set; }

    }

}
