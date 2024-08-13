// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetAttachedMediaInfoRequest : TeaModel {
        /// <summary>
        /// The validity period of the URL. Unit: seconds.
        /// 
        /// *   If you set the OutputType parameter to **cdn**:
        /// 
        ///     *   The URL of the auxiliary media asset has a validity period only if URL signing is enabled. Otherwise, the URL of the auxiliary media asset is permanently valid.
        ///     *   Minimum value: **1**.
        ///     *   Maximum value: unlimited.
        ///     *   Default value: If you do not set this parameter, the default validity period that is specified in URL signing is used.
        /// 
        /// *   If you set the OutputType parameter to **oss**:
        /// 
        ///     *   The URL of the auxiliary media asset has a validity period only if the permissions on the Object Storage Service (OSS) bucket are private. Otherwise, the URL of the auxiliary media asset is permanently valid.
        ///     *   Minimum value: **1**.
        ///     *   The maximum value for a media asset stored in the VOD bucket is **2592000** (30 days) and the maximum value for a media asset stored in an OSS bucket is **129600** (36 hours). The maximum value is limited to reduce security risks of the origin.
        ///     *   Default value: If you do not set this parameter, the default value **3600** is used.
        /// </summary>
        [NameInMap("AuthTimeout")]
        [Validation(Required=false)]
        public long? AuthTimeout { get; set; }

        /// <summary>
        /// The ID of the auxiliary media asset.
        /// 
        /// *   Separate multiple IDs with commas (,). You can specify up to 20 IDs.
        /// *   You can obtain the ID from the response to the [CreateUploadAttachedMedia](~~CreateUploadAttachedMedia~~) operation that you call to obtain the upload URL and credential.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MediaIds")]
        [Validation(Required=false)]
        public string MediaIds { get; set; }

        /// <summary>
        /// The type of the media asset URL. Valid values:
        /// 
        /// *   **oss**
        /// *   **cdn** (default)
        /// </summary>
        [NameInMap("OutputType")]
        [Validation(Required=false)]
        public string OutputType { get; set; }

    }

}
