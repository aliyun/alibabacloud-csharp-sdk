// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class TargetAudio : TeaModel {
        /// <summary>
        /// <para>Specifies whether to disable audio stream generation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: disables audio stream generation. No audio stream is included in the output file.</description></item>
        /// <item><description>false: does not disable audio stream generation. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DisableAudio")]
        [Validation(Required=false)]
        public bool? DisableAudio { get; set; }

        /// <summary>
        /// <para>The audio processing settings. This parameter is invalid if <b>TranscodeAudio</b> is left empty or <b>TranscodeAudio.Codec</b> is set to copy.</para>
        /// <remarks>
        /// <para> This parameter is not available to the GenerateVideoPlaylist operation.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("FilterAudio")]
        [Validation(Required=false)]
        public TargetAudioFilterAudio FilterAudio { get; set; }
        public class TargetAudioFilterAudio : TeaModel {
            /// <summary>
            /// <para>Specifies whether to mix all sound tracks into a single track. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>false (default)</description></item>
            /// <item><description>true</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Mixing")]
            [Validation(Required=false)]
            public bool? Mixing { get; set; }

        }

        /// <summary>
        /// <para>The index numbers of audio streams. If you do not specify this parameter, the first audio stream (the one with the smallest index number) is processed. If the array contains an element greater than 100, all audio streams are processed.</para>
        /// <list type="bullet">
        /// <item><description>For example, you can set the parameter to <c>[0,1]</c> to process audio streams with index numbers 0 and 1, <c>[1]</c> to process only the audio stream with the index number 1, or <c>[101]</c> to process all audio streams.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you specify an index number but no audio stream with the index number is found, the index number is ignored.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Stream")]
        [Validation(Required=false)]
        public List<long?> Stream { get; set; }

        /// <summary>
        /// <para>The audio transcoding settings. If you do not specify this parameter, no audio streams are included in the output file.</para>
        /// <remarks>
        /// <para> We recommend that you do not use this parameter to disable audio stream generation.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("TranscodeAudio")]
        [Validation(Required=false)]
        public TargetAudioTranscodeAudio TranscodeAudio { get; set; }
        public class TargetAudioTranscodeAudio : TeaModel {
            /// <summary>
            /// <para>The bitrate of the audio stream. Unit: bit/s. This parameter and the <b>Quality</b> parameter are mutually exclusive. Valid values: 1000 to 10000000.</para>
            /// 
            /// <b>Example:</b>
            /// <para>64000</para>
            /// </summary>
            [NameInMap("Bitrate")]
            [Validation(Required=false)]
            public int? Bitrate { get; set; }

            /// <summary>
            /// <para>The audio bitrate option. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>fixed: always uses the target bitrate.</description></item>
            /// <item><description>adaptive: uses the source bitrate when the source bitrate is smaller than the target bitrate.</description></item>
            /// <item><description>fall: returns a failure when the source bitrate is smaller than the target bitrate.</description></item>
            /// </list>
            /// <para>Default values:</para>
            /// <list type="bullet">
            /// <item><description>fixed for the CreateMediaConvert operation.</description></item>
            /// <item><description>adaptive for the GenerateVideoPlaylist operation.</description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter must be used in conjunction with the <b>Bitrate</b> parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>fixed</para>
            /// </summary>
            [NameInMap("BitrateOption")]
            [Validation(Required=false)]
            public string BitrateOption { get; set; }

            /// <summary>
            /// <para>The audio bit depth. Valid values: 16 and 24.</para>
            /// <remarks>
            /// <para> This parameter takes effect only when Codec is set to flac.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("BitsPerSample")]
            [Validation(Required=false)]
            public int? BitsPerSample { get; set; }

            /// <summary>
            /// <para>The number of sound channels. By default, the audio stream has the same number of sound channels as the source audio. Valid values: [1,8].</para>
            /// <remarks>
            /// <para> The number of sound channels varies with audio formats: one or two for MP3, up to six for AC3 5.1, and one for AMR.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Channel")]
            [Validation(Required=false)]
            public int? Channel { get; set; }

            /// <summary>
            /// <para>The codec. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>copy, mp3, vorbis, aac, flac, ac3, opus, and amr for the CreateMediaConvert operation. The default value is copy.</description></item>
            /// <item><description>aac for the GenerateVideoPlaylist operation. The default value is aac.</description></item>
            /// </list>
            /// <remarks>
            /// <para> When you set the parameter to copy, the audio stream is directly copied into the output file and all other parameters in <b>TranscodeAudio</b> do not take effect. The copy value is commonly used in container format conversion scenarios. You cannot use this value in audio merging scenarios.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>aac</para>
            /// </summary>
            [NameInMap("Codec")]
            [Validation(Required=false)]
            public string Codec { get; set; }

            /// <summary>
            /// <para>The audio quality. Valid values: 0 to 100. The greater the value, the higher the quality. This parameter and the <b>Bitrate</b> parameter are mutually exclusive.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("Quality")]
            [Validation(Required=false)]
            public int? Quality { get; set; }

            /// <summary>
            /// <para>The sampling rate option. Unit: Hz. By default, the source sampling rate is used. Valid values: 8000, 12025, 12000, 16000, 22050, 24000, 32000, 44100, 48000, 64000, 88200, and 96000.</para>
            /// <remarks>
            /// <para> Supported sampling rates vary with formats: 48 kHz and lower for MP3, 8 kHz, 12 kHz, 16 kHz, 24 kHz, and 48 kHz for Opus, 32 kHz, 44.1 kHz, and 48 kHz for AC3, and 8 kHz and 16 kHz for AMR.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>12050</para>
            /// </summary>
            [NameInMap("SampleRate")]
            [Validation(Required=false)]
            public int? SampleRate { get; set; }

            /// <summary>
            /// <para>The sampling rate option. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>fixed: always uses the target sampling rate.</description></item>
            /// <item><description>adaptive: uses the source sampling rate when the source sampling rate is smaller than the target sampling rate.</description></item>
            /// <item><description>fall: returns a failure when the source sampling rate is smaller than the target sampling rate.</description></item>
            /// </list>
            /// <para>Default values:</para>
            /// <list type="bullet">
            /// <item><description>fixed for the CreateMediaConvert operation.</description></item>
            /// <item><description>adaptive for the GenerateVideoPlaylist operation.</description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter must be used in conjunction with the <b>SampleRate</b> parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>fixed</para>
            /// </summary>
            [NameInMap("SampleRateOption")]
            [Validation(Required=false)]
            public string SampleRateOption { get; set; }

        }

    }

}
