// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateMediaConvertTaskRequest : TeaModel {
        /// <summary>
        /// <para>When concatenating media files, this specifies the index of the primary file in the Sources list. The default transcoding parameters (such as resolution and frame rate from the <c>Video</c> and <c>Audio</c> objects) are taken from this primary file. The default index is 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AlignmentIndex")]
        [Validation(Required=false)]
        public int? AlignmentIndex { get; set; }

        /// <summary>
        /// <para><b>You can leave this parameter empty if you do not have special requirements.</b></para>
        /// <para>The chained authorization configuration. For more information, see <a href="https://help.aliyun.com/document_detail/465340.html">Use chained authorization to access resources of other entities</a>.</para>
        /// </summary>
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public CredentialConfig CredentialConfig { get; set; }

        /// <summary>
        /// <para>The message notification settings. For more information, click Notification. For information about the format of asynchronous notifications, see <a href="https://help.aliyun.com/document_detail/2743997.html">Asynchronous notification format</a>.</para>
        /// </summary>
        [NameInMap("Notification")]
        [Validation(Required=false)]
        public Notification Notification { get; set; }

        /// <summary>
        /// <para>The name of the project. For more information about how to obtain the project name, see <a href="https://help.aliyun.com/document_detail/478153.html">Create a project</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>A list of media files. If you provide more than one file, they are concatenated in the order of their URIs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Sources")]
        [Validation(Required=false)]
        public List<CreateMediaConvertTaskRequestSources> Sources { get; set; }
        public class CreateMediaConvertTaskRequestSources : TeaModel {
            /// <summary>
            /// <para>The alignment mode for the added audio and video streams. Valid values include:</para>
            /// <list type="bullet">
            /// <item><description><para>false (default): No alignment is performed.</para>
            /// </description></item>
            /// <item><description><para>loop: Aligns content by looping the audio or video.</para>
            /// </description></item>
            /// <item><description><para>pad: Aligns content by padding with silent frames or black frames.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>This parameter only takes effect if Attached is set to true.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AlignMode")]
            [Validation(Required=false)]
            public string AlignMode { get; set; }

            /// <summary>
            /// <para>If true, adds the current source media file to the output as a synchronized audio stream or video stream. The default is false.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>You cannot set Attached to true for the source media file referenced by AlignmentIndex.</description></item>
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
            /// <para>Specifies whether to disable the audio from the source media file. Valid values include:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Disables the audio.</para>
            /// </description></item>
            /// <item><description><para>false (default): Includes the audio.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DisableAudio")]
            [Validation(Required=false)]
            public bool? DisableAudio { get; set; }

            /// <summary>
            /// <para>Specifies whether to disable the video from the source media file. Valid values include:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Disables the video.</para>
            /// </description></item>
            /// <item><description><para>false (default): Includes the video.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DisableVideo")]
            [Validation(Required=false)]
            public bool? DisableVideo { get; set; }

            /// <summary>
            /// <para>The duration of media transcoding in seconds. The default value, 0, transcodes the media until its end.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public double? Duration { get; set; }

            /// <summary>
            /// <para>The start time of media transcoding, in seconds. Valid values include:</para>
            /// <list type="bullet">
            /// <item><description><para>0 (default): Transcoding starts from the beginning of the media file.</para>
            /// </description></item>
            /// <item><description><para>n (a value greater than 0): Transcoding starts n seconds into the media file.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public double? StartTime { get; set; }

            /// <summary>
            /// <para>A list of subtitles to add.</para>
            /// </summary>
            [NameInMap("Subtitles")]
            [Validation(Required=false)]
            public List<CreateMediaConvertTaskRequestSourcesSubtitles> Subtitles { get; set; }
            public class CreateMediaConvertTaskRequestSourcesSubtitles : TeaModel {
                /// <summary>
                /// <para>The language of the subtitle. The value must comply with the ISO 639-2 standard.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eng</para>
                /// </summary>
                [NameInMap("Language")]
                [Validation(Required=false)]
                public string Language { get; set; }

                /// <summary>
                /// <para>The subtitle delay, in seconds. The default value is 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.5</para>
                /// </summary>
                [NameInMap("TimeOffset")]
                [Validation(Required=false)]
                public double? TimeOffset { get; set; }

                /// <summary>
                /// <para>The OSS URI of the object. The URI must use the <c>oss://${Bucket}/${Object}</c> format, where <c>${Bucket}</c> is the name of an OSS bucket in the same region as the project, and <c>${Object}</c> is the full path to the object, including its file extension.
                /// Supported subtitle formats include: srt, vtt, mov_text, ass, dvd_sub, and pgs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss://test-bucket/test-object</para>
                /// </summary>
                [NameInMap("URI")]
                [Validation(Required=false)]
                public string URI { get; set; }

            }

            /// <summary>
            /// <para>The OSS URI of the object. The URI must use the <c>oss://${Bucket}/${Object}</c> format, where <c>${Bucket}</c> is the name of an OSS bucket in the same region as the project, and <c>${Object}</c> is the full path to the object, including its file extension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://test-bucket/test-object</para>
            /// </summary>
            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

        }

        /// <summary>
        /// <para>Custom tags for searching and filtering asynchronous tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;test&quot;:&quot;val1&quot;}</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tags { get; set; }

        /// <summary>
        /// <para>A list of media packaging tasks to convert and package the input media into HLS outputs. Each TargetGroup corresponds to one HLS master playlist.</para>
        /// </summary>
        [NameInMap("TargetGroups")]
        [Validation(Required=false)]
        public List<CreateMediaConvertTaskRequestTargetGroups> TargetGroups { get; set; }
        public class CreateMediaConvertTaskRequestTargetGroups : TeaModel {
            /// <summary>
            /// <para>A list of media packaging subtasks. Each <c>Target</c> corresponds to a variant stream (<c>#EXT-X-STREAM-INF</c>) in the HLS master playlist and generates a corresponding HLS media playlist.</para>
            /// </summary>
            [NameInMap("Targets")]
            [Validation(Required=false)]
            public List<CreateMediaConvertTaskRequestTargetGroupsTargets> Targets { get; set; }
            public class CreateMediaConvertTaskRequestTargetGroupsTargets : TeaModel {
                /// <summary>
                /// <para>The audio processing parameters.</para>
                /// <remarks>
                /// <para>Notice: If this parameter is left empty, the first audio stream, if it exists, is copied directly to the output file.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("Audio")]
                [Validation(Required=false)]
                public TargetAudio Audio { get; set; }

                /// <summary>
                /// <para>The packaging container type. Only <c>mp4</c> and <c>ts</c> are supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mp4</para>
                /// </summary>
                [NameInMap("Container")]
                [Validation(Required=false)]
                public string Container { get; set; }

                /// <summary>
                /// <para>The media packaging settings.</para>
                /// </summary>
                [NameInMap("Segment")]
                [Validation(Required=false)]
                public CreateMediaConvertTaskRequestTargetGroupsTargetsSegment Segment { get; set; }
                public class CreateMediaConvertTaskRequestTargetGroupsTargetsSegment : TeaModel {
                    /// <summary>
                    /// <para>The duration of each segment, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public double? Duration { get; set; }

                    /// <summary>
                    /// <para>The media packaging format. Only <c>hls</c> is supported.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>hls</para>
                    /// </summary>
                    [NameInMap("Format")]
                    [Validation(Required=false)]
                    public string Format { get; set; }

                    /// <summary>
                    /// <para>The starting sequence number for segments. The default is 0.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("StartNumber")]
                    [Validation(Required=false)]
                    public int? StartNumber { get; set; }

                }

                /// <summary>
                /// <para>The playback speed of the output media. The value must be between 0.5 and 1.0, inclusive. The default value is 1.0.</para>
                /// <remarks>
                /// <para>This parameter specifies the default playback speed of the output file as a ratio of the source file\&quot;s speed. It does not perform speed-up transcoding.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1.0</para>
                /// </summary>
                [NameInMap("Speed")]
                [Validation(Required=false)]
                public float? Speed { get; set; }

                /// <summary>
                /// <para>If true, removes metadata from the output file. The default is false.</para>
                /// </summary>
                [NameInMap("StripMetadata")]
                [Validation(Required=false)]
                public bool? StripMetadata { get; set; }

                /// <summary>
                /// <para>The subtitle processing parameters.</para>
                /// <remarks>
                /// <para>Notice: You must use the <c>Subtitle.ExtractSubtitle</c> parameter to package subtitle streams. The <c>URI</c> in <c>Subtitle.ExtractSubtitle</c> must be in the same directory as or a subdirectory of <c>TargetGroups.URI</c>. The <c>Format</c> in <c>Subtitle.ExtractSubtitle</c> must be <c>vtt</c>. You only need to configure this parameter in one <c>Target</c> to package all subtitle streams.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("Subtitle")]
                [Validation(Required=false)]
                public TargetSubtitle Subtitle { get; set; }

                /// <summary>
                /// <para>The OSS URI of the output HLS media playlist file for the subtask.</para>
                /// <remarks>
                /// <para>Notice: This URI must be in the same directory as or a subdirectory of <c>TargetGroups.URI</c>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>oss://test-bucket/test-target-object.mp4</para>
                /// </summary>
                [NameInMap("URI")]
                [Validation(Required=false)]
                public string URI { get; set; }

                /// <summary>
                /// <para>The video processing parameters.</para>
                /// <remarks>
                /// <para>Notice: If this parameter is left empty, the first video stream, if it exists, is copied directly to the output file.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("Video")]
                [Validation(Required=false)]
                public TargetVideo Video { get; set; }

            }

            /// <summary>
            /// <para>The OSS URI of the output HLS master playlist file for the packaging task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://test-bucket/test-object/master.m3u8</para>
            /// </summary>
            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

        }

        /// <summary>
        /// <para>A list of media processing tasks.</para>
        /// </summary>
        [NameInMap("Targets")]
        [Validation(Required=false)]
        public List<CreateMediaConvertTaskRequestTargets> Targets { get; set; }
        public class CreateMediaConvertTaskRequestTargets : TeaModel {
            /// <summary>
            /// <para>Settings for retaining attached pictures.</para>
            /// <remarks>
            /// <para>Notice: Retaining attached pictures is supported only when the <c>Container</c> parameter is set to <c>mp4</c> or <c>mkv</c>.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("AttachedPicture")]
            [Validation(Required=false)]
            public CreateMediaConvertTaskRequestTargetsAttachedPicture AttachedPicture { get; set; }
            public class CreateMediaConvertTaskRequestTargetsAttachedPicture : TeaModel {
                /// <summary>
                /// <para>A list of indexes of the attached pictures in the source file to process. An empty list (default) indicates that no attached pictures are retained. An index of -1 indicates that all attached pictures are retained.</para>
                /// <list type="bullet">
                /// <item><description>Example: <c>[0,1]</c> processes the attached pictures with index 0 and 1; <c>[1]</c> processes the attached picture with index 1; <c>[-1]</c> processes all attached pictures.</description></item>
                /// </list>
                /// <remarks>
                /// <para>If a specified index does not correspond to an existing attached picture, it is ignored.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("Stream")]
                [Validation(Required=false)]
                public List<int?> Stream { get; set; }

            }

            /// <summary>
            /// <para>The audio processing parameters.</para>
            /// <remarks>
            /// <para>Notice: If this parameter is left empty, the first audio stream, if it exists, is copied directly to the output file.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Audio")]
            [Validation(Required=false)]
            public TargetAudio Audio { get; set; }

            /// <summary>
            /// <para>The media container type. Valid container types include:</para>
            /// <list type="bullet">
            /// <item><description><para>Audio/video containers: mp4, mkv, mov, asf, avi, mxf, ts, flv</para>
            /// </description></item>
            /// <item><description><para>Audio-only containers: mp3, aac, flac, oga, ac3, opus</para>
            /// <remarks>
            /// <para>Notice: </para>
            /// </remarks>
            /// <para>The <c>Container</c> and <c>URI</c> parameters must be set together. To perform only subtitle extraction, frame capture, sprite generation, or animated image generation, leave both <c>Container</c> and <c>URI</c> empty. In this case, parameters such as <c>Segment</c>, <c>Video</c>, <c>Audio</c>, and <c>Speed</c> are ignored.</para>
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
            /// <para>Settings for retaining data streams.</para>
            /// <remarks>
            /// <para>Notice: Retaining data streams is supported only when the <c>Container</c> parameter is set to <c>mp4</c>.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public CreateMediaConvertTaskRequestTargetsData Data { get; set; }
            public class CreateMediaConvertTaskRequestTargetsData : TeaModel {
                /// <summary>
                /// <para>A list of indexes of the data streams in the source file to process. An empty list (default) indicates that no data streams are retained. An index of -1 indicates that all data streams are retained.</para>
                /// <list type="bullet">
                /// <item><description>Example: <c>[0,1]</c> processes the data streams with index 0 and 1; <c>[1]</c> processes the data stream with index 1; <c>[-1]</c> processes all data streams.</description></item>
                /// </list>
                /// <remarks>
                /// <para>If a specified index does not correspond to an existing data stream, it is ignored.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("Stream")]
                [Validation(Required=false)]
                public List<int?> Stream { get; set; }

            }

            /// <summary>
            /// <para>The parameters for frame capture, sprite generation, and animated image generation.</para>
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public TargetImage Image { get; set; }

            /// <summary>
            /// <para>Settings for media segmentation.</para>
            /// </summary>
            [NameInMap("Segment")]
            [Validation(Required=false)]
            public CreateMediaConvertTaskRequestTargetsSegment Segment { get; set; }
            public class CreateMediaConvertTaskRequestTargetsSegment : TeaModel {
                /// <summary>
                /// <para>The duration of each segment, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public double? Duration { get; set; }

                /// <summary>
                /// <para>The segmentation method. Valid values include:</para>
                /// <list type="bullet">
                /// <item><description><para>hls</para>
                /// </description></item>
                /// <item><description><para>dash</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>hls</para>
                /// </summary>
                [NameInMap("Format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                /// <summary>
                /// <para>The starting sequence number. This parameter is supported only for HLS. The default value is 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("StartNumber")]
                [Validation(Required=false)]
                public int? StartNumber { get; set; }

            }

            /// <summary>
            /// <para>The playback speed of the output media. The value must be between 0.5 and 1.0, inclusive. The default value is 1.0.</para>
            /// <remarks>
            /// <para>This parameter specifies the default playback speed of the output file as a ratio of the source file\&quot;s speed. It does not perform speed-up transcoding.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("Speed")]
            [Validation(Required=false)]
            public float? Speed { get; set; }

            /// <summary>
            /// <para>If true, removes metadata such as <c>title</c> and <c>album</c> from the media file. The default is false.</para>
            /// </summary>
            [NameInMap("StripMetadata")]
            [Validation(Required=false)]
            public bool? StripMetadata { get; set; }

            /// <summary>
            /// <para>The subtitle processing parameters.</para>
            /// <remarks>
            /// <para>Notice: If this parameter is left empty, the first subtitle stream, if it exists, is copied directly to the output file.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Subtitle")]
            [Validation(Required=false)]
            public TargetSubtitle Subtitle { get; set; }

            /// <summary>
            /// <para>The OSS URI of the output file for media transcoding.</para>
            /// <para>The URI must be in the <c>oss://${Bucket}/${Object}</c> format. In this format, <c>${Bucket}</c> is the name of the OSS bucket, which must be in the same region as the project, and <c>${Object}</c> is the full path to the object, including the file extension.</para>
            /// <list type="bullet">
            /// <item><description><para>If the <b>URI</b> has a file extension, all output media files are saved to this <b>URI</b>. If multiple files are generated, they will overwrite each other.</para>
            /// </description></item>
            /// <item><description><para>If the <b>URI</b> does not have a file extension, the final output URI is generated based on the <b>URI</b>, <b>Container</b>, and <b>Segment</b> parameters. For example, if the <b>URI</b> is <c>oss://examplebucket/outputVideo</c>:</para>
            /// <list type="bullet">
            /// <item><description><para>If <b>Container</b> is <c>mp4</c> and <b>Segment</b> is empty, the OSS URI of the generated media file is <c>oss://examplebucket/outputVideo.mp4</c>.</para>
            /// </description></item>
            /// <item><description><para>If <b>Container</b> is <c>ts</c> and <b>Format</b> in <b>Segment</b> is <c>hls</c>, the process generates an m3u8 file with the OSS URI <c>oss://examplebucket/outputVideo.m3u8</c> and multiple TS files prefixed with <c>oss://examplebucket/outputVideo</c>.</para>
            /// </description></item>
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
            /// <para>The video processing parameters.</para>
            /// <remarks>
            /// <para>Notice: If this parameter is left empty, the first video stream, if it exists, is copied directly to the output file.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Video")]
            [Validation(Required=false)]
            public TargetVideo Video { get; set; }

        }

        /// <summary>
        /// <para>The custom user data. This data is returned in the asynchronous notification, allowing you to associate the notification with your internal system. The maximum length is 2,048 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ID&quot;: &quot;testuid&quot;,&quot;Name&quot;: &quot;test-user&quot;,&quot;Avatar&quot;: &quot;<a href="http://test.com/testuid%22%7D">http://test.com/testuid&quot;}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
