// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddRtsLiveStreamTranscodeRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application to which the live stream belongs. Value requirements:</para>
        /// <list type="bullet">
        /// <item><description>The name can contain letters, digits, underscores (_), and hyphens (-).</description></item>
        /// <item><description>We recommend that you specify a name that is more than three characters in length. The name must start with a letter or digit.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun-test</para>
        /// </summary>
        [NameInMap("App")]
        [Validation(Required=false)]
        public string App { get; set; }

        /// <summary>
        /// <para>The bitrate of the output audio. Unit: Kbit/s. Valid values: <b>1</b> to <b>1000</b>.</para>
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
        /// <item><description><b>aac</b></description></item>
        /// <item><description><b>mp3</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>If you want to use the Opus encoding format, set the Opus parameter to true.</para>
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
        /// <para>The audio sampling rate. Valid values: <b>22050 to 96000</b>. The value 44100 is commonly used. Unit: Hz.</para>
        /// <remarks>
        /// <para>If you set the AudioProfile parameter to aac_ld, the audio sampling rate cannot exceed 44,100 Hz.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>44100</para>
        /// </summary>
        [NameInMap("AudioRate")]
        [Validation(Required=false)]
        public int? AudioRate { get; set; }

        /// <summary>
        /// <para>Specifies whether to remove B-frames during transcoding. Valid values:</para>
        /// <remarks>
        /// <para> This parameter is required if you set the TemplateType parameter to h264, h264-nbhd, or h264-origin.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><b>true</b>: removes B-frames.</description></item>
        /// <item><description><b>false</b>: retains B-frames. This is the default value.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify this parameter, the default value <b>false</b> is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeleteBframes")]
        [Validation(Required=false)]
        public bool? DeleteBframes { get; set; }

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
        /// <para>The frame rate of the output video. Unit: FPS. Valid values: <b>1</b> to <b>60</b>.</para>
        /// <remarks>
        /// <para> This parameter is required if you set the TemplateType parameter to h264, h264-nbhd, or h264-origin.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("FPS")]
        [Validation(Required=false)]
        public int? FPS { get; set; }

        /// <summary>
        /// <para>The group of pictures (GOP) size of the output video. This parameter is used to specify the keyframe interval. Unit: seconds. Valid values: <b>1</b> to <b>3</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Gop")]
        [Validation(Required=false)]
        public string Gop { get; set; }

        /// <summary>
        /// <para>The height of the output video. Unit: pixels.</para>
        /// <remarks>
        /// <para> This parameter is required if you set the TemplateType parameter to h264, h264-nbhd, or h264-origin.</para>
        /// </remarks>
        /// <para>The value must comply with the following rules:****</para>
        /// <list type="bullet">
        /// <item><description><b>Height ≥ 100</b>: The height of the video is no less than 100 pixels.</description></item>
        /// <item><description><b>max(Height,Width) ≤ 2560</b>: The width or height of the video, whichever is greater, cannot exceed 2,560 pixels.</description></item>
        /// <item><description><b>min(Height,Width) ≤ 1440</b>: The width or height of the video, whichever is smaller, cannot exceed 1,440 pixels.</description></item>
        /// </list>
        /// <para>For example, a resolution of 1560 × 1560 pixels is invalid.</para>
        /// <remarks>
        /// <para>An original quality template needs to retain the source information. Therefore, the video resolution cannot exceed 4K.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1280</para>
        /// </summary>
        [NameInMap("Height")]
        [Validation(Required=false)]
        public int? Height { get; set; }

        /// <summary>
        /// <para>Specifies whether to trigger transcoding only when a stream is pulled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>yes</b>: triggers transcoding only when a stream is pulled.</description></item>
        /// <item><description><b>no</b>: triggers transcoding whenever a stream is ingested, no matter whether the stream is pulled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>no</para>
        /// </summary>
        [NameInMap("Lazy")]
        [Validation(Required=false)]
        public string Lazy { get; set; }

        /// <summary>
        /// <para>Specifies whether to transcode audio to the Opus format to be compatible with native WebRTC. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: transcodes audio to the Opus format.</description></item>
        /// <item><description><b>false</b>: does not transcode audio to the Opus format.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify this parameter, the default value <b>false</b> is used.</para>
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
        /// <para>The codec profile. The video codec profile determines how ApsaraVideo Live performs codec on the video. In normal cases, a greater value indicates a higher image quality and requires more codec resources. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: baseline, which is suitable for mobile devices.</description></item>
        /// <item><description><b>2</b>: main, which is suitable for standard-definition devices.</description></item>
        /// <item><description><b>3</b>: high, which is suitable for high-definition devices.</description></item>
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
        /// <para>The name of the transcoding template. Value requirements:</para>
        /// <list type="bullet">
        /// <item><description>The name can contain letters, digits, underscores (_), and hyphens (-).</description></item>
        /// <item><description>We recommend that you specify a name that is more than three characters in length. The name must start with a letter or digit.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The name cannot be the same as that of a default transcoding template.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ld</para>
        /// </summary>
        [NameInMap("Template")]
        [Validation(Required=false)]
        public string Template { get; set; }

        /// <summary>
        /// <para>The type of the transcoding template.</para>
        /// <para>If you set this parameter to h264, h264-nbhd, or h264-origin, you must also specify the Height, Width, FPS, VideoBitrate, and DeleteBframes parameters. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>h264</b>: H.264 standard transcoding template.</description></item>
        /// <item><description><b>h264-nbhd</b>: H.264 Narrowband HD™ transcoding template.</description></item>
        /// <item><description><b>h264-origin</b>: H.264 original quality template. If you use this type of template, the same transcoding parameters of the video source are retained by default.</description></item>
        /// <item><description><b>audio</b>: audio-only transcoding template. If you use this type of template, images are removed from the video source and an audio-only stream is generated. In addition, you must also specify the AudioBitrate parameter.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>h264</para>
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

        /// <summary>
        /// <para>The bitrate of the output video. Unit: Kbit/s. Valid values: <b>1</b> to <b>6000</b>.</para>
        /// <remarks>
        /// <para> This parameter is required if you set the TemplateType parameter to h264, h264-nbhd, or h264-origin.</para>
        /// </remarks>
        /// <remarks>
        /// <para>The bitrate of the output video is as close to the value that you specify as possible, but not exactly the same as the value, especially when the value is excessively large or small.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("VideoBitrate")]
        [Validation(Required=false)]
        public int? VideoBitrate { get; set; }

        /// <summary>
        /// <para>The width of the output video. Unit: pixels.</para>
        /// <remarks>
        /// <para> This parameter is required if you set the TemplateType parameter to h264, h264-nbhd, or h264-origin.</para>
        /// </remarks>
        /// <para>The value must comply with the following rules:</para>
        /// <list type="bullet">
        /// <item><description><b>Width ≥ 100</b>: The width of the video is no less than 100 pixels.</description></item>
        /// <item><description><b>max(Height,Width) ≤ 2560</b>: The width or height of the video, whichever is greater, cannot exceed 2,560 pixels.</description></item>
        /// <item><description><b>min(Height,Width) ≤ 1440</b>: The width or height of the video, whichever is smaller, cannot exceed 1,440 pixels.</description></item>
        /// </list>
        /// <para>For example, a resolution of 1560 × 1560 pixels is invalid.</para>
        /// <remarks>
        /// <para>An original quality template needs to retain the source information. Therefore, the video resolution cannot exceed 4K.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>720</para>
        /// </summary>
        [NameInMap("Width")]
        [Validation(Required=false)]
        public int? Width { get; set; }

    }

}
