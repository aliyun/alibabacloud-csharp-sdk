// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateWmBaseImageRequest : TeaModel {
        /// <summary>
        /// <para>Height of the watermark image, in pixels. Valid values: 100 to 5000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1080</para>
        /// </summary>
        [NameInMap("Height")]
        [Validation(Required=false)]
        public int? Height { get; set; }

        /// <summary>
        /// <para>Image watermark control parameters.</para>
        /// </summary>
        [NameInMap("ImageControl")]
        [Validation(Required=false)]
        public CreateWmBaseImageRequestImageControl ImageControl { get; set; }
        public class CreateWmBaseImageRequestImageControl : TeaModel {
            /// <summary>
            /// <para>Logo watermark control parameters.</para>
            /// </summary>
            [NameInMap("LogoVisibleControl")]
            [Validation(Required=false)]
            public CreateWmBaseImageRequestImageControlLogoVisibleControl LogoVisibleControl { get; set; }
            public class CreateWmBaseImageRequestImageControlLogoVisibleControl : TeaModel {
                /// <summary>
                /// <para>The clockwise rotation angle of the logo watermark text. Valid values: 1 to 360.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("Angle")]
                [Validation(Required=false)]
                public long? Angle { get; set; }

                /// <summary>
                /// <para>Enable enhanced visible logo watermark. If enabled, the logo is converted into a watermark and added to the image.</para>
                /// </summary>
                [NameInMap("Enhance")]
                [Validation(Required=false)]
                public bool? Enhance { get; set; }

                /// <summary>
                /// <para>Base64-encoded logo watermark. The logo file must be a PNG image encoded in Base64 format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>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</para>
                /// </summary>
                [NameInMap("LogoBase64")]
                [Validation(Required=false)]
                public string LogoBase64 { get; set; }

                /// <summary>
                /// <para>Applies when Mode is top-left, top-right, bottom-left, or bottom-right. Specifies the margin.</para>
                /// </summary>
                [NameInMap("Margin")]
                [Validation(Required=false)]
                public CreateWmBaseImageRequestImageControlLogoVisibleControlMargin Margin { get; set; }
                public class CreateWmBaseImageRequestImageControlLogoVisibleControlMargin : TeaModel {
                    /// <summary>
                    /// <para>Applies when Mode is bottom-left or bottom-right. The bottom margin.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Bottom")]
                    [Validation(Required=false)]
                    public float? Bottom { get; set; }

                    /// <summary>
                    /// <para>Applies when Mode is top-left or bottom-left. The left margin.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Left")]
                    [Validation(Required=false)]
                    public float? Left { get; set; }

                    /// <summary>
                    /// <para>The right margin. This parameter is valid only when Mode is set to top-right or bottom-right.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Right")]
                    [Validation(Required=false)]
                    public float? Right { get; set; }

                    /// <summary>
                    /// <para>Applies when Mode is top-left or top-right. The top margin.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Top")]
                    [Validation(Required=false)]
                    public float? Top { get; set; }

                }

                /// <summary>
                /// <para>The display mode for the logo watermark. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>pos</b>: Fixed position pattern.</para>
                /// </description></item>
                /// <item><description><para><b>repeat</b>: Tile pattern.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>pos</para>
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// <para>Logo watermark opacity. Valid values: 1 to 255. A higher value means lower transparency.</para>
                /// 
                /// <b>Example:</b>
                /// <para>255</para>
                /// </summary>
                [NameInMap("Opacity")]
                [Validation(Required=false)]
                public int? Opacity { get; set; }

                /// <summary>
                /// <para>The horizontal anchor point for the logo watermark. Valid values: 0 to 1. When (PosAx, PosAy) is (0, 0), the watermark anchors to the top-left corner of the text. When the value is 0.5, the watermark anchors to the centroid of the text. When (PosAx, PosAy) is (1, 1), the watermark anchors to the bottom-right corner of the text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PosAx")]
                [Validation(Required=false)]
                public float? PosAx { get; set; }

                /// <summary>
                /// <para>The vertical anchor point for the logo watermark. The value ranges from 0 to 1. The coordinates (PosAx, PosAy) define the anchor point on the watermark. For example, (0,0) represents the top-left corner, (0.5, 0.5) represents the centroid, and (1,1) represents the bottom-right corner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PosAy")]
                [Validation(Required=false)]
                public float? PosAy { get; set; }

                /// <summary>
                /// <para>Takes effect when Mode is set to pos. This parameter controls the horizontal position of a visible watermark, using pixel coordinates with the top-left corner as the origin.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PosX")]
                [Validation(Required=false)]
                public long? PosX { get; set; }

                /// <summary>
                /// <para>Specifies the vertical position of the visible watermark in pixels. The top-left corner is the origin. This parameter is valid only when Mode is set to pos.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PosY")]
                [Validation(Required=false)]
                public long? PosY { get; set; }

                /// <summary>
                /// <para>This parameter takes effect when Mode is set to repeat. It specifies the horizontal pitch for the tiled visible watermark.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("SpaceX")]
                [Validation(Required=false)]
                public long? SpaceX { get; set; }

                /// <summary>
                /// <para>Applies only when Mode is set to repeat. Controls the vertical pitch between tiled visible watermarks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("SpaceY")]
                [Validation(Required=false)]
                public long? SpaceY { get; set; }

                /// <summary>
                /// <para>Visibility:</para>
                /// <para><b>true</b>: Display</para>
                /// <para><b>false</b>: Hide</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Visible")]
                [Validation(Required=false)]
                public bool? Visible { get; set; }

            }

            /// <summary>
            /// <para>Text watermark control parameters.</para>
            /// </summary>
            [NameInMap("TextVisibleControl")]
            [Validation(Required=false)]
            public CreateWmBaseImageRequestImageControlTextVisibleControl TextVisibleControl { get; set; }
            public class CreateWmBaseImageRequestImageControlTextVisibleControl : TeaModel {
                /// <summary>
                /// <para>Rotation angle of the text watermark, in degrees clockwise. Valid values: 0 to 360.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("Angle")]
                [Validation(Required=false)]
                public long? Angle { get; set; }

                /// <summary>
                /// <para>Text watermark color. Format: RGB, such as 0xFFFFFF or #FFFFFF. For example, 0x000000 or #000000 means black.</para>
                /// 
                /// <b>Example:</b>
                /// <para>#FF0000</para>
                /// </summary>
                [NameInMap("FontColor")]
                [Validation(Required=false)]
                public string FontColor { get; set; }

                /// <summary>
                /// <para>Font size of the text watermark. Larger values produce larger fonts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("FontSize")]
                [Validation(Required=false)]
                public long? FontSize { get; set; }

                /// <summary>
                /// <para>Takes effect only when Mode is top-left, top-right, bottom-left, or bottom-right. Margin settings.</para>
                /// </summary>
                [NameInMap("Margin")]
                [Validation(Required=false)]
                public CreateWmBaseImageRequestImageControlTextVisibleControlMargin Margin { get; set; }
                public class CreateWmBaseImageRequestImageControlTextVisibleControlMargin : TeaModel {
                    /// <summary>
                    /// <para>Takes effect only when Mode is bottom-left or bottom-right. Bottom margin.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Bottom")]
                    [Validation(Required=false)]
                    public float? Bottom { get; set; }

                    /// <summary>
                    /// <para>Takes effect only when Mode is top-left or bottom-left. Left margin.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Left")]
                    [Validation(Required=false)]
                    public float? Left { get; set; }

                    /// <summary>
                    /// <para>Takes effect only when Mode is top-right or bottom-right. Right margin.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Right")]
                    [Validation(Required=false)]
                    public float? Right { get; set; }

                    /// <summary>
                    /// <para>Takes effect only when Mode is top-left or top-right. Top margin.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Top")]
                    [Validation(Required=false)]
                    public float? Top { get; set; }

                }

                /// <summary>
                /// <para>Text watermark display mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>pos</b>: Fixed position mode.</para>
                /// </description></item>
                /// <item><description><para><b>repeat</b>: Tiled mode.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>pos</para>
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// <para>Text watermark opacity. Valid values: 1 to 255. Higher values mean less transparency.</para>
                /// 
                /// <b>Example:</b>
                /// <para>255</para>
                /// </summary>
                [NameInMap("Opacity")]
                [Validation(Required=false)]
                public int? Opacity { get; set; }

                /// <summary>
                /// <para>Horizontal anchor point for the text watermark. Valid values: 0 to 1. When (PosAx, PosAy) is (0, 0), the top-left corner of the text is used as the anchor point. When it is 0.5, the center point is used. When it is (1, 1), the bottom-right corner is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PosAx")]
                [Validation(Required=false)]
                public float? PosAx { get; set; }

                /// <summary>
                /// <para>Vertical anchor point for the text watermark. Valid values: 0 to 1. When (PosAx, PosAy) is (0, 0), the top-left corner of the text is used as the anchor point. When it is 0.5, the center point is used. When it is (1, 1), the bottom-right corner is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PosAy")]
                [Validation(Required=false)]
                public float? PosAy { get; set; }

                /// <summary>
                /// <para>Takes effect only when Mode is pos. Horizontal position of the text watermark, measured in pixels from the top-left corner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PosX")]
                [Validation(Required=false)]
                public long? PosX { get; set; }

                /// <summary>
                /// <para>Takes effect only when Mode is pos. Vertical position of the text watermark, measured in pixels from the top-left corner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PosY")]
                [Validation(Required=false)]
                public long? PosY { get; set; }

                /// <summary>
                /// <para>Takes effect only when Mode is repeat. Horizontal spacing between repeated text watermarks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("SpaceX")]
                [Validation(Required=false)]
                public long? SpaceX { get; set; }

                /// <summary>
                /// <para>Takes effect only when Mode is repeat. Vertical spacing between repeated text watermarks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SpaceY")]
                [Validation(Required=false)]
                public long? SpaceY { get; set; }

                /// <summary>
                /// <para>Visibility setting:</para>
                /// <para>true: Show the watermark.</para>
                /// <para>false: Hide the watermark.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Visible")]
                [Validation(Required=false)]
                public bool? Visible { get; set; }

                /// <summary>
                /// <para>Text watermark content. Format: UTF-8 string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>水印文本</para>
                /// </summary>
                [NameInMap("VisibleText")]
                [Validation(Required=false)]
                public string VisibleText { get; set; }

            }

        }

        /// <summary>
        /// <para>Opacity of the watermark image. Valid values: 1 to 255. Higher values mean lower transparency.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>255</para>
        /// </summary>
        [NameInMap("Opacity")]
        [Validation(Required=false)]
        public int? Opacity { get; set; }

        /// <summary>
        /// <para>Scaling factor of the watermark image.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Scale")]
        [Validation(Required=false)]
        public int? Scale { get; set; }

        /// <summary>
        /// <para>Width of the watermark image, in pixels. Valid values: 100 to 5000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1920</para>
        /// </summary>
        [NameInMap("Width")]
        [Validation(Required=false)]
        public int? Width { get; set; }

        /// <summary>
        /// <para>Base64-encoded watermark information. Length: 1 to 300 characters. Do not set this parameter if you set WmInfoUint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aGVsbG8gc2F*****</para>
        /// </summary>
        [NameInMap("WmInfoBytesB64")]
        [Validation(Required=false)]
        public string WmInfoBytesB64 { get; set; }

        /// <summary>
        /// <para>Bit width of the watermark information. Default value: 32. This value must be the same during embedding and extraction. For example, if you use a 40-bit SDK to embed the watermark, set this value to 40 when extracting it.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("WmInfoSize")]
        [Validation(Required=false)]
        public long? WmInfoSize { get; set; }

        /// <summary>
        /// <para>Decimal-form watermark information. Do not set this parameter if you set WmInfoBytesB64.</para>
        /// <para>The valid range depends on the WmInfoSize value:</para>
        /// <list type="bullet">
        /// <item><description><para>If WmInfoSize is <b>32</b>, the valid range is 1 to 4294967295.</para>
        /// </description></item>
        /// <item><description><para>If WmInfoSize is <b>40</b>, the valid range is 1 to 1099511627775.</para>
        /// </description></item>
        /// <item><description><para>If WmInfoSize is <b>64</b>, the valid range is 1 to 18446744073709551615.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>12*****</para>
        /// </summary>
        [NameInMap("WmInfoUint")]
        [Validation(Required=false)]
        public string WmInfoUint { get; set; }

        /// <summary>
        /// <para>Watermark type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>PureWebappInvisible</b>: Web watermark.</para>
        /// </description></item>
        /// <item><description><para><b>PureAppInvisible</b>: App watermark.</para>
        /// </description></item>
        /// <item><description><para><b>PureScreenInvisible</b>: Screen watermark.</para>
        /// </description></item>
        /// <item><description><para><b>AigcWebappInvisible</b>: AIGC web watermark.</para>
        /// </description></item>
        /// <item><description><para><b>AigcAppInvisible</b>: AIGC app watermark.</para>
        /// </description></item>
        /// <item><description><para><b>AigcScreenInvisible</b>: AIGC screen watermark.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PureWebappInvisible</para>
        /// </summary>
        [NameInMap("WmType")]
        [Validation(Required=false)]
        public string WmType { get; set; }

        /// <summary>
        /// <para>Comments.</para>
        /// 
        /// <b>Example:</b>
        /// <para>备注</para>
        /// </summary>
        [NameInMap("comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

    }

}
