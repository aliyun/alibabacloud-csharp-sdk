// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetStackGroupOperationResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StackGroupOperation")]
        [Validation(Required=false)]
        public GetStackGroupOperationResponseBodyStackGroupOperation StackGroupOperation { get; set; }
        public class GetStackGroupOperationResponseBodyStackGroupOperation : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("StackGroupId")]
            [Validation(Required=false)]
            public string StackGroupId { get; set; }
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
            [NameInMap("RetainStacks")]
            [Validation(Required=false)]
            public bool? RetainStacks { get; set; }
            [NameInMap("StackGroupName")]
            [Validation(Required=false)]
            public string StackGroupName { get; set; }
            [NameInMap("OperationId")]
            [Validation(Required=false)]
            public string OperationId { get; set; }
            [NameInMap("OperationDescription")]
            [Validation(Required=false)]
            public string OperationDescription { get; set; }
            [NameInMap("StackGroupDriftDetectionDetail")]
            [Validation(Required=false)]
            public GetStackGroupOperationResponseBodyStackGroupOperationStackGroupDriftDetectionDetail StackGroupDriftDetectionDetail { get; set; }
            public class GetStackGroupOperationResponseBodyStackGroupOperationStackGroupDriftDetectionDetail : TeaModel {
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
            [NameInMap("OperationPreferences")]
            [Validation(Required=false)]
            public GetStackGroupOperationResponseBodyStackGroupOperationOperationPreferences OperationPreferences { get; set; }
            public class GetStackGroupOperationResponseBodyStackGroupOperationOperationPreferences : TeaModel {
                [NameInMap("MaxConcurrentCount")]
                [Validation(Required=false)]
                public int? MaxConcurrentCount { get; set; }

                [NameInMap("FailureToleranceCount")]
                [Validation(Required=false)]
                public int? FailureToleranceCount { get; set; }

                [NameInMap("MaxConcurrentPercentage")]
                [Validation(Required=false)]
                public int? MaxConcurrentPercentage { get; set; }

                [NameInMap("RegionIdsOrder")]
                [Validation(Required=false)]
                public List<string> RegionIdsOrder { get; set; }

                [NameInMap("FailureTolerancePercentage")]
                [Validation(Required=false)]
                public int? FailureTolerancePercentage { get; set; }

            }
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }
            [NameInMap("ExecutionRoleName")]
            [Validation(Required=false)]
            public string ExecutionRoleName { get; set; }
            [NameInMap("AdministratorRoleName")]
            [Validation(Required=false)]
            public string AdministratorRoleName { get; set; }
            [NameInMap("DeploymentTargets")]
            [Validation(Required=false)]
            public GetStackGroupOperationResponseBodyStackGroupOperationDeploymentTargets DeploymentTargets { get; set; }
            public class GetStackGroupOperationResponseBodyStackGroupOperationDeploymentTargets : TeaModel {
                [NameInMap("RdFolderIds")]
                [Validation(Required=false)]
                public List<string> RdFolderIds { get; set; }

                [NameInMap("AccountIds")]
                [Validation(Required=false)]
                public List<string> AccountIds { get; set; }

            }
        };

    }

}
