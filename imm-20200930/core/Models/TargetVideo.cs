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
        /// <item><description><para>true: Disables video stream generation. The output file will not contain a video stream.</para>
        /// </description></item>
        /// <item><description><para>false (default): Enables video stream generation.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DisableVideo")]
        [Validation(Required=false)]
        public bool? DisableVideo { get; set; }

        /// <summary>
        /// <para>The video processing parameters. This parameter is invalid if <b>TranscodeVideo</b> is empty or if <b>TranscodeVideo.Codec</b> is set to copy.</para>
        /// <remarks>
        /// <para>You cannot set this parameter for the GenerateVideoPlaylist API.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("FilterVideo")]
        [Validation(Required=false)]
        public TargetVideoFilterVideo FilterVideo { get; set; }
        public class TargetVideoFilterVideo : TeaModel {
            /// <summary>
            /// <para>Blurs a rectangular area of the video to remove logos, station icons, and other elements.</para>
            /// </summary>
            [NameInMap("Delogos")]
            [Validation(Required=false)]
            public List<TargetVideoFilterVideoDelogos> Delogos { get; set; }
            public class TargetVideoFilterVideoDelogos : TeaModel {
                /// <summary>
                /// <para>The duration for which the mosaic is displayed, in seconds (s). By default, the mosaic is displayed until the end of the video.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public double? Duration { get; set; }

                /// <summary>
                /// <para>The meaning of this parameter varies depending on whether the value is an integer or a decimal:</para>
                /// <list type="bullet">
                /// <item><description><para>0 (default): The pixel offset is 0. The ratio of the horizontal offset to the output video width is also 0.</para>
                /// </description></item>
                /// <item><description><para>Integer: The offset in pixels (px). The value ranges from 1 to 4096.</para>
                /// </description></item>
                /// <item><description><para>Decimal: The ratio of the horizontal offset to the output video width. The value ranges from (0, 1).</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Dx")]
                [Validation(Required=false)]
                public float? Dx { get; set; }

                /// <summary>
                /// <para>The default value is 0. The meaning of this parameter varies depending on whether the value is an integer or a decimal:</para>
                /// <list type="bullet">
                /// <item><description><para>0 (default): The pixel offset is 0. The ratio of the vertical offset to the output video height is also 0.</para>
                /// </description></item>
                /// <item><description><para>Integer: The offset in pixels (px). The value ranges from 1 to 4096.</para>
                /// </description></item>
                /// <item><description><para>Decimal: The ratio of the vertical offset to the output video height. The value ranges from (0, 1).</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Dy")]
                [Validation(Required=false)]
                public float? Dy { get; set; }

                /// <summary>
                /// <para>The height of the mosaic. The default value is the decimal 1.0, which means it fills the entire height of the output video. The meaning of this parameter varies depending on whether the value is an integer or a decimal:</para>
                /// <list type="bullet">
                /// <item><description><para>Integer: The height in pixels (px). The value ranges from 1 to 4096.</para>
                /// </description></item>
                /// <item><description><para>Decimal: The ratio of the mosaic height to the output video height. The value ranges from (0, 1).</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>40</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public float? Height { get; set; }

                /// <summary>
                /// <para>The reference position for adding the mosaic. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>topleft (default): The top-left corner.</para>
                /// </description></item>
                /// <item><description><para>topright: The top-right corner.</para>
                /// </description></item>
                /// <item><description><para>bottomright: The bottom-right corner.</para>
                /// </description></item>
                /// <item><description><para>bottomleft: The bottom-left corner.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>topleft</para>
                /// </summary>
                [NameInMap("ReferPos")]
                [Validation(Required=false)]
                public string ReferPos { get; set; }

                /// <summary>
                /// <para>The start time for adding the mosaic, in seconds (s). By default, the mosaic is added from the beginning of the video.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public double? StartTime { get; set; }

                /// <summary>
                /// <para>The width of the mosaic. The default value is the decimal 1.0, which means it fills the entire width of the output video. The meaning of this parameter varies depending on whether the value is an integer or a decimal:</para>
                /// <list type="bullet">
                /// <item><description><para>Integer: The width in pixels (px). The value ranges from 1 to 4096.</para>
                /// </description></item>
                /// <item><description><para>Decimal: The ratio of the mosaic width to the output video width. The value ranges from (0, 1).</para>
                /// </description></item>
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
            /// <para>The video desensitization configuration.</para>
            /// <remarks>
            /// <para>Notice: </para>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>This parameter applies only to the CreateMediaConvertTask API.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("Desensitization")]
            [Validation(Required=false)]
            public TargetVideoFilterVideoDesensitization Desensitization { get; set; }
            public class TargetVideoFilterVideoDesensitization : TeaModel {
                /// <summary>
                /// <para>The facial desensitization configuration.</para>
                /// <remarks>
                /// <para>This feature is in public preview. If you have any questions, join the DingTalk group for feedback. For the DingTalk group number, see <a href="https://help.aliyun.com/document_detail/84454.html">Contact us</a>.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("Face")]
                [Validation(Required=false)]
                public TargetVideoFilterVideoDesensitizationFace Face { get; set; }
                public class TargetVideoFilterVideoDesensitizationFace : TeaModel {
                    /// <summary>
                    /// <para>The confidence threshold for facial recognition. This sets the lower limit for the confidence level. If the confidence level of a detected face is below this threshold, the face is not desensitized.</para>
                    /// <list type="bullet">
                    /// <item><description><para>Value range: 0.0 to 1.0.</para>
                    /// </description></item>
                    /// <item><description><para>Default value: 0.0 (no confidence filtering).</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.4</para>
                    /// </summary>
                    [NameInMap("Confidence")]
                    [Validation(Required=false)]
                    public float? Confidence { get; set; }

                    /// <summary>
                    /// <para>The minimum face size threshold. This sets the minimum size for a face to be desensitized. If the width or height of a detected face is smaller than this threshold, the face is not desensitized. The unit is pixels. The default value is 0, which means there is no restriction on face size.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.4</para>
                    /// </summary>
                    [NameInMap("MinSize")]
                    [Validation(Required=false)]
                    public int? MinSize { get; set; }

                }

                /// <summary>
                /// <para>The license plate desensitization configuration.</para>
                /// <remarks>
                /// <para>This feature is in public preview. If you have any questions, join the DingTalk group for feedback. For the DingTalk group number, see <a href="https://help.aliyun.com/document_detail/84454.html">Contact us</a>.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("LicensePlate")]
                [Validation(Required=false)]
                public TargetVideoFilterVideoDesensitizationLicensePlate LicensePlate { get; set; }
                public class TargetVideoFilterVideoDesensitizationLicensePlate : TeaModel {
                    /// <summary>
                    /// <para>The confidence threshold for license plate recognition. This sets the lower limit for the confidence level. If the confidence level of a detected license plate is below this threshold, the license plate is not desensitized.</para>
                    /// <list type="bullet">
                    /// <item><description><para>Value range: 0.0 to 1.0.</para>
                    /// </description></item>
                    /// <item><description><para>Default value: 0.0 (no confidence filtering).</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.4</para>
                    /// </summary>
                    [NameInMap("Confidence")]
                    [Validation(Required=false)]
                    public float? Confidence { get; set; }

                    /// <summary>
                    /// <para>The minimum license plate size threshold. This sets the minimum size for a license plate to be desensitized. If the width or height of a detected license plate is smaller than this threshold, the license plate is not desensitized. The unit is pixels. The default value is 0, which means there is no restriction on license plate size.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.4</para>
                    /// </summary>
                    [NameInMap("MinSize")]
                    [Validation(Required=false)]
                    public int? MinSize { get; set; }

                }

            }

            /// <summary>
            /// <para>The video playback speed setting. The value ranges from 0.5 to 1.0. The default value is 1.0.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>This is the ratio of the default playback speed of the transcoded media file to that of the source media file. This is not a high-speed transcoding feature.</description></item>
            /// </list>
            /// </remarks>
            /// <remarks>
            /// <para>Notice: </para>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>This parameter applies only to the CreateMediaConvertTask API.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("Speed")]
            [Validation(Required=false)]
            public float? Speed { get; set; }

            /// <summary>
            /// <para>A list of video watermarks.</para>
            /// </summary>
            [NameInMap("Watermarks")]
            [Validation(Required=false)]
            public List<TargetVideoFilterVideoWatermarks> Watermarks { get; set; }
            public class TargetVideoFilterVideoWatermarks : TeaModel {
                /// <summary>
                /// <para>The outline color of the watermark text. The format is #RRGGBB. The default value is #000000. You can also enter values such as &quot;red&quot; or &quot;green&quot;.</para>
                /// <remarks>
                /// <para>Notice: </para>
                /// </remarks>
                /// <para>This parameter is effective only when the <c>Type</c> parameter is set to <c>text</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>red</para>
                /// </summary>
                [NameInMap("BorderColor")]
                [Validation(Required=false)]
                public string BorderColor { get; set; }

                /// <summary>
                /// <para>The outline width for the text watermark, in pixels (px). The value must be an integer from 0 to 4096. The default value is 0.</para>
                /// <remarks>
                /// <para>Notice: </para>
                /// </remarks>
                /// <para>This parameter is effective only when the <c>Type</c> parameter is set to <c>text</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("BorderWidth")]
                [Validation(Required=false)]
                public int? BorderWidth { get; set; }

                /// <summary>
                /// <para>The content of the text watermark. The default value is empty.</para>
                /// <remarks>
                /// <para>Notice: </para>
                /// </remarks>
                /// <para>This parameter is effective only when the <c>Type</c> parameter is set to <c>text</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The duration for which the watermark is displayed, in seconds (s). By default, the watermark is displayed until the end of the video.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public double? Duration { get; set; }

                /// <summary>
                /// <para>The meaning of this parameter varies depending on whether the value is an integer or a decimal:</para>
                /// <list type="bullet">
                /// <item><description><para>0 (default): The pixel offset is 0. The ratio of the horizontal offset to the output video width is also 0.</para>
                /// </description></item>
                /// <item><description><para>Integer: The offset in pixels (px). The value ranges from 1 to 4096.</para>
                /// </description></item>
                /// <item><description><para>Decimal: The ratio of the horizontal offset to the output video width. The value ranges from (0, 1).</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Dx")]
                [Validation(Required=false)]
                public float? Dx { get; set; }

                /// <summary>
                /// <para>The meaning of this parameter varies depending on whether the value is an integer or a decimal:</para>
                /// <list type="bullet">
                /// <item><description><para>0 (default): The pixel offset is 0. The ratio of the vertical offset to the output video height is also 0.</para>
                /// </description></item>
                /// <item><description><para>Integer: The offset in pixels (px). The value ranges from 1 to 4096.</para>
                /// </description></item>
                /// <item><description><para>Decimal: The ratio of the vertical offset to the output video height. The value ranges from (0, 1).</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Dy")]
                [Validation(Required=false)]
                public float? Dy { get; set; }

                /// <summary>
                /// <para>The font opacity of the text watermark. The value ranges from (0, 1]. The default value is 1, which means fully opaque.</para>
                /// <remarks>
                /// <para>Notice: </para>
                /// </remarks>
                /// <para>This parameter is effective only when the <c>Type</c> parameter is set to <c>text</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.8</para>
                /// </summary>
                [NameInMap("FontApha")]
                [Validation(Required=false)]
                public float? FontApha { get; set; }

                /// <summary>
                /// <para>The font color of the watermark text. The format is #RRGGBB. The default value is #000000. You can also enter values such as &quot;red&quot; or &quot;green&quot;.</para>
                /// <remarks>
                /// <para>Notice: </para>
                /// </remarks>
                /// <para>This parameter is effective only when the <c>Type</c> parameter is set to <c>text</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>red</para>
                /// </summary>
                [NameInMap("FontColor")]
                [Validation(Required=false)]
                public string FontColor { get; set; }

                /// <summary>
                /// <para>The font name for the text watermark. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>SourceHanSans-Regular (default)</para>
                /// </description></item>
                /// <item><description><para>SourceHanSans-Bold</para>
                /// </description></item>
                /// <item><description><para>SourceHanSerif-Regular</para>
                /// </description></item>
                /// <item><description><para>SourceHanSerif-Bold</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>Notice: </para>
                /// </remarks>
                /// <para>This parameter is effective only when the <c>Type</c> parameter is set to <c>text</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SourceHanSans-Bold</para>
                /// </summary>
                [NameInMap("FontName")]
                [Validation(Required=false)]
                public string FontName { get; set; }

                /// <summary>
                /// <para>The font size for the text watermark. The default value is 16. The value must be an integer in the range (4, 120).</para>
                /// <remarks>
                /// <para>Notice: </para>
                /// </remarks>
                /// <para>This parameter is effective only when the <c>Type</c> parameter is set to <c>text</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>18</para>
                /// </summary>
                [NameInMap("FontSize")]
                [Validation(Required=false)]
                public int? FontSize { get; set; }

                /// <summary>
                /// <para>The height of the watermark image. By default, this is the height of the original watermark image. The meaning of this parameter varies depending on whether the value is an integer or a decimal:</para>
                /// <list type="bullet">
                /// <item><description><para>Integer: The height of the watermark in pixels (px). The value ranges from 1 to 4096.</para>
                /// </description></item>
                /// <item><description><para>Decimal: The ratio of the watermark height to the output video height. The value ranges from (0, 1).</para>
                /// </description></item>
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
                /// <item><description><para>topleft (default): The top-left corner.</para>
                /// </description></item>
                /// <item><description><para>topright: The top-right corner.</para>
                /// </description></item>
                /// <item><description><para>bottomright: The bottom-right corner.</para>
                /// </description></item>
                /// <item><description><para>bottomleft: The bottom-left corner.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>topleft</para>
                /// </summary>
                [NameInMap("ReferPos")]
                [Validation(Required=false)]
                public string ReferPos { get; set; }

                /// <summary>
                /// <para>The start time for adding the watermark, in seconds (s). By default, the watermark is added from the beginning of the video.</para>
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
                /// <item><description><para>text (default): A text watermark.</para>
                /// </description></item>
                /// <item><description><para>file: An image or animated image watermark.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The OSS URL of the watermark file. Supported formats are PNG and MOV.</para>
                /// <para>The OSS URL must follow the format <c>oss://&lt;bucket&gt;/&lt;object&gt;</c>, where <c>&lt;bucket&gt;</c> is the name of an OSS bucket in the same region as the current project, and <c>&lt;object&gt;</c> is the full path of the file, including the file name extension.</para>
                /// <remarks>
                /// <para>Notice: </para>
                /// </remarks>
                /// <para>This parameter is effective only when the <c>Type</c> parameter is set to <c>file</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss://test-bucket/watermark.jpg</para>
                /// </summary>
                [NameInMap("URI")]
                [Validation(Required=false)]
                public string URI { get; set; }

                /// <summary>
                /// <para>The width of the watermark image. By default, this is the width of the original watermark image. The meaning of this parameter varies depending on whether the value is an integer or a decimal:</para>
                /// <list type="bullet">
                /// <item><description><para>Integer: The width of the watermark in pixels (px). The value ranges from 1 to 4096.</para>
                /// </description></item>
                /// <item><description><para>Decimal: The ratio of the watermark width to the output video width. The value ranges from (0, 1).</para>
                /// </description></item>
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
        /// <para>A list of index numbers for the source video streams to process. If you leave this parameter empty (default), the system processes the video stream with the smallest index number (the first video stream). If you set the index number to a value greater than 100, the system processes all video streams.</para>
        /// <list type="bullet">
        /// <item><description>Example: <c>[0,1]</c> processes video streams with index numbers 0 and 1. <c>[1]</c> processes the video stream with index number 1. <c>[101]</c> processes all video streams.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The system only processes video streams with existing index numbers. If a video stream corresponding to an index number does not exist, the system ignores that index number.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Stream")]
        [Validation(Required=false)]
        public List<int?> Stream { get; set; }

        /// <summary>
        /// <para>The video transcoding parameters. An empty value disables video processing. The output file will not contain a video stream.</para>
        /// <remarks>
        /// <para>Do not disable video processing by leaving this parameter empty.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("TranscodeVideo")]
        [Validation(Required=false)]
        public TargetVideoTranscodeVideo TranscodeVideo { get; set; }
        public class TargetVideoTranscodeVideo : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable adaptive resolution for long and short edges. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Yes. In this case, the format for the <b>Resolution</b> parameter is <c>long edge × short edge</c>.</para>
            /// </description></item>
            /// <item><description><para>false (default): No. In this case, the format for the <b>Resolution</b> parameter is <c>width × height</c>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AdaptiveResolutionDirection")]
            [Validation(Required=false)]
            public bool? AdaptiveResolutionDirection { get; set; }

            /// <summary>
            /// <para>The number of consecutive B-frames. The default value is 3.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("BFrames")]
            [Validation(Required=false)]
            public int? BFrames { get; set; }

            /// <summary>
            /// <para>The video stream bitrate in bits per second (bit/s).</para>
            /// <remarks>
            /// <para>This parameter is mutually exclusive with <b>CRF</b>. If both this parameter and the <b>CRF</b> parameter are empty, the system encodes the video with a CRF value of 23.</para>
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
            /// <item><description><para>fixed: Always uses the specified target video bitrate.</para>
            /// </description></item>
            /// <item><description><para>adaptive: Uses the source video bitrate if it is lower than the specified target video bitrate.</para>
            /// </description></item>
            /// <item><description><para>fall: The task fails if the source video bitrate is lower than the specified target video bitrate.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value:</para>
            /// <list type="bullet">
            /// <item><description><para>For the CreateMediaConvert API, the default value is fixed.</para>
            /// </description></item>
            /// <item><description><para>For the GenerateVideoPlaylist API, the default value is adaptive.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter must be set together with the <b>Bitrate</b> parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>fixed</para>
            /// </summary>
            [NameInMap("BitrateOption")]
            [Validation(Required=false)]
            public string BitrateOption { get; set; }

            /// <summary>
            /// <para>The size of the decoding buffer for dynamic bitrate, in bits per second (bps).</para>
            /// <remarks>
            /// <para>This parameter is effective only when used with the <b>CRF</b> parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>4000000</para>
            /// </summary>
            [NameInMap("BufferSize")]
            [Validation(Required=false)]
            public int? BufferSize { get; set; }

            /// <summary>
            /// <para>Specifies the Constant Rate Factor (CRF) mode. This parameter is mutually exclusive with <b>Bitrate</b>. The value ranges from 0 to 51. A larger value indicates lower image quality. A value from 18 to 38 is recommended.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18</para>
            /// </summary>
            [NameInMap("CRF")]
            [Validation(Required=false)]
            public float? CRF { get; set; }

            /// <summary>
            /// <para>The video encoding format. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>For the CreateMediaConvert API: copy (default), h264, h265, and vp9.</para>
            /// <remarks>
            /// <para>Warning: </para>
            /// </remarks>
            /// <para>If you set this parameter to copy, the system directly copies the video stream to the output file. In this case, the other parameters under <b>TranscodeVideo</b> are invalid. The copy value cannot be used for video concatenation and is typically used for container format conversion.</para>
            /// </description></item>
            /// <item><description><para>For the GenerateVideoPlaylist API: h264 (default) and h265.</para>
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
            /// <para>The video frame rate. By default, this is the same as the source video.</para>
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
            /// <item><description><para>fixed: Always uses the specified target video frame rate.</para>
            /// </description></item>
            /// <item><description><para>adaptive: Uses the source video frame rate if it is lower than the specified target video frame rate.</para>
            /// </description></item>
            /// <item><description><para>fall: The task fails if the source video frame rate is lower than the specified target video frame rate.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value:</para>
            /// <list type="bullet">
            /// <item><description><para>For the CreateMediaConvert API, the default value is fixed.</para>
            /// </description></item>
            /// <item><description><para>For the GenerateVideoPlaylist API, the default value is adaptive.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter must be set together with the <b>FrameRate</b> parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>fixed</para>
            /// </summary>
            [NameInMap("FrameRateOption")]
            [Validation(Required=false)]
            public string FrameRateOption { get; set; }

            /// <summary>
            /// <para>The size of the Group of Pictures (GOP) in frames. The default value is 150.</para>
            /// <remarks>
            /// <para>This parameter is not supported by the GenerateVideoPlaylist API.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("GOPSize")]
            [Validation(Required=false)]
            public int? GOPSize { get; set; }

            /// <summary>
            /// <para>The maximum bitrate limit for dynamic bitrate. When you use this parameter, you must also specify the BufferSize parameter.</para>
            /// <remarks>
            /// <para>This parameter is effective only when used with the <b>CRF</b> parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>128000</para>
            /// </summary>
            [NameInMap("MaxBitrate")]
            [Validation(Required=false)]
            public int? MaxBitrate { get; set; }

            /// <summary>
            /// <para>The pixel format. By default, this is the same as the source video. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>yuv420p</para>
            /// </description></item>
            /// <item><description><para>yuv422p</para>
            /// </description></item>
            /// <item><description><para>yuv444p</para>
            /// </description></item>
            /// <item><description><para>yuv420p10le</para>
            /// </description></item>
            /// <item><description><para>yuv422p10le</para>
            /// </description></item>
            /// <item><description><para>yuv444p10le</para>
            /// </description></item>
            /// <item><description><para>yuva420p</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>The yuva420p value is available only for the CreateMediaConvert API, and the <b>Codec</b> parameter must be set to vp9.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>yuv420p</para>
            /// </summary>
            [NameInMap("PixelFormat")]
            [Validation(Required=false)]
            public string PixelFormat { get; set; }

            /// <summary>
            /// <para>The number of reference frames. The default value is 2.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Refs")]
            [Validation(Required=false)]
            public int? Refs { get; set; }

            /// <summary>
            /// <para>The resolution of the output video in the format of <c>width × height</c>. By default, this is the same as the playback resolution of the source video. You can configure both width and height, or only width or height. You can also use this parameter with the <b>AdaptiveResolutionDirection</b> parameter to configure both the long and short edges, or only the long or short edge. The value for a single edge ranges from (0, 4096].</para>
            /// <list type="bullet">
            /// <item><description><para>Example 1: If <b>AdaptiveResolutionDirection</b> is set to false, <c>1280x720</c> sets the width to 1280 and the height to 720. <c>1280x</c> sets the width to 1280 and keeps the height the same as the source video. <c>x720</c> sets the height to 720 and keeps the width the same as the source video.</para>
            /// </description></item>
            /// <item><description><para>Example 2: If <b>AdaptiveResolutionDirection</b> is set to true, <c>1280x720</c> sets the long edge to 1280 and the short edge to 720. <c>1280x</c> sets the long edge to 1280 and keeps the short edge the same as the source video. <c>x720</c> sets the short edge to 720 and keeps the long edge the same as the source video.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>If the source video contains rotation information, the width, height, long edge, and short edge are determined based on the rotated video, which means the playback resolution is used.</para>
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
            /// <item><description><para>fixed: Always uses the specified target video resolution.</para>
            /// </description></item>
            /// <item><description><para>adaptive: Uses the source video resolution if its area is smaller than the area of the specified target video resolution.</para>
            /// </description></item>
            /// <item><description><para>fall: The task fails if the area of the source video resolution is smaller than the area of the specified target video resolution.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value:</para>
            /// <list type="bullet">
            /// <item><description><para>For the CreateMediaConvert API, the default value is fixed.</para>
            /// </description></item>
            /// <item><description><para>For the GenerateVideoPlaylist API, the default value is adaptive.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter must be set together with the <b>Resolution</b> parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>fixed</para>
            /// </summary>
            [NameInMap("ResolutionOption")]
            [Validation(Required=false)]
            public string ResolutionOption { get; set; }

            /// <summary>
            /// <para>The clockwise rotation angle of the video in degrees. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>0 (default)</para>
            /// </description></item>
            /// <item><description><para>90</para>
            /// </description></item>
            /// <item><description><para>180</para>
            /// </description></item>
            /// <item><description><para>270</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("Rotation")]
            [Validation(Required=false)]
            public int? Rotation { get; set; }

            /// <summary>
            /// <para>The scaling mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>stretch (default): Fixes the width and height or the long and short edges, and forces scaling to stretch and fill any blank areas.</para>
            /// </description></item>
            /// <item><description><para>crop: Scales the video proportionally to the minimum resolution that extends beyond the specified rectangle (defined by width/height or long/short edges), and then center-crops the excess parts.</para>
            /// </description></item>
            /// <item><description><para>fill: Scales the video proportionally to the maximum resolution that fits within the specified rectangle (defined by width/height or long/short edges), and then center-fills any blank areas with black.</para>
            /// </description></item>
            /// <item><description><para>fit: Scales the video proportionally to the maximum resolution that fits within the specified rectangle (defined by width/height or long/short edges).</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter must be set together with the <b>Resolution</b> parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>crop</para>
            /// </summary>
            [NameInMap("ScaleType")]
            [Validation(Required=false)]
            public string ScaleType { get; set; }

            /// <summary>
            /// <para>Enables the Narrowband HD mode. Set the value as follows:</para>
            /// <para>0: The default value. Disables the mode.</para>
            /// <para>1: Enables transcoding in Narrowband HD mode.</para>
            /// <remarks>
            /// <para>For best results, use the officially recommended Bitrate or CRF parameters for video transcoding and encoding in Narrowband HD mode.</para>
            /// </remarks>
            /// <remarks>
            /// <para>Notice: </para>
            /// </remarks>
            /// <para>Narrowband HD only supports the h.264/h.265 format, yuv420p, and an 8-bit depth. It does not support transcoding output for multiple target videos or video concatenation. For more information, see <a href="https://help.aliyun.com/document_detail/2984556.html">Introduction to Narrowband HD</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("VideoSlim")]
            [Validation(Required=false)]
            public int? VideoSlim { get; set; }

        }

    }

}
