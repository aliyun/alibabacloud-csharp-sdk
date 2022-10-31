// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamWatermarksResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("WatermarkList")]
        [Validation(Required=false)]
        public DescribeLiveStreamWatermarksResponseBodyWatermarkList WatermarkList { get; set; }
        public class DescribeLiveStreamWatermarksResponseBodyWatermarkList : TeaModel {
            [NameInMap("Watermark")]
            [Validation(Required=false)]
            public List<DescribeLiveStreamWatermarksResponseBodyWatermarkListWatermark> Watermark { get; set; }
            public class DescribeLiveStreamWatermarksResponseBodyWatermarkListWatermark : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("OffsetCorner")]
                [Validation(Required=false)]
                public string OffsetCorner { get; set; }

                [NameInMap("PictureUrl")]
                [Validation(Required=false)]
                public string PictureUrl { get; set; }

                [NameInMap("RefHeight")]
                [Validation(Required=false)]
                public int? RefHeight { get; set; }

                [NameInMap("RefWidth")]
                [Validation(Required=false)]
                public int? RefWidth { get; set; }

                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public string TemplateId { get; set; }

                [NameInMap("Transparency")]
                [Validation(Required=false)]
                public int? Transparency { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                [NameInMap("XOffset")]
                [Validation(Required=false)]
                public float? XOffset { get; set; }

                [NameInMap("YOffset")]
                [Validation(Required=false)]
                public float? YOffset { get; set; }

            }

        }

    }

}
