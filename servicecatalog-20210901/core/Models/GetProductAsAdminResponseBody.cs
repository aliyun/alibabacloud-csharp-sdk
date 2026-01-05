// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class GetProductAsAdminResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the product.</para>
        /// </summary>
        [NameInMap("ProductDetail")]
        [Validation(Required=false)]
        public GetProductAsAdminResponseBodyProductDetail ProductDetail { get; set; }
        public class GetProductAsAdminResponseBodyProductDetail : TeaModel {
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
            /// <para>The value is fixed as Ros, which indicates Resource Orchestration Service (ROS).</para>
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

            /// <summary>
            /// <para>The type of the product template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>RosTerraformTemplate: the Terraform template that is supported by Resource Orchestration Service (ROS).</description></item>
            /// <item><description>RosStandardTemplate: the standard ROS template.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RosTerraformTemplate</para>
            /// </summary>
            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

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
        /// <para>The tag options associated with the product.</para>
        /// </summary>
        [NameInMap("TagOptions")]
        [Validation(Required=false)]
        public List<GetProductAsAdminResponseBodyTagOptions> TagOptions { get; set; }
        public class GetProductAsAdminResponseBodyTagOptions : TeaModel {
            /// <summary>
            /// <para>Indicates whether the tag option is enabled. Valid values:</para>
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
            /// <para>The key of the tag option.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The ID of the owner of the tag option.</para>
            /// 
            /// <b>Example:</b>
            /// <para>133413081827****</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The ID of the tag option.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag-bp1q65xd3j****</para>
            /// </summary>
            [NameInMap("TagOptionId")]
            [Validation(Required=false)]
            public string TagOptionId { get; set; }

            /// <summary>
            /// <para>The value of the tag option.</para>
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
