// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateHighlightTaskRequest : TeaModel {
        /// <summary>
        /// <para>The chained authorization configuration. <b>Leave this parameter empty unless otherwise required.</b></para>
        /// </summary>
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public CredentialConfig CredentialConfig { get; set; }

        /// <summary>
        /// <para>The editing configuration.</para>
        /// </summary>
        [NameInMap("Edit")]
        [Validation(Required=false)]
        public CreateHighlightTaskRequestEdit Edit { get; set; }
        public class CreateHighlightTaskRequestEdit : TeaModel {
            /// <summary>
            /// <para>The background music mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Random: custom background music, randomly selected based on weights</description></item>
            /// <item><description>Sequential: custom background music, applied in sequence</description></item>
            /// <item><description>Closed: no background music
            /// Default value: Closed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Closed</para>
            /// </summary>
            [NameInMap("BackgroundMusicMode")]
            [Validation(Required=false)]
            public string BackgroundMusicMode { get; set; }

            /// <summary>
            /// <para>The background music. This parameter is valid only when BackgroundMusicMode is set to Random or Sequential. <b>The current maximum number of background music tracks is 1.</b></para>
            /// </summary>
            [NameInMap("BackgroundMusics")]
            [Validation(Required=false)]
            public List<CreateHighlightTaskRequestEditBackgroundMusics> BackgroundMusics { get; set; }
            public class CreateHighlightTaskRequestEditBackgroundMusics : TeaModel {
                /// <summary>
                /// <para>The URI of the background music, which is an OSS URI. Only audio files are supported.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss://test-bucket/test-object/test.mp3</para>
                /// </summary>
                [NameInMap("URI")]
                [Validation(Required=false)]
                public string URI { get; set; }

                /// <summary>
                /// <para>The volume of the background music. Valid values: [0, 10]. Default value: 0.2. A value of 1 indicates the original volume.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.2</para>
                /// </summary>
                [NameInMap("Volume")]
                [Validation(Required=false)]
                public double? Volume { get; set; }

            }

            /// <summary>
            /// <para>The editing mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Sequential: sequential mode</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sequential</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The transition mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Auto: automatic transition</description></item>
            /// <item><description>Random: custom transition, randomly selected based on weights</description></item>
            /// <item><description>Sequential: custom transition, applied in sequence</description></item>
            /// <item><description>Closed: no transition
            /// Default value: Closed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Closed</para>
            /// </summary>
            [NameInMap("TransitionMode")]
            [Validation(Required=false)]
            public string TransitionMode { get; set; }

            /// <summary>
            /// <para>The transition effects. This parameter is valid only when TransitionMode is set to Random or Sequential. You can specify up to 10 transition effects.</para>
            /// </summary>
            [NameInMap("Transitions")]
            [Validation(Required=false)]
            public List<CreateHighlightTaskRequestEditTransitions> Transitions { get; set; }
            public class CreateHighlightTaskRequestEditTransitions : TeaModel {
                /// <summary>
                /// <para>The duration of the transition. Unit: seconds. If the transition duration is greater than the clip duration minus 1, the transition effect on the clip does not take effect. Valid values: [0, 5].</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public double? Duration { get; set; }

                /// <summary>
                /// <para>The transition effect. For more information, see <a href="https://www.alibabacloud.com/help/en/imm/developer-reference/transition-effect">Transition effects</a>.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fade</para>
                /// </summary>
                [NameInMap("Transition")]
                [Validation(Required=false)]
                public string Transition { get; set; }

                /// <summary>
                /// <para>The weight of the transition. Valid values: [1, 100]. Default value: 50. This parameter is valid only when TransitionMode is set to Random.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public long? Weight { get; set; }

            }

            /// <summary>
            /// <para>The visual effect mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Auto: automatic visual effect</description></item>
            /// <item><description>Random: custom visual effect, randomly selected based on weights</description></item>
            /// <item><description>Sequential: custom visual effect, applied in sequence</description></item>
            /// <item><description>Closed: no visual effect
            /// Default value: Closed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Closed</para>
            /// </summary>
            [NameInMap("VfxEffectMode")]
            [Validation(Required=false)]
            public string VfxEffectMode { get; set; }

            /// <summary>
            /// <para>The visual effects. This parameter is valid only when VfxEffectMode is set to Random or Sequential. You can specify up to 10 visual effects.</para>
            /// </summary>
            [NameInMap("VfxEffects")]
            [Validation(Required=false)]
            public List<CreateHighlightTaskRequestEditVfxEffects> VfxEffects { get; set; }
            public class CreateHighlightTaskRequestEditVfxEffects : TeaModel {
                /// <summary>
                /// <para>The visual effect. For more information, see <a href="https://www.alibabacloud.com/help/en/imm/developer-reference/effects">Visual effects</a>.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>letterboxed</para>
                /// </summary>
                [NameInMap("VfxEffect")]
                [Validation(Required=false)]
                public string VfxEffect { get; set; }

                /// <summary>
                /// <para>The weight of the visual effect. Valid values: [1, 100]. Default value: 50. This parameter is valid only when VfxEffectMode is set to Random.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public long? Weight { get; set; }

            }

        }

        /// <summary>
        /// <para>The highlight configuration.</para>
        /// </summary>
        [NameInMap("Highlight")]
        [Validation(Required=false)]
        public CreateHighlightTaskRequestHighlight Highlight { get; set; }
        public class CreateHighlightTaskRequestHighlight : TeaModel {
            /// <summary>
            /// <para>The highlight content. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Pet</description></item>
            /// <item><description>Person</description></item>
            /// <item><description>Sports</description></item>
            /// <item><description>Meeting</description></item>
            /// </list>
            /// <para>The value cannot exceed 100 characters in length.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>character</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

        }

        /// <summary>
        /// <para>The highlight recognition mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Scene: scene and frame recognition</description></item>
        /// <item><description>Average: average clip recognition
        /// Default value: Average.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Average</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The message notification configuration. For more information, see Notification. For the format of asynchronous notification messages, see <a href="https://www.alibabacloud.com/help/en/imm/developer-reference/asynchronous-notification-message-examples">Asynchronous notification message format</a>.</para>
        /// </summary>
        [NameInMap("Notification")]
        [Validation(Required=false)]
        public Notification Notification { get; set; }

        /// <summary>
        /// <para>The output configuration.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public CreateHighlightTaskRequestOutput Output { get; set; }
        public class CreateHighlightTaskRequestOutput : TeaModel {
            /// <summary>
            /// <para>The audio processing parameter settings. &gt;Notice: If Audio is empty, the first audio stream (if any) is directly copied to the output file.</notice></para>
            /// </summary>
            [NameInMap("Audio")]
            [Validation(Required=false)]
            public TargetAudio Audio { get; set; }

            /// <summary>
            /// <para>The media container type. This parameter is required when Type is set to Concat or Compose. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Audio and video containers: mp4, mkv, mov, asf, avi, mxf, ts, and flv</description></item>
            /// </list>
            /// <remarks>
            /// <para>Notice: You must specify both Container and URI.</notice></para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>mp4</para>
            /// </summary>
            [NameInMap("Container")]
            [Validation(Required=false)]
            public string Container { get; set; }

            /// <summary>
            /// <para>The maximum duration of the edited video. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0</para>
            /// </summary>
            [NameInMap("MaxDuration")]
            [Validation(Required=false)]
            public double? MaxDuration { get; set; }

            /// <summary>
            /// <para>The media segmentation settings. By default, segmentation is not performed.</para>
            /// </summary>
            [NameInMap("Segment")]
            [Validation(Required=false)]
            public CreateHighlightTaskRequestOutputSegment Segment { get; set; }
            public class CreateHighlightTaskRequestOutputSegment : TeaModel {
                /// <summary>
                /// <para>The length of each segment. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public double? Duration { get; set; }

                /// <summary>
                /// <para>The media segmentation format. Valid values:</para>
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
                /// <para>The start number. This parameter is supported only for hls. Default value: 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("StartNumber")]
                [Validation(Required=false)]
                public long? StartNumber { get; set; }

            }

            /// <summary>
            /// <para>The playback speed multiplier for the media. Valid values: [0.5, 1.0]. Default value: 1.0.</para>
            /// <remarks>
            /// <para>The ratio of the default playback speed of the transcoded media file to that of the source media file. This is not speed-adjusted transcoding.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("Speed")]
            [Validation(Required=false)]
            public double? Speed { get; set; }

            /// <summary>
            /// <para>The target duration of the video. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0</para>
            /// </summary>
            [NameInMap("TargetDuration")]
            [Validation(Required=false)]
            public double? TargetDuration { get; set; }

            /// <summary>
            /// <para>The URI of the output file.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://test-bucket/test-target-object.mp4</para>
            /// </summary>
            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

            /// <summary>
            /// <para>The video processing parameter settings. &gt;Notice: If Video is empty, the first video stream (if any) is directly copied to the output file.</notice></para>
            /// </summary>
            [NameInMap("Video")]
            [Validation(Required=false)]
            public TargetVideo Video { get; set; }

        }

        /// <summary>
        /// <para>The name of the project.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>immtest</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The list of media resources to be processed. You can specify up to 10 videos.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Sources")]
        [Validation(Required=false)]
        public List<CreateHighlightTaskRequestSources> Sources { get; set; }
        public class CreateHighlightTaskRequestSources : TeaModel {
            /// <summary>
            /// <para>The duration of the media clip. Unit: seconds. Default value: 0, which indicates the end time of the video. This parameter is valid only when Type is set to Concat.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public double? Duration { get; set; }

            /// <summary>
            /// <para>The start time of the media resource. Valid values: [0, video duration]. This parameter is valid only when Type is set to Concat. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public double? StartTime { get; set; }

            /// <summary>
            /// <para>The URI of the media resource, which is an OSS URI. Only videos are supported.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://test-bucket/test-object</para>
            /// </summary>
            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

        }

        /// <summary>
        /// <para>The custom tags used to search and filter asynchronous tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;test&quot;:&quot;val1&quot;}</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tags { get; set; }

        /// <summary>
        /// <para>The processing type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Retrieval: highlight extraction</description></item>
        /// <item><description>Concat: video composition</description></item>
        /// <item><description>Compose: one-click video creation</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Retrieval</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The custom user data, which is returned in asynchronous message notifications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ID&quot;: &quot;testuid&quot;,&quot;Name&quot;: &quot;test-user&quot;,&quot;Avatar&quot;: &quot;<a href="http://test.com/testuid%22%7D">http://test.com/testuid&quot;}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
