// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class GetProductVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the product version.</para>
        /// </summary>
        [NameInMap("ProductVersionDetail")]
        [Validation(Required=false)]
        public GetProductVersionResponseBodyProductVersionDetail ProductVersionDetail { get; set; }
        public class GetProductVersionResponseBodyProductVersionDetail : TeaModel {
            /// <summary>
            /// <para>Indicates whether the product version is visible to end users. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The product version is visible to end users. This is the default value.</description></item>
            /// <item><description>false: The product version is invisible to end users.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }

            /// <summary>
            /// <para>The time when the product version was created.</para>
            /// <para>The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-04-12T06:10:37Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the product version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The description of the product version.</para>
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
            /// <para>The ID of the product to which the product version belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prod-bp18r7q127****</para>
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

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
            /// <para>The type of the product template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>RosTerraformTemplate: The Terraform template that is supported by Resource Orchestration Service (ROS).</description></item>
            /// <item><description>RosStandardTemplate: The standard ROS template.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RosTerraformTemplate</para>
            /// </summary>
            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

            /// <summary>
            /// <para>The URL of the template.</para>
            /// </summary>
            [NameInMap("TemplateUrl")]
            [Validation(Required=false)]
            public string TemplateUrl { get; set; }

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
