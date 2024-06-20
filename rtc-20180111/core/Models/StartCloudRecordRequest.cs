// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class StartCloudRecordRequest : TeaModel {
        /// <summary>
        /// appId
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// channelName
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        [NameInMap("ClockWidgets")]
        [Validation(Required=false)]
        public List<StartCloudRecordRequestClockWidgets> ClockWidgets { get; set; }
        public class StartCloudRecordRequestClockWidgets : TeaModel {
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
            public StartCloudRecordRequestClockWidgetsBoxColor BoxColor { get; set; }
            public class StartCloudRecordRequestClockWidgetsBoxColor : TeaModel {
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
            public StartCloudRecordRequestClockWidgetsFontColor FontColor { get; set; }
            public class StartCloudRecordRequestClockWidgetsFontColor : TeaModel {
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
        public List<StartCloudRecordRequestImages> Images { get; set; }
        public class StartCloudRecordRequestImages : TeaModel {
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

        /// <summary>
        /// panes
        /// </summary>
        [NameInMap("Panes")]
        [Validation(Required=false)]
        public List<StartCloudRecordRequestPanes> Panes { get; set; }
        public class StartCloudRecordRequestPanes : TeaModel {
            [NameInMap("Images")]
            [Validation(Required=false)]
            public List<StartCloudRecordRequestPanesImages> Images { get; set; }
            public class StartCloudRecordRequestPanesImages : TeaModel {
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
            /// paneId
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("PaneId")]
            [Validation(Required=false)]
            public int? PaneId { get; set; }

            /// <summary>
            /// source
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// sourceType
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            [NameInMap("Texts")]
            [Validation(Required=false)]
            public List<StartCloudRecordRequestPanesTexts> Texts { get; set; }
            public class StartCloudRecordRequestPanesTexts : TeaModel {
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
                public StartCloudRecordRequestPanesTextsBoxColor BoxColor { get; set; }
                public class StartCloudRecordRequestPanesTextsBoxColor : TeaModel {
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
                public StartCloudRecordRequestPanesTextsFontColor FontColor { get; set; }
                public class StartCloudRecordRequestPanesTextsFontColor : TeaModel {
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
        /// storageConfig
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StorageConfig")]
        [Validation(Required=false)]
        public StartCloudRecordRequestStorageConfig StorageConfig { get; set; }
        public class StartCloudRecordRequestStorageConfig : TeaModel {
            /// <summary>
            /// accessKey
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("AccessKey")]
            [Validation(Required=false)]
            public string AccessKey { get; set; }

            /// <summary>
            /// bucket
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            /// <summary>
            /// region
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public int? Region { get; set; }

            /// <summary>
            /// secretKey
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("SecretKey")]
            [Validation(Required=false)]
            public string SecretKey { get; set; }

            /// <summary>
            /// vendor
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public int? Vendor { get; set; }

        }

        /// <summary>
        /// taskId
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// templateId
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("Texts")]
        [Validation(Required=false)]
        public List<StartCloudRecordRequestTexts> Texts { get; set; }
        public class StartCloudRecordRequestTexts : TeaModel {
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
            public StartCloudRecordRequestTextsBoxColor BoxColor { get; set; }
            public class StartCloudRecordRequestTextsBoxColor : TeaModel {
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
            public StartCloudRecordRequestTextsFontColor FontColor { get; set; }
            public class StartCloudRecordRequestTextsFontColor : TeaModel {
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
