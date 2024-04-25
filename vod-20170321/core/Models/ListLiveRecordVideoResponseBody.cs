// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListLiveRecordVideoResponseBody : TeaModel {
        /// <summary>
        /// The list of videos.
        /// </summary>
        [NameInMap("LiveRecordVideoList")]
        [Validation(Required=false)]
        public ListLiveRecordVideoResponseBodyLiveRecordVideoList LiveRecordVideoList { get; set; }
        public class ListLiveRecordVideoResponseBodyLiveRecordVideoList : TeaModel {
            [NameInMap("LiveRecordVideo")]
            [Validation(Required=false)]
            public List<ListLiveRecordVideoResponseBodyLiveRecordVideoListLiveRecordVideo> LiveRecordVideo { get; set; }
            public class ListLiveRecordVideoResponseBodyLiveRecordVideoListLiveRecordVideo : TeaModel {
                /// <summary>
                /// The name of the app.
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// The domain name.
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// The ID of the playlist.
                /// </summary>
                [NameInMap("PlaylistId")]
                [Validation(Required=false)]
                public string PlaylistId { get; set; }

                /// <summary>
                /// The recording end time. The time is in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("RecordEndTime")]
                [Validation(Required=false)]
                public string RecordEndTime { get; set; }

                /// <summary>
                /// The recording start time. The time is in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("RecordStartTime")]
                [Validation(Required=false)]
                public string RecordStartTime { get; set; }

                /// <summary>
                /// The name of the live-to-VOD file.
                /// </summary>
                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

                /// <summary>
                /// The information about the live-to-VOD file.
                /// </summary>
                [NameInMap("Video")]
                [Validation(Required=false)]
                public ListLiveRecordVideoResponseBodyLiveRecordVideoListLiveRecordVideoVideo Video { get; set; }
                public class ListLiveRecordVideoResponseBodyLiveRecordVideoListLiveRecordVideoVideo : TeaModel {
                    /// <summary>
                    /// The ID of the video category.
                    /// </summary>
                    [NameInMap("CateId")]
                    [Validation(Required=false)]
                    public int? CateId { get; set; }

                    /// <summary>
                    /// The category of the video.
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
                    /// The time when the audio or video file was created. The time is in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
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
                    /// The duration of the video file. Unit: seconds.
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public float? Duration { get; set; }

                    /// <summary>
                    /// The time when the video was updated. The time is in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                    /// </summary>
                    [NameInMap("ModifyTime")]
                    [Validation(Required=false)]
                    public string ModifyTime { get; set; }

                    /// <summary>
                    /// The size of the source video file. Unit: bytes.
                    /// </summary>
                    [NameInMap("Size")]
                    [Validation(Required=false)]
                    public long? Size { get; set; }

                    /// <summary>
                    /// The array of video snapshot URLs.
                    /// </summary>
                    [NameInMap("Snapshots")]
                    [Validation(Required=false)]
                    public ListLiveRecordVideoResponseBodyLiveRecordVideoListLiveRecordVideoVideoSnapshots Snapshots { get; set; }
                    public class ListLiveRecordVideoResponseBodyLiveRecordVideoListLiveRecordVideoVideoSnapshots : TeaModel {
                        [NameInMap("Snapshot")]
                        [Validation(Required=false)]
                        public List<string> Snapshot { get; set; }

                    }

                    /// <summary>
                    /// The status of the video. Valid values:
                    /// 
                    /// *   **Uploading**
                    /// *   **UploadFail**
                    /// *   **UploadSuccess**
                    /// *   **Transcoding**
                    /// *   **TranscodeFail**
                    /// *   **Blocked**
                    /// *   **Normal**: The video is normal.
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// The tags of the video. Multiple tags are separated with commas (,).
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

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of videos.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
