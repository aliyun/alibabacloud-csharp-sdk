// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class CreateProjectBuildRequest : TeaModel {
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("projectBuildAction")]
        [Validation(Required=false)]
        public string ProjectBuildAction { get; set; }

        [NameInMap("taskIds")]
        [Validation(Required=false)]
        public List<string> TaskIds { get; set; }

        [NameInMap("taskPolicies")]
        [Validation(Required=false)]
        public List<CreateProjectBuildRequestTaskPolicies> TaskPolicies { get; set; }
        public class CreateProjectBuildRequestTaskPolicies : TeaModel {
            [NameInMap("destroyAfterExecution")]
            [Validation(Required=false)]
            public bool? DestroyAfterExecution { get; set; }

            [NameInMap("priority")]
            [Validation(Required=false)]
            public long? Priority { get; set; }

            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

    }

}
