// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SearchMediaResponseBody : TeaModel {
        /// <summary>
        /// The status of the audio file. Valid values:
        /// 
        /// *   **Uploading**
        /// *   **Normal**
        /// *   **UploadFail**
        /// *   **Deleted**
        /// </summary>
        [NameInMap("MediaList")]
        [Validation(Required=false)]
        public List<SearchMediaResponseBodyMediaList> MediaList { get; set; }
        public class SearchMediaResponseBodyMediaList : TeaModel {
            /// <summary>
            /// AI详细信息
            /// </summary>
            [NameInMap("AiData")]
            [Validation(Required=false)]
            public SearchMediaResponseBodyMediaListAiData AiData { get; set; }
            public class SearchMediaResponseBodyMediaListAiData : TeaModel {
                /// <summary>
                /// AI标签信息列表
                /// </summary>
                [NameInMap("AiLabelInfo")]
                [Validation(Required=false)]
                public List<SearchMediaResponseBodyMediaListAiDataAiLabelInfo> AiLabelInfo { get; set; }
                public class SearchMediaResponseBodyMediaListAiDataAiLabelInfo : TeaModel {
                    /// <summary>
                    /// 分类
                    /// </summary>
                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    /// <summary>
                    /// 实体ID
                    /// </summary>
                    [NameInMap("LabelId")]
                    [Validation(Required=false)]
                    public string LabelId { get; set; }

                    /// <summary>
                    /// 实体名称
                    /// </summary>
                    [NameInMap("LabelName")]
                    [Validation(Required=false)]
                    public string LabelName { get; set; }

                    /// <summary>
                    /// 片段列表
                    /// </summary>
                    [NameInMap("Occurrences")]
                    [Validation(Required=false)]
                    public List<SearchMediaResponseBodyMediaListAiDataAiLabelInfoOccurrences> Occurrences { get; set; }
                    public class SearchMediaResponseBodyMediaListAiDataAiLabelInfoOccurrences : TeaModel {
                        /// <summary>
                        /// 片段起始时间
                        /// </summary>
                        [NameInMap("From")]
                        [Validation(Required=false)]
                        public double? From { get; set; }

                        /// <summary>
                        /// 打分
                        /// </summary>
                        [NameInMap("Score")]
                        [Validation(Required=false)]
                        public double? Score { get; set; }

                        /// <summary>
                        /// 片段结束时间
                        /// </summary>
                        [NameInMap("To")]
                        [Validation(Required=false)]
                        public double? To { get; set; }

                    }

                }

                /// <summary>
                /// 字幕信息列表
                /// </summary>
                [NameInMap("OcrInfo")]
                [Validation(Required=false)]
                public List<SearchMediaResponseBodyMediaListAiDataOcrInfo> OcrInfo { get; set; }
                public class SearchMediaResponseBodyMediaListAiDataOcrInfo : TeaModel {
                    /// <summary>
                    /// 文本内容
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// 片段起始时间
                    /// </summary>
                    [NameInMap("From")]
                    [Validation(Required=false)]
                    public double? From { get; set; }

                    /// <summary>
                    /// 片段结束时间
                    /// </summary>
                    [NameInMap("To")]
                    [Validation(Required=false)]
                    public double? To { get; set; }

                }

            }

            /// <summary>
            /// AI简介数据
            /// </summary>
            [NameInMap("AiRoughData")]
            [Validation(Required=false)]
            public SearchMediaResponseBodyMediaListAiRoughData AiRoughData { get; set; }
            public class SearchMediaResponseBodyMediaListAiRoughData : TeaModel {
                /// <summary>
                /// 视频AI分类
                /// </summary>
                [NameInMap("AiCategory")]
                [Validation(Required=false)]
                public string AiCategory { get; set; }

                /// <summary>
                /// AI任务ID
                /// </summary>
                [NameInMap("AiJobId")]
                [Validation(Required=false)]
                public string AiJobId { get; set; }

                /// <summary>
                /// 保存类型
                /// </summary>
                [NameInMap("SaveType")]
                [Validation(Required=false)]
                public string SaveType { get; set; }

                /// <summary>
                /// 数据状态
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// Queries the information about media assets such as video, audio, and image files, and auxiliary media assets.
            /// </summary>
            [NameInMap("AttachedMedia")]
            [Validation(Required=false)]
            public SearchMediaResponseBodyMediaListAttachedMedia AttachedMedia { get; set; }
            public class SearchMediaResponseBodyMediaListAttachedMedia : TeaModel {
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                [NameInMap("BusinessType")]
                [Validation(Required=false)]
                public string BusinessType { get; set; }

                [NameInMap("Categories")]
                [Validation(Required=false)]
                public List<SearchMediaResponseBodyMediaListAttachedMediaCategories> Categories { get; set; }
                public class SearchMediaResponseBodyMediaListAttachedMediaCategories : TeaModel {
                    [NameInMap("CateId")]
                    [Validation(Required=false)]
                    public long? CateId { get; set; }

                    [NameInMap("CateName")]
                    [Validation(Required=false)]
                    public string CateName { get; set; }

                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public long? Level { get; set; }

                    [NameInMap("ParentId")]
                    [Validation(Required=false)]
                    public long? ParentId { get; set; }

                }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                [NameInMap("ModificationTime")]
                [Validation(Required=false)]
                public string ModificationTime { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("StorageLocation")]
                [Validation(Required=false)]
                public string StorageLocation { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public string Tags { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("URL")]
                [Validation(Required=false)]
                public string URL { get; set; }

            }

            /// <summary>
            /// The name of the category.
            /// </summary>
            [NameInMap("Audio")]
            [Validation(Required=false)]
            public SearchMediaResponseBodyMediaListAudio Audio { get; set; }
            public class SearchMediaResponseBodyMediaListAudio : TeaModel {
                /// <summary>
                /// The number of entries to return on each page. Default value: **10**. Maximum value: **100**.
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// The time when the auxiliary media asset was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("AudioId")]
                [Validation(Required=false)]
                public string AudioId { get; set; }

                /// <summary>
                /// The URL of the auxiliary media asset.
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
                /// The status of the auxiliary media asset. Valid values:
                /// 
                /// *   **Uploading**: The auxiliary media asset is being uploaded. This is the initial status.
                /// *   **Normal**: The auxiliary media asset is uploaded.
                /// *   **UploadFail**: The auxiliary media asset fails to be uploaded.
                /// </summary>
                [NameInMap("CoverURL")]
                [Validation(Required=false)]
                public string CoverURL { get; set; }

                /// <summary>
                /// The source. Valid values:
                /// 
                /// *   **general**: The video file is uploaded by using ApsaraVideo VOD.
                /// *   **short_video**: The video file is uploaded by using the short video SDK.
                /// *   **editing**: The video file is produced after online editing.
                /// *   **live**: The video stream is recorded and uploaded as a file.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The type of the auxiliary media asset. Valid values:
                /// 
                /// *   **watermark**
                /// *   **subtitle**
                /// *   **material**
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The ID of the auxiliary media asset.
                /// </summary>
                [NameInMap("DownloadSwitch")]
                [Validation(Required=false)]
                public string DownloadSwitch { get; set; }

                /// <summary>
                /// The time when the image file was updated. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public float? Duration { get; set; }

                /// <summary>
                /// The number of the page to return. Default value: **1**.
                /// 
                /// > If the value of this parameter exceeds **200**, we recommend that you set the ScrollToken parameter as well.
                /// </summary>
                [NameInMap("MediaSource")]
                [Validation(Required=false)]
                public string MediaSource { get; set; }

                /// <summary>
                /// The pagination identifier.
                /// </summary>
                [NameInMap("ModificationTime")]
                [Validation(Required=false)]
                public string ModificationTime { get; set; }

                /// <summary>
                /// The total number of data records that meet the specified filter criteria.
                /// </summary>
                [NameInMap("PreprocessStatus")]
                [Validation(Required=false)]
                public string PreprocessStatus { get; set; }

                [NameInMap("RestoreExpiration")]
                [Validation(Required=false)]
                public string RestoreExpiration { get; set; }

                [NameInMap("RestoreStatus")]
                [Validation(Required=false)]
                public string RestoreStatus { get; set; }

                /// <summary>
                /// The title of the video file.
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                /// <summary>
                /// The ID of the video file.
                /// </summary>
                [NameInMap("Snapshots")]
                [Validation(Required=false)]
                public List<string> Snapshots { get; set; }

                /// <summary>
                /// The status of the image file.
                /// 
                /// *   **Uploading**: The image file is being uploaded. This is the initial status.
                /// *   **Normal**: The image file is uploaded.
                /// *   **UploadFail**: The image file fails to be uploaded.
                /// </summary>
                [NameInMap("SpriteSnapshots")]
                [Validation(Required=false)]
                public List<string> SpriteSnapshots { get; set; }

                /// <summary>
                /// The size of the audio file.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("StorageClass")]
                [Validation(Required=false)]
                public string StorageClass { get; set; }

                /// <summary>
                /// The duration of the audio file.
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
                /// The transcoding mode. Default value: FastTranscode. Valid values:
                /// 
                /// *   **FastTranscode**: The audio file is immediately transcoded after it is uploaded. You cannot play the file before it is transcoded.
                /// *   **NoTranscode**: The audio file can be played without being transcoded. You can immediately play the file after it is uploaded.
                /// *   **AsyncTranscode**: The audio file can be immediately played and asynchronously transcoded after it is uploaded.
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// The time when the audio file was updated. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("TranscodeMode")]
                [Validation(Required=false)]
                public string TranscodeMode { get; set; }

            }

            /// <summary>
            /// The list of category IDs.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The time when the video file was updated. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public SearchMediaResponseBodyMediaListImage Image { get; set; }
            public class SearchMediaResponseBodyMediaListImage : TeaModel {
                /// <summary>
                /// The ID of the audio file.
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// The duration of the video file. Unit: seconds.
                /// </summary>
                [NameInMap("CateId")]
                [Validation(Required=false)]
                public long? CateId { get; set; }

                /// <summary>
                /// The tags of the auxiliary media asset.
                /// </summary>
                [NameInMap("CateName")]
                [Validation(Required=false)]
                public string CateName { get; set; }

                /// <summary>
                /// [Details about auxiliary media assets](~~86991~~).
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The ID of the application.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The endpoint of the OSS bucket in which the audio file is stored.
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// The URL of the thumbnail.
                /// </summary>
                [NameInMap("ModificationTime")]
                [Validation(Required=false)]
                public string ModificationTime { get; set; }

                /// <summary>
                /// The type of the media asset. Valid values:
                /// 
                /// *   **video**
                /// *   **audio**
                /// *   **image**
                /// *   **attached**
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The ID of the application.
                /// </summary>
                [NameInMap("StorageLocation")]
                [Validation(Required=false)]
                public string StorageLocation { get; set; }

                /// <summary>
                /// The list of automatic snapshots.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public string Tags { get; set; }

                /// <summary>
                /// The ID of the request.
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// The URL of the thumbnail.
                /// </summary>
                [NameInMap("URL")]
                [Validation(Required=false)]
                public string URL { get; set; }

            }

            /// <summary>
            /// The time when the media asset was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            /// <summary>
            /// The description of the image file.
            /// </summary>
            [NameInMap("MediaType")]
            [Validation(Required=false)]
            public string MediaType { get; set; }

            /// <summary>
            /// The download switch. The video file can be downloaded offline only when the download switch is turned on. Valid values:
            /// 
            /// *   **on**
            /// *   **off**
            /// </summary>
            [NameInMap("Video")]
            [Validation(Required=false)]
            public SearchMediaResponseBodyMediaListVideo Video { get; set; }
            public class SearchMediaResponseBodyMediaListVideo : TeaModel {
                /// <summary>
                /// The download switch. The audio file can be downloaded offline only when the download switch is turned on. Valid values:
                /// 
                /// *   **on**
                /// *   **off**
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

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
                /// The filter condition. For more information about the syntax, see [Protocol for media asset search](~~86991~~).
                /// </summary>
                [NameInMap("CoverURL")]
                [Validation(Required=false)]
                public string CoverURL { get; set; }

                /// <summary>
                /// The category ID of the auxiliary media asset.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The endpoint of the OSS bucket in which the image file is stored.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The ID of the application.
                /// </summary>
                [NameInMap("DownloadSwitch")]
                [Validation(Required=false)]
                public string DownloadSwitch { get; set; }

                /// <summary>
                /// The description of the auxiliary media asset.
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public float? Duration { get; set; }

                /// <summary>
                /// [Details about video files](~~86991~~).
                /// </summary>
                [NameInMap("MediaSource")]
                [Validation(Required=false)]
                public string MediaSource { get; set; }

                /// <summary>
                /// The description of the audio file.
                /// </summary>
                [NameInMap("ModificationTime")]
                [Validation(Required=false)]
                public string ModificationTime { get; set; }

                /// <summary>
                /// The URL of the image file.
                /// </summary>
                [NameInMap("PreprocessStatus")]
                [Validation(Required=false)]
                public string PreprocessStatus { get; set; }

                [NameInMap("RestoreExpiration")]
                [Validation(Required=false)]
                public string RestoreExpiration { get; set; }

                [NameInMap("RestoreStatus")]
                [Validation(Required=false)]
                public string RestoreStatus { get; set; }

                /// <summary>
                /// The time when the image file was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                /// <summary>
                /// The endpoint of the OSS bucket in which the auxiliary media asset is stored.
                /// </summary>
                [NameInMap("Snapshots")]
                [Validation(Required=false)]
                public List<string> Snapshots { get; set; }

                /// <summary>
                /// The list of automatic snapshots.
                /// </summary>
                [NameInMap("SpriteSnapshots")]
                [Validation(Required=false)]
                public List<string> SpriteSnapshots { get; set; }

                /// <summary>
                /// The ID of the application.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("StorageClass")]
                [Validation(Required=false)]
                public string StorageClass { get; set; }

                /// <summary>
                /// The time when the audio file was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("StorageLocation")]
                [Validation(Required=false)]
                public string StorageLocation { get; set; }

                /// <summary>
                /// The title of the image file.
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
                /// The category ID of the audio file.
                /// </summary>
                [NameInMap("TranscodeMode")]
                [Validation(Required=false)]
                public string TranscodeMode { get; set; }

                /// <summary>
                /// The time when the video file was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("VideoId")]
                [Validation(Required=false)]
                public string VideoId { get; set; }

            }

        }

        /// <summary>
        /// The tags of the audio file.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The title of the auxiliary media asset.
        /// </summary>
        [NameInMap("ScrollToken")]
        [Validation(Required=false)]
        public string ScrollToken { get; set; }

        /// <summary>
        /// [Details about image files](~~86991~~).
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
