// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetVideoInfoResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the media file.
        /// </summary>
        [NameInMap("Video")]
        [Validation(Required=false)]
        public GetVideoInfoResponseBodyVideo Video { get; set; }
        public class GetVideoInfoResponseBodyVideo : TeaModel {
            /// <summary>
            /// The ID of the application.
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// The review status of the video. Valid values:
            /// 
            /// *   **Normal**: pass
            /// *   **Blocked**: failed
            /// </summary>
            [NameInMap("AuditStatus")]
            [Validation(Required=false)]
            public string AuditStatus { get; set; }

            /// <summary>
            /// The category ID of the media file.
            /// </summary>
            [NameInMap("CateId")]
            [Validation(Required=false)]
            public long? CateId { get; set; }

            /// <summary>
            /// The name of the category.
            /// </summary>
            [NameInMap("CateName")]
            [Validation(Required=false)]
            public string CateName { get; set; }

            /// <summary>
            /// The thumbnail URL of the media file.
            /// </summary>
            [NameInMap("CoverURL")]
            [Validation(Required=false)]
            public string CoverURL { get; set; }

            /// <summary>
            /// The time when the media file was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The custom information about the media file.
            /// 
            /// > This parameter has been deprecated. This parameter is no longer returned after you call the operation.
            /// </summary>
            [NameInMap("CustomMediaInfo")]
            [Validation(Required=false)]
            public string CustomMediaInfo { get; set; }

            /// <summary>
            /// The description of the media file.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The duration of the media file. Unit: seconds.
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public float? Duration { get; set; }

            /// <summary>
            /// The time when the media file was updated. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("ModificationTime")]
            [Validation(Required=false)]
            public string ModificationTime { get; set; }

            /// <summary>
            /// The region where the media file is stored.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The size of the source file. Unit: bytes.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// The video snapshot URLs.
            /// </summary>
            [NameInMap("Snapshots")]
            [Validation(Required=false)]
            public GetVideoInfoResponseBodyVideoSnapshots Snapshots { get; set; }
            public class GetVideoInfoResponseBodyVideoSnapshots : TeaModel {
                [NameInMap("Snapshot")]
                [Validation(Required=false)]
                public List<string> Snapshot { get; set; }

            }

            /// <summary>
            /// The status of the video. For information about the operations that can be performed on videos in different statuses and limits, see the Status: the status of a video section of the [Basic data types](~~52839~~) topic. Valid values:
            /// 
            /// *   **Uploading**: The video is being uploaded.
            /// *   **UploadFail**: The video failed to be uploaded.
            /// *   **UploadSucc**: The video has been uploaded.
            /// *   **Transcoding**: The video is being transcoded.
            /// *   **TranscodeFail**: The video failed to be transcoded.
            /// *   **Blocked**: The video is blocked.
            /// *   **Normal**: The video is normal.
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

            /// <summary>
            /// The tags of the media file. Multiple tags are separated by commas (,).
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

            /// <summary>
            /// The ID of the transcoding template group.
            /// </summary>
            [NameInMap("TemplateGroupId")]
            [Validation(Required=false)]
            public string TemplateGroupId { get; set; }

            /// <summary>
            /// The title of the media file.
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// The ID of the media file.
            /// </summary>
            [NameInMap("VideoId")]
            [Validation(Required=false)]
            public string VideoId { get; set; }

        }

    }

}
