// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class DeleteAccessAssignmentResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Task")]
        [Validation(Required=false)]
        public DeleteAccessAssignmentResponseBodyTask Task { get; set; }
        public class DeleteAccessAssignmentResponseBodyTask : TeaModel {
            [NameInMap("AccessConfigurationId")]
            [Validation(Required=false)]
            public string AccessConfigurationId { get; set; }
            [NameInMap("AccessConfigurationName")]
            [Validation(Required=false)]
            public string AccessConfigurationName { get; set; }
            [NameInMap("PrincipalId")]
            [Validation(Required=false)]
            public string PrincipalId { get; set; }
            [NameInMap("PrincipalName")]
            [Validation(Required=false)]
            public string PrincipalName { get; set; }
            [NameInMap("PrincipalType")]
            [Validation(Required=false)]
            public string PrincipalType { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }
            [NameInMap("TargetName")]
            [Validation(Required=false)]
            public string TargetName { get; set; }
            [NameInMap("TargetPath")]
            [Validation(Required=false)]
            public string TargetPath { get; set; }
            [NameInMap("TargetPathName")]
            [Validation(Required=false)]
            public string TargetPathName { get; set; }
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }
        };

    }

}
