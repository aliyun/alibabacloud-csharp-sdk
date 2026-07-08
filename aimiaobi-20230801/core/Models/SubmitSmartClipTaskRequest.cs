// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class SubmitSmartClipTaskRequest : TeaModel {
        /// <summary>
        /// <para>Video editing configuration.</para>
        /// </summary>
        [NameInMap("EditingConfig")]
        [Validation(Required=false)]
        public SubmitSmartClipTaskRequestEditingConfig EditingConfig { get; set; }
        public class SubmitSmartClipTaskRequestEditingConfig : TeaModel {
            /// <summary>
            /// <para>Background music configuration.</para>
            /// </summary>
            [NameInMap("BackgroundMusicConfig")]
            [Validation(Required=false)]
            public SubmitSmartClipTaskRequestEditingConfigBackgroundMusicConfig BackgroundMusicConfig { get; set; }
            public class SubmitSmartClipTaskRequestEditingConfigBackgroundMusicConfig : TeaModel {
                /// <summary>
                /// <para>Background music style. Default value: empty. If background music is already configured in InputConfig, this field does not take effect.
                /// Valid values:
                /// bgm-beauty: Fashion
                /// bgm-chinese-style: Chinese style
                /// bgm-cuisine: Food
                /// bgm-dynamic: Dynamic
                /// bgm-quirky: Quirky
                /// bgm-relaxing: Relaxing
                /// bgm-romantic: Romantic
                /// bgm-upbeat: Upbeat</para>
                /// </summary>
                [NameInMap("Style")]
                [Validation(Required=false)]
                public string Style { get; set; }

                /// <summary>
                /// <para>Volume of the background music. Valid values: 0 to 10.0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.2</para>
                /// </summary>
                [NameInMap("Volume")]
                [Validation(Required=false)]
                public double? Volume { get; set; }

            }

            /// <summary>
            /// <para>Media configuration.</para>
            /// </summary>
            [NameInMap("MediaConfig")]
            [Validation(Required=false)]
            public SubmitSmartClipTaskRequestEditingConfigMediaConfig MediaConfig { get; set; }
            public class SubmitSmartClipTaskRequestEditingConfigMediaConfig : TeaModel {
                /// <summary>
                /// <para>Volume of the video material. 0 means mute.</para>
                /// </summary>
                [NameInMap("Volume")]
                [Validation(Required=false)]
                public double? Volume { get; set; }

            }

            /// <summary>
            /// <para>Voiceover configuration.</para>
            /// </summary>
            [NameInMap("SpeechConfig")]
            [Validation(Required=false)]
            public SubmitSmartClipTaskRequestEditingConfigSpeechConfig SpeechConfig { get; set; }
            public class SubmitSmartClipTaskRequestEditingConfigSpeechConfig : TeaModel {
                /// <summary>
                /// <para>Caption parameter configuration.</para>
                /// </summary>
                [NameInMap("AsrConfig")]
                [Validation(Required=false)]
                public SubmitSmartClipTaskRequestEditingConfigSpeechConfigAsrConfig AsrConfig { get; set; }
                public class SubmitSmartClipTaskRequestEditingConfigSpeechConfigAsrConfig : TeaModel {
                    /// <summary>
                    /// <para>Caption alignment.
                    /// TopLeft: Top-left corner of the video.
                    /// TopCenter: Top center of the vertical axis of the video.
                    /// TopRight: Top-right corner of the video.
                    /// CenterLeft: Left side of the horizontal center line of the video.
                    /// CenterCenter: Center of the video.
                    /// CenterRight: Right side of the horizontal center line of the video.
                    /// BottomLeft: Bottom-left corner of the video.
                    /// BottomCenter: Bottom center of the vertical axis of the video.
                    /// BottomRight: Bottom-right corner of the video.</para>
                    /// </summary>
                    [NameInMap("Alignment")]
                    [Validation(Required=false)]
                    public string Alignment { get; set; }

                    /// <summary>
                    /// <para>Font of the caption text. For supported fonts, see the font list. Default font: SimSun.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SimSun</para>
                    /// </summary>
                    [NameInMap("Font")]
                    [Validation(Required=false)]
                    public string Font { get; set; }

                    /// <summary>
                    /// <para>Color of the caption text. Format: # followed by a hexadecimal value. Example: #ffffff.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>#ffffff</para>
                    /// </summary>
                    [NameInMap("FontColor")]
                    [Validation(Required=false)]
                    public string FontColor { get; set; }

                    /// <summary>
                    /// <para>Font size of the caption text. This size scales based on the source material size and the final output size. Default value: 0. Maximum value: 5000.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("FontSize")]
                    [Validation(Required=false)]
                    public string FontSize { get; set; }

                    /// <summary>
                    /// <para>Letter spacing of the caption text, in pixels.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Spacing")]
                    [Validation(Required=false)]
                    public string Spacing { get; set; }

                    /// <summary>
                    /// <para>Horizontal distance from the top-left corner of the caption text to the top-left corner of the output video. You can specify this value as a percentage or in pixels. If the value is between 0 and 0.9999, it represents a percentage of the output video width. If the value is an integer greater than or equal to 2, it represents an absolute pixel value. Default value: 0. This coordinate scales based on the source material size and the final output size.</para>
                    /// </summary>
                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public float? X { get; set; }

                    /// <summary>
                    /// <para>Vertical distance from the top-left corner of the caption text to the top-left corner of the output video. You can specify this value as a percentage or in pixels. If the value is between 0 and 0.9999, it represents a percentage of the output video height. If the value is an integer greater than or equal to 2, it represents an absolute pixel value. Default value: 0. This coordinate scales based on the source material size and the final output size.</para>
                    /// </summary>
                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public float? Y { get; set; }

                }

                /// <summary>
                /// <para>Speech rate of the voiceover script.
                /// Valid values: -500 to 500. Default value: 0.
                /// The corresponding playback speed multipliers for [-500, 0, 500] are [0.5, 1.0, 2.0].
                /// Calculation method:
                /// For 0.8× speed: (1 - 1/0.8) / 0.002 = -125
                /// For 1.2× speed: (1 - 1/1.2) / 0.001 = 166
                /// Use coefficient 0.002 for speeds less than 1×.
                /// Use coefficient 0.001 for speeds greater than 1×.
                /// Round the result to the nearest integer.</para>
                /// <para>The calculation method is as follows:<br>
                /// 0.8× speed: (1 − 1/0.8)/0.002 = −125<br>
                /// 1.2× speed: (1 − 1/1.2)/0.001 = 166<br>
                /// When the speed is less than 1×, use a coefficient of 0.002.<br>
                /// When the speed is greater than 1×, use a coefficient of 0.001.<br>
                /// The actual algorithm result is approximated.<br><br><br><br><br></para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SpeechRate")]
                [Validation(Required=false)]
                public double? SpeechRate { get; set; }

                /// <summary>
                /// <para>Voiceover style. Default value: empty. If both Voice and Style are specified, Voice takes precedence.
                /// Gentle: Gentle
                /// Serious: Serious
                /// Entertainment: Entertainment</para>
                /// </summary>
                [NameInMap("Style")]
                [Validation(Required=false)]
                public string Style { get; set; }

                /// <summary>
                /// <para>Specify one or more voice styles for the voiceover, separated by commas. When multiple voices are specified, one is randomly selected for synthesis. For available voice styles, see <a href="https://help.aliyun.com/zh/ims/developer-reference/smart-voice-effect-example?spm=a2c4g.11186623.0.0.13091ee6Pw4Jqz">Smart Voice Effect Examples</a>. Example: &quot;zhimiao_emo,zhilun&quot;.</para>
                /// </summary>
                [NameInMap("Voice")]
                [Validation(Required=false)]
                public string Voice { get; set; }

                /// <summary>
                /// <para>Volume of the voiceover audio. Default value: 1. Valid values: 0 to 10.0. Decimal values are supported. Example: 0.5.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("Volume")]
                [Validation(Required=false)]
                public double? Volume { get; set; }

            }

            /// <summary>
            /// <para>Title configuration.</para>
            /// </summary>
            [NameInMap("TitleConfig")]
            [Validation(Required=false)]
            public SubmitSmartClipTaskRequestEditingConfigTitleConfig TitleConfig { get; set; }
            public class SubmitSmartClipTaskRequestEditingConfigTitleConfig : TeaModel {
                /// <summary>
                /// <para>TopLeft: Top-left corner of the video.
                /// TopCenter: Top center of the vertical axis of the video.
                /// TopRight: Top-right corner of the video.
                /// CenterLeft: Left side of the horizontal center line of the video.
                /// CenterCenter: Center of the video.
                /// CenterRight: Right side of the horizontal center line of the video.
                /// BottomLeft: Bottom-left corner of the video.
                /// BottomCenter: Bottom center of the vertical axis of the video.
                /// BottomRight: Bottom-right corner of the video.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TopLeft</para>
                /// </summary>
                [NameInMap("Alignment")]
                [Validation(Required=false)]
                public string Alignment { get; set; }

                /// <summary>
                /// <para>Time when the title appears.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("TimelineIn")]
                [Validation(Required=false)]
                public float? TimelineIn { get; set; }

                /// <summary>
                /// <para>Time when the title disappears.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("TimelineOut")]
                [Validation(Required=false)]
                public float? TimelineOut { get; set; }

                /// <summary>
                /// <para>Horizontal distance from the top-left corner of the banner text to the top-left corner of the output video. You can specify this value as a percentage or in pixels. If the value is between 0 and 0.9999, it represents a percentage of the output video width. If the value is an integer greater than or equal to 2, it represents an absolute pixel value. Default value: 0. This coordinate scales based on the source material size and the final output size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public float? X { get; set; }

                /// <summary>
                /// <para>Vertical distance from the top-left corner of the banner text to the top-left corner of the output video. You can specify this value as a percentage or in pixels. If the value is between 0 and 0.9999, it represents a percentage of the output video height. If the value is an integer greater than or equal to 2, it represents an absolute pixel value. Default value: 0. This coordinate scales based on the source material size and the final output size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public float? Y { get; set; }

            }

        }

        /// <summary>
        /// <para>Additional extended parameters. These parameters merge with InputConfig, OutputConfig, and EditingConfig.</para>
        /// </summary>
        [NameInMap("ExtendParam")]
        [Validation(Required=false)]
        public string ExtendParam { get; set; }

        /// <summary>
        /// <para>Input configuration.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InputConfig")]
        [Validation(Required=false)]
        public SubmitSmartClipTaskRequestInputConfig InputConfig { get; set; }
        public class SubmitSmartClipTaskRequestInputConfig : TeaModel {
            /// <summary>
            /// <para>List of background music IDs.</para>
            /// </summary>
            [NameInMap("BackgroundMusics")]
            [Validation(Required=false)]
            public List<SubmitSmartClipTaskRequestInputConfigBackgroundMusics> BackgroundMusics { get; set; }
            public class SubmitSmartClipTaskRequestInputConfigBackgroundMusics : TeaModel {
                /// <summary>
                /// <para>Background music ID.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss://default/bucket-name/filepath/video.mp3</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>ID type:
                /// materialId: Material Library reference ID
                /// fileKey: FileKey in Alibaba Cloud Model Studio
                /// url: Publicly accessible URL</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fileKey</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>List of voiceover script texts.</para>
            /// </summary>
            [NameInMap("SpeechTexts")]
            [Validation(Required=false)]
            public List<string> SpeechTexts { get; set; }

            /// <summary>
            /// <para>List of stickers.</para>
            /// </summary>
            [NameInMap("Stickers")]
            [Validation(Required=false)]
            public List<SubmitSmartClipTaskRequestInputConfigStickers> Stickers { get; set; }
            public class SubmitSmartClipTaskRequestInputConfigStickers : TeaModel {
                /// <summary>
                /// <para>Height of the sticker.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public double? Height { get; set; }

                /// <summary>
                /// <para>Sticker ID.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("StickerId")]
                [Validation(Required=false)]
                public SubmitSmartClipTaskRequestInputConfigStickersStickerId StickerId { get; set; }
                public class SubmitSmartClipTaskRequestInputConfigStickersStickerId : TeaModel {
                    /// <summary>
                    /// <para>Sticker ID.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>oss://default/bucket-name/filepath/sticker.png</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>ID type:
                    /// materialId: Material Library reference ID
                    /// fileKey: FileKey in Alibaba Cloud Model Studio
                    /// url: Publicly accessible URL</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>fileKey</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>Width of the sticker.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public double? Width { get; set; }

                /// <summary>
                /// <para>X coordinate of the top-left corner of the sticker.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public double? X { get; set; }

                /// <summary>
                /// <para>Y coordinate of the top-left corner of the sticker.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public double? Y { get; set; }

            }

            /// <summary>
            /// <para>List of titles.</para>
            /// </summary>
            [NameInMap("Titles")]
            [Validation(Required=false)]
            public List<string> Titles { get; set; }

            /// <summary>
            /// <para>List of video material ID objects.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("VideoIds")]
            [Validation(Required=false)]
            public List<SubmitSmartClipTaskRequestInputConfigVideoIds> VideoIds { get; set; }
            public class SubmitSmartClipTaskRequestInputConfigVideoIds : TeaModel {
                /// <summary>
                /// <para>Material ID.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss://default/bucket-name/filepath/video.mp4</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>ID type:
                /// materialId: Material Library reference ID
                /// fileKey: FileKey in Alibaba Cloud Model Studio
                /// url: Publicly accessible URL</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fileKey</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>Output configuration.</para>
        /// </summary>
        [NameInMap("OutputConfig")]
        [Validation(Required=false)]
        public SubmitSmartClipTaskRequestOutputConfig OutputConfig { get; set; }
        public class SubmitSmartClipTaskRequestOutputConfig : TeaModel {
            /// <summary>
            /// <para>Number of output videos.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>Output file name. Must include {index}.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_{index}.mp4</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>Output video height.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1080</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public int? Height { get; set; }

            /// <summary>
            /// <para>Maximum duration of the output video, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("MaxDuration")]
            [Validation(Required=false)]
            public int? MaxDuration { get; set; }

            /// <summary>
            /// <para>Save to Content Management.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SaveToGeneratedContent")]
            [Validation(Required=false)]
            public bool? SaveToGeneratedContent { get; set; }

            /// <summary>
            /// <para>Output video width.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1920</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public int? Width { get; set; }

        }

        /// <summary>
        /// <para>Alibaba Cloud Model Studio workspace ID. For more information, see <a href="https://help.aliyun.com/document_detail/2782167.html">workspace ID</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>业务空间ID</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
