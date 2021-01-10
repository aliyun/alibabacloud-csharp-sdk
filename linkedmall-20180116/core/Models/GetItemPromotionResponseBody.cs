// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class GetItemPromotionResponseBody : TeaModel {
        [NameInMap("ItemPromotionModel")]
        [Validation(Required=false)]
        public GetItemPromotionResponseBodyItemPromotionModel ItemPromotionModel { get; set; }
        public class GetItemPromotionResponseBodyItemPromotionModel : TeaModel {
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }
            [NameInMap("SkuPromotion")]
            [Validation(Required=false)]
            public Dictionary<string, string> SkuPromotion { get; set; }
            [NameInMap("PromotionFlag")]
            [Validation(Required=false)]
            public bool? PromotionFlag { get; set; }
            [NameInMap("PromotionName")]
            [Validation(Required=false)]
            public string PromotionName { get; set; }
            [NameInMap("LmItemId")]
            [Validation(Required=false)]
            public string LmItemId { get; set; }
            [NameInMap("PromotionDesc")]
            [Validation(Required=false)]
            public string PromotionDesc { get; set; }
            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public long? ItemId { get; set; }
            [NameInMap("PromotionId")]
            [Validation(Required=false)]
            public string PromotionId { get; set; }
            [NameInMap("ExtInfo")]
            [Validation(Required=false)]
            public Dictionary<string, string> ExtInfo { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("SubMessage")]
        [Validation(Required=false)]
        public string SubMessage { get; set; }

        [NameInMap("SubCode")]
        [Validation(Required=false)]
        public string SubCode { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
