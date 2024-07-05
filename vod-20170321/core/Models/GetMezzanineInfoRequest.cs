// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetMezzanineInfoRequest : TeaModel {
        /// <summary>
        /// The type of additional information. Separate multiple values with commas (,). By default, only the basic information is returned. Valid values:
        /// 
        /// *   **video**: video stream information
        /// *   **audio**: audio stream information
        /// </summary>
        [NameInMap("AdditionType")]
        [Validation(Required=false)]
        public string AdditionType { get; set; }

        /// <summary>
        /// The validity period of the mezzanine file URL. Unit: seconds. Default value: **1800**. Minimum value: **1**.
        /// 
        /// *   If the OutputType parameter is set to **cdn**:
        /// 
        ///     *   The mezzanine file URL has a validity period only if URL signing is enabled. Otherwise, the mezzanine file URL is permanently valid.
        ///     *   Minimum value: **1**.
        ///     *   Maximum Value: unlimited.
        ///     *   Default value: If you do not set this parameter, the default validity period that is specified in URL signing is used.
        /// 
        /// <!---->
        /// 
        /// *   If the OutputType parameter is set to **oss**:
        /// 
        ///     *   The mezzanine file URL has a validity period only if the permissions on the Object Storage Service (OSS) bucket are private. Otherwise, the mezzanine file URL is permanently valid.
        ///     *   Minimum value: **1**.
        ///     *   Maximum value: **2592000** (30 days). The maximum value is limited to reduce security risks of the origin.
        ///     *   Default value: If you do not set this parameter, the default value is **3600**.
        /// </summary>
        [NameInMap("AuthTimeout")]
        [Validation(Required=false)]
        public long? AuthTimeout { get; set; }

        /// <summary>
        /// The type of the mezzanine file URL. Valid values:
        /// 
        /// - **oss**: OSS URL
        /// - **cdn** (default): Content Delivery Network (CDN) URL
        /// 
        /// > If the mezzanine file is stored in a bucket of the in type, only an OSS URL is returned.
        /// </summary>
        [NameInMap("OutputType")]
        [Validation(Required=false)]
        public string OutputType { get; set; }

        /// <summary>
        /// The ID of the video.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

    }

}
