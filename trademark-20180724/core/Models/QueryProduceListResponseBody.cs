// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class QueryProduceListResponseBody : TeaModel {
        [NameInMap("CurrentPageNum")]
        [Validation(Required=false)]
        public int? CurrentPageNum { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryProduceListResponseBodyData Data { get; set; }
        public class QueryProduceListResponseBodyData : TeaModel {
            [NameInMap("TmProduces")]
            [Validation(Required=false)]
            public List<QueryProduceListResponseBodyDataTmProduces> TmProduces { get; set; }
            public class QueryProduceListResponseBodyDataTmProduces : TeaModel {
                [NameInMap("AgreementId")]
                [Validation(Required=false)]
                public string AgreementId { get; set; }

                [NameInMap("BizId")]
                [Validation(Required=false)]
                public string BizId { get; set; }

                [NameInMap("Classification")]
                [Validation(Required=false)]
                public QueryProduceListResponseBodyDataTmProducesClassification Classification { get; set; }
                public class QueryProduceListResponseBodyDataTmProducesClassification : TeaModel {
                    [NameInMap("ClassificationCode")]
                    [Validation(Required=false)]
                    public string ClassificationCode { get; set; }

                    [NameInMap("ClassificationName")]
                    [Validation(Required=false)]
                    public string ClassificationName { get; set; }

                }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("LoaUrl")]
                [Validation(Required=false)]
                public string LoaUrl { get; set; }

                [NameInMap("MaterialName")]
                [Validation(Required=false)]
                public string MaterialName { get; set; }

                [NameInMap("Note")]
                [Validation(Required=false)]
                public string Note { get; set; }

                [NameInMap("OrderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                [NameInMap("OrderPrice")]
                [Validation(Required=false)]
                public float? OrderPrice { get; set; }

                [NameInMap("PrincipalName")]
                [Validation(Required=false)]
                public int? PrincipalName { get; set; }

                [NameInMap("ReceiptUrl")]
                [Validation(Required=false)]
                public string ReceiptUrl { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("SubmitCount")]
                [Validation(Required=false)]
                public int? SubmitCount { get; set; }

                [NameInMap("TmIcon")]
                [Validation(Required=false)]
                public string TmIcon { get; set; }

                [NameInMap("TmName")]
                [Validation(Required=false)]
                public string TmName { get; set; }

                [NameInMap("TmNumber")]
                [Validation(Required=false)]
                public string TmNumber { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

        [NameInMap("NextPage")]
        [Validation(Required=false)]
        public bool? NextPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PrePage")]
        [Validation(Required=false)]
        public bool? PrePage { get; set; }

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
