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
        /// The information about the video.
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
            /// The category ID of the video.
            /// </summary>
            [NameInMap("CateId")]
            [Validation(Required=false)]
            public long? CateId { get; set; }

            /// <summary>
            /// The category of the video.
            /// </summary>
            [NameInMap("CateName")]
            [Validation(Required=false)]
            public string CateName { get; set; }

            /// <summary>
            /// The thumbnail URL of the video.
            /// </summary>
            [NameInMap("CoverURL")]
            [Validation(Required=false)]
            public string CoverURL { get; set; }

            /// <summary>
            /// The time when the video was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The information about the custom media asset.
            /// > This parameter has been deprecated. This parameter is no longer returned when you call the API.
            /// </summary>
            [NameInMap("CustomMediaInfo")]
            [Validation(Required=false)]
            public string CustomMediaInfo { get; set; }

            /// <summary>
            /// The description of the video.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The duration of the video. Unit: seconds.
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public float? Duration { get; set; }

            /// <summary>
            /// The time when the video was updated. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("ModificationTime")]
            [Validation(Required=false)]
            public string ModificationTime { get; set; }

            /// <summary>
            /// The region ID of the Object Storage Service (OSS) bucket.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The size of the source video file. Unit: byte.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// The URL array of video snapshots.
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
            /// The video status. Valid values:
            /// *   **Uploading**: The video is being uploaded.
            /// *   **UploadFail**: The video failed to be uploaded.
            /// *   **UploadSucc**: The video has been uploaded.
            /// *   **Transcoding**: The video is being transcoded.
            /// *   **TranscodeFail**: The video failed to be transcoded.
            /// *   **Blocked**: The video failed the review.
            /// *   **Normal**: The video passed the review.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The OSS bucket where the video is stored.
            /// </summary>
            [NameInMap("StorageLocation")]
            [Validation(Required=false)]
            public string StorageLocation { get; set; }

            /// <summary>
            /// The tags of the video. Separate multiple tags with commas (,).
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

            /// <summary>
            /// The ID of the template group.
            /// </summary>
            [NameInMap("TemplateGroupId")]
            [Validation(Required=false)]
            public string TemplateGroupId { get; set; }

            /// <summary>
            /// The title of the video.
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// The ID of the video.
            /// </summary>
            [NameInMap("VideoId")]
            [Validation(Required=false)]
            public string VideoId { get; set; }

        }

    }

}
