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
        /// <item><description>true: Disabled. The output file does not contain a video stream.</description></item>
        /// <item><description>false (default): Not disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DisableVideo")]
        [Validation(Required=false)]
        public bool? DisableVideo { get; set; }

        /// <summary>
        /// <para>The video processing parameters. This parameter does not take effect when the <b>TranscodeVideo</b> parameter is empty or when <b>TranscodeVideo.Codec</b> is set to copy.</para>
        /// <remarks>
        /// <para>This parameter is not supported for the GenerateVideoPlaylist API.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("FilterVideo")]
        [Validation(Required=false)]
        public TargetVideoFilterVideo FilterVideo { get; set; }
        public class TargetVideoFilterVideo : TeaModel {
            /// <summary>
            /// <para>Blurs a rectangular area of the video to remove logos, station marks, and similar elements.</para>
            /// </summary>
            [NameInMap("Delogos")]
            [Validation(Required=false)]
            public List<TargetVideoFilterVideoDelogos> Delogos { get; set; }
            public class TargetVideoFilterVideoDelogos : TeaModel {
                /// <summary>
                /// <para>The duration for which the mosaic is applied, in seconds (s). The default value is until the end of the video.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public double? Duration { get; set; }

                /// <summary>
                /// <para>The meanings differ depending on whether the value is an integer or decimal:</para>
                /// <list type="bullet">
                /// <item><description>0 (default): Both the offset in pixels and the ratio of horizontal offset to output resolution height are 0.</description></item>
                /// <item><description>Integer: The offset in pixels (px). Value range: [1,4096].</description></item>
                /// <item><description>Decimal: The ratio of horizontal offset to output resolution height. Value range: (0,1).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Dx")]
                [Validation(Required=false)]
                public float? Dx { get; set; }

                /// <summary>
                /// <para>Default value: 0. The meanings differ depending on whether the value is an integer or decimal:</para>
                /// <list type="bullet">
                /// <item><description>0 (default): Both the offset in pixels and the ratio of vertical offset to output resolution height are 0.</description></item>
                /// <item><description>Integer: The offset in pixels (px). Value range: [1,4096].</description></item>
                /// <item><description>Decimal: The ratio of vertical offset to output resolution height. Value range: (0,1).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Dy")]
                [Validation(Required=false)]
                public float? Dy { get; set; }

                /// <summary>
                /// <para>The height of the mosaic. The default value is the decimal 1.0, which fills the entire output video height. The meanings differ depending on whether the value is an integer or decimal:</para>
                /// <list type="bullet">
                /// <item><description>Integer: The pixel value, in pixels (px). Value range: [1,4096].</description></item>
                /// <item><description>Decimal: The ratio relative to the output video resolution height. Value range: (0,1).</description></item>
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
                /// <item><description>topleft (default): top-left corner</description></item>
                /// <item><description>topright: top-right corner</description></item>
                /// <item><description>bottomright: bottom-right corner</description></item>
                /// <item><description>bottomleft: bottom-left corner</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>topleft</para>
                /// </summary>
                [NameInMap("ReferPos")]
                [Validation(Required=false)]
                public string ReferPos { get; set; }

                /// <summary>
                /// <para>The start time for adding the mosaic, in seconds (s). The default value is the start time of the video.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public double? StartTime { get; set; }

                /// <summary>
                /// <para>The width of the mosaic. The default value is the decimal 1.0, which fills the entire output video width. The meanings differ depending on whether the value is an integer or decimal:</para>
                /// <list type="bullet">
                /// <item><description>Integer: The pixel value, in pixels (px). Value range: [1,4096].</description></item>
                /// <item><description>Decimal: The ratio relative to the output video resolution width. Value range: (0,1).</description></item>
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
            /// <item><description>This parameter is applicable only to the CreateMediaConvertTask API.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("Desensitization")]
            [Validation(Required=false)]
            public TargetVideoFilterVideoDesensitization Desensitization { get; set; }
            public class TargetVideoFilterVideoDesensitization : TeaModel {
                /// <summary>
                /// <para>The face desensitization configuration.</para>
                /// <remarks>
                /// <para>This feature is in public preview. If you have any questions, join the DingTalk group for feedback. For the DingTalk group number, see <a href="https://help.aliyun.com/document_detail/84454.html">Contact us</a>.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("Face")]
                [Validation(Required=false)]
                public TargetVideoFilterVideoDesensitizationFace Face { get; set; }
                public class TargetVideoFilterVideoDesensitizationFace : TeaModel {
                    /// <summary>
                    /// <para>The blur radius. Value range: 1 to 100. A larger value typically results in a more blurred area.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("BlurRadius")]
                    [Validation(Required=false)]
                    public int? BlurRadius { get; set; }

                    /// <summary>
                    /// <para>The face confidence threshold, which sets the lower limit of confidence for face recognition. If the confidence value of a detected face is lower than this threshold, the face is not desensitized.</para>
                    /// <list type="bullet">
                    /// <item><description>Value range: 0.0 to 1.0.</description></item>
                    /// <item><description>Default value: 0.0 (no confidence filtering is performed).</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.4</para>
                    /// </summary>
                    [NameInMap("Confidence")]
                    [Validation(Required=false)]
                    public float? Confidence { get; set; }

                    /// <summary>
                    /// <para>The minimum face size threshold, which sets the minimum size of faces to be desensitized. If the width or height of a detected face is smaller than this threshold, the face is not desensitized. Unit: pixels. Default value: 0, which indicates no restriction on face size.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.4</para>
                    /// </summary>
                    [NameInMap("MinSize")]
                    [Validation(Required=false)]
                    public int? MinSize { get; set; }

                    /// <summary>
                    /// <para>The detection box scaling ratio. Value range: 0.1 to 5.0. Scales both the width and height of the detection box based on its center.
                    /// • &gt; 1.0: Enlarges the blur area.
                    /// • &lt; 1.0: Reduces the blur area.
                    /// • = 1.0: Uses the original detection box.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.0</para>
                    /// </summary>
                    [NameInMap("ScaleRatio")]
                    [Validation(Required=false)]
                    public float? ScaleRatio { get; set; }

                    /// <summary>
                    /// <para>The transparency and edge feathering intensity of the blur area. Value range: 0.0 to 1.0.
                    /// • 0.0: Displays the full blur effect.
                    /// • 1.0: No blur processing is performed. Only the original image is displayed.
                    /// • 0.0 to 1.0: A larger value results in a higher proportion of the original image, a smaller actual blur radius, and typically a larger edge feathering range.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.0</para>
                    /// </summary>
                    [NameInMap("Transparency")]
                    [Validation(Required=false)]
                    public float? Transparency { get; set; }

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
                    /// <para>The blur radius. Value range: 1 to 100. A larger value typically results in a more blurred area.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("BlurRadius")]
                    [Validation(Required=false)]
                    public int? BlurRadius { get; set; }

                    /// <summary>
                    /// <para>The license plate confidence threshold, which sets the lower limit of confidence for license plate recognition. If the confidence value of a detected license plate is lower than this threshold, the license plate is not desensitized.</para>
                    /// <list type="bullet">
                    /// <item><description>Value range: 0.0 to 1.0.</description></item>
                    /// <item><description>Default value: 0.0 (no confidence filtering is performed).</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.4</para>
                    /// </summary>
                    [NameInMap("Confidence")]
                    [Validation(Required=false)]
                    public float? Confidence { get; set; }

                    /// <summary>
                    /// <para>The minimum license plate size threshold, which sets the minimum size of license plates to be desensitized. If the width or height of a detected license plate is smaller than this threshold, the license plate is not desensitized. Unit: pixels. Default value: 0, which indicates no restriction on license plate size.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.4</para>
                    /// </summary>
                    [NameInMap("MinSize")]
                    [Validation(Required=false)]
                    public int? MinSize { get; set; }

                    /// <summary>
                    /// <para>The detection box scaling ratio. Value range: 0.1 to 5.0. Scales both the width and height of the detection box based on its center.
                    /// • &gt; 1.0: Enlarges the blur area.
                    /// • &lt; 1.0: Reduces the blur area.
                    /// • = 1.0: Uses the original detection box.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.0</para>
                    /// </summary>
                    [NameInMap("ScaleRatio")]
                    [Validation(Required=false)]
                    public float? ScaleRatio { get; set; }

                    /// <summary>
                    /// <para>The transparency and edge feathering intensity of the blur area. Value range: 0.0 to 1.0.
                    /// • 0.0: Displays the full blur effect.
                    /// • 1.0: No blur processing is performed. Only the original image is displayed.
                    /// • 0.0 to 1.0: A larger value results in a higher proportion of the original image, a smaller actual blur radius, and typically a larger edge feathering range.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.0</para>
                    /// </summary>
                    [NameInMap("Transparency")]
                    [Validation(Required=false)]
                    public float? Transparency { get; set; }

                }

            }

            /// <summary>
            /// <para>The video playback speed setting. Value range: [0.5,1.0]. Default value: 1.0.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>This is the ratio of the transcoded media file playback speed to the source media file default playback speed, not speed-up transcoding.</description></item>
            /// </list>
            /// </remarks>
            /// <remarks>
            /// <para>Notice: </para>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>This parameter is applicable only to the CreateMediaConvertTask API.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("Speed")]
            [Validation(Required=false)]
            public float? Speed { get; set; }

            /// <summary>
            /// <para>The list of video watermarks.</para>
            /// </summary>
            [NameInMap("Watermarks")]
            [Validation(Required=false)]
            public List<TargetVideoFilterVideoWatermarks> Watermarks { get; set; }
            public class TargetVideoFilterVideoWatermarks : TeaModel {
                /// <summary>
                /// <para>The border color of the watermark text. The format is #RRGGBB. Default value: #000000. Values such as &quot;red&quot; and &quot;green&quot; are also supported.</para>
                /// <remarks>
                /// <para>Notice:  This parameter takes effect when the <c>Type</c> parameter is set to <c>text</c>.</notice></para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>red</para>
                /// </summary>
                [NameInMap("BorderColor")]
                [Validation(Required=false)]
                public string BorderColor { get; set; }

                /// <summary>
                /// <para>The border width of the text watermark, in pixels (px). The value must be an integer. Value range: [0,4096]. Default value: 0.</para>
                /// <remarks>
                /// <para>Notice:  This parameter takes effect when the <c>Type</c> parameter is set to <c>text</c>.</notice></para>
                /// </remarks>
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
                /// <para>Notice:  This parameter takes effect when the <c>Type</c> parameter is set to <c>text</c>.</notice></para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>example</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The duration for which the watermark is displayed, in seconds (s). The default value is until the end of the video.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public double? Duration { get; set; }

                /// <summary>
                /// <para>The meanings differ depending on whether the value is an integer or decimal:</para>
                /// <list type="bullet">
                /// <item><description>0 (default): Both the offset in pixels and the ratio of horizontal offset to output resolution height are 0.</description></item>
                /// <item><description>Integer: The offset in pixels (px). Value range: [1,4096].</description></item>
                /// <item><description>Decimal: The ratio of horizontal offset to output resolution height. Value range: (0,1).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Dx")]
                [Validation(Required=false)]
                public float? Dx { get; set; }

                /// <summary>
                /// <para>The meanings differ depending on whether the value is an integer or decimal:</para>
                /// <list type="bullet">
                /// <item><description><para>0 (default): Both the offset in pixels and the ratio of vertical offset to output resolution height are 0.</para>
                /// </description></item>
                /// <item><description><para>Integer: The offset in pixels (px). Value range: [1,4096].</para>
                /// </description></item>
                /// <item><description><para>Decimal: The ratio of vertical offset to output resolution height. Value range: (0,1).</para>
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
                /// <para>The font transparency of the text watermark. Value range: (0,1]. Default value: 1, which indicates fully opaque.</para>
                /// <remarks>
                /// <para>Notice:  This parameter takes effect when the <c>Type</c> parameter is set to <c>text</c>.</notice></para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0.8</para>
                /// </summary>
                [NameInMap("FontApha")]
                [Validation(Required=false)]
                public float? FontApha { get; set; }

                /// <summary>
                /// <para>The font color of the watermark text. The format is #RRGGBB. Default value: #000000. Values such as &quot;red&quot; and &quot;green&quot; are also supported.</para>
                /// <remarks>
                /// <para>Notice:  This parameter takes effect when the <c>Type</c> parameter is set to <c>text</c>.</notice></para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>red</para>
                /// </summary>
                [NameInMap("FontColor")]
                [Validation(Required=false)]
                public string FontColor { get; set; }

                /// <summary>
                /// <para>The font name of the text watermark. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>SourceHanSans-Regular (default)</description></item>
                /// <item><description>SourceHanSans-Bold</description></item>
                /// <item><description>SourceHanSerif-Regular</description></item>
                /// <item><description>SourceHanSerif-Bold</description></item>
                /// </list>
                /// <remarks>
                /// <para>Notice:  This parameter takes effect when the <c>Type</c> parameter is set to <c>text</c>.</notice></para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>SourceHanSans-Bold</para>
                /// </summary>
                [NameInMap("FontName")]
                [Validation(Required=false)]
                public string FontName { get; set; }

                /// <summary>
                /// <para>The font size of the text watermark. Default value: 16. The value must be an integer. Value range: (4,120).</para>
                /// <remarks>
                /// <para>Notice:  This parameter takes effect when the <c>Type</c> parameter is set to <c>text</c>.</notice></para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>18</para>
                /// </summary>
                [NameInMap("FontSize")]
                [Validation(Required=false)]
                public int? FontSize { get; set; }

                /// <summary>
                /// <para>The height of the watermark image. The default value is the original height of the watermark image. The meanings differ depending on whether the value is an integer or decimal:</para>
                /// <list type="bullet">
                /// <item><description>Integer: The pixel value of the logo removal height, in pixels (px). Value range: [1,4096].</description></item>
                /// <item><description>Decimal: The ratio relative to the output video resolution height. Value range: (0,1).</description></item>
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
                /// <item><description>topleft (default): top-left corner</description></item>
                /// <item><description>topright: top-right corner</description></item>
                /// <item><description>bottomright: bottom-right corner</description></item>
                /// <item><description>bottomleft: bottom-left corner</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>topleft</para>
                /// </summary>
                [NameInMap("ReferPos")]
                [Validation(Required=false)]
                public string ReferPos { get; set; }

                /// <summary>
                /// <para>The start time for adding the watermark, in seconds (s). The default value is the start time of the video.</para>
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
                /// <item><description>text (default): text watermark.</description></item>
                /// <item><description>file: image or animated image watermark.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The OSS URI of the watermark file. Supported formats are PNG and MOV.</para>
                /// <para>The OSS URI format is <c>oss://&lt;bucket&gt;/&lt;object&gt;</c>, where <c>&lt;bucket&gt;</c> is the name of an OSS bucket in the same region as the current project, and <c>&lt;object&gt;</c> is the full path of the file including the file name extension.</para>
                /// <remarks>
                /// <para>Notice:  This parameter takes effect when the <c>Type</c> parameter is set to <c>file</c>.</notice></para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>oss://test-bucket/watermark.jpg</para>
                /// </summary>
                [NameInMap("URI")]
                [Validation(Required=false)]
                public string URI { get; set; }

                /// <summary>
                /// <para>The width of the watermark image. The default value is the original width of the watermark image. The meanings differ depending on whether the value is an integer or decimal:</para>
                /// <list type="bullet">
                /// <item><description>Integer: The pixel value of the logo removal width, in pixels (px). Value range: [1,4096].</description></item>
                /// <item><description>Decimal: The ratio relative to the output video resolution width. Value range: (0,1).</description></item>
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
        /// <para>The list of video stream index numbers to process from the source file. An empty value (default) indicates that the video stream with the smallest index number (the first video stream) is processed. An index number greater than 100 indicates that all video streams are processed.</para>
        /// <list type="bullet">
        /// <item><description>Example: <c>[0,1]</c> processes video streams with index numbers 0 and 1. <c>[1]</c> processes the video stream with index number 1. <c>[101]</c> processes all video streams.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Only video streams with existing index numbers are processed. If a video stream corresponding to an index number does not exist, that index number is ignored.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Stream")]
        [Validation(Required=false)]
        public List<int?> Stream { get; set; }

        /// <summary>
        /// <para>The video transcoding parameters. An empty value indicates that video processing is disabled and the output file does not contain a video stream.</para>
        /// <remarks>
        /// <para>Setting this parameter to an empty value to disable video processing is not recommended.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("TranscodeVideo")]
        [Validation(Required=false)]
        public TargetVideoTranscodeVideo TranscodeVideo { get; set; }
        public class TargetVideoTranscodeVideo : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable adaptive long/short side mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enabled. The format of the <b>Resolution</b> parameter is <c>long side × short side</c>.</description></item>
            /// <item><description>false (default): Disabled. The format of the <b>Resolution</b> parameter is <c>width × height</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AdaptiveResolutionDirection")]
            [Validation(Required=false)]
            public bool? AdaptiveResolutionDirection { get; set; }

            /// <summary>
            /// <para>The number of consecutive B-frames. Default value: 3.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("BFrames")]
            [Validation(Required=false)]
            public int? BFrames { get; set; }

            /// <summary>
            /// <para>The video stream bitrate, in bits per second (bit/s).</para>
            /// <remarks>
            /// <para>This parameter is mutually exclusive with <b>CRF</b>. If both this parameter and <b>CRF</b> are empty, encoding is performed with a <b>CRF</b> value of 23.</para>
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
            /// <item><description>fixed: Always uses the specified target video bitrate.</description></item>
            /// <item><description>adaptive: Uses the source video bitrate when it is lower than the specified target video bitrate.</description></item>
            /// <item><description>fall: Returns a failure when the source video bitrate is lower than the specified target video bitrate.</description></item>
            /// </list>
            /// <para>Default value:</para>
            /// <list type="bullet">
            /// <item><description>For the CreateMediaConvert API, the default value is fixed.</description></item>
            /// <item><description>For the GenerateVideoPlaylist API, the default value is adaptive.</description></item>
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
            /// <para>The decoding buffer size for variable bitrate, in bits per second (bps).</para>
            /// <remarks>
            /// <para>This parameter takes effect only when used together with the <b>CRF</b> parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>4000000</para>
            /// </summary>
            [NameInMap("BufferSize")]
            [Validation(Required=false)]
            public int? BufferSize { get; set; }

            /// <summary>
            /// <para>Specifies the constant quality mode. This parameter is mutually exclusive with the <b>Bitrate</b> parameter. The value range is [0,51]. A larger value results in lower video quality. The recommended value range is [18,38].</para>
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
            /// <item><description>For the CreateMediaConvert API: copy (default), h264, h265, vp9.
            /// <warning>When this parameter is set to copy, the video streams to be processed are directly copied to the output file, and other parameters under <b>TranscodeVideo</b> do not take effect. copy cannot be used for video concatenation and is typically used for container format conversion scenarios.</warning></description></item>
            /// <item><description>For the GenerateVideoPlaylist API: h264 (default), h265.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>h264</para>
            /// </summary>
            [NameInMap("Codec")]
            [Validation(Required=false)]
            public string Codec { get; set; }

            /// <summary>
            /// <para>The video frame rate. The default value is the same as the source video.</para>
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
            /// <item><description>fixed: Always uses the specified target video frame rate.</description></item>
            /// <item><description>adaptive: Uses the source video frame rate when it is lower than the specified target video frame rate.</description></item>
            /// <item><description>fall: Returns a failure when the source video frame rate is lower than the specified target video frame rate.</description></item>
            /// </list>
            /// <para>Default value:</para>
            /// <list type="bullet">
            /// <item><description>For the CreateMediaConvert API, the default value is fixed.</description></item>
            /// <item><description>For the GenerateVideoPlaylist API, the default value is adaptive.</description></item>
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
            /// <para>The number of frames between keyframes. Default value: 150.</para>
            /// <remarks>
            /// <para>This parameter is not supported for the GenerateVideoPlaylist API.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("GOPSize")]
            [Validation(Required=false)]
            public int? GOPSize { get; set; }

            /// <summary>
            /// <para>The maximum bitrate limit for variable bitrate. When using this parameter, the BufferSize parameter must be specified.</para>
            /// <remarks>
            /// <para>This parameter takes effect only when used together with the <b>CRF</b> parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>128000</para>
            /// </summary>
            [NameInMap("MaxBitrate")]
            [Validation(Required=false)]
            public int? MaxBitrate { get; set; }

            /// <summary>
            /// <para>The pixel format. The default value is the same as the source video. Valid values:</para>
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
            /// <para>yuva420p is available only for the CreateMediaConvert API, and the <b>Codec</b> parameter must be set to vp9.</para>
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
            /// <para>The resolution of the output video in the format of <c>widthxheight</c>. The default value is the same as the playback resolution of the source video. You can specify both width and height, or specify only width or height. You can also use the <b>AdaptiveResolutionDirection</b> parameter to specify both long and short sides, or only the long side or short side. The value range for a single side is (0,4096].</para>
            /// <list type="bullet">
            /// <item><description>Example 1: If <b>AdaptiveResolutionDirection</b> is false, <c>1280x720</c> sets the width to 1280 and height to 720. <c>1280x</c> sets the width to 1280 and keeps the height the same as the source video. <c>x720</c> sets the height to 720 and keeps the width the same as the source video.</description></item>
            /// <item><description>Example 2: If <b>AdaptiveResolutionDirection</b> is true, <c>1280x720</c> sets the long side to 1280 and short side to 720. <c>1280x</c> sets the long side to 1280 and keeps the short side the same as the source video. <c>x720</c> sets the short side to 720 and keeps the long side the same as the source video.</description></item>
            /// </list>
            /// <remarks>
            /// <para>If the source video contains rotation information, the width/height and long/short side determination is based on the post-rotation state, which is the playback resolution.</para>
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
            /// <item><description>fixed: Always uses the specified target video resolution.</description></item>
            /// <item><description>adaptive: Uses the source video resolution when the source video resolution area is smaller than the specified target video resolution area.</description></item>
            /// <item><description>fall: Returns a failure when the source video resolution area is smaller than the specified target video resolution area.</description></item>
            /// </list>
            /// <para>Default value:</para>
            /// <list type="bullet">
            /// <item><description>For the CreateMediaConvert API, the default value is fixed.</description></item>
            /// <item><description>For the GenerateVideoPlaylist API, the default value is adaptive.</description></item>
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
            /// <para>The clockwise rotation degree of the video. Valid values:</para>
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
            /// <para>The scaling mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>stretch (default): Fixed width/height or long/short sides. Forces scaling and stretches to fill blank areas.</description></item>
            /// <item><description>crop: Proportional scaling. Scales to the minimum resolution that extends beyond the specified width/height or long/short side rectangle, then center-crops the excess.</description></item>
            /// <item><description>fill: Proportional scaling. Scales to the maximum resolution within the specified width/height or long/short side rectangle, then fills blank areas with black using center alignment.</description></item>
            /// <item><description>fit: Proportional scaling. Scales to the maximum resolution within the specified width/height or long/short side rectangle.</description></item>
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
            /// <para>Enables the lightweight HD mode. Valid values:</para>
            /// <para>0: Default value. Disabled.</para>
            /// <para>1: Uses the lightweight HD mode for transcoding.</para>
            /// <remarks>
            /// <para>For optimal results, use the officially recommended Bitrate or CRF parameters for video transcoding encoding with lightweight HD.</para>
            /// <para>Notice: Lightweight HD supports only h.264/h.265 formats, only yuv420p, 8-bit depth, and does not support multi-target video transcoding output or video concatenation. For more information, see <a href="https://help.aliyun.com/document_detail/2984556.html">Lightweight HD product introduction</a>.</para>
            /// </remarks>
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
