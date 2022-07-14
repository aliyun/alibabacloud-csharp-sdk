// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryWaterMarkTemplateListResponseBody : TeaModel {
        [NameInMap("NonExistWids")]
        [Validation(Required=false)]
        public QueryWaterMarkTemplateListResponseBodyNonExistWids NonExistWids { get; set; }
        public class QueryWaterMarkTemplateListResponseBodyNonExistWids : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("WaterMarkTemplateList")]
        [Validation(Required=false)]
        public QueryWaterMarkTemplateListResponseBodyWaterMarkTemplateList WaterMarkTemplateList { get; set; }
        public class QueryWaterMarkTemplateListResponseBodyWaterMarkTemplateList : TeaModel {
            [NameInMap("WaterMarkTemplate")]
            [Validation(Required=false)]
            public List<QueryWaterMarkTemplateListResponseBodyWaterMarkTemplateListWaterMarkTemplate> WaterMarkTemplate { get; set; }
            public class QueryWaterMarkTemplateListResponseBodyWaterMarkTemplateListWaterMarkTemplate : TeaModel {
                public string Dx { get; set; }
                public string Dy { get; set; }
                public string Height { get; set; }
                public string Id { get; set; }
                public string Name { get; set; }
                public QueryWaterMarkTemplateListResponseBodyWaterMarkTemplateListWaterMarkTemplateRatioRefer RatioRefer { get; set; }
                public class QueryWaterMarkTemplateListResponseBodyWaterMarkTemplateListWaterMarkTemplateRatioRefer : TeaModel {
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
                public QueryWaterMarkTemplateListResponseBodyWaterMarkTemplateListWaterMarkTemplateTimeline Timeline { get; set; }
                public class QueryWaterMarkTemplateListResponseBodyWaterMarkTemplateListWaterMarkTemplateTimeline : TeaModel {
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
