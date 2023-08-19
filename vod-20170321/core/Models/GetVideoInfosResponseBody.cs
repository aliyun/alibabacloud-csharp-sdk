// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetVideoInfosResponseBody : TeaModel {
        /// <summary>
        /// The IDs of the videos that do not exist.
        /// </summary>
        [NameInMap("NonExistVideoIds")]
        [Validation(Required=false)]
        public List<string> NonExistVideoIds { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The period of time in which the object remains in the restored state.
        /// </summary>
        [NameInMap("VideoList")]
        [Validation(Required=false)]
        public List<GetVideoInfosResponseBodyVideoList> VideoList { get; set; }
        public class GetVideoInfosResponseBodyVideoList : TeaModel {
            /// <summary>
            /// The ID of the application.
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// The ID of the video category.
            /// </summary>
            [NameInMap("CateId")]
            [Validation(Required=false)]
            public long? CateId { get; set; }

            /// <summary>
            /// The name of the video category.
            /// </summary>
            [NameInMap("CateName")]
            [Validation(Required=false)]
            public string CateName { get; set; }

            /// <summary>
            /// The URL of the video thumbnail.
            /// </summary>
            [NameInMap("CoverURL")]
            [Validation(Required=false)]
            public string CoverURL { get; set; }

            /// <summary>
            /// The time when the video file was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

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
            /// The time when the video file was updated. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("ModificationTime")]
            [Validation(Required=false)]
            public string ModificationTime { get; set; }

            /// <summary>
            /// The period of time in which the object remains in the restored state.
            /// </summary>
            [NameInMap("RestoreExpiration")]
            [Validation(Required=false)]
            public string RestoreExpiration { get; set; }

            /// <summary>
            /// The restoration status of the audio or video file. Valid values:
            /// - **Processing**
            /// - **Success**
            /// - **Failed**
            /// </summary>
            [NameInMap("RestoreStatus")]
            [Validation(Required=false)]
            public string RestoreStatus { get; set; }

            /// <summary>
            /// The size of the video mezzanine file. Unit: byte.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// The URL array of video snapshots.
            /// </summary>
            [NameInMap("Snapshots")]
            [Validation(Required=false)]
            public List<string> Snapshots { get; set; }

            /// <summary>
            /// The status of the video. By default, videos in all states are returned. Multiple states are separated by commas (,). Valid values:
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
            /// The storage class of the audio or video file. Valid values:
            /// - **Standard**: All media resources are stored as Standard objects.
            /// - **IA**: All media resources are stored as IA objects.
            /// - **Archive**: All media resources are stored as Archive objects.
            /// - **ColdArchive**: All media resources are stored as Cold Archive objects.
            /// - **SourceIA**: Only the source files are IA objects.
            /// - **SourceArchive**: Only the source files are Archive objects.
            /// - **SourceColdArchive**: Only the source files are Cold Archive objects.
            /// - **Changing**: The storage class is being modified.
            /// </summary>
            [NameInMap("StorageClass")]
            [Validation(Required=false)]
            public string StorageClass { get; set; }

            /// <summary>
            /// The Object Storage Service (OSS) bucket where the video file is stored.
            /// </summary>
            [NameInMap("StorageLocation")]
            [Validation(Required=false)]
            public string StorageLocation { get; set; }

            /// <summary>
            /// The tags of the video. Multiple tags are separated by commas (,).
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

            /// <summary>
            /// The ID of the template group that was used to transcode the video.
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
