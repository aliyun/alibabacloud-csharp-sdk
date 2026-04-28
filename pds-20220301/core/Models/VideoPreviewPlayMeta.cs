// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class VideoPreviewPlayMeta : TeaModel {
        /// <summary>
        /// <para>Category</para>
        /// 
        /// <b>Example:</b>
        /// <para>live_transcoding</para>
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>Status of the live transcoding job.</para>
        /// </summary>
        [NameInMap("live_transcoding_task_list")]
        [Validation(Required=false)]
        public List<VideoPreviewPlayMetaLiveTranscodingTaskList> LiveTranscodingTaskList { get; set; }
        public class VideoPreviewPlayMetaLiveTranscodingTaskList : TeaModel {
            /// <summary>
            /// <para>Whether the original resolution is maintained.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("keep_original_resolution")]
            [Validation(Required=false)]
            public bool? KeepOriginalResolution { get; set; }

            /// <summary>
            /// <para>The status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>finished: The index is complete, and the url can be obtained.</description></item>
            /// <item><description>running: Indexing in progress. Wait a moment and try again.</description></item>
            /// <item><description>failed: Transcoding failed. Check the media file. If you have any questions, contact customer service.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>finished</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Template ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>264_720p</para>
            /// </summary>
            [NameInMap("template_id")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

        }

        /// <summary>
        /// <para>Video meta information.</para>
        /// </summary>
        [NameInMap("meta")]
        [Validation(Required=false)]
        public VideoPreviewPlayMetaMeta Meta { get; set; }
        public class VideoPreviewPlayMetaMeta : TeaModel {
            /// <summary>
            /// <para>Length of the video.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("duration")]
            [Validation(Required=false)]
            public double? Duration { get; set; }

            /// <summary>
            /// <para>Height of the video.</para>
            /// 
            /// <b>Example:</b>
            /// <para>720</para>
            /// </summary>
            [NameInMap("height")]
            [Validation(Required=false)]
            public long? Height { get; set; }

            /// <summary>
            /// <para>Width of the video.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1280</para>
            /// </summary>
            [NameInMap("width")]
            [Validation(Required=false)]
            public long? Width { get; set; }

        }

        /// <summary>
        /// <para>The status of the offline transcoding job.</para>
        /// </summary>
        [NameInMap("offline_video_transcoding_list")]
        [Validation(Required=false)]
        public List<VideoPreviewPlayMetaOfflineVideoTranscodingList> OfflineVideoTranscodingList { get; set; }
        public class VideoPreviewPlayMetaOfflineVideoTranscodingList : TeaModel {
            /// <summary>
            /// <para>Whether the original resolution is maintained.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("keep_original_resolution")]
            [Validation(Required=false)]
            public string KeepOriginalResolution { get; set; }

            /// <summary>
            /// <para>The status. finished: The index is completed, and the url can be obtained. running: Indexing in progress. Wait a moment and try again. failed: Transcoding failed. Check the media file. If you have any questions, contact customer service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>finished</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Template ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>264_720p</para>
            /// </summary>
            [NameInMap("template_id")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

        }

        /// <summary>
        /// <para>The state of the transcoding job.</para>
        /// </summary>
        [NameInMap("quick_video_list")]
        [Validation(Required=false)]
        public List<VideoPreviewPlayMetaQuickVideoList> QuickVideoList { get; set; }
        public class VideoPreviewPlayMetaQuickVideoList : TeaModel {
            /// <summary>
            /// <para>The status. finished: The index is completed, and the url can be obtained. running: Indexing in progress. Wait a moment and try again. failed: Transcoding failed. Check the media file. If you have any questions, contact customer service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>finished</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Template ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>264_720p</para>
            /// </summary>
            [NameInMap("template_id")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

        }

    }

}
