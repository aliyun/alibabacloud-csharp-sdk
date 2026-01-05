// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class CreateProductRequest : TeaModel {
        /// <summary>
        /// <para>The description of the product.</para>
        /// <para>The value must be 1 to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The description of the product.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the product.</para>
        /// <para>The value must be 1 to 128 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DEMO-Create an ECS instance</para>
        /// </summary>
        [NameInMap("ProductName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        /// <summary>
        /// <para>The type of the product.</para>
        /// <para>Set the value to Ros, which specifies Resource Orchestration Service (ROS).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ros</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The information about the product version.</para>
        /// </summary>
        [NameInMap("ProductVersionParameters")]
        [Validation(Required=false)]
        public CreateProductRequestProductVersionParameters ProductVersionParameters { get; set; }
        public class CreateProductRequestProductVersionParameters : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable the product version. Valid values:</para>
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
            /// <para>The description of the product version.</para>
            /// <para>The value must be 1 to 128 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The description of the product version.</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The recommended product version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Default (default): No product version is recommended.</description></item>
            /// <item><description>Recommended: the stable version.</description></item>
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
            /// <para>The name of the product version.</para>
            /// <para>The value must be 1 to 128 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("ProductVersionName")]
            [Validation(Required=false)]
            public string ProductVersionName { get; set; }

            /// <summary>
            /// <para>The type of the template.</para>
            /// <para>Set the value to RosTerraformTemplate, which indicates the Terraform template that is supported by Resource Orchestration Service (ROS).</para>
            /// 
            /// <b>Example:</b>
            /// <para>RosTerraformTemplate</para>
            /// </summary>
            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

            /// <summary>
            /// <para>The URL of the template.</para>
            /// <para>To obtain the URL of a template, you can call the <a href="~~CreateTemplate~~">CreateTemplate</a> operation.</para>
            /// </summary>
            [NameInMap("TemplateUrl")]
            [Validation(Required=false)]
            public string TemplateUrl { get; set; }

        }

        /// <summary>
        /// <para>The provider of the product.</para>
        /// <para>The value must be 1 to 128 characters in length.</para>
        /// <para>This parameter is required.</para>
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
        /// <item><description>RosTerraformTemplate: the Terraform template that is supported by ROS.</description></item>
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

}
