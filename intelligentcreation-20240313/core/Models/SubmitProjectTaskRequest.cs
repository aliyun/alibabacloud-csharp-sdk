// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class SubmitProjectTaskRequest : TeaModel {
        /// <summary>
        /// <para>frame</para>
        /// </summary>
        [NameInMap("frames")]
        [Validation(Required=false)]
        public List<SubmitProjectTaskRequestFrames> Frames { get; set; }
        public class SubmitProjectTaskRequestFrames : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("index")]
            [Validation(Required=false)]
            public int? Index { get; set; }

            [NameInMap("layers")]
            [Validation(Required=false)]
            public List<SubmitProjectTaskRequestFramesLayers> Layers { get; set; }
            public class SubmitProjectTaskRequestFramesLayers : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>222</para>
                /// </summary>
                [NameInMap("height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("index")]
                [Validation(Required=false)]
                public int? Index { get; set; }

                [NameInMap("material")]
                [Validation(Required=false)]
                public SubmitProjectTaskRequestFramesLayersMaterial Material { get; set; }
                public class SubmitProjectTaskRequestFramesLayersMaterial : TeaModel {
                    [NameInMap("anchorStyleLevel")]
                    [Validation(Required=false)]
                    public string AnchorStyleLevel { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>video/mp4</para>
                    /// </summary>
                    [NameInMap("format")]
                    [Validation(Required=false)]
                    public string Format { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>38863</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("speed")]
                    [Validation(Required=false)]
                    public string Speed { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="https://meeting.dingtalk.com/j/1COFppy0POR">https://meeting.dingtalk.com/j/1COFppy0POR</a></para>
                    /// </summary>
                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                    [NameInMap("volume")]
                    [Validation(Required=false)]
                    public int? Volume { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("positionX")]
                [Validation(Required=false)]
                public int? PositionX { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>22</para>
                /// </summary>
                [NameInMap("positionY")]
                [Validation(Required=false)]
                public int? PositionY { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ANCHOR</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>111</para>
                /// </summary>
                [NameInMap("width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

            }

            [NameInMap("subtitle")]
            [Validation(Required=false)]
            public SubmitProjectTaskRequestFramesSubtitle Subtitle { get; set; }
            public class SubmitProjectTaskRequestFramesSubtitle : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>BottomLeft</para>
                /// </summary>
                [NameInMap("alignment")]
                [Validation(Required=false)]
                public string Alignment { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>#ffffff</para>
                /// </summary>
                [NameInMap("backgroundColor")]
                [Validation(Required=false)]
                public string BackgroundColor { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SimSun</para>
                /// </summary>
                [NameInMap("font")]
                [Validation(Required=false)]
                public string Font { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>#ffffff</para>
                /// </summary>
                [NameInMap("fontColor")]
                [Validation(Required=false)]
                public string FontColor { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>32</para>
                /// </summary>
                [NameInMap("fontSize")]
                [Validation(Required=false)]
                public int? FontSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("maxCharLength")]
                [Validation(Required=false)]
                public int? MaxCharLength { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("positionX")]
                [Validation(Required=false)]
                public int? PositionX { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("positionY")]
                [Validation(Required=false)]
                public int? PositionY { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>22</para>
                /// </summary>
                [NameInMap("textHeight")]
                [Validation(Required=false)]
                public int? TextHeight { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("textWidth")]
                [Validation(Required=false)]
                public int? TextWidth { get; set; }

            }

            [NameInMap("videoScript")]
            [Validation(Required=false)]
            public SubmitProjectTaskRequestFramesVideoScript VideoScript { get; set; }
            public class SubmitProjectTaskRequestFramesVideoScript : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://meeting.dingtalk.com/j/1COFppy0POR">https://meeting.dingtalk.com/j/1COFppy0POR</a></para>
                /// </summary>
                [NameInMap("audioUrl")]
                [Validation(Required=false)]
                public string AudioUrl { get; set; }

                [NameInMap("speechOpen")]
                [Validation(Required=false)]
                public bool? SpeechOpen { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2.0</para>
                /// </summary>
                [NameInMap("speedRate")]
                [Validation(Required=false)]
                public string SpeedRate { get; set; }

                [NameInMap("textContent")]
                [Validation(Required=false)]
                public string TextContent { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>TEXT</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("voiceTemplateId")]
                [Validation(Required=false)]
                public long? VoiceTemplateId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("volume")]
                [Validation(Required=false)]
                public int? Volume { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9:16</para>
        /// </summary>
        [NameInMap("scaleType")]
        [Validation(Required=false)]
        public string ScaleType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("subtitleTag")]
        [Validation(Required=false)]
        public int? SubtitleTag { get; set; }

        [NameInMap("transparentBackground")]
        [Validation(Required=false)]
        public int? TransparentBackground { get; set; }

    }

}
