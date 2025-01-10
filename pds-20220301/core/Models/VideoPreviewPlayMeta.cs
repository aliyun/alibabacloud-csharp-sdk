// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class VideoPreviewPlayMeta : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>live_transcoding</para>
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("live_transcoding_task_list")]
        [Validation(Required=false)]
        public List<VideoPreviewPlayMetaLiveTranscodingTaskList> LiveTranscodingTaskList { get; set; }
        public class VideoPreviewPlayMetaLiveTranscodingTaskList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("keep_original_resolution")]
            [Validation(Required=false)]
            public bool? KeepOriginalResolution { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>finished</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>264_720p</para>
            /// </summary>
            [NameInMap("template_id")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

        }

        [NameInMap("meta")]
        [Validation(Required=false)]
        public VideoPreviewPlayMetaMeta Meta { get; set; }
        public class VideoPreviewPlayMetaMeta : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("duration")]
            [Validation(Required=false)]
            public double? Duration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>720</para>
            /// </summary>
            [NameInMap("height")]
            [Validation(Required=false)]
            public long? Height { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1280</para>
            /// </summary>
            [NameInMap("width")]
            [Validation(Required=false)]
            public long? Width { get; set; }

        }

        [NameInMap("offline_video_transcoding_list")]
        [Validation(Required=false)]
        public List<VideoPreviewPlayMetaOfflineVideoTranscodingList> OfflineVideoTranscodingList { get; set; }
        public class VideoPreviewPlayMetaOfflineVideoTranscodingList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("keep_original_resolution")]
            [Validation(Required=false)]
            public string KeepOriginalResolution { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>finished</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>264_720p</para>
            /// </summary>
            [NameInMap("template_id")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

        }

        [NameInMap("quick_video_list")]
        [Validation(Required=false)]
        public List<VideoPreviewPlayMetaQuickVideoList> QuickVideoList { get; set; }
        public class VideoPreviewPlayMetaQuickVideoList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>finished</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>264_720p</para>
            /// </summary>
            [NameInMap("template_id")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

        }

    }

}
