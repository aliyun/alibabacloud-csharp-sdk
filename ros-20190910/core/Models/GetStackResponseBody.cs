// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetStackResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of resources on which drift detection has been performed.</para>
        /// <remarks>
        /// <para>This parameter is returned only when the most recent drift detection on the stack was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CheckedStackResourceCount")]
        [Validation(Required=false)]
        public int? CheckedStackResourceCount { get; set; }

        /// <summary>
        /// <para>The time when the stack was created. The time is displayed in UTC+0 and follows the ISO 8601 standard without the trailing Z. Format: YYYY-MM-DDThh:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-09-16T08:21:40</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>Indicates whether deletion protection is enabled for the stack. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enabled: Deletion protection is enabled.</description></item>
        /// <item><description>Disabled: Deletion protection is disabled. In this case, you can release the stack by using the console or by calling the DeleteStack operation.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The deletion protection mechanism of a nested stack is the same as that of the root stack.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Disabled</para>
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public string DeletionProtection { get; set; }

        /// <summary>
        /// <para>The description of the stack.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Create a VPC.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Indicates whether rollback is disabled when the stack fails to be created. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Rollback is disabled. No rollback is performed when the stack fails to be created.</description></item>
        /// <item><description>false (default): Rollback is enabled. Rollback is performed when the stack fails to be created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DisableRollback")]
        [Validation(Required=false)]
        public bool? DisableRollback { get; set; }

        /// <summary>
        /// <para>The time when the most recent successful drift detection was performed on the stack.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-09-16T09:21:40</para>
        /// </summary>
        [NameInMap("DriftDetectionTime")]
        [Validation(Required=false)]
        public string DriftDetectionTime { get; set; }

        /// <summary>
        /// <para>The interface description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Interface")]
        [Validation(Required=false)]
        public string Interface { get; set; }

        /// <summary>
        /// <para>The stack-related output logs.</para>
        /// </summary>
        [NameInMap("Log")]
        [Validation(Required=false)]
        public GetStackResponseBodyLog Log { get; set; }
        public class GetStackResponseBodyLog : TeaModel {
            /// <summary>
            /// <para>The resource output logs. This parameter is returned when LogOption is set to Resource or All.</para>
            /// <remarks>
            /// <para>Only certain resource types return resource logs, such as <c>ALIYUN::ROS::ResourceCleaner</c>.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("ResourceLogs")]
            [Validation(Required=false)]
            public List<GetStackResponseBodyLogResourceLogs> ResourceLogs { get; set; }
            public class GetStackResponseBodyLogResourceLogs : TeaModel {
                /// <summary>
                /// <para>All logs associated with the resource.</para>
                /// </summary>
                [NameInMap("Logs")]
                [Validation(Required=false)]
                public List<GetStackResponseBodyLogResourceLogsLogs> Logs { get; set; }
                public class GetStackResponseBodyLogResourceLogsLogs : TeaModel {
                    /// <summary>
                    /// <para>The content of a log entry associated with the resource.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[]</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>The list of keywords for a log entry associated with the resource.</para>
                    /// </summary>
                    [NameInMap("Keys")]
                    [Validation(Required=false)]
                    public List<string> Keys { get; set; }

                }

                /// <summary>
                /// <para>The resource name defined in the template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MyResourceCleaner</para>
                /// </summary>
                [NameInMap("ResourceName")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

            }

            /// <summary>
            /// <para>The Terraform output logs. This parameter is returned only for Terraform stacks.
            /// This parameter is returned when LogOption is not specified, or when LogOption is set to Stack or All.</para>
            /// <remarks>
            /// <para>This parameter is not returned for stacks that are running. This parameter indicates the logs of the most recent operation (creation, continued creation, update, or deletion) on the stack.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("TerraformLogs")]
            [Validation(Required=false)]
            public List<GetStackResponseBodyLogTerraformLogs> TerraformLogs { get; set; }
            public class GetStackResponseBodyLogTerraformLogs : TeaModel {
                /// <summary>
                /// <para>The name of the Terraform command that is run. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>apply</para>
                /// </description></item>
                /// <item><description><para>plan</para>
                /// </description></item>
                /// <item><description><para>destroy</para>
                /// </description></item>
                /// <item><description><para>version</para>
                /// </description></item>
                /// </list>
                /// <para>For more information about the commands, see <a href="https://www.terraform.io/cli/commands">Command</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>apply</para>
                /// </summary>
                [NameInMap("Command")]
                [Validation(Required=false)]
                public string Command { get; set; }

                /// <summary>
                /// <para>The content that is output by the current command in the current output stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Apply complete! Resources: 42 added, 0 changed, 0 destroyed.</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The output stream. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>stdout: standard output.</para>
                /// </description></item>
                /// <item><description><para>stderr: standard error.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>stdout</para>
                /// </summary>
                [NameInMap("Stream")]
                [Validation(Required=false)]
                public string Stream { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of resources on which drift detection has not been performed.</para>
        /// <remarks>
        /// <para>This parameter is returned only when the most recent drift detection on the stack was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NotCheckedStackResourceCount")]
        [Validation(Required=false)]
        public int? NotCheckedStackResourceCount { get; set; }

        /// <summary>
        /// <para>The callback URLs for receiving stack events.</para>
        /// </summary>
        [NameInMap("NotificationURLs")]
        [Validation(Required=false)]
        public List<string> NotificationURLs { get; set; }

        /// <summary>
        /// <para>The supplementary information that is returned when an error occurs during a stack operation.</para>
        /// <remarks>
        /// <para>This property is returned only in specific cases and contains at least one sub-property. For example, an error occurs when another cloud service API is called.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("OperationInfo")]
        [Validation(Required=false)]
        public GetStackResponseBodyOperationInfo OperationInfo { get; set; }
        public class GetStackResponseBodyOperationInfo : TeaModel {
            /// <summary>
            /// <para>The name of the API operation called on another cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DeleteSecurityGroup</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>The error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DependencyViolation</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The logical ID of the resource on which the operation error occurred.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EcsSecurityGroup</para>
            /// </summary>
            [NameInMap("LogicalResourceId")]
            [Validation(Required=false)]
            public string LogicalResourceId { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>There is still instance(s) in the specified security group.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The request ID of the API call to another cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>071D6166-3F6B-5C7B-A1F0-0113FBB643A8</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>The resource type on which the operation error occurred.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALIYUN::ECS::SecurityGroup</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        /// <summary>
        /// <para>The list of order IDs. This parameter is returned only when manual payment for subscription orders is configured during stack creation.</para>
        /// </summary>
        [NameInMap("OrderIds")]
        [Validation(Required=false)]
        public List<string> OrderIds { get; set; }

        /// <summary>
        /// <para>The list of stack outputs.</para>
        /// </summary>
        [NameInMap("Outputs")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Outputs { get; set; }

        /// <summary>
        /// <para>The stack parameters.</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<GetStackResponseBodyParameters> Parameters { get; set; }
        public class GetStackResponseBodyParameters : TeaModel {
            /// <summary>
            /// <para>The parameter name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALIYUN::Region</para>
            /// </summary>
            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            /// <summary>
            /// <para>The parameter value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

        /// <summary>
        /// <para>The parent stack ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4a6c9851-3b0f-4f5f-b4ca-a14bf692****</para>
        /// </summary>
        [NameInMap("ParentStackId")]
        [Validation(Required=false)]
        public string ParentStackId { get; set; }

        /// <summary>
        /// <para>The RAM role name. Resource Orchestration Service (ROS) assumes this role to create the stack and calls API operations on behalf of the user by using the credentials of the role.<br>ROS always uses this role for all operations that are performed on the stack. As long as the user has the permission to perform operations on the stack, ROS uses this role even if the user does not have the permission to use the role. This ensures that the role grants the least privilege.<br>If no value is specified, ROS uses the role that was previously associated with the stack. If no role is available, ROS uses a temporary credential generated from the user credentials.<br>The RAM role name can be up to 64 bytes in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-role</para>
        /// </summary>
        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        /// <summary>
        /// <para>The region ID of the stack. You can call <a href="https://help.aliyun.com/document_detail/131035.html">DescribeRegions</a> to query the most recent region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B288A0BE-D927-4888-B0F7-B35EF84B6E6F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazb4ph6aiy****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The resource processing progress.</para>
        /// </summary>
        [NameInMap("ResourceProgress")]
        [Validation(Required=false)]
        public GetStackResponseBodyResourceProgress ResourceProgress { get; set; }
        public class GetStackResponseBodyResourceProgress : TeaModel {
            /// <summary>
            /// <para>The number of resources that failed to be processed.</para>
            /// <remarks>
            /// <para>This parameter is returned only when ShowResourceProgress is set to EnabledIfCreateStack.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("FailedResourceCount")]
            [Validation(Required=false)]
            public int? FailedResourceCount { get; set; }

            /// <summary>
            /// <para>The number of resources that are being processed.</para>
            /// <remarks>
            /// <para>This parameter is returned only when ShowResourceProgress is set to EnabledIfCreateStack.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InProgressResourceCount")]
            [Validation(Required=false)]
            public int? InProgressResourceCount { get; set; }

            /// <summary>
            /// <para>The list of progress details for resources that are being processed.</para>
            /// <remarks>
            /// <para>This parameter is returned only when ShowResourceProgress is set to EnabledIfCreateStack.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("InProgressResourceDetails")]
            [Validation(Required=false)]
            public List<GetStackResponseBodyResourceProgressInProgressResourceDetails> InProgressResourceDetails { get; set; }
            public class GetStackResponseBodyResourceProgressInProgressResourceDetails : TeaModel {
                /// <summary>
                /// <para>The target progress value of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("ProgressTargetValue")]
                [Validation(Required=false)]
                public float? ProgressTargetValue { get; set; }

                /// <summary>
                /// <para>The current progress value of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("ProgressValue")]
                [Validation(Required=false)]
                public float? ProgressValue { get; set; }

                /// <summary>
                /// <para>The resource name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>WaitCondition</para>
                /// </summary>
                [NameInMap("ResourceName")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

                /// <summary>
                /// <para>The resource type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALIYUN::ROS::WaitCondition</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            /// <summary>
            /// <para>The number of resources that are pending processing.</para>
            /// <remarks>
            /// <para>This parameter is returned only when ShowResourceProgress is set to EnabledIfCreateStack.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("PendingResourceCount")]
            [Validation(Required=false)]
            public int? PendingResourceCount { get; set; }

            /// <summary>
            /// <para>The stack action progress percentage. Value range: 0 to 100.</para>
            /// <para>Example: During stack creation, the value starts from 0 and increases. If the creation succeeds, the value reaches 100. If the creation fails and rollback begins, the value starts from another value (100 minus the progress value when the resource creation failed) and increases. When the rollback succeeds, the value reaches 100. During stack creation, this parameter indicates the progress of the creation action. During stack rollback, this parameter indicates the progress of the rollback action.</para>
            /// <remarks>
            /// <para>This parameter is returned only when ShowResourceProgress is set to PercentageOnly.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("StackActionProgress")]
            [Validation(Required=false)]
            public float? StackActionProgress { get; set; }

            /// <summary>
            /// <para>The stack operation progress percentage. Value range: 0 to 100.</para>
            /// <para>Example: During stack creation, the value starts from 0 and increases. If the creation succeeds, the value reaches 100. If the creation fails and rollback begins, the value decreases. When the rollback succeeds, the value reaches 0. This parameter indicates the overall progress of the creation operation, regardless of whether the stack status is creating or rolling back.</para>
            /// <remarks>
            /// <para>This parameter is returned only when ShowResourceProgress is set to PercentageOnly.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("StackOperationProgress")]
            [Validation(Required=false)]
            public float? StackOperationProgress { get; set; }

            /// <summary>
            /// <para>The number of resources that are successfully processed.</para>
            /// <remarks>
            /// <para>This parameter is returned only when ShowResourceProgress is set to EnabledIfCreateStack.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SuccessResourceCount")]
            [Validation(Required=false)]
            public int? SuccessResourceCount { get; set; }

            /// <summary>
            /// <para>The total number of resources.</para>
            /// <remarks>
            /// <para>This parameter is returned only when ShowResourceProgress is set to EnabledIfCreateStack.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalResourceCount")]
            [Validation(Required=false)]
            public int? TotalResourceCount { get; set; }

        }

        /// <summary>
        /// <para>When the stack status is rollback failed, this field displays the root cause of the failure in the previous phase that triggered the rollback.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Resource UPDATE failed: Exception: resources.FailToCreate: FailToCreate: reason</para>
        /// </summary>
        [NameInMap("RollbackFailedRootReason")]
        [Validation(Required=false)]
        public string RollbackFailedRootReason { get; set; }

        /// <summary>
        /// <para>The root stack ID. This parameter is returned only when the stack is a nested stack.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4a6c9851-3b0f-4f5f-b4ca-a14bf692****</para>
        /// </summary>
        [NameInMap("RootStackId")]
        [Validation(Required=false)]
        public string RootStackId { get; set; }

        /// <summary>
        /// <para>Indicates whether the stack is a managed stack. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><para>true: The stack is a managed stack.  </para>
        /// </description></item>
        /// <item><description><para>false: The stack is not a managed stack.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ServiceManaged")]
        [Validation(Required=false)]
        public bool? ServiceManaged { get; set; }

        /// <summary>
        /// <para>The service name to which the managed stack belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACVS</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <para>The drift status of the stack in the most recent successful drift detection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DRIFTED: The stack has drifted.</description></item>
        /// <item><description>NOT_CHECKED: No successful drift detection has been performed on the stack.</description></item>
        /// <item><description>IN_SYNC: The stack is in sync.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>IN_SYNC</para>
        /// </summary>
        [NameInMap("StackDriftStatus")]
        [Validation(Required=false)]
        public string StackDriftStatus { get; set; }

        /// <summary>
        /// <para>The stack ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c754d2a4-28f1-46df-b557-9586173a****</para>
        /// </summary>
        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

        /// <summary>
        /// <para>The stack name.<br>The name can be up to 255 characters in length and must start with a digit or letter. It can contain digits, letters, hyphens (-), and underscores (_).</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyStack</para>
        /// </summary>
        [NameInMap("StackName")]
        [Validation(Required=false)]
        public string StackName { get; set; }

        /// <summary>
        /// <para>The stack type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ROS: The stack uses an ROS template.</description></item>
        /// <item><description>Terraform: The stack uses a Terraform template.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ROS</para>
        /// </summary>
        [NameInMap("StackType")]
        [Validation(Required=false)]
        public string StackType { get; set; }

        /// <summary>
        /// <para>The stack status. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description>CREATE_IN_PROGRESS: The stack is being created.</description></item>
        /// <item><description>CREATE_FAILED: The stack failed to be created.</description></item>
        /// <item><description>CREATE_COMPLETE: The stack is created.</description></item>
        /// <item><description>UPDATE_IN_PROGRESS: The stack is being updated.</description></item>
        /// <item><description>UPDATE_FAILED: The stack failed to be updated.</description></item>
        /// <item><description>UPDATE_COMPLETE: The stack is updated.</description></item>
        /// <item><description>DELETE_IN_PROGRESS: The stack is being deleted.</description></item>
        /// <item><description>DELETE_FAILED: The stack failed to be deleted.</description></item>
        /// <item><description>DELETE_COMPLETE: The stack is deleted.</description></item>
        /// <item><description>CREATE_ROLLBACK_IN_PROGRESS: The stack creation is being rolled back.</description></item>
        /// <item><description>CREATE_ROLLBACK_FAILED: The stack creation failed to be rolled back.</description></item>
        /// <item><description>CREATE_ROLLBACK_COMPLETE: The stack creation is rolled back.</description></item>
        /// <item><description>ROLLBACK_IN_PROGRESS: The stack is being rolled back.</description></item>
        /// <item><description>ROLLBACK_FAILED: The stack failed to be rolled back.</description></item>
        /// <item><description>ROLLBACK_COMPLETE: The stack is rolled back.</description></item>
        /// <item><description>CHECK_IN_PROGRESS: The stack is being validated.</description></item>
        /// <item><description>CHECK_FAILED: The stack failed to be validated.</description></item>
        /// <item><description>CHECK_COMPLETE: The stack is validated.</description></item>
        /// <item><description>REVIEW_IN_PROGRESS: The stack is being reviewed.</description></item>
        /// <item><description>IMPORT_CREATE_IN_PROGRESS: The stack is being created through resource import.</description></item>
        /// <item><description>IMPORT_CREATE_FAILED: The stack failed to be created through resource import.</description></item>
        /// <item><description>IMPORT_CREATE_COMPLETE: The stack is created through resource import.</description></item>
        /// <item><description>IMPORT_CREATE_ROLLBACK_IN_PROGRESS: The stack creation through resource import is being rolled back.</description></item>
        /// <item><description>IMPORT_CREATE_ROLLBACK_FAILED: The stack creation through resource import failed to be rolled back.</description></item>
        /// <item><description>IMPORT_CREATE_ROLLBACK_COMPLETE: The stack creation through resource import is rolled back.</description></item>
        /// <item><description>IMPORT_UPDATE_IN_PROGRESS: The stack is being updated through resource import.</description></item>
        /// <item><description>IMPORT_UPDATE_FAILED: The stack failed to be updated through resource import.</description></item>
        /// <item><description>IMPORT_UPDATE_COMPLETE: The stack is updated through resource import.</description></item>
        /// <item><description>IMPORT_UPDATE_ROLLBACK_IN_PROGRESS: The stack update through resource import is being rolled back.</description></item>
        /// <item><description>IMPORT_UPDATE_ROLLBACK_FAILED: The stack update through resource import failed to be rolled back.</description></item>
        /// <item><description>IMPORT_UPDATE_ROLLBACK_COMPLETE: The stack update through resource import is rolled back.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CREATE_COMPLETE</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The reason why the stack is in its current state.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Stack CREATE completed successfully</para>
        /// </summary>
        [NameInMap("StatusReason")]
        [Validation(Required=false)]
        public string StatusReason { get; set; }

        /// <summary>
        /// <para>The tags of the stack.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetStackResponseBodyTags> Tags { get; set; }
        public class GetStackResponseBodyTags : TeaModel {
            /// <summary>
            /// <para>The tag key of the stack.</para>
            /// 
            /// <b>Example:</b>
            /// <para>usage</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the stack.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The template description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Create a VPC.</para>
        /// </summary>
        [NameInMap("TemplateDescription")]
        [Validation(Required=false)]
        public string TemplateDescription { get; set; }

        /// <summary>
        /// <para>The template ID. This parameter is returned only when the template used by the stack is a private template or a shared template.</para>
        /// <para>If the template is a shared template, the returned value is the same as the TemplateARN of the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a52f81be-496f-4e1c-a286-8852ab54****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The resource scenario ID. This parameter is returned only when the template used by the stack is generated from a resource scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ts-7f7a704cf71c49a6****</para>
        /// </summary>
        [NameInMap("TemplateScratchId")]
        [Validation(Required=false)]
        public string TemplateScratchId { get; set; }

        /// <summary>
        /// <para>The URL of the file that contains the template body. This parameter is returned only when the template used by the stack is from a URL, including a web server (HTTP or HTTPS) or an Alibaba Cloud OSS bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://ros/template/demo</para>
        /// </summary>
        [NameInMap("TemplateURL")]
        [Validation(Required=false)]
        public string TemplateURL { get; set; }

        /// <summary>
        /// <para>The template version. This parameter is returned only when the template used by the stack is a private template or a shared template.</para>
        /// <para>If the template is a shared template, this parameter is returned only when VersionOption is set to AllVersions during sharing.</para>
        /// <para>Valid values: v1 to v100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

        /// <summary>
        /// <para>The timeout period for creating the stack. Unit: minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TimeoutInMinutes")]
        [Validation(Required=false)]
        public int? TimeoutInMinutes { get; set; }

        /// <summary>
        /// <para>The time when the stack was last updated. The time is displayed in UTC+0 and follows the ISO 8601 standard without the trailing Z. Format: YYYY-MM-DDThh:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-09-17T08:21:40</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
