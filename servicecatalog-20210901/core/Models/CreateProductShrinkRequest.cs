// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class CreateProductShrinkRequest : TeaModel {
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
        public string ProductVersionParametersShrink { get; set; }

        /// <summary>
        /// The provider of the product.
        /// 
        /// The value must be 1 to 128 characters in length.
        /// </summary>
        [NameInMap("ProviderName")]
        [Validation(Required=false)]
        public string ProviderName { get; set; }

        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}
