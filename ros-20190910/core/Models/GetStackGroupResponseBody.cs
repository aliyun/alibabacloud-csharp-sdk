// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetStackGroupResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StackGroup")]
        [Validation(Required=false)]
        public GetStackGroupResponseBodyStackGroup StackGroup { get; set; }
        public class GetStackGroupResponseBodyStackGroup : TeaModel {
            [NameInMap("StackGroupId")]
            [Validation(Required=false)]
            public string StackGroupId { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("AdministrationRoleName")]
            [Validation(Required=false)]
            public string AdministrationRoleName { get; set; }
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public List<GetStackGroupResponseBodyStackGroupParameters> Parameters { get; set; }
            public class GetStackGroupResponseBodyStackGroupParameters : TeaModel {
                public string ParameterKey { get; set; }
                public string ParameterValue { get; set; }
            }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("StackGroupName")]
            [Validation(Required=false)]
            public string StackGroupName { get; set; }
            [NameInMap("ExecutionRoleName")]
            [Validation(Required=false)]
            public string ExecutionRoleName { get; set; }
            [NameInMap("TemplateBody")]
            [Validation(Required=false)]
            public string TemplateBody { get; set; }
            [NameInMap("StackGroupDriftDetectionDetail")]
            [Validation(Required=false)]
            public GetStackGroupResponseBodyStackGroupStackGroupDriftDetectionDetail StackGroupDriftDetectionDetail { get; set; }
            public class GetStackGroupResponseBodyStackGroupStackGroupDriftDetectionDetail : TeaModel {
                [NameInMap("DriftDetectionTime")]
                [Validation(Required=false)]
                public string DriftDetectionTime { get; set; }

                [NameInMap("TotalStackInstancesCount")]
                [Validation(Required=false)]
                public int? TotalStackInstancesCount { get; set; }

                [NameInMap("FailedStackInstancesCount")]
                [Validation(Required=false)]
                public int? FailedStackInstancesCount { get; set; }

                [NameInMap("DriftDetectionStatus")]
                [Validation(Required=false)]
                public string DriftDetectionStatus { get; set; }

                [NameInMap("StackGroupDriftStatus")]
                [Validation(Required=false)]
                public string StackGroupDriftStatus { get; set; }

                [NameInMap("InProgressStackInstancesCount")]
                [Validation(Required=false)]
                public int? InProgressStackInstancesCount { get; set; }

                [NameInMap("InSyncStackInstancesCount")]
                [Validation(Required=false)]
                public int? InSyncStackInstancesCount { get; set; }

                [NameInMap("CancelledStackInstancesCount")]
                [Validation(Required=false)]
                public int? CancelledStackInstancesCount { get; set; }

                [NameInMap("DriftedStackInstancesCount")]
                [Validation(Required=false)]
                public int? DriftedStackInstancesCount { get; set; }

            }
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }
            [NameInMap("PermissionModel")]
            [Validation(Required=false)]
            public string PermissionModel { get; set; }
            [NameInMap("AutoDeployment")]
            [Validation(Required=false)]
            public GetStackGroupResponseBodyStackGroupAutoDeployment AutoDeployment { get; set; }
            public class GetStackGroupResponseBodyStackGroupAutoDeployment : TeaModel {
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                [NameInMap("RetainStacksOnAccountRemoval")]
                [Validation(Required=false)]
                public bool? RetainStacksOnAccountRemoval { get; set; }

            }
            [NameInMap("RdFolderIds")]
            [Validation(Required=false)]
            public List<string> RdFolderIds { get; set; }
        };

    }

}
