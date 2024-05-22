// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class StartMPUTaskRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("BackgroundColor")]
        [Validation(Required=false)]
        public int? BackgroundColor { get; set; }

        [NameInMap("Backgrounds")]
        [Validation(Required=false)]
        public List<StartMPUTaskRequestBackgrounds> Backgrounds { get; set; }
        public class StartMPUTaskRequestBackgrounds : TeaModel {
            [NameInMap("Display")]
            [Validation(Required=false)]
            public int? Display { get; set; }

            [NameInMap("Height")]
            [Validation(Required=false)]
            public float? Height { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            [NameInMap("Width")]
            [Validation(Required=false)]
            public float? Width { get; set; }

            [NameInMap("X")]
            [Validation(Required=false)]
            public float? X { get; set; }

            [NameInMap("Y")]
            [Validation(Required=false)]
            public float? Y { get; set; }

            [NameInMap("ZOrder")]
            [Validation(Required=false)]
            public int? ZOrder { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        [NameInMap("ClockWidgets")]
        [Validation(Required=false)]
        public List<StartMPUTaskRequestClockWidgets> ClockWidgets { get; set; }
        public class StartMPUTaskRequestClockWidgets : TeaModel {
            [NameInMap("Alpha")]
            [Validation(Required=false)]
            public float? Alpha { get; set; }

            [NameInMap("BorderColor")]
            [Validation(Required=false)]
            public long? BorderColor { get; set; }

            [NameInMap("BorderWidth")]
            [Validation(Required=false)]
            public int? BorderWidth { get; set; }

            [NameInMap("Box")]
            [Validation(Required=false)]
            public bool? Box { get; set; }

            [NameInMap("BoxBorderWidth")]
            [Validation(Required=false)]
            public int? BoxBorderWidth { get; set; }

            [NameInMap("BoxColor")]
            [Validation(Required=false)]
            public long? BoxColor { get; set; }

            [NameInMap("FontColor")]
            [Validation(Required=false)]
            public int? FontColor { get; set; }

            [NameInMap("FontSize")]
            [Validation(Required=false)]
            public int? FontSize { get; set; }

            [NameInMap("FontType")]
            [Validation(Required=false)]
            public int? FontType { get; set; }

            [NameInMap("X")]
            [Validation(Required=false)]
            public float? X { get; set; }

            [NameInMap("Y")]
            [Validation(Required=false)]
            public float? Y { get; set; }

            [NameInMap("ZOrder")]
            [Validation(Required=false)]
            public int? ZOrder { get; set; }

        }

        [NameInMap("CropMode")]
        [Validation(Required=false)]
        public int? CropMode { get; set; }

        [NameInMap("EnhancedParam")]
        [Validation(Required=false)]
        public StartMPUTaskRequestEnhancedParam EnhancedParam { get; set; }
        public class StartMPUTaskRequestEnhancedParam : TeaModel {
            [NameInMap("EnablePortraitSegmentation")]
            [Validation(Required=false)]
            public bool? EnablePortraitSegmentation { get; set; }

        }

        [NameInMap("LayoutIds")]
        [Validation(Required=false)]
        public List<long?> LayoutIds { get; set; }

        [NameInMap("MediaEncode")]
        [Validation(Required=false)]
        public int? MediaEncode { get; set; }

        [NameInMap("MixMode")]
        [Validation(Required=false)]
        public int? MixMode { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("PayloadType")]
        [Validation(Required=false)]
        public int? PayloadType { get; set; }

        [NameInMap("ReportVad")]
        [Validation(Required=false)]
        public int? ReportVad { get; set; }

        [NameInMap("RtpExtInfo")]
        [Validation(Required=false)]
        public int? RtpExtInfo { get; set; }

        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        [NameInMap("StreamType")]
        [Validation(Required=false)]
        public int? StreamType { get; set; }

        [NameInMap("StreamURL")]
        [Validation(Required=false)]
        public string StreamURL { get; set; }

        [NameInMap("SubSpecAudioUsers")]
        [Validation(Required=false)]
        public List<string> SubSpecAudioUsers { get; set; }

        [NameInMap("SubSpecCameraUsers")]
        [Validation(Required=false)]
        public List<string> SubSpecCameraUsers { get; set; }

        [NameInMap("SubSpecShareScreenUsers")]
        [Validation(Required=false)]
        public List<string> SubSpecShareScreenUsers { get; set; }

        [NameInMap("SubSpecUsers")]
        [Validation(Required=false)]
        public List<string> SubSpecUsers { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public int? TaskType { get; set; }

        [NameInMap("TimeStampRef")]
        [Validation(Required=false)]
        public long? TimeStampRef { get; set; }

        [NameInMap("UnsubSpecAudioUsers")]
        [Validation(Required=false)]
        public List<string> UnsubSpecAudioUsers { get; set; }

        [NameInMap("UnsubSpecCameraUsers")]
        [Validation(Required=false)]
        public List<string> UnsubSpecCameraUsers { get; set; }

        [NameInMap("UnsubSpecShareScreenUsers")]
        [Validation(Required=false)]
        public List<string> UnsubSpecShareScreenUsers { get; set; }

        [NameInMap("UserPanes")]
        [Validation(Required=false)]
        public List<StartMPUTaskRequestUserPanes> UserPanes { get; set; }
        public class StartMPUTaskRequestUserPanes : TeaModel {
            [NameInMap("Images")]
            [Validation(Required=false)]
            public List<StartMPUTaskRequestUserPanesImages> Images { get; set; }
            public class StartMPUTaskRequestUserPanesImages : TeaModel {
                [NameInMap("Display")]
                [Validation(Required=false)]
                public int? Display { get; set; }

                [NameInMap("Height")]
                [Validation(Required=false)]
                public float? Height { get; set; }

                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                [NameInMap("Width")]
                [Validation(Required=false)]
                public float? Width { get; set; }

                [NameInMap("X")]
                [Validation(Required=false)]
                public float? X { get; set; }

                [NameInMap("Y")]
                [Validation(Required=false)]
                public float? Y { get; set; }

                [NameInMap("ZOrder")]
                [Validation(Required=false)]
                public int? ZOrder { get; set; }

            }

            [NameInMap("PaneId")]
            [Validation(Required=false)]
            public int? PaneId { get; set; }

            [NameInMap("SegmentType")]
            [Validation(Required=false)]
            public int? SegmentType { get; set; }

            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            [NameInMap("Texts")]
            [Validation(Required=false)]
            public List<StartMPUTaskRequestUserPanesTexts> Texts { get; set; }
            public class StartMPUTaskRequestUserPanesTexts : TeaModel {
                [NameInMap("Alpha")]
                [Validation(Required=false)]
                public float? Alpha { get; set; }

                [NameInMap("BorderColor")]
                [Validation(Required=false)]
                public long? BorderColor { get; set; }

                [NameInMap("BorderWidth")]
                [Validation(Required=false)]
                public int? BorderWidth { get; set; }

                [NameInMap("Box")]
                [Validation(Required=false)]
                public bool? Box { get; set; }

                [NameInMap("BoxBorderWidth")]
                [Validation(Required=false)]
                public int? BoxBorderWidth { get; set; }

                [NameInMap("BoxColor")]
                [Validation(Required=false)]
                public long? BoxColor { get; set; }

                [NameInMap("FontColor")]
                [Validation(Required=false)]
                public int? FontColor { get; set; }

                [NameInMap("FontSize")]
                [Validation(Required=false)]
                public int? FontSize { get; set; }

                [NameInMap("FontType")]
                [Validation(Required=false)]
                public int? FontType { get; set; }

                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                [NameInMap("X")]
                [Validation(Required=false)]
                public float? X { get; set; }

                [NameInMap("Y")]
                [Validation(Required=false)]
                public float? Y { get; set; }

                [NameInMap("ZOrder")]
                [Validation(Required=false)]
                public int? ZOrder { get; set; }

            }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("VadInterval")]
        [Validation(Required=false)]
        public long? VadInterval { get; set; }

        [NameInMap("Watermarks")]
        [Validation(Required=false)]
        public List<StartMPUTaskRequestWatermarks> Watermarks { get; set; }
        public class StartMPUTaskRequestWatermarks : TeaModel {
            [NameInMap("Alpha")]
            [Validation(Required=false)]
            public float? Alpha { get; set; }

            [NameInMap("Display")]
            [Validation(Required=false)]
            public int? Display { get; set; }

            [NameInMap("Height")]
            [Validation(Required=false)]
            public float? Height { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            [NameInMap("Width")]
            [Validation(Required=false)]
            public float? Width { get; set; }

            [NameInMap("X")]
            [Validation(Required=false)]
            public float? X { get; set; }

            [NameInMap("Y")]
            [Validation(Required=false)]
            public float? Y { get; set; }

            [NameInMap("ZOrder")]
            [Validation(Required=false)]
            public int? ZOrder { get; set; }

        }

    }

}
