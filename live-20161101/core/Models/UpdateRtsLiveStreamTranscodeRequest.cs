// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class UpdateRtsLiveStreamTranscodeRequest : TeaModel {
        /// <summary>
        /// <para>The AppName of the live stream. This parameter cannot be modified.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun-test</para>
        /// </summary>
        [NameInMap("App")]
        [Validation(Required=false)]
        public string App { get; set; }

        /// <summary>
        /// <para>The output audio bitrate. Unit: kbps. Valid values: 1 to <b>1000</b>.</para>
        /// <remarks>
        /// <para>Required if you set TemplateType to audio.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>128</para>
        /// </summary>
        [NameInMap("AudioBitrate")]
        [Validation(Required=false)]
        public int? AudioBitrate { get; set; }

        /// <summary>
        /// <para>The number of audio channels. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: mono.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: stereo.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("AudioChannelNum")]
        [Validation(Required=false)]
        public int? AudioChannelNum { get; set; }

        /// <summary>
        /// <para>The audio codec. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>aac</para>
        /// </description></item>
        /// <item><description><para>mp3</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>To use the Opus codec, set the Opus parameter to true.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>aac</para>
        /// </summary>
        [NameInMap("AudioCodec")]
        [Validation(Required=false)]
        public string AudioCodec { get; set; }

        /// <summary>
        /// <para>The audio codec profile. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>aac_low</para>
        /// </description></item>
        /// <item><description><para>aac_he</para>
        /// </description></item>
        /// <item><description><para>aac_he_v2</para>
        /// </description></item>
        /// <item><description><para>aac_ld</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>aac_low</para>
        /// </summary>
        [NameInMap("AudioProfile")]
        [Validation(Required=false)]
        public string AudioProfile { get; set; }

        /// <summary>
        /// <para>The audio sample rate. Valid values: 22050, 32000, 44100, 48000, 96000. Recommended: 44100. Unit: Hz.</para>
        /// <remarks>
        /// <para>If AudioProfile is set to aac_ld, the sample rate cannot exceed 44100.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>44100</para>
        /// </summary>
        [NameInMap("AudioRate")]
        [Validation(Required=false)]
        public int? AudioRate { get; set; }

        /// <summary>
        /// <para>Controls whether to remove B-frames from the transcoded output video. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The transcoded video has no B-frames.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The transcoded video contains B-frames. This is the default value.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Required if you set TemplateType to h264, h264-nbhd, or h264-origin.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeleteBframes")]
        [Validation(Required=false)]
        public bool? DeleteBframes { get; set; }

        /// <summary>
        /// <para>The streaming domain. This parameter cannot be modified.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The frame rate of the output video. Unit: frames per second (FPS). Valid values: 1 to <b>60</b>.</para>
        /// <remarks>
        /// <para>Required if you set TemplateType to h264, h264-nbhd, or h264-origin.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("FPS")]
        [Validation(Required=false)]
        public int? FPS { get; set; }

        /// <summary>
        /// <para>The Group of Pictures (GOP) size, which specifies the keyframe interval. Unit: seconds. Valid values: <b>1</b> to <b>3</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Gop")]
        [Validation(Required=false)]
        public string Gop { get; set; }

        /// <summary>
        /// <para>Output video height in pixels.</para>
        /// <para>Requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>Height ≥ 100</para>
        /// </description></item>
        /// <item><description><para>max(Height, Width) ≤ 2560</para>
        /// </description></item>
        /// <item><description><para>min(Height, Width) ≤ 1440</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>Required if you set TemplateType to h264, h264-nbhd, or h264-origin.</para>
        /// </description></item>
        /// <item><description><para>For h264-origin templates, the resolution can be up to 4K to retain the information of the source stream.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1280</para>
        /// </summary>
        [NameInMap("Height")]
        [Validation(Required=false)]
        public int? Height { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable on-demand transcoding. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>yes</b>: Transcoding only starts when the first viewer requests this transcoded stream.</para>
        /// </description></item>
        /// <item><description><para><b>no</b>: Transcoding starts immediately after the stream is published.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>no</para>
        /// </summary>
        [NameInMap("Lazy")]
        [Validation(Required=false)]
        public string Lazy { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the Opus codec for audio transcoding. This is mainly for compatibility with native WebRTC. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Transcodes the audio to the Opus format.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Does not use the Opus format for transcoding. This is the default value.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Opus")]
        [Validation(Required=false)]
        public bool? Opus { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The video codec profile. A larger value indicates better video quality and higher resource consumption for encoding and decoding. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: baseline (for mobile devices).</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: main (for SD devices).</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: high (for HD devices).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Profile")]
        [Validation(Required=false)]
        public int? Profile { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the custom transcoding template. This parameter cannot be modified.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ld</para>
        /// </summary>
        [NameInMap("Template")]
        [Validation(Required=false)]
        public string Template { get; set; }

        /// <summary>
        /// <para>The type of the custom transcoding template. This parameter cannot be modified.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>h264</para>
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

        /// <summary>
        /// <para>The output video bitrate. Unit: kbps. Valid values: 1 to <b>6000</b>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>Required if you set TemplateType to h264, h264-nbhd, or h264-origin.</para>
        /// </description></item>
        /// <item><description><para>The system tries to transcode the video at the specified bitrate. However, the actual bitrate may not be the same as the specified value, especially when the specified value is too high or too low.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("VideoBitrate")]
        [Validation(Required=false)]
        public int? VideoBitrate { get; set; }

        /// <summary>
        /// <para>Output video width in pixels.</para>
        /// <para>Requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>Width ≥ 100</para>
        /// </description></item>
        /// <item><description><para>max(Height, Width) ≤ 2560</para>
        /// </description></item>
        /// <item><description><para>min(Height, Width) ≤ 1440</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Required if you set TemplateType to h264, h264-nbhd, or h264-origin.</para>
        /// </remarks>
        /// <para>For h264-origin templates, the resolution can be up to 4K to retain the information of the source stream.</para>
        /// 
        /// <b>Example:</b>
        /// <para>720</para>
        /// </summary>
        [NameInMap("Width")]
        [Validation(Required=false)]
        public int? Width { get; set; }

    }

}
