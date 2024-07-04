// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20180528.Models
{
    public class QueryWaterMarkTemplateListResponseBody : TeaModel {
        [NameInMap("NonExistWids")]
        [Validation(Required=false)]
        public QueryWaterMarkTemplateListResponseBodyNonExistWids NonExistWids { get; set; }
        public class QueryWaterMarkTemplateListResponseBodyNonExistWids : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }

        }

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

                [NameInMap("ReferPos")]
                [Validation(Required=false)]
                public string ReferPos { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("Timeline")]
                [Validation(Required=false)]
                public QueryWaterMarkTemplateListResponseBodyWaterMarkTemplateListWaterMarkTemplateTimeline Timeline { get; set; }
                public class QueryWaterMarkTemplateListResponseBodyWaterMarkTemplateListWaterMarkTemplateTimeline : TeaModel {
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
