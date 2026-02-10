// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamWatermarksResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5c6a2a0df228-4a64- af62-20e91b9676b3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of watermark templates that meet the specified conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

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

                [NameInMap("RuleCount")]
                [Validation(Required=false)]
                public int? RuleCount { get; set; }

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
