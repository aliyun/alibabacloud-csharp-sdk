// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListSnapshotsRequest : TeaModel {
        /// <summary>
        /// The validity period of the snapshot URL. Unit: seconds. Default value: **3600**. Minimum value: **3600**.
        /// 
        /// *   This parameter only takes effect when [URL authentication](https://help.aliyun.com/document_detail/57007.html) is enabled.
        /// *   If the specified validity period is less than **3600** seconds, the default value is **3600**.
        /// *   If an Object Storage Service (OSS) URL is returned, the maximum validity period is limited to **2592000** seconds (30 days) to reduce security risks of the origin.
        /// </summary>
        [NameInMap("AuthTimeout")]
        [Validation(Required=false)]
        public string AuthTimeout { get; set; }

        /// <summary>
        /// The number of the page to turn. Default value: **1**.
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public string PageNo { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: **20**. Maximum value: **100**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The type of snapshots that are returned. Valid values:
        /// 
        /// *   **CoverSnapshot**: thumbnail snapshot
        /// *   **NormalSnapshot**: normal snapshot
        /// *   **SpriteSnapshot**: sprite snapshot
        /// *   **SpriteOriginSnapshot**: sprite source snapshot
        /// *   **WebVttSnapshot**: WebVTT snapshot
        /// </summary>
        [NameInMap("SnapshotType")]
        [Validation(Required=false)]
        public string SnapshotType { get; set; }

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
