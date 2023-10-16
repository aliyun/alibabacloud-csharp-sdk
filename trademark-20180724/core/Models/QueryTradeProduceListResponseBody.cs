// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class QueryTradeProduceListResponseBody : TeaModel {
        [NameInMap("CurrentPageNum")]
        [Validation(Required=false)]
        public int? CurrentPageNum { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryTradeProduceListResponseBodyData Data { get; set; }
        public class QueryTradeProduceListResponseBodyData : TeaModel {
            [NameInMap("TradeProduces")]
            [Validation(Required=false)]
            public List<QueryTradeProduceListResponseBodyDataTradeProduces> TradeProduces { get; set; }
            public class QueryTradeProduceListResponseBodyDataTradeProduces : TeaModel {
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

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("FailReason")]
                [Validation(Required=false)]
                public int? FailReason { get; set; }

                [NameInMap("FinalAmount")]
                [Validation(Required=false)]
                public float? FinalAmount { get; set; }

                [NameInMap("Icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                [NameInMap("OperateNote")]
                [Validation(Required=false)]
                public string OperateNote { get; set; }

                [NameInMap("PreAmount")]
                [Validation(Required=false)]
                public float? PreAmount { get; set; }

                [NameInMap("PreOrderId")]
                [Validation(Required=false)]
                public string PreOrderId { get; set; }

                [NameInMap("RegisterNumber")]
                [Validation(Required=false)]
                public string RegisterNumber { get; set; }

                [NameInMap("Source")]
                [Validation(Required=false)]
                public int? Source { get; set; }

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
