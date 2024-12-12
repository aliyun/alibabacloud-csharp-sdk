// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UpdateLiveTranscodeTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The template name.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The configuration of the template.</para>
        /// </summary>
        [NameInMap("TemplateConfig")]
        [Validation(Required=false)]
        public UpdateLiveTranscodeTemplateRequestTemplateConfig TemplateConfig { get; set; }
        public class UpdateLiveTranscodeTemplateRequestTemplateConfig : TeaModel {
            /// <summary>
            /// <para>The audio parameters.</para>
            /// </summary>
            [NameInMap("AudioParams")]
            [Validation(Required=false)]
            public UpdateLiveTranscodeTemplateRequestTemplateConfigAudioParams AudioParams { get; set; }
            public class UpdateLiveTranscodeTemplateRequestTemplateConfigAudioParams : TeaModel {
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
                /// <para>The audio codec. Valid values: AAC MP3</para>
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
                /// <para>aac_low</para>
                /// </summary>
                [NameInMap("Profile")]
                [Validation(Required=false)]
                public string Profile { get; set; }

                /// <summary>
                /// <para>The audio sampling rate. Valid values: 22050 to 96000.</para>
                /// <para>Note If you set AudioProfile to aac_ld, the audio sampling rate cannot exceed 44100.</para>
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
            public UpdateLiveTranscodeTemplateRequestTemplateConfigVideoParams VideoParams { get; set; }
            public class UpdateLiveTranscodeTemplateRequestTemplateConfigVideoParams : TeaModel {
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
                /// <para>30</para>
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
                /// <para>The height of the output video. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Height ≥ 128</description></item>
                /// <item><description>max (Height,Width) ≤ 2560</description></item>
                /// <item><description>min（Height,Width）≤ 1440</description></item>
                /// </list>
                /// <remarks>
                /// <para> The resolution of a video transcoded by using the H.265 Narrowband HD template cannot exceed 1,280 × 720 pixels.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>720</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public string Height { get; set; }

                /// <summary>
                /// <para>The video encoding profile. The profile determines how a video is encoded. In most cases, a greater value indicates better image quality and higher resource consumption. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: baseline. This value is suitable for mobile devices.</description></item>
                /// <item><description>2: main. This value is suitable for standard-definition devices.</description></item>
                /// <item><description>3: high. This value is suitable for high-definition devices.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Profile")]
                [Validation(Required=false)]
                public string Profile { get; set; }

                /// <summary>
                /// <para>The width of the output video. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Width ≥ 128</description></item>
                /// <item><description>max (Height,Width) ≤ 2560</description></item>
                /// <item><description>min（Height,Width）≤ 1440</description></item>
                /// </list>
                /// <remarks>
                /// <para> The resolution of a video transcoded by using the H.265 Narrowband HD template cannot exceed 1,280 × 720 pixels.</para>
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
        /// <para>The template ID. To obtain the template ID, log on to the <a href="https://ims.console.aliyun.com/summary">Intelligent Media Services (IMS) console</a>, choose Real-time Media Processing &gt; Template Management, and then click the Transcoding tab. Alternatively, find the ID from the response parameters of the <a href="https://help.aliyun.com/document_detail/449217.html">CreateLiveTranscodeTemplate</a> operation.</para>
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
