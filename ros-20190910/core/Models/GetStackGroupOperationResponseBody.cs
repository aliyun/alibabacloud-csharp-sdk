// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetStackGroupOperationResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14A07460-EBE7-47CA-9757-12CC4761D47A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the stack group operation.</para>
        /// </summary>
        [NameInMap("StackGroupOperation")]
        [Validation(Required=false)]
        public GetStackGroupOperationResponseBodyStackGroupOperation StackGroupOperation { get; set; }
        public class GetStackGroupOperationResponseBodyStackGroupOperation : TeaModel {
            /// <summary>
            /// <para>The operation type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CREATE</description></item>
            /// <item><description>UPDATE</description></item>
            /// <item><description>DELETE</description></item>
            /// <item><description>DETECT_DRIFT</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DELETE</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>The name of the RAM role that you specify for the administrator account when you create the self-managed stack group. ROS assumes the administrator role to perform operations. If this parameter is not specified, the default value AliyunROSStackGroupAdministrationRole is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AliyunROSStackGroupAdministrationRole</para>
            /// </summary>
            [NameInMap("AdministrationRoleName")]
            [Validation(Required=false)]
            public string AdministrationRoleName { get; set; }

            /// <summary>
            /// <para>The time when the operation was initiated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-01-20T09:22:3</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The destinations to deploy stack instances when the stack is granted service-managed permissions.</para>
            /// </summary>
            [NameInMap("DeploymentTargets")]
            [Validation(Required=false)]
            public GetStackGroupOperationResponseBodyStackGroupOperationDeploymentTargets DeploymentTargets { get; set; }
            public class GetStackGroupOperationResponseBodyStackGroupOperationDeploymentTargets : TeaModel {
                /// <summary>
                /// <para>The IDs of the members in the resource directory.</para>
                /// <remarks>
                /// <para>This parameter is returned only if AccountIds is specified when the <a href="https://help.aliyun.com/document_detail/151716.html">UpdateStackInstances</a> operation is called to update stack instances.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("AccountIds")]
                [Validation(Required=false)]
                public List<string> AccountIds { get; set; }

                /// <summary>
                /// <para>The IDs of the folders in the resource directory.</para>
                /// </summary>
                [NameInMap("RdFolderIds")]
                [Validation(Required=false)]
                public List<string> RdFolderIds { get; set; }

            }

            /// <summary>
            /// <para>The time when the operation ended.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-01-20T09:22:4</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The name of the RAM role that you specify for the execution account when you create the self-managed stack group. The administrator role AliyunROSStackGroupAdministrationRole assumes the execution role to perform operations. If this parameter is not specified, the default value AliyunROSStackGroupExecutionRole is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AliyunROSStackGroupExecutionRole</para>
            /// </summary>
            [NameInMap("ExecutionRoleName")]
            [Validation(Required=false)]
            public string ExecutionRoleName { get; set; }

            /// <summary>
            /// <para>The description of the operation.</para>
            /// <remarks>
            /// <para>This parameter is returned only if OperationDescription is specified when the <a href="https://help.aliyun.com/document_detail/151338.html">CreateStackInstances</a> operation is called to create stack instances.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Create stack instance in hangzhou</para>
            /// </summary>
            [NameInMap("OperationDescription")]
            [Validation(Required=false)]
            public string OperationDescription { get; set; }

            /// <summary>
            /// <para>The operation ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6da106ca-1784-4a6f-a7e1-e723863d****</para>
            /// </summary>
            [NameInMap("OperationId")]
            [Validation(Required=false)]
            public string OperationId { get; set; }

            /// <summary>
            /// <para>The operation settings.</para>
            /// </summary>
            [NameInMap("OperationPreferences")]
            [Validation(Required=false)]
            public GetStackGroupOperationResponseBodyStackGroupOperationOperationPreferences OperationPreferences { get; set; }
            public class GetStackGroupOperationResponseBodyStackGroupOperationOperationPreferences : TeaModel {
                /// <summary>
                /// <para>The number of accounts within which stack operation failures are allowed to occur in each region. If the value of this parameter is exceeded in a region, Resource Orchestration Service (ROS) stops the operation in the region. If the operation is stopped in one region, the operation is no longer performed in other regions.</para>
                /// <para>Valid values: 0 to 20.</para>
                /// <remarks>
                /// <para>Only one of FailureToleranceCount and FailureTolerancePercentage can be returned.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("FailureToleranceCount")]
                [Validation(Required=false)]
                public int? FailureToleranceCount { get; set; }

                /// <summary>
                /// <para>The percentage of the number of accounts within which stack operation failures are allowed to occur to the total number of accounts in each region. If the value of this parameter is exceeded in a region, ROS stops the operation in the region.</para>
                /// <para>Valid values: 0 to 100.</para>
                /// <remarks>
                /// <para>Only one of FailureToleranceCount and FailureTolerancePercentage can be returned.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("FailureTolerancePercentage")]
                [Validation(Required=false)]
                public int? FailureTolerancePercentage { get; set; }

                /// <summary>
                /// <para>The maximum number of accounts within which stacks are deployed at the same time in each region.</para>
                /// <para>Valid values: 1 to 20.</para>
                /// <remarks>
                /// <para>Only one of MaxConcurrentCount and MaxConcurrentPercentage can be returned.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MaxConcurrentCount")]
                [Validation(Required=false)]
                public int? MaxConcurrentCount { get; set; }

                /// <summary>
                /// <para>The percentage of the maximum number of accounts within which stacks are deployed at the same time to the total number of accounts in each region.</para>
                /// <para>Valid values: 1 to 100.</para>
                /// <remarks>
                /// <para>Only one of MaxConcurrentCount and MaxConcurrentPercentage can be returned.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("MaxConcurrentPercentage")]
                [Validation(Required=false)]
                public int? MaxConcurrentPercentage { get; set; }

                /// <summary>
                /// <para>The regions in the order of operation execution.</para>
                /// </summary>
                [NameInMap("RegionIdsOrder")]
                [Validation(Required=false)]
                public List<string> RegionIdsOrder { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether stacks are retained when the associated stack instances are deleted. When you delete a stack instance, you can choose to delete or retain the stack with which the stack instance is associated.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Stacks are retained when the associated stack instances are deleted.</description></item>
            /// <item><description>false: Stacks are deleted when the associated stack instances are deleted. Proceed with caution.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is returned only if you delete stack instances.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("RetainStacks")]
            [Validation(Required=false)]
            public bool? RetainStacks { get; set; }

            /// <summary>
            /// <para>The information about drift detection.</para>
            /// <remarks>
            /// <para>This parameter is returned only if drift detection is performed.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("StackGroupDriftDetectionDetail")]
            [Validation(Required=false)]
            public GetStackGroupOperationResponseBodyStackGroupOperationStackGroupDriftDetectionDetail StackGroupDriftDetectionDetail { get; set; }
            public class GetStackGroupOperationResponseBodyStackGroupOperationStackGroupDriftDetectionDetail : TeaModel {
                /// <summary>
                /// <para>The number of stack instances for which drift detection was canceled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CancelledStackInstancesCount")]
                [Validation(Required=false)]
                public int? CancelledStackInstancesCount { get; set; }

                /// <summary>
                /// <para>The drift detection state.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>COMPLETED: Drift detection is performed on the stack group and all stack instances passed the drift detection.</description></item>
                /// <item><description>FAILED: Drift detection is performed on the stack group. The number of stack instances that failed the drift detection exceeds the specified threshold.</description></item>
                /// <item><description>PARTIAL_SUCCESS: Drift detection is performed on the stack group. The number of stack instances that failed the drift detection does not exceed the specified threshold.</description></item>
                /// <item><description>IN_PROGRESS: Drift detection is being performed on the stack group.</description></item>
                /// <item><description>STOPPED: Drift detection is canceled for the stack group.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>COMPLETED</para>
                /// </summary>
                [NameInMap("DriftDetectionStatus")]
                [Validation(Required=false)]
                public string DriftDetectionStatus { get; set; }

                /// <summary>
                /// <para>The time when drift detection was performed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-02-27T07:47:47</para>
                /// </summary>
                [NameInMap("DriftDetectionTime")]
                [Validation(Required=false)]
                public string DriftDetectionTime { get; set; }

                /// <summary>
                /// <para>The number of stack instances that have drifted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DriftedStackInstancesCount")]
                [Validation(Required=false)]
                public int? DriftedStackInstancesCount { get; set; }

                /// <summary>
                /// <para>The number of stack instances that failed drift detection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("FailedStackInstancesCount")]
                [Validation(Required=false)]
                public int? FailedStackInstancesCount { get; set; }

                /// <summary>
                /// <para>The number of stack instances on which drift detection was being performed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("InProgressStackInstancesCount")]
                [Validation(Required=false)]
                public int? InProgressStackInstancesCount { get; set; }

                /// <summary>
                /// <para>The number of stack instances that were being synchronized.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("InSyncStackInstancesCount")]
                [Validation(Required=false)]
                public int? InSyncStackInstancesCount { get; set; }

                /// <summary>
                /// <para>The drift state of the stack group.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>DRIFTED: At least one stack instance in the stack group has drifted.</description></item>
                /// <item><description>NOT_CHECKED: No successful drift detection is performed in the stack group.</description></item>
                /// <item><description>IN_SYNC: All the stack instances in the stack group are being synchronized.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DRIFTED</para>
                /// </summary>
                [NameInMap("StackGroupDriftStatus")]
                [Validation(Required=false)]
                public string StackGroupDriftStatus { get; set; }

                /// <summary>
                /// <para>The number of stack instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("TotalStackInstancesCount")]
                [Validation(Required=false)]
                public int? TotalStackInstancesCount { get; set; }

            }

            /// <summary>
            /// <para>The ID of the stack group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fd0ddef9-9540-4b42-a464-94f77835****</para>
            /// </summary>
            [NameInMap("StackGroupId")]
            [Validation(Required=false)]
            public string StackGroupId { get; set; }

            /// <summary>
            /// <para>The name of the stack group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MyStackGroup</para>
            /// </summary>
            [NameInMap("StackGroupName")]
            [Validation(Required=false)]
            public string StackGroupName { get; set; }

            /// <summary>
            /// <para>The state of the operation.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>RUNNING</description></item>
            /// <item><description>SUCCEEDED</description></item>
            /// <item><description>FAILED</description></item>
            /// <item><description>STOPPING</description></item>
            /// <item><description>STOPPED</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCEEDED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
