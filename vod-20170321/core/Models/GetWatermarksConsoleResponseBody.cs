// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetWatermarksConsoleResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("WatermarkInfos")]
        [Validation(Required=false)]
        public GetWatermarksConsoleResponseBodyWatermarkInfos WatermarkInfos { get; set; }
        public class GetWatermarksConsoleResponseBodyWatermarkInfos : TeaModel {
            [NameInMap("WatermarkInfo")]
            [Validation(Required=false)]
            public List<GetWatermarksConsoleResponseBodyWatermarkInfosWatermarkInfo> WatermarkInfo { get; set; }
            public class GetWatermarksConsoleResponseBodyWatermarkInfosWatermarkInfo : TeaModel {
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("FileUrl")]
                [Validation(Required=false)]
                public string FileUrl { get; set; }

                [NameInMap("IsDefault")]
                [Validation(Required=false)]
                public string IsDefault { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("ScreenHeight")]
                [Validation(Required=false)]
                public int? ScreenHeight { get; set; }

                [NameInMap("ScreenWidth")]
                [Validation(Required=false)]
                public int? ScreenWidth { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("WatermarkConfig")]
                [Validation(Required=false)]
                public string WatermarkConfig { get; set; }

                [NameInMap("WatermarkId")]
                [Validation(Required=false)]
                public string WatermarkId { get; set; }

            }

        }

        [NameInMap("Watermarks")]
        [Validation(Required=false)]
        public GetWatermarksConsoleResponseBodyWatermarks Watermarks { get; set; }
        public class GetWatermarksConsoleResponseBodyWatermarks : TeaModel {
            [NameInMap("Watermark")]
            [Validation(Required=false)]
            public List<GetWatermarksConsoleResponseBodyWatermarksWatermark> Watermark { get; set; }
            public class GetWatermarksConsoleResponseBodyWatermarksWatermark : TeaModel {
                [NameInMap("Active")]
                [Validation(Required=false)]
                public string Active { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public int? CreateTime { get; set; }

                [NameInMap("Height")]
                [Validation(Required=false)]
                public string Height { get; set; }

                [NameInMap("HorizontalOffset")]
                [Validation(Required=false)]
                public string HorizontalOffset { get; set; }

                [NameInMap("IsDefault")]
                [Validation(Required=false)]
                public string IsDefault { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Position")]
                [Validation(Required=false)]
                public string Position { get; set; }

                [NameInMap("ScreenMode")]
                [Validation(Required=false)]
                public string ScreenMode { get; set; }

                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                [NameInMap("VerticalOffset")]
                [Validation(Required=false)]
                public string VerticalOffset { get; set; }

                [NameInMap("VideoHeight")]
                [Validation(Required=false)]
                public int? VideoHeight { get; set; }

                [NameInMap("VideoWidth")]
                [Validation(Required=false)]
                public int? VideoWidth { get; set; }

                [NameInMap("WatermarkId")]
                [Validation(Required=false)]
                public string WatermarkId { get; set; }

                [NameInMap("Width")]
                [Validation(Required=false)]
                public string Width { get; set; }

            }

        }

    }

}
