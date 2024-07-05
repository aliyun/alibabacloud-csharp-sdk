// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetAttachedMediaInfoRequest : TeaModel {
        /// <summary>
        /// The validity period of the URL of the auxiliary media asset. Unit: seconds.
        /// > *   If the OutputType parameter is set to **cdn**:
        /// >     *   The URL of the auxiliary media asset has a validity period only if URL signing is enabled. Otherwise, the URL of the auxiliary media asset is permanently valid.
        /// >     *   Minimum value: **1**.
        /// >     *   Maximum value: unlimited.
        /// >     *   Default value: If you do not set this parameter, the default validity period that is specified in URL signing is used.
        /// > *   If the OutputType parameter is set to **oss**:
        /// >     *   The URL of the auxiliary media asset has a validity period only if the permissions on the Object Storage Service (OSS) bucket are private. Otherwise, the URL of the auxiliary media asset is permanently valid.
        /// >     *   Minimum value: **1**.
        /// >     *   Maximum value: **2592000** (30 days). The maximum value is limited to reduce security risks of the origin.
        /// >     *   Default value: If you do not set this parameter, the default value is **3600**.
        /// </summary>
        [NameInMap("AuthTimeout")]
        [Validation(Required=false)]
        public long? AuthTimeout { get; set; }

        /// <summary>
        /// The ID of the auxiliary media asset. Separate multiple IDs with commas (,). A maximum of 20 IDs can be specified.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MediaIds")]
        [Validation(Required=false)]
        public string MediaIds { get; set; }

        /// <summary>
        /// The type of the URL of the auxiliary media asset. Valid values:
        /// *   **oss**: OSS URL
        /// *   **cdn** (default): Content Delivery Network (CDN) URL
        /// </summary>
        [NameInMap("OutputType")]
        [Validation(Required=false)]
        public string OutputType { get; set; }

    }

}
