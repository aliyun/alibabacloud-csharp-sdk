// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddCustomLiveStreamTranscodeRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application to which the live stream belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveApp****</para>
        /// </summary>
        [NameInMap("App")]
        [Validation(Required=false)]
        public string App { get; set; }

        /// <summary>
        /// <para>The bitrate of the output audio. Unit: Kbit/s. Valid values: <b>1 to 1000</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>512</para>
        /// </summary>
        [NameInMap("AudioBitrate")]
        [Validation(Required=false)]
        public int? AudioBitrate { get; set; }

        /// <summary>
        /// <para>The number of sound channels. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: mono.</description></item>
        /// <item><description><b>2</b>: binaural.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("AudioChannelNum")]
        [Validation(Required=false)]
        public int? AudioChannelNum { get; set; }

        /// <summary>
        /// <para>The audio encoding format. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>AAC</b></description></item>
        /// <item><description><b>MP3</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AAC</para>
        /// </summary>
        [NameInMap("AudioCodec")]
        [Validation(Required=false)]
        public string AudioCodec { get; set; }

        /// <summary>
        /// <para>The audio encoding profile. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>aac_low</b></description></item>
        /// <item><description><b>aac_he</b></description></item>
        /// <item><description><b>aac_he_v2</b></description></item>
        /// <item><description><b>aac_ld</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>aac_low</para>
        /// </summary>
        [NameInMap("AudioProfile")]
        [Validation(Required=false)]
        public string AudioProfile { get; set; }

        /// <summary>
        /// <para>The audio sampling rate. Valid values: <b>22050 to 96000</b>.</para>
        /// <remarks>
        /// <para>Notice: If you set AudioProfile to <b>aac_ld</b>, the audio sampling rate cannot exceed 44100.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>96000</para>
        /// </summary>
        [NameInMap("AudioRate")]
        [Validation(Required=false)]
        public int? AudioRate { get; set; }

        /// <summary>
        /// <para>The source-based bitrate settings. This parameter takes precedence over other bitrate settings. The following fields must be included:</para>
        /// <list type="bullet">
        /// <item><description><b>UpLimit</b>: the maximum bitrate limit. Valid values: an integer from 128 to 10000. The value must be greater than the minimum bitrate.</description></item>
        /// <item><description><b>LowerLimit int</b> : the minimum bitrate rate. Valid values: an integer from 128 to 10000. The value must be smaller than the maximum bitrate.</description></item>
        /// <item><description><b>Factor</b>: The ratio of the output bitrate to the source bitrate. Valid values: 0.1 to 1. The value is accurate to one decimal place. A value of 1 indicates that the output video has the same bitrate as the source video.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;UpLimit&quot;:2500,&quot;LowerLimit&quot;:800,&quot;Factor&quot;:1}</para>
        /// </summary>
        [NameInMap("BitrateWithSource")]
        [Validation(Required=false)]
        public string BitrateWithSource { get; set; }

        /// <summary>
        /// <para>The main streaming domain.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>Encryption configuration. In JSON format, the fields are explained as follows:</para>
        /// <list type="bullet">
        /// <item><description><b>EncryptType</b>: Encryption type. Fixed value is aliyun.</description></item>
        /// <item><description><b>KmsKeyID</b>: User KMS master key ID.</description></item>
        /// <item><description><b>KmsKeyExpireInterval</b>: Key rotation period. Range: 60~3600, unit: seconds.<remarks>
        /// <para>If the EncryptParameters is configured, the KmsKeyID, KmsUID, and KmsKeyExpireInterval parameters cannot be empty</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;EncryptType&quot;: &quot;aliyun&quot;, &quot;KmsKeyID&quot;:&quot;afce5722-81d2-43c3-9930-7601da11****&quot;,&quot;KmsKeyExpireInterval&quot;:&quot;3600&quot;}</para>
        /// </summary>
        [NameInMap("EncryptParameters")]
        [Validation(Required=false)]
        public string EncryptParameters { get; set; }

        /// <summary>
        /// <para>Other source-based settings, including the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>KeyFrameOpen</b>: specifies whether to use the key frames of the source video. Valid values: yes or no.</description></item>
        /// <item><description><b>Copyts</b>: specifies whether to use the presentation time stamp (PTS) of the source video. Valid values: yes or no.</description></item>
        /// <item><description><b>SeiMode</b>: specifies whether to pass through supplemental enhancement information (SEI) messages. Valid values: 0, 1, and 2, where 0 specifies that no SEI messages are passed through, 1 specifies that part of SEI messages are passed through, and 2 specifies that all SEI messages are passed through.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;KeyFrameOpen&quot;:&quot;yes&quot;,&quot;Copyts&quot;:&quot;yes&quot;,&quot;SeiMode&quot;:1}</para>
        /// </summary>
        [NameInMap("ExtWithSource")]
        [Validation(Required=false)]
        public string ExtWithSource { get; set; }

        /// <summary>
        /// <para>The frame rate of the output video. Unit: frames per second (FPS). Valid values: <b>1 to 60</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("FPS")]
        [Validation(Required=false)]
        public int? FPS { get; set; }

        /// <summary>
        /// <para>The source-based frame rate settings. This parameter takes precedence over other frame rate settings. The following fields must be included:</para>
        /// <list type="bullet">
        /// <item><description><b>UpLimit</b>: the maximum frame rate. Valid values: an integer from 1 to 60. The value must be greater than the minimum frame rate.</description></item>
        /// <item><description><b>LowerLimit</b>: the minimum frame rate. Valid values: an integer from 1 to 60. The value must be smaller than the maximum frame rate.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;UpLimit&quot;:60,&quot;LowerLimit&quot;:1}</para>
        /// </summary>
        [NameInMap("FpsWithSource")]
        [Validation(Required=false)]
        public string FpsWithSource { get; set; }

        /// <summary>
        /// <para>The Group of Picture (GOP) size of the video. Unit: frames or seconds.</para>
        /// <list type="bullet">
        /// <item><description>Unit: frames. Valid values: <b>1 to 3000</b>.</description></item>
        /// <item><description>Unit: seconds. Valid value: <b>1 to 20</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Gop")]
        [Validation(Required=false)]
        public string Gop { get; set; }

        /// <summary>
        /// <para>The height of the output video. Unit: pixel. Valid values:</para>
        /// <para>The value must comply with all the following rules:</para>
        /// <list type="bullet">
        /// <item><description><b>Height ≥ 100</b>: The height of the video is greater than or equal to 100 pixels.</description></item>
        /// <item><description><b>max(Height,Width) ≤ 2560</b>: The width or height of the video, whichever is greater, cannot exceed 2,560 pixels.</description></item>
        /// <item><description><b>min(Height,Width) ≤ 1440</b>: The width or height of the video, whichever is smaller, cannot exceed 1,440 pixels.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The resolution of the output video that is transcoded by using the H.265 Narrowband HD™ transcoding template cannot exceed 1280 × 720 pixels.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>720</para>
        /// </summary>
        [NameInMap("Height")]
        [Validation(Required=false)]
        public int? Height { get; set; }

        /// <summary>
        /// <para>The rotation period of the CMK. Valid values: 60 to 3600. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("KmsKeyExpireInterval")]
        [Validation(Required=false)]
        public string KmsKeyExpireInterval { get; set; }

        /// <summary>
        /// <para>The ID of the customer master key (CMK) that you created in Key Management Service (KMS).</para>
        /// 
        /// <b>Example:</b>
        /// <para>afce5722-81d2-43c3-9930-7601da11****</para>
        /// </summary>
        [NameInMap("KmsKeyID")]
        [Validation(Required=false)]
        public string KmsKeyID { get; set; }

        /// <summary>
        /// <para>The ID of your KMS account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25346073170691****</para>
        /// </summary>
        [NameInMap("KmsUID")]
        [Validation(Required=false)]
        public string KmsUID { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the load-on-demand mechanism for transcoding. Valid values: yes and no. Default value: <b>yes</b>.</para>
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
        /// <para>The video encoding profile. The profile defines a set of parameters that are used to encode a video. In most cases, a greater value indicates better image quality and higher resource consumption. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: baseline. This value is suitable for mobile devices.</description></item>
        /// <item><description><b>2</b>: main. This value is suitable for standard-definition devices.</description></item>
        /// <item><description><b>3</b>: high. This value is suitable for high-definition devices.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Profile")]
        [Validation(Required=false)]
        public int? Profile { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The source-based resolution settings. This parameter takes precedence over other resolution settings. The following fields must be included:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Type</b>: You can set this field to short, long, or screen. short specifies that the resolution of the output video is adapted to the shorter side, long specifies that the resolution of the output video is adapted to the longer side, and screen specifies that the output video has an adaptive resolution.</para>
        /// </description></item>
        /// <item><description><para><b>Value</b>:</para>
        /// <list type="bullet">
        /// <item><description>Set this field to 360, 480, 540, 720, or 1080 if the Type field is set to short.</description></item>
        /// <item><description>Set this field to 640, 848, 960, 1280, or 1920 if the Type field is set to long.</description></item>
        /// <item><description>Set this field to 640\*360, 848\*480, 960\*540, 1280\*720, or 1920\*1080 if the Type field is set to screen.</description></item>
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
        /// <para>The name of the custom transcoding template.</para>
        /// <remarks>
        /// <para>The name can contain digits, letters, and hyphens (-), and must start with a letter or digit. The name must be different from the names of any default transcoding templates.</para>
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
        /// <item><description><b>h264</b>: custom H.264 standard transcoding.</description></item>
        /// <item><description><b>h264-nbhd</b>: custom H.264 Narrowband HD™ transcoding.</description></item>
        /// <item><description><b>h265</b>: custom H.265 standard transcoding.</description></item>
        /// <item><description><b>h265-nbhd</b>: custom H.265 Narrowband HD™ transcoding.</description></item>
        /// <item><description><b>audio</b>: audio-only transcoding.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you set <b>TemplateType</b> to <b>h264</b>, <b>h264-nbhd</b>, <b>h265</b>, or <b>h265-nbhd</b>, the <b>Height</b>, <b>Width</b>, <b>FPS</b>, and <b>VideoBitrate</b> parameters are required.</para>
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
        /// <para>The bitrate of the output video. Unit: Kbit/s. Valid values: <b>1 to 6000</b>.</para>
        /// <remarks>
        /// <para>The bitrate of the output video may not be the same as the value that you specify, but is as close to the value as possible, especially when the value is excessively large or small.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>720</para>
        /// </summary>
        [NameInMap("VideoBitrate")]
        [Validation(Required=false)]
        public int? VideoBitrate { get; set; }

        /// <summary>
        /// <para>The width of the output video. Unit: pixel. Valid values:</para>
        /// <para>The value must comply with all the following rules:</para>
        /// <list type="bullet">
        /// <item><description><b>Width ≥ 100</b>: The width of the video is greater than or equal to 100 pixels.</description></item>
        /// <item><description><b>max(Height,Width) ≤ 2560</b>: The width or height of the video, whichever is greater, cannot exceed 2,560 pixels.</description></item>
        /// <item><description><b>min(Height,Width) ≤ 1440</b>: The width or height of the video, whichever is smaller, cannot exceed 1,440 pixels.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The resolution of the output video that is transcoded by using the H.265 Narrowband HD™ transcoding template cannot exceed 1280 × 720 pixels.</para>
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
