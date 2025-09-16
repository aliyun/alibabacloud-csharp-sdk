// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateWmEmbedTaskRequest : TeaModel {
        [NameInMap("AudioControl")]
        [Validation(Required=false)]
        public CreateWmEmbedTaskRequestAudioControl AudioControl { get; set; }
        public class CreateWmEmbedTaskRequestAudioControl : TeaModel {
            [NameInMap("MetadataControl")]
            [Validation(Required=false)]
            public CreateWmEmbedTaskRequestAudioControlMetadataControl MetadataControl { get; set; }
            public class CreateWmEmbedTaskRequestAudioControlMetadataControl : TeaModel {
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                [NameInMap("XmpKvBase64")]
                [Validation(Required=false)]
                public string XmpKvBase64 { get; set; }

            }

        }

        [NameInMap("CsvControl")]
        [Validation(Required=false)]
        public CreateWmEmbedTaskRequestCsvControl CsvControl { get; set; }
        public class CreateWmEmbedTaskRequestCsvControl : TeaModel {
            [NameInMap("EmbedBitsNumberInEachTime")]
            [Validation(Required=false)]
            public long? EmbedBitsNumberInEachTime { get; set; }

            [NameInMap("EmbedColumn")]
            [Validation(Required=false)]
            public long? EmbedColumn { get; set; }

            [NameInMap("EmbedDensity")]
            [Validation(Required=false)]
            public string EmbedDensity { get; set; }

            [NameInMap("EmbedPrecision")]
            [Validation(Required=false)]
            public long? EmbedPrecision { get; set; }

            [NameInMap("EmbedTimePosition")]
            [Validation(Required=false)]
            public string EmbedTimePosition { get; set; }

            [NameInMap("Method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            [NameInMap("TimeFormat")]
            [Validation(Required=false)]
            public string TimeFormat { get; set; }

        }

        [NameInMap("DocumentControl")]
        [Validation(Required=false)]
        public CreateWmEmbedTaskRequestDocumentControl DocumentControl { get; set; }
        public class CreateWmEmbedTaskRequestDocumentControl : TeaModel {
            [NameInMap("BackgroundControl")]
            [Validation(Required=false)]
            public CreateWmEmbedTaskRequestDocumentControlBackgroundControl BackgroundControl { get; set; }
            public class CreateWmEmbedTaskRequestDocumentControlBackgroundControl : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("BgAddInvisible")]
                [Validation(Required=false)]
                public bool? BgAddInvisible { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("BgAddVisible")]
                [Validation(Required=false)]
                public bool? BgAddVisible { get; set; }

                [NameInMap("BgInvisibleControl")]
                [Validation(Required=false)]
                public CreateWmEmbedTaskRequestDocumentControlBackgroundControlBgInvisibleControl BgInvisibleControl { get; set; }
                public class CreateWmEmbedTaskRequestDocumentControlBackgroundControlBgInvisibleControl : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Opacity")]
                    [Validation(Required=false)]
                    public long? Opacity { get; set; }

                }

                [NameInMap("BgVisibleControl")]
                [Validation(Required=false)]
                public CreateWmEmbedTaskRequestDocumentControlBackgroundControlBgVisibleControl BgVisibleControl { get; set; }
                public class CreateWmEmbedTaskRequestDocumentControlBackgroundControlBgVisibleControl : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("Angle")]
                    [Validation(Required=false)]
                    public long? Angle { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0x000000</para>
                    /// </summary>
                    [NameInMap("FontColor")]
                    [Validation(Required=false)]
                    public string FontColor { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("FontSize")]
                    [Validation(Required=false)]
                    public long? FontSize { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("HorizontalNumber")]
                    [Validation(Required=false)]
                    public long? HorizontalNumber { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>pos</para>
                    /// </summary>
                    [NameInMap("Mode")]
                    [Validation(Required=false)]
                    public string Mode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Opacity")]
                    [Validation(Required=false)]
                    public long? Opacity { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.5</para>
                    /// </summary>
                    [NameInMap("PosX")]
                    [Validation(Required=false)]
                    public string PosX { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.5</para>
                    /// </summary>
                    [NameInMap("PosY")]
                    [Validation(Required=false)]
                    public string PosY { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("VerticalNumber")]
                    [Validation(Required=false)]
                    public long? VerticalNumber { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>hello ****</para>
                    /// </summary>
                    [NameInMap("VisibleText")]
                    [Validation(Required=false)]
                    public string VisibleText { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("InvisibleAntiAllCopy")]
            [Validation(Required=false)]
            public bool? InvisibleAntiAllCopy { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("InvisibleAntiTextCopy")]
            [Validation(Required=false)]
            public bool? InvisibleAntiTextCopy { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/abc****.pdf">https://example.com/abc****.pdf</a></para>
        /// </summary>
        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc****.pdf</para>
        /// </summary>
        [NameInMap("Filename")]
        [Validation(Required=false)]
        public string Filename { get; set; }

        [NameInMap("ImageControl")]
        [Validation(Required=false)]
        public CreateWmEmbedTaskRequestImageControl ImageControl { get; set; }
        public class CreateWmEmbedTaskRequestImageControl : TeaModel {
            [NameInMap("LogoVisibleControl")]
            [Validation(Required=false)]
            public CreateWmEmbedTaskRequestImageControlLogoVisibleControl LogoVisibleControl { get; set; }
            public class CreateWmEmbedTaskRequestImageControlLogoVisibleControl : TeaModel {
                [NameInMap("Angle")]
                [Validation(Required=false)]
                public long? Angle { get; set; }

                [NameInMap("Enhance")]
                [Validation(Required=false)]
                public bool? Enhance { get; set; }

                [NameInMap("LogoBase64")]
                [Validation(Required=false)]
                public string LogoBase64 { get; set; }

                [NameInMap("Margin")]
                [Validation(Required=false)]
                public CreateWmEmbedTaskRequestImageControlLogoVisibleControlMargin Margin { get; set; }
                public class CreateWmEmbedTaskRequestImageControlLogoVisibleControlMargin : TeaModel {
                    [NameInMap("Bottom")]
                    [Validation(Required=false)]
                    public float? Bottom { get; set; }

                    [NameInMap("Left")]
                    [Validation(Required=false)]
                    public float? Left { get; set; }

                    [NameInMap("Right")]
                    [Validation(Required=false)]
                    public float? Right { get; set; }

                    [NameInMap("Top")]
                    [Validation(Required=false)]
                    public float? Top { get; set; }

                }

                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                [NameInMap("Opacity")]
                [Validation(Required=false)]
                public int? Opacity { get; set; }

                [NameInMap("PosAx")]
                [Validation(Required=false)]
                public float? PosAx { get; set; }

                [NameInMap("PosAy")]
                [Validation(Required=false)]
                public float? PosAy { get; set; }

                [NameInMap("PosX")]
                [Validation(Required=false)]
                public long? PosX { get; set; }

                [NameInMap("PosY")]
                [Validation(Required=false)]
                public long? PosY { get; set; }

                [NameInMap("SpaceX")]
                [Validation(Required=false)]
                public long? SpaceX { get; set; }

                [NameInMap("SpaceY")]
                [Validation(Required=false)]
                public long? SpaceY { get; set; }

                [NameInMap("Visible")]
                [Validation(Required=false)]
                public bool? Visible { get; set; }

            }

            [NameInMap("MetadataControl")]
            [Validation(Required=false)]
            public CreateWmEmbedTaskRequestImageControlMetadataControl MetadataControl { get; set; }
            public class CreateWmEmbedTaskRequestImageControlMetadataControl : TeaModel {
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                [NameInMap("XmpKvBase64")]
                [Validation(Required=false)]
                public string XmpKvBase64 { get; set; }

            }

            [NameInMap("TextVisibleControl")]
            [Validation(Required=false)]
            public CreateWmEmbedTaskRequestImageControlTextVisibleControl TextVisibleControl { get; set; }
            public class CreateWmEmbedTaskRequestImageControlTextVisibleControl : TeaModel {
                [NameInMap("Angle")]
                [Validation(Required=false)]
                public long? Angle { get; set; }

                [NameInMap("FontColor")]
                [Validation(Required=false)]
                public string FontColor { get; set; }

                [NameInMap("FontSize")]
                [Validation(Required=false)]
                public long? FontSize { get; set; }

                [NameInMap("Margin")]
                [Validation(Required=false)]
                public CreateWmEmbedTaskRequestImageControlTextVisibleControlMargin Margin { get; set; }
                public class CreateWmEmbedTaskRequestImageControlTextVisibleControlMargin : TeaModel {
                    [NameInMap("Bottom")]
                    [Validation(Required=false)]
                    public float? Bottom { get; set; }

                    [NameInMap("Left")]
                    [Validation(Required=false)]
                    public float? Left { get; set; }

                    [NameInMap("Right")]
                    [Validation(Required=false)]
                    public float? Right { get; set; }

                    [NameInMap("Top")]
                    [Validation(Required=false)]
                    public float? Top { get; set; }

                }

                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                [NameInMap("Opacity")]
                [Validation(Required=false)]
                public int? Opacity { get; set; }

                [NameInMap("PosAx")]
                [Validation(Required=false)]
                public float? PosAx { get; set; }

                [NameInMap("PosAy")]
                [Validation(Required=false)]
                public float? PosAy { get; set; }

                [NameInMap("PosX")]
                [Validation(Required=false)]
                public long? PosX { get; set; }

                [NameInMap("PosY")]
                [Validation(Required=false)]
                public long? PosY { get; set; }

                [NameInMap("SpaceX")]
                [Validation(Required=false)]
                public long? SpaceX { get; set; }

                [NameInMap("SpaceY")]
                [Validation(Required=false)]
                public long? SpaceY { get; set; }

                [NameInMap("Visible")]
                [Validation(Required=false)]
                public bool? Visible { get; set; }

                [NameInMap("VisibleText")]
                [Validation(Required=false)]
                public string VisibleText { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>95</para>
        /// </summary>
        [NameInMap("ImageEmbedJpegQuality")]
        [Validation(Required=false)]
        public long? ImageEmbedJpegQuality { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ImageEmbedLevel")]
        [Validation(Required=false)]
        public long? ImageEmbedLevel { get; set; }

        [NameInMap("InvisibleEnable")]
        [Validation(Required=false)]
        public bool? InvisibleEnable { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3000k</para>
        /// </summary>
        [NameInMap("VideoBitrate")]
        [Validation(Required=false)]
        public string VideoBitrate { get; set; }

        [NameInMap("VideoControl")]
        [Validation(Required=false)]
        public CreateWmEmbedTaskRequestVideoControl VideoControl { get; set; }
        public class CreateWmEmbedTaskRequestVideoControl : TeaModel {
            [NameInMap("MetadataControl")]
            [Validation(Required=false)]
            public CreateWmEmbedTaskRequestVideoControlMetadataControl MetadataControl { get; set; }
            public class CreateWmEmbedTaskRequestVideoControlMetadataControl : TeaModel {
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                [NameInMap("XmpKvBase64")]
                [Validation(Required=false)]
                public string XmpKvBase64 { get; set; }

            }

            [NameInMap("TextVisibleControl")]
            [Validation(Required=false)]
            public CreateWmEmbedTaskRequestVideoControlTextVisibleControl TextVisibleControl { get; set; }
            public class CreateWmEmbedTaskRequestVideoControlTextVisibleControl : TeaModel {
                [NameInMap("FontColor")]
                [Validation(Required=false)]
                public string FontColor { get; set; }

                [NameInMap("FontSize")]
                [Validation(Required=false)]
                public int? FontSize { get; set; }

                [NameInMap("Margin")]
                [Validation(Required=false)]
                public CreateWmEmbedTaskRequestVideoControlTextVisibleControlMargin Margin { get; set; }
                public class CreateWmEmbedTaskRequestVideoControlTextVisibleControlMargin : TeaModel {
                    [NameInMap("Bottom")]
                    [Validation(Required=false)]
                    public int? Bottom { get; set; }

                    [NameInMap("Right")]
                    [Validation(Required=false)]
                    public int? Right { get; set; }

                }

                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                [NameInMap("Opacity")]
                [Validation(Required=false)]
                public int? Opacity { get; set; }

                [NameInMap("PosX")]
                [Validation(Required=false)]
                public int? PosX { get; set; }

                [NameInMap("PosY")]
                [Validation(Required=false)]
                public int? PosY { get; set; }

                [NameInMap("Visible")]
                [Validation(Required=false)]
                public bool? Visible { get; set; }

                [NameInMap("VisibleText")]
                [Validation(Required=false)]
                public string VisibleText { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("VideoIsLong")]
        [Validation(Required=false)]
        public bool? VideoIsLong { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>aGVsbG8gc2F*****</para>
        /// </summary>
        [NameInMap("WmInfoBytesB64")]
        [Validation(Required=false)]
        public string WmInfoBytesB64 { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("WmInfoSize")]
        [Validation(Required=false)]
        public long? WmInfoSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123***</para>
        /// </summary>
        [NameInMap("WmInfoUint")]
        [Validation(Required=false)]
        public string WmInfoUint { get; set; }

        /// <summary>
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
