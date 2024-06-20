// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class UpdateStreamingOutRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        [NameInMap("ClockWidgets")]
        [Validation(Required=false)]
        public List<UpdateStreamingOutRequestClockWidgets> ClockWidgets { get; set; }
        public class UpdateStreamingOutRequestClockWidgets : TeaModel {
            [NameInMap("Alpha")]
            [Validation(Required=false)]
            public double? Alpha { get; set; }

            [NameInMap("BoxAlpha")]
            [Validation(Required=false)]
            public double? BoxAlpha { get; set; }

            [NameInMap("BoxBorderw")]
            [Validation(Required=false)]
            public int? BoxBorderw { get; set; }

            [NameInMap("BoxColor")]
            [Validation(Required=false)]
            public UpdateStreamingOutRequestClockWidgetsBoxColor BoxColor { get; set; }
            public class UpdateStreamingOutRequestClockWidgetsBoxColor : TeaModel {
                [NameInMap("B")]
                [Validation(Required=false)]
                public int? B { get; set; }

                [NameInMap("G")]
                [Validation(Required=false)]
                public int? G { get; set; }

                [NameInMap("R")]
                [Validation(Required=false)]
                public int? R { get; set; }

            }

            [NameInMap("Font")]
            [Validation(Required=false)]
            public int? Font { get; set; }

            [NameInMap("FontColor")]
            [Validation(Required=false)]
            public UpdateStreamingOutRequestClockWidgetsFontColor FontColor { get; set; }
            public class UpdateStreamingOutRequestClockWidgetsFontColor : TeaModel {
                [NameInMap("B")]
                [Validation(Required=false)]
                public int? B { get; set; }

                [NameInMap("G")]
                [Validation(Required=false)]
                public int? G { get; set; }

                [NameInMap("R")]
                [Validation(Required=false)]
                public int? R { get; set; }

            }

            [NameInMap("FontSize")]
            [Validation(Required=false)]
            public int? FontSize { get; set; }

            [NameInMap("HasBox")]
            [Validation(Required=false)]
            public bool? HasBox { get; set; }

            [NameInMap("Layer")]
            [Validation(Required=false)]
            public int? Layer { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("X")]
            [Validation(Required=false)]
            public double? X { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Y")]
            [Validation(Required=false)]
            public double? Y { get; set; }

            [NameInMap("Zone")]
            [Validation(Required=false)]
            public int? Zone { get; set; }

        }

        [NameInMap("Images")]
        [Validation(Required=false)]
        public List<UpdateStreamingOutRequestImages> Images { get; set; }
        public class UpdateStreamingOutRequestImages : TeaModel {
            [NameInMap("Alpha")]
            [Validation(Required=false)]
            public double? Alpha { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public double? Height { get; set; }

            [NameInMap("ImageCropMode")]
            [Validation(Required=false)]
            public int? ImageCropMode { get; set; }

            [NameInMap("Layer")]
            [Validation(Required=false)]
            public int? Layer { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public double? Width { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("X")]
            [Validation(Required=false)]
            public double? X { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Y")]
            [Validation(Required=false)]
            public double? Y { get; set; }

        }

        [NameInMap("Panes")]
        [Validation(Required=false)]
        public List<UpdateStreamingOutRequestPanes> Panes { get; set; }
        public class UpdateStreamingOutRequestPanes : TeaModel {
            [NameInMap("Images")]
            [Validation(Required=false)]
            public List<UpdateStreamingOutRequestPanesImages> Images { get; set; }
            public class UpdateStreamingOutRequestPanesImages : TeaModel {
                [NameInMap("Alpha")]
                [Validation(Required=false)]
                public double? Alpha { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public double? Height { get; set; }

                [NameInMap("Layer")]
                [Validation(Required=false)]
                public int? Layer { get; set; }

                [NameInMap("PaneImageCropMode")]
                [Validation(Required=false)]
                public int? PaneImageCropMode { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public double? Width { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public double? X { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public double? Y { get; set; }

            }

            [NameInMap("PaneCropMode")]
            [Validation(Required=false)]
            public int? PaneCropMode { get; set; }

            [NameInMap("PaneId")]
            [Validation(Required=false)]
            public int? PaneId { get; set; }

            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            [NameInMap("Texts")]
            [Validation(Required=false)]
            public List<UpdateStreamingOutRequestPanesTexts> Texts { get; set; }
            public class UpdateStreamingOutRequestPanesTexts : TeaModel {
                [NameInMap("Alpha")]
                [Validation(Required=false)]
                public double? Alpha { get; set; }

                [NameInMap("BoxAlpha")]
                [Validation(Required=false)]
                public double? BoxAlpha { get; set; }

                [NameInMap("BoxBorderw")]
                [Validation(Required=false)]
                public int? BoxBorderw { get; set; }

                [NameInMap("BoxColor")]
                [Validation(Required=false)]
                public UpdateStreamingOutRequestPanesTextsBoxColor BoxColor { get; set; }
                public class UpdateStreamingOutRequestPanesTextsBoxColor : TeaModel {
                    [NameInMap("B")]
                    [Validation(Required=false)]
                    public int? B { get; set; }

                    [NameInMap("G")]
                    [Validation(Required=false)]
                    public int? G { get; set; }

                    [NameInMap("R")]
                    [Validation(Required=false)]
                    public int? R { get; set; }

                }

                [NameInMap("Font")]
                [Validation(Required=false)]
                public int? Font { get; set; }

                [NameInMap("FontColor")]
                [Validation(Required=false)]
                public UpdateStreamingOutRequestPanesTextsFontColor FontColor { get; set; }
                public class UpdateStreamingOutRequestPanesTextsFontColor : TeaModel {
                    [NameInMap("B")]
                    [Validation(Required=false)]
                    public int? B { get; set; }

                    [NameInMap("G")]
                    [Validation(Required=false)]
                    public int? G { get; set; }

                    [NameInMap("R")]
                    [Validation(Required=false)]
                    public int? R { get; set; }

                }

                [NameInMap("FontSize")]
                [Validation(Required=false)]
                public int? FontSize { get; set; }

                [NameInMap("HasBox")]
                [Validation(Required=false)]
                public bool? HasBox { get; set; }

                [NameInMap("Layer")]
                [Validation(Required=false)]
                public int? Layer { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("Texture")]
                [Validation(Required=false)]
                public string Texture { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public double? X { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public double? Y { get; set; }

            }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("Texts")]
        [Validation(Required=false)]
        public List<UpdateStreamingOutRequestTexts> Texts { get; set; }
        public class UpdateStreamingOutRequestTexts : TeaModel {
            [NameInMap("Alpha")]
            [Validation(Required=false)]
            public double? Alpha { get; set; }

            [NameInMap("BoxAlpha")]
            [Validation(Required=false)]
            public double? BoxAlpha { get; set; }

            [NameInMap("BoxBorderw")]
            [Validation(Required=false)]
            public int? BoxBorderw { get; set; }

            [NameInMap("BoxColor")]
            [Validation(Required=false)]
            public UpdateStreamingOutRequestTextsBoxColor BoxColor { get; set; }
            public class UpdateStreamingOutRequestTextsBoxColor : TeaModel {
                [NameInMap("B")]
                [Validation(Required=false)]
                public int? B { get; set; }

                [NameInMap("G")]
                [Validation(Required=false)]
                public int? G { get; set; }

                [NameInMap("R")]
                [Validation(Required=false)]
                public int? R { get; set; }

            }

            [NameInMap("Font")]
            [Validation(Required=false)]
            public int? Font { get; set; }

            [NameInMap("FontColor")]
            [Validation(Required=false)]
            public UpdateStreamingOutRequestTextsFontColor FontColor { get; set; }
            public class UpdateStreamingOutRequestTextsFontColor : TeaModel {
                [NameInMap("B")]
                [Validation(Required=false)]
                public int? B { get; set; }

                [NameInMap("G")]
                [Validation(Required=false)]
                public int? G { get; set; }

                [NameInMap("R")]
                [Validation(Required=false)]
                public int? R { get; set; }

            }

            [NameInMap("FontSize")]
            [Validation(Required=false)]
            public int? FontSize { get; set; }

            [NameInMap("HasBox")]
            [Validation(Required=false)]
            public bool? HasBox { get; set; }

            [NameInMap("Layer")]
            [Validation(Required=false)]
            public int? Layer { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Texture")]
            [Validation(Required=false)]
            public string Texture { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("X")]
            [Validation(Required=false)]
            public double? X { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Y")]
            [Validation(Required=false)]
            public double? Y { get; set; }

        }

    }

}
