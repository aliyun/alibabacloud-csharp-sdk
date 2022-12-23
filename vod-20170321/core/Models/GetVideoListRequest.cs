// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetVideoListRequest : TeaModel {
        /// <summary>
        /// The ID of the video category.
        /// </summary>
        [NameInMap("CateId")]
        [Validation(Required=false)]
        public long? CateId { get; set; }

        /// <summary>
        /// The end of the time range for querying videos based on their creation time. The end time must be later than the start time. Specify the time in the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time must be in UTC.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The number of the page to return. Default value: **1**.
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// Optional. The number of entries to return on each page. Default value: **10**. Maximum value: **100**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The method for sorting the results. Valid values:
        /// 
        /// *   **CreationTime:Desc** (default): The results are sorted in reverse chronological order based on the creation time.
        /// *   **CreationTime:Asc**: The results are sorted in chronological order based on the creation time.
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// The beginning of the time range for querying videos based on their creation time. Specify the time in the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time must be in UTC.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The status of the video. By default, you can obtain videos in all states. Separate multiple states with commas (,). Valid values:
        /// 
        /// *   **Uploading**: The video is being uploaded.
        /// *   **UploadFail**: The video fails to be uploaded.
        /// *   **UploadSucc**: The video is uploaded.
        /// *   **Transcoding**: The video is being transcoded.
        /// *   **TranscodeFail**: The video fails to be transcoded.
        /// *   **Blocked**: The video is blocked.
        /// *   **Normal**: The video can be played.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The Object Storage Service (OSS) bucket where the video file is stored.
        /// </summary>
        [NameInMap("StorageLocation")]
        [Validation(Required=false)]
        public string StorageLocation { get; set; }

    }

}
