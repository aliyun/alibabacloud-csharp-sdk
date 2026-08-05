// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateLiveTranscodeTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The template name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my template</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The template configuration.</para>
        /// <remarks>
        /// <para>The pass parameter requirements vary based on the templatetype (Type). When Type is set to normal, at least one of the width and height parameters must be specified, and the frame rate and bitrate parameters are required. For other template types, specify the parameters based on your requirements.</para>
        /// </remarks>
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
                /// <para>The bitrate of the transcoded audio. Unit: kbps. Valid values: 1 to 1000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Bitrate")]
                [Validation(Required=false)]
                public string Bitrate { get; set; }

                /// <summary>
                /// <para>The number of audio channels. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>1: mono.</para>
                /// </description></item>
                /// <item><description><para>2: stereo.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Channels")]
                [Validation(Required=false)]
                public string Channels { get; set; }

                /// <summary>
                /// <para>The audio encoding format. Valid values:</para>
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
                /// <para>The audio encoding preset. When Codec is set to AAC, valid values:</para>
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
                /// <para>The audio sample rate. Valid values: 22050 to 96000.</para>
                /// <remarks>
                /// <para>Notice: If AudioProfile is set to aac_ld, the sample rate must not exceed 44100.</para>
                /// </remarks>
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
                /// <para>The bitrate of the transcoded video. Unit: kbps. Valid values: 1 to 6000.</para>
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
                /// <para>The frame rate of the transcoded video. Unit: FPS. Valid values: 1 to 60.</para>
                /// 
                /// <b>Example:</b>
                /// <para>25</para>
                /// </summary>
                [NameInMap("Fps")]
                [Validation(Required=false)]
                public string Fps { get; set; }

                /// <summary>
                /// <para>The video GOP (Group of Pictures). Unit: frames. Valid values: 1 to 3000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("Gop")]
                [Validation(Required=false)]
                public string Gop { get; set; }

                /// <summary>
                /// <para>The height of the transcoded video. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Height ≥ 128</para>
                /// </description></item>
                /// <item><description><para>max(Height, Width) ≤ 2560</para>
                /// </description></item>
                /// <item><description><para>min(Height, Width) ≤ 1440</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>Notice: For H.265 narrowband HD templates, the resolution must not exceed 1280 × 720.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>720</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public string Height { get; set; }

                /// <summary>
                /// <para>The encoding profile. A set of specific encoding features supported by the video. A higher value generally produces better image quality but consumes more encoding and decoding resources. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>1: baseline (suitable for mobile devices).</para>
                /// </description></item>
                /// <item><description><para>2: main (suitable for standard resolution devices).</para>
                /// </description></item>
                /// <item><description><para>3: high (suitable for high resolution devices).</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Profile")]
                [Validation(Required=false)]
                public string Profile { get; set; }

                /// <summary>
                /// <para>The width of the transcoded video. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Width ≥ 128</para>
                /// </description></item>
                /// <item><description><para>max(Height, Width) ≤ 2560</para>
                /// </description></item>
                /// <item><description><para>min(Height, Width) ≤ 1440</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>Notice: For H.265 narrowband HD templates, the resolution must not exceed 1280 × 720.</para>
                /// </remarks>
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
        /// <para>The template type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>normal: standard.</description></item>
        /// <item><description>narrow-band: narrowband HD.</description></item>
        /// <item><description>audio-only: audio only.</description></item>
        /// <item><description>origin: original quality.</description></item>
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
