// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class SaveAvatarProjectRequest : TeaModel {
        [NameInMap("agentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        [NameInMap("bitRate")]
        [Validation(Required=false)]
        public string BitRate { get; set; }

        [NameInMap("frameRate")]
        [Validation(Required=false)]
        public string FrameRate { get; set; }

        [NameInMap("frames")]
        [Validation(Required=false)]
        public List<SaveAvatarProjectRequestFrames> Frames { get; set; }
        public class SaveAvatarProjectRequestFrames : TeaModel {
            [NameInMap("index")]
            [Validation(Required=false)]
            public int? Index { get; set; }

            [NameInMap("layers")]
            [Validation(Required=false)]
            public List<SaveAvatarProjectRequestFramesLayers> Layers { get; set; }
            public class SaveAvatarProjectRequestFramesLayers : TeaModel {
                [NameInMap("height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                [NameInMap("index")]
                [Validation(Required=false)]
                public int? Index { get; set; }

                [NameInMap("material")]
                [Validation(Required=false)]
                public SaveAvatarProjectRequestFramesLayersMaterial Material { get; set; }
                public class SaveAvatarProjectRequestFramesLayersMaterial : TeaModel {
                    [NameInMap("format")]
                    [Validation(Required=false)]
                    public string Format { get; set; }

                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

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

            [NameInMap("videoScript")]
            [Validation(Required=false)]
            public SaveAvatarProjectRequestFramesVideoScript VideoScript { get; set; }
            public class SaveAvatarProjectRequestFramesVideoScript : TeaModel {
                [NameInMap("emotion")]
                [Validation(Required=false)]
                public string Emotion { get; set; }

                [NameInMap("pitchRate")]
                [Validation(Required=false)]
                public string PitchRate { get; set; }

                [NameInMap("speedRate")]
                [Validation(Required=false)]
                public string SpeedRate { get; set; }

                [NameInMap("textContent")]
                [Validation(Required=false)]
                public string TextContent { get; set; }

                [NameInMap("voiceLanguage")]
                [Validation(Required=false)]
                public string VoiceLanguage { get; set; }

                [NameInMap("voiceTemplateId")]
                [Validation(Required=false)]
                public string VoiceTemplateId { get; set; }

                [NameInMap("volume")]
                [Validation(Required=false)]
                public string Volume { get; set; }

            }

        }

        [NameInMap("operateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

        [NameInMap("projectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("projectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("resSpecType")]
        [Validation(Required=false)]
        public string ResSpecType { get; set; }

        [NameInMap("resolution")]
        [Validation(Required=false)]
        public string Resolution { get; set; }

        [NameInMap("scaleType")]
        [Validation(Required=false)]
        public string ScaleType { get; set; }

        [NameInMap("scriptModelTag")]
        [Validation(Required=false)]
        public string ScriptModelTag { get; set; }

        [NameInMap("synchronizedDisplay")]
        [Validation(Required=false)]
        public string SynchronizedDisplay { get; set; }

    }

}
