// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class CreateProductRequest : TeaModel {
        /// <summary>
        /// The description of the product.
        /// 
        /// The value must be 1 to 128 characters in length.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The name of the product.
        /// 
        /// The value must be 1 to 128 characters in length.
        /// </summary>
        [NameInMap("ProductName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        /// <summary>
        /// The type of the product.
        /// 
        /// Set the value to Ros, which specifies Resource Orchestration Service (ROS).
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// The information about the product version.
        /// </summary>
        [NameInMap("ProductVersionParameters")]
        [Validation(Required=false)]
        public CreateProductRequestProductVersionParameters ProductVersionParameters { get; set; }
        public class CreateProductRequestProductVersionParameters : TeaModel {
            /// <summary>
            /// Specifies whether to enable the product version. Valid values:
            /// 
            /// *   true: enables the product version. This is the default value.
            /// *   false: disables the product version.
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
            /// *   Recommended: the recommended version.
            /// *   Latest: the latest version.
            /// *   Deprecated: the version that is about to be discontinued.
            /// </summary>
            [NameInMap("Guidance")]
            [Validation(Required=false)]
            public string Guidance { get; set; }

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
            /// Set the value to RosTerraformTemplate, which specifies the Terraform template that is supported by ROS.
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

        /// <summary>
        /// The provider of the product.
        /// 
        /// The value must be 1 to 128 characters in length.
        /// </summary>
        [NameInMap("ProviderName")]
        [Validation(Required=false)]
        public string ProviderName { get; set; }

    }

}
