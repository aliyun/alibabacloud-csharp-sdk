// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListLiveRecordVideoResponseBody : TeaModel {
        /// <summary>
        /// The total number of videos returned.
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
                /// The information about the video.
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// The tags of the video. Separate multiple tags with commas (,).
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// The last time when the video was updated. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("PlaylistId")]
                [Validation(Required=false)]
                public string PlaylistId { get; set; }

                /// <summary>
                /// The domain name of the recorded live stream.
                /// </summary>
                [NameInMap("RecordEndTime")]
                [Validation(Required=false)]
                public string RecordEndTime { get; set; }

                /// <summary>
                /// The array of video snapshot URLs.
                /// </summary>
                [NameInMap("RecordStartTime")]
                [Validation(Required=false)]
                public string RecordStartTime { get; set; }

                /// <summary>
                /// The end of the time range to query. The query is performed based on the time range during which the required live streams were recorded. The end time must be later than the start time. Specify the time in the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time must be in UTC.
                /// </summary>
                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

                /// <summary>
                /// The name of the application that was used to record the live stream.
                /// </summary>
                [NameInMap("Video")]
                [Validation(Required=false)]
                public ListLiveRecordVideoResponseBodyLiveRecordVideoListLiveRecordVideoVideo Video { get; set; }
                public class ListLiveRecordVideoResponseBodyLiveRecordVideoListLiveRecordVideoVideo : TeaModel {
                    /// <summary>
                    /// The time when the video was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                    /// </summary>
                    [NameInMap("CateId")]
                    [Validation(Required=false)]
                    public int? CateId { get; set; }

                    /// <summary>
                    /// The name of the application.
                    /// </summary>
                    [NameInMap("CateName")]
                    [Validation(Required=false)]
                    public string CateName { get; set; }

                    [NameInMap("CoverURL")]
                    [Validation(Required=false)]
                    public string CoverURL { get; set; }

                    /// <summary>
                    /// The beginning of the time range to query. The query is performed based on the time range during which the required live streams were recorded. Specify the time in the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time must be in UTC.
                    /// </summary>
                    [NameInMap("CreationTime")]
                    [Validation(Required=false)]
                    public string CreationTime { get; set; }

                    /// <summary>
                    /// The name of the live stream.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public float? Duration { get; set; }

                    [NameInMap("ModifyTime")]
                    [Validation(Required=false)]
                    public string ModifyTime { get; set; }

                    /// <summary>
                    /// Queries live-to-VOD videos.
                    /// </summary>
                    [NameInMap("Size")]
                    [Validation(Required=false)]
                    public long? Size { get; set; }

                    [NameInMap("Snapshots")]
                    [Validation(Required=false)]
                    public ListLiveRecordVideoResponseBodyLiveRecordVideoListLiveRecordVideoVideoSnapshots Snapshots { get; set; }
                    public class ListLiveRecordVideoResponseBodyLiveRecordVideoListLiveRecordVideoVideoSnapshots : TeaModel {
                        [NameInMap("Snapshot")]
                        [Validation(Required=false)]
                        public List<string> Snapshot { get; set; }

                    }

                    /// <summary>
                    /// The ID of the playlist.
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// 2017-01-11T13:00:00Z
                    /// </summary>
                    [NameInMap("Tags")]
                    [Validation(Required=false)]
                    public string Tags { get; set; }

                    [NameInMap("TemplateGroupId")]
                    [Validation(Required=false)]
                    public string TemplateGroupId { get; set; }

                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                    /// <summary>
                    /// 10
                    /// </summary>
                    [NameInMap("VideoId")]
                    [Validation(Required=false)]
                    public string VideoId { get; set; }

                }

            }

        }

        /// <summary>
        /// The description of the video.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The title of the video.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
