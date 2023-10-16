// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class QueryIntentionPriceResponseBody : TeaModel {
        [NameInMap("CurrentPageNum")]
        [Validation(Required=false)]
        public int? CurrentPageNum { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryIntentionPriceResponseBodyData Data { get; set; }
        public class QueryIntentionPriceResponseBodyData : TeaModel {
            [NameInMap("TmProduces")]
            [Validation(Required=false)]
            public List<QueryIntentionPriceResponseBodyDataTmProduces> TmProduces { get; set; }
            public class QueryIntentionPriceResponseBodyDataTmProduces : TeaModel {
                [NameInMap("BizId")]
                [Validation(Required=false)]
                public string BizId { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("FirstClassification")]
                [Validation(Required=false)]
                public QueryIntentionPriceResponseBodyDataTmProducesFirstClassification FirstClassification { get; set; }
                public class QueryIntentionPriceResponseBodyDataTmProducesFirstClassification : TeaModel {
                    [NameInMap("ClassificationCode")]
                    [Validation(Required=false)]
                    public string ClassificationCode { get; set; }

                    [NameInMap("ClassificationName")]
                    [Validation(Required=false)]
                    public string ClassificationName { get; set; }

                }

                [NameInMap("LoaUrl")]
                [Validation(Required=false)]
                public string LoaUrl { get; set; }

                [NameInMap("MaterialId")]
                [Validation(Required=false)]
                public string MaterialId { get; set; }

                [NameInMap("MaterialName")]
                [Validation(Required=false)]
                public string MaterialName { get; set; }

                [NameInMap("Note")]
                [Validation(Required=false)]
                public string Note { get; set; }

                [NameInMap("OrderPrice")]
                [Validation(Required=false)]
                public float? OrderPrice { get; set; }

                [NameInMap("ServicePrice")]
                [Validation(Required=false)]
                public float? ServicePrice { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("SupplementId")]
                [Validation(Required=false)]
                public long? SupplementId { get; set; }

                [NameInMap("SupplementStatus")]
                [Validation(Required=false)]
                public int? SupplementStatus { get; set; }

                [NameInMap("ThirdClassification")]
                [Validation(Required=false)]
                public QueryIntentionPriceResponseBodyDataTmProducesThirdClassification ThirdClassification { get; set; }
                public class QueryIntentionPriceResponseBodyDataTmProducesThirdClassification : TeaModel {
                    [NameInMap("ThirdClassifications")]
                    [Validation(Required=false)]
                    public List<QueryIntentionPriceResponseBodyDataTmProducesThirdClassificationThirdClassifications> ThirdClassifications { get; set; }
                    public class QueryIntentionPriceResponseBodyDataTmProducesThirdClassificationThirdClassifications : TeaModel {
                        [NameInMap("ClassificationCode")]
                        [Validation(Required=false)]
                        public string ClassificationCode { get; set; }

                        [NameInMap("ClassificationName")]
                        [Validation(Required=false)]
                        public string ClassificationName { get; set; }

                    }

                }

                [NameInMap("TmIcon")]
                [Validation(Required=false)]
                public string TmIcon { get; set; }

                [NameInMap("TmName")]
                [Validation(Required=false)]
                public string TmName { get; set; }

                [NameInMap("TmNumber")]
                [Validation(Required=false)]
                public string TmNumber { get; set; }

                [NameInMap("TotalPrice")]
                [Validation(Required=false)]
                public float? TotalPrice { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

        }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalItemNum")]
        [Validation(Required=false)]
        public int? TotalItemNum { get; set; }

        [NameInMap("TotalPageNum")]
        [Validation(Required=false)]
        public int? TotalPageNum { get; set; }

    }

}
