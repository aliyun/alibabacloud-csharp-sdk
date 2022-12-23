// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SearchMediaResponseBody : TeaModel {
        /// <summary>
        /// Details about media assets.
        /// </summary>
        [NameInMap("MediaList")]
        [Validation(Required=false)]
        public List<SearchMediaResponseBodyMediaList> MediaList { get; set; }
        public class SearchMediaResponseBodyMediaList : TeaModel {
            /// <summary>
            /// [Details about auxiliary media assets](~~86991~~).
            /// </summary>
            [NameInMap("AttachedMedia")]
            [Validation(Required=false)]
            public SearchMediaResponseBodyMediaListAttachedMedia AttachedMedia { get; set; }
            public class SearchMediaResponseBodyMediaListAttachedMedia : TeaModel {
                /// <summary>
                /// The ID of the application.
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// The type of the auxiliary media asset. Valid values:
                /// 
                /// *   **watermark**
                /// *   **subtitle**
                /// *   **material**
                /// </summary>
                [NameInMap("BusinessType")]
                [Validation(Required=false)]
                public string BusinessType { get; set; }

                /// <summary>
                /// The list of category IDs.
                /// </summary>
                [NameInMap("Categories")]
                [Validation(Required=false)]
                public List<SearchMediaResponseBodyMediaListAttachedMediaCategories> Categories { get; set; }
                public class SearchMediaResponseBodyMediaListAttachedMediaCategories : TeaModel {
                    /// <summary>
                    /// The category ID of the auxiliary media asset.
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
                    /// The level of the category.
                    /// </summary>
                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public long? Level { get; set; }

                    /// <summary>
                    /// The ID of the parent category.
                    /// </summary>
                    [NameInMap("ParentId")]
                    [Validation(Required=false)]
                    public long? ParentId { get; set; }

                }

                /// <summary>
                /// The time when the auxiliary media asset was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The description of the auxiliary media asset.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The ID of the auxiliary media asset.
                /// </summary>
                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                /// <summary>
                /// The time when the auxiliary media asset was updated. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("ModificationTime")]
                [Validation(Required=false)]
                public string ModificationTime { get; set; }

                /// <summary>
                /// The status of the auxiliary media asset. Valid values:
                /// 
                /// *   **Uploading**: The auxiliary media asset is being uploaded. This is the initial status.
                /// *   **Normal**: The auxiliary media asset is uploaded.
                /// *   **UploadFail**: The auxiliary media asset fails to be uploaded.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The endpoint of the OSS bucket in which the auxiliary media asset is stored.
                /// </summary>
                [NameInMap("StorageLocation")]
                [Validation(Required=false)]
                public string StorageLocation { get; set; }

                /// <summary>
                /// The tags of the auxiliary media asset.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public string Tags { get; set; }

                /// <summary>
                /// The title of the auxiliary media asset.
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// The URL of the auxiliary media asset.
                /// </summary>
                [NameInMap("URL")]
                [Validation(Required=false)]
                public string URL { get; set; }

            }

            /// <summary>
            /// [Details about audio files](~~86991~~).
            /// </summary>
            [NameInMap("Audio")]
            [Validation(Required=false)]
            public SearchMediaResponseBodyMediaListAudio Audio { get; set; }
            public class SearchMediaResponseBodyMediaListAudio : TeaModel {
                /// <summary>
                /// The ID of the application.
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// The ID of the audio file.
                /// </summary>
                [NameInMap("AudioId")]
                [Validation(Required=false)]
                public string AudioId { get; set; }

                /// <summary>
                /// The category ID of the audio file.
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
                /// The URL of the thumbnail.
                /// </summary>
                [NameInMap("CoverURL")]
                [Validation(Required=false)]
                public string CoverURL { get; set; }

                /// <summary>
                /// The time when the audio file was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The description of the audio file.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The download switch. The audio file can be downloaded offline only when the download switch is turned on. Valid values:
                /// 
                /// *   **on**
                /// *   **off**
                /// </summary>
                [NameInMap("DownloadSwitch")]
                [Validation(Required=false)]
                public string DownloadSwitch { get; set; }

                /// <summary>
                /// The duration of the audio file.
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public float? Duration { get; set; }

                /// <summary>
                /// The source. Valid values:
                /// 
                /// *   **general**: The audio file is uploaded by using ApsaraVideo VOD.
                /// *   **short_video**: The audio file is uploaded to ApsaraVideo VOD by using the short video SDK. For more information, see [Introduction](~~53407~~).
                /// *   **editing**: The audio file is uploaded to ApsaraVideo VOD after online editing and production. For more information, see [ProduceEditingProjectVideo](~~68536~~).
                /// *   **live**: The audio stream is recorded and uploaded as a file to ApsaraVideo VOD.
                /// </summary>
                [NameInMap("MediaSource")]
                [Validation(Required=false)]
                public string MediaSource { get; set; }

                /// <summary>
                /// The time when the audio file was updated. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("ModificationTime")]
                [Validation(Required=false)]
                public string ModificationTime { get; set; }

                /// <summary>
                /// The preprocessing status. Only preprocessed videos can be used for live streaming in the production studio. Valid values:
                /// 
                /// *   **UnPreprocess**
                /// *   **Preprocessing**
                /// *   **PreprocessSucceed**
                /// *   **PreprocessFailed**
                /// </summary>
                [NameInMap("PreprocessStatus")]
                [Validation(Required=false)]
                public string PreprocessStatus { get; set; }

                /// <summary>
                /// The size of the audio file.
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                /// <summary>
                /// The list of automatic snapshots.
                /// </summary>
                [NameInMap("Snapshots")]
                [Validation(Required=false)]
                public List<string> Snapshots { get; set; }

                /// <summary>
                /// The list of sprite snapshots.
                /// </summary>
                [NameInMap("SpriteSnapshots")]
                [Validation(Required=false)]
                public List<string> SpriteSnapshots { get; set; }

                /// <summary>
                /// The status of the audio file. Valid values:
                /// 
                /// *   **Uploading**
                /// *   **Normal**
                /// *   **UploadFail**
                /// *   **Deleted**
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The endpoint of the OSS bucket in which the audio file is stored.
                /// </summary>
                [NameInMap("StorageLocation")]
                [Validation(Required=false)]
                public string StorageLocation { get; set; }

                /// <summary>
                /// The tags of the audio file.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public string Tags { get; set; }

                /// <summary>
                /// The title of the audio file.
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// The transcoding mode. Default value: FastTranscode. Valid values:
                /// 
                /// *   **FastTranscode**: The audio file is immediately transcoded after it is uploaded. You cannot play the file before it is transcoded.
                /// *   **NoTranscode**: The audio file can be played without being transcoded. You can immediately play the file after it is uploaded.
                /// *   **AsyncTranscode**: The audio file can be immediately played and asynchronously transcoded after it is uploaded.
                /// </summary>
                [NameInMap("TranscodeMode")]
                [Validation(Required=false)]
                public string TranscodeMode { get; set; }

            }

            /// <summary>
            /// The time when the media asset was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// [Details about image files](~~86991~~).
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public SearchMediaResponseBodyMediaListImage Image { get; set; }
            public class SearchMediaResponseBodyMediaListImage : TeaModel {
                /// <summary>
                /// The ID of the application.
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// The category ID of the image file.
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
                /// The time when the image file was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The description of the image file.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The ID of the image file.
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// The time when the image file was updated. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("ModificationTime")]
                [Validation(Required=false)]
                public string ModificationTime { get; set; }

                /// <summary>
                /// The status of the image file.
                /// 
                /// *   **Uploading**: The image file is being uploaded. This is the initial status.
                /// *   **Normal**: The image file is uploaded.
                /// *   **UploadFail**: The image file fails to be uploaded.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The endpoint of the OSS bucket in which the image file is stored.
                /// </summary>
                [NameInMap("StorageLocation")]
                [Validation(Required=false)]
                public string StorageLocation { get; set; }

                /// <summary>
                /// The tags of the image file.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public string Tags { get; set; }

                /// <summary>
                /// The title of the image file.
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// The URL of the image file.
                /// </summary>
                [NameInMap("URL")]
                [Validation(Required=false)]
                public string URL { get; set; }

            }

            /// <summary>
            /// The ID of the media asset.
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            /// <summary>
            /// The type of the media asset. Valid values:
            /// 
            /// *   **video**
            /// *   **audio**
            /// *   **image**
            /// *   **attached**
            /// </summary>
            [NameInMap("MediaType")]
            [Validation(Required=false)]
            public string MediaType { get; set; }

            /// <summary>
            /// [Details about video files](~~86991~~).
            /// </summary>
            [NameInMap("Video")]
            [Validation(Required=false)]
            public SearchMediaResponseBodyMediaListVideo Video { get; set; }
            public class SearchMediaResponseBodyMediaListVideo : TeaModel {
                /// <summary>
                /// The ID of the application.
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// The category ID of the video file.
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
                /// The URL of the thumbnail.
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
                /// The description of the video file.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The download switch. The video file can be downloaded offline only when the download switch is turned on. Valid values:
                /// 
                /// *   **on**
                /// *   **off**
                /// </summary>
                [NameInMap("DownloadSwitch")]
                [Validation(Required=false)]
                public string DownloadSwitch { get; set; }

                /// <summary>
                /// The duration of the video file. Unit: seconds.
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public float? Duration { get; set; }

                /// <summary>
                /// The source. Valid values:
                /// 
                /// *   **general**: The video file is uploaded by using ApsaraVideo VOD.
                /// *   **short_video**: The video file is uploaded by using the short video SDK.
                /// *   **editing**: The video file is produced after online editing.
                /// *   **live**: The video stream is recorded and uploaded as a file.
                /// </summary>
                [NameInMap("MediaSource")]
                [Validation(Required=false)]
                public string MediaSource { get; set; }

                /// <summary>
                /// The time when the video file was updated. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("ModificationTime")]
                [Validation(Required=false)]
                public string ModificationTime { get; set; }

                /// <summary>
                /// The preprocessing status. Valid values:
                /// 
                /// *   **UnPreprocess**
                /// *   **Preprocessing**
                /// *   **PreprocessSucceed**
                /// *   **PreprocessFailed**
                /// </summary>
                [NameInMap("PreprocessStatus")]
                [Validation(Required=false)]
                public string PreprocessStatus { get; set; }

                /// <summary>
                /// The size of the video file.
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                /// <summary>
                /// The list of automatic snapshots.
                /// </summary>
                [NameInMap("Snapshots")]
                [Validation(Required=false)]
                public List<string> Snapshots { get; set; }

                /// <summary>
                /// The list of sprite snapshots.
                /// </summary>
                [NameInMap("SpriteSnapshots")]
                [Validation(Required=false)]
                public List<string> SpriteSnapshots { get; set; }

                /// <summary>
                /// The status of the video file. Valid values:
                /// 
                /// *   **Uploading**
                /// *   **UploadFail**
                /// *   **UploadSucc**
                /// *   **Transcoding**
                /// *   **TranscodeFail**
                /// *   **Blocked**
                /// *   **Normal**
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The endpoint of the OSS bucket in which the video file is stored.
                /// </summary>
                [NameInMap("StorageLocation")]
                [Validation(Required=false)]
                public string StorageLocation { get; set; }

                /// <summary>
                /// The tags of the video file.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public string Tags { get; set; }

                /// <summary>
                /// The title of the video file.
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// The transcoding mode. Default value: FastTranscode. Valid values:
                /// 
                /// *   **FastTranscode**: The video file is immediately transcoded after it is uploaded. You cannot play the file before it is transcoded.
                /// *   **NoTranscode**: The video file can be played without being transcoded. You can immediately play the file after it is uploaded.
                /// *   **AsyncTranscode**: The video file can be immediately played and asynchronously transcoded after it is uploaded.
                /// </summary>
                [NameInMap("TranscodeMode")]
                [Validation(Required=false)]
                public string TranscodeMode { get; set; }

                /// <summary>
                /// The ID of the video file.
                /// </summary>
                [NameInMap("VideoId")]
                [Validation(Required=false)]
                public string VideoId { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The pagination identifier.
        /// </summary>
        [NameInMap("ScrollToken")]
        [Validation(Required=false)]
        public string ScrollToken { get; set; }

        /// <summary>
        /// The total number of data records that meet the specified filter criteria.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
