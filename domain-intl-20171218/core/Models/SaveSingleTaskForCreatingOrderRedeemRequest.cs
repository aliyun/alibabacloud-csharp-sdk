// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain_intl20171218.Models
{
    public class SaveSingleTaskForCreatingOrderRedeemRequest : TeaModel {
        [NameInMap("CouponNo")]
        [Validation(Required=false)]
        public string CouponNo { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("CurrentExpirationDate")]
        [Validation(Required=false)]
        public long? CurrentExpirationDate { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("PromotionNo")]
        [Validation(Required=false)]
        public string PromotionNo { get; set; }

        [NameInMap("UseCoupon")]
        [Validation(Required=false)]
        public bool? UseCoupon { get; set; }

        [NameInMap("UsePromotion")]
        [Validation(Required=false)]
        public bool? UsePromotion { get; set; }

        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
