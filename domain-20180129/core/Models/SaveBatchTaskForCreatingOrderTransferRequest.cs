// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class SaveBatchTaskForCreatingOrderTransferRequest : TeaModel {
        [NameInMap("CouponNo")]
        [Validation(Required=false)]
        public string CouponNo { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("OrderTransferParam")]
        [Validation(Required=false)]
        public List<SaveBatchTaskForCreatingOrderTransferRequestOrderTransferParam> OrderTransferParam { get; set; }
        public class SaveBatchTaskForCreatingOrderTransferRequestOrderTransferParam : TeaModel {
            [NameInMap("AuthorizationCode")]
            [Validation(Required=false)]
            public string AuthorizationCode { get; set; }

            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            [NameInMap("PermitPremiumTransfer")]
            [Validation(Required=false)]
            public bool? PermitPremiumTransfer { get; set; }

            [NameInMap("RegistrantProfileId")]
            [Validation(Required=false)]
            public long? RegistrantProfileId { get; set; }

        }

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
