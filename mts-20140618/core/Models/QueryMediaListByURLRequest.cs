// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryMediaListByURLRequest : TeaModel {
        /// <summary>
        /// The OSS URLs of the media files. To obtain the OSS URL of a media file, you can perform the following operations in the ApsaraVideo Media Processing (MPS) console: In the left-side navigation pane, choose **Media Management** > **Media List**. Find the media file whose OSS URL you want to view and click **Manage** in the **Actions** column. The OSS URL of the media file is displayed on the **Obtain Encoding URL** tab. Separate multiple URLs with commas (,). You can query up to 10 media files at a time.
        /// 
        /// *   The URL complies with RFC 3986 and is encoded in UTF-8, with reserved characters being percent-encoded. The value can be up to 3,200 bytes in size. For more information, see [URL encoding](https://help.aliyun.com/document_detail/423796.html).
        /// *   Only OSS HTTP URLs are supported. Alibaba Cloud CDN URLs and HTTPS URLs are not supported.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FileURLs")]
        [Validation(Required=false)]
        public string FileURLs { get; set; }

        /// <summary>
        /// Specifies whether to include media information in the returned result.
        /// 
        /// *   Valid values: true and false.
        /// 
        /// *   Default value: **false**.
        /// 
        /// > To obtain detailed information about the media files, set this parameter to true.
        /// </summary>
        [NameInMap("IncludeMediaInfo")]
        [Validation(Required=false)]
        public bool? IncludeMediaInfo { get; set; }

        /// <summary>
        /// Specifies whether to include playback information in the returned result.
        /// 
        /// *   Valid values: true and false.
        /// *   Default value: **false**.
        /// </summary>
        [NameInMap("IncludePlayList")]
        [Validation(Required=false)]
        public bool? IncludePlayList { get; set; }

        /// <summary>
        /// Specifies whether to include snapshot information in the returned result.
        /// 
        /// *   Valid values: true and false.
        /// *   Default value: **false**.
        /// </summary>
        [NameInMap("IncludeSnapshotList")]
        [Validation(Required=false)]
        public bool? IncludeSnapshotList { get; set; }

        /// <summary>
        /// Specifies whether to include summaries in the returned result.
        /// 
        /// *   Valid values: true and false.
        /// *   Default value: **false**.
        /// </summary>
        [NameInMap("IncludeSummaryList")]
        [Validation(Required=false)]
        public bool? IncludeSummaryList { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
