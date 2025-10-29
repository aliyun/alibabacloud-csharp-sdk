// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class UpdateCustomLiveStreamTranscodeRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application to which the stream belongs, and it cannot be modified.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveApp****</para>
        /// </summary>
        [NameInMap("App")]
        [Validation(Required=false)]
        public string App { get; set; }

        /// <summary>
        /// <para>Audio transcoding bitrate. Unit: kbps, value range: 1 to 1000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>512</para>
        /// </summary>
        [NameInMap("AudioBitrate")]
        [Validation(Required=false)]
        public int? AudioBitrate { get; set; }

        /// <summary>
        /// <para>Number of audio channels. Values: </para>
        /// <list type="bullet">
        /// <item><description>1: Mono. </description></item>
        /// <item><description>2: Stereo.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("AudioChannelNum")]
        [Validation(Required=false)]
        public int? AudioChannelNum { get; set; }

        /// <summary>
        /// <para>Audio encoding format. Values: </para>
        /// <list type="bullet">
        /// <item><description>aac </description></item>
        /// <item><description>mp3</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>aac</para>
        /// </summary>
        [NameInMap("AudioCodec")]
        [Validation(Required=false)]
        public string AudioCodec { get; set; }

        /// <summary>
        /// <para>Audio encoding. Values: </para>
        /// <list type="bullet">
        /// <item><description>aac_low</description></item>
        /// <item><description>aac_he</description></item>
        /// <item><description>aac_he_v2 </description></item>
        /// <item><description>aac_ld</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>aac_low</para>
        /// </summary>
        [NameInMap("AudioProfile")]
        [Validation(Required=false)]
        public string AudioProfile { get; set; }

        /// <summary>
        /// <para>Audio sampling rate. Values: 22050, 32000, 44100, 48000, 96000. Unit: Hz.</para>
        /// <remarks>
        /// <para>If <b>AudioProfile</b> is set to <b>aac_ld</b>, the sampling rate must not exceed 44100.</para>
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
        /// <item><description><b>UpLimit</b>: the maximum bitrate. Set this field to an integer from 128 to 10000. The value must be greater than the minimum bitrate.</description></item>
        /// <item><description><b>LowerLimit</b>: the minimum bitrate. Set this field to an integer from 128 to 10000. The value must be smaller than the maximum bitrate.</description></item>
        /// <item><description><b>Factor</b>: the ratio of the output bitrate to the source bitrate. Valid values: 0.1 to 1. The value is accurate to one decimal place. A value of 1 indicates that the output video has the same bitrate as the source video.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;UpLimit\&quot;:2500,\&quot;LowerLimit\&quot;:800,\&quot;Factor\&quot;:1}</para>
        /// </summary>
        [NameInMap("BitrateWithSource")]
        [Validation(Required=false)]
        public string BitrateWithSource { get; set; }

        [NameInMap("DeInterlaced")]
        [Validation(Required=false)]
        public bool? DeInterlaced { get; set; }

        /// <summary>
        /// <para>Streamer domain name, unmodifiable.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>Encryption configuration. JSON format, with the following fields: </para>
        /// <list type="bullet">
        /// <item><description>EncryptType: Type of encryption. Fixed value is aliyun.</description></item>
        /// <item><description>KmsKeyID: User\&quot;s KMS master key ID. </description></item>
        /// <item><description>KmsKeyExpireInterval: Key rotation period. Value range: 60~3600, unit: seconds.<remarks>
        /// <para>When using DRM encryption, KmsKeyID cannot be modified.</para>
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
        /// <para>Other source-based settings. The following fields are included:</para>
        /// <list type="bullet">
        /// <item><description><b>KeyFrameOpen</b>: Valid values: yes and no.</description></item>
        /// <item><description><b>Copyts</b>: Valid values: yes and no.</description></item>
        /// <item><description><b>SeiMode</b>: Valid values: 0, 1, and 2. 0 specifies that no supplemental enhancement information (SEI) messages are passed through, 1 specifies that part of SEI messages are passed through, and 2 specifies that all SEI messages are passed through.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;KeyFrameOpen\&quot;:\&quot;yes\&quot;,\&quot;Copyts\&quot;:\&quot;yes\&quot;,\&quot;SeiMode\&quot;:1}</para>
        /// </summary>
        [NameInMap("ExtWithSource")]
        [Validation(Required=false)]
        public string ExtWithSource { get; set; }

        /// <summary>
        /// <para>Transcode video frame rate. Unit: FPS, value range: 1 to 60.</para>
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
        /// <item><description><b>UpLimit</b>: the maximum frame rate. Set this field to an integer from 1 to 60. The value must be greater than the minimum frame rate.</description></item>
        /// <item><description><b>LowerLimit</b>: the minimum frame rate. Set this field to an integer from 1 to 60. The value must be smaller than the maximum frame rate.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;UpLimit\&quot;:60,\&quot;LowerLimit\&quot;:1}</para>
        /// </summary>
        [NameInMap("FpsWithSource")]
        [Validation(Required=false)]
        public string FpsWithSource { get; set; }

        /// <summary>
        /// <para>Video GOP (Group of Pictures), supports units in frames or seconds. When the unit is frames, the value should be {number}; when the unit is seconds, the value should be {number}s. </para>
        /// <list type="bullet">
        /// <item><description>For frames, the range is 1 to 3000. </description></item>
        /// <item><description>For seconds, the range is 1 to 20s.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Gop")]
        [Validation(Required=false)]
        public string Gop { get; set; }

        /// <summary>
        /// <para>Video transcoding height. Unit: pixels. The value must meet the following three conditions:</para>
        /// <list type="bullet">
        /// <item><description>Height ≥ 100: The height of the video must be no less than 100 pixels.</description></item>
        /// <item><description>max(Height, Width) ≤ 2560: The larger of the video\&quot;s width and height cannot exceed 2560.</description></item>
        /// <item><description>min(Height, Width) ≤ 1440: The smaller of the video\&quot;s width and height cannot exceed 1440.<remarks>
        /// <para>For 265 narrowband HD templates, the maximum resolution is 1280×720.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>720</para>
        /// </summary>
        [NameInMap("Height")]
        [Validation(Required=false)]
        public int? Height { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable triggered transcoding. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>yes</b>: enables triggered transcoding.</description></item>
        /// <item><description><b>no</b>: disables triggered transcoding.</description></item>
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
        /// <para>Encoding level. A set of specific encoding features supported by the video, generally, the higher the value, the better the picture quality, but also the higher the resources consumed for encoding and decoding. Values: </para>
        /// <list type="bullet">
        /// <item><description>1: baseline (suitable for mobile devices).</description></item>
        /// <item><description>2: main (suitable for standard resolution devices). </description></item>
        /// <item><description>3: high (suitable for high-resolution devices).</description></item>
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
        /// <para>{\&quot;Type\&quot;:\&quot;short\&quot;,\&quot;Value\&quot;:\&quot;1080\&quot;}</para>
        /// </summary>
        [NameInMap("ResWithSource")]
        [Validation(Required=false)]
        public string ResWithSource { get; set; }

        /// <summary>
        /// <para>Custom name of the transcoding template, not modifiable.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LiveCusTranscode****</para>
        /// </summary>
        [NameInMap("Template")]
        [Validation(Required=false)]
        public string Template { get; set; }

        /// <summary>
        /// <para>Custom transcoding template type, unmodifiable.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>h264</para>
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

        /// <summary>
        /// <para>Video transcoding bitrate. Unit: kbps, value range: 1 to 6000.</para>
        /// <remarks>
        /// <para>The actual bitrate of the transcoded video will try to be as close as possible to the one you set, but it cannot be guaranteed to be exactly the same, especially when the set bitrate is too high or too low.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>720</para>
        /// </summary>
        [NameInMap("VideoBitrate")]
        [Validation(Required=false)]
        public int? VideoBitrate { get; set; }

        /// <summary>
        /// <para>Video transcoding width. Unit: pixels. The value must meet the following three conditions: </para>
        /// <list type="bullet">
        /// <item><description>Width ≥ 100: The video width must be no less than 100 pixels. </description></item>
        /// <item><description>max(Height, Width) ≤ 2560: The larger of the video\&quot;s height and width cannot exceed 2560. </description></item>
        /// <item><description>min(Height, Width) ≤ 1440: The smaller of the video\&quot;s height and width cannot exceed 1440.<remarks>
        /// <para>For 265 narrowband HD templates, the maximum resolution is 1280×720.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>576</para>
        /// </summary>
        [NameInMap("Width")]
        [Validation(Required=false)]
        public int? Width { get; set; }

    }

}
