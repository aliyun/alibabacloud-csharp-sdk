// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class LaunchProductRequest : TeaModel {
        /// <summary>
        /// <para>The input parameters of the template.</para>
        /// <para>You can specify up to 200 parameters.</para>
        /// <remarks>
        /// <para>This parameter is optional. If you specify the Parameters parameter, you must specify the ParameterKey and ParameterValue parameters.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<LaunchProductRequestParameters> Parameters { get; set; }
        public class LaunchProductRequestParameters : TeaModel {
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
        /// <para>If the PortfolioId parameter is not required, you do not need to specify the PortfolioId parameter. If the PortfolioId parameter is required, you must specify the PortfolioId parameter. For more information about how to obtain the value of the PortfolioId parameter, see <a href="~~ListLaunchOptions~~">ListLaunchOptions</a>.</para>
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
        /// <para>The name of the product instance.</para>
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
        /// <para>The ID of the region to which the Resource Orchestration Service (ROS) stack belongs.</para>
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
        /// <para>The custom tags that are specified by the end user.</para>
        /// <para>Maximum value of N: 20.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>The Tags parameter is optional. If you specify the Tags parameter, you must specify the Tags.N.Key and Tags.N.Value parameters.</para>
        /// </description></item>
        /// <item><description><para>The tag is propagated to each stack resource that supports the tag feature.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<LaunchProductRequestTags> Tags { get; set; }
        public class LaunchProductRequestTags : TeaModel {
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
