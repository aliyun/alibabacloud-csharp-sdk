// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class VideoPreviewPlayInfo : TeaModel {
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
        /// <para>Live transcoding subtitle information.</para>
        /// </summary>
        [NameInMap("live_transcoding_subtitle_task_list")]
        [Validation(Required=false)]
        public List<VideoPreviewSubtitleInfo> LiveTranscodingSubtitleTaskList { get; set; }

        /// <summary>
        /// <para>The information about video playback.</para>
        /// </summary>
        [NameInMap("live_transcoding_task_list")]
        [Validation(Required=false)]
        public List<VideoPreviewPlayInfoLiveTranscodingTaskList> LiveTranscodingTaskList { get; set; }
        public class VideoPreviewPlayInfoLiveTranscodingTaskList : TeaModel {
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
            /// <para>Template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>264_480p</para>
            /// </summary>
            [NameInMap("template_id")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>Playback URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.data.aliyunpds.com/lt/xxx/media.m3u8">https://example.data.aliyunpds.com/lt/xxx/media.m3u8</a></para>
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>Playback URL of master m3u8.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://pds-xxx-valueadd.oss-xxx.aliyuncs.com/qv/xxx/master.m3u8">https://pds-xxx-valueadd.oss-xxx.aliyuncs.com/qv/xxx/master.m3u8</a></para>
        /// </summary>
        [NameInMap("master_url")]
        [Validation(Required=false)]
        public string MasterUrl { get; set; }

        /// <summary>
        /// <para>Video meta information.</para>
        /// </summary>
        [NameInMap("meta")]
        [Validation(Required=false)]
        public VideoPreviewPlayInfoMeta Meta { get; set; }
        public class VideoPreviewPlayInfoMeta : TeaModel {
            /// <summary>
            /// <para>Video length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4.2898</para>
            /// </summary>
            [NameInMap("duration")]
            [Validation(Required=false)]
            public double? Duration { get; set; }

            /// <summary>
            /// <para>Height of the video</para>
            /// 
            /// <b>Example:</b>
            /// <para>1080</para>
            /// </summary>
            [NameInMap("height")]
            [Validation(Required=false)]
            public long? Height { get; set; }

            /// <summary>
            /// <para>Width of the video.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1920</para>
            /// </summary>
            [NameInMap("width")]
            [Validation(Required=false)]
            public long? Width { get; set; }

        }

        /// <summary>
        /// <para>Offline transcoding playback information.</para>
        /// </summary>
        [NameInMap("offline_video_transcoding_list")]
        [Validation(Required=false)]
        public List<VideoPreviewPlayInfoOfflineVideoTranscodingList> OfflineVideoTranscodingList { get; set; }
        public class VideoPreviewPlayInfoOfflineVideoTranscodingList : TeaModel {
            /// <summary>
            /// <para>Whether the transcoded video has the same resolution as the source video.</para>
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
            /// <para>The task status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>finished</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>264_1080p</para>
            /// </summary>
            [NameInMap("template_id")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>Playback URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.data.aliyunpds.com/xxx/master.mp4">https://example.data.aliyunpds.com/xxx/master.mp4</a></para>
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>Offline transcoding subtitle information.</para>
        /// </summary>
        [NameInMap("offline_video_transcoding_subtitle_list")]
        [Validation(Required=false)]
        public List<VideoPreviewSubtitleInfo> OfflineVideoTranscodingSubtitleList { get; set; }

        /// <summary>
        /// <para>The information about video playback.</para>
        /// </summary>
        [NameInMap("quick_video_list")]
        [Validation(Required=false)]
        public List<VideoPreviewPlayInfoQuickVideoList> QuickVideoList { get; set; }
        public class VideoPreviewPlayInfoQuickVideoList : TeaModel {
            /// <summary>
            /// <para>Valid values:</para>
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
            /// <para>264_480p</para>
            /// </summary>
            [NameInMap("template_id")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>Playback URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.data.aliyunpds.com/qv/xxx/media.m3u8">https://example.data.aliyunpds.com/qv/xxx/media.m3u8</a></para>
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>Quick transcoding subtitle information.</para>
        /// </summary>
        [NameInMap("quick_video_subtitle_list")]
        [Validation(Required=false)]
        public List<VideoPreviewSubtitleInfo> QuickVideoSubtitleList { get; set; }

    }

}
