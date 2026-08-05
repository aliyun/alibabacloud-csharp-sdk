// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddCustomLiveStreamTranscodeRequest : TeaModel {
        /// <summary>
        /// <para>The AppName of the live stream.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveApp****</para>
        /// </summary>
        [NameInMap("App")]
        [Validation(Required=false)]
        public string App { get; set; }

        /// <summary>
        /// <para>The output audio bitrate. Unit: kbps. Valid values: 1 to <b>1000</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>512</para>
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
        /// <item><description><para><b>AAC</b></para>
        /// </description></item>
        /// <item><description><para><b>MP3</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AAC</para>
        /// </summary>
        [NameInMap("AudioCodec")]
        [Validation(Required=false)]
        public string AudioCodec { get; set; }

        /// <summary>
        /// <para>The audio profile. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>aac_low</b></para>
        /// </description></item>
        /// <item><description><para><b>aac_he</b></para>
        /// </description></item>
        /// <item><description><para><b>aac_he_v2</b></para>
        /// </description></item>
        /// <item><description><para><b>aac_ld</b></para>
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
        /// <para>The audio sample rate. Valid values: <b>22050</b> to <b>96000</b>.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>If you set AudioProfile to <b>aac_ld</b>, the sample rate cannot exceed 44100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>96000</para>
        /// </summary>
        [NameInMap("AudioRate")]
        [Validation(Required=false)]
        public int? AudioRate { get; set; }

        /// <summary>
        /// <para>The adaptive bitrate settings. If specified, it overrides the VideoBitrate parameter. Fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>UpLimit (integer):</b> Required. The upper limit of the bitrate. This must be an integer from 128 to 10000 and greater than the lower limit.</para>
        /// </description></item>
        /// <item><description><para><b>LowerLimit (integer):</b> Required. The lower limit of the bitrate. This must be an integer from 128 to 10000 and less than the upper limit.</para>
        /// </description></item>
        /// <item><description><para><b>Factor (float):</b> Required: The factor by which the source bitrate is multiplied to calculate the output bitrate. Valid values: 0.1 to 1. The value can be accurate to one decimal place. A value of 1 indicates that the output bitrate is the same as the source bitrate.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;UpLimit&quot;:2500,&quot;LowerLimit&quot;:800,&quot;Factor&quot;:1}</para>
        /// </summary>
        [NameInMap("BitrateWithSource")]
        [Validation(Required=false)]
        public string BitrateWithSource { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically detect and remove interlacing during transcoding. Deinterlacing converts interlaced video into progressive video.</para>
        /// <list type="bullet">
        /// <item><description><para>true: enables deinterlacing.</para>
        /// </description></item>
        /// <item><description><para>false: keeps the source format. This is the default value.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeInterlaced")]
        [Validation(Required=false)]
        public bool? DeInterlaced { get; set; }

        /// <summary>
        /// <para>The streaming domain.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The encryption settings, formatted as a JSON string.</para>
        /// <list type="bullet">
        /// <item><description><para><b>EncryptType</b>: The encryption type. Set the value to aliyun.</para>
        /// </description></item>
        /// <item><description><para><b>KmsKeyID</b>: The ID of the customer master key (CMK) in Key Management Service (KMS).</para>
        /// </description></item>
        /// <item><description><para><b>KmsKeyExpireInterval</b>: The key rotation period. Unit: seconds. Valid values: <b>60 to 3600.</b></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If set, its internal fields cannot be empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;EncryptType&quot;: &quot;aliyun&quot;, &quot;KmsKeyID&quot;:&quot;afce5722-81d2-43c3-9930-7601da11****&quot;,&quot;KmsKeyExpireInterval&quot;:&quot;3600&quot;}</para>
        /// </summary>
        [NameInMap("EncryptParameters")]
        [Validation(Required=false)]
        public string EncryptParameters { get; set; }

        /// <summary>
        /// <para>Other adaptive settings that align the transcoded stream with the source stream. Fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>KeyFrameOpen</b>: Specifies whether to align keyframes with the source stream. Valid values: yes and no.</para>
        /// </description></item>
        /// <item><description><para><b>Copyts (string)</b>: Specifies whether to align the presentation timestamp (PTS) with the source stream. Valid values: yes and no.</para>
        /// </description></item>
        /// <item><description><para><b>SeiMode</b>: The pass-through mode for Supplemental Enhancement Information (SEI). Valid values: 0 (disabled) and 1 (enabled).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;KeyFrameOpen&quot;:&quot;yes&quot;,&quot;Copyts&quot;:&quot;yes&quot;,&quot;SeiMode&quot;:1}</para>
        /// </summary>
        [NameInMap("ExtWithSource")]
        [Validation(Required=false)]
        public string ExtWithSource { get; set; }

        /// <summary>
        /// <para>The frame rate of the output video. Unit: frames per second (FPS). Valid values: 1 to <b>60</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("FPS")]
        [Validation(Required=false)]
        public int? FPS { get; set; }

        /// <summary>
        /// <para>Adapts the output frame rate based on the source\&quot;s frame rate, while keeping it within a specified range. If specified, it overrides the FPS parameter. Fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>UpLimit (integer):</b> Required. The upper limit of the frame rate. This must be an integer from 1 to 60 and greater than the lower limit.</para>
        /// </description></item>
        /// <item><description><para><b>LowerLimit (integer):</b> Required. The lower limit of the frame rate. This must be an integer from 1 to 60 and less than the upper limit.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;UpLimit&quot;:60,&quot;LowerLimit&quot;:1}</para>
        /// </summary>
        [NameInMap("FpsWithSource")]
        [Validation(Required=false)]
        public string FpsWithSource { get; set; }

        /// <summary>
        /// <para>The Group of Pictures (GOP) size. The unit can be frame or second. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>By frames: 1 to 3000.</para>
        /// </description></item>
        /// <item><description><para>By seconds: 1s to 20s.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Gop")]
        [Validation(Required=false)]
        public string Gop { get; set; }

        /// <summary>
        /// <para>Output video height in pixels. Requirements:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Height ≥ 100</b></para>
        /// </description></item>
        /// <item><description><para><b>max(Height, Width) ≤ 2560</b></para>
        /// </description></item>
        /// <item><description><para><b>min(Height, Width) ≤ 1440</b></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>For h265-nbhd, it cannot exceed 720.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>720</para>
        /// </summary>
        [NameInMap("Height")]
        [Validation(Required=false)]
        public int? Height { get; set; }

        /// <summary>
        /// <para>The key rotation period. Unit: seconds. Valid values: 60 to 3600.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("KmsKeyExpireInterval")]
        [Validation(Required=false)]
        public string KmsKeyExpireInterval { get; set; }

        /// <summary>
        /// <para>The ID of the customer master key (CMK) in Key Management Service (KMS).</para>
        /// 
        /// <b>Example:</b>
        /// <para>afce5722-81d2-43c3-9930-7601da11****</para>
        /// </summary>
        [NameInMap("KmsKeyID")]
        [Validation(Required=false)]
        public string KmsKeyID { get; set; }

        /// <summary>
        /// <para>The ID of the KMS account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25346073170691****</para>
        /// </summary>
        [NameInMap("KmsUID")]
        [Validation(Required=false)]
        public string KmsUID { get; set; }

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
        /// <para>yes</para>
        /// </summary>
        [NameInMap("Lazy")]
        [Validation(Required=false)]
        public string Lazy { get; set; }

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
        /// <para>The adaptive resolution settings. If specified, it overrides the Height and Width parameters. Fieds:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Type (string):</b> Required. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>short</b>: sets the shorter edge of the video to the specified value and scales the other edge to maintain the original aspect ratio.</para>
        /// </description></item>
        /// <item><description><para><b>long</b>: sets the longer edge of the video to the specified value and scales the other edge to maintain the original aspect ratio.</para>
        /// </description></item>
        /// <item><description><para><b>screen</b>: Matches the output to a standard resolution, automatically flipping the dimensions based on the source\&quot;s orientation.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>Value (string):</b> Required. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>For short: 360, 480, 540, 720, and 1080.</para>
        /// </description></item>
        /// <item><description><para>For long: 640, 848, 960, 1280, and 1920.</para>
        /// </description></item>
        /// <item><description><para>For screen: 640×360, 848×480, 960×540, 1280×720, and 1920×1080.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Type&quot;:&quot;short&quot;,&quot;Value&quot;:&quot;1080&quot;}</para>
        /// </summary>
        [NameInMap("ResWithSource")]
        [Validation(Required=false)]
        public string ResWithSource { get; set; }

        /// <summary>
        /// <para>The custom name of the transcoding template.</para>
        /// <remarks>
        /// <para>The name can contain digits, letters, and hyphens (-). It must start with a digit or a letter. It cannot be the same as the name of a standard transcoding template.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LiveCusTranscode****</para>
        /// </summary>
        [NameInMap("Template")]
        [Validation(Required=false)]
        public string Template { get; set; }

        /// <summary>
        /// <para>The type of the custom transcoding template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>h264</b>: custom H.264 standard transcoding.</para>
        /// </description></item>
        /// <item><description><para><b>h264-nbhd</b>: custom H.264 Narrowband HD™ transcoding.</para>
        /// </description></item>
        /// <item><description><para><b>h265</b>: custom H.265 standard transcoding.</para>
        /// </description></item>
        /// <item><description><para><b>h265-nbhd</b>: custom H.265 Narrowband HD™ transcoding.</para>
        /// </description></item>
        /// <item><description><para><b>audio</b>: audio-only transcoding.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>For video types, Height, Width, FPS, and VideoBitrate are required.</para>
        /// </remarks>
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
        /// <para>The system tries to transcode the video at the specified bitrate. However, the actual bitrate may not be the same as the specified value, especially when the specified value is too high or too low.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>720</para>
        /// </summary>
        [NameInMap("VideoBitrate")]
        [Validation(Required=false)]
        public int? VideoBitrate { get; set; }

        /// <summary>
        /// <para>Output video width in pixels.</para>
        /// <para>Requirements:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Width ≥ 100</b></para>
        /// </description></item>
        /// <item><description><para><b>max(Height, Width) ≤ 2560</b></para>
        /// </description></item>
        /// <item><description><para><b>min(Height, Width) ≤ 1440</b></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>For h265-nbhd, it cannot exceed 1280.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>576</para>
        /// </summary>
        [NameInMap("Width")]
        [Validation(Required=false)]
        public int? Width { get; set; }

    }

}
