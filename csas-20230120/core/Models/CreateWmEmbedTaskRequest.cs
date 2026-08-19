// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateWmEmbedTaskRequest : TeaModel {
        /// <summary>
        /// <para>The audio control parameters.</para>
        /// </summary>
        [NameInMap("AudioControl")]
        [Validation(Required=false)]
        public CreateWmEmbedTaskRequestAudioControl AudioControl { get; set; }
        public class CreateWmEmbedTaskRequestAudioControl : TeaModel {
            /// <summary>
            /// <para>The control parameters for audio metadata.</para>
            /// </summary>
            [NameInMap("MetadataControl")]
            [Validation(Required=false)]
            public CreateWmEmbedTaskRequestAudioControlMetadataControl MetadataControl { get; set; }
            public class CreateWmEmbedTaskRequestAudioControlMetadataControl : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable this feature.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The metadata in Base64 format. Encode the following string in Base64 format: AIGC={&quot;Label&quot;:&quot;1&quot;,&quot;ContentProducer&quot;:&quot;AXXXX&quot;,&quot;ProduceID&quot;:&quot;BXXXX,&quot;ReservedCode1&quot;:&quot;CXXX&quot;,&quot;ContentPropagator&quot;:&quot;DXXX&quot;,&quot;PropagateID&quot;:&quot;EXXX&quot;,&quot;ReservedCode2&quot;:&quot;FXXXX&quot;}. Note: 1. The &quot;AIGC=&quot; prefix is required. Otherwise, the metadata cannot be added. The prefix differs from that of image metadata. 2. The Base64 encoding must be in standard format with padding.</para>
                /// 
                /// <b>Example:</b>
                /// <para>QUlHQz17IkxhYmVsIjoiMSIsIkNvbnRlbnRQcm9kdWNlciI6IkFYWFhYIiwiUHJvZHVjZUlEIjoiQlhYWFgsIlJlc2VydmVkQ29kZTEiOiJDWFhYIiwiQ29udGVudFByb3BhZ2F0b3IiOiJEWFhYIiwiUHJvcGFnYXRlSUQiOiJFWFhYIiwiUmVzZXJ2ZWRDb2RlMiI6IkZYWFhYIn0=</para>
                /// </summary>
                [NameInMap("XmpKvBase64")]
                [Validation(Required=false)]
                public string XmpKvBase64 { get; set; }

            }

        }

        /// <summary>
        /// <para>The CSV watermark embedding control parameters.</para>
        /// </summary>
        [NameInMap("CsvControl")]
        [Validation(Required=false)]
        public CreateWmEmbedTaskRequestCsvControl CsvControl { get; set; }
        public class CreateWmEmbedTaskRequestCsvControl : TeaModel {
            /// <summary>
            /// <para>The timestamp watermark information bit width. Specifies how much information a single timestamp can contain. A larger value theoretically reduces the number of rows required for extraction, but increases the time modification magnitude. The magnitude range is 2^n, where n is this parameter value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("EmbedBitsNumberInEachTime")]
            [Validation(Required=false)]
            public long? EmbedBitsNumberInEachTime { get; set; }

            /// <summary>
            /// <para>The column to embed the watermark. We recommend that you use a string content column. Counting starts from 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EmbedColumn")]
            [Validation(Required=false)]
            public long? EmbedColumn { get; set; }

            /// <summary>
            /// <para>The zero-width character watermark parameter that specifies the embedding density. Valid values: a floating-point number between 0 and 1. 0 indicates that only the first row is embedded. 1 indicates that all rows are embedded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EmbedDensity")]
            [Validation(Required=false)]
            public string EmbedDensity { get; set; }

            /// <summary>
            /// <para>The modification precision, which indicates the magnitude of modification as a power of 10. For example, 0 indicates a modification precision of 10^0 (the ones place), -1 indicates the first decimal place, and 1 indicates the tens place. If the float data does not have this precision, no modification is made.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("EmbedPrecision")]
            [Validation(Required=false)]
            public long? EmbedPrecision { get; set; }

            /// <summary>
            /// <para>The timestamp watermark parameter that specifies the watermark embedding position. Valid values: Min (minute), Sec (second), and MilSec (millisecond). Select one of the three. The algorithm modifies the data at the selected position.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sec</para>
            /// </summary>
            [NameInMap("EmbedTimePosition")]
            [Validation(Required=false)]
            public string EmbedTimePosition { get; set; }

            /// <summary>
            /// <para>The watermark embedding method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lossy_zero_width_embed</para>
            /// </summary>
            [NameInMap("Method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            /// <summary>
            /// <para>The timestamp watermark parameter that specifies the format string for parsing timestamps in the CSV file. For example, if the timestamp in the CSV file is similar to &quot;2023-10-15 13:20:59:342&quot;, the corresponding format string is &quot;Year-Mon-Day Hour:Min:Sec.MilSec&quot;. The watermark output retains this format after embedding. If the format is incorrect, this method cannot be used. Year, month, day, hour, minute, second, and millisecond in the format string must follow the specified notation. Delimiters must be single non-alphabetic English characters, typically &quot;:&quot;, &quot;/&quot;, &quot;-&quot;, or &quot; &quot; (space). &quot;T&quot; and &quot;Z&quot; are also supported as delimiters. Other time formats are not currently supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hour:Min:Sec</para>
            /// </summary>
            [NameInMap("TimeFormat")]
            [Validation(Required=false)]
            public string TimeFormat { get; set; }

        }

        /// <summary>
        /// <para>The document watermark control parameters.</para>
        /// </summary>
        [NameInMap("DocumentControl")]
        [Validation(Required=false)]
        public CreateWmEmbedTaskRequestDocumentControl DocumentControl { get; set; }
        public class CreateWmEmbedTaskRequestDocumentControl : TeaModel {
            /// <summary>
            /// <para>The background watermark control parameters.</para>
            /// </summary>
            [NameInMap("BackgroundControl")]
            [Validation(Required=false)]
            public CreateWmEmbedTaskRequestDocumentControlBackgroundControl BackgroundControl { get; set; }
            public class CreateWmEmbedTaskRequestDocumentControlBackgroundControl : TeaModel {
                /// <summary>
                /// <para>Specifies whether to add a background invisible watermark. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("BgAddInvisible")]
                [Validation(Required=false)]
                public bool? BgAddInvisible { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable the background visible watermark. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("BgAddVisible")]
                [Validation(Required=false)]
                public bool? BgAddVisible { get; set; }

                /// <summary>
                /// <para>The background invisible watermark control parameters.</para>
                /// </summary>
                [NameInMap("BgInvisibleControl")]
                [Validation(Required=false)]
                public CreateWmEmbedTaskRequestDocumentControlBackgroundControlBgInvisibleControl BgInvisibleControl { get; set; }
                public class CreateWmEmbedTaskRequestDocumentControlBackgroundControlBgInvisibleControl : TeaModel {
                    /// <summary>
                    /// <para>The opacity parameter of the background invisible watermark. Valid values: 1 to 13. A larger value indicates less transparency.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Opacity")]
                    [Validation(Required=false)]
                    public long? Opacity { get; set; }

                }

                /// <summary>
                /// <para>The background visible watermark control parameters.</para>
                /// </summary>
                [NameInMap("BgVisibleControl")]
                [Validation(Required=false)]
                public CreateWmEmbedTaskRequestDocumentControlBackgroundControlBgVisibleControl BgVisibleControl { get; set; }
                public class CreateWmEmbedTaskRequestDocumentControlBackgroundControlBgVisibleControl : TeaModel {
                    /// <summary>
                    /// <para>The counterclockwise rotation angle of the visible watermark text. Valid values: 1 to 360.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("Angle")]
                    [Validation(Required=false)]
                    public long? Angle { get; set; }

                    /// <summary>
                    /// <para>The font color of the visible watermark text. The format is 0xFFFFFF RGB color format. For example, 0x000000 indicates black.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0x000000</para>
                    /// </summary>
                    [NameInMap("FontColor")]
                    [Validation(Required=false)]
                    public string FontColor { get; set; }

                    /// <summary>
                    /// <para>The font size of the visible watermark text. A larger value indicates a larger font.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("FontSize")]
                    [Validation(Required=false)]
                    public long? FontSize { get; set; }

                    /// <summary>
                    /// <para>Takes effect when Mode is set to repeat. Specifies the number of times the visible watermark repeats horizontally.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("HorizontalNumber")]
                    [Validation(Required=false)]
                    public long? HorizontalNumber { get; set; }

                    /// <summary>
                    /// <para>The background visible watermark mode. Valid values:</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pos</para>
                    /// </summary>
                    [NameInMap("Mode")]
                    [Validation(Required=false)]
                    public string Mode { get; set; }

                    /// <summary>
                    /// <para>The opacity parameter of the visible watermark. Valid values: 1 to 255. A larger value indicates less transparency.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Opacity")]
                    [Validation(Required=false)]
                    public long? Opacity { get; set; }

                    /// <summary>
                    /// <para>Takes effect when Mode is set to pos. Controls the horizontal position of the visible watermark, with the lower-left corner as the origin. When the value is between 0 and 1, it represents proportional control. When the value is greater than 1, it represents precise pixel position control.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.5</para>
                    /// </summary>
                    [NameInMap("PosX")]
                    [Validation(Required=false)]
                    public string PosX { get; set; }

                    /// <summary>
                    /// <para>Takes effect when Mode is set to pos. Controls the vertical position of the visible watermark, with the lower-left corner as the origin. When the value is between 0 and 1, it represents proportional control. When the value is greater than 1, it represents precise pixel position control.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.5</para>
                    /// </summary>
                    [NameInMap("PosY")]
                    [Validation(Required=false)]
                    public string PosY { get; set; }

                    /// <summary>
                    /// <para>Takes effect when Mode is set to repeat. Specifies the number of times the visible watermark repeats vertically.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("VerticalNumber")]
                    [Validation(Required=false)]
                    public long? VerticalNumber { get; set; }

                    /// <summary>
                    /// <para>The background visible watermark text. The format is a UTF-8 string.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>hello ****</para>
                    /// </summary>
                    [NameInMap("VisibleText")]
                    [Validation(Required=false)]
                    public string VisibleText { get; set; }

                }

            }

            /// <summary>
            /// <para>Specifies whether to enable component invisible watermark. The component invisible watermark can resist document addition, deletion, modification, save-as (same format), and full-select copy from docx to a new docx document. It cannot resist format conversion attacks. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("InvisibleAntiAllCopy")]
            [Validation(Required=false)]
            public bool? InvisibleAntiAllCopy { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable zero-width character invisible watermark. The zero-width character invisible watermark can resist document addition, deletion, modification, save-as (same format), partial text copy-paste, and CopytoTxt attacks. It cannot resist format conversion toPDF attacks. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("InvisibleAntiTextCopy")]
            [Validation(Required=false)]
            public bool? InvisibleAntiTextCopy { get; set; }

        }

        /// <summary>
        /// <para>The URL for downloading the file to be embedded. The URL must be active for public network access.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/abc****.pdf">https://example.com/abc****.pdf</a></para>
        /// </summary>
        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// <para>The name of the file to be embedded. The backend validates the file type based on the file name extension.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc****.pdf</para>
        /// </summary>
        [NameInMap("Filename")]
        [Validation(Required=false)]
        public string Filename { get; set; }

        /// <summary>
        /// <para>The image watermark control parameters.</para>
        /// </summary>
        [NameInMap("ImageControl")]
        [Validation(Required=false)]
        public CreateWmEmbedTaskRequestImageControl ImageControl { get; set; }
        public class CreateWmEmbedTaskRequestImageControl : TeaModel {
            /// <summary>
            /// <para>The control parameters for logo watermarks.</para>
            /// </summary>
            [NameInMap("LogoVisibleControl")]
            [Validation(Required=false)]
            public CreateWmEmbedTaskRequestImageControlLogoVisibleControl LogoVisibleControl { get; set; }
            public class CreateWmEmbedTaskRequestImageControlLogoVisibleControl : TeaModel {
                /// <summary>
                /// <para>The clockwise rotation angle of the logo watermark. Valid values: 1 to 360.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("Angle")]
                [Validation(Required=false)]
                public long? Angle { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable enhanced visible watermarking. After this feature is enabled, the logo is processed so that information embedded in the logo can be extracted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Enhance")]
                [Validation(Required=false)]
                public bool? Enhance { get; set; }

                /// <summary>
                /// <para>The logo watermark in Base64 format. The logo file is a PNG image converted to Base64 format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>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</para>
                /// </summary>
                [NameInMap("LogoBase64")]
                [Validation(Required=false)]
                public string LogoBase64 { get; set; }

                /// <summary>
                /// <para>This parameter takes effect when Mode is set to top-left, top-right, bottom-left, or bottom-right. The margin settings.</para>
                /// </summary>
                [NameInMap("Margin")]
                [Validation(Required=false)]
                public CreateWmEmbedTaskRequestImageControlLogoVisibleControlMargin Margin { get; set; }
                public class CreateWmEmbedTaskRequestImageControlLogoVisibleControlMargin : TeaModel {
                    /// <summary>
                    /// <para>This parameter takes effect when Mode is set to bottom-left or bottom-right. The bottom margin.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Bottom")]
                    [Validation(Required=false)]
                    public float? Bottom { get; set; }

                    /// <summary>
                    /// <para>This parameter takes effect when Mode is set to top-left or bottom-left. The left margin.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Left")]
                    [Validation(Required=false)]
                    public float? Left { get; set; }

                    /// <summary>
                    /// <para>This parameter takes effect when Mode is set to top-right or bottom-right. The right margin.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Right")]
                    [Validation(Required=false)]
                    public float? Right { get; set; }

                    /// <summary>
                    /// <para>This parameter takes effect when Mode is set to top-left or top-right. The top margin.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Top")]
                    [Validation(Required=false)]
                    public float? Top { get; set; }

                }

                /// <summary>
                /// <para>The display mode of the logo watermark. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>pos</para>
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// <para>The opacity of the logo watermark. Valid values: 1 to 255. A larger value indicates lower transparency.</para>
                /// 
                /// <b>Example:</b>
                /// <para>255</para>
                /// </summary>
                [NameInMap("Opacity")]
                [Validation(Required=false)]
                public int? Opacity { get; set; }

                /// <summary>
                /// <para>The horizontal anchor point of the logo watermark. Valid values: 0 to 1. When (PosAx, PosAy) is set to (0, 0), the watermark is drawn with the upper-left corner as the anchor point. When the value is 0.5, the watermark is drawn at the center. When (PosAx, PosAy) is set to (1, 1), the watermark is drawn at the lower-right corner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PosAx")]
                [Validation(Required=false)]
                public float? PosAx { get; set; }

                /// <summary>
                /// <para>The vertical anchor point of the logo watermark. Valid values: 0 to 1. When (PosAx, PosAy) is set to (0, 0), the watermark is drawn with the upper-left corner as the anchor point. When the value is 0.5, the watermark is drawn at the center. When (PosAx, PosAy) is set to (1, 1), the watermark is drawn at the lower-right corner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PosAy")]
                [Validation(Required=false)]
                public float? PosAy { get; set; }

                /// <summary>
                /// <para>This parameter takes effect when Mode is set to pos. Specifies the horizontal position of the visible watermark in pixels, with the upper-left corner as the origin.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PosX")]
                [Validation(Required=false)]
                public long? PosX { get; set; }

                /// <summary>
                /// <para>This parameter takes effect when Mode is set to pos. Specifies the vertical position of the visible watermark in pixels, with the upper-left corner as the origin.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PosY")]
                [Validation(Required=false)]
                public long? PosY { get; set; }

                /// <summary>
                /// <para>This parameter takes effect when Mode is set to repeat. Specifies the horizontal spacing for tiled visible watermarks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("SpaceX")]
                [Validation(Required=false)]
                public long? SpaceX { get; set; }

                /// <summary>
                /// <para>This parameter takes effect when Mode is set to repeat. Specifies the vertical spacing for tiled visible watermarks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("SpaceY")]
                [Validation(Required=false)]
                public long? SpaceY { get; set; }

                /// <summary>
                /// <para>The visibility. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Visible")]
                [Validation(Required=false)]
                public bool? Visible { get; set; }

            }

            /// <summary>
            /// <para>The metadata control parameters. This parameter takes effect when WmType is set to PureImage or AigcImage.</para>
            /// </summary>
            [NameInMap("MetadataControl")]
            [Validation(Required=false)]
            public CreateWmEmbedTaskRequestImageControlMetadataControl MetadataControl { get; set; }
            public class CreateWmEmbedTaskRequestImageControlMetadataControl : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable this feature.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The metadata in Base64 format. Encode the following string in Base64 format: AIGC:{&quot;Label&quot;:&quot;1&quot;,&quot;ContentProducer&quot;:&quot;AXXXX&quot;,&quot;ProduceID&quot;:&quot;BXXXX,&quot;ReservedCode1&quot;:&quot;CXXX&quot;,&quot;ContentPropagator&quot;:&quot;DXXX&quot;,&quot;PropagateID&quot;:&quot;EXXX&quot;,&quot;ReservedCode2&quot;:&quot;FXXXX&quot;}. Note: 1. The &quot;AIGC:&quot; prefix is required. Otherwise, the metadata cannot be added. The format differs from that of audio and video metadata. 2. The Base64 encoding must be in standard format with padding.</para>
                /// 
                /// <b>Example:</b>
                /// <para>QUlHQzp7IkxhYmVsIjoiMSIsIkNvbnRlbnRQcm9kdWNlciI6IkFYWFhYIiwiUHJvZHVjZUlEIjoiQlhYWFgsIlJlc2VydmVkQ29kZTEiOiJDWFhYIiwiQ29udGVudFByb3BhZ2F0b3IiOiJEWFhYIiwiUHJvcGFnYXRlSUQiOiJFWFhYIiwiUmVzZXJ2ZWRDb2RlMiI6IkZYWFhYIn0=</para>
                /// </summary>
                [NameInMap("XmpKvBase64")]
                [Validation(Required=false)]
                public string XmpKvBase64 { get; set; }

            }

            /// <summary>
            /// <para>The control parameters for image text watermarks.</para>
            /// </summary>
            [NameInMap("TextVisibleControl")]
            [Validation(Required=false)]
            public CreateWmEmbedTaskRequestImageControlTextVisibleControl TextVisibleControl { get; set; }
            public class CreateWmEmbedTaskRequestImageControlTextVisibleControl : TeaModel {
                /// <summary>
                /// <para>The clockwise rotation angle of the text watermark. Valid values: 0 to 360.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("Angle")]
                [Validation(Required=false)]
                public long? Angle { get; set; }

                /// <summary>
                /// <para>The font color of the text watermark. The format is 0xFFFFFF or #FFFFFF RGB color format. For example, 0x000000 or #000000 indicates black.</para>
                /// 
                /// <b>Example:</b>
                /// <para>#FF0000</para>
                /// </summary>
                [NameInMap("FontColor")]
                [Validation(Required=false)]
                public string FontColor { get; set; }

                /// <summary>
                /// <para>The font size of the text watermark. A larger value indicates a larger font.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("FontSize")]
                [Validation(Required=false)]
                public long? FontSize { get; set; }

                /// <summary>
                /// <para>This parameter takes effect when Mode is set to top-left, top-right, bottom-left, or bottom-right. The margin settings.</para>
                /// </summary>
                [NameInMap("Margin")]
                [Validation(Required=false)]
                public CreateWmEmbedTaskRequestImageControlTextVisibleControlMargin Margin { get; set; }
                public class CreateWmEmbedTaskRequestImageControlTextVisibleControlMargin : TeaModel {
                    /// <summary>
                    /// <para>This parameter takes effect when Mode is set to bottom-left or bottom-right. The bottom margin.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Bottom")]
                    [Validation(Required=false)]
                    public float? Bottom { get; set; }

                    /// <summary>
                    /// <para>This parameter takes effect when Mode is set to top-left or bottom-left. The left margin.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Left")]
                    [Validation(Required=false)]
                    public float? Left { get; set; }

                    /// <summary>
                    /// <para>This parameter takes effect when Mode is set to top-right or bottom-right. The right margin.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Right")]
                    [Validation(Required=false)]
                    public float? Right { get; set; }

                    /// <summary>
                    /// <para>This parameter takes effect when Mode is set to top-left or top-right. The top margin.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Top")]
                    [Validation(Required=false)]
                    public float? Top { get; set; }

                }

                /// <summary>
                /// <para>The display mode of the text watermark. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>pos</para>
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// <para>The opacity of the text watermark. Valid values: 1 to 255. A larger value indicates lower transparency.</para>
                /// 
                /// <b>Example:</b>
                /// <para>255</para>
                /// </summary>
                [NameInMap("Opacity")]
                [Validation(Required=false)]
                public int? Opacity { get; set; }

                /// <summary>
                /// <para>The horizontal anchor point of the text watermark.
                /// Valid values: 0 to 1. When (PosAx, PosAy) is set to (0, 0), the text is drawn with the upper-left corner as the anchor point. When the value is 0.5, the text is drawn at the center point. When (PosAx, PosAy) is set to (1, 1), the text is drawn with the lower-right corner as the anchor point.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PosAx")]
                [Validation(Required=false)]
                public float? PosAx { get; set; }

                /// <summary>
                /// <para>The vertical anchor point of the text watermark.
                /// Valid values: 0 to 1. When (PosAx, PosAy) is set to (0, 0), the text is drawn with the upper-left corner as the anchor point. When the value is 0.5, the text is drawn from the center point. When (PosAx, PosAy) is set to (1, 1), the text is drawn with the lower-right corner as the anchor point.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PosAy")]
                [Validation(Required=false)]
                public float? PosAy { get; set; }

                /// <summary>
                /// <para>This parameter takes effect when Mode is set to pos. Specifies the horizontal position of the text watermark in pixels, with the upper-left corner as the origin.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PosX")]
                [Validation(Required=false)]
                public long? PosX { get; set; }

                /// <summary>
                /// <para>This parameter takes effect when Mode is set to pos. Specifies the vertical position of the text watermark in pixels, with the upper-left corner as the origin.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PosY")]
                [Validation(Required=false)]
                public long? PosY { get; set; }

                /// <summary>
                /// <para>This parameter takes effect when Mode is set to repeat. Specifies the horizontal spacing for tiled text watermarks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("SpaceX")]
                [Validation(Required=false)]
                public long? SpaceX { get; set; }

                /// <summary>
                /// <para>This parameter takes effect when Mode is set to repeat. Specifies the vertical spacing for tiled text watermarks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SpaceY")]
                [Validation(Required=false)]
                public long? SpaceY { get; set; }

                /// <summary>
                /// <para>The visibility. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Visible")]
                [Validation(Required=false)]
                public bool? Visible { get; set; }

                /// <summary>
                /// <para>The text watermark content. The format is a UTF-8 string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>WatermarkText</para>
                /// </summary>
                [NameInMap("VisibleText")]
                [Validation(Required=false)]
                public string VisibleText { get; set; }

            }

        }

        /// <summary>
        /// <para>The image watermark parameter that specifies the expected JPEG compression quality factor of the output image. Default value: 95. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95</para>
        /// </summary>
        [NameInMap("ImageEmbedJpegQuality")]
        [Validation(Required=false)]
        public long? ImageEmbedJpegQuality { get; set; }

        /// <summary>
        /// <para>The image watermark parameter. A larger value indicates higher robustness but lower visual quality. Default value: 2. Valid values: 0 to 4.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ImageEmbedLevel")]
        [Validation(Required=false)]
        public long? ImageEmbedLevel { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable invisible watermark embedding. Default value: true.</para>
        /// </summary>
        [NameInMap("InvisibleEnable")]
        [Validation(Required=false)]
        public bool? InvisibleEnable { get; set; }

        /// <summary>
        /// <para>The short video watermark parameter that specifies the video bitrate. By default, the video bitrate is automatically obtained. You can use this parameter to forcibly specify the bitrate used during extraction. Typically, you do not need to set this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3000k</para>
        /// </summary>
        [NameInMap("VideoBitrate")]
        [Validation(Required=false)]
        public string VideoBitrate { get; set; }

        /// <summary>
        /// <para>The video control parameters.</para>
        /// </summary>
        [NameInMap("VideoControl")]
        [Validation(Required=false)]
        public CreateWmEmbedTaskRequestVideoControl VideoControl { get; set; }
        public class CreateWmEmbedTaskRequestVideoControl : TeaModel {
            /// <summary>
            /// <para>The metadata control parameters.</para>
            /// </summary>
            [NameInMap("MetadataControl")]
            [Validation(Required=false)]
            public CreateWmEmbedTaskRequestVideoControlMetadataControl MetadataControl { get; set; }
            public class CreateWmEmbedTaskRequestVideoControlMetadataControl : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable this feature.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The metadata in Base64 format. Encode the following string in Base64 format: AIGC={&quot;Label&quot;:&quot;1&quot;,&quot;ContentProducer&quot;:&quot;AXXXX&quot;,&quot;ProduceID&quot;:&quot;BXXXX,&quot;ReservedCode1&quot;:&quot;CXXX&quot;,&quot;ContentPropagator&quot;:&quot;DXXX&quot;,&quot;PropagateID&quot;:&quot;EXXX&quot;,&quot;ReservedCode2&quot;:&quot;FXXXX&quot;}. Note: 1. The &quot;AIGC=&quot; prefix is required. Otherwise, the metadata cannot be added. The prefix differs from that of image metadata. 2. The Base64 encoding must be in standard format with padding.</para>
                /// 
                /// <b>Example:</b>
                /// <para>QUlHQz17IkxhYmVsIjoiMSIsIkNvbnRlbnRQcm9kdWNlciI6IkFYWFhYIiwiUHJvZHVjZUlEIjoiQlhYWFgsIlJlc2VydmVkQ29kZTEiOiJDWFhYIiwiQ29udGVudFByb3BhZ2F0b3IiOiJEWFhYIiwiUHJvcGFnYXRlSUQiOiJFWFhYIiwiUmVzZXJ2ZWRDb2RlMiI6IkZYWFhYIn0=</para>
                /// </summary>
                [NameInMap("XmpKvBase64")]
                [Validation(Required=false)]
                public string XmpKvBase64 { get; set; }

            }

            /// <summary>
            /// <para>The control parameters for video text watermarks.</para>
            /// </summary>
            [NameInMap("TextVisibleControl")]
            [Validation(Required=false)]
            public CreateWmEmbedTaskRequestVideoControlTextVisibleControl TextVisibleControl { get; set; }
            public class CreateWmEmbedTaskRequestVideoControlTextVisibleControl : TeaModel {
                /// <summary>
                /// <para>The font color of the text watermark. The format is 0xFFFFFF or #FFFFFF RGB color format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>#FF0000</para>
                /// </summary>
                [NameInMap("FontColor")]
                [Validation(Required=false)]
                public string FontColor { get; set; }

                /// <summary>
                /// <para>The font size. Valid values: <b>0</b> to <b>72</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("FontSize")]
                [Validation(Required=false)]
                public int? FontSize { get; set; }

                /// <summary>
                /// <para>This parameter takes effect when Mode is set to top-left, top-right, bottom-left, or bottom-right. The margin settings.</para>
                /// </summary>
                [NameInMap("Margin")]
                [Validation(Required=false)]
                public CreateWmEmbedTaskRequestVideoControlTextVisibleControlMargin Margin { get; set; }
                public class CreateWmEmbedTaskRequestVideoControlTextVisibleControlMargin : TeaModel {
                    /// <summary>
                    /// <para>This parameter takes effect when Mode is set to bottom-left or bottom-right. The bottom margin.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Bottom")]
                    [Validation(Required=false)]
                    public int? Bottom { get; set; }

                    /// <summary>
                    /// <para>This parameter takes effect when Mode is set to top-right or bottom-right. The right margin.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Right")]
                    [Validation(Required=false)]
                    public int? Right { get; set; }

                }

                /// <summary>
                /// <para>The display mode of the text watermark. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>pos</b>: fixed position, with the upper-left corner as the origin.</description></item>
                /// <item><description><b>bottom-right</b>: lower-left mode.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>bottom-right</para>
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// <para>The opacity of the text watermark. Valid values: 1 to 255. A larger value indicates lower transparency.</para>
                /// 
                /// <b>Example:</b>
                /// <para>255</para>
                /// </summary>
                [NameInMap("Opacity")]
                [Validation(Required=false)]
                public int? Opacity { get; set; }

                /// <summary>
                /// <para>This parameter takes effect when Mode is set to pos. Specifies the horizontal position of the visible watermark in pixels, with the upper-left corner as the origin.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("PosX")]
                [Validation(Required=false)]
                public int? PosX { get; set; }

                /// <summary>
                /// <para>This parameter takes effect when Mode is set to pos. Specifies the vertical position of the visible watermark in pixels, with the upper-left corner as the origin.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("PosY")]
                [Validation(Required=false)]
                public int? PosY { get; set; }

                /// <summary>
                /// <para>The visibility. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("Visible")]
                [Validation(Required=false)]
                public bool? Visible { get; set; }

                /// <summary>
                /// <para>The text watermark content. The format is a UTF-8 string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>WatermarkTest</para>
                /// </summary>
                [NameInMap("VisibleText")]
                [Validation(Required=false)]
                public string VisibleText { get; set; }

            }

        }

        /// <summary>
        /// <para>Video watermark parameter. Specifies whether to use the long video watermark SDK. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The long video watermark SDK is used.</description></item>
        /// <item><description><b>false</b>: The long video watermark SDK is not used.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("VideoIsLong")]
        [Validation(Required=false)]
        public bool? VideoIsLong { get; set; }

        /// <summary>
        /// <para>The watermark information in Base64-encoded string format. If this parameter is set, WmInfoUint cannot be set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aGVsbG8gc2F*****</para>
        /// </summary>
        [NameInMap("WmInfoBytesB64")]
        [Validation(Required=false)]
        public string WmInfoBytesB64 { get; set; }

        /// <summary>
        /// <para>The bit width of the watermark information capacity. Default value: 32. This parameter must be consistent between embedding and extraction. For example, if the 40-bit SDK is used for embedding, set this parameter to 40 during extraction as well.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("WmInfoSize")]
        [Validation(Required=false)]
        public long? WmInfoSize { get; set; }

        /// <summary>
        /// <para>The watermark information in decimal number format. If this parameter is set, WmInfoBytesB64 cannot be set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123***</para>
        /// </summary>
        [NameInMap("WmInfoUint")]
        [Validation(Required=false)]
        public string WmInfoUint { get; set; }

        /// <summary>
        /// <para>The watermark type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PureDocument</b>: document watermark.</description></item>
        /// <item><description><b>PureImage</b>: image watermark.</description></item>
        /// <item><description><b>PureAudio</b>: audio watermark.</description></item>
        /// <item><description><b>PureVideo</b>: video watermark.</description></item>
        /// <item><description><b>AigcDocument</b>: AIGC document watermark.</description></item>
        /// <item><description><b>AigcImage</b>: AIGC image watermark.</description></item>
        /// <item><description><b>AigcAudio</b>: AIGC audio watermark.</description></item>
        /// <item><description><b>AigcVideo</b>: AIGC video watermark.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PureDocument</para>
        /// </summary>
        [NameInMap("WmType")]
        [Validation(Required=false)]
        public string WmType { get; set; }

    }

}
