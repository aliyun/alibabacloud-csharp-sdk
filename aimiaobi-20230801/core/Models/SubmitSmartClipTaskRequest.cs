// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class SubmitSmartClipTaskRequest : TeaModel {
        [NameInMap("EditingConfig")]
        [Validation(Required=false)]
        public SubmitSmartClipTaskRequestEditingConfig EditingConfig { get; set; }
        public class SubmitSmartClipTaskRequestEditingConfig : TeaModel {
            [NameInMap("BackgroundMusicConfig")]
            [Validation(Required=false)]
            public SubmitSmartClipTaskRequestEditingConfigBackgroundMusicConfig BackgroundMusicConfig { get; set; }
            public class SubmitSmartClipTaskRequestEditingConfigBackgroundMusicConfig : TeaModel {
                [NameInMap("Style")]
                [Validation(Required=false)]
                public string Style { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.2</para>
                /// </summary>
                [NameInMap("Volume")]
                [Validation(Required=false)]
                public double? Volume { get; set; }

            }

            [NameInMap("MediaConfig")]
            [Validation(Required=false)]
            public SubmitSmartClipTaskRequestEditingConfigMediaConfig MediaConfig { get; set; }
            public class SubmitSmartClipTaskRequestEditingConfigMediaConfig : TeaModel {
                [NameInMap("Volume")]
                [Validation(Required=false)]
                public double? Volume { get; set; }

            }

            [NameInMap("SpeechConfig")]
            [Validation(Required=false)]
            public SubmitSmartClipTaskRequestEditingConfigSpeechConfig SpeechConfig { get; set; }
            public class SubmitSmartClipTaskRequestEditingConfigSpeechConfig : TeaModel {
                [NameInMap("AsrConfig")]
                [Validation(Required=false)]
                public SubmitSmartClipTaskRequestEditingConfigSpeechConfigAsrConfig AsrConfig { get; set; }
                public class SubmitSmartClipTaskRequestEditingConfigSpeechConfigAsrConfig : TeaModel {
                    [NameInMap("Alignment")]
                    [Validation(Required=false)]
                    public string Alignment { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>SimSun</para>
                    /// </summary>
                    [NameInMap("Font")]
                    [Validation(Required=false)]
                    public string Font { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>#ffffff</para>
                    /// </summary>
                    [NameInMap("FontColor")]
                    [Validation(Required=false)]
                    public string FontColor { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("FontSize")]
                    [Validation(Required=false)]
                    public string FontSize { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Spacing")]
                    [Validation(Required=false)]
                    public string Spacing { get; set; }

                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public float? X { get; set; }

                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public float? Y { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SpeechRate")]
                [Validation(Required=false)]
                public double? SpeechRate { get; set; }

                [NameInMap("Style")]
                [Validation(Required=false)]
                public string Style { get; set; }

                [NameInMap("Voice")]
                [Validation(Required=false)]
                public string Voice { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("Volume")]
                [Validation(Required=false)]
                public double? Volume { get; set; }

            }

            [NameInMap("TitleConfig")]
            [Validation(Required=false)]
            public SubmitSmartClipTaskRequestEditingConfigTitleConfig TitleConfig { get; set; }
            public class SubmitSmartClipTaskRequestEditingConfigTitleConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>TopLeft</para>
                /// </summary>
                [NameInMap("Alignment")]
                [Validation(Required=false)]
                public string Alignment { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("TimelineIn")]
                [Validation(Required=false)]
                public float? TimelineIn { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("TimelineOut")]
                [Validation(Required=false)]
                public float? TimelineOut { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public float? X { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public float? Y { get; set; }

            }

        }

        [NameInMap("ExtendParam")]
        [Validation(Required=false)]
        public string ExtendParam { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InputConfig")]
        [Validation(Required=false)]
        public SubmitSmartClipTaskRequestInputConfig InputConfig { get; set; }
        public class SubmitSmartClipTaskRequestInputConfig : TeaModel {
            [NameInMap("BackgroundMusics")]
            [Validation(Required=false)]
            public List<SubmitSmartClipTaskRequestInputConfigBackgroundMusics> BackgroundMusics { get; set; }
            public class SubmitSmartClipTaskRequestInputConfigBackgroundMusics : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss://default/bucket-name/filepath/video.mp3</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fileKey</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("SpeechTexts")]
            [Validation(Required=false)]
            public List<string> SpeechTexts { get; set; }

            [NameInMap("Stickers")]
            [Validation(Required=false)]
            public List<SubmitSmartClipTaskRequestInputConfigStickers> Stickers { get; set; }
            public class SubmitSmartClipTaskRequestInputConfigStickers : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public double? Height { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("StickerId")]
                [Validation(Required=false)]
                public SubmitSmartClipTaskRequestInputConfigStickersStickerId StickerId { get; set; }
                public class SubmitSmartClipTaskRequestInputConfigStickersStickerId : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>oss://default/bucket-name/filepath/sticker.png</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
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
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public double? Width { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public double? X { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public double? Y { get; set; }

            }

            [NameInMap("Titles")]
            [Validation(Required=false)]
            public List<string> Titles { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("VideoIds")]
            [Validation(Required=false)]
            public List<SubmitSmartClipTaskRequestInputConfigVideoIds> VideoIds { get; set; }
            public class SubmitSmartClipTaskRequestInputConfigVideoIds : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss://default/bucket-name/filepath/video.mp4</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
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

        [NameInMap("OutputConfig")]
        [Validation(Required=false)]
        public SubmitSmartClipTaskRequestOutputConfig OutputConfig { get; set; }
        public class SubmitSmartClipTaskRequestOutputConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test_{index}.mp4</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1080</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public int? Height { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("MaxDuration")]
            [Validation(Required=false)]
            public int? MaxDuration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SaveToGeneratedContent")]
            [Validation(Required=false)]
            public bool? SaveToGeneratedContent { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1920</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public int? Width { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
