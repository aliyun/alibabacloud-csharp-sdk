// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class ListProvisionedProductPlansResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// 
        /// Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// 
        /// Valid values: 1 to 100. Minimum value: 1. Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// An array that consists of plans.
        /// </summary>
        [NameInMap("PlanDetails")]
        [Validation(Required=false)]
        public List<ListProvisionedProductPlansResponseBodyPlanDetails> PlanDetails { get; set; }
        public class ListProvisionedProductPlansResponseBodyPlanDetails : TeaModel {
            /// <summary>
            /// An array that consists of reviewers.
            /// </summary>
            [NameInMap("AssignedApprovers")]
            [Validation(Required=false)]
            public List<ListProvisionedProductPlansResponseBodyPlanDetailsAssignedApprovers> AssignedApprovers { get; set; }
            public class ListProvisionedProductPlansResponseBodyPlanDetailsAssignedApprovers : TeaModel {
                /// <summary>
                /// The RAM entity name of the reviewer.
                /// </summary>
                [NameInMap("PrincipalName")]
                [Validation(Required=false)]
                public string PrincipalName { get; set; }

                /// <summary>
                /// The type of the RAM entity of the reviewer. Valid values:
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
            /// *   LaunchProduct: launches the product. This is the default value.
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
            public List<ListProvisionedProductPlansResponseBodyPlanDetailsParameters> Parameters { get; set; }
            public class ListProvisionedProductPlansResponseBodyPlanDetailsParameters : TeaModel {
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
            /// The name of the product.
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

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
            /// *   ApplicationInProgress: The plan is being reviewed.
            /// *   ApplicationApproved: The plan is approved.
            /// *   ApplicationRejected: The approval is rejected.
            /// *   ExecuteInProgress: The plan is being run.
            /// *   ExecuteSuccess: The plan is run.
            /// *   ExecuteFailed: The plan fails to be run.
            /// *   Canceled: The plan is canceled.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The message returned for the state.
            /// 
            /// > This parameter is returned only when PreviewFailed or ExecuteFailed is returned for the Status parameter.
            /// </summary>
            [NameInMap("StatusMessage")]
            [Validation(Required=false)]
            public string StatusMessage { get; set; }

            /// <summary>
            /// An array that consists of custom tags.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListProvisionedProductPlansResponseBodyPlanDetailsTags> Tags { get; set; }
            public class ListProvisionedProductPlansResponseBodyPlanDetailsTags : TeaModel {
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
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
