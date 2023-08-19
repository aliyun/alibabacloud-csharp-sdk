// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetVideoListRequest : TeaModel {
        /// <summary>
        /// The ID of the category. You can use one of the following methods to obtain the category ID:
        /// 
        /// *   Log on to the [ApsaraVideo VOD console](https://vod.console.aliyun.com). In the left-side navigation pane, choose **Configuration Management** > **Media Management** > **Categories** to view the category ID.
        /// *   Obtain the value of CateId from the response to the [AddCategory](~~56401~~) operation.
        /// *   Obtain the value of CateId from the response to the [GetCategories](~~56406~~) operation.
        /// </summary>
        [NameInMap("CateId")]
        [Validation(Required=false)]
        public long? CateId { get; set; }

        /// <summary>
        /// The end of the time range to query. The end time must be later than the start time. Specify the time in the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time must be in UTC.
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
        /// The number of entries to return on each page. Default value: **10**. Maximum value: **100**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The sorting method of the results. Valid values:
        /// 
        /// *   **CreationTime:Desc** (default): The results are sorted in reverse chronological order based on the creation time.
        /// *   **CreationTime:Asc**: The results are sorted in chronological order based on the creation time.
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time must be in UTC.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The status of the video. You can specify multiple video statuses and separate them with commas (,). Valid values:
        /// 
        /// *   **Uploading**: The video is being uploaded.
        /// *   **UploadFail**: The video failed to be uploaded.
        /// *   **UploadSucc**: The video has been uploaded.
        /// *   **Transcoding**: The video is being transcoded.
        /// *   **TranscodeFail**: The video failed to be transcoded.
        /// *   **checking**: The video is being reviewed.
        /// *   **Blocked**: The video is blocked.
        /// *   **Normal**: The video is normal.
        /// *   **ProduceFail**: The video failed to be produced.
        /// 
        /// For more information about each video status, see the "Status: the status of a video" section of the [Basic data types](~~52839#section-p7c-jgy-070~~) topic.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The storage address of the media file.
        /// </summary>
        [NameInMap("StorageLocation")]
        [Validation(Required=false)]
        public string StorageLocation { get; set; }

    }

}
