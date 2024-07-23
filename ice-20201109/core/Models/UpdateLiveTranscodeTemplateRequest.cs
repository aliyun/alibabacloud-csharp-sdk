// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UpdateLiveTranscodeTemplateRequest : TeaModel {
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("TemplateConfig")]
        [Validation(Required=false)]
        public UpdateLiveTranscodeTemplateRequestTemplateConfig TemplateConfig { get; set; }
        public class UpdateLiveTranscodeTemplateRequestTemplateConfig : TeaModel {
            [NameInMap("AudioParams")]
            [Validation(Required=false)]
            public UpdateLiveTranscodeTemplateRequestTemplateConfigAudioParams AudioParams { get; set; }
            public class UpdateLiveTranscodeTemplateRequestTemplateConfigAudioParams : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Bitrate")]
                [Validation(Required=false)]
                public string Bitrate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Channels")]
                [Validation(Required=false)]
                public string Channels { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>AAC</para>
                /// </summary>
                [NameInMap("Codec")]
                [Validation(Required=false)]
                public string Codec { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>aac_low</para>
                /// </summary>
                [NameInMap("Profile")]
                [Validation(Required=false)]
                public string Profile { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>44100</para>
                /// </summary>
                [NameInMap("Samplerate")]
                [Validation(Required=false)]
                public string Samplerate { get; set; }

            }

            [NameInMap("VideoParams")]
            [Validation(Required=false)]
            public UpdateLiveTranscodeTemplateRequestTemplateConfigVideoParams VideoParams { get; set; }
            public class UpdateLiveTranscodeTemplateRequestTemplateConfigVideoParams : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2500</para>
                /// </summary>
                [NameInMap("Bitrate")]
                [Validation(Required=false)]
                public string Bitrate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>H.264</para>
                /// </summary>
                [NameInMap("Codec")]
                [Validation(Required=false)]
                public string Codec { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("Fps")]
                [Validation(Required=false)]
                public string Fps { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("Gop")]
                [Validation(Required=false)]
                public string Gop { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>720</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public string Height { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Profile")]
                [Validation(Required=false)]
                public string Profile { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1280</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public string Width { get; set; }

            }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>96e8864746a0b6f3</b></b></para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
