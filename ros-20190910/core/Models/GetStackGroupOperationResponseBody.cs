// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetStackGroupOperationResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the stack group operation.
        /// </summary>
        [NameInMap("StackGroupOperation")]
        [Validation(Required=false)]
        public GetStackGroupOperationResponseBodyStackGroupOperation StackGroupOperation { get; set; }
        public class GetStackGroupOperationResponseBodyStackGroupOperation : TeaModel {
            /// <summary>
            /// The operation type.
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
            /// The name of the RAM role that you specify for the administrator account when you create the self-managed stack group. ROS assumes the administrator role to perform operations. If this parameter is not specified, the default value AliyunROSStackGroupAdministrationRole is returned.
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
            /// The destinations to deploy stack instances when the stack is granted service-managed permissions.
            /// </summary>
            [NameInMap("DeploymentTargets")]
            [Validation(Required=false)]
            public GetStackGroupOperationResponseBodyStackGroupOperationDeploymentTargets DeploymentTargets { get; set; }
            public class GetStackGroupOperationResponseBodyStackGroupOperationDeploymentTargets : TeaModel {
                /// <summary>
                /// The IDs of the members in the resource directory.
                /// 
                /// > This parameter is returned only if AccountIds is specified when the [UpdateStackInstances](https://help.aliyun.com/document_detail/151716.html) operation is called to update stack instances.
                /// </summary>
                [NameInMap("AccountIds")]
                [Validation(Required=false)]
                public List<string> AccountIds { get; set; }

                /// <summary>
                /// The IDs of the folders in the resource directory.
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
            /// The name of the RAM role that you specify for the execution account when you create the self-managed stack group. The administrator role AliyunROSStackGroupAdministrationRole assumes the execution role to perform operations. If this parameter is not specified, the default value AliyunROSStackGroupExecutionRole is returned.
            /// </summary>
            [NameInMap("ExecutionRoleName")]
            [Validation(Required=false)]
            public string ExecutionRoleName { get; set; }

            /// <summary>
            /// The description of the operation.
            /// 
            /// > This parameter is returned only if OperationDescription is specified when the [CreateStackInstances](https://help.aliyun.com/document_detail/151338.html) operation is called to create stack instances.
            /// </summary>
            [NameInMap("OperationDescription")]
            [Validation(Required=false)]
            public string OperationDescription { get; set; }

            /// <summary>
            /// The operation ID.
            /// </summary>
            [NameInMap("OperationId")]
            [Validation(Required=false)]
            public string OperationId { get; set; }

            /// <summary>
            /// The operation settings.
            /// </summary>
            [NameInMap("OperationPreferences")]
            [Validation(Required=false)]
            public GetStackGroupOperationResponseBodyStackGroupOperationOperationPreferences OperationPreferences { get; set; }
            public class GetStackGroupOperationResponseBodyStackGroupOperationOperationPreferences : TeaModel {
                /// <summary>
                /// The number of accounts within which stack operation failures are allowed to occur in each region. If the value of this parameter is exceeded in a region, Resource Orchestration Service (ROS) stops the operation in the region. If the operation is stopped in one region, the operation is no longer performed in other regions.
                /// 
                /// Valid values: 0 to 20.
                /// 
                /// > Only one of FailureToleranceCount and FailureTolerancePercentage can be returned.
                /// </summary>
                [NameInMap("FailureToleranceCount")]
                [Validation(Required=false)]
                public int? FailureToleranceCount { get; set; }

                /// <summary>
                /// The percentage of the number of accounts within which stack operation failures are allowed to occur to the total number of accounts in each region. If the value of this parameter is exceeded in a region, ROS stops the operation in the region.
                /// 
                /// Valid values: 0 to 100.
                /// 
                /// > Only one of FailureToleranceCount and FailureTolerancePercentage can be returned.
                /// </summary>
                [NameInMap("FailureTolerancePercentage")]
                [Validation(Required=false)]
                public int? FailureTolerancePercentage { get; set; }

                /// <summary>
                /// The maximum number of accounts within which stacks are deployed at the same time in each region.
                /// 
                /// Valid values: 1 to 20.
                /// 
                /// > Only one of MaxConcurrentCount and MaxConcurrentPercentage can be returned.
                /// </summary>
                [NameInMap("MaxConcurrentCount")]
                [Validation(Required=false)]
                public int? MaxConcurrentCount { get; set; }

                /// <summary>
                /// The percentage of the maximum number of accounts within which stacks are deployed at the same time to the total number of accounts in each region.
                /// 
                /// Valid values: 1 to 100.
                /// 
                /// > Only one of MaxConcurrentCount and MaxConcurrentPercentage can be returned.
                /// </summary>
                [NameInMap("MaxConcurrentPercentage")]
                [Validation(Required=false)]
                public int? MaxConcurrentPercentage { get; set; }

                /// <summary>
                /// The regions in the order of operation execution.
                /// </summary>
                [NameInMap("RegionIdsOrder")]
                [Validation(Required=false)]
                public List<string> RegionIdsOrder { get; set; }

            }

            /// <summary>
            /// Indicates whether stacks are retained when the associated stack instances are deleted. When you delete a stack instance, you can choose to delete or retain the stack with which the stack instance is associated.
            /// 
            /// Valid values:
            /// 
            /// *   true: Stacks are retained when the associated stack instances are deleted.
            /// *   false: Stacks are deleted when the associated stack instances are deleted. Proceed with caution.
            /// 
            /// > This parameter is returned only if you delete stack instances.
            /// </summary>
            [NameInMap("RetainStacks")]
            [Validation(Required=false)]
            public bool? RetainStacks { get; set; }

            /// <summary>
            /// The information about drift detection.
            /// 
            /// > This parameter is returned only if drift detection is performed.
            /// </summary>
            [NameInMap("StackGroupDriftDetectionDetail")]
            [Validation(Required=false)]
            public GetStackGroupOperationResponseBodyStackGroupOperationStackGroupDriftDetectionDetail StackGroupDriftDetectionDetail { get; set; }
            public class GetStackGroupOperationResponseBodyStackGroupOperationStackGroupDriftDetectionDetail : TeaModel {
                /// <summary>
                /// The number of stack instances for which drift detection was canceled.
                /// </summary>
                [NameInMap("CancelledStackInstancesCount")]
                [Validation(Required=false)]
                public int? CancelledStackInstancesCount { get; set; }

                /// <summary>
                /// The drift detection state.
                /// 
                /// Valid values:
                /// 
                /// *   COMPLETED: Drift detection is performed on the stack group and all stack instances passed the drift detection.
                /// *   FAILED: Drift detection is performed on the stack group. The number of stack instances that failed the drift detection exceeds the specified threshold.
                /// *   PARTIAL_SUCCESS: Drift detection is performed on the stack group. The number of stack instances that failed the drift detection does not exceed the specified threshold.
                /// *   IN_PROGRESS: Drift detection is being performed on the stack group.
                /// *   STOPPED: Drift detection is canceled for the stack group.
                /// </summary>
                [NameInMap("DriftDetectionStatus")]
                [Validation(Required=false)]
                public string DriftDetectionStatus { get; set; }

                /// <summary>
                /// The time when drift detection was performed.
                /// </summary>
                [NameInMap("DriftDetectionTime")]
                [Validation(Required=false)]
                public string DriftDetectionTime { get; set; }

                /// <summary>
                /// The number of stack instances that have drifted.
                /// </summary>
                [NameInMap("DriftedStackInstancesCount")]
                [Validation(Required=false)]
                public int? DriftedStackInstancesCount { get; set; }

                /// <summary>
                /// The number of stack instances that failed drift detection.
                /// </summary>
                [NameInMap("FailedStackInstancesCount")]
                [Validation(Required=false)]
                public int? FailedStackInstancesCount { get; set; }

                /// <summary>
                /// The number of stack instances on which drift detection was being performed.
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
                /// The drift state of the stack group.
                /// 
                /// Valid values:
                /// 
                /// *   DRIFTED: At least one stack instance in the stack group has drifted.
                /// *   NOT_CHECKED: No successful drift detection is performed in the stack group.
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
            /// The state of the operation.
            /// 
            /// Valid values:
            /// 
            /// *   RUNNING
            /// *   SUCCEEDED
            /// *   FAILED
            /// *   STOPPING
            /// *   STOPPED
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
