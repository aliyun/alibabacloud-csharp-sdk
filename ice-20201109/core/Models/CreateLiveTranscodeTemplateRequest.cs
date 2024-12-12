// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateLiveTranscodeTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The name of the template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my template</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The configuration of the template.</para>
        /// </summary>
        [NameInMap("TemplateConfig")]
        [Validation(Required=false)]
        public CreateLiveTranscodeTemplateRequestTemplateConfig TemplateConfig { get; set; }
        public class CreateLiveTranscodeTemplateRequestTemplateConfig : TeaModel {
            /// <summary>
            /// <para>The audio parameters.</para>
            /// </summary>
            [NameInMap("AudioParams")]
            [Validation(Required=false)]
            public CreateLiveTranscodeTemplateRequestTemplateConfigAudioParams AudioParams { get; set; }
            public class CreateLiveTranscodeTemplateRequestTemplateConfigAudioParams : TeaModel {
                /// <summary>
                /// <para>The bitrate of the output audio. Unit: Kbit/s. Valid values: 1 to 1000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Bitrate")]
                [Validation(Required=false)]
                public string Bitrate { get; set; }

                /// <summary>
                /// <para>The number of sound channels. Valid values: 1: mono 2: binaural</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Channels")]
                [Validation(Required=false)]
                public string Channels { get; set; }

                /// <summary>
                /// <para>The audio codec. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>AAC</description></item>
                /// <item><description>MP3</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>AAC</para>
                /// </summary>
                [NameInMap("Codec")]
                [Validation(Required=false)]
                public string Codec { get; set; }

                /// <summary>
                /// <para>The audio codec profile. Valid values when the Codec parameter is set to AAC:</para>
                /// <list type="bullet">
                /// <item><description>aac_low</description></item>
                /// <item><description>aac_he</description></item>
                /// <item><description>aac_he_v2</description></item>
                /// <item><description>aac_ld</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>aaclow</para>
                /// </summary>
                [NameInMap("Profile")]
                [Validation(Required=false)]
                public string Profile { get; set; }

                /// <summary>
                /// <para>The audio sampling rate. Valid values: 22050 to 96000.</para>
                /// <para>Note: If you set AudioProfile to aac_ld, the audio sampling rate cannot exceed 44,100.</para>
                /// 
                /// <b>Example:</b>
                /// <para>44100</para>
                /// </summary>
                [NameInMap("Samplerate")]
                [Validation(Required=false)]
                public string Samplerate { get; set; }

            }

            /// <summary>
            /// <para>The video parameters.</para>
            /// </summary>
            [NameInMap("VideoParams")]
            [Validation(Required=false)]
            public CreateLiveTranscodeTemplateRequestTemplateConfigVideoParams VideoParams { get; set; }
            public class CreateLiveTranscodeTemplateRequestTemplateConfigVideoParams : TeaModel {
                /// <summary>
                /// <para>The bitrate of the output video. Unit: Kbit/s. Valid values: 1 to 6000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2500</para>
                /// </summary>
                [NameInMap("Bitrate")]
                [Validation(Required=false)]
                public string Bitrate { get; set; }

                /// <summary>
                /// <para>The encoding type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>H.264</description></item>
                /// <item><description>H.265</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>H.264</para>
                /// </summary>
                [NameInMap("Codec")]
                [Validation(Required=false)]
                public string Codec { get; set; }

                /// <summary>
                /// <para>The frame rate of the output video. Unit: frames per second (FPS). Valid values: 1 to 60.</para>
                /// 
                /// <b>Example:</b>
                /// <para>25</para>
                /// </summary>
                [NameInMap("Fps")]
                [Validation(Required=false)]
                public string Fps { get; set; }

                /// <summary>
                /// <para>The group of pictures (GOP) of the output video. Unit: frame. Valid values: 1 to 3000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("Gop")]
                [Validation(Required=false)]
                public string Gop { get; set; }

                /// <summary>
                /// <para>The height of the output video. Valid values: Height ≥ 128 max (Height,Width) ≤ 2560 min (Height,Width) ≤ 1440</para>
                /// <para>Note: The resolution of the output video that is transcoded by using the H.265 Narrowband HD transcoding template cannot exceed 1280 × 720 pixels.</para>
                /// 
                /// <b>Example:</b>
                /// <para>720</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public string Height { get; set; }

                /// <summary>
                /// <para>The encoding profile. The profile determines how a video is encoded. In most cases, a greater value indicates better image quality and higher resource consumption. Valid values: 1: baseline. This value is suitable for mobile devices. 2: main. This value is suitable for standard-definition devices. 3: high. This value is suitable for high-definition devices.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Profile")]
                [Validation(Required=false)]
                public string Profile { get; set; }

                /// <summary>
                /// <para>The width of the output video. Valid values: Width ≥ 128 max (Height,Width) ≤ 2560 min (Height,Width) ≤ 1440</para>
                /// <para>Note: The resolution of the output video that is transcoded by using the H.265 Narrowband HD transcoding template cannot exceed 1280 × 720 pixels.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1280</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public string Width { get; set; }

            }

        }

        /// <summary>
        /// <para>The type of the template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>normal</description></item>
        /// <item><description>narrow-band</description></item>
        /// <item><description>audio-only</description></item>
        /// <item><description>origin</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
