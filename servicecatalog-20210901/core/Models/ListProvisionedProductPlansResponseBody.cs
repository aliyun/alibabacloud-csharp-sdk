// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class ListProvisionedProductPlansResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// <para>Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// <para>Valid values: 1 to 100. Minimum value: 1. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>An array that consists of plans.</para>
        /// </summary>
        [NameInMap("PlanDetails")]
        [Validation(Required=false)]
        public List<ListProvisionedProductPlansResponseBodyPlanDetails> PlanDetails { get; set; }
        public class ListProvisionedProductPlansResponseBodyPlanDetails : TeaModel {
            /// <summary>
            /// <para>An array that consists of reviewers.</para>
            /// </summary>
            [NameInMap("AssignedApprovers")]
            [Validation(Required=false)]
            public List<ListProvisionedProductPlansResponseBodyPlanDetailsAssignedApprovers> AssignedApprovers { get; set; }
            public class ListProvisionedProductPlansResponseBodyPlanDetailsAssignedApprovers : TeaModel {
                /// <summary>
                /// <para>The RAM entity name of the reviewer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>endUser</para>
                /// </summary>
                [NameInMap("PrincipalName")]
                [Validation(Required=false)]
                public string PrincipalName { get; set; }

                /// <summary>
                /// <para>The type of the RAM entity of the reviewer. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>RamUser: a RAM user</description></item>
                /// <item><description>RamRole: a RAM role</description></item>
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
            /// <para>2022-09-13T02:01:22Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>For development team.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The purpose of the plan. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>LaunchProduct: launches the product. This is the default value.</description></item>
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
            /// <para>24477111603637****</para>
            /// </summary>
            [NameInMap("OwnerPrincipalId")]
            [Validation(Required=false)]
            public string OwnerPrincipalId { get; set; }

            /// <summary>
            /// <para>The name of the RAM entity to which the plan belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enduser</para>
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
            public List<ListProvisionedProductPlansResponseBodyPlanDetailsParameters> Parameters { get; set; }
            public class ListProvisionedProductPlansResponseBodyPlanDetailsParameters : TeaModel {
                /// <summary>
                /// <para>The name of the parameter in the template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>role_name</para>
                /// </summary>
                [NameInMap("ParameterKey")]
                [Validation(Required=false)]
                public string ParameterKey { get; set; }

                /// <summary>
                /// <para>The value of the parameter in the template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test-8</para>
                /// </summary>
                [NameInMap("ParameterValue")]
                [Validation(Required=false)]
                public string ParameterValue { get; set; }

            }

            /// <summary>
            /// <para>The ID of the plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>plan-bp18mmdh2u****</para>
            /// </summary>
            [NameInMap("PlanId")]
            [Validation(Required=false)]
            public string PlanId { get; set; }

            /// <summary>
            /// <para>The name of the plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEMO-Create an ECS instance-637\<em>\</em>\<em>\</em></para>
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
            /// <para>port-bp1438kf2j****</para>
            /// </summary>
            [NameInMap("PortfolioId")]
            [Validation(Required=false)]
            public string PortfolioId { get; set; }

            /// <summary>
            /// <para>The ID of the product.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prod-bp1rtrnh2c****</para>
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            /// <summary>
            /// <para>The name of the product.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Create an ECS instance</para>
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// <para>The ID of the product version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pv-bp19udk22v****</para>
            /// </summary>
            [NameInMap("ProductVersionId")]
            [Validation(Required=false)]
            public string ProductVersionId { get; set; }

            /// <summary>
            /// <para>The ID of the product instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pp-bp1c35162d****</para>
            /// </summary>
            [NameInMap("ProvisionedProductId")]
            [Validation(Required=false)]
            public string ProvisionedProductId { get; set; }

            /// <summary>
            /// <para>The name of the product instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rds-MYSQL-875****</para>
            /// </summary>
            [NameInMap("ProvisionedProductName")]
            [Validation(Required=false)]
            public string ProvisionedProductName { get; set; }

            /// <summary>
            /// <para>The ID of the ROS stack.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2599090a-309e-4306-b989-17ba66a9****</para>
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
            /// <item><description>ApplicationInProgress: The plan is being reviewed.</description></item>
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
            /// <para>This parameter is returned only when PreviewFailed or ExecuteFailed is returned for the Status parameter.</para>
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
            public List<ListProvisionedProductPlansResponseBodyPlanDetailsTags> Tags { get; set; }
            public class ListProvisionedProductPlansResponseBodyPlanDetailsTags : TeaModel {
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
            /// <para>2022-07-18T06:02:35.075Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0FEEF92D-4052-5202-87D0-3D8EC16F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
