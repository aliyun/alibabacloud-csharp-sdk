// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateMediaConvertTaskRequest : TeaModel {
        /// <summary>
        /// <para>When performing media concatenation, the index of the primary media file (which provides the default transcoding parameters for <c>Video</c> and <c>Audio</c>, including resolution, frame rate, etc.) in the concatenation list. The default value is 0 (aligning with the first media file in the concatenation list).</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AlignmentIndex")]
        [Validation(Required=false)]
        public int? AlignmentIndex { get; set; }

        /// <summary>
        /// <para><b>If there are no special requirements, please leave this blank.</b></para>
        /// <para>Chain authorization configuration. For more information, see <a href="https://help.aliyun.com/document_detail/465340.html">Using Chain Authorization to Access Other Entity Resources</a>.</para>
        /// </summary>
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public CredentialConfig CredentialConfig { get; set; }

        /// <summary>
        /// <para>Notification configuration. For details, click Notification. The format of asynchronous notification messages can be found in <a href="https://help.aliyun.com/document_detail/2743997.html">Asynchronous Notification Message Format</a>.</para>
        /// </summary>
        [NameInMap("Notification")]
        [Validation(Required=false)]
        public Notification Notification { get; set; }

        /// <summary>
        /// <para>The name of the project. For how to obtain it, see <a href="https://help.aliyun.com/document_detail/478153.html">Creating a Project</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>A list of media files. If the list contains more than one element, it indicates that the Concat (concatenation) function is enabled. The Concat order follows the sequence of the input video file URIs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Sources")]
        [Validation(Required=false)]
        public List<CreateMediaConvertTaskRequestSources> Sources { get; set; }
        public class CreateMediaConvertTaskRequestSources : TeaModel {
            /// <summary>
            /// <para>The alignment strategy for adding audio and video streams, with the following value range:</para>
            /// <list type="bullet">
            /// <item><description>false (default): No alignment.</description></item>
            /// <item><description>loop: Loop the audio and video content to align.</description></item>
            /// <item><description>pad: Align by padding silent frames and black video frames.<remarks>
            /// <list type="bullet">
            /// <item><description>Only valid when the Attached parameter is true.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AlignMode")]
            [Validation(Required=false)]
            public string AlignMode { get; set; }

            /// <summary>
            /// <para>Add the current source media file as a synchronized audio or video stream to the output media file, with a default value of false.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>The AlignmentIndex parameter pointing to the Attached parameter of the Source cannot be true.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Attached")]
            [Validation(Required=false)]
            public bool? Attached { get; set; }

            /// <summary>
            /// <para>Whether to disable the audio in the source media file. The value range is as follows:</para>
            /// <list type="bullet">
            /// <item><description>true: Disable.</description></item>
            /// <item><description>false (default): Do not disable.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DisableAudio")]
            [Validation(Required=false)]
            public bool? DisableAudio { get; set; }

            /// <summary>
            /// <para>Whether to disable the video in the source media file. The value range is as follows:</para>
            /// <list type="bullet">
            /// <item><description>true: Disable.</description></item>
            /// <item><description>false (default): Do not disable.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DisableVideo")]
            [Validation(Required=false)]
            public bool? DisableVideo { get; set; }

            /// <summary>
            /// <para>The duration of media transcoding, in seconds. The default value is 0, indicating until the end of the video.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public double? Duration { get; set; }

            /// <summary>
            /// <para>The start time for media transcoding, in seconds. The value range is as follows:</para>
            /// <list type="bullet">
            /// <item><description>0 (default): Start transcoding from the beginning of the media.</description></item>
            /// <item><description>n (greater than 0): Start transcoding n seconds after the beginning of the media.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public double? StartTime { get; set; }

            /// <summary>
            /// <para>A list of subtitles to add, which is empty by default.</para>
            /// </summary>
            [NameInMap("Subtitles")]
            [Validation(Required=false)]
            public List<CreateMediaConvertTaskRequestSourcesSubtitles> Subtitles { get; set; }
            public class CreateMediaConvertTaskRequestSourcesSubtitles : TeaModel {
                /// <summary>
                /// <para>The language of the subtitle, referenced by ISO 639-2, with a default value of empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eng</para>
                /// </summary>
                [NameInMap("Language")]
                [Validation(Required=false)]
                public string Language { get; set; }

                /// <summary>
                /// <para>The subtitle delay time, in seconds, with a default value of 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.5</para>
                /// </summary>
                [NameInMap("TimeOffset")]
                [Validation(Required=false)]
                public double? TimeOffset { get; set; }

                /// <summary>
                /// <para>The OSS address rule is <c>oss://${Bucket}/${Object}</c>, where <c>${Bucket}</c> is the name of the OSS Bucket in the same region (Region) as the current project, and <c>${Object}</c> is the complete path of the file including the file extension.
                /// Supported subtitle formats include: srt, vtt, mov_text, ass, dvd_sub, pgs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss://test-bucket/test-object</para>
                /// </summary>
                [NameInMap("URI")]
                [Validation(Required=false)]
                public string URI { get; set; }

            }

            /// <summary>
            /// <para>The OSS address rule is <c>oss://${Bucket}/${Object}</c>, where <c>${Bucket}</c> is the name of the OSS Bucket in the same region (Region) as the current project, and <c>${Object}</c> is the complete path of the file including the file extension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://test-bucket/test-object</para>
            /// </summary>
            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

        }

        /// <summary>
        /// <para>Custom tags used for searching and filtering asynchronous tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;test&quot;:&quot;val1&quot;}</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tags { get; set; }

        /// <summary>
        /// <para>List of media processing tasks, supporting multiple task configurations.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Targets")]
        [Validation(Required=false)]
        public List<CreateMediaConvertTaskRequestTargets> Targets { get; set; }
        public class CreateMediaConvertTaskRequestTargets : TeaModel {
            /// <summary>
            /// <para>Audio processing parameter configuration.</para>
            /// <remarks>
            /// <para>Notice: If Audio is null, the first audio stream (if present) will be directly copied to the output file.</notice></para>
            /// </remarks>
            /// </summary>
            [NameInMap("Audio")]
            [Validation(Required=false)]
            public TargetAudio Audio { get; set; }

            /// <summary>
            /// <para>Media container type. Available container types are as follows:</para>
            /// <list type="bullet">
            /// <item><description>Audio and video containers: mp4, mkv, mov, asf, avi, mxf, ts, flv</description></item>
            /// <item><description>Audio containers: mp3, aac, flac, oga, ac3, opus<remarks>
            /// <para>Notice: Both Container and URI parameters need to be set. If only subtitle extraction, frame capture, sprite image capture, or media-to-gif conversion is performed, both Container and URI should be set to null, making the Segment, Video, Audio, and Speed parameters meaningless.</notice></para>
            /// </remarks>
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
            /// <para>Configuration for frame capture, sprite image capture, and media to animated image conversion.</para>
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public TargetImage Image { get; set; }

            /// <summary>
            /// <para>Media segment settings, no segmentation by default.</para>
            /// </summary>
            [NameInMap("Segment")]
            [Validation(Required=false)]
            public CreateMediaConvertTaskRequestTargetsSegment Segment { get; set; }
            public class CreateMediaConvertTaskRequestTargetsSegment : TeaModel {
                /// <summary>
                /// <para>Segment length. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public double? Duration { get; set; }

                /// <summary>
                /// <para>Media slicing method. The value range is as follows:</para>
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
                /// <para>Starting sequence number, supported only for hls, default is 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("StartNumber")]
                [Validation(Required=false)]
                public int? StartNumber { get; set; }

            }

            /// <summary>
            /// <para>Media playback speed setting, with a value range of [0.5,1.0], default is 1.0.</para>
            /// <remarks>
            /// <para>The ratio of the playback speed of the transcoded media file to the original media file, not a speed-up transcoding.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("Speed")]
            [Validation(Required=false)]
            public float? Speed { get; set; }

            /// <summary>
            /// <para>Removes metadata from the media file, such as <c>title</c>, <c>album</c>, etc. The default value is false.</para>
            /// </summary>
            [NameInMap("StripMetadata")]
            [Validation(Required=false)]
            public bool? StripMetadata { get; set; }

            /// <summary>
            /// <para>Subtitle processing parameter configuration.</para>
            /// <remarks>
            /// <para>Notice: If Subtitle is null, the first subtitle stream (if present) will be directly copied to the output file.</notice></para>
            /// </remarks>
            /// </summary>
            [NameInMap("Subtitle")]
            [Validation(Required=false)]
            public TargetSubtitle Subtitle { get; set; }

            /// <summary>
            /// <para>OSS address for the output file of media transcoding.</para>
            /// <para>The OSS address rule is <c>oss://${Bucket}/${Object}</c>, where <c>${Bucket}</c> is the name of the OSS Bucket in the same region (Region) as the current project, and <c>${Object}</c> is the complete path of the file including the file extension.</para>
            /// <list type="bullet">
            /// <item><description>When <b>URI</b> has an extension, the OSS address for the transcoded media file will be <b>URI</b>. If there are multiple output files, they may overwrite each other.</description></item>
            /// <item><description>When <b>URI</b> does not have an extension, the OSS address for the transcoded media file is determined by the <b>URI</b>, <b>Container</b>, and <b>Segment</b> parameters. For example, if <b>URI</b> is <c>oss://examplebucket/outputVideo</c>:<list type="bullet">
            /// <item><description>When <b>Container</b> is <c>mp4</c> and <b>Segment</b> is empty, the generated media file\&quot;s OSS address will be <c>oss://examplebucket/outputVideo.mp4</c>.</description></item>
            /// <item><description>When <b>Container</b> is <c>ts</c> and <b>Segment</b>\&quot;s <b>Format</b> is <c>hls</c>, it will generate an m3u8 file with the OSS address <c>oss://examplebucket/outputVideo.m3u8</c> and multiple ts files with the prefix <c>oss://examplebucket/outputVideo</c>.</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>oss://test-bucket/test-target-object.mp4</para>
            /// </summary>
            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

            /// <summary>
            /// <para>Video processing parameter configuration.</para>
            /// <remarks>
            /// <para>Notice: If Video is null, the first video stream (if present) will be directly copied to the output file.</notice></para>
            /// </remarks>
            /// </summary>
            [NameInMap("Video")]
            [Validation(Required=false)]
            public TargetVideo Video { get; set; }

        }

        /// <summary>
        /// <para>User-defined information that will be returned in asynchronous message notifications, used for convenient association and processing within your system. The maximum length is 2048 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ID&quot;: &quot;testuid&quot;,&quot;Name&quot;: &quot;test-user&quot;,&quot;Avatar&quot;: &quot;<a href="http://test.com/testuid%22%7D">http://test.com/testuid&quot;}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
