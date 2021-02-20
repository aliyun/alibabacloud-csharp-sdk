// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeRecordTemplatesResponseBody : TeaModel {
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public long? TotalNum { get; set; }

        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public long? TotalPage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Templates")]
        [Validation(Required=false)]
        public List<DescribeRecordTemplatesResponseBodyTemplates> Templates { get; set; }
        public class DescribeRecordTemplatesResponseBodyTemplates : TeaModel {
            [NameInMap("MnsQueue")]
            [Validation(Required=false)]
            public string MnsQueue { get; set; }

            [NameInMap("OssFilePrefix")]
            [Validation(Required=false)]
            public string OssFilePrefix { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("ClockWidgets")]
            [Validation(Required=false)]
            public List<DescribeRecordTemplatesResponseBodyTemplatesClockWidgets> ClockWidgets { get; set; }
            public class DescribeRecordTemplatesResponseBodyTemplatesClockWidgets : TeaModel {
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

            [NameInMap("OssBucket")]
            [Validation(Required=false)]
            public string OssBucket { get; set; }

            [NameInMap("DelayStopTime")]
            [Validation(Required=false)]
            public string DelayStopTime { get; set; }

            [NameInMap("LayoutIds")]
            [Validation(Required=false)]
            public List<int?> LayoutIds { get; set; }

            [NameInMap("MediaEncode")]
            [Validation(Required=false)]
            public int? MediaEncode { get; set; }

            [NameInMap("FileSplitInterval")]
            [Validation(Required=false)]
            public int? FileSplitInterval { get; set; }

            [NameInMap("HttpCallbackUrl")]
            [Validation(Required=false)]
            public string HttpCallbackUrl { get; set; }

            [NameInMap("Formats")]
            [Validation(Required=false)]
            public List<string> Formats { get; set; }

            [NameInMap("BackgroundColor")]
            [Validation(Required=false)]
            public int? BackgroundColor { get; set; }

            [NameInMap("Backgrounds")]
            [Validation(Required=false)]
            public List<DescribeRecordTemplatesResponseBodyTemplatesBackgrounds> Backgrounds { get; set; }
            public class DescribeRecordTemplatesResponseBodyTemplatesBackgrounds : TeaModel {
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
            public List<DescribeRecordTemplatesResponseBodyTemplatesWatermarks> Watermarks { get; set; }
            public class DescribeRecordTemplatesResponseBodyTemplatesWatermarks : TeaModel {
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

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            [NameInMap("TaskProfile")]
            [Validation(Required=false)]
            public string TaskProfile { get; set; }

        }

    }

}
