// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20180528.Models
{
    public class SearchWaterMarkTemplateResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("WaterMarkTemplateList")]
        [Validation(Required=false)]
        public SearchWaterMarkTemplateResponseBodyWaterMarkTemplateList WaterMarkTemplateList { get; set; }
        public class SearchWaterMarkTemplateResponseBodyWaterMarkTemplateList : TeaModel {
            [NameInMap("WaterMarkTemplate")]
            [Validation(Required=false)]
            public List<SearchWaterMarkTemplateResponseBodyWaterMarkTemplateListWaterMarkTemplate> WaterMarkTemplate { get; set; }
            public class SearchWaterMarkTemplateResponseBodyWaterMarkTemplateListWaterMarkTemplate : TeaModel {
                [NameInMap("Dx")]
                [Validation(Required=false)]
                public string Dx { get; set; }

                [NameInMap("Dy")]
                [Validation(Required=false)]
                public string Dy { get; set; }

                [NameInMap("Height")]
                [Validation(Required=false)]
                public string Height { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("RatioRefer")]
                [Validation(Required=false)]
                public SearchWaterMarkTemplateResponseBodyWaterMarkTemplateListWaterMarkTemplateRatioRefer RatioRefer { get; set; }
                public class SearchWaterMarkTemplateResponseBodyWaterMarkTemplateListWaterMarkTemplateRatioRefer : TeaModel {
                    [NameInMap("Dx")]
                    [Validation(Required=false)]
                    public string Dx { get; set; }

                    [NameInMap("Dy")]
                    [Validation(Required=false)]
                    public string Dy { get; set; }

                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public string Height { get; set; }

                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public string Width { get; set; }

                }

                [NameInMap("ReferPos")]
                [Validation(Required=false)]
                public string ReferPos { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("Timeline")]
                [Validation(Required=false)]
                public SearchWaterMarkTemplateResponseBodyWaterMarkTemplateListWaterMarkTemplateTimeline Timeline { get; set; }
                public class SearchWaterMarkTemplateResponseBodyWaterMarkTemplateListWaterMarkTemplateTimeline : TeaModel {
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }

                    [NameInMap("Start")]
                    [Validation(Required=false)]
                    public string Start { get; set; }

                }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Width")]
                [Validation(Required=false)]
                public string Width { get; set; }

            }

        }

    }

}
