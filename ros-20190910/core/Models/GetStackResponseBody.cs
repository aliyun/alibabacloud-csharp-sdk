// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetStackResponseBody : TeaModel {
        /// <summary>
        /// The number of resources on which drift detection is performed.
        /// 
        /// >  This parameter is returned only if the drift detection on the stack is successful.
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
        /// *   Disabled: Deletion protection is disabled for the stack. You can delete the stack in the Resource Orchestration Service (ROS) console or by calling the DeleteStack operation.
        /// 
        /// >  Deletion protection of a nested stack works in the same way as that of the root stack.
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
        /// *   true: Rollback is disabled when the stack fails to be created.
        /// *   false: Rollback is enabled when the stack fails to be created. This is the default value.
        /// </summary>
        [NameInMap("DisableRollback")]
        [Validation(Required=false)]
        public bool? DisableRollback { get; set; }

        /// <summary>
        /// The time when the last successful drift detection operation was performed.
        /// </summary>
        [NameInMap("DriftDetectionTime")]
        [Validation(Required=false)]
        public string DriftDetectionTime { get; set; }

        /// <summary>
        /// The description of the web UI in the ROS console.
        /// </summary>
        [NameInMap("Interface")]
        [Validation(Required=false)]
        public string Interface { get; set; }

        /// <summary>
        /// The logs of the stack.
        /// </summary>
        [NameInMap("Log")]
        [Validation(Required=false)]
        public GetStackResponseBodyLog Log { get; set; }
        public class GetStackResponseBodyLog : TeaModel {
            /// <summary>
            /// The logs of resources in the stack. This parameter is returned if the LogOption parameter is set to Resource or All.  
            /// 
            /// >  The logs are returned for resources of specific types, such as `ALIYUN::ROS::ResourceCleaner`.
            /// </summary>
            [NameInMap("ResourceLogs")]
            [Validation(Required=false)]
            public List<GetStackResponseBodyLogResourceLogs> ResourceLogs { get; set; }
            public class GetStackResponseBodyLogResourceLogs : TeaModel {
                /// <summary>
                /// The logs of all resources.
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
            /// The logs of the Terraform stack. This parameter is returned only for a Terraform stack. 
            /// 
            /// This parameter is returned if the LogOption parameter is left empty or set to Stack or All.  
            /// 
            /// >  This parameter is not returned for a running stack. The logs are generated from the last creation, re-creation, update, or deletion operation on the stack.
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
        /// The number of resources on which drift detection is not performed.
        /// 
        /// >  This parameter is returned only if the drift detection on the stack is successful.
        /// </summary>
        [NameInMap("NotCheckedStackResourceCount")]
        [Validation(Required=false)]
        public int? NotCheckedStackResourceCount { get; set; }

        /// <summary>
        /// The callback URLs that are used to receive stack events.
        /// </summary>
        [NameInMap("NotificationURLs")]
        [Validation(Required=false)]
        public List<string> NotificationURLs { get; set; }

        /// <summary>
        /// The additional information that is displayed when an error occurs on a stack operation. 
        /// 
        /// >  This property is returned in specific conditions. At least one sub-property is returned. For example, an error is reported when you call the API of another cloud service.
        /// </summary>
        [NameInMap("OperationInfo")]
        [Validation(Required=false)]
        public GetStackResponseBodyOperationInfo OperationInfo { get; set; }
        public class GetStackResponseBodyOperationInfo : TeaModel {
            /// <summary>
            /// The name of the API of another cloud service.
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// The error code returned.
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// The logical ID of the resource on which the operation error occurred.
            /// </summary>
            [NameInMap("LogicalResourceId")]
            [Validation(Required=false)]
            public string LogicalResourceId { get; set; }

            /// <summary>
            /// The error message returned.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The ID of the request to call the API of another cloud service.
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// The type of the resource on which the operation error occurred.
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        [NameInMap("OrderIds")]
        [Validation(Required=false)]
        public List<string> OrderIds { get; set; }

        /// <summary>
        /// The output parameters of the stack.
        /// 
        /// >  This parameter is returned if the OutputOption parameter is set to Enabled.
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
        /// The ID of the parent stack.
        /// </summary>
        [NameInMap("ParentStackId")]
        [Validation(Required=false)]
        public string ParentStackId { get; set; }

        /// <summary>
        /// The name of the RAM role. ROS assumes the RAM role to create the stack and uses credentials of the role to call the APIs of Alibaba Cloud services.
        /// 
        /// ROS assumes the RAM role to perform operations on the stack. If you have permissions to perform operations on the stack but do not have permissions to use the RAM role, ROS still assumes the RAM role. You must make sure that the least privileges are granted to the role.
        /// 
        /// If you do not specify this parameter, ROS assumes an existing role that is associated with the stack. If no roles are available for ROS to assume, ROS uses a temporary credential that is generated from the credentials of your account.
        /// 
        /// The name of the RAM role can be up to 64 bytes in length.
        /// </summary>
        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        /// <summary>
        /// The ID of the region in which the stack is deployed. You can call the [DescribeRegions](~~131035~~) operation to query the most recent list of Alibaba Cloud regions.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the instances belong.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The creation progress of resources.
        /// </summary>
        [NameInMap("ResourceProgress")]
        [Validation(Required=false)]
        public GetStackResponseBodyResourceProgress ResourceProgress { get; set; }
        public class GetStackResponseBodyResourceProgress : TeaModel {
            /// <summary>
            /// The number of resources that fail to be created.
            /// </summary>
            [NameInMap("FailedResourceCount")]
            [Validation(Required=false)]
            public int? FailedResourceCount { get; set; }

            /// <summary>
            /// The number of resources that are being created.
            /// </summary>
            [NameInMap("InProgressResourceCount")]
            [Validation(Required=false)]
            public int? InProgressResourceCount { get; set; }

            /// <summary>
            /// The progress details of resources that are being created.
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
            /// </summary>
            [NameInMap("PendingResourceCount")]
            [Validation(Required=false)]
            public int? PendingResourceCount { get; set; }

            [NameInMap("StackActionProgress")]
            [Validation(Required=false)]
            public float? StackActionProgress { get; set; }

            [NameInMap("StackOperationProgress")]
            [Validation(Required=false)]
            public float? StackOperationProgress { get; set; }

            /// <summary>
            /// The number of resources that are created.
            /// </summary>
            [NameInMap("SuccessResourceCount")]
            [Validation(Required=false)]
            public int? SuccessResourceCount { get; set; }

            /// <summary>
            /// The total number of resources.
            /// </summary>
            [NameInMap("TotalResourceCount")]
            [Validation(Required=false)]
            public int? TotalResourceCount { get; set; }

        }

        /// <summary>
        /// The ID of the root stack. This parameter is returned if the specified stack is a nested stack.
        /// </summary>
        [NameInMap("RootStackId")]
        [Validation(Required=false)]
        public string RootStackId { get; set; }

        /// <summary>
        /// Indicates whether the stack is a managed stack. Valid values: 
        /// 
        /// - true
        /// - false
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
        /// The status of the stack in the last successful drift detection. Valid values:
        /// 
        /// *   DRIFTED: The stack has drifted.
        /// *   NOT_CHECKED: No successful drift detection is performed on the stack.
        /// *   IN_SYNC: The stack is being synchronized.
        /// </summary>
        [NameInMap("StackDriftStatus")]
        [Validation(Required=false)]
        public string StackDriftStatus { get; set; }

        /// <summary>
        /// The ID of the stack.
        /// </summary>
        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

        /// <summary>
        /// The name of the stack.
        /// 
        /// The name can be up to 255 characters in length, and can contain digits, letters, hyphens (-), and underscores (\_). It must start with a digit or letter.
        /// </summary>
        [NameInMap("StackName")]
        [Validation(Required=false)]
        public string StackName { get; set; }

        /// <summary>
        /// The type of the stack. Valid values:
        /// 
        /// *   ROS: The ROS stack, which is created by using an ROS template.
        /// *   Terraform: The Terraform stack, which is created by using a Terraform template.
        /// </summary>
        [NameInMap("StackType")]
        [Validation(Required=false)]
        public string StackType { get; set; }

        /// <summary>
        /// The state of the stack. Valid values:
        /// 
        /// *   CREATE_IN_PROGRESS: The stack is being created.
        /// *   CREATE_FAILED: The stack fails to be created.
        /// *   CREATE_COMPLETE: The stack is created.
        /// *   UPDATE_IN_PROGRESS: The stack is being updated.
        /// *   UPDATE_FAILED: The stack fails to be updated.
        /// *   UPDATE_COMPLETE: The stack is updated.
        /// *   DELETE_IN_PROGRESS: The stack is being deleted.
        /// *   DELETE_FAILED: The stack fails to be deleted.
        /// *   CREATE_ROLLBACK_IN_PROGRESS: The stack is being rolled back after the stack fails to be created.
        /// *   CREATE_ROLLBACK_FAILED: The stack fails to be rolled back after the stack fails to be created.
        /// *   CREATE_ROLLBACK_COMPLETE: The stack is rolled back after the stack fails to be created.
        /// *   ROLLBACK_IN_PROGRESS: The resources in the stack are being rolled back.
        /// *   ROLLBACK_FAILED: The resources in the stack fail to be rolled back.
        /// *   ROLLBACK_COMPLETE: The resources in the stack are rolled back.
        /// *   CHECK_IN_PROGRESS: The stack is being validated.
        /// *   CHECK_FAILED: The stack fails to be validated.
        /// *   CHECK_COMPLETE: The stack is validated.
        /// *   REVIEW_IN_PROGRESS: The stack is being reviewed.
        /// *   IMPORT_CREATE_IN_PROGRESS: The stack is being created by using imported resources.
        /// *   IMPORT_CREATE_FAILED: The stack fails to be created by using imported resources.
        /// *   IMPORT_CREATE_COMPLETE: The stack is created by using imported resources.
        /// *   IMPORT_CREATE_ROLLBACK_IN_PROGRESS: The resources are being rolled back after the stack fails to be created by using imported resources.
        /// *   IMPORT_CREATE_ROLLBACK_FAILED: The resources fail to be rolled back after the stack fails to be created by using imported resources.
        /// *   IMPORT_CREATE_ROLLBACK_COMPLETE: The resources are rolled back after the stack fails to be created by using imported resources.
        /// *   IMPORT_UPDATE_IN_PROGRESS: The stack is being updated by using imported resources.
        /// *   IMPORT_UPDATE_FAILED: The stack fails to be updated by using imported resources.
        /// *   IMPORT_UPDATE_COMPLETE: The stack is updated by using imported resources.
        /// *   IMPORT_UPDATE_ROLLBACK_IN_PROGRESS: The resources are being rolled back after the stack fails to be updated by using imported resources.
        /// *   IMPORT_UPDATE_ROLLBACK_FAILED: The resources fail to be rolled back after the stack fails to be updated by using imported resources.
        /// *   IMPORT_UPDATE_ROLLBACK_COMPLETE: The resources are rolled back after the stack fails to be updated by using imported resources.
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
        /// The ID of the template. This parameter is returned only if the current template of the stack is a custom template or a shared template.  
        /// 
        /// If the template is a shared template, the value of this parameter is the same as the value of the TemplateARN parameter.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// The ID of the scenario. This parameter is returned only if the current template of the stack is generated from a scenario.
        /// </summary>
        [NameInMap("TemplateScratchId")]
        [Validation(Required=false)]
        public string TemplateScratchId { get; set; }

        /// <summary>
        /// The URL of the file that contains the template body. This parameter is returned only if the current template of the stack is from a URL. The URL can point to a template that is located on an HTTP or HTTPS web server or in an Alibaba Cloud Object Storage Service (OSS) bucket.
        /// </summary>
        [NameInMap("TemplateURL")]
        [Validation(Required=false)]
        public string TemplateURL { get; set; }

        /// <summary>
        /// The version of the template. This parameter is returned only if the current template of the stack is a custom template or a shared template.  
        /// 
        /// If the template is a shared template, this parameter is returned only when the VersionOption parameter is set to AllVersions.  
        /// 
        /// Valid values: v1 to v100.
        /// </summary>
        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

        /// <summary>
        /// The timeout period within which the stack can be created. Unit: minutes.
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
