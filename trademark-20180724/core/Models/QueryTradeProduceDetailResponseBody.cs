// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class QueryTradeProduceDetailResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryTradeProduceDetailResponseBodyData Data { get; set; }
        public class QueryTradeProduceDetailResponseBodyData : TeaModel {
            [NameInMap("AllowCancel")]
            [Validation(Required=false)]
            public bool? AllowCancel { get; set; }

            [NameInMap("BizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            [NameInMap("BuyerStatus")]
            [Validation(Required=false)]
            public int? BuyerStatus { get; set; }

            [NameInMap("Classification")]
            [Validation(Required=false)]
            public string Classification { get; set; }

            [NameInMap("ConfiscateAmount")]
            [Validation(Required=false)]
            public float? ConfiscateAmount { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("ExclusiveDateLimit")]
            [Validation(Required=false)]
            public string ExclusiveDateLimit { get; set; }

            [NameInMap("Extend")]
            [Validation(Required=false)]
            public Dictionary<string, object> Extend { get; set; }

            [NameInMap("FinalAmount")]
            [Validation(Required=false)]
            public float? FinalAmount { get; set; }

            [NameInMap("Icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            [NameInMap("OperateNote")]
            [Validation(Required=false)]
            public string OperateNote { get; set; }

            [NameInMap("PaidAmount")]
            [Validation(Required=false)]
            public float? PaidAmount { get; set; }

            [NameInMap("PreAmount")]
            [Validation(Required=false)]
            public float? PreAmount { get; set; }

            [NameInMap("PreOrderId")]
            [Validation(Required=false)]
            public string PreOrderId { get; set; }

            [NameInMap("RefundAmount")]
            [Validation(Required=false)]
            public float? RefundAmount { get; set; }

            [NameInMap("RegisterNumber")]
            [Validation(Required=false)]
            public string RegisterNumber { get; set; }

            [NameInMap("Share")]
            [Validation(Required=false)]
            public string Share { get; set; }

            [NameInMap("Source")]
            [Validation(Required=false)]
            public int? Source { get; set; }

            [NameInMap("ThirdCode")]
            [Validation(Required=false)]
            public string ThirdCode { get; set; }

            [NameInMap("TmName")]
            [Validation(Required=false)]
            public string TmName { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
