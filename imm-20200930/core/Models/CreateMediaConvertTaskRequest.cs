// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateMediaConvertTaskRequest : TeaModel {
        /// <summary>
        /// <para>The sequence number of the main media file in the concatenation list of media files. The main media file provides the default transcoding settings, such as the resolution and the frame rate, for videos and audios. Default value: <c>0</c>. A value of <c>0</c> specifies that the main media file is aligned with the first media file in the concatenation list.</para>
        /// </summary>
        [NameInMap("AlignmentIndex")]
        [Validation(Required=false)]
        public int? AlignmentIndex { get; set; }

        /// <summary>
        /// <para><b>If you have no special requirements, leave this parameter empty.</b></para>
        /// <para>The authorization chain. For more information, see <a href="https://help.aliyun.com/document_detail/465340.html">Use authorization chains to access resources of other entities</a>.</para>
        /// </summary>
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public CredentialConfig CredentialConfig { get; set; }

        /// <summary>
        /// <para>The notification settings. For more information, see &quot;Notification&quot;. For information about the asynchronous notification format, see <a href="https://help.aliyun.com/document_detail/2743997.html">Asynchronous notification format</a>.</para>
        /// </summary>
        [NameInMap("Notification")]
        [Validation(Required=false)]
        public Notification Notification { get; set; }

        /// <summary>
        /// <para>The name of the project. You can obtain the name of the project from the response of the <a href="https://help.aliyun.com/document_detail/478153.html">CreateProject</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>immtest</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The source media files. If multiple files exist at the same time, the Concat feature is enabled. The video files are concatenated in the order of their URI inputs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Sources")]
        [Validation(Required=false)]
        public List<CreateMediaConvertTaskRequestSources> Sources { get; set; }
        public class CreateMediaConvertTaskRequestSources : TeaModel {
            /// <summary>
            /// <para>The transcoding duration of the media. Unit: seconds. Default value: 0. A value of 0 specifies that the transcoding duration lasts until the end of the video.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public double? Duration { get; set; }

            /// <summary>
            /// <para>The start time of the media transcoding task. Unit: seconds. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0 (default): starts transcoding when the media starts playing.</description></item>
            /// <item><description>n: starts transcoding n seconds after the media starts playing. n must be greater than 0.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public double? StartTime { get; set; }

            /// <summary>
            /// <para>The subtitles. By default, this parameter is left empty.</para>
            /// </summary>
            [NameInMap("Subtitles")]
            [Validation(Required=false)]
            public List<CreateMediaConvertTaskRequestSourcesSubtitles> Subtitles { get; set; }
            public class CreateMediaConvertTaskRequestSourcesSubtitles : TeaModel {
                /// <summary>
                /// <para>The subtitle language. If you specify this parameter, comply with the ISO 639-2 standard. This parameter is left empty by default.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eng</para>
                /// </summary>
                [NameInMap("Language")]
                [Validation(Required=false)]
                public string Language { get; set; }

                /// <summary>
                /// <para>The time offset of the subtitle. Unit: seconds. Default value: 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.5</para>
                /// </summary>
                [NameInMap("TimeOffset")]
                [Validation(Required=false)]
                public double? TimeOffset { get; set; }

                /// <summary>
                /// <para>The URI of the Object Storage Service (OSS) bucket. Specify the value in the <c>oss://${Bucket}/${Object}</c> format. <c>${Bucket}</c> specifies the name of the OSS bucket that resides in the same region with the current project. <c>${Object}</c> specifies the complete path to the file whose name contains an extension. The following subtitle formats are supported: srt, vtt, mov_text, ass, dvd_sub, and pgs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss://test-bucket/subtitles</para>
                /// </summary>
                [NameInMap("URI")]
                [Validation(Required=false)]
                public string URI { get; set; }

            }

            /// <summary>
            /// <para>The URI of the Object Storage Service (OSS) bucket. Specify the value in the <c>oss://${Bucket}/${Object}</c> format. <c>${Bucket}</c> specifies the name of the OSS bucket that resides in the same region with the current project. <c>${Object}</c> specifies the complete path to the file whose name contains an extension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://test-bucket/test-object</para>
            /// </summary>
            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

        }

        /// <summary>
        /// <para>The custom tags. You can search for or filter asynchronous tasks by custom tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;test&quot;:&quot;val1&quot;}</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tags { get; set; }

        /// <summary>
        /// <para>The media processing tasks. You can specify multiple values for this parameter.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Targets")]
        [Validation(Required=false)]
        public List<CreateMediaConvertTaskRequestTargets> Targets { get; set; }
        public class CreateMediaConvertTaskRequestTargets : TeaModel {
            /// <summary>
            /// <para>The audio processing settings.</para>
            /// <remarks>
            /// <para> If you leave Audio empty and the first audio stream exists, the first audio stream is directly copied to the output file.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Audio")]
            [Validation(Required=false)]
            public TargetAudio Audio { get; set; }

            /// <summary>
            /// <para>The type of the media container.</para>
            /// <list type="bullet">
            /// <item><description><para>Valid values for audio and video containers: mp4, mkv, mov, asf, avi, mxf, ts, and flv.</para>
            /// </description></item>
            /// <item><description><para>Valid values only for audio containers: mp3, aac, flac, oga, ac3, and opus.</para>
            /// <para>**</para>
            /// <para><b>Note</b> Specify Container and URI at the same time. If you want to extract subtitles, capture frames, capture image sprites, or rotate media images, set Container and URI to null. In this case, Segment, Video, Audio, and Speed do not take effect.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>mp4</para>
            /// </summary>
            [NameInMap("Container")]
            [Validation(Required=false)]
            public string Container { get; set; }

            /// <summary>
            /// <para>The frame capturing, sprite capturing, and media rotation settings.</para>
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public TargetImage Image { get; set; }

            /// <summary>
            /// <para>The media segmentation settings. By default, no segmentation is performed.</para>
            /// </summary>
            [NameInMap("Segment")]
            [Validation(Required=false)]
            public CreateMediaConvertTaskRequestTargetsSegment Segment { get; set; }
            public class CreateMediaConvertTaskRequestTargetsSegment : TeaModel {
                /// <summary>
                /// <para>The duration of the segment. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public double? Duration { get; set; }

                /// <summary>
                /// <para>The media segmentation mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>hls</description></item>
                /// <item><description>dash</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>hls</para>
                /// </summary>
                [NameInMap("Format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                /// <summary>
                /// <para>The start sequence number. You can specify this parameter only if you set Format to hls. Default value: 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("StartNumber")]
                [Validation(Required=false)]
                public int? StartNumber { get; set; }

            }

            /// <summary>
            /// <para>The playback speed of the media. Valid values: 0.5 to 2. Default value: 1.0.</para>
            /// <remarks>
            /// <para> This parameter specifies the ratio of the non-regular playback speed of the transcoded media file to the default playback speed of the source media file.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("Speed")]
            [Validation(Required=false)]
            public float? Speed { get; set; }

            /// <summary>
            /// <para>Specifies whether to remove the metadata, such as <c>title</c> and <c>album</c>, from the media file. Default value: false.</para>
            /// </summary>
            [NameInMap("StripMetadata")]
            [Validation(Required=false)]
            public bool? StripMetadata { get; set; }

            /// <summary>
            /// <para>The subtitle processing settings.</para>
            /// <remarks>
            /// <para> If you leave Subtitle empty and the first subtitle stream exists, the first subtitle stream is directly copied to the output file.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Subtitle")]
            [Validation(Required=false)]
            public TargetSubtitle Subtitle { get; set; }

            /// <summary>
            /// <para>The URI of the OSS bucket in which you want to store the media transcoding output file.</para>
            /// <para>Specify the value in the <c>oss://${Bucket}/${Object}</c> format. <c>${Bucket}</c> specifies the name of the OSS bucket that resides in the same region with the current project. <c>${Object}</c> specifies the complete path to the file whose name contains an extension.</para>
            /// <list type="bullet">
            /// <item><description><para>If the value of <b>URI</b> contains an extension, the endpoint of the OSS bucket matches the URI. If multiple media transcoding output files exist, the endpoints of the correspodning OSS buckets may be overwritten.****</para>
            /// </description></item>
            /// <item><description><para>If the value of <b>URI</b> does not contain an extension, the endpoint of the OSS bucket consists of the following parameters: <b>URI</b>, <b>Container</b>, and <b>Segment</b>. In the following examples, the value of <b>URI</b> is <c>oss://examplebucket/outputVideo</c>.</para>
            /// <list type="bullet">
            /// <item><description>If the value of <b>Container</b> is <c>mp4</c> and the value of <b>Segment</b> is null, the endpoint of the OSS bucket is <c>oss://examplebucket/outputVideo.mp4</c>.</description></item>
            /// <item><description>If the value of <b>Container</b> is <c>ts</c> and the value of <b>Format</b> in <b>Segment</b> is <c>hls</c>, the endpoint of the OSS bucket is <c>oss://examplebucket/outputVideo.m3u8</c>. In addition, multiple ts files prefixed with <c>oss://examplebucket/outputVideo</c> are generated.</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>oss://test-bucket/targets</para>
            /// </summary>
            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

            /// <summary>
            /// <para>The video processing settings.</para>
            /// <remarks>
            /// <para> If you leave Video empty and the first video stream exists, the first video stream is directly copied to the output file.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Video")]
            [Validation(Required=false)]
            public TargetVideo Video { get; set; }

        }

        /// <summary>
        /// <para>The custom information, which is returned as asynchronous notifications to facilitate notification management in your system. The maximum information length is 2,048 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ID&quot;: &quot;user1&quot;,&quot;Name&quot;: &quot;test-user1&quot;,&quot;Avatar&quot;: &quot;<a href="http://example.com?id=user1%22%7D">http://example.com?id=user1&quot;}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
