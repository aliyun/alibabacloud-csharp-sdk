// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class UpdateRtsLiveStreamTranscodeRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application to which the live stream belongs, which cannot be modified.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun-test</para>
        /// </summary>
        [NameInMap("App")]
        [Validation(Required=false)]
        public string App { get; set; }

        /// <summary>
        /// <para>The bitrate of the output audio. Unit: Kbit/s. Valid values: 1 to 1000.</para>
        /// <remarks>
        /// <para> This parameter is required if you set the TemplateType parameter to audio.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>128</para>
        /// </summary>
        [NameInMap("AudioBitrate")]
        [Validation(Required=false)]
        public int? AudioBitrate { get; set; }

        /// <summary>
        /// <para>The number of sound channels. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: mono</description></item>
        /// <item><description><b>2</b>: stereo</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("AudioChannelNum")]
        [Validation(Required=false)]
        public int? AudioChannelNum { get; set; }

        /// <summary>
        /// <para>The audio encoder. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>aac</description></item>
        /// <item><description>mp3</description></item>
        /// </list>
        /// <remarks>
        /// <para> To use the Opus encoder, you need only to set the Opus parameter to true.</para>
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
        /// <item><description>aac_low</description></item>
        /// <item><description>aac_he</description></item>
        /// <item><description>aac_he_v2</description></item>
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
        /// <para>The audio sampling rate. Valid values: 22050, 32000, 44100, 48000, and 96000. 44100 is commonly used. Unit: Hz.</para>
        /// <remarks>
        /// <para> If the value of the AudioProfile parameter is aac_ld, the audio sampling rate cannot exceed 44,100.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>44100</para>
        /// </summary>
        [NameInMap("AudioRate")]
        [Validation(Required=false)]
        public int? AudioRate { get; set; }

        /// <summary>
        /// <para>Specifies whether to remove B frames during transcoding. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Remove B frames.</description></item>
        /// <item><description>false (default): Retain B frames.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is required when the TemplateType parameter is set to h264, h264-nbhd, or h264-origin.</para>
        /// </description></item>
        /// <item><description><para>If this parameter is not specified, the default value false is used.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeleteBframes")]
        [Validation(Required=false)]
        public bool? DeleteBframes { get; set; }

        /// <summary>
        /// <para>The main streaming domain, which cannot be modified.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The frame rate of the output video. Unit: frames per second (FPS). Valid values: 1 to 60.</para>
        /// <remarks>
        /// <para> This parameter is required when the TemplateType parameter is set to h264, h264-nbhd, or h264-origin.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("FPS")]
        [Validation(Required=false)]
        public int? FPS { get; set; }

        /// <summary>
        /// <para>The group of pictures (GOP) of the output video. This parameter is used to specify the keyframe interval. Unit: seconds. Valid values: 1 to 3.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Gop")]
        [Validation(Required=false)]
        public string Gop { get; set; }

        /// <summary>
        /// <para>The height of the output video. Unit: pixel.</para>
        /// <para>The value must comply with the following rules:</para>
        /// <list type="bullet">
        /// <item><description>Height ≥ 100: The height of the video is at least 100 pixels.</description></item>
        /// <item><description>max(Height,Width) ≤ 2560: The larger of the width and height of the video cannot exceed 2,560 pixels.</description></item>
        /// <item><description>min(Height,Width) ≤ 1440: The smaller of the width and height of the video cannot exceed 1,440 pixels. For example, a resolution of 1560 × 1560 pixels is invalid.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is required when the TemplateType parameter is set to h264, h264-nbhd, or h264-origin.</para>
        /// </description></item>
        /// <item><description><para>If the TemplateType parameter is set to h264-origin, the highest resolution supported is 4K.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1280</para>
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
        /// <para>no</para>
        /// </summary>
        [NameInMap("Lazy")]
        [Validation(Required=false)]
        public string Lazy { get; set; }

        /// <summary>
        /// <para>Specifies whether to transcode streams to the Opus format to be compatible with native WebRTC. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Transcode streams to the Opus format.</description></item>
        /// <item><description>false: Do not transcode streams to the Opus format.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If this parameter is not specified, the default value false is used.</para>
        /// </remarks>
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
        /// <para>The ID of the custom transcoding template, which cannot be modified.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ld</para>
        /// </summary>
        [NameInMap("Template")]
        [Validation(Required=false)]
        public string Template { get; set; }

        /// <summary>
        /// <para>The type of the custom transcoding template, which cannot be modified.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>h264</para>
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

        /// <summary>
        /// <para>The bitrate of the output video. Unit: Kbit/s. Valid values: 1 to 6000.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is required when the TemplateType parameter is set to h264, h264-nbhd, or h264-origin.</para>
        /// </description></item>
        /// <item><description><para>The bitrate of the output video is as close to the value that you specify as possible, but not the same as the value, especially when the value is excessively large or small.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("VideoBitrate")]
        [Validation(Required=false)]
        public int? VideoBitrate { get; set; }

        /// <summary>
        /// <para>The width of the output video. Unit: pixel.</para>
        /// <para>The value must comply with the following rules:</para>
        /// <list type="bullet">
        /// <item><description>Width ≥ 100: The width of the video is at least 100 pixels.</description></item>
        /// <item><description>max(Height,Width) ≤ 2560: The larger of the width and height of the video cannot exceed 2,560 pixels.</description></item>
        /// <item><description>min(Height,Width) ≤ 1440: The smaller of the width and height of the video cannot exceed 1,440 pixels. For example, a resolution of 1560 × 1560 pixels is invalid.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is required when the TemplateType parameter is set to h264, h264-nbhd, or h264-origin.</para>
        /// </description></item>
        /// <item><description><para>If the TemplateType parameter is set to h264-origin, the highest resolution supported is 4K.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>720</para>
        /// </summary>
        [NameInMap("Width")]
        [Validation(Required=false)]
        public int? Width { get; set; }

    }

}
