// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class GetProvisionedProductPlanResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the plan.</para>
        /// </summary>
        [NameInMap("PlanDetail")]
        [Validation(Required=false)]
        public GetProvisionedProductPlanResponseBodyPlanDetail PlanDetail { get; set; }
        public class GetProvisionedProductPlanResponseBodyPlanDetail : TeaModel {
            /// <summary>
            /// <para>The approval details of the plan.</para>
            /// </summary>
            [NameInMap("ApprovalDetail")]
            [Validation(Required=false)]
            public GetProvisionedProductPlanResponseBodyPlanDetailApprovalDetail ApprovalDetail { get; set; }
            public class GetProvisionedProductPlanResponseBodyPlanDetailApprovalDetail : TeaModel {
                /// <summary>
                /// <para>The operation records.</para>
                /// </summary>
                [NameInMap("OperationRecords")]
                [Validation(Required=false)]
                public List<GetProvisionedProductPlanResponseBodyPlanDetailApprovalDetailOperationRecords> OperationRecords { get; set; }
                public class GetProvisionedProductPlanResponseBodyPlanDetailApprovalDetailOperationRecords : TeaModel {
                    /// <summary>
                    /// <para>The operation that is performed by the operator on the plan. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Submit: submits the plan.</description></item>
                    /// <item><description>Cancel: cancels the plan.</description></item>
                    /// <item><description>Approve: approves the plan.</description></item>
                    /// <item><description>reject: rejectes the plan.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Approve</para>
                    /// </summary>
                    [NameInMap("ApprovalAction")]
                    [Validation(Required=false)]
                    public string ApprovalAction { get; set; }

                    /// <summary>
                    /// <para>The approval comment of the operator.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Agreed.</para>
                    /// </summary>
                    [NameInMap("Comment")]
                    [Validation(Required=false)]
                    public string Comment { get; set; }

                    /// <summary>
                    /// <para>The time when the operation was performed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2022-03-22T05:56:14Z</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    /// <summary>
                    /// <para>The RAM entities that have performed operations on the plan.</para>
                    /// </summary>
                    [NameInMap("Operator")]
                    [Validation(Required=false)]
                    public GetProvisionedProductPlanResponseBodyPlanDetailApprovalDetailOperationRecordsOperator Operator { get; set; }
                    public class GetProvisionedProductPlanResponseBodyPlanDetailApprovalDetailOperationRecordsOperator : TeaModel {
                        /// <summary>
                        /// <para>The ID of the RAM entity.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>277401963826235***</para>
                        /// </summary>
                        [NameInMap("PrincipalId")]
                        [Validation(Required=false)]
                        public string PrincipalId { get; set; }

                        /// <summary>
                        /// <para>The name RAM entity that servers as the operator.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>approver</para>
                        /// </summary>
                        [NameInMap("PrincipalName")]
                        [Validation(Required=false)]
                        public string PrincipalName { get; set; }

                        /// <summary>
                        /// <para>The type of the RAM entity. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>RamUser: a RAM user.</description></item>
                        /// <item><description>RamRole: a RAM role.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>RamUser</para>
                        /// </summary>
                        [NameInMap("PrincipalType")]
                        [Validation(Required=false)]
                        public string PrincipalType { get; set; }

                    }

                }

                /// <summary>
                /// <para>The operations that are being performed by the plan.</para>
                /// </summary>
                [NameInMap("TodoTaskActivities")]
                [Validation(Required=false)]
                public List<GetProvisionedProductPlanResponseBodyPlanDetailApprovalDetailTodoTaskActivities> TodoTaskActivities { get; set; }
                public class GetProvisionedProductPlanResponseBodyPlanDetailApprovalDetailTodoTaskActivities : TeaModel {
                    /// <summary>
                    /// <para>The name of the operation that is being performed by the plan.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ApproverNode-1</para>
                    /// </summary>
                    [NameInMap("ActivityName")]
                    [Validation(Required=false)]
                    public string ActivityName { get; set; }

                    /// <summary>
                    /// <para>The tasks that are pending for review.</para>
                    /// </summary>
                    [NameInMap("Tasks")]
                    [Validation(Required=false)]
                    public List<GetProvisionedProductPlanResponseBodyPlanDetailApprovalDetailTodoTaskActivitiesTasks> Tasks { get; set; }
                    public class GetProvisionedProductPlanResponseBodyPlanDetailApprovalDetailTodoTaskActivitiesTasks : TeaModel {
                        /// <summary>
                        /// <para>The RAM entities that can perform operations on the plan.</para>
                        /// </summary>
                        [NameInMap("Operator")]
                        [Validation(Required=false)]
                        public GetProvisionedProductPlanResponseBodyPlanDetailApprovalDetailTodoTaskActivitiesTasksOperator Operator { get; set; }
                        public class GetProvisionedProductPlanResponseBodyPlanDetailApprovalDetailTodoTaskActivitiesTasksOperator : TeaModel {
                            /// <summary>
                            /// <para>The name of the RAM entity.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>approver</para>
                            /// </summary>
                            [NameInMap("PrincipalName")]
                            [Validation(Required=false)]
                            public string PrincipalName { get; set; }

                            /// <summary>
                            /// <para>The type of the RAM entity. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>RamUser: a RAM user.</description></item>
                            /// <item><description>RamRole: a RAM role.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>RamUser</para>
                            /// </summary>
                            [NameInMap("PrincipalType")]
                            [Validation(Required=false)]
                            public string PrincipalType { get; set; }

                        }

                    }

                }

            }

            /// <summary>
            /// <para>An array that consists of reviewers.</para>
            /// </summary>
            [NameInMap("AssignedApprovers")]
            [Validation(Required=false)]
            public List<GetProvisionedProductPlanResponseBodyPlanDetailAssignedApprovers> AssignedApprovers { get; set; }
            public class GetProvisionedProductPlanResponseBodyPlanDetailAssignedApprovers : TeaModel {
                /// <summary>
                /// <para>The name of the RAM entity of the plan approver.</para>
                /// 
                /// <b>Example:</b>
                /// <para>approver</para>
                /// </summary>
                [NameInMap("PrincipalName")]
                [Validation(Required=false)]
                public string PrincipalName { get; set; }

                /// <summary>
                /// <para>The type of the Resource Access Management (RAM) entity of the plan approver. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>RamUser: a RAM user.</description></item>
                /// <item><description>RamRole: a RAM role.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>RamUser</para>
                /// </summary>
                [NameInMap("PrincipalType")]
                [Validation(Required=false)]
                public string PrincipalType { get; set; }

            }

            /// <summary>
            /// <para>The time when the plan was created.</para>
            /// <para>The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-05-23T09:46:27Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Create an ECS instance.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The purpose of the plan. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>LaunchProduct: launches the product.</description></item>
            /// <item><description>UpdateProvisionedProduct: updates the information about the product instance.</description></item>
            /// <item><description>TerminateProvisionedProduct: terminates the product instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>LaunchProduct</para>
            /// </summary>
            [NameInMap("OperationType")]
            [Validation(Required=false)]
            public string OperationType { get; set; }

            /// <summary>
            /// <para>The ID of the RAM entity to which the plan belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>27740196382623****</para>
            /// </summary>
            [NameInMap("OwnerPrincipalId")]
            [Validation(Required=false)]
            public string OwnerPrincipalId { get; set; }

            /// <summary>
            /// <para>The name of the RAM entity to which the plan belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>endUser</para>
            /// </summary>
            [NameInMap("OwnerPrincipalName")]
            [Validation(Required=false)]
            public string OwnerPrincipalName { get; set; }

            /// <summary>
            /// <para>The type of the RAM entity to which the plan belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>RamUser: a RAM user</description></item>
            /// <item><description>RamRole: a RAM role</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RamUser</para>
            /// </summary>
            [NameInMap("OwnerPrincipalType")]
            [Validation(Required=false)]
            public string OwnerPrincipalType { get; set; }

            /// <summary>
            /// <para>An array that consists of the parameters in the template.</para>
            /// </summary>
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public List<GetProvisionedProductPlanResponseBodyPlanDetailParameters> Parameters { get; set; }
            public class GetProvisionedProductPlanResponseBodyPlanDetailParameters : TeaModel {
                /// <summary>
                /// <para>The name of the input parameter for the template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>instance_type</para>
                /// </summary>
                [NameInMap("ParameterKey")]
                [Validation(Required=false)]
                public string ParameterKey { get; set; }

                /// <summary>
                /// <para>The value of the input parameter for the template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.s6-c1m1.small</para>
                /// </summary>
                [NameInMap("ParameterValue")]
                [Validation(Required=false)]
                public string ParameterValue { get; set; }

            }

            /// <summary>
            /// <para>The ID of the plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>plan-bp1jvmdk2k****</para>
            /// </summary>
            [NameInMap("PlanId")]
            [Validation(Required=false)]
            public string PlanId { get; set; }

            /// <summary>
            /// <para>The name of the plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEMO-ECS instance</para>
            /// </summary>
            [NameInMap("PlanName")]
            [Validation(Required=false)]
            public string PlanName { get; set; }

            /// <summary>
            /// <para>The type of the plan.</para>
            /// <para>The value is fixed as Ros, which indicates Resource Orchestration Service (ROS).</para>
            /// 
            /// <b>Example:</b>
            /// <para>Ros</para>
            /// </summary>
            [NameInMap("PlanType")]
            [Validation(Required=false)]
            public string PlanType { get; set; }

            /// <summary>
            /// <para>The ID of the product portfolio.</para>
            /// 
            /// <b>Example:</b>
            /// <para>port-bp1yt7582g****</para>
            /// </summary>
            [NameInMap("PortfolioId")]
            [Validation(Required=false)]
            public string PortfolioId { get; set; }

            /// <summary>
            /// <para>The ID of the product.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prod-bp18r7q127****</para>
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            /// <summary>
            /// <para>The ID of the product version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pv-bp15e79d26****</para>
            /// </summary>
            [NameInMap("ProductVersionId")]
            [Validation(Required=false)]
            public string ProductVersionId { get; set; }

            /// <summary>
            /// <para>The ID of the product instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pp-bp1ddg1n2a****</para>
            /// </summary>
            [NameInMap("ProvisionedProductId")]
            [Validation(Required=false)]
            public string ProvisionedProductId { get; set; }

            /// <summary>
            /// <para>The name of the product instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEMO-ECS instance</para>
            /// </summary>
            [NameInMap("ProvisionedProductName")]
            [Validation(Required=false)]
            public string ProvisionedProductName { get; set; }

            /// <summary>
            /// <para>The ID of the ROS stack.</para>
            /// 
            /// <b>Example:</b>
            /// <para>137e31df-3754-40b4-be2f-c793ad84****</para>
            /// </summary>
            [NameInMap("StackId")]
            [Validation(Required=false)]
            public string StackId { get; set; }

            /// <summary>
            /// <para>The ID of the region to which the ROS stack belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("StackRegionId")]
            [Validation(Required=false)]
            public string StackRegionId { get; set; }

            /// <summary>
            /// <para>The state of the plan. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PreviewInProgress: The plan is being prechecked.</description></item>
            /// <item><description>PreviewSuccess: The precheck is successful.</description></item>
            /// <item><description>PreviewFailed: The precheck fails.</description></item>
            /// <item><description>ApplicationInProgress: The plan is being approved.</description></item>
            /// <item><description>ApplicationApproved: The plan is approved.</description></item>
            /// <item><description>ApplicationRejected: The approval is rejected.</description></item>
            /// <item><description>ExecuteInProgress: The plan is being run.</description></item>
            /// <item><description>ExecuteSuccess: The plan is run.</description></item>
            /// <item><description>ExecuteFailed: The plan fails to be run.</description></item>
            /// <item><description>Canceled: The plan is canceled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PreviewSuccess</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The message returned for the state.</para>
            /// <remarks>
            /// <para>This parameter is returned only when PreviewFailed or ExecuteFailed is returned for Status.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Create stack failed: Resource CREATE failed: terraform stack sc-146611588617****-pp-bp1ddg1n2a**** failure...</para>
            /// </summary>
            [NameInMap("StatusMessage")]
            [Validation(Required=false)]
            public string StatusMessage { get; set; }

            /// <summary>
            /// <para>An array that consists of custom tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetProvisionedProductPlanResponseBodyPlanDetailTags> Tags { get; set; }
            public class GetProvisionedProductPlanResponseBodyPlanDetailTags : TeaModel {
                /// <summary>
                /// <para>The key of the custom tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>k1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the custom tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the plan belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>146611588617****</para>
            /// </summary>
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

            /// <summary>
            /// <para>The last time when the task was modified.</para>
            /// <para>The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-05-23T09:47:29Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The details of the product.</para>
        /// </summary>
        [NameInMap("ProductDetail")]
        [Validation(Required=false)]
        public GetProvisionedProductPlanResponseBodyProductDetail ProductDetail { get; set; }
        public class GetProvisionedProductPlanResponseBodyProductDetail : TeaModel {
            /// <summary>
            /// <para>The creation time.</para>
            /// <para>The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-04-12T06:10:37Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the product.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is a product description.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud Resource Name (ARN) of the product.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:servicecatalog:cn-hangzhou:146611588617****:product/prod-bp18r7q127****</para>
            /// </summary>
            [NameInMap("ProductArn")]
            [Validation(Required=false)]
            public string ProductArn { get; set; }

            /// <summary>
            /// <para>The ID of the product.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prod-bp18r7q127****</para>
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            /// <summary>
            /// <para>The name of the product.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEMO-Create an ECS instance</para>
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// <para>The type of the product.</para>
            /// <para>The value is fixed as Ros, which indicates ROS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Ros</para>
            /// </summary>
            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            /// <summary>
            /// <para>The provider of the product.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IT team</para>
            /// </summary>
            [NameInMap("ProviderName")]
            [Validation(Required=false)]
            public string ProviderName { get; set; }

        }

        /// <summary>
        /// <para>The details of the product version.</para>
        /// </summary>
        [NameInMap("ProductVersionDetail")]
        [Validation(Required=false)]
        public GetProvisionedProductPlanResponseBodyProductVersionDetail ProductVersionDetail { get; set; }
        public class GetProvisionedProductPlanResponseBodyProductVersionDetail : TeaModel {
            /// <summary>
            /// <para>Indicates whether the product version is visible to end users. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true (default)</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }

            /// <summary>
            /// <para>The time when the product version was created.</para>
            /// <para>The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-04-12T06:10:37Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the product version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The description of the product version.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The recommendation information. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Default: No recommendation information is provided. This is the default value.</description></item>
            /// <item><description>Recommended: the recommendation version.</description></item>
            /// <item><description>Latest: the latest version.</description></item>
            /// <item><description>Deprecated: the version that is about to be deprecated.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Default</para>
            /// </summary>
            [NameInMap("Guidance")]
            [Validation(Required=false)]
            public string Guidance { get; set; }

            /// <summary>
            /// <para>The ID of the product to which the product version belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prod-bp18r7q127****</para>
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            /// <summary>
            /// <para>The ID of the product version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pv-bp15e79d26****</para>
            /// </summary>
            [NameInMap("ProductVersionId")]
            [Validation(Required=false)]
            public string ProductVersionId { get; set; }

            /// <summary>
            /// <para>The name for the version of the product.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("ProductVersionName")]
            [Validation(Required=false)]
            public string ProductVersionName { get; set; }

            /// <summary>
            /// <para>The type of the template.</para>
            /// <para>The value is fixed as RosTerraformTemplate, which indicates that the Terraform template is supported by ROS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RosTerraformTemplate</para>
            /// </summary>
            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

            /// <summary>
            /// <para>The URL of the template.</para>
            /// </summary>
            [NameInMap("TemplateUrl")]
            [Validation(Required=false)]
            public string TemplateUrl { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0FEEF92D-4052-5202-87D0-3D8EC16F81BF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An array that consists of the resources to be changed in the plan.</para>
        /// </summary>
        [NameInMap("ResourceChanges")]
        [Validation(Required=false)]
        public List<GetProvisionedProductPlanResponseBodyResourceChanges> ResourceChanges { get; set; }
        public class GetProvisionedProductPlanResponseBodyResourceChanges : TeaModel {
            /// <summary>
            /// <para>The action that is performed on the resource. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Add</description></item>
            /// <item><description>Modify</description></item>
            /// <item><description>Remove</description></item>
            /// <item><description>None</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Add</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>The logical ID of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instance</para>
            /// </summary>
            [NameInMap("LogicalResourceId")]
            [Validation(Required=false)]
            public string LogicalResourceId { get; set; }

            /// <summary>
            /// <para>The physical ID of the resource.</para>
            /// <remarks>
            /// <para> This parameter is returned if the value of Action is Modify or Remove.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp13lmam3qd9q6il****</para>
            /// </summary>
            [NameInMap("PhysicalResourceId")]
            [Validation(Required=false)]
            public string PhysicalResourceId { get; set; }

            /// <summary>
            /// <para>Indicates whether a replacement update is performed on the template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>True: A replacement update is performed on the template.</description></item>
            /// <item><description>False: A change is made on the template.</description></item>
            /// <item><description>Conditional: A replacement update may be performed on the template. You can check whether a replacement update is performed when the template is in use.</description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter is returned if the value of Action is Modify.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("Replacement")]
            [Validation(Required=false)]
            public string Replacement { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alicloud_instance</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

    }

}
