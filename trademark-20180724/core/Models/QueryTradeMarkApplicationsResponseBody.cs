// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class QueryTradeMarkApplicationsResponseBody : TeaModel {
        [NameInMap("CurrentPageNum")]
        [Validation(Required=false)]
        public int? CurrentPageNum { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryTradeMarkApplicationsResponseBodyData Data { get; set; }
        public class QueryTradeMarkApplicationsResponseBodyData : TeaModel {
            [NameInMap("TmProduces")]
            [Validation(Required=false)]
            public List<QueryTradeMarkApplicationsResponseBodyDataTmProduces> TmProduces { get; set; }
            public class QueryTradeMarkApplicationsResponseBodyDataTmProduces : TeaModel {
                [NameInMap("AgreementId")]
                [Validation(Required=false)]
                public string AgreementId { get; set; }

                [NameInMap("BizId")]
                [Validation(Required=false)]
                public string BizId { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("FirstClassification")]
                [Validation(Required=false)]
                public QueryTradeMarkApplicationsResponseBodyDataTmProducesFirstClassification FirstClassification { get; set; }
                public class QueryTradeMarkApplicationsResponseBodyDataTmProducesFirstClassification : TeaModel {
                    [NameInMap("ClassificationCode")]
                    [Validation(Required=false)]
                    public string ClassificationCode { get; set; }

                    [NameInMap("ClassificationName")]
                    [Validation(Required=false)]
                    public string ClassificationName { get; set; }

                }

                [NameInMap("Flags")]
                [Validation(Required=false)]
                public QueryTradeMarkApplicationsResponseBodyDataTmProducesFlags Flags { get; set; }
                public class QueryTradeMarkApplicationsResponseBodyDataTmProducesFlags : TeaModel {
                    [NameInMap("Flags")]
                    [Validation(Required=false)]
                    public List<string> Flags { get; set; }

                }

                [NameInMap("LoaUrl")]
                [Validation(Required=false)]
                public string LoaUrl { get; set; }

                [NameInMap("MaterialId")]
                [Validation(Required=false)]
                public long? MaterialId { get; set; }

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

                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("RenewResponse")]
                [Validation(Required=false)]
                public QueryTradeMarkApplicationsResponseBodyDataTmProducesRenewResponse RenewResponse { get; set; }
                public class QueryTradeMarkApplicationsResponseBodyDataTmProducesRenewResponse : TeaModel {
                    [NameInMap("Address")]
                    [Validation(Required=false)]
                    public string Address { get; set; }

                    [NameInMap("EngAddress")]
                    [Validation(Required=false)]
                    public string EngAddress { get; set; }

                    [NameInMap("EngName")]
                    [Validation(Required=false)]
                    public string EngName { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("RegisterTime")]
                    [Validation(Required=false)]
                    public long? RegisterTime { get; set; }

                    [NameInMap("SubmitSbjtime")]
                    [Validation(Required=false)]
                    public long? SubmitSbjtime { get; set; }

                }

                [NameInMap("ServicePrice")]
                [Validation(Required=false)]
                public float? ServicePrice { get; set; }

                [NameInMap("ShowGoToDefendButton")]
                [Validation(Required=false)]
                public bool? ShowGoToDefendButton { get; set; }

                [NameInMap("Specification")]
                [Validation(Required=false)]
                public int? Specification { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("SubmitAuditTime")]
                [Validation(Required=false)]
                public long? SubmitAuditTime { get; set; }

                [NameInMap("SubmitTime")]
                [Validation(Required=false)]
                public long? SubmitTime { get; set; }

                [NameInMap("SupplementId")]
                [Validation(Required=false)]
                public long? SupplementId { get; set; }

                [NameInMap("SupplementStatus")]
                [Validation(Required=false)]
                public int? SupplementStatus { get; set; }

                [NameInMap("SystemVersion")]
                [Validation(Required=false)]
                public string SystemVersion { get; set; }

                [NameInMap("ThirdClassification")]
                [Validation(Required=false)]
                public QueryTradeMarkApplicationsResponseBodyDataTmProducesThirdClassification ThirdClassification { get; set; }
                public class QueryTradeMarkApplicationsResponseBodyDataTmProducesThirdClassification : TeaModel {
                    [NameInMap("ThirdClassifications")]
                    [Validation(Required=false)]
                    public List<QueryTradeMarkApplicationsResponseBodyDataTmProducesThirdClassificationThirdClassifications> ThirdClassifications { get; set; }
                    public class QueryTradeMarkApplicationsResponseBodyDataTmProducesThirdClassificationThirdClassifications : TeaModel {
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

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

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
