// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class AsyncCreateClipsTaskRequest : TeaModel {
        [NameInMap("ColorWords")]
        [Validation(Required=false)]
        public List<AsyncCreateClipsTaskRequestColorWords> ColorWords { get; set; }
        public class AsyncCreateClipsTaskRequestColorWords : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("EffectColorStyle")]
            [Validation(Required=false)]
            public string EffectColorStyle { get; set; }

            [NameInMap("FontSize")]
            [Validation(Required=false)]
            public int? FontSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TimelineIn")]
            [Validation(Required=false)]
            public int? TimelineIn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("TimelineOut")]
            [Validation(Required=false)]
            public int? TimelineOut { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.2</para>
            /// </summary>
            [NameInMap("X")]
            [Validation(Required=false)]
            public float? X { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("Y")]
            [Validation(Required=false)]
            public float? Y { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1920</para>
        /// </summary>
        [NameInMap("Height")]
        [Validation(Required=false)]
        public int? Height { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://music.mp4">http://music.mp4</a></para>
        /// </summary>
        [NameInMap("MusicUrl")]
        [Validation(Required=false)]
        public string MusicUrl { get; set; }

        [NameInMap("MusicVolume")]
        [Validation(Required=false)]
        public int? MusicVolume { get; set; }

        [NameInMap("SubtitleFontSize")]
        [Validation(Required=false)]
        public int? SubtitleFontSize { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17a299a9-f223-4707-b0dd-4c22519bddf5</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("VoiceStyle")]
        [Validation(Required=false)]
        public string VoiceStyle { get; set; }

        [NameInMap("VoiceVolume")]
        [Validation(Required=false)]
        public int? VoiceVolume { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1080</para>
        /// </summary>
        [NameInMap("Width")]
        [Validation(Required=false)]
        public int? Width { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-ipe7d81yq4sl5jmk</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
