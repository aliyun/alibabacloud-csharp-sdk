// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class MediaConvertAudio : TeaModel {
        /// <summary>
        /// <para>The audio bitrate of the output file.</para>
        /// <list type="bullet">
        /// <item><description>Unit: Kbps.</description></item>
        /// <item><description>Valid values: [8,1000].</description></item>
        /// <item><description>Default value: 128.</description></item>
        /// <item><description>Common values: 64, 128, and 256.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>128</para>
        /// </summary>
        [NameInMap("Bitrate")]
        [Validation(Required=false)]
        public long? Bitrate { get; set; }

        /// <summary>
        /// <para>The number of audio channels.</para>
        /// <list type="bullet">
        /// <item><description><para>Valid values: 0, 1, 2, 4, 5, 6, and 8.</para>
        /// <list type="bullet">
        /// <item><description>If the Codec parameter is set to MP3 or OPUS, you can set this parameter to 0, 1, or 2.</description></item>
        /// <item><description>If the Codec parameter is set to AAC or FLAC, you can set this parameter to 0, 1, 2, 4, 5, 6, or 8.</description></item>
        /// <item><description>If the Codec parameter is set to VORBIS, you can set this parameter to 2.</description></item>
        /// <item><description>If the Format parameter is set to MPD, you cannot set this parameter to 8.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Default value: 2.</para>
        /// </description></item>
        /// <item><description><para>Set the value to 0 to preserve the original number of channels from the source file.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Channels")]
        [Validation(Required=false)]
        public long? Channels { get; set; }

        /// <summary>
        /// <para>The audio codec.</para>
        /// <list type="bullet">
        /// <item><description>Valid values: AAC, AC3, EAC3, MP2, MP3, FLAC, OPUS, VORBIS, WMA-V1, WMA-V2, and pcm_s16le.</description></item>
        /// <item><description>Default value: AAC.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AAC</para>
        /// </summary>
        [NameInMap("Codec")]
        [Validation(Required=false)]
        public string Codec { get; set; }

        /// <summary>
        /// <para>The audio codec profile.</para>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only if the Codec parameter is set to AAC.</description></item>
        /// <item><description>Valid values: aac_low, aac_he, aac_he_v2, aac_ld, and aac_eld.</description></item>
        /// <item><description>Default value: aac_low.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>aac_low</para>
        /// </summary>
        [NameInMap("Profile")]
        [Validation(Required=false)]
        public string Profile { get; set; }

        /// <summary>
        /// <para>Specifies whether to remove the audio stream from the output.</para>
        /// <list type="bullet">
        /// <item><description>true: deletes the audio stream. All other parameters in the Audio object are ignored.</description></item>
        /// <item><description>false: retains the audio stream.</description></item>
        /// <item><description>Default value: false.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Remove")]
        [Validation(Required=false)]
        public bool? Remove { get; set; }

        /// <summary>
        /// <para>The sample rate.</para>
        /// <list type="bullet">
        /// <item><description>Unit: Hz</description></item>
        /// <item><description>Valid values: 22050, 32000, 44100, 48000, and 96000.</description></item>
        /// <item><description>Default value: 44100.</description></item>
        /// </list>
        /// <para>The supported sample rates vary depending on the container and codec format. For example, when the audio codec is MP3, a sample rate of 96000 is not supported. If the container format is FLV, only sample rates of 22050 and 44100 are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>44100</para>
        /// </summary>
        [NameInMap("Samplerate")]
        [Validation(Required=false)]
        public string Samplerate { get; set; }

    }

}
