// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class UpdateProductVersionRequest : TeaModel {
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
        /// The ID of the product version.
        /// </summary>
        [NameInMap("ProductVersionId")]
        [Validation(Required=false)]
        public string ProductVersionId { get; set; }

        /// <summary>
        /// The name of the product version.
        /// 
        /// The value must be 1 to 128 characters in length.
        /// </summary>
        [NameInMap("ProductVersionName")]
        [Validation(Required=false)]
        public string ProductVersionName { get; set; }

    }

}
