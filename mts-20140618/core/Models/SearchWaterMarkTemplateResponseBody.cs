// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
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
                public string Dx { get; set; }
                public string Dy { get; set; }
                public string Height { get; set; }
                public string Id { get; set; }
                public string Name { get; set; }
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
                public string ReferPos { get; set; }
                public string State { get; set; }
                public SearchWaterMarkTemplateResponseBodyWaterMarkTemplateListWaterMarkTemplateTimeline Timeline { get; set; }
                public class SearchWaterMarkTemplateResponseBodyWaterMarkTemplateListWaterMarkTemplateTimeline : TeaModel {
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }

                    [NameInMap("Start")]
                    [Validation(Required=false)]
                    public string Start { get; set; }

                }
                public string Type { get; set; }
                public string Width { get; set; }
            }
        };

    }

}
