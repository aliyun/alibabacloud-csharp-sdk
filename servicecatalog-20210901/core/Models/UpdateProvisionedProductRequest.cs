// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class UpdateProvisionedProductRequest : TeaModel {
        /// <summary>
        /// <para>The input parameters of the template.</para>
        /// <para>You can specify up to 200 parameters.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is optional. If you specify the Parameters parameter, you must specify the ParameterKey and ParameterValue parameters.</description></item>
        /// <item><description>If the values of the ProductVersionId and Parameters parameters are not changed, you are not allowed to update the information about the product instance.</description></item>
        /// </list>
        /// </remarks>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<UpdateProvisionedProductRequestParameters> Parameters { get; set; }
        public class UpdateProvisionedProductRequestParameters : TeaModel {
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
        /// <para>The ID of the product portfolio.</para>
        /// <remarks>
        /// <para>The PortfolioId parameter is not required if the default launch option exists. The PortfolioId parameter is required if the default launch option does not exist. For more information about how to obtain the value of the PortfolioId parameter, see <a href="~~ListLaunchOptions~~">ListLaunchOptions</a>.</para>
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
        /// <remarks>
        /// <para>If the values of the ProductVersionId and Parameters parameters are not changed, the information about the product instance cannot be updated.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pv-bp15e79d26****</para>
        /// </summary>
        [NameInMap("ProductVersionId")]
        [Validation(Required=false)]
        public string ProductVersionId { get; set; }

        /// <summary>
        /// <para>The ID of the product instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pp-bp1ddg1n2a****</para>
        /// </summary>
        [NameInMap("ProvisionedProductId")]
        [Validation(Required=false)]
        public string ProvisionedProductId { get; set; }

        /// <summary>
        /// <para>The input custom tags.</para>
        /// <para>Maximum value of N: 20.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The Tags parameter is optional. If you need to specify the Tags parameter, you must specify the Tags.N.Key and Tags.N.Value parameters.</description></item>
        /// <item><description>The tag is propagated to each stack resource that supports the tag feature.</description></item>
        /// </list>
        /// </remarks>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<UpdateProvisionedProductRequestTags> Tags { get; set; }
        public class UpdateProvisionedProductRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key of the custom tag.</para>
            /// <para>The tag key must be 1 to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>. It cannot start with <c>acs:</c> or <c>aliyun</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the custom tag.</para>
            /// <para>The tag value can be up to 128 characters in length and cannot start with <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
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
