// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class SaveAvatarProjectRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1000196</para>
        /// </summary>
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
            [NameInMap("layers")]
            [Validation(Required=false)]
            public List<SaveAvatarProjectRequestFramesLayers> Layers { get; set; }
            public class SaveAvatarProjectRequestFramesLayers : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                [NameInMap("material")]
                [Validation(Required=false)]
                public SaveAvatarProjectRequestFramesLayersMaterial Material { get; set; }
                public class SaveAvatarProjectRequestFramesLayersMaterial : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>image/png</para>
                    /// </summary>
                    [NameInMap("format")]
                    [Validation(Required=false)]
                    public string Format { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>434508</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="https://alidocs.dingtalk.com/i/nodes/vy20BglGWOxjGpq0C5G4DlN0VA7depqY">https://alidocs.dingtalk.com/i/nodes/vy20BglGWOxjGpq0C5G4DlN0VA7depqY</a></para>
                    /// </summary>
                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
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
                /// <para>ANCHOR</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

            }

            [NameInMap("videoScript")]
            [Validation(Required=false)]
            public SaveAvatarProjectRequestFramesVideoScript VideoScript { get; set; }
            public class SaveAvatarProjectRequestFramesVideoScript : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1.0</para>
                /// </summary>
                [NameInMap("speedRate")]
                [Validation(Required=false)]
                public string SpeedRate { get; set; }

                [NameInMap("voiceLanguage")]
                [Validation(Required=false)]
                public string VoiceLanguage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("voiceTemplateId")]
                [Validation(Required=false)]
                public string VoiceTemplateId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("volume")]
                [Validation(Required=false)]
                public string Volume { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CREATE</para>
        /// </summary>
        [NameInMap("operateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>787594567117586432</para>
        /// </summary>
        [NameInMap("projectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>df_cs_471437</para>
        /// </summary>
        [NameInMap("projectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>STANDARD</para>
        /// </summary>
        [NameInMap("resSpecType")]
        [Validation(Required=false)]
        public string ResSpecType { get; set; }

        [NameInMap("resolution")]
        [Validation(Required=false)]
        public string Resolution { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9:16</para>
        /// </summary>
        [NameInMap("scaleType")]
        [Validation(Required=false)]
        public string ScaleType { get; set; }

        [NameInMap("synchronizedDisplay")]
        [Validation(Required=false)]
        public string SynchronizedDisplay { get; set; }

    }

}
