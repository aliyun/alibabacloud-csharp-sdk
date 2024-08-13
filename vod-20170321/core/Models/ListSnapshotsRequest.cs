// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListSnapshotsRequest : TeaModel {
        /// <summary>
        /// The validity period of the snapshot URL. Default value: **3600**. Minimum value: **3600**. Unit: seconds.
        /// 
        /// *   This parameter takes effect only when you enable URL signing. For more information, see [Configure URL signing](https://help.aliyun.com/document_detail/57007.html).
        /// *   If you specify a value smaller than **3,600 seconds**, **3600** is used by default.
        /// *   If the snapshot URL is an Object Storage Service (OSS) URL, the maximum value for this parameter is **2592000** (30 days). This reduces risks on the origin.
        /// </summary>
        [NameInMap("AuthTimeout")]
        [Validation(Required=false)]
        public string AuthTimeout { get; set; }

        /// <summary>
        /// The page number. Default value: **1**.
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public string PageNo { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: **20**. Maximum value: **100**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The type of snapshots to return. Valid values:
        /// 
        /// *   **CoverSnapshot**: thumbnail snapshot
        /// *   **NormalSnapshot**: regular snapshot
        /// *   **SpriteSnapshot**: sprite snapshot
        /// *   **SpriteOriginSnapshot**: sprite source snapshot
        /// *   **WebVttSnapshot**: WebVTT snapshot
        /// </summary>
        [NameInMap("SnapshotType")]
        [Validation(Required=false)]
        public string SnapshotType { get; set; }

        /// <summary>
        /// The ID of the video. You can use one of the following methods to obtain the ID:
        /// 
        /// *   Log on to the [ApsaraVideo VOD console](https://vod.console.aliyun.com). In the left-side navigation pane, choose **Media Files** > **Audio/Video** to view the video ID.
        /// *   Obtain the video ID from the response to the [CreateUploadVideo](~~CreateUploadVideo~~) operation that you call to obtain the upload URL and credential.
        /// *   Obtain the video ID from the response to the [SearchMedia](~~SearchMedia~~) operation that you call to query videos.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

    }

}
