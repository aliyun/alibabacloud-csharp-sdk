// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class StartRecordTaskRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ShowLog")]
        [Validation(Required=false)]
        public string ShowLog { get; set; }

        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("TaskProfile")]
        [Validation(Required=false)]
        public string TaskProfile { get; set; }

        [NameInMap("MediaEncode")]
        [Validation(Required=false)]
        public int? MediaEncode { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("SubSpecUsers")]
        [Validation(Required=false)]
        public List<string> SubSpecUsers { get; set; }

        [NameInMap("UserPanes")]
        [Validation(Required=false)]
        public List<StartRecordTaskRequestUserPanes> UserPanes { get; set; }
        public class StartRecordTaskRequestUserPanes : TeaModel {
            [NameInMap("Images")]
            [Validation(Required=false)]
            public List<StartRecordTaskRequestUserPanesImages> Images { get; set; }
            public class StartRecordTaskRequestUserPanesImages : TeaModel {
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

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("Texts")]
            [Validation(Required=false)]
            public List<StartRecordTaskRequestUserPanesTexts> Texts { get; set; }
            public class StartRecordTaskRequestUserPanesTexts : TeaModel {
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

    }

}
