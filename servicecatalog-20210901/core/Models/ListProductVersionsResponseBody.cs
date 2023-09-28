// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class ListProductVersionsResponseBody : TeaModel {
        /// <summary>
        /// The versions of the product.
        /// </summary>
        [NameInMap("ProductVersionDetails")]
        [Validation(Required=false)]
        public List<ListProductVersionsResponseBodyProductVersionDetails> ProductVersionDetails { get; set; }
        public class ListProductVersionsResponseBodyProductVersionDetails : TeaModel {
            /// <summary>
            /// Indicates whether the product version is enabled. Valid values:
            /// 
            /// true: The product version is enabled. This is the default value. false: The product version is disabled.
            /// </summary>
            [NameInMap("Active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }

            /// <summary>
            /// The time when the product version was created.
            /// 
            /// The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The description of the product version.
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
            /// The ID of the product to which the product version belongs.
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            /// <summary>
            /// The ID of the product version.
            /// </summary>
            [NameInMap("ProductVersionId")]
            [Validation(Required=false)]
            public string ProductVersionId { get; set; }

            /// <summary>
            /// The name of the product version.
            /// </summary>
            [NameInMap("ProductVersionName")]
            [Validation(Required=false)]
            public string ProductVersionName { get; set; }

            /// <summary>
            /// The type of the template.
            /// 
            /// The value is fixed as RosTerraformTemplate, which indicates the Terraform template that is supported by Resource Orchestration Service (ROS).
            /// </summary>
            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

            /// <summary>
            /// The URL of the template.
            /// </summary>
            [NameInMap("TemplateUrl")]
            [Validation(Required=false)]
            public string TemplateUrl { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
