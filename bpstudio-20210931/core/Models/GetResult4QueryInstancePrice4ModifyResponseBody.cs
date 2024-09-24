// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BPStudio20210931.Models
{
    public class GetResult4QueryInstancePrice4ModifyResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetResult4QueryInstancePrice4ModifyResponseBodyData Data { get; set; }
        public class GetResult4QueryInstancePrice4ModifyResponseBodyData : TeaModel {
            [NameInMap("PriceList")]
            [Validation(Required=false)]
            public List<GetResult4QueryInstancePrice4ModifyResponseBodyDataPriceList> PriceList { get; set; }
            public class GetResult4QueryInstancePrice4ModifyResponseBodyDataPriceList : TeaModel {
                [NameInMap("DiscountAmount")]
                [Validation(Required=false)]
                public double? DiscountAmount { get; set; }

                [NameInMap("Error")]
                [Validation(Required=false)]
                public string Error { get; set; }

                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                [NameInMap("OriginalAmount")]
                [Validation(Required=false)]
                public double? OriginalAmount { get; set; }

                [NameInMap("PriceUnit")]
                [Validation(Required=false)]
                public string PriceUnit { get; set; }

                [NameInMap("PromotionName")]
                [Validation(Required=false)]
                public string PromotionName { get; set; }

                [NameInMap("TradeAmount")]
                [Validation(Required=false)]
                public double? TradeAmount { get; set; }

            }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
