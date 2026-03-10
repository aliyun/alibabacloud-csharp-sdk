// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateHighlightTaskRequest : TeaModel {
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public CredentialConfig CredentialConfig { get; set; }

        [NameInMap("Edit")]
        [Validation(Required=false)]
        public CreateHighlightTaskRequestEdit Edit { get; set; }
        public class CreateHighlightTaskRequestEdit : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Closed</para>
            /// </summary>
            [NameInMap("BackgroundMusicMode")]
            [Validation(Required=false)]
            public string BackgroundMusicMode { get; set; }

            [NameInMap("BackgroundMusics")]
            [Validation(Required=false)]
            public List<CreateHighlightTaskRequestEditBackgroundMusics> BackgroundMusics { get; set; }
            public class CreateHighlightTaskRequestEditBackgroundMusics : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss://test-bucket/test-object</para>
                /// </summary>
                [NameInMap("URI")]
                [Validation(Required=false)]
                public string URI { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.2</para>
                /// </summary>
                [NameInMap("Volume")]
                [Validation(Required=false)]
                public double? Volume { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sequential</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Closed</para>
            /// </summary>
            [NameInMap("TransitionMode")]
            [Validation(Required=false)]
            public string TransitionMode { get; set; }

            [NameInMap("Transitions")]
            [Validation(Required=false)]
            public List<CreateHighlightTaskRequestEditTransitions> Transitions { get; set; }
            public class CreateHighlightTaskRequestEditTransitions : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public double? Duration { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>directional</para>
                /// </summary>
                [NameInMap("Transition")]
                [Validation(Required=false)]
                public string Transition { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public long? Weight { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Closed</para>
            /// </summary>
            [NameInMap("VfxEffectMode")]
            [Validation(Required=false)]
            public string VfxEffectMode { get; set; }

            [NameInMap("VfxEffects")]
            [Validation(Required=false)]
            public List<CreateHighlightTaskRequestEditVfxEffects> VfxEffects { get; set; }
            public class CreateHighlightTaskRequestEditVfxEffects : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>open</para>
                /// </summary>
                [NameInMap("VfxEffect")]
                [Validation(Required=false)]
                public string VfxEffect { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public long? Weight { get; set; }

            }

        }

        [NameInMap("Highlight")]
        [Validation(Required=false)]
        public CreateHighlightTaskRequestHighlight Highlight { get; set; }
        public class CreateHighlightTaskRequestHighlight : TeaModel {
            /// <summary>
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
        /// <b>Example:</b>
        /// <para>Average</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        [NameInMap("Notification")]
        [Validation(Required=false)]
        public Notification Notification { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public CreateHighlightTaskRequestOutput Output { get; set; }
        public class CreateHighlightTaskRequestOutput : TeaModel {
            [NameInMap("Audio")]
            [Validation(Required=false)]
            public TargetAudio Audio { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mp4</para>
            /// </summary>
            [NameInMap("Container")]
            [Validation(Required=false)]
            public string Container { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10.0</para>
            /// </summary>
            [NameInMap("MaxDuration")]
            [Validation(Required=false)]
            public double? MaxDuration { get; set; }

            [NameInMap("Segment")]
            [Validation(Required=false)]
            public CreateHighlightTaskRequestOutputSegment Segment { get; set; }
            public class CreateHighlightTaskRequestOutputSegment : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public double? Duration { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>hls</para>
                /// </summary>
                [NameInMap("Format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("StartNumber")]
                [Validation(Required=false)]
                public long? StartNumber { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("Speed")]
            [Validation(Required=false)]
            public double? Speed { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://test-bucket/test-target-object.mp4</para>
            /// </summary>
            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

            [NameInMap("Video")]
            [Validation(Required=false)]
            public TargetVideo Video { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>immtest</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Sources")]
        [Validation(Required=false)]
        public List<CreateHighlightTaskRequestSources> Sources { get; set; }
        public class CreateHighlightTaskRequestSources : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public double? Duration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public double? StartTime { get; set; }

            /// <summary>
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
        /// <b>Example:</b>
        /// <para>{&quot;test&quot;:&quot;val1&quot;}</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tags { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Retrieval</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;ID&quot;: &quot;testuid&quot;,&quot;Name&quot;: &quot;test-user&quot;,&quot;Avatar&quot;: &quot;<a href="http://test.com/testuid%22%7D">http://test.com/testuid&quot;}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
