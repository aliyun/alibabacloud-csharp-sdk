// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DeleteImagesRequest : TeaModel {
        /// <summary>
        /// Specifies whether to delete the associated template.
        /// </summary>
        [NameInMap("DeleteCascadedBundle")]
        [Validation(Required=false)]
        public bool? DeleteCascadedBundle { get; set; }

        /// <summary>
        /// The image IDs. You can specify 1 to 100 image IDs.
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public List<string> ImageId { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
