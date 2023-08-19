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
                /// The name of the application.
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
                /// The end of the time range in which data was queried. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("RecordEndTime")]
                [Validation(Required=false)]
                public string RecordEndTime { get; set; }

                /// <summary>
                /// The beginning of the time range in which data was queried. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("RecordStartTime")]
                [Validation(Required=false)]
                public string RecordStartTime { get; set; }

                /// <summary>
                /// The name of the live stream.
                /// </summary>
                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

                /// <summary>
                /// The information about the video.
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
                    /// The name of the video category.
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
                    /// The last time when the video was updated. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                    /// </summary>
                    [NameInMap("ModifyTime")]
                    [Validation(Required=false)]
                    public string ModifyTime { get; set; }

                    /// <summary>
                    /// The size of the mezzanine file. Unit: byte.
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
                    /// *   **Uploading:**: indicates that the video is being uploaded.
                    /// *   **UploadFail**: indicates that the video failed to be uploaded.
                    /// *   **UploadSucces**: indicates that the video was uploaded.
                    /// *   **Transcoding**: indicates that the video is being transcoded.
                    /// *   **TranscodeFail**: indicates that the video failed to be transcoded.
                    /// *   **Blocked**: indicates that the video is blocked.
                    /// *   **Normal**: indicates that the video is in a normal state.
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// The tags of the video. Separate multiple tags with commas (,).
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
        /// The total number of videos returned.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
