// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListLiveRecordVideoRequest : TeaModel {
        /// <summary>
        /// The sorting rule of results. Valid values:
        /// 
        /// *   **CreationTime:Desc**: sorts the results based on the creation time in descending order. This is the default value.
        /// *   **CreationTime:Asc**: sorts the results based on the creation time in ascending order.
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **ListLiveRecordVideo**.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// CreationTime:Desc
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The name of the recorded live stream.
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// The ID of the transcoding template group.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The duration of the video. Unit: seconds.
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// The name of the video category.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The status of the video. Valid values:
        /// 
        /// *   **Uploading:**: indicates that the video is being uploaded.
        /// *   **UploadFail**: indicates that the video failed to be uploaded.
        /// *   **UploadSucces**: indicates that the video was uploaded.
        /// *   **Transcoding**: indicates that the video is being transcoded.
        /// *   **TranscodeFail**: indicates that the video failed to be transcoded.
        /// *   **Blocked**: indicates that the video is blocked.
        /// *   **Normal**: indicates that the video is in a normal state.
        /// </summary>
        [NameInMap("StreamName")]
        [Validation(Required=false)]
        public string StreamName { get; set; }

    }

}
