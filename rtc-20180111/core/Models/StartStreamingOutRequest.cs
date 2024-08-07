// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class StartStreamingOutRequest : TeaModel {
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
        public List<StartStreamingOutRequestClockWidgets> ClockWidgets { get; set; }
        public class StartStreamingOutRequestClockWidgets : TeaModel {
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
            public StartStreamingOutRequestClockWidgetsBoxColor BoxColor { get; set; }
            public class StartStreamingOutRequestClockWidgetsBoxColor : TeaModel {
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
            public StartStreamingOutRequestClockWidgetsFontColor FontColor { get; set; }
            public class StartStreamingOutRequestClockWidgetsFontColor : TeaModel {
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

        [NameInMap("CropMode")]
        [Validation(Required=false)]
        public int? CropMode { get; set; }

        [NameInMap("Images")]
        [Validation(Required=false)]
        public List<StartStreamingOutRequestImages> Images { get; set; }
        public class StartStreamingOutRequestImages : TeaModel {
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
        public List<StartStreamingOutRequestPanes> Panes { get; set; }
        public class StartStreamingOutRequestPanes : TeaModel {
            [NameInMap("Images")]
            [Validation(Required=false)]
            public List<StartStreamingOutRequestPanesImages> Images { get; set; }
            public class StartStreamingOutRequestPanesImages : TeaModel {
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

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("PaneId")]
            [Validation(Required=false)]
            public string PaneId { get; set; }

            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            [NameInMap("Texts")]
            [Validation(Required=false)]
            public List<StartStreamingOutRequestPanesTexts> Texts { get; set; }
            public class StartStreamingOutRequestPanesTexts : TeaModel {
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
                public StartStreamingOutRequestPanesTextsBoxColor BoxColor { get; set; }
                public class StartStreamingOutRequestPanesTextsBoxColor : TeaModel {
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
                public StartStreamingOutRequestPanesTextsFontColor FontColor { get; set; }
                public class StartStreamingOutRequestPanesTextsFontColor : TeaModel {
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
        public List<StartStreamingOutRequestTexts> Texts { get; set; }
        public class StartStreamingOutRequestTexts : TeaModel {
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
            public StartStreamingOutRequestTextsBoxColor BoxColor { get; set; }
            public class StartStreamingOutRequestTextsBoxColor : TeaModel {
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
            public StartStreamingOutRequestTextsFontColor FontColor { get; set; }
            public class StartStreamingOutRequestTextsFontColor : TeaModel {
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

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
