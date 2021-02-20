// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class UpdateRecordTemplateRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ShowLog")]
        [Validation(Required=false)]
        public string ShowLog { get; set; }

        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("TaskProfile")]
        [Validation(Required=false)]
        public string TaskProfile { get; set; }

        [NameInMap("MediaEncode")]
        [Validation(Required=false)]
        public int? MediaEncode { get; set; }

        [NameInMap("BackgroundColor")]
        [Validation(Required=false)]
        public int? BackgroundColor { get; set; }

        [NameInMap("OssBucket")]
        [Validation(Required=false)]
        public string OssBucket { get; set; }

        [NameInMap("OssFilePrefix")]
        [Validation(Required=false)]
        public string OssFilePrefix { get; set; }

        [NameInMap("MnsQueue")]
        [Validation(Required=false)]
        public string MnsQueue { get; set; }

        [NameInMap("HttpCallbackUrl")]
        [Validation(Required=false)]
        public string HttpCallbackUrl { get; set; }

        [NameInMap("FileSplitInterval")]
        [Validation(Required=false)]
        public int? FileSplitInterval { get; set; }

        [NameInMap("DelayStopTime")]
        [Validation(Required=false)]
        public int? DelayStopTime { get; set; }

        [NameInMap("LayoutIds")]
        [Validation(Required=false)]
        public List<int?> LayoutIds { get; set; }

        [NameInMap("Formats")]
        [Validation(Required=false)]
        public List<string> Formats { get; set; }

        [NameInMap("Backgrounds")]
        [Validation(Required=false)]
        public List<UpdateRecordTemplateRequestBackgrounds> Backgrounds { get; set; }
        public class UpdateRecordTemplateRequestBackgrounds : TeaModel {
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
        public List<UpdateRecordTemplateRequestWatermarks> Watermarks { get; set; }
        public class UpdateRecordTemplateRequestWatermarks : TeaModel {
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
        public List<UpdateRecordTemplateRequestClockWidgets> ClockWidgets { get; set; }
        public class UpdateRecordTemplateRequestClockWidgets : TeaModel {
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
