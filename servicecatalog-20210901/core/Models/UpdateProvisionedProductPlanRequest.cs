// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class UpdateProvisionedProductPlanRequest : TeaModel {
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
        /// <para>An array that consists of the parameters in the template.</para>
        /// <para>Maximum value of N: 200.</para>
        /// <remarks>
        /// <para>If you specify Parameters, you must specify ParameterKey and ParameterValue.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<UpdateProvisionedProductPlanRequestParameters> Parameters { get; set; }
        public class UpdateProvisionedProductPlanRequestParameters : TeaModel {
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
        /// <para>The ID of the plan.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>plan-bp1jvmdk2k****</para>
        /// </summary>
        [NameInMap("PlanId")]
        [Validation(Required=false)]
        public string PlanId { get; set; }

        /// <summary>
        /// <para>The ID of the product portfolio.</para>
        /// <remarks>
        /// <para>If the default launch option exists, you do not need to specify PortfolioId. If the default launch option does not exist, you must specify PortfolioId. For more information about how to obtain the value of PortfolioId, see <a href="~~ListLaunchOptions~~">ListLaunchOptions</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>port-bp1yt7582g****</para>
        /// </summary>
        [NameInMap("PortfolioId")]
        [Validation(Required=false)]
        public string PortfolioId { get; set; }

        /// <summary>
        /// <para>The ID of the product.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>prod-bp18r7q127****</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// <para>The ID of the product version.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pv-bp15e79d26****</para>
        /// </summary>
        [NameInMap("ProductVersionId")]
        [Validation(Required=false)]
        public string ProductVersionId { get; set; }

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
        public List<UpdateProvisionedProductPlanRequestTags> Tags { get; set; }
        public class UpdateProvisionedProductPlanRequestTags : TeaModel {
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
