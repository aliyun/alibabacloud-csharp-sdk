// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class GetProvisionedProductResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the product instance.</para>
        /// </summary>
        [NameInMap("ProvisionedProductDetail")]
        [Validation(Required=false)]
        public GetProvisionedProductResponseBodyProvisionedProductDetail ProvisionedProductDetail { get; set; }
        public class GetProvisionedProductResponseBodyProvisionedProductDetail : TeaModel {
            /// <summary>
            /// <para>The time when the product instance was created.</para>
            /// <para>The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-05-23T09:46:27Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the task that was last run on the product instance.</para>
            /// <para>The task can be one of the following types:</para>
            /// <list type="bullet">
            /// <item><description>LaunchProduct: a task that launches the product.</description></item>
            /// <item><description>UpdateProvisionedProduct: a task that updates the information about the product instance.</description></item>
            /// <item><description>TerminateProvisionedProduct: a task that terminates the product instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>task-bp1dmg242c****</para>
            /// </summary>
            [NameInMap("LastProvisioningTaskId")]
            [Validation(Required=false)]
            public string LastProvisioningTaskId { get; set; }

            /// <summary>
            /// <para>The ID of the last task that was successfully run on the product instance.</para>
            /// <para>The task can be one of the following types:</para>
            /// <list type="bullet">
            /// <item><description>LaunchProduct: a task that launches the product.</description></item>
            /// <item><description>UpdateProvisionedProduct: a task that updates the information about the product instance.</description></item>
            /// <item><description>TerminateProvisionedProduct: a task that terminates the product instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>task-bp1dmg242c****</para>
            /// </summary>
            [NameInMap("LastSuccessfulProvisioningTaskId")]
            [Validation(Required=false)]
            public string LastSuccessfulProvisioningTaskId { get; set; }

            /// <summary>
            /// <para>The ID of the task that was last run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task-bp1dmg242c****</para>
            /// </summary>
            [NameInMap("LastTaskId")]
            [Validation(Required=false)]
            public string LastTaskId { get; set; }

            /// <summary>
            /// <para>The ID of the RAM entity to which the product instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>24477111603637****</para>
            /// </summary>
            [NameInMap("OwnerPrincipalId")]
            [Validation(Required=false)]
            public string OwnerPrincipalId { get; set; }

            /// <summary>
            /// <para>The type of the Resource Access Management (RAM) entity to which the product instance belongs. Valid values:</para>
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
            /// <para>The name of the product.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEMO-Create an ECS instance</para>
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

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
            /// <para>The name of the product version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("ProductVersionName")]
            [Validation(Required=false)]
            public string ProductVersionName { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud Resource Name (ARN) of the product instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:servicecatalog:cn-hangzhou:146611588617****:provisionedproduct/pp-bp1ddg1n2a****</para>
            /// </summary>
            [NameInMap("ProvisionedProductArn")]
            [Validation(Required=false)]
            public string ProvisionedProductArn { get; set; }

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
            /// <para>The type of the product instance.</para>
            /// <para>The value is fixed as RosStack, which indicates an ROS stack.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RosStack</para>
            /// </summary>
            [NameInMap("ProvisionedProductType")]
            [Validation(Required=false)]
            public string ProvisionedProductType { get; set; }

            /// <summary>
            /// <para>The ID of the Resource Orchestration Service (ROS) stack.</para>
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
            /// <para>The state of the product instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Available: The product instance was available.</description></item>
            /// <item><description>UnderChange: The information about the product instance was being changed.</description></item>
            /// <item><description>Error: An exception occurred on the product instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The message that is returned for the status of the product instance.</para>
            /// <remarks>
            /// <para>This parameter is returned only when Error is returned for the Status parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Resource CREATE failed: terraform stack sc-146611588617****-pp-bp1ddg1n2a**** failure...</para>
            /// </summary>
            [NameInMap("StatusMessage")]
            [Validation(Required=false)]
            public string StatusMessage { get; set; }

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

    }

}
