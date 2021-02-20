// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class UpdateMPULayoutRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ShowLog")]
        [Validation(Required=false)]
        public string ShowLog { get; set; }

        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("CropMode")]
        [Validation(Required=false)]
        public int? CropMode { get; set; }

        [NameInMap("BackgroundColor")]
        [Validation(Required=false)]
        public int? BackgroundColor { get; set; }

        [NameInMap("LayoutIds")]
        [Validation(Required=false)]
        public List<int?> LayoutIds { get; set; }

        [NameInMap("SubSpecUsers")]
        [Validation(Required=false)]
        public List<string> SubSpecUsers { get; set; }

        [NameInMap("UserPanes")]
        [Validation(Required=false)]
        public List<UpdateMPULayoutRequestUserPanes> UserPanes { get; set; }
        public class UpdateMPULayoutRequestUserPanes : TeaModel {
            [NameInMap("Images")]
            [Validation(Required=false)]
            public List<UpdateMPULayoutRequestUserPanesImages> Images { get; set; }
            public class UpdateMPULayoutRequestUserPanesImages : TeaModel {
                [NameInMap("Width")]
                [Validation(Required=false)]
                public float? Width { get; set; }

                [NameInMap("Height")]
                [Validation(Required=false)]
                public float? Height { get; set; }

                [NameInMap("Y")]
                [Validation(Required=false)]
                public float? Y { get; set; }

                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                [NameInMap("Display")]
                [Validation(Required=false)]
                public int? Display { get; set; }

                [NameInMap("ZOrder")]
                [Validation(Required=false)]
                public int? ZOrder { get; set; }

                [NameInMap("X")]
                [Validation(Required=false)]
                public float? X { get; set; }

            }

            [NameInMap("SegmentType")]
            [Validation(Required=false)]
            public int? SegmentType { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("Texts")]
            [Validation(Required=false)]
            public List<UpdateMPULayoutRequestUserPanesTexts> Texts { get; set; }
            public class UpdateMPULayoutRequestUserPanesTexts : TeaModel {
                [NameInMap("FontType")]
                [Validation(Required=false)]
                public int? FontType { get; set; }

                [NameInMap("FontColor")]
                [Validation(Required=false)]
                public int? FontColor { get; set; }

                [NameInMap("Y")]
                [Validation(Required=false)]
                public float? Y { get; set; }

                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                [NameInMap("ZOrder")]
                [Validation(Required=false)]
                public int? ZOrder { get; set; }

                [NameInMap("FontSize")]
                [Validation(Required=false)]
                public int? FontSize { get; set; }

                [NameInMap("X")]
                [Validation(Required=false)]
                public float? X { get; set; }

            }

            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            [NameInMap("PaneId")]
            [Validation(Required=false)]
            public int? PaneId { get; set; }

        }

        [NameInMap("Backgrounds")]
        [Validation(Required=false)]
        public List<UpdateMPULayoutRequestBackgrounds> Backgrounds { get; set; }
        public class UpdateMPULayoutRequestBackgrounds : TeaModel {
            [NameInMap("Width")]
            [Validation(Required=false)]
            public float? Width { get; set; }

            [NameInMap("Height")]
            [Validation(Required=false)]
            public float? Height { get; set; }

            [NameInMap("Y")]
            [Validation(Required=false)]
            public float? Y { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            [NameInMap("Display")]
            [Validation(Required=false)]
            public int? Display { get; set; }

            [NameInMap("ZOrder")]
            [Validation(Required=false)]
            public int? ZOrder { get; set; }

            [NameInMap("X")]
            [Validation(Required=false)]
            public float? X { get; set; }

        }

        [NameInMap("Watermarks")]
        [Validation(Required=false)]
        public List<UpdateMPULayoutRequestWatermarks> Watermarks { get; set; }
        public class UpdateMPULayoutRequestWatermarks : TeaModel {
            [NameInMap("Alpha")]
            [Validation(Required=false)]
            public float? Alpha { get; set; }

            [NameInMap("Width")]
            [Validation(Required=false)]
            public float? Width { get; set; }

            [NameInMap("Height")]
            [Validation(Required=false)]
            public float? Height { get; set; }

            [NameInMap("Y")]
            [Validation(Required=false)]
            public float? Y { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            [NameInMap("Display")]
            [Validation(Required=false)]
            public int? Display { get; set; }

            [NameInMap("ZOrder")]
            [Validation(Required=false)]
            public int? ZOrder { get; set; }

            [NameInMap("X")]
            [Validation(Required=false)]
            public float? X { get; set; }

        }

        [NameInMap("ClockWidgets")]
        [Validation(Required=false)]
        public List<UpdateMPULayoutRequestClockWidgets> ClockWidgets { get; set; }
        public class UpdateMPULayoutRequestClockWidgets : TeaModel {
            [NameInMap("FontType")]
            [Validation(Required=false)]
            public int? FontType { get; set; }

            [NameInMap("FontColor")]
            [Validation(Required=false)]
            public int? FontColor { get; set; }

            [NameInMap("Y")]
            [Validation(Required=false)]
            public float? Y { get; set; }

            [NameInMap("ZOrder")]
            [Validation(Required=false)]
            public int? ZOrder { get; set; }

            [NameInMap("X")]
            [Validation(Required=false)]
            public float? X { get; set; }

            [NameInMap("FontSize")]
            [Validation(Required=false)]
            public int? FontSize { get; set; }

        }

    }

}
