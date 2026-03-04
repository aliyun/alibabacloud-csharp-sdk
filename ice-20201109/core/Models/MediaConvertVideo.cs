// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class MediaConvertVideo : TeaModel {
        /// <summary>
        /// <para>The average bitrate of the output. If you use the CRB, ABR, or VBR bitrate control mode, you must specify Bitrate, and you must set TransMode to a valid value.</para>
        /// <list type="bullet">
        /// <item><description>Unit: Kbps.</description></item>
        /// <item><description>Valid values: -1 and [10,50000]. A value of -1 indicates that the original bitrate of the input is used.</description></item>
        /// </list>
        /// <para>Best practices:</para>
        /// <list type="bullet">
        /// <item><description>CBR: Set TransMode to CBR and Bitrate, Maxrate, and Bufsize to the same value.</description></item>
        /// <item><description>ABR: Set TransMode to onepass and specify Bitrate. You can also specify Maxrate and Bufsize to control the bitrate range.</description></item>
        /// <item><description>VBR: Set TransMode to twopass and specify Maxrate/BitrateBnd and Bufsize.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>6000</para>
        /// </summary>
        [NameInMap("Bitrate")]
        [Validation(Required=false)]
        public int? Bitrate { get; set; }

        /// <summary>
        /// <para>The buffer size. It controls bitrate fluctuations. A larger value allows for more bitrate variation and potentially higher video quality.</para>
        /// <list type="bullet">
        /// <item><description>Unit: Kbps.</description></item>
        /// <item><description>Valid values: [1000,128000].</description></item>
        /// <item><description>Default value: 6000.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>20000</para>
        /// </summary>
        [NameInMap("Bufsize")]
        [Validation(Required=false)]
        public int? Bufsize { get; set; }

        /// <summary>
        /// <para>The video codec.</para>
        /// <list type="bullet">
        /// <item><description>Valid values: H.264, H.265, AV1, GIF, and WEBP.</description></item>
        /// <item><description>Default value: H.264.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>H.264</para>
        /// </summary>
        [NameInMap("Codec")]
        [Validation(Required=false)]
        public string Codec { get; set; }

        /// <summary>
        /// <para>The quality control factor. To use the CRF mode, you must specify Crf and set TransMode to fixCRF. A larger value means lower quality and a higher compression ratio.</para>
        /// <list type="bullet">
        /// <item><description>Valid values: [20,51].</description></item>
        /// <item><description>If Codec is set to H.264, the default value is 23. If Codec is set to H.265, the default value is 26. If Codec is set to AV1, the default value is 32.</description></item>
        /// </list>
        /// <para>Best Practice:</para>
        /// <list type="bullet">
        /// <item><description>A value of 0 specifies lossless quality. A value of 51 specifies the worst quality. A recommended range is [23, 29]. You can adjust the value based on the complexity of the image. If you increase the value by six, the bitrate is reduced by half. Under the same definition, you can set the value for an animated cartoon higher than that for a shot video.</description></item>
        /// <item><description>CRF targets perceptual quality, not a fixed bitrate. Use it with Maxrate and Bufsize to control bitrate fluctuations.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>23</para>
        /// </summary>
        [NameInMap("Crf")]
        [Validation(Required=false)]
        public object Crf { get; set; }

        /// <summary>
        /// <para>Crops the video frame. You can set automatic black border removal or custom cropping.</para>
        /// <list type="bullet">
        /// <item><description><para>Specify this parameter if the input resolution is greater than the output resolution. Do not specify AdjDarMethod if this parameter is specified.</para>
        /// </description></item>
        /// <item><description><para>To automatically remove black borders, set this parameter to border.</para>
        /// </description></item>
        /// <item><description><para>To use custom cropping, set the parameter in the format of {width}:{height}:{left}:{top}.</para>
        /// <list type="bullet">
        /// <item><description>width: the width of the output video.</description></item>
        /// <item><description>height: the height of the output video.</description></item>
        /// <item><description>left: the distance between the left border of the output and that of the original frame.</description></item>
        /// <item><description>top: the distance between the top border of the output and that of the original frame.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>Example: 1920:800:0:140.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1920:800:0:140</para>
        /// </summary>
        [NameInMap("Crop")]
        [Validation(Required=false)]
        public string Crop { get; set; }

        /// <summary>
        /// <para>The frame rate of the video stream.</para>
        /// <list type="bullet">
        /// <item><description>Unit: frames per second (FPS).</description></item>
        /// <item><description>Valid values: (0,60].</description></item>
        /// <item><description>Default value: the frame rate of the input file. If the original frame rate exceeds 60 FPS, 60 is used.</description></item>
        /// <item><description>Recommended values: 24, 25, and 30.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>25</para>
        /// </summary>
        [NameInMap("Fps")]
        [Validation(Required=false)]
        public object Fps { get; set; }

        /// <summary>
        /// <para>The keyframe interval.</para>
        /// <list type="bullet">
        /// <item><description>Set by time: The time interval, in seconds. Valid values: [1,100000].</description></item>
        /// <item><description>Set by frame count: The number of frames. Valid values: [1,100000].</description></item>
        /// <item><description>Default value: 10s.</description></item>
        /// </list>
        /// <para>Best practice: Set this parameter to 2-7s to improve the Time-to-First-Frame and seeking performance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10s</para>
        /// </summary>
        [NameInMap("Gop")]
        [Validation(Required=false)]
        public object Gop { get; set; }

        /// <summary>
        /// <para>The height or short edge of the output. If LongShortMode is set to false or left empty, this parameter specifies the height of the output. If LongShortMode is set to true, this parameter specifies the short edge of the output.</para>
        /// <list type="bullet">
        /// <item><description><para>Unit: pixel.</para>
        /// </description></item>
        /// <item><description><para>Valid values: [128,4096]. The value must be an even number.</para>
        /// </description></item>
        /// <item><description><para>Default value:</para>
        /// <list type="bullet">
        /// <item><description>If neither Width nor Height is specified, the dimension of the input is used.</description></item>
        /// <item><description>If only Width is specified, Height is auto-scaled.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1080</para>
        /// </summary>
        [NameInMap("Height")]
        [Validation(Required=false)]
        public int? Height { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable orientation-adaptive scaling. This parameter takes effect if at least one of the Width and Height parameters is specified. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// <item><description>Default value: false.</description></item>
        /// </list>
        /// <para>Best practice: Enable this feature when your inputs include both horizontal and vertical videos. This prevents videos from stretching.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("LongShortMode")]
        [Validation(Required=false)]
        public bool? LongShortMode { get; set; }

        /// <summary>
        /// <para>The maximum frame rate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25</para>
        /// </summary>
        [NameInMap("MaxFps")]
        [Validation(Required=false)]
        public object MaxFps { get; set; }

        /// <summary>
        /// <para>The maximum bitrate of the output.</para>
        /// <list type="bullet">
        /// <item><description>Unit: Kbps.</description></item>
        /// <item><description>Valid values: [10,50000].</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("Maxrate")]
        [Validation(Required=false)]
        public int? Maxrate { get; set; }

        /// <summary>
        /// <para>The black borders added to the video.</para>
        /// <list type="bullet">
        /// <item><description><para>Specify this parameter if the input resolution is smaller than the output resolution. If you specify this parameter, do not specify IsCheckReso, IsCheckResoFail, or AdjDarMethod.</para>
        /// </description></item>
        /// <item><description><para>Format: {width}:{height}:{left}:{top}.</para>
        /// <list type="bullet">
        /// <item><description>width: the width of the output video.</description></item>
        /// <item><description>height: the height of the output video.</description></item>
        /// <item><description>left: the distance between the left border of the output and that of the original frame.</description></item>
        /// <item><description>top: the distance between the top border of the output and that of the original frame.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>Example: 1920:1080:0:140.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1920:1080:0:140</para>
        /// </summary>
        [NameInMap("Pad")]
        [Validation(Required=false)]
        public string Pad { get; set; }

        /// <summary>
        /// <para>The codec profile.</para>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only if Codec is set to H.264.</description></item>
        /// <item><description>Valid values: baseline, main, and high.</description></item>
        /// <item><description>Default value: high.</description></item>
        /// </list>
        /// <para>Best practice: For multi-bitrate streaming, use baseline for the lowest quality rendition to ensure maximum compatibility with older devices. Use main or high for other renditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>high</para>
        /// </summary>
        [NameInMap("Profile")]
        [Validation(Required=false)]
        public string Profile { get; set; }

        /// <summary>
        /// <para>The video quality scale. This parameter applies to VBR mode. A higher value means lower video quality and a higher compression ratio.</para>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only if Codec is set to H.264.</description></item>
        /// <item><description>Valid values: [0,51].</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>13</para>
        /// </summary>
        [NameInMap("Qscale")]
        [Validation(Required=false)]
        public int? Qscale { get; set; }

        /// <summary>
        /// <para>Specifies whether to delete the video stream. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: deletes the video stream. All video-related parameters are invalid.</description></item>
        /// <item><description>false: retains the video stream.</description></item>
        /// <item><description>Default value: false.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Remove")]
        [Validation(Required=false)]
        public bool? Remove { get; set; }

        /// <summary>
        /// <para>The scan mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If you leave this parameter empty, the output follows the source\&quot;s original scan mode.</description></item>
        /// <item><description>auto: automatic deinterlacing</description></item>
        /// <item><description>progressive</description></item>
        /// <item><description>interlaced</description></item>
        /// <item><description>By default, this parameter is left empty.</description></item>
        /// </list>
        /// <para>Best practice: The interlaced scan mode saves data traffic than the progressive scan mode but provides poor image quality. Therefore, the latter is commonly used in mainstream video production.</para>
        /// <list type="bullet">
        /// <item><description>If you set ScanMode to progressive or interlaced, but this scan mode does not match that of the input, the video fails to be transcoded.</description></item>
        /// <item><description>To improve compatibility, leave this parameter empty or set it to auto.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>auto</para>
        /// </summary>
        [NameInMap("ScanMode")]
        [Validation(Required=false)]
        public string ScanMode { get; set; }

        /// <summary>
        /// <para>The width or long edge of the output. If LongShortMode is set to false or left empty, this parameter specifies the width of the output. If LongShortMode is set to true, this parameter specifies the long edge of the output.</para>
        /// <list type="bullet">
        /// <item><description><para>Unit: pixel.</para>
        /// </description></item>
        /// <item><description><para>Valid values: [128,4096]. The value must be an even number.</para>
        /// </description></item>
        /// <item><description><para>Default value:</para>
        /// <list type="bullet">
        /// <item><description>If neither Width nor Height is specified, the dimension of the input is used.</description></item>
        /// <item><description>If only Height is specified, Width is auto-scaled.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1920</para>
        /// </summary>
        [NameInMap("Width")]
        [Validation(Required=false)]
        public int? Width { get; set; }

    }

}
