// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class UpdateCloudRecordRequest : TeaModel {
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
        public List<UpdateCloudRecordRequestClockWidgets> ClockWidgets { get; set; }
        public class UpdateCloudRecordRequestClockWidgets : TeaModel {
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
            public UpdateCloudRecordRequestClockWidgetsBoxColor BoxColor { get; set; }
            public class UpdateCloudRecordRequestClockWidgetsBoxColor : TeaModel {
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
            public UpdateCloudRecordRequestClockWidgetsFontColor FontColor { get; set; }
            public class UpdateCloudRecordRequestClockWidgetsFontColor : TeaModel {
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
        public List<UpdateCloudRecordRequestImages> Images { get; set; }
        public class UpdateCloudRecordRequestImages : TeaModel {
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
        public List<UpdateCloudRecordRequestPanes> Panes { get; set; }
        public class UpdateCloudRecordRequestPanes : TeaModel {
            [NameInMap("Images")]
            [Validation(Required=false)]
            public List<UpdateCloudRecordRequestPanesImages> Images { get; set; }
            public class UpdateCloudRecordRequestPanesImages : TeaModel {
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
            public int? PaneId { get; set; }

            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            [NameInMap("Texts")]
            [Validation(Required=false)]
            public List<UpdateCloudRecordRequestPanesTexts> Texts { get; set; }
            public class UpdateCloudRecordRequestPanesTexts : TeaModel {
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
                public UpdateCloudRecordRequestPanesTextsBoxColor BoxColor { get; set; }
                public class UpdateCloudRecordRequestPanesTextsBoxColor : TeaModel {
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
                public UpdateCloudRecordRequestPanesTextsFontColor FontColor { get; set; }
                public class UpdateCloudRecordRequestPanesTextsFontColor : TeaModel {
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
        public List<UpdateCloudRecordRequestTexts> Texts { get; set; }
        public class UpdateCloudRecordRequestTexts : TeaModel {
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
            public UpdateCloudRecordRequestTextsBoxColor BoxColor { get; set; }
            public class UpdateCloudRecordRequestTextsBoxColor : TeaModel {
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
            public UpdateCloudRecordRequestTextsFontColor FontColor { get; set; }
            public class UpdateCloudRecordRequestTextsFontColor : TeaModel {
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
