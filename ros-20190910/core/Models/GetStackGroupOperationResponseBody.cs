// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetStackGroupOperationResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The details of the operation on the stack group.
        /// </summary>
        [NameInMap("StackGroupOperation")]
        [Validation(Required=false)]
        public GetStackGroupOperationResponseBodyStackGroupOperation StackGroupOperation { get; set; }
        public class GetStackGroupOperationResponseBodyStackGroupOperation : TeaModel {
            /// <summary>
            /// The operation that was performed.
            /// 
            /// Valid values:
            /// 
            /// *   CREATE
            /// *   UPDATE
            /// *   DELETE
            /// *   DETECT_DRIFT
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// The name of the RAM role that is specified for the administrator account in Resource Orchestration Service (ROS) when you create the stack group that is granted self-managed permissions. If this parameter is not specified, the default value AliyunROSStackGroupAdministrationRole is returned.
            /// </summary>
            [NameInMap("AdministrationRoleName")]
            [Validation(Required=false)]
            public string AdministrationRoleName { get; set; }

            /// <summary>
            /// The time when the operation was initiated.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The folders in which you want to deploy the stack instances that are granted service-managed permissions.
            /// </summary>
            [NameInMap("DeploymentTargets")]
            [Validation(Required=false)]
            public GetStackGroupOperationResponseBodyStackGroupOperationDeploymentTargets DeploymentTargets { get; set; }
            public class GetStackGroupOperationResponseBodyStackGroupOperationDeploymentTargets : TeaModel {
                /// <summary>
                /// The IDs of the member accounts in the resource directory.
                /// 
                /// >  This parameter is returned only if the AccountIds request parameter is specified in the [UpdateStackInstances](~~151716~~) operation to update stack instances.
                /// </summary>
                [NameInMap("AccountIds")]
                [Validation(Required=false)]
                public List<string> AccountIds { get; set; }

                /// <summary>
                /// The folder IDs of the resource directory.
                /// </summary>
                [NameInMap("RdFolderIds")]
                [Validation(Required=false)]
                public List<string> RdFolderIds { get; set; }

            }

            /// <summary>
            /// The time when the operation ended.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// The name of the RAM role that is specified for the execution account when you create the stack group that is granted self-managed permissions. The administrator account whose RAM role is AliyunROSStackGroupAdministrationRole assumes this RAM role. If this parameter is not specified, the default value AliyunROSStackGroupExecutionRole is returned.
            /// </summary>
            [NameInMap("ExecutionRoleName")]
            [Validation(Required=false)]
            public string ExecutionRoleName { get; set; }

            /// <summary>
            /// The description of the operation.
            /// 
            /// >  This parameter is returned only if the OperationDescription request parameter is specified in the [CreateStackInstances](~~151338~~) operation to create stack instances.
            /// </summary>
            [NameInMap("OperationDescription")]
            [Validation(Required=false)]
            public string OperationDescription { get; set; }

            /// <summary>
            /// The ID of the operation that was performed on the stack group.
            /// </summary>
            [NameInMap("OperationId")]
            [Validation(Required=false)]
            public string OperationId { get; set; }

            /// <summary>
            /// The operation preferences.
            /// </summary>
            [NameInMap("OperationPreferences")]
            [Validation(Required=false)]
            public GetStackGroupOperationResponseBodyStackGroupOperationOperationPreferences OperationPreferences { get; set; }
            public class GetStackGroupOperationResponseBodyStackGroupOperationOperationPreferences : TeaModel {
                /// <summary>
                /// The maximum number of stack operation failures that can occur within the accounts in each region. When the value is exceeded, the operation fails to be performed in the region. If the operation fails to be performed in one region, the operation fails to be performed in other regions.
                /// 
                /// Valid values: 0 to 20.
                /// 
                /// >  Only one of the FailureToleranceCount and FailureTolerancePercentage parameters is returned.
                /// </summary>
                [NameInMap("FailureToleranceCount")]
                [Validation(Required=false)]
                public int? FailureToleranceCount { get; set; }

                /// <summary>
                /// The percentage of the total number of accounts within which stack operation failures can occur to the total number of accounts in each region. When the value is exceeded, the operation fails to be performed in the region.
                /// 
                /// Valid values: 0 to 100.
                /// 
                /// >  Only one of the FailureToleranceCount and FailureTolerancePercentage parameters is returned.
                /// </summary>
                [NameInMap("FailureTolerancePercentage")]
                [Validation(Required=false)]
                public int? FailureTolerancePercentage { get; set; }

                /// <summary>
                /// The maximum number of accounts within which operations are performed on stacks concurrently in each region.
                /// 
                /// Valid values: 1 to 20.
                /// 
                /// >  Only one of the MaxConcurrentCount and MaxConcurrentPercentage parameters is returned.
                /// </summary>
                [NameInMap("MaxConcurrentCount")]
                [Validation(Required=false)]
                public int? MaxConcurrentCount { get; set; }

                /// <summary>
                /// The percentage of the total number of accounts within which operations are performed on stacks concurrently to the total number of accounts in each region.
                /// 
                /// Valid values: 1 to 100.
                /// 
                /// >  Only one of the MaxConcurrentCount and MaxConcurrentPercentage parameters is returned.
                /// </summary>
                [NameInMap("MaxConcurrentPercentage")]
                [Validation(Required=false)]
                public int? MaxConcurrentPercentage { get; set; }

                /// <summary>
                /// The regions in the order of which the operation is performed.
                /// </summary>
                [NameInMap("RegionIdsOrder")]
                [Validation(Required=false)]
                public List<string> RegionIdsOrder { get; set; }

            }

            /// <summary>
            /// Indicates whether the relevant stacks are retained when stack instances are deleted in the stack group.
            /// 
            /// Valid values:
            /// 
            /// *   true: The stacks are retained.
            /// *   false: The stacks are deleted. Proceed with caution.
            /// 
            /// >  This parameter is returned only when the stack instances are deleted.
            /// </summary>
            [NameInMap("RetainStacks")]
            [Validation(Required=false)]
            public bool? RetainStacks { get; set; }

            /// <summary>
            /// The details of the drift detection.
            /// 
            /// >  This parameter is returned only when the drift detection is performed on the stack group.
            /// </summary>
            [NameInMap("StackGroupDriftDetectionDetail")]
            [Validation(Required=false)]
            public GetStackGroupOperationResponseBodyStackGroupOperationStackGroupDriftDetectionDetail StackGroupDriftDetectionDetail { get; set; }
            public class GetStackGroupOperationResponseBodyStackGroupOperationStackGroupDriftDetectionDetail : TeaModel {
                /// <summary>
                /// The number of stack instances for which the drift detection was canceled.
                /// </summary>
                [NameInMap("CancelledStackInstancesCount")]
                [Validation(Required=false)]
                public int? CancelledStackInstancesCount { get; set; }

                /// <summary>
                /// The status of the drift detection.
                /// 
                /// Valid values:
                /// 
                /// *   COMPLETED: The drift detection is performed and completed on all stack instances.
                /// *   FAILED: The drift detection is performed. The number of stack instances that failed the drift detection exceeds the specified threshold.
                /// *   PARTIAL_SUCCESS: The drift detection is performed. The number of stack instances that failed the drift detection does not exceed the specified threshold.
                /// *   IN_PROGRESS: The drift detection is being performed on the stack group.
                /// *   STOPPED: The drift detection is canceled for the stack group.
                /// </summary>
                [NameInMap("DriftDetectionStatus")]
                [Validation(Required=false)]
                public string DriftDetectionStatus { get; set; }

                /// <summary>
                /// The time when the drift detection was initiated.
                /// </summary>
                [NameInMap("DriftDetectionTime")]
                [Validation(Required=false)]
                public string DriftDetectionTime { get; set; }

                /// <summary>
                /// The number of stack instances that were drifted.
                /// </summary>
                [NameInMap("DriftedStackInstancesCount")]
                [Validation(Required=false)]
                public int? DriftedStackInstancesCount { get; set; }

                /// <summary>
                /// The number of stack instances that failed the drift detection.
                /// </summary>
                [NameInMap("FailedStackInstancesCount")]
                [Validation(Required=false)]
                public int? FailedStackInstancesCount { get; set; }

                /// <summary>
                /// The number of stack instances on which the drift detection was being performed.
                /// </summary>
                [NameInMap("InProgressStackInstancesCount")]
                [Validation(Required=false)]
                public int? InProgressStackInstancesCount { get; set; }

                /// <summary>
                /// The number of stack instances that were being synchronized.
                /// </summary>
                [NameInMap("InSyncStackInstancesCount")]
                [Validation(Required=false)]
                public int? InSyncStackInstancesCount { get; set; }

                /// <summary>
                /// The drift status of the stack group.
                /// 
                /// Valid values:
                /// 
                /// *   DRIFTED: At least one stack instance in the stack group is drifted.
                /// *   NOT_CHECKED: No drift detection is completed in the stack group.
                /// *   IN_SYNC: All the stack instances in the stack group are being synchronized.
                /// </summary>
                [NameInMap("StackGroupDriftStatus")]
                [Validation(Required=false)]
                public string StackGroupDriftStatus { get; set; }

                /// <summary>
                /// The number of stack instances.
                /// </summary>
                [NameInMap("TotalStackInstancesCount")]
                [Validation(Required=false)]
                public int? TotalStackInstancesCount { get; set; }

            }

            /// <summary>
            /// The ID of the stack group.
            /// </summary>
            [NameInMap("StackGroupId")]
            [Validation(Required=false)]
            public string StackGroupId { get; set; }

            /// <summary>
            /// The name of the stack group.
            /// </summary>
            [NameInMap("StackGroupName")]
            [Validation(Required=false)]
            public string StackGroupName { get; set; }

            /// <summary>
            /// The status of the operation.
            /// 
            /// Valid values:
            /// 
            /// *   RUNNING: The operation is being performed.
            /// *   SUCCEEDED: The operation succeeded.
            /// *   FAILED: The operation failed.
            /// *   STOPPING: The operation is being stopped.
            /// *   STOPPED: The operation is stopped.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
