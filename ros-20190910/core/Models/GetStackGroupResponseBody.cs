// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetStackGroupResponseBody : TeaModel {
        /// <summary>
        /// The details of the stack group.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Details of the stack group.
        /// </summary>
        [NameInMap("StackGroup")]
        [Validation(Required=false)]
        public GetStackGroupResponseBodyStackGroup StackGroup { get; set; }
        public class GetStackGroupResponseBodyStackGroup : TeaModel {
            /// <summary>
            /// The parameters of the stack group.
            /// </summary>
            [NameInMap("AdministrationRoleName")]
            [Validation(Required=false)]
            public string AdministrationRoleName { get; set; }

            /// <summary>
            /// Indicates whether automatic deployment is enabled.
            /// 
            /// Valid values:
            /// 
            /// *   true: Automatic deployment is enabled. If a member account is added to the folder to which the stack group belongs after automatic deployment is enabled, the stack group deploys its stack instances in the specified region where the added account is deployed. If the account is deleted from the folder, the stack instances in the specified region are deleted from the stack group.
            /// *   false: Automatic deployment is disabled. After automatic deployment is disabled, the stack instances remain unchanged when the member account in the folder is changed.
            /// </summary>
            [NameInMap("AutoDeployment")]
            [Validation(Required=false)]
            public GetStackGroupResponseBodyStackGroupAutoDeployment AutoDeployment { get; set; }
            public class GetStackGroupResponseBodyStackGroupAutoDeployment : TeaModel {
                /// <summary>
                /// Indicates whether stacks in the member account are retained when the member account is deleted from the folder.
                /// 
                /// Valid values:
                /// 
                /// *   true: The stacks are retained.
                /// *   false: The stacks are deleted.
                /// 
                /// >  This parameter is returned only when the Enabled parameter is set to true.
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// The folder IDs of the resource directory. This parameter is used to deploy stack instances within all the accounts in the folders.
                /// 
                /// >  This parameter is returned only when the PermissionModel parameter is set to SERVICE_MANAGED.
                /// </summary>
                [NameInMap("RetainStacksOnAccountRemoval")]
                [Validation(Required=false)]
                public bool? RetainStacksOnAccountRemoval { get; set; }

            }

            /// <summary>
            /// The name of the stack group.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The template body.
            /// </summary>
            [NameInMap("ExecutionRoleName")]
            [Validation(Required=false)]
            public string ExecutionRoleName { get; set; }

            /// <summary>
            /// The key of the parameter.
            /// </summary>
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public List<GetStackGroupResponseBodyStackGroupParameters> Parameters { get; set; }
            public class GetStackGroupResponseBodyStackGroupParameters : TeaModel {
                /// <summary>
                /// The name of the parameter.
                /// </summary>
                [NameInMap("ParameterKey")]
                [Validation(Required=false)]
                public string ParameterKey { get; set; }

                /// <summary>
                /// The value of the parameter.
                /// </summary>
                [NameInMap("ParameterValue")]
                [Validation(Required=false)]
                public string ParameterValue { get; set; }

            }

            /// <summary>
            /// The information about automatic deployment settings.
            /// 
            /// >  This parameter is returned only when the PermissionModel parameter is set to SERVICE_MANAGED.
            /// </summary>
            [NameInMap("PermissionModel")]
            [Validation(Required=false)]
            public string PermissionModel { get; set; }

            /// <summary>
            /// The folder IDs of the resource directory. This parameter is used to deploy stack instances within all the accounts in the folders.
            /// 
            /// >  This parameter is returned only when the PermissionModel parameter is set to SERVICE_MANAGED.
            /// </summary>
            [NameInMap("RdFolderIds")]
            [Validation(Required=false)]
            public List<string> RdFolderIds { get; set; }

            /// <summary>
            /// The permission model.
            /// 
            /// Valid values:
            /// 
            /// *   SELF_MANAGED: the self-managed permission model
            /// *   SERVICE_MANAGED: the service-managed permission model
            /// 
            /// >  For more information about the permission models of stack groups, see [Overview](~~154578~~).
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The time when drift detection was performed on the stack group.
            /// </summary>
            [NameInMap("StackGroupDriftDetectionDetail")]
            [Validation(Required=false)]
            public GetStackGroupResponseBodyStackGroupStackGroupDriftDetectionDetail StackGroupDriftDetectionDetail { get; set; }
            public class GetStackGroupResponseBodyStackGroupStackGroupDriftDetectionDetail : TeaModel {
                /// <summary>
                /// The number of stack instances that have drifted.
                /// </summary>
                [NameInMap("CancelledStackInstancesCount")]
                [Validation(Required=false)]
                public int? CancelledStackInstancesCount { get; set; }

                /// <summary>
                /// The drift status of the stack group.
                /// 
                /// Valid values:
                /// 
                /// *   DRIFTED: At least one stack instance in the stack group has drifted.
                /// *   NOT_CHECKED: No drift detection is completed on the stack group.
                /// *   IN_SYNC: All the stack instances in the stack group are being synchronized.
                /// </summary>
                [NameInMap("DriftDetectionStatus")]
                [Validation(Required=false)]
                public string DriftDetectionStatus { get; set; }

                /// <summary>
                /// The number of stack instances.
                /// </summary>
                [NameInMap("DriftDetectionTime")]
                [Validation(Required=false)]
                public string DriftDetectionTime { get; set; }

                /// <summary>
                /// The ID of the resource group. This parameter is specified when you create the stack group.
                /// </summary>
                [NameInMap("DriftedStackInstancesCount")]
                [Validation(Required=false)]
                public int? DriftedStackInstancesCount { get; set; }

                /// <summary>
                /// The status of drift detection on the stack group.
                /// 
                /// Valid values:
                /// 
                /// *   COMPLETED: Drift detection is performed and completed on all stack instances.
                /// *   FAILED: Drift detection is performed. The number of stack instances that failed the drift detection exceeds the specified threshold.
                /// *   PARTIAL_SUCCESS: Drift detection is performed. The number of stack instances that failed the drift detection does not exceed the specified threshold.
                /// *   IN_PROGRESS: Drift detection is being performed on the stack group.
                /// *   STOPPED: Drift detection is canceled for the stack group.
                /// </summary>
                [NameInMap("FailedStackInstancesCount")]
                [Validation(Required=false)]
                public int? FailedStackInstancesCount { get; set; }

                /// <summary>
                /// The number of stack instances that were being synchronized.
                /// </summary>
                [NameInMap("InProgressStackInstancesCount")]
                [Validation(Required=false)]
                public int? InProgressStackInstancesCount { get; set; }

                /// <summary>
                /// The number of stack instances for which drift detection was canceled.
                /// </summary>
                [NameInMap("InSyncStackInstancesCount")]
                [Validation(Required=false)]
                public int? InSyncStackInstancesCount { get; set; }

                /// <summary>
                /// The number of stack instances on which drift detection was being performed.
                /// </summary>
                [NameInMap("StackGroupDriftStatus")]
                [Validation(Required=false)]
                public string StackGroupDriftStatus { get; set; }

                /// <summary>
                /// The number of stack instances that failed drift detection.
                /// </summary>
                [NameInMap("TotalStackInstancesCount")]
                [Validation(Required=false)]
                public int? TotalStackInstancesCount { get; set; }

            }

            /// <summary>
            /// The status of the stack group.
            /// 
            /// Valid values:
            /// 
            /// *   ACTIVE
            /// *   DELETED
            /// </summary>
            [NameInMap("StackGroupId")]
            [Validation(Required=false)]
            public string StackGroupId { get; set; }

            /// <summary>
            /// The name of the RAM role that is specified for the execution account when you create the self-managed stack group. The administrator role AliyunROSStackGroupAdministrationRole assumes the execution role. If this parameter is not specified, the default value AliyunROSStackGroupExecutionRole is returned.
            /// </summary>
            [NameInMap("StackGroupName")]
            [Validation(Required=false)]
            public string StackGroupName { get; set; }

            /// <summary>
            /// The name of the RAM role that is specified for the administrator account in Resource Orchestration Service (ROS) when you create the self-managed stack group. If this parameter is not specified, the default value AliyunROSStackGroupAdministrationRole is returned.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The structure that contains the template body.
            /// 
            /// > We recommend that you use TemplateContent instead of TemplateBody.
            /// </summary>
            [NameInMap("TemplateBody")]
            [Validation(Required=false)]
            public string TemplateBody { get; set; }

            /// <summary>
            /// The JSON-formatted structure that contains the template body. For more information, see [Template syntax](~~28857~~).
            /// </summary>
            [NameInMap("TemplateContent")]
            [Validation(Required=false)]
            public string TemplateContent { get; set; }

        }

    }

}
