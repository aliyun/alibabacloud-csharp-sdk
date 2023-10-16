// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class QueryTmSbjProduceResponseBody : TeaModel {
        [NameInMap("Moudle")]
        [Validation(Required=false)]
        public QueryTmSbjProduceResponseBodyMoudle Moudle { get; set; }
        public class QueryTmSbjProduceResponseBodyMoudle : TeaModel {
            [NameInMap("TmSbjProduceList")]
            [Validation(Required=false)]
            public List<QueryTmSbjProduceResponseBodyMoudleTmSbjProduceList> TmSbjProduceList { get; set; }
            public class QueryTmSbjProduceResponseBodyMoudleTmSbjProduceList : TeaModel {
                [NameInMap("BitFlag")]
                [Validation(Required=false)]
                public long? BitFlag { get; set; }

                [NameInMap("BizId")]
                [Validation(Required=false)]
                public string BizId { get; set; }

                [NameInMap("ClassificationCode")]
                [Validation(Required=false)]
                public string ClassificationCode { get; set; }

                [NameInMap("DeleteFlag")]
                [Validation(Required=false)]
                public string DeleteFlag { get; set; }

                [NameInMap("Env")]
                [Validation(Required=false)]
                public string Env { get; set; }

                [NameInMap("Extend")]
                [Validation(Required=false)]
                public QueryTmSbjProduceResponseBodyMoudleTmSbjProduceListExtend Extend { get; set; }
                public class QueryTmSbjProduceResponseBodyMoudleTmSbjProduceListExtend : TeaModel {
                    [NameInMap("Bid")]
                    [Validation(Required=false)]
                    public long? Bid { get; set; }

                    [NameInMap("BlackIcon")]
                    [Validation(Required=false)]
                    public bool? BlackIcon { get; set; }

                    [NameInMap("LoaOssKey")]
                    [Validation(Required=false)]
                    public string LoaOssKey { get; set; }

                    [NameInMap("LogoGoodsId")]
                    [Validation(Required=false)]
                    public string LogoGoodsId { get; set; }

                    [NameInMap("MaterialId")]
                    [Validation(Required=false)]
                    public string MaterialId { get; set; }

                    [NameInMap("SubmitCount")]
                    [Validation(Required=false)]
                    public long? SubmitCount { get; set; }

                    [NameInMap("TmNametype")]
                    [Validation(Required=false)]
                    public long? TmNametype { get; set; }

                }

                [NameInMap("LoaId")]
                [Validation(Required=false)]
                public long? LoaId { get; set; }

                [NameInMap("MainOrderId")]
                [Validation(Required=false)]
                public string MainOrderId { get; set; }

                [NameInMap("MaterialId")]
                [Validation(Required=false)]
                public long? MaterialId { get; set; }

                [NameInMap("MaterialName")]
                [Validation(Required=false)]
                public string MaterialName { get; set; }

                [NameInMap("OrderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                [NameInMap("OrderPrice")]
                [Validation(Required=false)]
                public float? OrderPrice { get; set; }

                [NameInMap("PrincipalKey")]
                [Validation(Required=false)]
                public string PrincipalKey { get; set; }

                [NameInMap("PrincipalName")]
                [Validation(Required=false)]
                public string PrincipalName { get; set; }

                [NameInMap("ProductType")]
                [Validation(Required=false)]
                public string ProductType { get; set; }

                [NameInMap("RiskSource")]
                [Validation(Required=false)]
                public string RiskSource { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("SubmitAuditTime")]
                [Validation(Required=false)]
                public long? SubmitAuditTime { get; set; }

                [NameInMap("SubmitStatus")]
                [Validation(Required=false)]
                public string SubmitStatus { get; set; }

                [NameInMap("SubmitTime")]
                [Validation(Required=false)]
                public long? SubmitTime { get; set; }

                [NameInMap("SubmitTimes")]
                [Validation(Required=false)]
                public long? SubmitTimes { get; set; }

                [NameInMap("TmCode")]
                [Validation(Required=false)]
                public string TmCode { get; set; }

                [NameInMap("TmIcon")]
                [Validation(Required=false)]
                public string TmIcon { get; set; }

                [NameInMap("TmName")]
                [Validation(Required=false)]
                public string TmName { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
