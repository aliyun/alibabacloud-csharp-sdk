// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class CreateProvisionedProductPlanRequest : TeaModel {
        /// <summary>
        /// <para>The description of the plan.</para>
        /// <para>The value must be 1 to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Create an ECS instance.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The type of the operation that you want the plan to perform. Valid values:</para>
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
        /// <para>An array that consists of the parameters in the template.</para>
        /// <para>You can specify up to 200 parameters.</para>
        /// <remarks>
        /// <para>If you specify Parameters, you must specify ParameterKey and ParameterValue.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<CreateProvisionedProductPlanRequestParameters> Parameters { get; set; }
        public class CreateProvisionedProductPlanRequestParameters : TeaModel {
            /// <summary>
            /// <para>The name of the parameter in the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instance_type</para>
            /// </summary>
            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            /// <summary>
            /// <para>The value of the parameter in the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.s6-c1m1.small</para>
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

        /// <summary>
        /// <para>The plan name.</para>
        /// <para>The value must be 1 to 128 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DEMO-ECS instance</para>
        /// </summary>
        [NameInMap("PlanName")]
        [Validation(Required=false)]
        public string PlanName { get; set; }

        /// <summary>
        /// <para>The plan type.</para>
        /// <para>Set the value to Ros, which specifies Resource Orchestration Service (ROS).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ros</para>
        /// </summary>
        [NameInMap("PlanType")]
        [Validation(Required=false)]
        public string PlanType { get; set; }

        /// <summary>
        /// <para>The product portfolio ID.</para>
        /// <remarks>
        /// <para>If PortfolioId is not required, you do not need to specify PortfolioId. If PortfolioId is required, you must specify PortfolioId. For more information about how to obtain the value of PortfolioId, see <a href="~~ListLaunchOptions~~">ListLaunchOptions</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>port-bp1yt7582g****</para>
        /// </summary>
        [NameInMap("PortfolioId")]
        [Validation(Required=false)]
        public string PortfolioId { get; set; }

        /// <summary>
        /// <para>The product ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>prod-bp18r7q127****</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// <para>The product version ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pv-bp15e79d26****</para>
        /// </summary>
        [NameInMap("ProductVersionId")]
        [Validation(Required=false)]
        public string ProductVersionId { get; set; }

        /// <summary>
        /// <para>The product instance name.</para>
        /// <para>The value must be 1 to 128 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DEMO-ECS instance</para>
        /// </summary>
        [NameInMap("ProvisionedProductName")]
        [Validation(Required=false)]
        public string ProvisionedProductName { get; set; }

        /// <summary>
        /// <para>The ID of the region to which the ROS stack belongs.</para>
        /// <para>For more information about how to obtain the regions that are supported by ROS, see <a href="https://help.aliyun.com/document_detail/131035.html">DescribeRegions</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("StackRegionId")]
        [Validation(Required=false)]
        public string StackRegionId { get; set; }

        /// <summary>
        /// <para>An array that consists of custom tags.</para>
        /// <para>Maximum value of N: 20.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If you specify Tags, you must specify Tags.N.Key and Tags.N.Value.</description></item>
        /// <item><description>The tag of a stack is propagated to each resource that supports the tag feature in the stack.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateProvisionedProductPlanRequestTags> Tags { get; set; }
        public class CreateProvisionedProductPlanRequestTags : TeaModel {
            /// <summary>
            /// <para>The key of the custom tag.</para>
            /// <para>The key can be up to 128 characters in length, and cannot start with <c>acs:</c> or <c>aliyun</c>. The tag key cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the custom tag.</para>
            /// <para>The value can be up to 128 characters in length, and cannot start with <c>acs:</c>. The tag value cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
