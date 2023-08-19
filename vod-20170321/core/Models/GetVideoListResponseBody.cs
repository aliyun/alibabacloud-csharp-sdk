// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetVideoListResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of media files returned.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        /// <summary>
        /// The period of time in which the object remains in the restored state.
        /// </summary>
        [NameInMap("VideoList")]
        [Validation(Required=false)]
        public GetVideoListResponseBodyVideoList VideoList { get; set; }
        public class GetVideoListResponseBodyVideoList : TeaModel {
            [NameInMap("Video")]
            [Validation(Required=false)]
            public List<GetVideoListResponseBodyVideoListVideo> Video { get; set; }
            public class GetVideoListResponseBodyVideoListVideo : TeaModel {
                /// <summary>
                /// The ID of the application. Default value: **app-1000000**.
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

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
                /// The time when the video was updated. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
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
                /// The restoration status of the media file. Valid values:
                /// 
                /// - **Processing**
                /// - **Success**
                /// - **Failed**
                /// </summary>
                [NameInMap("RestoreStatus")]
                [Validation(Required=false)]
                public string RestoreStatus { get; set; }

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
                public GetVideoListResponseBodyVideoListVideoSnapshots Snapshots { get; set; }
                public class GetVideoListResponseBodyVideoListVideoSnapshots : TeaModel {
                    [NameInMap("Snapshot")]
                    [Validation(Required=false)]
                    public List<string> Snapshot { get; set; }

                }

                /// <summary>
                /// The status of the video. Valid values:
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
                /// The storage class of the media file. Valid values:
                /// 
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

}
