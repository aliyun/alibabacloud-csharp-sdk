// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class CreateProductVersionRequest : TeaModel {
        /// <summary>
        /// Specifies whether the product version is active. Valid values:
        /// 
        /// *   true: The product version is active. This is the default value.
        /// *   false: The product version is inactive.
        /// </summary>
        [NameInMap("Active")]
        [Validation(Required=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// The description of the product version.
        /// 
        /// The value must be 1 to 128 characters in length.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The recommendation information. Valid values:
        /// 
        /// *   Default: No recommendation information is provided. This is the default value.
        /// *   Recommended: the recommendation version.
        /// *   Latest: the latest version.
        /// *   Deprecated: the version that is about to be discontinued.
        /// </summary>
        [NameInMap("Guidance")]
        [Validation(Required=false)]
        public string Guidance { get; set; }

        /// <summary>
        /// The ID of the product to which the product version belongs.
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// The name of the product version.
        /// 
        /// The value must be 1 to 128 characters in length.
        /// </summary>
        [NameInMap("ProductVersionName")]
        [Validation(Required=false)]
        public string ProductVersionName { get; set; }

        /// <summary>
        /// The type of the template.
        /// 
        /// The value is fixed as RosTerraformTemplate, which specifies the Terraform template that is supported by Resource Orchestration Service (ROS).
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

        /// <summary>
        /// The URL of the template.
        /// 
        /// For more information about how to obtain the URL of a template, see [CreateTemplate](~~CreateTemplate~~).
        /// </summary>
        [NameInMap("TemplateUrl")]
        [Validation(Required=false)]
        public string TemplateUrl { get; set; }

    }

}
