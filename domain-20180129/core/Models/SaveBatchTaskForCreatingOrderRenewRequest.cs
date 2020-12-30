// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class SaveBatchTaskForCreatingOrderRenewRequest : TeaModel {
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("CouponNo")]
        [Validation(Required=false)]
        public string CouponNo { get; set; }

        [NameInMap("UseCoupon")]
        [Validation(Required=false)]
        public bool? UseCoupon { get; set; }

        [NameInMap("PromotionNo")]
        [Validation(Required=false)]
        public string PromotionNo { get; set; }

        [NameInMap("UsePromotion")]
        [Validation(Required=false)]
        public bool? UsePromotion { get; set; }

        [NameInMap("OrderRenewParam")]
        [Validation(Required=false)]
        public List<SaveBatchTaskForCreatingOrderRenewRequestOrderRenewParam> OrderRenewParam { get; set; }
        public class SaveBatchTaskForCreatingOrderRenewRequestOrderRenewParam : TeaModel {
            [NameInMap("SubscriptionDuration")]
            [Validation(Required=false)]
            public int? SubscriptionDuration { get; set; }

            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            [NameInMap("CurrentExpirationDate")]
            [Validation(Required=false)]
            public long? CurrentExpirationDate { get; set; }

        }

    }

}
