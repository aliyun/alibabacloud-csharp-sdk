// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class MediaConvertTransConfig : TeaModel {
        /// <summary>
        /// <para>The method for adjusting the resolution. This parameter takes effect only if both the Width and Height parameters are specified. You can use this parameter together with the LongShortMode parameter.</para>
        /// <list type="bullet">
        /// <item><description>Valid values: rescale, crop, pad, and none.</description></item>
        /// <item><description>Default value: none.</description></item>
        /// <item><description></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>rescale</para>
        /// </summary>
        [NameInMap("AdjDarMethod")]
        [Validation(Required=false)]
        public string AdjDarMethod { get; set; }

        /// <summary>
        /// <para>Specifies whether to check the audio bitrate. Mutually exclusive with IsCheckVideoBitrateFail. IsCheckVideoBitrateFail has a higher priority.</para>
        /// <list type="bullet">
        /// <item><description><para>true: checks the audio bitrate. If the source bitrate is lower than the target, the task will transcode using the source bitrate.</para>
        /// </description></item>
        /// <item><description><para>false: does not check the audio bitrate.</para>
        /// </description></item>
        /// <item><description><para>Default value:</para>
        /// <list type="bullet">
        /// <item><description>If this parameter is not specified and the codec of the output audio is different from that of the input audio, the default value is false.</description></item>
        /// <item><description>If this parameter is not specified and the codec of the output audio is the same as that of the input audio, the default value is true.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("IsCheckAudioBitrate")]
        [Validation(Required=false)]
        public bool? IsCheckAudioBitrate { get; set; }

        /// <summary>
        /// <para>Specifies whether to check the audio bitrate. Mutually exclusive with IsCheckAudioBitrate. This parameter has a higher priority.</para>
        /// <list type="bullet">
        /// <item><description>true: checks the audio bitrate. If the source bitrate is lower than the target, the task will fail.</description></item>
        /// <item><description>false: does not check the audio bitrate.</description></item>
        /// <item><description>Default value: false.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("IsCheckAudioBitrateFail")]
        [Validation(Required=false)]
        public bool? IsCheckAudioBitrateFail { get; set; }

        /// <summary>
        /// <para>Specifies whether to check the video resolution. Mutually exclusive with IsCheckResoFail. IsCheckResoFail has a higher priority.</para>
        /// <list type="bullet">
        /// <item><description>true: checks the video resolution. If the source resolution (width or height) is smaller than the target, the task will transcode using the source resolution.</description></item>
        /// <item><description>false: does not check the video resolution.</description></item>
        /// <item><description>Default value: false.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("IsCheckReso")]
        [Validation(Required=false)]
        public bool? IsCheckReso { get; set; }

        /// <summary>
        /// <para>Specifies whether to check the video resolution. Mutually exclusive with IsCheckReso. This parameter has a higher priority.</para>
        /// <list type="bullet">
        /// <item><description>true: checks the video resolution. If the source resolution (width or height) is smaller than the target, the task will fail.</description></item>
        /// <item><description>false: does not check the video resolution.</description></item>
        /// <item><description>Default value: false.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("IsCheckResoFail")]
        [Validation(Required=false)]
        public bool? IsCheckResoFail { get; set; }

        /// <summary>
        /// <para>Specifies whether to check the video bitrate. Mutually exclusive with IsCheckVideoBitrateFail. IsCheckVideoBitrateFail has a higher priority.</para>
        /// <list type="bullet">
        /// <item><description>true: checks the video bitrate. If the source bitrate is lower than the target, the task will transcode using the source bitrate.</description></item>
        /// <item><description>false: does not check the video bitrate.</description></item>
        /// <item><description>Default value: false.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("IsCheckVideoBitrate")]
        [Validation(Required=false)]
        public bool? IsCheckVideoBitrate { get; set; }

        /// <summary>
        /// <para>Specifies whether to check the video bitrate. Mutually exclusive with IsCheckVideoBitrate. This parameter has a higher priority.</para>
        /// <list type="bullet">
        /// <item><description>true: checks the video bitrate. If the source bitrate is lower than the target, the task will fail.</description></item>
        /// <item><description>false: does not check the video bitrate.</description></item>
        /// <item><description>Default value: false.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("IsCheckVideoBitrateFail")]
        [Validation(Required=false)]
        public bool? IsCheckVideoBitrateFail { get; set; }

        /// <summary>
        /// <para>The video bitrate control mode. This is only valid for H.264, H.265, and AV1 codecs and must be used with the correct Bitrate or Crf settings. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CBR: Constant bitrate mode.</description></item>
        /// <item><description>onepass: Typically used for Average bitrate mode (ABR). Faster than twopass.</description></item>
        /// <item><description>twopass: Typically used for variable bitrate mode (VBR). Slower than onepass.</description></item>
        /// <item><description>fixCRF: Constant Rate Factor (quality-based) mode.</description></item>
        /// <item><description>If you specify the Bitrate parameter, the default value of this parameter is onepass. If you do not specify the Bitrate parameter, the default value of this parameter is fixCRF, and the default value of the Crf parameter is used.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>onepass</para>
        /// </summary>
        [NameInMap("TransMode")]
        [Validation(Required=false)]
        public string TransMode { get; set; }

    }

}
