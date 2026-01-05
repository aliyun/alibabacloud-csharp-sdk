// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class CreateProductVersionRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the product version is active. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The product version is active. This is the default value.</description></item>
        /// <item><description>false: The product version is inactive.</description></item>
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
        /// <para>The recommendation information. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Default: No recommendation information is provided. This is the default value.</description></item>
        /// <item><description>Recommended: the recommendation version.</description></item>
        /// <item><description>Latest: the latest version.</description></item>
        /// <item><description>Deprecated: the version that is about to be discontinued.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Default</para>
        /// </summary>
        [NameInMap("Guidance")]
        [Validation(Required=false)]
        public string Guidance { get; set; }

        /// <summary>
        /// <para>The ID of the product to which the product version belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>prod-bp18r7q127****</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// <para>The name of the product version.</para>
        /// <para>The value must be 1 to 128 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("ProductVersionName")]
        [Validation(Required=false)]
        public string ProductVersionName { get; set; }

        /// <summary>
        /// <para>The type of the product template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RosTerraformTemplate: the Terraform template that is supported by Resource Orchestration Service (ROS).</description></item>
        /// <item><description>RosStandardTemplate: the standard ROS template.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RosTerraformTemplate</para>
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

        /// <summary>
        /// <para>The URL of the template.</para>
        /// <para>For more information about how to obtain the URL of a template, see <a href="~~CreateTemplate~~">CreateTemplate</a>.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TemplateUrl")]
        [Validation(Required=false)]
        public string TemplateUrl { get; set; }

    }

}
