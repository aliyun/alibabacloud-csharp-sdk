// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class TargetVideo : TeaModel {
        /// <summary>
        /// <para>Specifies whether to disable video stream generation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: disables video stream generation. No video stream is included in the output file.</description></item>
        /// <item><description>false: does not disable video stream generation. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DisableVideo")]
        [Validation(Required=false)]
        public bool? DisableVideo { get; set; }

        /// <summary>
        /// <para>The video processing parameters. This parameter is invalid if <b>TranscodeVideo</b> is left empty or <b>TranscodeVideo.Codec</b> is set to copy.</para>
        /// <remarks>
        /// <para>This parameter is not available to the GenerateVideoPlaylist operation.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("FilterVideo")]
        [Validation(Required=false)]
        public TargetVideoFilterVideo FilterVideo { get; set; }
        public class TargetVideoFilterVideo : TeaModel {
            /// <summary>
            /// <para>The configurations for blurring a rectangular area of the video. This parameter is used to remove logos from videos, such as TV channel logos.</para>
            /// </summary>
            [NameInMap("Delogos")]
            [Validation(Required=false)]
            public List<TargetVideoFilterVideoDelogos> Delogos { get; set; }
            public class TargetVideoFilterVideoDelogos : TeaModel {
                /// <summary>
                /// <para>The duration of the blur in seconds. By default, the blur lasts until the end of the video.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public double? Duration { get; set; }

                /// <summary>
                /// <para>The value of the parameter can be an integer or a decimal.</para>
                /// <list type="bullet">
                /// <item><description>0: indicates that both the offset in pixels and the ratio of the horizontal offset relative to the height of the target resolution are 0. This is the default value.</description></item>
                /// <item><description>An integer: the offset in pixels. Valid values: [1,4096].</description></item>
                /// <item><description>A decimal: the ratio of the horizontal offset relative to the height of the target resolution. Valid values: (0,1).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Dx")]
                [Validation(Required=false)]
                public float? Dx { get; set; }

                /// <summary>
                /// <para>Default value: 0. The value of the parameter can be an integer or a decimal.</para>
                /// <list type="bullet">
                /// <item><description>0: indicates that both the offset in pixels and the ratio of the vertical offset relative to the height of the target resolution are 0. This is the default value.</description></item>
                /// <item><description>An integer: the offset in pixels. Valid values: [1,4096].</description></item>
                /// <item><description>A decimal: the ratio of the vertical offset relative to the height of the target resolution. Valid values: (0,1).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Dy")]
                [Validation(Required=false)]
                public float? Dy { get; set; }

                /// <summary>
                /// <para>The height of the blur. The default value is 1.0, which specifies that the blur is as high as the video. The value can be a decimal or an integer.</para>
                /// <list type="bullet">
                /// <item><description>An integer: the number of pixels. Valid values: [1,4096].</description></item>
                /// <item><description>A decimal: the ratio relative to the height of the target resolution. Valid values: (0,1).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>40</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public float? Height { get; set; }

                /// <summary>
                /// <para>The reference position of the blur. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>topleft: the upper-left corner. This is the default value.</description></item>
                /// <item><description>topright: the upper-right corner.</description></item>
                /// <item><description>bottomright: the lower-right corner.</description></item>
                /// <item><description>bottomleft: the lower-left corner.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>topleft</para>
                /// </summary>
                [NameInMap("ReferPos")]
                [Validation(Required=false)]
                public string ReferPos { get; set; }

                /// <summary>
                /// <para>The start time of blurring (in seconds). By default, the blur begins at the start time of the video.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public double? StartTime { get; set; }

                /// <summary>
                /// <para>The width of the blur. The default value is 1.0, which specifies that the blur is as wide as the video. The value can be a decimal or an integer.</para>
                /// <list type="bullet">
                /// <item><description>An integer: the number of pixels. Valid values: [1,4096].</description></item>
                /// <item><description>A decimal: the ratio relative to the width of the target resolution. Valid values: (0,1).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public float? Width { get; set; }

            }

            /// <summary>
            /// <para>The video anonymization settings.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>This parameter only applies to the CreateMediaConvertTask operation.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("Desensitization")]
            [Validation(Required=false)]
            public TargetVideoFilterVideoDesensitization Desensitization { get; set; }
            public class TargetVideoFilterVideoDesensitization : TeaModel {
                /// <summary>
                /// <para>The settings for face anonymization.</para>
                /// </summary>
                [NameInMap("Face")]
                [Validation(Required=false)]
                public TargetVideoFilterVideoDesensitizationFace Face { get; set; }
                public class TargetVideoFilterVideoDesensitizationFace : TeaModel {
                    /// <summary>
                    /// <para>The minimum confidence threshold. Valid values: 0 to 1. Default value: 0.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Confidence")]
                    [Validation(Required=false)]
                    public float? Confidence { get; set; }

                    /// <summary>
                    /// <para>This parameter does not take effect if the width or height of the bounding box of a face falls below the specified minimum threshold. Default value: 0.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MinSize")]
                    [Validation(Required=false)]
                    public int? MinSize { get; set; }

                }

                /// <summary>
                /// <para>The settings for license plate anonymization.</para>
                /// </summary>
                [NameInMap("LicensePlate")]
                [Validation(Required=false)]
                public TargetVideoFilterVideoDesensitizationLicensePlate LicensePlate { get; set; }
                public class TargetVideoFilterVideoDesensitizationLicensePlate : TeaModel {
                    /// <summary>
                    /// <para>The minimum confidence threshold. Valid values: 0 to 1. Default value: 0.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Confidence")]
                    [Validation(Required=false)]
                    public float? Confidence { get; set; }

                    /// <summary>
                    /// <para>The minimum threshold for license plate size. This parameter does not take effect if the width or height of the bounding box of a license plate falls below the specified minimum threshold. Default value: 0.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MinSize")]
                    [Validation(Required=false)]
                    public int? MinSize { get; set; }

                }

            }

            /// <summary>
            /// <para>The video playback speed. Valid values: [0.5,1.0]. Default value: 1.0.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>This parameter specifies the ratio of the playback speed of the output media file to the default playback speed of the source media file. It does not indicate transcoding acceleration.</description></item>
            /// </list>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>This parameter only applies to the CreateMediaConvertTask operation.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("Speed")]
            [Validation(Required=false)]
            public float? Speed { get; set; }

            /// <summary>
            /// <para>The video watermarks.</para>
            /// </summary>
            [NameInMap("Watermarks")]
            [Validation(Required=false)]
            public List<TargetVideoFilterVideoWatermarks> Watermarks { get; set; }
            public class TargetVideoFilterVideoWatermarks : TeaModel {
                /// <summary>
                /// <para>The color of the text watermark border. You can specify a color name, such as &quot;red&quot; or &quot;green&quot;, or an RGB color code. The default color is #000000.</para>
                /// <remarks>
                /// <para>This parameter takes effect only when the Type parameter is set to text.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>red</para>
                /// </summary>
                [NameInMap("BorderColor")]
                [Validation(Required=false)]
                public string BorderColor { get; set; }

                /// <summary>
                /// <para>The width of the text watermark border. Unit: pixels. The value must be an integer within the [0,4096] range. Default value: 0.</para>
                /// <remarks>
                /// <para>This parameter takes effect only when the Type parameter is set to text.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("BorderWidth")]
                [Validation(Required=false)]
                public int? BorderWidth { get; set; }

                /// <summary>
                /// <para>The content of the text watermark. By default, this parameter is left empty.</para>
                /// <remarks>
                /// <para>This parameter takes effect only when the Type parameter is set to text.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>example</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The duration of watermarking (in seconds). By default, the watermark lasts until the video ends.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public double? Duration { get; set; }

                /// <summary>
                /// <para>The value of the parameter can be an integer or a decimal.</para>
                /// <list type="bullet">
                /// <item><description>0: indicates that both the offset in pixels and the ratio of the horizontal offset relative to the height of the target resolution are 0. This is the default value.</description></item>
                /// <item><description>An integer: the offset in pixels. Valid values: [1,4096].</description></item>
                /// <item><description>A decimal: the ratio of the horizontal offset relative to the height of the target resolution. Valid values: (0,1).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Dx")]
                [Validation(Required=false)]
                public float? Dx { get; set; }

                /// <summary>
                /// <para>The value of the parameter can be an integer or a decimal.</para>
                /// <list type="bullet">
                /// <item><description>0: indicates that both the offset in pixels and the ratio of the vertical offset relative to the height of the target resolution are 0. This is the default value.</description></item>
                /// <item><description>An integer: the offset in pixels. Valid values: [1,4096].</description></item>
                /// <item><description>A decimal: the ratio of the vertical offset relative to the height of the target resolution. Valid values: (0,1).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Dy")]
                [Validation(Required=false)]
                public float? Dy { get; set; }

                /// <summary>
                /// <para>The font transparency of the text watermark. Valid values: (0,1]. Default value: 1, which specifies that the text watermark is fully opaque.</para>
                /// <remarks>
                /// <para>This parameter takes effect only when the Type parameter is set to text.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0.8</para>
                /// </summary>
                [NameInMap("FontApha")]
                [Validation(Required=false)]
                public float? FontApha { get; set; }

                /// <summary>
                /// <para>The color of the text watermark. You can specify a color name, such as &quot;red&quot; or &quot;green&quot;, or an RGB color code. The default color is #000000.</para>
                /// <remarks>
                /// <para>This parameter takes effect only when the Type parameter is set to text.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>red</para>
                /// </summary>
                [NameInMap("FontColor")]
                [Validation(Required=false)]
                public string FontColor { get; set; }

                /// <summary>
                /// <para>The font of the text watermark. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>SourceHanSans-Regular (default)</description></item>
                /// <item><description>SourceHanSans-Bold</description></item>
                /// <item><description>SourceHanSerif-Regular</description></item>
                /// <item><description>SourceHanSerif-Bold</description></item>
                /// </list>
                /// <remarks>
                /// <para>This parameter takes effect only when the Type parameter is set to text.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>SourceHanSans-Bold</para>
                /// </summary>
                [NameInMap("FontName")]
                [Validation(Required=false)]
                public string FontName { get; set; }

                /// <summary>
                /// <para>The size of the text watermark. Default value: 16. The value must be an integer within the (4,120) range.</para>
                /// <remarks>
                /// <para>This parameter takes effect only when the Type parameter is set to text.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>18</para>
                /// </summary>
                [NameInMap("FontSize")]
                [Validation(Required=false)]
                public int? FontSize { get; set; }

                /// <summary>
                /// <para>The height of the image watermark. By default, the height is the same as the height of the original watermark file. The value of the parameter can be an integer or a decimal.</para>
                /// <list type="bullet">
                /// <item><description>An integer: the number of pixels excluding the height of the logo. Valid values: [1,4096].</description></item>
                /// <item><description>A decimal: the ratio relative to the height of the target resolution. Valid values: (0,1).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>40</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public float? Height { get; set; }

                /// <summary>
                /// <para>The reference position for adding the watermark. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>topleft: the upper-left corner. This is the default value.</description></item>
                /// <item><description>topright: the upper-right corner.</description></item>
                /// <item><description>bottomright: the lower-right corner.</description></item>
                /// <item><description>bottomleft: the lower-left corner.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>topleft</para>
                /// </summary>
                [NameInMap("ReferPos")]
                [Validation(Required=false)]
                public string ReferPos { get; set; }

                /// <summary>
                /// <para>The start time of watermarking (in seconds). By default, the watermark begins at the start time of the video.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public double? StartTime { get; set; }

                /// <summary>
                /// <para>The watermark type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>text: a text watermark. This is the default value.</description></item>
                /// <item><description>file: a still or animated image watermark.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The Object Storage Service (OSS) URI of the watermark file. The watermark file can be a PNG or MOV file.</para>
                /// <para>The URI is in the <c>oss://&lt;bucket&gt;/&lt;object&gt;</c> format, where <c>&lt;bucket&gt;</c> is the name of the bucket in the same region as the current project and <c>&lt;object&gt;</c> is the path of the object with the extension included.</para>
                /// <remarks>
                /// <para>This parameter takes effect only when the Type parameter is set to file.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>oss://test-bucket/watermark</para>
                /// </summary>
                [NameInMap("URI")]
                [Validation(Required=false)]
                public string URI { get; set; }

                /// <summary>
                /// <para>The width of the image watermark. By default, the width is the same as the width of the original watermark file. The value of the parameter can be an integer or a decimal.</para>
                /// <list type="bullet">
                /// <item><description>An integer: the number of pixels excluding the width of the logo. Valid values: [1,4096].</description></item>
                /// <item><description>A decimal: the ratio relative to the width of the target resolution. Valid values: (0,1).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public float? Width { get; set; }

            }

        }

        /// <summary>
        /// <para>The index numbers of video streams. If you do not specify this parameter, the first video stream (the one with the smallest index number) is processed. If the array contains an element greater than 100, all video streams are processed.</para>
        /// <list type="bullet">
        /// <item><description>For example, you can set the parameter to <c>[0,1]</c> to process video streams with index numbers 0 and 1, <c>[1]</c> to process only the video stream with the index number 1, and <c>[101]</c> to process all video streams.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you specify an index number but no video stream with the index number is found, the index number is ignored.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Stream")]
        [Validation(Required=false)]
        public List<int?> Stream { get; set; }

        /// <summary>
        /// <para>The video transcoding parameters. If you do not specify this parameter, no video streams are included in the output file.</para>
        /// <remarks>
        /// <para>We recommend that you do not use this parameter to disable video stream generation.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("TranscodeVideo")]
        [Validation(Required=false)]
        public TargetVideoTranscodeVideo TranscodeVideo { get; set; }
        public class TargetVideoTranscodeVideo : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable adaptation to resolution based on long and short sides. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The format of the <b>Resolution</b> parameter is <c>LongSide×ShortSide</c>. This is the default value.</description></item>
            /// <item><description>false: The format of the <b>Resolution</b> parameter is <c>Width×Height</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AdaptiveResolutionDirection")]
            [Validation(Required=false)]
            public bool? AdaptiveResolutionDirection { get; set; }

            /// <summary>
            /// <para>The number of consecutive B frames. Default value: 3.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("BFrames")]
            [Validation(Required=false)]
            public int? BFrames { get; set; }

            /// <summary>
            /// <para>The bitrate of the video stream. Unit: bit/s.</para>
            /// <remarks>
            /// <para>This parameter and the <b>CRF</b> parameter are mutually exclusive. If you leave both the parameters empty, the <b>CRF</b> parameter with a value of 23 applies.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>128000</para>
            /// </summary>
            [NameInMap("Bitrate")]
            [Validation(Required=false)]
            public int? Bitrate { get; set; }

            /// <summary>
            /// <para>The video bitrate option. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>fixed: always uses the target bitrate.</description></item>
            /// <item><description>adaptive: uses the source bitrate when the source bitrate is less than the target bitrate.</description></item>
            /// <item><description>fall: returns a failure when the source bitrate is less than the target bitrate.</description></item>
            /// </list>
            /// <para>Default value:</para>
            /// <list type="bullet">
            /// <item><description>fixed for the CreateMediaConvert operation.</description></item>
            /// <item><description>adaptive for the GenerateVideoPlaylist operation.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter must be used together with the <b>Bitrate</b> parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>fixed</para>
            /// </summary>
            [NameInMap("BitrateOption")]
            [Validation(Required=false)]
            public string BitrateOption { get; set; }

            /// <summary>
            /// <para>The size of the buffer for decoding when the dynamic bitrate is used. Unit: bit/s.</para>
            /// <remarks>
            /// <para>This parameter must be used together with the <b>CRF</b> parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>4000000</para>
            /// </summary>
            [NameInMap("BufferSize")]
            [Validation(Required=false)]
            public int? BufferSize { get; set; }

            /// <summary>
            /// <para>The constant rate factor (CRF) of the video. The value of this parameter falls within the [0,51] range. A greater indicates lower quality. We recommend that you specify a value within the [18,38] range. This parameter and the <b>Bitrate</b> parameter are mutually exclusive.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18</para>
            /// </summary>
            [NameInMap("CRF")]
            [Validation(Required=false)]
            public float? CRF { get; set; }

            /// <summary>
            /// <para>The video coding format. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>copy, h264, h265, and vp9 for the CreateMediaConvert operation. The default value is copy.</para>
            /// <para>**</para>
            /// <para>**Warning **When you set the parameter to copy, the video stream is directly copied into the output file and all other parameters in TranscodeVideo do not take effect. The copy value is commonly used in container format conversion scenarios. You cannot use this value in video merging scenarios.</para>
            /// </description></item>
            /// <item><description><para>h264 and h265 for the GenerateVideoPlaylist operation. The default value is h264.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>h264</para>
            /// </summary>
            [NameInMap("Codec")]
            [Validation(Required=false)]
            public string Codec { get; set; }

            /// <summary>
            /// <para>The target frame rate. By default, the target frame rate is the same as the source frame rate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>25</para>
            /// </summary>
            [NameInMap("FrameRate")]
            [Validation(Required=false)]
            public float? FrameRate { get; set; }

            /// <summary>
            /// <para>The frame rate option. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>fixed: always uses the target frame rate.</description></item>
            /// <item><description>adaptive: uses the source frame rate when the source frame rate is less than the target frame rate.</description></item>
            /// <item><description>fall: returns a failure if the source frame rate is less than the target frame rate.</description></item>
            /// </list>
            /// <para>Default value:</para>
            /// <list type="bullet">
            /// <item><description>fixed for the CreateMediaConvert operation.</description></item>
            /// <item><description>adaptive for the GenerateVideoPlaylist operation.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter must be used together with the <b>FrameRate</b> parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>fixed</para>
            /// </summary>
            [NameInMap("FrameRateOption")]
            [Validation(Required=false)]
            public string FrameRateOption { get; set; }

            /// <summary>
            /// <para>The keyframe interval. Default value: 150.</para>
            /// <remarks>
            /// <para>This parameter is not available to the GenerateVideoPlaylist operation.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("GOPSize")]
            [Validation(Required=false)]
            public int? GOPSize { get; set; }

            /// <summary>
            /// <para>The maximum bitrate when the dynamic bitrate is used. If you specify this parameter, you must also specify the BufferSize parameter.</para>
            /// <remarks>
            /// <para>This parameter must be used together with the <b>CRF</b> parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>128000</para>
            /// </summary>
            [NameInMap("MaxBitrate")]
            [Validation(Required=false)]
            public int? MaxBitrate { get; set; }

            /// <summary>
            /// <para>The pixel format. By default, the pixel format matches that of the source video. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>yuv420p</description></item>
            /// <item><description>yuv422p</description></item>
            /// <item><description>yuv444p</description></item>
            /// <item><description>yuv420p10le</description></item>
            /// <item><description>yuv422p10le</description></item>
            /// <item><description>yuv444p10le</description></item>
            /// <item><description>yuva420p</description></item>
            /// </list>
            /// <remarks>
            /// <para>You can set the parameter to yuva420p only when you call the CreateMediaConvert operation and set the <b>Codec</b> parameter to vp9.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>yuv420p</para>
            /// </summary>
            [NameInMap("PixelFormat")]
            [Validation(Required=false)]
            public string PixelFormat { get; set; }

            /// <summary>
            /// <para>The number of reference frames. Default value: 2.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Refs")]
            [Validation(Required=false)]
            public int? Refs { get; set; }

            /// <summary>
            /// <para>The target resolution in the <c>WidthxHeight</c> format. By default, the target resolution is the same as the source resolution. You can specify both width and height, or only one of them. You can use this parameter together with the <b>AdaptiveResolutionDirection</b> parameter to set both the long side and short side or one of them. The value of each side falls within the range of (0,4096].</para>
            /// <list type="bullet">
            /// <item><description>Example 1: If <b>AdaptiveResolutionDirection</b> is set to false, <c>1280x720</c> specifies a width of 1280 pixels and a height of 720 pixels, <c>1280x</c> specifies a width of 1280 pixels and the same height as the source video, and <c>x720</c> specifies a height of 720 pixels and the same width as the source video.</description></item>
            /// <item><description>Example 2: If <b>AdaptiveResolutionDirection</b> is set to true, <c>1280x720</c> specifies a long side of 1280 pixels and a short side of 720 pixels, <c>1280x</c> specifies a long side of 1280 pixels and the same short side as the source video, and <c>x720</c> specifies a short side of 720 pixels and the same long side as the source video.</description></item>
            /// </list>
            /// <remarks>
            /// <para>If the source video contains rotation information, the width, height, long side, and short side depend on the frame after rotation (the playback resolution).</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>640x480</para>
            /// </summary>
            [NameInMap("Resolution")]
            [Validation(Required=false)]
            public string Resolution { get; set; }

            /// <summary>
            /// <para>The resolution option. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>fixed: always uses the target video resolution.</description></item>
            /// <item><description>adaptive: uses the source video resolution when the source video resolution is less than the target video resolution.</description></item>
            /// <item><description>fall: returns a failure when the source video resolution is less than the target video resolution.</description></item>
            /// </list>
            /// <para>Default value:</para>
            /// <list type="bullet">
            /// <item><description>fixed for the CreateMediaConvert operation.</description></item>
            /// <item><description>adaptive for the GenerateVideoPlaylist operation.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter must be used together with the <b>Resolution</b> parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>fixed</para>
            /// </summary>
            [NameInMap("ResolutionOption")]
            [Validation(Required=false)]
            public string ResolutionOption { get; set; }

            /// <summary>
            /// <para>The degrees to rotate the video clockwise. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0 (default)</description></item>
            /// <item><description>90</description></item>
            /// <item><description>180</description></item>
            /// <item><description>270</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("Rotation")]
            [Validation(Required=false)]
            public int? Rotation { get; set; }

            /// <summary>
            /// <para>The resizing mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>stretch: forcibly stretches the video based on the specified width and height or long side and short side to fill any remaining space. This is the default value.</description></item>
            /// <item><description>crop: proportionally resizes the video to the minimum resolution outside the rectangular shape based on the specified width and height or long side and short side, and crops the parts beyond the rectangular shape from the center.</description></item>
            /// <item><description>fill: proportionally resizes the video to the maximum resolution within the rectangular shape based on the specified width and height or long side and short side, and fills empty space with black from the center.</description></item>
            /// <item><description>fit: proportionally resizes the video to the maximum resolution that fits within the specified width and height or long side and short side.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter must be used together with the <b>Resolution</b> parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>crop</para>
            /// </summary>
            [NameInMap("ScaleType")]
            [Validation(Required=false)]
            public string ScaleType { get; set; }

            [NameInMap("VideoSlim")]
            [Validation(Required=false)]
            public int? VideoSlim { get; set; }

        }

    }

}
