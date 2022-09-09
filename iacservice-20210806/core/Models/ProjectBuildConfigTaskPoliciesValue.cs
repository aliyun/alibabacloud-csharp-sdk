// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ProjectBuildConfigTaskPoliciesValue : TeaModel {
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("priority")]
        [Validation(Required=false)]
        public long? Priority { get; set; }

        [NameInMap("destroyAfterExecution")]
        [Validation(Required=false)]
        public bool? DestroyAfterExecution { get; set; }

    }

}
