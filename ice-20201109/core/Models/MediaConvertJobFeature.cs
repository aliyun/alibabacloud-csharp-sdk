// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class MediaConvertJobFeature : TeaModel {
        /// <summary>
        /// <para>Clip settings.</para>
        /// </summary>
        [NameInMap("Clip")]
        [Validation(Required=false)]
        public MediaConvertJobFeatureClip Clip { get; set; }
        public class MediaConvertJobFeatureClip : TeaModel {
            /// <summary>
            /// <para>Specifies whether to clip the first segment before concatenation.</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: The system clips the first segment before concatenation and transcoding.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: The system first concatenates and transcodes the segments, and then clips the resulting video.</para>
            /// </description></item>
            /// <item><description><para>Default value: <c>false</c>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ConfigToClipFirstPart")]
            [Validation(Required=false)]
            public string ConfigToClipFirstPart { get; set; }

            /// <summary>
            /// <para>The time span for the clip.</para>
            /// </summary>
            [NameInMap("TimeSpan")]
            [Validation(Required=false)]
            public MediaConvertJobFeatureClipTimeSpan TimeSpan { get; set; }
            public class MediaConvertJobFeatureClipTimeSpan : TeaModel {
                /// <summary>
                /// <para>Specifies the duration of the clip, relative to the <c>Seek</c> time. By default, the clip extends to the end of the video. You can specify either <c>Duration</c> or <c>End</c>, but not both. If <c>End</c> is specified, <c>Duration</c> is ignored.</para>
                /// <list type="bullet">
                /// <item><description><para>Format: <c>hh:mm:ss[.SSS]</c> or <c>sssss[.SSS]</c>.</para>
                /// </description></item>
                /// <item><description><para>Value range: <c>[00:00:00.000, 23:59:59.999]</c> or <c>[0.000, 86399.999]</c>.</para>
                /// </description></item>
                /// <item><description><para>Example: <c>00:01:59.999</c> or <c>180.30</c>.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>60.0</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public string Duration { get; set; }

                /// <summary>
                /// <para>Specifies the end time of the clip. You can specify either <c>End</c> or <c>Duration</c>, but not both. If <c>End</c> is specified, <c>Duration</c> is ignored.</para>
                /// <list type="bullet">
                /// <item><description><para>Format: <c>hh:mm:ss[.SSS]</c> or <c>sssss[.SSS]</c>.</para>
                /// </description></item>
                /// <item><description><para>Value range: <c>[00:00:00.000, 23:59:59.999]</c> or <c>[0.000, 86399.999]</c>.</para>
                /// </description></item>
                /// <item><description><para>Example: <c>00:01:59.999</c> or <c>180.30</c>.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("End")]
                [Validation(Required=false)]
                public string End { get; set; }

                /// <summary>
                /// <para>Specifies the start time of the clip. If this parameter is not set, the clip starts from the beginning of the video.</para>
                /// <list type="bullet">
                /// <item><description><para>Format: <c>hh:mm:ss[.SSS]</c> or <c>sssss[.SSS]</c>.</para>
                /// </description></item>
                /// <item><description><para>Value range: <c>[00:00:00.000, 23:59:59.999]</c> or <c>[0.000, 86399.999]</c>.</para>
                /// </description></item>
                /// <item><description><para>Example: <c>00:01:59.999</c> or <c>180.30</c>.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>180.30</para>
                /// </summary>
                [NameInMap("Seek")]
                [Validation(Required=false)]
                public string Seek { get; set; }

            }

        }

        /// <summary>
        /// <para>Specifies the metadata for the output video container format, provided as JSON key-value pairs. Example: <c>{&quot;key1&quot;:&quot;value1&quot;,&quot;key2&quot;:&quot;value2&quot;}</c>.</para>
        /// <list type="bullet">
        /// <item><description><para>Maximum key length: 64 characters.</para>
        /// </description></item>
        /// <item><description><para>Maximum value length: 512 characters.</para>
        /// </description></item>
        /// </list>
        /// <para>You can add a maximum of four metadata key-value pairs.</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// <para>A list of watermark settings to overlay on the video. If specified, these settings override the corresponding parameters in the specified watermark template.</para>
        /// <list type="bullet">
        /// <item><description>You can add a maximum of four watermarks per transcoding job.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Watermarks")]
        [Validation(Required=false)]
        public List<MediaConvertJobFeatureWatermarks> Watermarks { get; set; }
        public class MediaConvertJobFeatureWatermarks : TeaModel {
            /// <summary>
            /// <para>Specifies whether the font size of the text watermark adapts to the output video resolution.</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: The font size is adaptive.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: The font size is fixed.</para>
            /// </description></item>
            /// <item><description><para>Default value: <c>false</c>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Adaptive")]
            [Validation(Required=false)]
            public string Adaptive { get; set; }

            /// <summary>
            /// <para>The border color of the text watermark.</para>
            /// <list type="bullet">
            /// <item><description>Default value: <c>black</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Black</para>
            /// </summary>
            [NameInMap("BorderColor")]
            [Validation(Required=false)]
            public string BorderColor { get; set; }

            /// <summary>
            /// <para>The border width of the text watermark.</para>
            /// <list type="bullet">
            /// <item><description><para>Unit: pixels.</para>
            /// </description></item>
            /// <item><description><para>Value range: [0, 4096].</para>
            /// </description></item>
            /// <item><description><para>Default value: <c>0</c>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("BorderWidth")]
            [Validation(Required=false)]
            public string BorderWidth { get; set; }

            /// <summary>
            /// <para>The content of the text watermark.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TextWatarmark</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The opacity of the font.</para>
            /// <list type="bullet">
            /// <item><description><para>Value range: (0, 1].</para>
            /// </description></item>
            /// <item><description><para>Default value: <c>1.0</c>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("FontAlpha")]
            [Validation(Required=false)]
            public string FontAlpha { get; set; }

            /// <summary>
            /// <para>The font color of the text watermark.</para>
            /// <list type="bullet">
            /// <item><description>Default value: <c>black</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>black</para>
            /// </summary>
            [NameInMap("FontColor")]
            [Validation(Required=false)]
            public string FontColor { get; set; }

            /// <summary>
            /// <para>The font name for the text watermark.</para>
            /// <list type="bullet">
            /// <item><description>Default value: <c>SimSun</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SimSum</para>
            /// </summary>
            [NameInMap("FontName")]
            [Validation(Required=false)]
            public string FontName { get; set; }

            /// <summary>
            /// <para>The font size of the text watermark.</para>
            /// <list type="bullet">
            /// <item><description><para>Value range: (4, 120).</para>
            /// </description></item>
            /// <item><description><para>Default value: <c>16</c>.</para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("FontSize")]
            [Validation(Required=false)]
            public string FontSize { get; set; }

            /// <summary>
            /// <para>The height of the watermark. If specified, this value overrides the corresponding parameter in the watermark template. You can specify the value in two ways:</para>
            /// <list type="bullet">
            /// <item><description><para>As an integer, representing the height in pixels.</para>
            /// <list type="bullet">
            /// <item><description><para>Unit: pixels.</para>
            /// </description></item>
            /// <item><description><para>Value range: [8, 4096].</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>As a decimal, representing the ratio of the height to the height of the output video.</para>
            /// <list type="bullet">
            /// <item><description><para>Value range: (0, 1).</para>
            /// </description></item>
            /// <item><description><para>Supports up to four decimal places, such as <c>0.9999</c>. The system truncates additional digits.</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0.1</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public string Height { get; set; }

            /// <summary>
            /// <para>The ID of the watermark template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>962e1332fa2d4e12bdfb76dd1402fcfa</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>The type of the watermark.</para>
            /// <list type="bullet">
            /// <item><description><para><c>Text</c>: A text watermark. You must also set the text watermark parameters.</para>
            /// </description></item>
            /// <item><description><para><c>Image</c>: An image watermark. You must also set the image watermark parameters.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: The system automatically determines the type based on the watermark template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Image</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The width of the watermark. If specified, this value overrides the corresponding parameter in the watermark template. You can specify the value in two ways:</para>
            /// <list type="bullet">
            /// <item><description><para>As an integer, representing the width in pixels.</para>
            /// <list type="bullet">
            /// <item><description><para>Unit: pixels.</para>
            /// </description></item>
            /// <item><description><para>Value range: [8, 4096].</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>As a decimal, representing the ratio of the width to the width of the output video.</para>
            /// <list type="bullet">
            /// <item><description><para>Value range: (0, 1).</para>
            /// </description></item>
            /// <item><description><para>Supports up to four decimal places, such as <c>0.9999</c>. The system truncates additional digits.</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0.1</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public string Width { get; set; }

            /// <summary>
            /// <para>The horizontal offset of the watermark relative to the output video. If specified, this value overrides the corresponding parameter in the watermark template. You can specify the value in two ways:</para>
            /// <list type="bullet">
            /// <item><description><para>As an integer, representing the offset in pixels.</para>
            /// <list type="bullet">
            /// <item><description><para>Unit: pixels.</para>
            /// </description></item>
            /// <item><description><para>Value range: [8, 4096].</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>As a decimal, representing the ratio of the offset to the width of the output video.</para>
            /// <list type="bullet">
            /// <item><description><para>Value range: (0, 1).</para>
            /// </description></item>
            /// <item><description><para>Supports up to four decimal places, such as <c>0.9999</c>. The system truncates additional digits.</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0.08</para>
            /// </summary>
            [NameInMap("X")]
            [Validation(Required=false)]
            public string X { get; set; }

            /// <summary>
            /// <para>The vertical offset of the watermark relative to the output video. If specified, this value overrides the corresponding parameter in the watermark template. You can specify the value in two ways:</para>
            /// <list type="bullet">
            /// <item><description><para>As an integer, representing the offset in pixels.</para>
            /// <list type="bullet">
            /// <item><description><para>Unit: pixels.</para>
            /// </description></item>
            /// <item><description><para>Value range: [8, 4096].</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>As a decimal, representing the ratio of the offset to the height of the output video.</para>
            /// <list type="bullet">
            /// <item><description><para>Value range: (0, 1).</para>
            /// </description></item>
            /// <item><description><para>Supports up to four decimal places, such as <c>0.9999</c>. The system truncates additional digits.</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0.08</para>
            /// </summary>
            [NameInMap("Y")]
            [Validation(Required=false)]
            public string Y { get; set; }

        }

    }

}
