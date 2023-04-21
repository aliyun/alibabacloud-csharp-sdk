// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DeleteImagesRequest : TeaModel {
        [NameInMap("DeleteCascadedBundle")]
        [Validation(Required=false)]
        public bool? DeleteCascadedBundle { get; set; }

        /// <summary>
        /// The IDs of the images that you want to delete.
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public List<string> ImageId { get; set; }

        /// <summary>
        /// The ID of the region where the images to delete are located.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
