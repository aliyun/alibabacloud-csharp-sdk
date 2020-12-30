// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class SaveBatchTaskForCreatingOrderActivateRequest : TeaModel {
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

        [NameInMap("OrderActivateParam")]
        [Validation(Required=false)]
        public List<SaveBatchTaskForCreatingOrderActivateRequestOrderActivateParam> OrderActivateParam { get; set; }
        public class SaveBatchTaskForCreatingOrderActivateRequestOrderActivateParam : TeaModel {
            [NameInMap("TelExt")]
            [Validation(Required=false)]
            public string TelExt { get; set; }

            [NameInMap("AliyunDns")]
            [Validation(Required=false)]
            public bool? AliyunDns { get; set; }

            [NameInMap("PermitPremiumActivation")]
            [Validation(Required=false)]
            public bool? PermitPremiumActivation { get; set; }

            [NameInMap("ZhProvince")]
            [Validation(Required=false)]
            public string ZhProvince { get; set; }

            [NameInMap("Telephone")]
            [Validation(Required=false)]
            public string Telephone { get; set; }

            [NameInMap("RegistrantOrganization")]
            [Validation(Required=false)]
            public string RegistrantOrganization { get; set; }

            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }

            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            [NameInMap("ZhCity")]
            [Validation(Required=false)]
            public string ZhCity { get; set; }

            [NameInMap("Dns1")]
            [Validation(Required=false)]
            public string Dns1 { get; set; }

            [NameInMap("TelArea")]
            [Validation(Required=false)]
            public string TelArea { get; set; }

            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            [NameInMap("EnableDomainProxy")]
            [Validation(Required=false)]
            public bool? EnableDomainProxy { get; set; }

            [NameInMap("PostalCode")]
            [Validation(Required=false)]
            public string PostalCode { get; set; }

            [NameInMap("RegistrantProfileId")]
            [Validation(Required=false)]
            public long? RegistrantProfileId { get; set; }

            [NameInMap("ZhRegistrantOrganization")]
            [Validation(Required=false)]
            public string ZhRegistrantOrganization { get; set; }

            [NameInMap("TrademarkDomainActivation")]
            [Validation(Required=false)]
            public bool? TrademarkDomainActivation { get; set; }

            [NameInMap("Dns2")]
            [Validation(Required=false)]
            public string Dns2 { get; set; }

            [NameInMap("ZhRegistrantName")]
            [Validation(Required=false)]
            public string ZhRegistrantName { get; set; }

            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("RegistrantType")]
            [Validation(Required=false)]
            public string RegistrantType { get; set; }

            [NameInMap("Country")]
            [Validation(Required=false)]
            public string Country { get; set; }

            [NameInMap("RegistrantName")]
            [Validation(Required=false)]
            public string RegistrantName { get; set; }

            [NameInMap("SubscriptionDuration")]
            [Validation(Required=false)]
            public int? SubscriptionDuration { get; set; }

            [NameInMap("ZhAddress")]
            [Validation(Required=false)]
            public string ZhAddress { get; set; }

            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }

        }

    }

}
