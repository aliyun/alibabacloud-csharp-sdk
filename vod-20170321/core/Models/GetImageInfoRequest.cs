// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetImageInfoRequest : TeaModel {
        /// <summary>
        /// The validity period of the image URL. Unit: seconds.
        /// 
        /// > *   If the OutputType parameter is set to **cdn**:
        /// >     *   The image URL has a validity period only if URL signing is enabled. Otherwise, the image URL is permanently valid.
        /// >     *   Minimum value: **1**.
        /// >     *   Maximum value: unlimited.
        /// >     *   Default value: If you do not set this parameter, the default validity period that is specified in URL signing is used.
        /// > *   If the OutputType parameter is set to **oss**:
        /// >     *   The image URL has a validity period only if the permissions on the Object Storage Service (OSS) bucket are private. Otherwise, the image URL is permanently valid.
        /// >     *   Minimum value: **1**.
        /// >     *   Maximum value: **2592000** (30 days). The maximum value is limited to reduce security risks of the origin.
        /// >     *   Default value: If you do not set this parameter, the default value is **3600**.
        /// </summary>
        [NameInMap("AuthTimeout")]
        [Validation(Required=false)]
        public long? AuthTimeout { get; set; }

        /// <summary>
        /// The ID of the image.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// The type of the image URL. Valid values:
        /// 
        /// *   **oss**: OSS URL
        /// *   **cdn** (default): Content Delivery Network (CDN) URL
        /// </summary>
        [NameInMap("OutputType")]
        [Validation(Required=false)]
        public string OutputType { get; set; }

    }

}
