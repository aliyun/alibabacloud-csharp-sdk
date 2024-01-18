// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class CreateOutDiscountOrderWithDesignatedTbUidRequest : TeaModel {
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("BuyerMessages")]
        [Validation(Required=false)]
        public string BuyerMessages { get; set; }

        [NameInMap("DeliveryAddress")]
        [Validation(Required=false)]
        public string DeliveryAddress { get; set; }

        [NameInMap("DeliveryInfo")]
        [Validation(Required=false)]
        public string DeliveryInfo { get; set; }

        [NameInMap("ExtInfo")]
        [Validation(Required=false)]
        public string ExtInfo { get; set; }

        [NameInMap("OrderExpireTime")]
        [Validation(Required=false)]
        public long? OrderExpireTime { get; set; }

        [NameInMap("OrderItems")]
        [Validation(Required=false)]
        public string OrderItems { get; set; }

        [NameInMap("OutDiscountInfos")]
        [Validation(Required=false)]
        public string OutDiscountInfos { get; set; }

        [NameInMap("OutTradeId")]
        [Validation(Required=false)]
        public string OutTradeId { get; set; }

        [NameInMap("TbAccountType")]
        [Validation(Required=false)]
        public string TbAccountType { get; set; }

        [NameInMap("TbUserId")]
        [Validation(Required=false)]
        public long? TbUserId { get; set; }

        [NameInMap("ThirdPartyUserId")]
        [Validation(Required=false)]
        public string ThirdPartyUserId { get; set; }

    }

}
