// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class SubmitProjectTaskRequest : TeaModel {
        /// <summary>
        /// frame
        /// </summary>
        [NameInMap("frames")]
        [Validation(Required=false)]
        public List<SubmitProjectTaskRequestFrames> Frames { get; set; }
        public class SubmitProjectTaskRequestFrames : TeaModel {
            [NameInMap("index")]
            [Validation(Required=false)]
            public int? Index { get; set; }

            [NameInMap("layers")]
            [Validation(Required=false)]
            public List<SubmitProjectTaskRequestFramesLayers> Layers { get; set; }
            public class SubmitProjectTaskRequestFramesLayers : TeaModel {
                [NameInMap("height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                [NameInMap("index")]
                [Validation(Required=false)]
                public int? Index { get; set; }

                [NameInMap("material")]
                [Validation(Required=false)]
                public SubmitProjectTaskRequestFramesLayersMaterial Material { get; set; }
                public class SubmitProjectTaskRequestFramesLayersMaterial : TeaModel {
                    [NameInMap("format")]
                    [Validation(Required=false)]
                    public string Format { get; set; }

                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                    [NameInMap("volume")]
                    [Validation(Required=false)]
                    public int? Volume { get; set; }

                }

                [NameInMap("positionX")]
                [Validation(Required=false)]
                public int? PositionX { get; set; }

                [NameInMap("positionY")]
                [Validation(Required=false)]
                public int? PositionY { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

            }

            [NameInMap("subtitle")]
            [Validation(Required=false)]
            public SubmitProjectTaskRequestFramesSubtitle Subtitle { get; set; }
            public class SubmitProjectTaskRequestFramesSubtitle : TeaModel {
                [NameInMap("alignment")]
                [Validation(Required=false)]
                public string Alignment { get; set; }

                [NameInMap("backgroundColor")]
                [Validation(Required=false)]
                public string BackgroundColor { get; set; }

                [NameInMap("font")]
                [Validation(Required=false)]
                public string Font { get; set; }

                [NameInMap("fontColor")]
                [Validation(Required=false)]
                public string FontColor { get; set; }

                [NameInMap("fontSize")]
                [Validation(Required=false)]
                public int? FontSize { get; set; }

                [NameInMap("maxCharLength")]
                [Validation(Required=false)]
                public int? MaxCharLength { get; set; }

                [NameInMap("positionX")]
                [Validation(Required=false)]
                public int? PositionX { get; set; }

                [NameInMap("positionY")]
                [Validation(Required=false)]
                public int? PositionY { get; set; }

                [NameInMap("textHeight")]
                [Validation(Required=false)]
                public int? TextHeight { get; set; }

                [NameInMap("textWidth")]
                [Validation(Required=false)]
                public int? TextWidth { get; set; }

            }

            [NameInMap("videoScript")]
            [Validation(Required=false)]
            public SubmitProjectTaskRequestFramesVideoScript VideoScript { get; set; }
            public class SubmitProjectTaskRequestFramesVideoScript : TeaModel {
                [NameInMap("audioUrl")]
                [Validation(Required=false)]
                public string AudioUrl { get; set; }

                [NameInMap("speedRate")]
                [Validation(Required=false)]
                public string SpeedRate { get; set; }

                [NameInMap("textContent")]
                [Validation(Required=false)]
                public string TextContent { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("voiceTemplateId")]
                [Validation(Required=false)]
                public long? VoiceTemplateId { get; set; }

                [NameInMap("volume")]
                [Validation(Required=false)]
                public int? Volume { get; set; }

            }

        }

        [NameInMap("scaleType")]
        [Validation(Required=false)]
        public string ScaleType { get; set; }

        [NameInMap("subtitleTag")]
        [Validation(Required=false)]
        public int? SubtitleTag { get; set; }

        [NameInMap("transparentBackground")]
        [Validation(Required=false)]
        public int? TransparentBackground { get; set; }

    }

}
