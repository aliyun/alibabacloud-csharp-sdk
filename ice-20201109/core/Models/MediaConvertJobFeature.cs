// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class MediaConvertJobFeature : TeaModel {
        /// <summary>
        /// <para>Configuration for clipping from the source video.</para>
        /// </summary>
        [NameInMap("Clip")]
        [Validation(Required=false)]
        public MediaConvertJobFeatureClip Clip { get; set; }
        public class MediaConvertJobFeatureClip : TeaModel {
            /// <summary>
            /// <para>Specifies the order of operations when concatenating multiple files and clipping.</para>
            /// <list type="bullet">
            /// <item><description>true: Clips the first input file before it is concatenated.</description></item>
            /// <item><description>false: Concatenates all input files first, then applies clipping.</description></item>
            /// <item><description>Default value: false.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ConfigToClipFirstPart")]
            [Validation(Required=false)]
            public string ConfigToClipFirstPart { get; set; }

            /// <summary>
            /// <para>The time range for the clip.</para>
            /// </summary>
            [NameInMap("TimeSpan")]
            [Validation(Required=false)]
            public MediaConvertJobFeatureClipTimeSpan TimeSpan { get; set; }
            public class MediaConvertJobFeatureClipTimeSpan : TeaModel {
                /// <summary>
                /// <para>The duration of the clip, starting from the Seek time. The default duration is from the Seek time to the end of the video. Duration and End are mutually exclusive. If End is set, Duration is ignored.</para>
                /// <list type="bullet">
                /// <item><description>Format: hh:mm:ss[.SSS] or sssss[.SSS].</description></item>
                /// <item><description>Valid values: [00:00:00.000,23:59:59.999] or [0.000,86399.999].</description></item>
                /// <item><description>Example: 00:01:59.99 or 180.30.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>60.0</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public string Duration { get; set; }

                /// <summary>
                /// <para>Specifies a duration to trim from the end of the video. Duration and End are mutually exclusive. If End is set, Duration is ignored.</para>
                /// <list type="bullet">
                /// <item><description>Format: hh:mm:ss[.SSS] or sssss[.SSS].</description></item>
                /// <item><description>Valid values: [00:00:00.000,23:59:59.999] or [0.000,86399.999].</description></item>
                /// <item><description>Example: 00:01:59.99 or 180.30.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("End")]
                [Validation(Required=false)]
                public string End { get; set; }

                /// <summary>
                /// <para>The start time of the clip. It defaults to the beginning of the video.</para>
                /// <list type="bullet">
                /// <item><description>Format: hh:mm:ss[.SSS] or sssss[.SSS].</description></item>
                /// <item><description>Valid values: [00:00:00.000,23:59:59.999] or [0.000,86399.999].</description></item>
                /// <item><description>Example: 00:01:59.99 or 180.30.</description></item>
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
        /// <para>A map of key-value pairs to be embedded as container-level metadata in the output file. Provided as a JSON string. Example: {&quot;key1&quot;:&quot;value1&quot;,&quot;key2&quot;:&quot;value2&quot;}.</para>
        /// <list type="bullet">
        /// <item><description>Max key length: 64 characters.</description></item>
        /// <item><description>Max value length: 512 characters.</description></item>
        /// </list>
        /// <para>Max 4 key-value pairs.</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// <para>Image or text watermarks to add to the video. These parameters override the corresponding settings from a specified watermark template.</para>
        /// <list type="bullet">
        /// <item><description>You can add up to four watermarks to a transcoding task.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Watermarks")]
        [Validation(Required=false)]
        public List<MediaConvertJobFeatureWatermarks> Watermarks { get; set; }
        public class MediaConvertJobFeatureWatermarks : TeaModel {
            /// <summary>
            /// <para>Specifies if the font size adapts to the output resolution. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// <item><description>Default value: false.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Adaptive")]
            [Validation(Required=false)]
            public string Adaptive { get; set; }

            /// <summary>
            /// <para>The color of the font border.</para>
            /// <list type="bullet">
            /// <item><description>Default value: Black.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Black</para>
            /// </summary>
            [NameInMap("BorderColor")]
            [Validation(Required=false)]
            public string BorderColor { get; set; }

            /// <summary>
            /// <para>The width of the font border.</para>
            /// <list type="bullet">
            /// <item><description>Unit: pixels.</description></item>
            /// <item><description>Valid values: [0,4096].</description></item>
            /// <item><description>Default value: 0.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("BorderWidth")]
            [Validation(Required=false)]
            public string BorderWidth { get; set; }

            /// <summary>
            /// <para>The text to be displayed as the watermark.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TextWatarmark</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The font opacity.</para>
            /// <list type="bullet">
            /// <item><description>Valid values: (0,1].</description></item>
            /// <item><description>Default value: 1.0.</description></item>
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
            /// <item><description>Default value: black.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>black</para>
            /// </summary>
            [NameInMap("FontColor")]
            [Validation(Required=false)]
            public string FontColor { get; set; }

            /// <summary>
            /// <para>The font of the text watermark.</para>
            /// <list type="bullet">
            /// <item><description>Default value: SimSum.</description></item>
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
            /// <item><description>Valid values: (4,120).</description></item>
            /// <item><description>Default value: 16.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("FontSize")]
            [Validation(Required=false)]
            public string FontSize { get; set; }

            /// <summary>
            /// <para>The height of the image watermark. This parameter overrides the corresponding setting from a specified watermark template. The following value types are supported:</para>
            /// <list type="bullet">
            /// <item><description><para>Integer: the pixel value of the watermark height.</para>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// <item><description>Valid values: [8,4096].</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>Decimal: A decimal of the output video\&quot;s height.</para>
            /// <list type="bullet">
            /// <item><description>Valid values: (0,1).</description></item>
            /// <item><description>The decimal number can be accurate to four decimal places, such as 0.9999. Excessive digits are automatically discarded.</description></item>
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
            /// <para>The watermark type.</para>
            /// <list type="bullet">
            /// <item><description>Text: a text watermark. In this case, you must specify the parameters related to the text watermark.</description></item>
            /// <item><description>Image: an image watermark. In this case, you must specify the parameters related to the image watermark.</description></item>
            /// </list>
            /// <para>If not specified, the type is inferred from the TemplateId.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Image</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The width of the image watermark. This parameter overrides the corresponding setting from a specified watermark template. The following value types are supported:</para>
            /// <list type="bullet">
            /// <item><description><para>Integer: the pixel value of the watermark width.</para>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// <item><description>Valid values: [8,4096].</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>Decimal: A decimal of the output video\&quot;s width.</para>
            /// <list type="bullet">
            /// <item><description>Valid values: (0,1).</description></item>
            /// <item><description>The decimal number can be accurate to four decimal places, such as 0.9999. Excessive digits are automatically discarded.</description></item>
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
            /// <para>The horizontal offset of the image watermark relative to the output video. This parameter overrides the corresponding setting from a specified watermark template. The following value types are supported:</para>
            /// <list type="bullet">
            /// <item><description><para>Integer: the pixel value of the horizontal offset.</para>
            /// <list type="bullet">
            /// <item><description>Unit: pixels.</description></item>
            /// <item><description>Valid values: [8,4096].</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>Decimal: the ratio of the horizontal offset to the width of the output video.</para>
            /// <list type="bullet">
            /// <item><description>Valid values: (0,1).</description></item>
            /// <item><description>The decimal number can be accurate to four decimal places, such as 0.9999. Excessive digits are automatically discarded.</description></item>
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
            /// <para>The vertical offset of the image watermark relative to the output video. This parameter overrides the corresponding setting from a specified watermark template. The following value types are supported:</para>
            /// <list type="bullet">
            /// <item><description><para>Integer: the pixel value of the vertical offset.</para>
            /// <list type="bullet">
            /// <item><description>Unit: pixels.</description></item>
            /// <item><description>Valid values: [8,4096].</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>Decimal: the ratio of the vertical offset to the height of the output video.</para>
            /// <list type="bullet">
            /// <item><description>Valid values: (0,1).</description></item>
            /// <item><description>The decimal number can be accurate to four decimal places, such as 0.9999. Excessive digits are automatically discarded.</description></item>
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
