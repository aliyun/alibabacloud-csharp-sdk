// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetStackResponseBody : TeaModel {
        /// <summary>
        /// The number of resources on which drift detection was performed.
        /// 
        /// >  This parameter is returned only if the most recent drift detection on the stack was successful.
        /// </summary>
        [NameInMap("CheckedStackResourceCount")]
        [Validation(Required=false)]
        public int? CheckedStackResourceCount { get; set; }

        /// <summary>
        /// The time when the stack was created. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// Indicates whether deletion protection is enabled for the stack. Valid values:
        /// 
        /// *   Enabled: Deletion protection is enabled for the stack.
        /// *   Disabled: Deletion protection is disabled for the stack. You can delete the stack by using the ROS console or by calling the DeleteStack operation.
        /// 
        /// >  Deletion protection of a nested stack is the same as deletion protection of its root stack.
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public string DeletionProtection { get; set; }

        /// <summary>
        /// The description of the stack.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Indicates whether rollback is disabled when the stack fails to be created. Valid values:
        /// 
        /// *   true
        /// *   false (default)
        /// </summary>
        [NameInMap("DisableRollback")]
        [Validation(Required=false)]
        public bool? DisableRollback { get; set; }

        /// <summary>
        /// The time when the most recent successful drift detection was performed on the stack.
        /// </summary>
        [NameInMap("DriftDetectionTime")]
        [Validation(Required=false)]
        public string DriftDetectionTime { get; set; }

        /// <summary>
        /// The description of the console user interface (UI).
        /// </summary>
        [NameInMap("Interface")]
        [Validation(Required=false)]
        public string Interface { get; set; }

        /// <summary>
        /// The log of the stack.
        /// </summary>
        [NameInMap("Log")]
        [Validation(Required=false)]
        public GetStackResponseBodyLog Log { get; set; }
        public class GetStackResponseBodyLog : TeaModel {
            /// <summary>
            /// The logs of resources in the stack. This parameter is returned if LogOption is set to Resource or All.
            /// 
            /// >  The logs are returned only for resources of specific types, such as the `ALIYUN::ROS::ResourceCleaner` type.
            /// </summary>
            [NameInMap("ResourceLogs")]
            [Validation(Required=false)]
            public List<GetStackResponseBodyLogResourceLogs> ResourceLogs { get; set; }
            public class GetStackResponseBodyLogResourceLogs : TeaModel {
                /// <summary>
                /// All the logs that are associated with the resources.
                /// </summary>
                [NameInMap("Logs")]
                [Validation(Required=false)]
                public List<GetStackResponseBodyLogResourceLogsLogs> Logs { get; set; }
                public class GetStackResponseBodyLogResourceLogsLogs : TeaModel {
                    /// <summary>
                    /// The content of a resource log.
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// The keywords of a resource log.
                    /// </summary>
                    [NameInMap("Keys")]
                    [Validation(Required=false)]
                    public List<string> Keys { get; set; }

                }

                /// <summary>
                /// The name of the resource that is defined in the template.
                /// </summary>
                [NameInMap("ResourceName")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

            }

            /// <summary>
            /// The logs generated when the Terraform stack is run. This parameter is returned only for a Terraform stack. This parameter is returned if LogOption is left empty or set to Stack or All.
            /// 
            /// >  This parameter is not returned for a running stack. The logs are generated from the most recent operation on the stack, such as the creation, resumed creation, update, or deletion operation.
            /// </summary>
            [NameInMap("TerraformLogs")]
            [Validation(Required=false)]
            public List<GetStackResponseBodyLogTerraformLogs> TerraformLogs { get; set; }
            public class GetStackResponseBodyLogTerraformLogs : TeaModel {
                /// <summary>
                /// The name of the Terraform command that is run. Valid values:
                /// 
                /// *   apply
                /// *   plan
                /// *   destroy
                /// *   version
                /// 
                /// For more information about Terraform commands, see [Basic CLI Features](https://www.terraform.io/cli/commands).
                /// </summary>
                [NameInMap("Command")]
                [Validation(Required=false)]
                public string Command { get; set; }

                /// <summary>
                /// The content of the output stream that is returned after the command is run.
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// The output stream. Valid values:
                /// 
                /// *   stdout: standard output stream
                /// *   stderr: standard error stream
                /// </summary>
                [NameInMap("Stream")]
                [Validation(Required=false)]
                public string Stream { get; set; }

            }

        }

        /// <summary>
        /// The number of resources on which drift detection was not performed.
        /// 
        /// >  This parameter is returned only if the most recent drift detection on the stack was successful.
        /// </summary>
        [NameInMap("NotCheckedStackResourceCount")]
        [Validation(Required=false)]
        public int? NotCheckedStackResourceCount { get; set; }

        /// <summary>
        /// The callback URLs for receiving stack events.
        /// </summary>
        [NameInMap("NotificationURLs")]
        [Validation(Required=false)]
        public List<string> NotificationURLs { get; set; }

        /// <summary>
        /// The supplementary information that is returned if an error occurs on a stack operation.
        /// 
        /// >  This parameter is returned together with at least one sub-parameter and only under specific conditions. For example, the supplementary information is returned when an API operation of another Alibaba Cloud service fails to be called.
        /// </summary>
        [NameInMap("OperationInfo")]
        [Validation(Required=false)]
        public GetStackResponseBodyOperationInfo OperationInfo { get; set; }
        public class GetStackResponseBodyOperationInfo : TeaModel {
            /// <summary>
            /// The name of the API operation that belongs to another Alibaba Cloud service.
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// The error code.
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// The logical ID of the resource on which the operation error occurs.
            /// </summary>
            [NameInMap("LogicalResourceId")]
            [Validation(Required=false)]
            public string LogicalResourceId { get; set; }

            /// <summary>
            /// The error message.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The ID of the request that is initiated to call the API operation of another Alibaba Cloud service.
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// The type of the resource on which the operation error occurs.
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        /// <summary>
        /// The order IDs. This parameter is returned only if you configured manual payment when you created a subscription stack.
        /// </summary>
        [NameInMap("OrderIds")]
        [Validation(Required=false)]
        public List<string> OrderIds { get; set; }

        /// <summary>
        /// The outputs of the stack.
        /// </summary>
        [NameInMap("Outputs")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Outputs { get; set; }

        /// <summary>
        /// The parameters of the stack.
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<GetStackResponseBodyParameters> Parameters { get; set; }
        public class GetStackResponseBodyParameters : TeaModel {
            /// <summary>
            /// The parameter name.
            /// </summary>
            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            /// <summary>
            /// The parameter value.
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

        /// <summary>
        /// The ID of the parent stack.
        /// </summary>
        [NameInMap("ParentStackId")]
        [Validation(Required=false)]
        public string ParentStackId { get; set; }

        /// <summary>
        /// The name of the Resource Access Management (RAM) role. ROS assumes the RAM role to create the stack and uses the credentials of the role to call the APIs of Alibaba Cloud services.\
        /// ROS assumes the RAM role to perform operations on the stack. If you have permissions to perform operations on the stack, ROS assumes the RAM role even if you do not have permissions to use the RAM role. You must make sure that permissions are granted to the RAM role based on the principle of least privilege.\
        /// If this parameter is not specified, ROS uses the existing role that is associated with the stack. If no roles are available, ROS uses a temporary credential that is generated from the credentials of your account.\
        /// The RAM role name can be up to 64 characters in length.
        /// </summary>
        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        /// <summary>
        /// The region ID of the stack. You can call the [DescribeRegions](~~131035~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The resource creation progress.
        /// </summary>
        [NameInMap("ResourceProgress")]
        [Validation(Required=false)]
        public GetStackResponseBodyResourceProgress ResourceProgress { get; set; }
        public class GetStackResponseBodyResourceProgress : TeaModel {
            /// <summary>
            /// The number of resources that failed to be created.
            /// 
            /// >  This parameter is returned only if `ShowResourceProgress` is set to `EnabledIfCreateStack`.
            /// </summary>
            [NameInMap("FailedResourceCount")]
            [Validation(Required=false)]
            public int? FailedResourceCount { get; set; }

            /// <summary>
            /// The number of resources that are being created.
            /// 
            /// >  This parameter is returned only if `ShowResourceProgress` is set to `EnabledIfCreateStack`.
            /// </summary>
            [NameInMap("InProgressResourceCount")]
            [Validation(Required=false)]
            public int? InProgressResourceCount { get; set; }

            /// <summary>
            /// The progress details of resources that are being created.
            /// 
            /// >  This parameter is returned only if `ShowResourceProgress` is set to `EnabledIfCreateStack`.
            /// </summary>
            [NameInMap("InProgressResourceDetails")]
            [Validation(Required=false)]
            public List<GetStackResponseBodyResourceProgressInProgressResourceDetails> InProgressResourceDetails { get; set; }
            public class GetStackResponseBodyResourceProgressInProgressResourceDetails : TeaModel {
                /// <summary>
                /// The desired progress value of the resource.
                /// </summary>
                [NameInMap("ProgressTargetValue")]
                [Validation(Required=false)]
                public float? ProgressTargetValue { get; set; }

                /// <summary>
                /// The current progress value of the resource.
                /// </summary>
                [NameInMap("ProgressValue")]
                [Validation(Required=false)]
                public float? ProgressValue { get; set; }

                /// <summary>
                /// The resource name.
                /// </summary>
                [NameInMap("ResourceName")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

                /// <summary>
                /// The resource type.
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            /// <summary>
            /// The number of resources to be created.
            /// 
            /// >  This parameter is returned only if `ShowResourceProgress` is set to `EnabledIfCreateStack`.
            /// </summary>
            [NameInMap("PendingResourceCount")]
            [Validation(Required=false)]
            public int? PendingResourceCount { get; set; }

            /// <summary>
            /// The creation or rollback progress of the stack, in percentage. Valid values: 0 to 100.
            /// 
            /// The value progressively increases from 0 to 100 during a stack creation operation. If the stack is created, the value reaches 100. If the stack fails to be created, a rollback is started for the stack resources, and the value progressively increases from the percentage of the remaining progress (100 - Progress value generated when the stack fails to be created). The value increases to 100 when the stack resources are rolled back. This parameter indicates the creation progress during a stack creation operation and indicates the rollback progress during a stack rollback operation.
            /// 
            /// >  This parameter is returned only if `ShowResourceProgress` is set to `PercentageOnly`.
            /// </summary>
            [NameInMap("StackActionProgress")]
            [Validation(Required=false)]
            public float? StackActionProgress { get; set; }

            /// <summary>
            /// The overall creation progress of the stack, in percentage. Valid values: 0 to 100.
            /// 
            /// The value progressively increases from 0 to 100 during a stack creation operation. If the stack is created, the value reaches 100. If the stack fails to be created, a rollback is started for the stack resources, and the value progressively decreases. The value decreases to 0 when the stack resources are rolled back. This parameter indicates only the overall creation progress, regardless of whether during a stack creation or rollback operation.
            /// 
            /// >  This parameter is returned only if `ShowResourceProgress` is set to `PercentageOnly`.
            /// </summary>
            [NameInMap("StackOperationProgress")]
            [Validation(Required=false)]
            public float? StackOperationProgress { get; set; }

            /// <summary>
            /// The number of resources that are created.
            /// 
            /// >  This parameter is returned only if `ShowResourceProgress` is set to `EnabledIfCreateStack`.
            /// </summary>
            [NameInMap("SuccessResourceCount")]
            [Validation(Required=false)]
            public int? SuccessResourceCount { get; set; }

            /// <summary>
            /// The total number of resources.
            /// 
            /// >  This parameter is returned only if `ShowResourceProgress` is set to `EnabledIfCreateStack`.
            /// </summary>
            [NameInMap("TotalResourceCount")]
            [Validation(Required=false)]
            public int? TotalResourceCount { get; set; }

        }

        /// <summary>
        /// 当资源栈状态为回滚失败时，该字段展示导致回滚的前一阶段执行失败的原因。
        /// </summary>
        [NameInMap("RollbackFailedRootReason")]
        [Validation(Required=false)]
        public string RollbackFailedRootReason { get; set; }

        /// <summary>
        /// The ID of the root stack. This parameter is returned if the specified stack is a nested stack.
        /// </summary>
        [NameInMap("RootStackId")]
        [Validation(Required=false)]
        public string RootStackId { get; set; }

        /// <summary>
        /// Indicates whether the stack is a managed stack. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("ServiceManaged")]
        [Validation(Required=false)]
        public bool? ServiceManaged { get; set; }

        /// <summary>
        /// The name of the service to which the managed stack belongs.
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// The state of the stack on which the most recent successful drift detection was performed. Valid values:
        /// 
        /// *   DRIFTED: The stack has drifted.
        /// *   NOT_CHECKED: No successful drift detection is performed on the stack.
        /// *   IN_SYNC: The stack is being synchronized.
        /// </summary>
        [NameInMap("StackDriftStatus")]
        [Validation(Required=false)]
        public string StackDriftStatus { get; set; }

        /// <summary>
        /// The stack ID.
        /// </summary>
        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

        /// <summary>
        /// The stack name.\
        /// The name can be up to 255 characters in length, and can contain digits, letters, hyphens (-), and underscores (\_). The name must start with a digit or letter.
        /// </summary>
        [NameInMap("StackName")]
        [Validation(Required=false)]
        public string StackName { get; set; }

        /// <summary>
        /// The stack type. Valid values:
        /// 
        /// *   ROS: ROS stack. The stack is created by using a ROS template.
        /// *   Terraform: Terraform stack. The stack is created by using a Terraform template.
        /// </summary>
        [NameInMap("StackType")]
        [Validation(Required=false)]
        public string StackType { get; set; }

        /// <summary>
        /// The state of the stack. Valid values:
        /// 
        /// *   CREATE_IN_PROGRESS: The stack is being created.
        /// *   CREATE_FAILED: The stack failed to be created.
        /// *   CREATE_COMPLETE: The stack is created.
        /// *   UPDATE_IN_PROGRESS: The stack is being updated.
        /// *   UPDATE_FAILED: The stack failed to be updated.
        /// *   UPDATE_COMPLETE: The stack is updated.
        /// *   DELETE_IN_PROGRESS: The stack is being deleted.
        /// *   DELETE_FAILED: The stack failed to be deleted.
        /// *   CREATE_ROLLBACK_IN_PROGRESS: The resources are being rolled back after the stack failed to be created.
        /// *   CREATE_ROLLBACK_FAILED: The resources failed to be rolled back after the stack failed to be created.
        /// *   CREATE_ROLLBACK_COMPLETE: The resources are rolled back after the stack failed to be created.
        /// *   ROLLBACK_IN_PROGRESS: The resources of the stack are being rolled back.
        /// *   ROLLBACK_FAILED: The resources of the stack failed to be rolled back.
        /// *   ROLLBACK_COMPLETE: The resources of the stack are rolled back.
        /// *   CHECK_IN_PROGRESS: The stack is being validated.
        /// *   CHECK_FAILED: The stack failed to be validated.
        /// *   CHECK_COMPLETE: The stack is validated.
        /// *   REVIEW_IN_PROGRESS: The stack is being reviewed.
        /// *   IMPORT_CREATE_IN_PROGRESS: The stack is being created by using imported resources.
        /// *   IMPORT_CREATE_FAILED: The stack failed to be created by using imported resources.
        /// *   IMPORT_CREATE_COMPLETE: The stack is created by using imported resources.
        /// *   IMPORT_CREATE_ROLLBACK_IN_PROGRESS: The resources are being rolled back after the stack failed to be created by using imported resources.
        /// *   IMPORT_CREATE_ROLLBACK_FAILED: The resources failed to be rolled back after the stack failed to be created by using imported resources.
        /// *   IMPORT_CREATE_ROLLBACK_COMPLETE: The resources are rolled back after the stack failed to be created by using imported resources.
        /// *   IMPORT_UPDATE_IN_PROGRESS: The stack is being updated by using imported resources.
        /// *   IMPORT_UPDATE_FAILED: The stack failed to be updated by using imported resources.
        /// *   IMPORT_UPDATE_COMPLETE: The stack is updated by using imported resources.
        /// *   IMPORT_UPDATE_ROLLBACK_IN_PROGRESS: The resources are being rolled back after the stack failed to be updated by using imported resources.
        /// *   IMPORT_UPDATE_ROLLBACK_FAILED: The resources failed to be rolled back after the stack failed to be updated by using imported resources.
        /// *   IMPORT_UPDATE_ROLLBACK_COMPLETE: The resources are rolled back after the stack failed to be updated by using imported resources.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The reason why the stack is in its current state.
        /// </summary>
        [NameInMap("StatusReason")]
        [Validation(Required=false)]
        public string StatusReason { get; set; }

        /// <summary>
        /// The tags of the stack.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetStackResponseBodyTags> Tags { get; set; }
        public class GetStackResponseBodyTags : TeaModel {
            /// <summary>
            /// The tag key of the stack.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value of the stack.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The description of the template.
        /// </summary>
        [NameInMap("TemplateDescription")]
        [Validation(Required=false)]
        public string TemplateDescription { get; set; }

        /// <summary>
        /// The template ID. This parameter is returned only if the current stack template is a custom template or shared template.
        /// 
        /// If the template is a shared template, the value of this parameter is the same as the value of TemplateARN.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// The ID of the resource scenario. This parameter is returned only if the current template of the stack is generated from a resource scenario.
        /// </summary>
        [NameInMap("TemplateScratchId")]
        [Validation(Required=false)]
        public string TemplateScratchId { get; set; }

        /// <summary>
        /// The URL of the file that contains the template body. This parameter is returned only if the current template of the stack is from a URL. The URL can point to a template that is located on an HTTP or HTTPS web server or in an Object Storage Service (OSS) bucket.
        /// </summary>
        [NameInMap("TemplateURL")]
        [Validation(Required=false)]
        public string TemplateURL { get; set; }

        /// <summary>
        /// The version of the template. This parameter is returned only if the current stack template is a custom template or shared template.
        /// 
        /// If the template is a shared template, this parameter is returned only if VersionOption is set to AllVersions.
        /// 
        /// Valid values: v1 to v100.
        /// </summary>
        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

        /// <summary>
        /// The timeout period for creating the stack. Unit: minutes.
        /// </summary>
        [NameInMap("TimeoutInMinutes")]
        [Validation(Required=false)]
        public int? TimeoutInMinutes { get; set; }

        /// <summary>
        /// The time when the stack was updated. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
