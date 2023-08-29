// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class LifecycleTask : TeaModel {
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("LifecycleRule")]
        [Validation(Required=false)]
        public LifecycleRule LifecycleRule { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("WorkflowInstance")]
        [Validation(Required=false)]
        public WorkflowInstance WorkflowInstance { get; set; }

    }

}
