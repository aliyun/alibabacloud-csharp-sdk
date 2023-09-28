// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class GetProvisionedProductPlanResponseBody : TeaModel {
        /// <summary>
        /// The details of the plan.
        /// </summary>
        [NameInMap("PlanDetail")]
        [Validation(Required=false)]
        public GetProvisionedProductPlanResponseBodyPlanDetail PlanDetail { get; set; }
        public class GetProvisionedProductPlanResponseBodyPlanDetail : TeaModel {
            /// <summary>
            /// The review details of the plan.
            /// </summary>
            [NameInMap("ApprovalDetail")]
            [Validation(Required=false)]
            public GetProvisionedProductPlanResponseBodyPlanDetailApprovalDetail ApprovalDetail { get; set; }
            public class GetProvisionedProductPlanResponseBodyPlanDetailApprovalDetail : TeaModel {
                /// <summary>
                /// An array that consists of operations that are performed by the operator.
                /// </summary>
                [NameInMap("OperationRecords")]
                [Validation(Required=false)]
                public List<GetProvisionedProductPlanResponseBodyPlanDetailApprovalDetailOperationRecords> OperationRecords { get; set; }
                public class GetProvisionedProductPlanResponseBodyPlanDetailApprovalDetailOperationRecords : TeaModel {
                    /// <summary>
                    /// The operation that is performed by the operator on the plan. Valid values:
                    /// 
                    /// *   Submit: submits the plan.
                    /// *   Cancel: cancels the plan.
                    /// *   Approve: approves the plan.
                    /// *   reject: rejectes the plan.
                    /// </summary>
                    [NameInMap("ApprovalAction")]
                    [Validation(Required=false)]
                    public string ApprovalAction { get; set; }

                    /// <summary>
                    /// The review comment of the operator.
                    /// </summary>
                    [NameInMap("Comment")]
                    [Validation(Required=false)]
                    public string Comment { get; set; }

                    /// <summary>
                    /// The time when the operation was performed.
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    /// <summary>
                    /// The operator who performs operations on the plan.
                    /// </summary>
                    [NameInMap("Operator")]
                    [Validation(Required=false)]
                    public GetProvisionedProductPlanResponseBodyPlanDetailApprovalDetailOperationRecordsOperator Operator { get; set; }
                    public class GetProvisionedProductPlanResponseBodyPlanDetailApprovalDetailOperationRecordsOperator : TeaModel {
                        /// <summary>
                        /// The RAM entity ID of the operator.
                        /// </summary>
                        [NameInMap("PrincipalId")]
                        [Validation(Required=false)]
                        public string PrincipalId { get; set; }

                        /// <summary>
                        /// The RAM entity name of the operator.
                        /// </summary>
                        [NameInMap("PrincipalName")]
                        [Validation(Required=false)]
                        public string PrincipalName { get; set; }

                        /// <summary>
                        /// The RAM entity type of the operator. Valid values:
                        /// 
                        /// *   RamUser: a RAM user
                        /// *   RamRole: a RAM role
                        /// </summary>
                        [NameInMap("PrincipalType")]
                        [Validation(Required=false)]
                        public string PrincipalType { get; set; }

                    }

                }

                /// <summary>
                /// An array that consists of operations that are being performed by the plan.
                /// </summary>
                [NameInMap("TodoTaskActivities")]
                [Validation(Required=false)]
                public List<GetProvisionedProductPlanResponseBodyPlanDetailApprovalDetailTodoTaskActivities> TodoTaskActivities { get; set; }
                public class GetProvisionedProductPlanResponseBodyPlanDetailApprovalDetailTodoTaskActivities : TeaModel {
                    /// <summary>
                    /// The name of the operation that is being performed by the plan.
                    /// </summary>
                    [NameInMap("ActivityName")]
                    [Validation(Required=false)]
                    public string ActivityName { get; set; }

                    /// <summary>
                    /// An array consisting of tasks that are pending for review.
                    /// </summary>
                    [NameInMap("Tasks")]
                    [Validation(Required=false)]
                    public List<GetProvisionedProductPlanResponseBodyPlanDetailApprovalDetailTodoTaskActivitiesTasks> Tasks { get; set; }
                    public class GetProvisionedProductPlanResponseBodyPlanDetailApprovalDetailTodoTaskActivitiesTasks : TeaModel {
                        /// <summary>
                        /// The operator who performs operations on the plan.
                        /// </summary>
                        [NameInMap("Operator")]
                        [Validation(Required=false)]
                        public GetProvisionedProductPlanResponseBodyPlanDetailApprovalDetailTodoTaskActivitiesTasksOperator Operator { get; set; }
                        public class GetProvisionedProductPlanResponseBodyPlanDetailApprovalDetailTodoTaskActivitiesTasksOperator : TeaModel {
                            /// <summary>
                            /// The RAM entity name of the operator.
                            /// </summary>
                            [NameInMap("PrincipalName")]
                            [Validation(Required=false)]
                            public string PrincipalName { get; set; }

                            /// <summary>
                            /// The RAM entity type of the operator. Valid values:
                            /// 
                            /// *   RamUser: a RAM user
                            /// *   RamRole: a RAM role
                            /// </summary>
                            [NameInMap("PrincipalType")]
                            [Validation(Required=false)]
                            public string PrincipalType { get; set; }

                        }

                    }

                }

            }

            /// <summary>
            /// An array that consists of reviewers.
            /// </summary>
            [NameInMap("AssignedApprovers")]
            [Validation(Required=false)]
            public List<GetProvisionedProductPlanResponseBodyPlanDetailAssignedApprovers> AssignedApprovers { get; set; }
            public class GetProvisionedProductPlanResponseBodyPlanDetailAssignedApprovers : TeaModel {
                /// <summary>
                /// The RAM entity name of the reviewer.
                /// </summary>
                [NameInMap("PrincipalName")]
                [Validation(Required=false)]
                public string PrincipalName { get; set; }

                /// <summary>
                /// The type of the Resource Access Management (RAM) entity of the reviewer. Valid values:
                /// 
                /// *   RamUser: a RAM user
                /// *   RamRole: a RAM role
                /// </summary>
                [NameInMap("PrincipalType")]
                [Validation(Required=false)]
                public string PrincipalType { get; set; }

            }

            /// <summary>
            /// The time when the plan was created.
            /// 
            /// The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The description of the plan.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The purpose of the plan. Valid values:
            /// 
            /// *   LaunchProduct: launches the product.
            /// *   UpdateProvisionedProduct: updates the information about the product instance.
            /// *   TerminateProvisionedProduct: terminates the product instance.
            /// </summary>
            [NameInMap("OperationType")]
            [Validation(Required=false)]
            public string OperationType { get; set; }

            /// <summary>
            /// The ID of the RAM entity to which the plan belongs.
            /// </summary>
            [NameInMap("OwnerPrincipalId")]
            [Validation(Required=false)]
            public string OwnerPrincipalId { get; set; }

            /// <summary>
            /// The name of the RAM entity to which the plan belongs.
            /// </summary>
            [NameInMap("OwnerPrincipalName")]
            [Validation(Required=false)]
            public string OwnerPrincipalName { get; set; }

            /// <summary>
            /// The type of the RAM entity to which the plan belongs. Valid values:
            /// 
            /// *   RamUser: a RAM user
            /// *   RamRole: a RAM role
            /// </summary>
            [NameInMap("OwnerPrincipalType")]
            [Validation(Required=false)]
            public string OwnerPrincipalType { get; set; }

            /// <summary>
            /// An array that consists of the parameters in the template.
            /// </summary>
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public List<GetProvisionedProductPlanResponseBodyPlanDetailParameters> Parameters { get; set; }
            public class GetProvisionedProductPlanResponseBodyPlanDetailParameters : TeaModel {
                /// <summary>
                /// The name of the parameter in the template.
                /// </summary>
                [NameInMap("ParameterKey")]
                [Validation(Required=false)]
                public string ParameterKey { get; set; }

                /// <summary>
                /// The value of the parameter in the template.
                /// </summary>
                [NameInMap("ParameterValue")]
                [Validation(Required=false)]
                public string ParameterValue { get; set; }

            }

            /// <summary>
            /// The ID of the plan.
            /// </summary>
            [NameInMap("PlanId")]
            [Validation(Required=false)]
            public string PlanId { get; set; }

            /// <summary>
            /// The name of the plan.
            /// </summary>
            [NameInMap("PlanName")]
            [Validation(Required=false)]
            public string PlanName { get; set; }

            /// <summary>
            /// The type of the plan.
            /// 
            /// The value is fixed as Ros, which indicates Resource Orchestration Service (ROS).
            /// </summary>
            [NameInMap("PlanType")]
            [Validation(Required=false)]
            public string PlanType { get; set; }

            /// <summary>
            /// The ID of the product portfolio.
            /// </summary>
            [NameInMap("PortfolioId")]
            [Validation(Required=false)]
            public string PortfolioId { get; set; }

            /// <summary>
            /// The ID of the product.
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            /// <summary>
            /// The ID of the product version.
            /// </summary>
            [NameInMap("ProductVersionId")]
            [Validation(Required=false)]
            public string ProductVersionId { get; set; }

            /// <summary>
            /// The ID of the product instance.
            /// </summary>
            [NameInMap("ProvisionedProductId")]
            [Validation(Required=false)]
            public string ProvisionedProductId { get; set; }

            /// <summary>
            /// The name of the product instance.
            /// </summary>
            [NameInMap("ProvisionedProductName")]
            [Validation(Required=false)]
            public string ProvisionedProductName { get; set; }

            /// <summary>
            /// The ID of the ROS stack.
            /// </summary>
            [NameInMap("StackId")]
            [Validation(Required=false)]
            public string StackId { get; set; }

            /// <summary>
            /// The ID of the region to which the ROS stack belongs.
            /// </summary>
            [NameInMap("StackRegionId")]
            [Validation(Required=false)]
            public string StackRegionId { get; set; }

            /// <summary>
            /// The state of the plan. Valid values:
            /// 
            /// *   PreviewInProgress: The plan is being prechecked.
            /// *   PreviewSuccess: The precheck is successful.
            /// *   PreviewFailed: The precheck fails.
            /// *   ExecuteInProgress: The plan is being run.
            /// *   ExecuteSuccess: The plan is run.
            /// *   ExecuteFailed: The plan fails to be run.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The message returned for the state.
            /// 
            /// > This parameter is returned only when PreviewFailed or ExecuteFailed is returned for Status.
            /// </summary>
            [NameInMap("StatusMessage")]
            [Validation(Required=false)]
            public string StatusMessage { get; set; }

            /// <summary>
            /// An array that consists of custom tags.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetProvisionedProductPlanResponseBodyPlanDetailTags> Tags { get; set; }
            public class GetProvisionedProductPlanResponseBodyPlanDetailTags : TeaModel {
                /// <summary>
                /// The key of the custom tag.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The value of the custom tag.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The ID of the Alibaba Cloud account to which the plan belongs.
            /// </summary>
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

            /// <summary>
            /// The last time when the task was modified.
            /// 
            /// The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// The details of the product.
        /// </summary>
        [NameInMap("ProductDetail")]
        [Validation(Required=false)]
        public GetProvisionedProductPlanResponseBodyProductDetail ProductDetail { get; set; }
        public class GetProvisionedProductPlanResponseBodyProductDetail : TeaModel {
            /// <summary>
            /// The creation time.
            /// 
            /// The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The description of the product.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The Alibaba Cloud Resource Name (ARN) of the product.
            /// </summary>
            [NameInMap("ProductArn")]
            [Validation(Required=false)]
            public string ProductArn { get; set; }

            /// <summary>
            /// The ID of the product.
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            /// <summary>
            /// The name of the product.
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// The type of the product.
            /// 
            /// The value is fixed as Ros, which indicates ROS.
            /// </summary>
            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            /// <summary>
            /// The provider of the product.
            /// </summary>
            [NameInMap("ProviderName")]
            [Validation(Required=false)]
            public string ProviderName { get; set; }

        }

        /// <summary>
        /// The details of the product version.
        /// </summary>
        [NameInMap("ProductVersionDetail")]
        [Validation(Required=false)]
        public GetProvisionedProductPlanResponseBodyProductVersionDetail ProductVersionDetail { get; set; }
        public class GetProvisionedProductPlanResponseBodyProductVersionDetail : TeaModel {
            /// <summary>
            /// Indicates whether the product version is visible to end users. Valid values:
            /// 
            /// *   true (defaut)
            /// *   false
            /// </summary>
            [NameInMap("Active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }

            /// <summary>
            /// The time when the product version was created.
            /// 
            /// The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The description of the product version.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The recommendation information. Valid values:
            /// 
            /// *   Default: No recommendation information is provided. This is the default value.
            /// *   Recommended: the recommendation version.
            /// *   Latest: the latest version.
            /// *   Deprecated: the version that is about to be deprecated.
            /// </summary>
            [NameInMap("Guidance")]
            [Validation(Required=false)]
            public string Guidance { get; set; }

            /// <summary>
            /// The ID of the product to which the product version belongs.
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            /// <summary>
            /// The ID of the product version.
            /// </summary>
            [NameInMap("ProductVersionId")]
            [Validation(Required=false)]
            public string ProductVersionId { get; set; }

            /// <summary>
            /// The name for the version of the product.
            /// </summary>
            [NameInMap("ProductVersionName")]
            [Validation(Required=false)]
            public string ProductVersionName { get; set; }

            /// <summary>
            /// The type of the template.
            /// 
            /// The value is fixed as RosTerraformTemplate, which indicates that the Terraform template is supported by ROS.
            /// </summary>
            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

            /// <summary>
            /// The URL of the template.
            /// </summary>
            [NameInMap("TemplateUrl")]
            [Validation(Required=false)]
            public string TemplateUrl { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array that consists of the resources to be changed in the plan.
        /// </summary>
        [NameInMap("ResourceChanges")]
        [Validation(Required=false)]
        public List<GetProvisionedProductPlanResponseBodyResourceChanges> ResourceChanges { get; set; }
        public class GetProvisionedProductPlanResponseBodyResourceChanges : TeaModel {
            /// <summary>
            /// The action that is performed on the resource. Valid values:
            /// 
            /// *   Add
            /// *   Modify
            /// *   Remove
            /// *   None
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// The logical ID of the resource.
            /// </summary>
            [NameInMap("LogicalResourceId")]
            [Validation(Required=false)]
            public string LogicalResourceId { get; set; }

            /// <summary>
            /// The physical ID of the resource.
            /// 
            /// > This parameter is returned only when Action is set to Modify or Remove.
            /// </summary>
            [NameInMap("PhysicalResourceId")]
            [Validation(Required=false)]
            public string PhysicalResourceId { get; set; }

            /// <summary>
            /// Indicates whether a replacement update is performed on the template. Valid values:
            /// 
            /// *   True: A replacement update is performed on the template.
            /// *   False: A change is made on the template.
            /// *   Conditional: A replacement update may be performed on the template. You can check whether a replacement update is performed when the template is in use.
            /// 
            /// > This parameter is returned only when Action is set to Modify.
            /// </summary>
            [NameInMap("Replacement")]
            [Validation(Required=false)]
            public string Replacement { get; set; }

            /// <summary>
            /// The type of the resource.
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

    }

}
