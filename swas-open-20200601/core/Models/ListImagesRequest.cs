// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class ListImagesRequest : TeaModel {
        /// <summary>
        /// The IDs of the images. The value can be a JSON array that consists of up to 50 image IDs, in the format of `["xxx", "yyy", … "zzz"]`. Separate the image IDs with commas (,).
        /// </summary>
        [NameInMap("ImageIds")]
        [Validation(Required=false)]
        public string ImageIds { get; set; }

        /// <summary>
        /// The type of the image. Valid values:
        /// 
        /// *   system
        /// *   app
        /// *   custom
        /// </summary>
        [NameInMap("ImageType")]
        [Validation(Required=false)]
        public string ImageType { get; set; }

        /// <summary>
        /// The region ID of the images. You can call the [ListRegions](~~189315~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
