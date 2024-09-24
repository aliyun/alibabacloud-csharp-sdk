// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetStackResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of resources on which drift detection was performed.</para>
        /// <remarks>
        /// <para> This parameter is returned only if the most recent drift detection on the stack was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CheckedStackResourceCount")]
        [Validation(Required=false)]
        public int? CheckedStackResourceCount { get; set; }

        /// <summary>
        /// <para>The time when the stack was created. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.</para>
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
        /// <item><description>Enabled: Deletion protection is enabled for the stack.</description></item>
        /// <item><description>Disabled: Deletion protection is disabled for the stack. You can delete the stack by using the ROS console or by calling the DeleteStack operation.</description></item>
        /// </list>
        /// <remarks>
        /// <para> Deletion protection of a nested stack is the same as deletion protection of its root stack.</para>
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
        /// <item><description>true</description></item>
        /// <item><description>false (default)</description></item>
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
        /// <para>The description of the console user interface (UI).</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Interface")]
        [Validation(Required=false)]
        public string Interface { get; set; }

        /// <summary>
        /// <para>The log of the stack.</para>
        /// </summary>
        [NameInMap("Log")]
        [Validation(Required=false)]
        public GetStackResponseBodyLog Log { get; set; }
        public class GetStackResponseBodyLog : TeaModel {
            /// <summary>
            /// <para>The logs of resources in the stack. This parameter is returned if LogOption is set to Resource or All.</para>
            /// <remarks>
            /// <para> The logs are returned only for resources of specific types, such as the <c>ALIYUN::ROS::ResourceCleaner</c> type.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("ResourceLogs")]
            [Validation(Required=false)]
            public List<GetStackResponseBodyLogResourceLogs> ResourceLogs { get; set; }
            public class GetStackResponseBodyLogResourceLogs : TeaModel {
                /// <summary>
                /// <para>All the logs that are associated with the resources.</para>
                /// </summary>
                [NameInMap("Logs")]
                [Validation(Required=false)]
                public List<GetStackResponseBodyLogResourceLogsLogs> Logs { get; set; }
                public class GetStackResponseBodyLogResourceLogsLogs : TeaModel {
                    /// <summary>
                    /// <para>The content of a resource log.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[]</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>The keywords of a resource log.</para>
                    /// </summary>
                    [NameInMap("Keys")]
                    [Validation(Required=false)]
                    public List<string> Keys { get; set; }

                }

                /// <summary>
                /// <para>The name of the resource that is defined in the template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MyResourceCleaner</para>
                /// </summary>
                [NameInMap("ResourceName")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

            }

            /// <summary>
            /// <para>The logs generated when the Terraform stack is run. This parameter is returned only for a Terraform stack. This parameter is returned if LogOption is left empty or set to Stack or All.</para>
            /// <remarks>
            /// <para> This parameter is not returned for a running stack. The logs are generated from the most recent operation on the stack, such as the creation, resumed creation, update, or deletion operation.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("TerraformLogs")]
            [Validation(Required=false)]
            public List<GetStackResponseBodyLogTerraformLogs> TerraformLogs { get; set; }
            public class GetStackResponseBodyLogTerraformLogs : TeaModel {
                /// <summary>
                /// <para>The name of the Terraform command that is run. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>apply</description></item>
                /// <item><description>plan</description></item>
                /// <item><description>destroy</description></item>
                /// <item><description>version</description></item>
                /// </list>
                /// <para>For more information about Terraform commands, see <a href="https://www.terraform.io/cli/commands">Basic CLI Features</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>apply</para>
                /// </summary>
                [NameInMap("Command")]
                [Validation(Required=false)]
                public string Command { get; set; }

                /// <summary>
                /// <para>The content of the output stream that is returned after the command is run.</para>
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
                /// <item><description>stdout: standard output stream</description></item>
                /// <item><description>stderr: standard error stream</description></item>
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
        /// <para>The number of resources on which drift detection was not performed.</para>
        /// <remarks>
        /// <para> This parameter is returned only if the most recent drift detection on the stack was successful.</para>
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
        /// <para>The supplementary information that is returned if an error occurs on a stack operation.</para>
        /// <remarks>
        /// <para> This parameter is returned together with at least one sub-parameter and only under specific conditions. For example, the supplementary information is returned when an API operation of another Alibaba Cloud service fails to be called.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("OperationInfo")]
        [Validation(Required=false)]
        public GetStackResponseBodyOperationInfo OperationInfo { get; set; }
        public class GetStackResponseBodyOperationInfo : TeaModel {
            /// <summary>
            /// <para>The name of the API operation that belongs to another Alibaba Cloud service.</para>
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
            /// <para>The logical ID of the resource on which the operation error occurs.</para>
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
            /// <para>The ID of the request that is initiated to call the API operation of another Alibaba Cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>071D6166-3F6B-5C7B-A1F0-0113FBB643A8</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>The type of the resource on which the operation error occurs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALIYUN::ECS::SecurityGroup</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        /// <summary>
        /// <para>The order IDs. This parameter is returned only if you configured manual payment when you created a subscription stack.</para>
        /// </summary>
        [NameInMap("OrderIds")]
        [Validation(Required=false)]
        public List<string> OrderIds { get; set; }

        /// <summary>
        /// <para>The outputs of the stack.</para>
        /// </summary>
        [NameInMap("Outputs")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Outputs { get; set; }

        /// <summary>
        /// <para>The parameters of the stack.</para>
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
        /// <para>The ID of the parent stack.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4a6c9851-3b0f-4f5f-b4ca-a14bf692****</para>
        /// </summary>
        [NameInMap("ParentStackId")]
        [Validation(Required=false)]
        public string ParentStackId { get; set; }

        /// <summary>
        /// <para>The name of the Resource Access Management (RAM) role. ROS assumes the RAM role to create the stack and uses the credentials of the role to call the APIs of Alibaba Cloud services.\
        /// ROS assumes the RAM role to perform operations on the stack. If you have permissions to perform operations on the stack, ROS assumes the RAM role even if you do not have permissions to use the RAM role. You must make sure that permissions are granted to the RAM role based on the principle of least privilege.\
        /// If this parameter is not specified, ROS uses the existing role that is associated with the stack. If no roles are available, ROS uses a temporary credential that is generated from the credentials of your account.\
        /// The RAM role name can be up to 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-role</para>
        /// </summary>
        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        /// <summary>
        /// <para>The region ID of the stack. You can call the <a href="https://help.aliyun.com/document_detail/131035.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazb4ph6aiy****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The resource creation progress.</para>
        /// </summary>
        [NameInMap("ResourceProgress")]
        [Validation(Required=false)]
        public GetStackResponseBodyResourceProgress ResourceProgress { get; set; }
        public class GetStackResponseBodyResourceProgress : TeaModel {
            /// <summary>
            /// <para>The number of resources that failed to be created.</para>
            /// <remarks>
            /// <para> This parameter is returned only if <c>ShowResourceProgress</c> is set to <c>EnabledIfCreateStack</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("FailedResourceCount")]
            [Validation(Required=false)]
            public int? FailedResourceCount { get; set; }

            /// <summary>
            /// <para>The number of resources that are being created.</para>
            /// <remarks>
            /// <para> This parameter is returned only if <c>ShowResourceProgress</c> is set to <c>EnabledIfCreateStack</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InProgressResourceCount")]
            [Validation(Required=false)]
            public int? InProgressResourceCount { get; set; }

            /// <summary>
            /// <para>The progress details of resources that are being created.</para>
            /// <remarks>
            /// <para> This parameter is returned only if <c>ShowResourceProgress</c> is set to <c>EnabledIfCreateStack</c>.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("InProgressResourceDetails")]
            [Validation(Required=false)]
            public List<GetStackResponseBodyResourceProgressInProgressResourceDetails> InProgressResourceDetails { get; set; }
            public class GetStackResponseBodyResourceProgressInProgressResourceDetails : TeaModel {
                /// <summary>
                /// <para>The desired progress value of the resource.</para>
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
            /// <para>The number of resources to be created.</para>
            /// <remarks>
            /// <para> This parameter is returned only if <c>ShowResourceProgress</c> is set to <c>EnabledIfCreateStack</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("PendingResourceCount")]
            [Validation(Required=false)]
            public int? PendingResourceCount { get; set; }

            /// <summary>
            /// <para>The creation or rollback progress of the stack, in percentage. Valid values: 0 to 100.</para>
            /// <para>The value progressively increases from 0 to 100 during a stack creation operation. If the stack is created, the value reaches 100. If the stack fails to be created, a rollback is started for the stack resources, and the value progressively increases from the percentage of the remaining progress (100 - Progress value generated when the stack fails to be created). The value increases to 100 when the stack resources are rolled back. This parameter indicates the creation progress during a stack creation operation and indicates the rollback progress during a stack rollback operation.</para>
            /// <remarks>
            /// <para> This parameter is returned only if <c>ShowResourceProgress</c> is set to <c>PercentageOnly</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("StackActionProgress")]
            [Validation(Required=false)]
            public float? StackActionProgress { get; set; }

            /// <summary>
            /// <para>The overall creation progress of the stack, in percentage. Valid values: 0 to 100.</para>
            /// <para>The value progressively increases from 0 to 100 during a stack creation operation. If the stack is created, the value reaches 100. If the stack fails to be created, a rollback is started for the stack resources, and the value progressively decreases. The value decreases to 0 when the stack resources are rolled back. This parameter indicates only the overall creation progress, regardless of whether during a stack creation or rollback operation.</para>
            /// <remarks>
            /// <para> This parameter is returned only if <c>ShowResourceProgress</c> is set to <c>PercentageOnly</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("StackOperationProgress")]
            [Validation(Required=false)]
            public float? StackOperationProgress { get; set; }

            /// <summary>
            /// <para>The number of resources that are created.</para>
            /// <remarks>
            /// <para> This parameter is returned only if <c>ShowResourceProgress</c> is set to <c>EnabledIfCreateStack</c>.</para>
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
            /// <para> This parameter is returned only if <c>ShowResourceProgress</c> is set to <c>EnabledIfCreateStack</c>.</para>
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
        /// <para>当资源栈状态为回滚失败时，该字段展示导致回滚的前一阶段执行失败的原因。</para>
        /// 
        /// <b>Example:</b>
        /// <para>Resource UPDATE failed: Exception: resources.FailToCreate: FailToCreate: reason</para>
        /// </summary>
        [NameInMap("RollbackFailedRootReason")]
        [Validation(Required=false)]
        public string RollbackFailedRootReason { get; set; }

        /// <summary>
        /// <para>The ID of the root stack. This parameter is returned if the specified stack is a nested stack.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4a6c9851-3b0f-4f5f-b4ca-a14bf692****</para>
        /// </summary>
        [NameInMap("RootStackId")]
        [Validation(Required=false)]
        public string RootStackId { get; set; }

        /// <summary>
        /// <para>Indicates whether the stack is a managed stack. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ServiceManaged")]
        [Validation(Required=false)]
        public bool? ServiceManaged { get; set; }

        /// <summary>
        /// <para>The name of the service to which the managed stack belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACVS</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <para>The state of the stack on which the most recent successful drift detection was performed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DRIFTED: The stack has drifted.</description></item>
        /// <item><description>NOT_CHECKED: No successful drift detection is performed on the stack.</description></item>
        /// <item><description>IN_SYNC: The stack is being synchronized.</description></item>
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
        /// <para>The stack name.\
        /// The name can be up to 255 characters in length, and can contain digits, letters, hyphens (-), and underscores (_). The name must start with a digit or letter.</para>
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
        /// <item><description>ROS: ROS stack. The stack is created by using a ROS template.</description></item>
        /// <item><description>Terraform: Terraform stack. The stack is created by using a Terraform template.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ROS</para>
        /// </summary>
        [NameInMap("StackType")]
        [Validation(Required=false)]
        public string StackType { get; set; }

        /// <summary>
        /// <para>The state of the stack. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CREATE_IN_PROGRESS: The stack is being created.</description></item>
        /// <item><description>CREATE_FAILED: The stack failed to be created.</description></item>
        /// <item><description>CREATE_COMPLETE: The stack is created.</description></item>
        /// <item><description>UPDATE_IN_PROGRESS: The stack is being updated.</description></item>
        /// <item><description>UPDATE_FAILED: The stack failed to be updated.</description></item>
        /// <item><description>UPDATE_COMPLETE: The stack is updated.</description></item>
        /// <item><description>DELETE_IN_PROGRESS: The stack is being deleted.</description></item>
        /// <item><description>DELETE_FAILED: The stack failed to be deleted.</description></item>
        /// <item><description>CREATE_ROLLBACK_IN_PROGRESS: The resources are being rolled back after the stack failed to be created.</description></item>
        /// <item><description>CREATE_ROLLBACK_FAILED: The resources failed to be rolled back after the stack failed to be created.</description></item>
        /// <item><description>CREATE_ROLLBACK_COMPLETE: The resources are rolled back after the stack failed to be created.</description></item>
        /// <item><description>ROLLBACK_IN_PROGRESS: The resources of the stack are being rolled back.</description></item>
        /// <item><description>ROLLBACK_FAILED: The resources of the stack failed to be rolled back.</description></item>
        /// <item><description>ROLLBACK_COMPLETE: The resources of the stack are rolled back.</description></item>
        /// <item><description>CHECK_IN_PROGRESS: The stack is being validated.</description></item>
        /// <item><description>CHECK_FAILED: The stack failed to be validated.</description></item>
        /// <item><description>CHECK_COMPLETE: The stack is validated.</description></item>
        /// <item><description>REVIEW_IN_PROGRESS: The stack is being reviewed.</description></item>
        /// <item><description>IMPORT_CREATE_IN_PROGRESS: The stack is being created by using imported resources.</description></item>
        /// <item><description>IMPORT_CREATE_FAILED: The stack failed to be created by using imported resources.</description></item>
        /// <item><description>IMPORT_CREATE_COMPLETE: The stack is created by using imported resources.</description></item>
        /// <item><description>IMPORT_CREATE_ROLLBACK_IN_PROGRESS: The resources are being rolled back after the stack failed to be created by using imported resources.</description></item>
        /// <item><description>IMPORT_CREATE_ROLLBACK_FAILED: The resources failed to be rolled back after the stack failed to be created by using imported resources.</description></item>
        /// <item><description>IMPORT_CREATE_ROLLBACK_COMPLETE: The resources are rolled back after the stack failed to be created by using imported resources.</description></item>
        /// <item><description>IMPORT_UPDATE_IN_PROGRESS: The stack is being updated by using imported resources.</description></item>
        /// <item><description>IMPORT_UPDATE_FAILED: The stack failed to be updated by using imported resources.</description></item>
        /// <item><description>IMPORT_UPDATE_COMPLETE: The stack is updated by using imported resources.</description></item>
        /// <item><description>IMPORT_UPDATE_ROLLBACK_IN_PROGRESS: The resources are being rolled back after the stack failed to be updated by using imported resources.</description></item>
        /// <item><description>IMPORT_UPDATE_ROLLBACK_FAILED: The resources failed to be rolled back after the stack failed to be updated by using imported resources.</description></item>
        /// <item><description>IMPORT_UPDATE_ROLLBACK_COMPLETE: The resources are rolled back after the stack failed to be updated by using imported resources.</description></item>
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
        /// <para>The description of the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Create a VPC.</para>
        /// </summary>
        [NameInMap("TemplateDescription")]
        [Validation(Required=false)]
        public string TemplateDescription { get; set; }

        /// <summary>
        /// <para>The template ID. This parameter is returned only if the current stack template is a custom template or shared template.</para>
        /// <para>If the template is a shared template, the value of this parameter is the same as the value of TemplateARN.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a52f81be-496f-4e1c-a286-8852ab54****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The ID of the resource scenario. This parameter is returned only if the current template of the stack is generated from a resource scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ts-7f7a704cf71c49a6****</para>
        /// </summary>
        [NameInMap("TemplateScratchId")]
        [Validation(Required=false)]
        public string TemplateScratchId { get; set; }

        /// <summary>
        /// <para>The URL of the file that contains the template body. This parameter is returned only if the current template of the stack is from a URL. The URL can point to a template that is located on an HTTP or HTTPS web server or in an Object Storage Service (OSS) bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://ros/template/demo</para>
        /// </summary>
        [NameInMap("TemplateURL")]
        [Validation(Required=false)]
        public string TemplateURL { get; set; }

        /// <summary>
        /// <para>The version of the template. This parameter is returned only if the current stack template is a custom template or shared template.</para>
        /// <para>If the template is a shared template, this parameter is returned only if VersionOption is set to AllVersions.</para>
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
        /// <para>The time when the stack was updated. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-09-17T08:21:40</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
